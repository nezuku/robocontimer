<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOptions
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows フォーム デザイナで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナで必要です。
    'Windows フォーム デザイナを使用して変更できます。  
    'コード エディタを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.btnHelp = New System.Windows.Forms.Button()
        Me.btnAbout = New System.Windows.Forms.Button()
        Me.grpGameTime = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.nudSetting = New System.Windows.Forms.NumericUpDown()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.nudExtend = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblSec = New System.Windows.Forms.Label()
        Me.nudNormal = New System.Windows.Forms.NumericUpDown()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.grpInitScore = New System.Windows.Forms.GroupBox()
        Me.nudBlue = New System.Windows.Forms.NumericUpDown()
        Me.lblBlue = New System.Windows.Forms.Label()
        Me.nudRed = New System.Windows.Forms.NumericUpDown()
        Me.lblRed = New System.Windows.Forms.Label()
        Me.grpCountDirection = New System.Windows.Forms.GroupBox()
        Me.rabCountDown = New System.Windows.Forms.RadioButton()
        Me.rabCountUp = New System.Windows.Forms.RadioButton()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.grpGameTime.SuspendLayout()
        CType(Me.nudSetting, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudExtend, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudNormal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpInitScore.SuspendLayout()
        CType(Me.nudBlue, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudRed, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpCountDirection.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 4
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnHelp, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnAbout, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(12, 223)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(321, 27)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(247, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(67, 21)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "キャンセル"
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Location = New System.Drawing.Point(166, 3)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(67, 21)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "OK"
        '
        'btnHelp
        '
        Me.btnHelp.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnHelp.Location = New System.Drawing.Point(86, 3)
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.Size = New System.Drawing.Size(67, 21)
        Me.btnHelp.TabIndex = 3
        Me.btnHelp.Text = "ヘルプ(&H)..."
        '
        'btnAbout
        '
        Me.btnAbout.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnAbout.Location = New System.Drawing.Point(6, 3)
        Me.btnAbout.Name = "btnAbout"
        Me.btnAbout.Size = New System.Drawing.Size(67, 21)
        Me.btnAbout.TabIndex = 2
        Me.btnAbout.Text = "情報(&A)..."
        '
        'grpGameTime
        '
        Me.grpGameTime.Controls.Add(Me.Label3)
        Me.grpGameTime.Controls.Add(Me.nudSetting)
        Me.grpGameTime.Controls.Add(Me.Label4)
        Me.grpGameTime.Controls.Add(Me.Label1)
        Me.grpGameTime.Controls.Add(Me.nudExtend)
        Me.grpGameTime.Controls.Add(Me.Label2)
        Me.grpGameTime.Controls.Add(Me.lblSec)
        Me.grpGameTime.Controls.Add(Me.nudNormal)
        Me.grpGameTime.Controls.Add(Me.lblTime)
        Me.grpGameTime.Location = New System.Drawing.Point(12, 12)
        Me.grpGameTime.Name = "grpGameTime"
        Me.grpGameTime.Size = New System.Drawing.Size(321, 104)
        Me.grpGameTime.TabIndex = 2
        Me.grpGameTime.TabStop = False
        Me.grpGameTime.Text = "時間の長さ"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(226, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(17, 12)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "秒"
        '
        'nudSetting
        '
        Me.nudSetting.Location = New System.Drawing.Point(152, 76)
        Me.nudSetting.Maximum = New Decimal(New Integer() {600, 0, 0, 0})
        Me.nudSetting.Minimum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.nudSetting.Name = "nudSetting"
        Me.nudSetting.Size = New System.Drawing.Size(68, 19)
        Me.nudSetting.TabIndex = 15
        Me.nudSetting.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.nudSetting.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(78, 78)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 12)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "セッティング(&S):"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(226, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(17, 12)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "秒"
        '
        'nudExtend
        '
        Me.nudExtend.Location = New System.Drawing.Point(152, 43)
        Me.nudExtend.Maximum = New Decimal(New Integer() {600, 0, 0, 0})
        Me.nudExtend.Minimum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.nudExtend.Name = "nudExtend"
        Me.nudExtend.Size = New System.Drawing.Size(68, 19)
        Me.nudExtend.TabIndex = 12
        Me.nudExtend.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.nudExtend.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(78, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 12)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "延長戦(&E):"
        '
        'lblSec
        '
        Me.lblSec.AutoSize = True
        Me.lblSec.Location = New System.Drawing.Point(226, 20)
        Me.lblSec.Name = "lblSec"
        Me.lblSec.Size = New System.Drawing.Size(17, 12)
        Me.lblSec.TabIndex = 10
        Me.lblSec.Text = "秒"
        '
        'nudNormal
        '
        Me.nudNormal.Location = New System.Drawing.Point(152, 18)
        Me.nudNormal.Maximum = New Decimal(New Integer() {600, 0, 0, 0})
        Me.nudNormal.Minimum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.nudNormal.Name = "nudNormal"
        Me.nudNormal.Size = New System.Drawing.Size(68, 19)
        Me.nudNormal.TabIndex = 9
        Me.nudNormal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.nudNormal.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.Location = New System.Drawing.Point(78, 20)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(47, 12)
        Me.lblTime.TabIndex = 8
        Me.lblTime.Text = "通常(&N):"
        '
        'grpInitScore
        '
        Me.grpInitScore.Controls.Add(Me.nudBlue)
        Me.grpInitScore.Controls.Add(Me.lblBlue)
        Me.grpInitScore.Controls.Add(Me.nudRed)
        Me.grpInitScore.Controls.Add(Me.lblRed)
        Me.grpInitScore.Location = New System.Drawing.Point(12, 122)
        Me.grpInitScore.Name = "grpInitScore"
        Me.grpInitScore.Size = New System.Drawing.Size(321, 45)
        Me.grpInitScore.TabIndex = 3
        Me.grpInitScore.TabStop = False
        Me.grpInitScore.Text = "リセット時の得点"
        '
        'nudBlue
        '
        Me.nudBlue.Location = New System.Drawing.Point(216, 18)
        Me.nudBlue.Minimum = New Decimal(New Integer() {100, 0, 0, -2147483648})
        Me.nudBlue.Name = "nudBlue"
        Me.nudBlue.Size = New System.Drawing.Size(68, 19)
        Me.nudBlue.TabIndex = 19
        Me.nudBlue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblBlue
        '
        Me.lblBlue.AutoSize = True
        Me.lblBlue.Location = New System.Drawing.Point(175, 20)
        Me.lblBlue.Name = "lblBlue"
        Me.lblBlue.Size = New System.Drawing.Size(35, 12)
        Me.lblBlue.TabIndex = 18
        Me.lblBlue.Text = "青(&B):"
        '
        'nudRed
        '
        Me.nudRed.Location = New System.Drawing.Point(77, 18)
        Me.nudRed.Minimum = New Decimal(New Integer() {100, 0, 0, -2147483648})
        Me.nudRed.Name = "nudRed"
        Me.nudRed.Size = New System.Drawing.Size(68, 19)
        Me.nudRed.TabIndex = 17
        Me.nudRed.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblRed
        '
        Me.lblRed.AutoSize = True
        Me.lblRed.Location = New System.Drawing.Point(36, 20)
        Me.lblRed.Name = "lblRed"
        Me.lblRed.Size = New System.Drawing.Size(35, 12)
        Me.lblRed.TabIndex = 16
        Me.lblRed.Text = "赤(&R):"
        '
        'grpCountDirection
        '
        Me.grpCountDirection.Controls.Add(Me.rabCountUp)
        Me.grpCountDirection.Controls.Add(Me.rabCountDown)
        Me.grpCountDirection.Location = New System.Drawing.Point(12, 173)
        Me.grpCountDirection.Name = "grpCountDirection"
        Me.grpCountDirection.Size = New System.Drawing.Size(321, 45)
        Me.grpCountDirection.TabIndex = 4
        Me.grpCountDirection.TabStop = False
        Me.grpCountDirection.Text = "カウント方法"
        '
        'rabCountDown
        '
        Me.rabCountDown.AutoSize = True
        Me.rabCountDown.Location = New System.Drawing.Point(39, 18)
        Me.rabCountDown.Name = "rabCountDown"
        Me.rabCountDown.Size = New System.Drawing.Size(101, 16)
        Me.rabCountDown.TabIndex = 0
        Me.rabCountDown.TabStop = True
        Me.rabCountDown.Text = "カウントダウン(&D)"
        Me.rabCountDown.UseVisualStyleBackColor = True
        '
        'rabCountUp
        '
        Me.rabCountUp.AutoSize = True
        Me.rabCountUp.Location = New System.Drawing.Point(183, 18)
        Me.rabCountUp.Name = "rabCountUp"
        Me.rabCountUp.Size = New System.Drawing.Size(99, 16)
        Me.rabCountUp.TabIndex = 1
        Me.rabCountUp.TabStop = True
        Me.rabCountUp.Text = "カウントアップ(&U)"
        Me.rabCountUp.UseVisualStyleBackColor = True
        '
        'frmOptions
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(345, 261)
        Me.Controls.Add(Me.grpCountDirection)
        Me.Controls.Add(Me.grpInitScore)
        Me.Controls.Add(Me.grpGameTime)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmOptions"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "オプション"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.grpGameTime.ResumeLayout(False)
        Me.grpGameTime.PerformLayout()
        CType(Me.nudSetting, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudExtend, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudNormal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpInitScore.ResumeLayout(False)
        Me.grpInitScore.PerformLayout()
        CType(Me.nudBlue, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudRed, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpCountDirection.ResumeLayout(False)
        Me.grpCountDirection.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents grpGameTime As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents nudExtend As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblSec As System.Windows.Forms.Label
    Friend WithEvents nudNormal As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblTime As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents nudSetting As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnAbout As System.Windows.Forms.Button
    Friend WithEvents btnHelp As System.Windows.Forms.Button
    Friend WithEvents grpInitScore As System.Windows.Forms.GroupBox
    Friend WithEvents nudBlue As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblBlue As System.Windows.Forms.Label
    Friend WithEvents nudRed As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblRed As System.Windows.Forms.Label
    Friend WithEvents grpCountDirection As System.Windows.Forms.GroupBox
    Friend WithEvents rabCountUp As System.Windows.Forms.RadioButton
    Friend WithEvents rabCountDown As System.Windows.Forms.RadioButton

End Class
