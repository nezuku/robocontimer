'
'   Robocon Timer
'   Copyright (C) 2005-2013 Attun
'
'   Licensed under the Apache License, Version 2.0 (the "License");
'   you may not use this file except in compliance with the License.
'   You may obtain a copy of the License at
'
'       http://www.apache.org/licenses/LICENSE-2.0
'
'   Unless required by applicable law or agreed to in writing, software
'   distributed under the License is distributed on an "AS IS" BASIS,
'   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
'   See the License for the specific language governing permissions and
'   limitations under the License.
'

Imports System
Imports System.Timers
Imports System.Diagnostics

Public Class frmMain
    '時間関連の変数は10ms単位
    '設定した試合時間
    Public intGameTimeNormal, intGameTimeExtend, intGameTimeSetting As Integer
    'カウント方向
    Private bCountDirection As Boolean
    Private Enum enmCountDirection
        mCountDown = False
        mCountUp = True
    End Enum
    '設定時間後もタイマー継続
    Private bCountAfterTimeUp As Boolean
    '桁数自動非表示
    Private bHideDigitZero As Boolean
    '音を鳴らした回数
    Private intBeepCount As Integer
    '残り時間
    Private intReminTime, intCountDownTime As Integer
    'スコア
    Private intScoreRed, intScoreBlue As Integer
    '初期スコア
    Private intInitScoreRed, intInitScoreBlue As Integer
    'ステータス欄に表示させるテキスト
    Public strStatusText As String
    '現在のタイマーのモード
    Private Enum enmMode
        mNotInit     '初期化されていない
        mNormal      '通常時
        mExtend      '延長戦
        mSetting     'セッティングタイム
    End Enum
    Private staMode As enmMode

    '現在のタイマーのモード
    Private Enum enmState
        sNotInit     '初期化されていない
        sStop       '初期化されていない
        sCountdown  'カウントダウン
        sWorking       '動作中
    End Enum
    Private staState As enmState

    'タイマーオブジェクト
    Private Timer As System.Timers.Timer
    '高精度タイマーオブジェクト
    Private HTimer, HTimerC As New Stopwatch
    'サウンド再生
    Private sndBeepLow As New System.Media.SoundPlayer(My.Resources.sndLow)
    Private sndBeepHigh As New System.Media.SoundPlayer(My.Resources.sndHigh)
    Private sndBeepPi As New System.Media.SoundPlayer(My.Resources.sndPi)

    '初期化を行う
    Private Sub Init()
        staState = enmMode.mNotInit
        staMode = enmMode.mNotInit

        'タイマー
        Timer = New System.Timers.Timer(50)
        'サウンドのロード
        sndBeepHigh.Load()
        sndBeepLow.Load()
        sndBeepPi.Load()
        '時間関連
        intGameTimeNormal = 180
        intGameTimeExtend = 60
        intGameTimeSetting = 60
        'カウント方向
        bCountDirection = enmCountDirection.mCountDown
        'スコア
        intScoreBlue = 0
        intScoreRed = 0
        intInitScoreBlue = 0
        intInitScoreRed = 0

        ''タイマー周り

        '高精度タイマーが使えるか判断します
        If Not Stopwatch.IsHighResolution Then
            MessageBox.Show("高精度タイマーが使えません。終了します。")
            End
        End If

        'タイマーをリセット
        staState = enmState.sStop
        staMode = enmMode.mNormal
        TimerReset()
    End Sub

    'タイマーの表示をリセットします。
    Private Sub TimerReset()
        TimerStop()
        sndBeepHigh.Load() 'サウンドのリロード
        sndBeepLow.Load()
        sndBeepPi.Load()
        HTimer.Reset()  'タイマーを両方リセットします
        HTimerC.Reset()
        Select Case staMode
            Case enmMode.mNormal
                intReminTime = intGameTimeNormal * 1000
                intCountDownTime = 500
                strStatusText = My.Resources.STATUS_READY
            Case enmMode.mExtend
                intReminTime = intGameTimeExtend * 1000
                intCountDownTime = 500
                strStatusText = My.Resources.STATUS_EXTEND
            Case enmMode.mSetting
                intReminTime = intGameTimeSetting * 1000
                strStatusText = My.Resources.STATUS_SETTING
        End Select
        UpdateDisplay()
    End Sub

    '通常のタイマーの動作を開始させる
    Private Sub TimerStart()
        pgbWork.Style = ProgressBarStyle.Marquee
        strStatusText = ""
        staState = enmState.sWorking
        HTimer.Start() 'タイマーを動作させる
        tmrDisplayUpdater.Enabled = True
    End Sub

    'カウントダウンタイマーのスタート
    'ステートをカウントダウンへ設定してタイマーを動作させる
    Private Sub TimerCountDown()
        strStatusText = ""
        TimerReset()
        intCountDownTime = 5000
        intBeepCount = 0
        staState = enmState.sCountdown
        UpdateDisplay()
        HTimerC.Start()  'カウントダウンタイマーを動作させる
        tmrDisplayUpdater.Enabled = True
    End Sub

    'タイマーを止めます。
    Private Sub TimerStop()
        pgbWork.Style = ProgressBarStyle.Blocks
        strStatusText = My.Resources.STATUS_STOP
        staState = enmState.sStop
        HTimer.Stop()
        HTimerC.Stop()
        tmrDisplayUpdater.Enabled = False
        UpdateDisplay()
    End Sub

    '表示内容の更新
    Public Sub UpdateDisplay()
        Dim intDisplayTimeBase As Integer

        '表示させる残り時間のベースとなる値
        If (bCountDirection = enmCountDirection.mCountDown) Then
            'カウントダウンの場合: 制限時間から経過時間を引いたもの
            intDisplayTimeBase = intReminTime - HTimer.ElapsedMilliseconds
            If intDisplayTimeBase < 0 Then intDisplayTimeBase = 0
        Else
            'カウントアップの場合: 経過時間をそのまま表示
            intDisplayTimeBase = HTimer.ElapsedMilliseconds
            If intDisplayTimeBase < 0 Then intDisplayTimeBase = 0
        End If

        '各桁のアップデート
        lblMin.Text = intDisplayTimeBase \ 60000
        lblS10.Text = intDisplayTimeBase \ 10000 Mod 6
        lblS1.Text = intDisplayTimeBase \ 1000 Mod 10
        lblM.Text = intDisplayTimeBase \ 100 Mod 10
        '1分以下の場合、分とコロンを非表示
        lblMin.Visible = (intDisplayTimeBase >= 60000)
        picDot1.Visible = (intDisplayTimeBase >= 60000)
        picDot2.Visible = (intDisplayTimeBase >= 60000)
        '10秒以下の場合、10秒を非表示
        lblS10.Visible = (intDisplayTimeBase >= 10000)
        'スコア
        lblScoreBlue.Text = intScoreBlue
        lblScoreRed.Text = intScoreRed
        'ステータス
        lblStatus.Text = strStatusText
    End Sub

    Private Sub KeyHandler(ByVal e As System.Windows.Forms.KeyEventArgs)
        Select Case e.KeyCode
            'スコア関連
            Case Keys.Q
                intScoreRed += 1
            Case Keys.A
                intScoreRed -= 1
            Case Keys.Z
                intScoreRed = intInitScoreRed
            Case Keys.E
                intScoreBlue += 1
            Case Keys.D
                intScoreBlue -= 1
            Case Keys.C
                intScoreBlue = intInitScoreBlue
            Case Keys.Y 'セッティング
                staMode = enmMode.mSetting
                TimerReset()
            Case Keys.U '通常スタート
                staMode = enmMode.mNormal
                TimerReset()
            Case Keys.I '延長戦
                staMode = enmMode.mExtend
                TimerReset()
            Case Keys.Escape 'タイマーリセットのみ
                TimerReset()
            Case Keys.Space 'タイマースタートストップ
                If staState = enmState.sCountdown Then 'カウントダウン中のストップはリセット扱い
                    TimerReset()
                ElseIf staState = enmState.sStop Then
                    TimerStart()
                Else
                    TimerStop()
                End If
            Case Keys.Enter     '停止時のみ有効:カウントダウンスタート
                If staState = enmState.sStop Then TimerCountDown()
            Case Keys.Tab
                OpenOptions()
            Case Keys.F1
                OpenHelp()
            Case Keys.B '簡易ホイッスル
                sndBeepPi.Play()
        End Select
        If intScoreBlue < -100 Then intScoreBlue = -100
        If intScoreBlue > 100 Then intScoreBlue = 100
        If intScoreRed < -100 Then intScoreRed = -100
        If intScoreRed > 100 Then intScoreRed = 100
        UpdateDisplay()
    End Sub

    Private Sub frmMain_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        'MsgBox(Asc(e.KeyCode)) ' for debugging
        KeyHandler(e)
    End Sub

    Private Sub frmMain_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Init()
    End Sub

    Private Sub OpenOptions()
        'タイマーを止めます
        TimerStop()

        '現在の設定をフォームに転送
        With frmOptions
            .nudNormal.Value = intGameTimeNormal
            .nudExtend.Value = intGameTimeExtend
            .nudSetting.Value = intGameTimeSetting
            .nudBlue.Value = intInitScoreBlue
            .nudRed.Value = intInitScoreRed
            .rabCountDown.Checked = Not bCountDirection
            .rabCountUp.Checked = bCountDirection
        End With
        'OKボタンを押したならば設定を反映させる
        If frmOptions.ShowDialog() = Windows.Forms.DialogResult.OK Then
            With frmOptions
                intGameTimeNormal = .nudNormal.Value
                intGameTimeExtend = .nudExtend.Value
                intGameTimeSetting = .nudSetting.Value
                intInitScoreBlue = .nudBlue.Value
                intInitScoreRed = .nudRed.Value
                If (.rabCountDown.Checked) Then
                    bCountDirection = enmCountDirection.mCountDown
                Else
                    bCountDirection = enmCountDirection.mCountUp
                End If
            End With
            'タイマーを通常モードでリセットさせます。
            TimerReset()
        End If
    End Sub

    Private Sub OpenHelp()
        'タイマーを止めます
        TimerStop()
        'ヘルプダイアログを表示します
        frmHelp.ShowDialog()
    End Sub

    Private Sub tmrDisplayUpdater_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrDisplayUpdater.Tick
        '現在の状態にあわせて分岐
        Select Case staState
            Case enmState.sCountdown    'カウントダウン中
                If staMode = enmMode.mSetting Then  'セッティングの場合は
                    sndBeepPi.Play()                '笛を鳴らすだけで
                    HTimerC.Stop()
                    TimerStart()                    '通常のタイマーをスタート
                Else
                    If intCountDownTime < HTimerC.ElapsedMilliseconds Then       'カウントダウンが0になったら
                        sndBeepHigh.Play()              '高い音
                        intBeepCount = 0                'ビープを鳴らした回数をリセット
                        TimerStart()
                    ElseIf (intCountDownTime - HTimerC.ElapsedMilliseconds) < 3000 - intBeepCount * 1000 Then
                        strStatusText = (intCountDownTime - HTimerC.ElapsedMilliseconds) \ 1000 + 1  '3…2…1…のテキスト更新
                        sndBeepLow.Play()                       '低い音
                        intBeepCount += 1
                    End If
                End If

            Case enmState.sWorking      '通常動作中
                'スタートから5秒間は"START"を表示
                If HTimer.ElapsedMilliseconds < 5000 Then strStatusText = My.Resources.STATUS_START Else strStatusText = ""

                '通常・延長モード固有の動作
                If (staMode = enmMode.mExtend) Or (staMode = enmMode.mNormal) Then
                    'カウントダウン
                    If (intReminTime - HTimer.ElapsedMilliseconds) < 10000 - intBeepCount * 1000 Then
                        sndBeepLow.Play()                       '低い音
                        intBeepCount += 1
                    End If
                End If

                '時間切れになったら
                If HTimer.ElapsedMilliseconds > intReminTime Then
                    'タイマーを止める
                    staState = enmState.sStop
                    TimerStop()
                    '音を鳴らす
                    If staMode = enmMode.mSetting Then
                        sndBeepPi.Play()
                    Else
                        sndBeepHigh.Play()
                    End If
                End If
        End Select
        '停止時と未初期化時は何もしません。

        UpdateDisplay()
    End Sub
End Class
