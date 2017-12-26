Public Class Game

    Private WithEvents ct As ClassTank
    Private WithEvents tick As Timer
    Private WithEvents dfcts As List(Of ClassDfTank)
    Private random As Random
    Private gc As GameControl

    Private Sub On_Click(sender As Object, e As EventArgs)

    End Sub

    Private Function getW()
        Return PictureBox1.Width
    End Function
    Private Function getH()
        Return PictureBox1.Height
    End Function



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetStyle(ControlStyles.AllPaintingInWmPaint, True)
        SetStyle(ControlStyles.OptimizedDoubleBuffer, True)
        Dim ph As Integer = PictureBox1.Height
        Dim pw As Integer = PictureBox1.Width
        random = New Random()
        '游戏控制类
        gc = New GameControl()
        ct = New ClassTank(New Point(Math.Floor(pw / 2), ph), fx.up)
        totalNum.Text = "坦克总数：" + CStr(gc.totalTank)
        killedNum.Text = "已击杀 ：" + CStr(gc.killedTank)
        dfcts = New List(Of ClassDfTank)
        For i As Integer = 1 To gc.initialTank
            dfcts.Add(gc.generateABadTank(Me.getW, Me.getH))
            System.Threading.Thread.CurrentThread.Sleep(100)
        Next
        tick = New Timer
        tick.Interval = 100
        tick.Enabled = False
        'Me.Focus()

    End Sub

    Private Sub up_click(sender As Object, e As EventArgs)
        Dim g As Graphics = PictureBox1.CreateGraphics
        g.Clear(Color.White)
        ct.Move(fx.up, g)
    End Sub

    Private Sub down_click(sender As Object, e As EventArgs)
        Dim g As Graphics = PictureBox1.CreateGraphics
        g.Clear(Color.White)
        ct.Move(fx.down, g)
    End Sub

    Private Sub ticker_tick(sender As Object, e As EventArgs) Handles tick.Tick
        Dim g As Graphics = PictureBox1.CreateGraphics
        g.Clear(Color.White)
        ct.Draw(g)
        ct.tankc_zd_move(g)
        Dim p As Point = ct.GetX()
        For i = 0 To dfcts.Count - 1
            If random.Next() Mod 20 = 1 Then
                dfcts(i).shot()
            End If
            dfcts(i).tankc_zd_move(g)
            'If random.Next() Mod 5 = 1 Then
            dfcts(i).Move(g, p)
            'End If

        Next
        checkkill()
    End Sub

    Private Sub left_click(sender As Object, e As EventArgs)
        Dim g As Graphics = PictureBox1.CreateGraphics
        g.Clear(Color.White)
        ct.Move(fx.left, g)
    End Sub

    Private Sub right_click(sender As Object, e As EventArgs)
        Dim g As Graphics = PictureBox1.CreateGraphics
        g.Clear(Color.White)
        ct.Move(fx.right, g)
    End Sub

    Private Sub shot_click(sender As Object, e As EventArgs)
        ct.shot()
        Me.KeyPreview = True
    End Sub

    Private Sub checkkill()

        '射中坦克编号与射中子弹编号
        Dim flag As Integer = -1
        Dim bulletFlag As Integer = -1

        '地方坦克位置汇总
        Dim p_df As List(Of Point) = New List(Of Point)
        For i = 0 To dfcts.Count - 1
            p_df.Add(dfcts(i).getposition())
        Next

        '我方子弹point汇总
        Dim p_zd As List(Of Point) = New List(Of Point)
        p_zd = ct.getzdposition()

        '敌方子弹point汇总
        Dim p_enemy_zd As List(Of Point) = New List(Of Point)
        For Each enemy_tk As ClassDfTank In dfcts
            p_enemy_zd.AddRange(enemy_tk.getzdsPosition())
        Next

        '检查是否命中地方坦克
        For i = 0 To p_zd.Count - 1
            For j = 0 To p_df.Count - 1
                If p_zd.ElementAt(i).X < p_df.ElementAt(j).X + 10 And p_zd.ElementAt(i).X > p_df.ElementAt(j).X - 10 And p_zd.ElementAt(i).Y < p_df.ElementAt(j).Y And p_zd.ElementAt(i).Y > p_df.ElementAt(j).Y - 20 Then
                    flag = j
                    bulletFlag = i
                End If
            Next
        Next

        For Each p As Point In p_enemy_zd
            If p.X < ct.GetX().X + 10 And p.X > ct.GetX().X - 10 And p.Y < ct.GetX().Y And p.Y > ct.GetX().Y - 20 Then
                tick.Enabled = False
                MessageBox.Show("很遗憾，你被击中了，游戏结束!")
            End If
        Next

        If Not flag = -1 Then
            '清楚被射中的子弹和坦克
            dfcts.RemoveAt(flag)
            ct.zds.RemoveAt(bulletFlag)
            '增加一个坦克
            dfcts.Add(gc.generateABadTank(Me.getW, Me.getW))
            gc.killedTank += 1
            killedNum.Text = "已击杀 ：" + CStr(gc.killedTank)
        End If

        If gc.killedTank = gc.totalTank Then
            tick.Enabled = False
            MessageBox.Show("you win the game, congratulations!")
        End If
    End Sub


    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.W Then
            Dim g As Graphics = PictureBox1.CreateGraphics
            g.Clear(Color.White)
            ct.Move(fx.up, g)
        ElseIf e.KeyCode = Keys.S Then
            Dim g As Graphics = PictureBox1.CreateGraphics
            g.Clear(Color.White)
            ct.Move(fx.down, g)
        ElseIf e.KeyCode = Keys.A Then
            Dim g As Graphics = PictureBox1.CreateGraphics
            g.Clear(Color.White)
            ct.Move(fx.left, g)
        ElseIf e.KeyCode = Keys.D Then
            Dim g As Graphics = PictureBox1.CreateGraphics
            g.Clear(Color.White)
            ct.Move(fx.right, g)
        ElseIf e.KeyCode = Keys.Space Then
            ct.shot()
        End If
    End Sub


    Private Sub 开始ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles start.Click
        start.Enabled = False
        tick.Enabled = Not tick.Enabled
        Dim g As Graphics = PictureBox1.CreateGraphics
        ct.Draw(g)
        For i = 0 To dfcts.Count - 1
            dfcts(i).Draw(g)
        Next
    End Sub

    Private Sub 重新开始ToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub 重新开始ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles restart.Click
        Form1_Load(sender, e)
        start.Enabled = True
    End Sub

    Private Sub Form1_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint

    End Sub
End Class
