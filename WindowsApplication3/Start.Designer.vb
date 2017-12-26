<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Start
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Start))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.文件ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.开始ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.oneToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.towToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.结束ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.帮助ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.关于ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.帮助ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(132, 225)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(33, 30)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.文件ToolStripMenuItem, Me.帮助ToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(534, 25)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        '文件ToolStripMenuItem
        '
        Me.文件ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.开始ToolStripMenuItem, Me.结束ToolStripMenuItem})
        Me.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem"
        Me.文件ToolStripMenuItem.Size = New System.Drawing.Size(44, 21)
        Me.文件ToolStripMenuItem.Text = "文件"
        '
        '开始ToolStripMenuItem
        '
        Me.开始ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.oneToolStripMenuItem, Me.towToolStripMenuItem})
        Me.开始ToolStripMenuItem.Name = "开始ToolStripMenuItem"
        Me.开始ToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.开始ToolStripMenuItem.Text = "开始"
        '
        'oneToolStripMenuItem
        '
        Me.oneToolStripMenuItem.Name = "oneToolStripMenuItem"
        Me.oneToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.oneToolStripMenuItem.Text = "1 player (&1)"
        '
        'towToolStripMenuItem
        '
        Me.towToolStripMenuItem.Name = "towToolStripMenuItem"
        Me.towToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.towToolStripMenuItem.Text = "2 player (&2)"
        '
        '结束ToolStripMenuItem
        '
        Me.结束ToolStripMenuItem.Name = "结束ToolStripMenuItem"
        Me.结束ToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.结束ToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.结束ToolStripMenuItem.Text = "结束"
        '
        '帮助ToolStripMenuItem
        '
        Me.帮助ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.关于ToolStripMenuItem, Me.帮助ToolStripMenuItem1})
        Me.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem"
        Me.帮助ToolStripMenuItem.Size = New System.Drawing.Size(44, 21)
        Me.帮助ToolStripMenuItem.Text = "帮助"
        '
        '关于ToolStripMenuItem
        '
        Me.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem"
        Me.关于ToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.关于ToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.关于ToolStripMenuItem.Text = "关于"
        '
        '帮助ToolStripMenuItem1
        '
        Me.帮助ToolStripMenuItem1.Name = "帮助ToolStripMenuItem1"
        Me.帮助ToolStripMenuItem1.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.H), System.Windows.Forms.Keys)
        Me.帮助ToolStripMenuItem1.Size = New System.Drawing.Size(146, 22)
        Me.帮助ToolStripMenuItem1.Text = "帮助"
        '
        'Start
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(534, 429)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "Start"
        Me.Text = "Start"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents 文件ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 开始ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents oneToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents towToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 结束ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 帮助ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 关于ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 帮助ToolStripMenuItem1 As ToolStripMenuItem
End Class
