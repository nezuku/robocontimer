<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.pnlTime = New System.Windows.Forms.Panel()
        Me.picDot3 = New System.Windows.Forms.PictureBox()
        Me.picDot2 = New System.Windows.Forms.PictureBox()
        Me.lblM = New System.Windows.Forms.Label()
        Me.lblS1 = New System.Windows.Forms.Label()
        Me.lblS10 = New System.Windows.Forms.Label()
        Me.picDot1 = New System.Windows.Forms.PictureBox()
        Me.lblMin = New System.Windows.Forms.Label()
        Me.pgbWork = New System.Windows.Forms.ProgressBar()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.lblScoreBlue = New System.Windows.Forms.Label()
        Me.lblScoreRed = New System.Windows.Forms.Label()
        Me.tmrDisplayUpdater = New System.Windows.Forms.Timer(Me.components)
        Me.pnlTime.SuspendLayout()
        CType(Me.picDot3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDot2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDot1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlTime
        '
        Me.pnlTime.BackColor = System.Drawing.Color.Black
        Me.pnlTime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlTime.Controls.Add(Me.picDot3)
        Me.pnlTime.Controls.Add(Me.picDot2)
        Me.pnlTime.Controls.Add(Me.lblM)
        Me.pnlTime.Controls.Add(Me.lblS1)
        Me.pnlTime.Controls.Add(Me.lblS10)
        Me.pnlTime.Controls.Add(Me.picDot1)
        Me.pnlTime.Controls.Add(Me.lblMin)
        Me.pnlTime.Location = New System.Drawing.Point(12, 12)
        Me.pnlTime.Margin = New System.Windows.Forms.Padding(5)
        Me.pnlTime.Name = "pnlTime"
        Me.pnlTime.Size = New System.Drawing.Size(992, 448)
        Me.pnlTime.TabIndex = 0
        '
        'picDot3
        '
        Me.picDot3.Image = Global.robocontimer.My.Resources.Resources.pngCoron
        Me.picDot3.Location = New System.Drawing.Point(771, 357)
        Me.picDot3.Name = "picDot3"
        Me.picDot3.Size = New System.Drawing.Size(48, 48)
        Me.picDot3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picDot3.TabIndex = 6
        Me.picDot3.TabStop = False
        '
        'picDot2
        '
        Me.picDot2.Image = Global.robocontimer.My.Resources.Resources.pngCoron
        Me.picDot2.Location = New System.Drawing.Point(261, 273)
        Me.picDot2.Name = "picDot2"
        Me.picDot2.Size = New System.Drawing.Size(48, 48)
        Me.picDot2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picDot2.TabIndex = 5
        Me.picDot2.TabStop = False
        '
        'lblM
        '
        Me.lblM.BackColor = System.Drawing.Color.Transparent
        Me.lblM.Font = New System.Drawing.Font("Microsoft Sans Serif", 150.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblM.ForeColor = System.Drawing.Color.Lime
        Me.lblM.Location = New System.Drawing.Point(841, 207)
        Me.lblM.Name = "lblM"
        Me.lblM.Size = New System.Drawing.Size(112, 198)
        Me.lblM.TabIndex = 4
        Me.lblM.Text = "8"
        Me.lblM.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'lblS1
        '
        Me.lblS1.BackColor = System.Drawing.Color.Transparent
        Me.lblS1.Font = New System.Drawing.Font("Microsoft Sans Serif", 300.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblS1.ForeColor = System.Drawing.Color.Lime
        Me.lblS1.Location = New System.Drawing.Point(541, -18)
        Me.lblS1.Name = "lblS1"
        Me.lblS1.Size = New System.Drawing.Size(240, 480)
        Me.lblS1.TabIndex = 3
        Me.lblS1.Text = "8"
        Me.lblS1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblS10
        '
        Me.lblS10.BackColor = System.Drawing.Color.Transparent
        Me.lblS10.Font = New System.Drawing.Font("Microsoft Sans Serif", 300.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblS10.ForeColor = System.Drawing.Color.Lime
        Me.lblS10.Location = New System.Drawing.Point(322, -18)
        Me.lblS10.Name = "lblS10"
        Me.lblS10.Size = New System.Drawing.Size(240, 480)
        Me.lblS10.TabIndex = 2
        Me.lblS10.Text = "8"
        Me.lblS10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'picDot1
        '
        Me.picDot1.Image = Global.robocontimer.My.Resources.Resources.pngCoron
        Me.picDot1.Location = New System.Drawing.Point(261, 123)
        Me.picDot1.Name = "picDot1"
        Me.picDot1.Size = New System.Drawing.Size(48, 48)
        Me.picDot1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picDot1.TabIndex = 1
        Me.picDot1.TabStop = False
        '
        'lblMin
        '
        Me.lblMin.BackColor = System.Drawing.Color.Transparent
        Me.lblMin.Font = New System.Drawing.Font("Microsoft Sans Serif", 300.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMin.ForeColor = System.Drawing.Color.Lime
        Me.lblMin.Location = New System.Drawing.Point(36, -18)
        Me.lblMin.Name = "lblMin"
        Me.lblMin.Size = New System.Drawing.Size(240, 480)
        Me.lblMin.TabIndex = 0
        Me.lblMin.Text = "8"
        Me.lblMin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pgbWork
        '
        Me.pgbWork.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pgbWork.Location = New System.Drawing.Point(12, 468)
        Me.pgbWork.MarqueeAnimationSpeed = 30
        Me.pgbWork.Maximum = 50
        Me.pgbWork.Name = "pgbWork"
        Me.pgbWork.Size = New System.Drawing.Size(992, 23)
        Me.pgbWork.Style = System.Windows.Forms.ProgressBarStyle.Marquee
        Me.pgbWork.TabIndex = 1
        '
        'lblStatus
        '
        Me.lblStatus.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblStatus.Font = New System.Drawing.Font("Impact", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.Location = New System.Drawing.Point(281, 535)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(454, 149)
        Me.lblStatus.TabIndex = 11
        Me.lblStatus.Text = "EXTENDED"
        Me.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblScoreBlue
        '
        Me.lblScoreBlue.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblScoreBlue.BackColor = System.Drawing.Color.Transparent
        Me.lblScoreBlue.Font = New System.Drawing.Font("Impact", 96.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScoreBlue.ForeColor = System.Drawing.Color.Black
        Me.lblScoreBlue.Image = Global.robocontimer.My.Resources.Resources.box_blue
        Me.lblScoreBlue.Location = New System.Drawing.Point(741, 494)
        Me.lblScoreBlue.Name = "lblScoreBlue"
        Me.lblScoreBlue.Size = New System.Drawing.Size(263, 231)
        Me.lblScoreBlue.TabIndex = 10
        Me.lblScoreBlue.Text = "00"
        Me.lblScoreBlue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblScoreRed
        '
        Me.lblScoreRed.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblScoreRed.BackColor = System.Drawing.Color.Transparent
        Me.lblScoreRed.Font = New System.Drawing.Font("Impact", 96.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScoreRed.ForeColor = System.Drawing.Color.Black
        Me.lblScoreRed.Image = Global.robocontimer.My.Resources.Resources.box_red
        Me.lblScoreRed.Location = New System.Drawing.Point(12, 494)
        Me.lblScoreRed.Name = "lblScoreRed"
        Me.lblScoreRed.Size = New System.Drawing.Size(263, 231)
        Me.lblScoreRed.TabIndex = 9
        Me.lblScoreRed.Text = "00"
        Me.lblScoreRed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tmrDisplayUpdater
        '
        Me.tmrDisplayUpdater.Interval = 10
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightYellow
        Me.ClientSize = New System.Drawing.Size(1016, 734)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.lblScoreBlue)
        Me.Controls.Add(Me.lblScoreRed)
        Me.Controls.Add(Me.pgbWork)
        Me.Controls.Add(Me.pnlTime)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ロボコンタイマー"
        Me.pnlTime.ResumeLayout(False)
        CType(Me.picDot3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDot2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDot1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlTime As System.Windows.Forms.Panel
    Friend WithEvents lblMin As System.Windows.Forms.Label
    Friend WithEvents picDot1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblM As System.Windows.Forms.Label
    Friend WithEvents lblS1 As System.Windows.Forms.Label
    Friend WithEvents lblS10 As System.Windows.Forms.Label
    Friend WithEvents picDot3 As System.Windows.Forms.PictureBox
    Friend WithEvents picDot2 As System.Windows.Forms.PictureBox
    Friend WithEvents pgbWork As System.Windows.Forms.ProgressBar
    Friend WithEvents lblScoreRed As System.Windows.Forms.Label
    Friend WithEvents lblScoreBlue As System.Windows.Forms.Label
    Friend WithEvents tmrDisplayUpdater As System.Windows.Forms.Timer
    Friend WithEvents lblStatus As System.Windows.Forms.Label

End Class
