' 子弹类
Public Class ClassZd
    Private x As Point
    Private zd_fx As fx

    Public Sub New(ByVal x As Point, ByVal zd_fx As fx)
        Me.x = x
        Me.zd_fx = zd_fx
    End Sub

    Public Sub zd_move(ByVal g As Graphics)
        If zd_fx = fx.up Then
            x.Y -= 15
        ElseIf zd_fx = fx.down Then
            x.Y += 15
        ElseIf zd_fx = fx.left Then
            x.X -= 15
        ElseIf zd_fx = fx.right Then
            x.X += 15
        End If
        zd_draw(g)
    End Sub

    Public Sub zd_draw(ByVal g As Graphics)
        g.DrawEllipse(Pens.Black, x.X - 1, x.Y - 1, 4, 4)
    End Sub

    Public Function getzdpositon()
        Return x
    End Function

End Class
