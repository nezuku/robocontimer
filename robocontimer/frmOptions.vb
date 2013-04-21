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

Imports System.Windows.Forms

Public Class frmOptions

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        '値の妥当性の確認
        If Not ((nudNormal.Value >= 10) And (nudNormal.Value <= 600) _
        And (nudExtend.Value >= 10) And (nudExtend.Value <= 600) _
        And (nudSetting.Value >= 10) And (nudSetting.Value <= 600)) Then
            MessageBox.Show("値が不正です。各試合時間の範囲は整数で10～600秒の間で設定できます。", "値が不正です", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub btnAbout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAbout.Click
        frmAbout.ShowDialog()
    End Sub

    Private Sub btnHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHelp.Click
        frmHelp.ShowDialog()
    End Sub
End Class
