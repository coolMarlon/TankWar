<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Game
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.start = New System.Windows.Forms.ToolStripMenuItem()
        Me.restart = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.totalNum = New System.Windows.Forms.Label()
        Me.killedNum = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(9, 26)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(466, 355)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.start, Me.restart})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(669, 25)
        Me.MenuStrip1.TabIndex = 8
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'start
        '
        Me.start.Name = "start"
        Me.start.Size = New System.Drawing.Size(44, 21)
        Me.start.Text = "开始"
        '
        'restart
        '
        Me.restart.Name = "restart"
        Me.restart.Size = New System.Drawing.Size(68, 21)
        Me.restart.Text = "重新开始"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.killedNum)
        Me.Panel1.Controls.Add(Me.totalNum)
        Me.Panel1.Location = New System.Drawing.Point(480, 28)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(177, 352)
        Me.Panel1.TabIndex = 9
        '
        'totalNum
        '
        Me.totalNum.AutoSize = True
        Me.totalNum.Location = New System.Drawing.Point(13, 21)
        Me.totalNum.Name = "totalNum"
        Me.totalNum.Size = New System.Drawing.Size(71, 12)
        Me.totalNum.TabIndex = 0
        Me.totalNum.Text = "坦克总数 ："
        '
        'killedNum
        '
        Me.killedNum.AutoSize = True
        Me.killedNum.Location = New System.Drawing.Point(13, 71)
        Me.killedNum.Name = "killedNum"
        Me.killedNum.Size = New System.Drawing.Size(59, 12)
        Me.killedNum.TabIndex = 1
        Me.killedNum.Text = "已击杀 ："
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(669, 392)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents start As ToolStripMenuItem
    Friend WithEvents restart As ToolStripMenuItem
    Friend WithEvents Panel1 As Panel
    Friend WithEvents killedNum As Label
    Friend WithEvents totalNum As Label
End Class
