' 坦克
Public Class ClassTank
    Private x As Point
    Public zds As List(Of ClassZd)

    Private tank_fx As fx


    Public Sub New(ByVal x As Point, ByVal tank_fx As fx)
        Me.x = x
        Me.tank_fx = tank_fx
        zds = New List(Of ClassZd)
    End Sub

    Public Function GetX()
        Return x
    End Function


    Public Overridable Sub Draw(ByVal g As Graphics)
        Dim img As Image
        If tank_fx = fx.up Then
            img = Image.FromFile("2.png")
        ElseIf tank_fx = fx.down Then
            img = Image.FromFile("3.png")
        ElseIf tank_fx = fx.left Then
            img = Image.FromFile("4.png")
        ElseIf tank_fx = fx.right Then
            img = Image.FromFile("1.png")
        End If

        g.DrawRectangle(Pens.Black, x.X - 25, x.Y - 50, 50, 50)
        g.DrawImage(img, x.X - 25, x.Y - 50, 50, 50)
    End Sub

    Public Overridable Sub Move(ByVal tank_fx As fx, ByVal g As Graphics)
        Me.tank_fx = tank_fx
        If tank_fx = fx.up Then
            x.Y -= 5
        ElseIf tank_fx = fx.down Then
            x.Y += 5
        ElseIf tank_fx = fx.left Then
            x.X -= 5
        ElseIf tank_fx = fx.right Then
            x.X += 5
        End If
        Draw(g)
    End Sub

    Public Sub shot()
        If tank_fx = fx.up Then
            zds.Add(New ClassZd(New Point(x.X, x.Y - 20), tank_fx))
        ElseIf tank_fx = fx.down Then
            zds.Add(New ClassZd(New Point(x.X, x.Y), tank_fx))
        ElseIf tank_fx = fx.left Then
            zds.Add(New ClassZd(New Point(x.X - 10, x.Y - 10), tank_fx))
        ElseIf tank_fx = fx.right Then
            zds.Add(New ClassZd(New Point(x.X + 10, x.Y - 10), tank_fx))
        End If
    End Sub

    ' 
    Public Sub tankc_zd_move(ByVal g As Graphics)
        If Not zds.Count = 0 Then
            For i = 0 To zds.Count - 1
                zds(i).zd_move(g)
            Next
        End If
    End Sub

    Public Function getzdposition()
        Dim zdp As List(Of Point) = New List(Of Point)
        For i = 0 To zds.Count - 1
            zdp.Add(zds(i).getzdpositon())
        Next
        Return zdp
    End Function

End Class

' 方向 =_="　
Public Enum fx
    up = 1
    down = 2
    left = 3
    right = 4
End Enum