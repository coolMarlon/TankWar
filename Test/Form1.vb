Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub DrawImagePointF(ByVal e As PaintEventArgs)

        ' Create image.
        Dim newImage As Image = Image.FromFile("SampImag.jpg")

        ' Create point for upper-left corner of image.
        Dim ulCorner As New PointF(100.0F, 100.0F)

        ' Draw image to screen.
        e.Graphics.DrawImage(newImage, ulCorner)
    End Sub

    Dim RcDraw As Rectangle
    Dim PenWidth As Integer = 5


    Private Sub Form1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseDown

        ' Determine the initial rectangle coordinates...

        RcDraw.X = e.X
        RcDraw.Y = e.Y

    End Sub

    Private Sub Form1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseUp

        ' Determine the width and height of the rectangle...

        If e.X < RcDraw.X Then
            RcDraw.Width = RcDraw.X - e.X
            RcDraw.X = e.X
        Else
            RcDraw.Width = e.X - RcDraw.X
        End If

        If e.Y < RcDraw.Y Then
            RcDraw.Height = RcDraw.Y - e.Y
            RcDraw.Y = e.Y
        Else
            RcDraw.Height = e.Y - RcDraw.Y
        End If

        ' Force a repaint of the region occupied by the rectangle...

        'Me.Invalidate(RcDraw)

        Me.Refresh()


    End Sub

    Private Sub Form1_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles MyBase.Paint

        ' Draw the rectangle...

        e.Graphics.DrawRectangle(New Pen(Color.Blue, PenWidth), RcDraw)
        DrawImagePointF(e)

    End Sub


End Class