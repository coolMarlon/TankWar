Public Class Start
    Dim cs1 As Integer = 1
    'Public msp1 As New System.Media.SoundPlayer(My.Resources.yxks)
    Private Sub Form1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Down And cs1 = 1 Then
            PictureBox1.Top = PictureBox1.Top + 40
            cs1 = 0
        End If
        If e.KeyCode = Keys.Up And cs1 = 0 Then
            PictureBox1.Top = PictureBox1.Top - 40
            cs1 = 1
        End If
        If e.KeyCode = Keys.Enter And cs1 = 1 Then
            Me.Hide()
            'msp1.Stop()
            'StartMediaPlayer1.close()
            'With Form2.GameMediaPlayer1
            '    .Visible = False
            '    .URL = Application.StartupPath & "\subpart\sound\game.mid"
            '    .settings.playCount = -1
            '    .settings.autoStart = True
            'End With
            Game.Show()
        End If
        If e.KeyCode = Keys.Enter And cs1 = 0 Then
            MsgBox("under development")
        End If
    End Sub

    Private Sub 结束ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 结束ToolStripMenuItem.Click
        End
    End Sub

    Private Sub 关于ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 关于ToolStripMenuItem.Click
        Help.Show()
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' msp1.Play()
        'With StartMediaPlayer1
        '    .Visible = False
        '    .URL = Application.StartupPath & "\subpart\sound\start.mid"
        '    .settings.playCount = -1
        '    .settings.autoStart = True
        'End With
    End Sub

    Private Sub oneToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles oneToolStripMenuItem.Click
        'msp1.Stop()
        Me.Hide()
        'StartMediaPlayer1.close()
        'With Form2.GameMediaPlayer1
        '    .Visible = False
        '    .URL = Application.StartupPath & "\subpart\sound\game.mid"
        '    .settings.playCount = -1
        '    .settings.autoStart = True
        'End With
        Game.Show()
    End Sub

    Private Sub 帮助ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 帮助ToolStripMenuItem1.Click
        Help.Show()
    End Sub

    Private Sub towToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles towToolStripMenuItem.Click
        MsgBox("under development")
    End Sub
End Class