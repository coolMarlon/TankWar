Public Class ClassDfTank
    Private x As Point
    Private dfct_fx As fx
    Private re As Integer
    Public Sub New(ByVal x As Point, ByVal dfct_fx As fx)
        Me.x = x
        Me.dfct_fx = dfct_fx
        re = 0
    End Sub

    Public Sub Draw(ByVal g As Graphics)
        Dim img As Image
        If dfct_fx = fx.up Then
            img = Image.FromFile("31.png")
        ElseIf dfct_fx = fx.down Then
            img = Image.FromFile("333.png")
        ElseIf dfct_fx = fx.left Then
            img = Image.FromFile("334.png")
        ElseIf dfct_fx = fx.right Then
            img = Image.FromFile("32.png")
        End If
        g.DrawRectangle(Pens.Black, x.X - 10, x.Y - 21, 20, 20)
        g.DrawImage(img, x.X - 10, x.Y - 21, 20, 20)
    End Sub

    Public Sub Move(ByVal g As Graphics)
        re += 1
        If dfct_fx = fx.up Then
            If re > 30 Then
                dfct_fx = fx.down
                re = 0
            End If
            x.Y -= 5
        ElseIf dfct_fx = fx.down Then
            If re > 30 Then
                dfct_fx = fx.up
                re = 0
            End If
            x.Y += 5
        ElseIf dfct_fx = fx.left Then
            If re > 30 Then
                dfct_fx = fx.right
                re = 0
            End If
            x.X -= 5
        ElseIf dfct_fx = fx.right Then
            If re > 30 Then
                dfct_fx = fx.left
                re = 0
            End If
            x.X += 5
        End If
        Draw(g)
    End Sub

    Public Function getposition()
        Return x
    End Function
End Class
