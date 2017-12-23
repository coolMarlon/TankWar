Public Class Form1

    Private WithEvents ct As ClassTank
    Private WithEvents tick As Timer
    Private WithEvents dfcts As List(Of ClassDfTank)


    Private Sub On_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Button1.Enabled = False
        tick.Enabled = Not tick.Enabled
        Dim g As Graphics = PictureBox1.CreateGraphics
        ct.Draw(g)
        For i = 0 To dfcts.Count - 1
            dfcts(i).Draw(g)
        Next
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ph As Integer = PictureBox1.Height
        Dim pw As Integer = PictureBox1.Width
        ct = New ClassTank(New Point(Math.Floor(pw / 2), ph), fx.up)
        dfcts = New List(Of ClassDfTank)
        dfcts.Add(New ClassDfTank(New Point(Math.Floor(pw / 2), Math.Floor(pw / 4)), fx.down))
        dfcts.Add(New ClassDfTank(New Point(Math.Floor(pw / 2), Math.Floor(pw / 3)), fx.left))
        dfcts.Add(New ClassDfTank(New Point(Math.Floor(pw / 2), Math.Floor(pw / 2)), fx.right))
        tick = New Timer
        tick.Interval = 100 : tick.Enabled = False
    End Sub

    Private Sub up_click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim g As Graphics = PictureBox1.CreateGraphics
        g.Clear(Color.White)
        ct.Move(fx.up, g)
    End Sub

    Private Sub down_click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim g As Graphics = PictureBox1.CreateGraphics
        g.Clear(Color.White)
        ct.Move(fx.down, g)
    End Sub

    Private Sub ticker_tick(sender As Object, e As EventArgs) Handles tick.Tick
        Dim g As Graphics = PictureBox1.CreateGraphics
        g.Clear(Color.White)
        ct.Draw(g)
        ct.tankc_zd_move(g)
        For i = 0 To dfcts.Count - 1
            dfcts(i).Move(g)
        Next
        checkkill()
    End Sub

    Private Sub left_click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim g As Graphics = PictureBox1.CreateGraphics
        g.Clear(Color.White)
        ct.Move(fx.left, g)
    End Sub

    Private Sub right_click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim g As Graphics = PictureBox1.CreateGraphics
        g.Clear(Color.White)
        ct.Move(fx.right, g)
    End Sub

    Private Sub shot_click(sender As Object, e As EventArgs) Handles Button6.Click
        ct.shot()
    End Sub

    Private Sub checkkill()
        Dim p_df As List(Of Point) = New List(Of Point)
        Dim flag As Integer = -1
        For i = 0 To dfcts.Count - 1
            p_df.Add(dfcts(i).getposition())
        Next
        Dim p_zd As List(Of Point) = New List(Of Point)
        p_zd = ct.getzdposition()

        For i = 0 To p_zd.Count - 1
            For j = 0 To p_df.Count - 1
                If p_zd.ElementAt(i).X < p_df.ElementAt(j).X + 10 And p_zd.ElementAt(i).X > p_df.ElementAt(j).X - 10 And p_zd.ElementAt(i).Y < p_df.ElementAt(j).Y And p_zd.ElementAt(i).Y > p_df.ElementAt(j).Y - 20 Then
                    flag = j
                End If
            Next
        Next

        If Not flag = -1 Then
            dfcts.RemoveAt(flag)
        End If

        If dfcts.Count = 0 Then
            tick.Enabled = False
            MsgBox("win", 1)
        End If
    End Sub

    Private Sub reload_click(sender As Object, e As EventArgs) Handles Button7.Click
        Form1_Load(sender, e)
        Button1.Enabled = True
    End Sub


End Class
