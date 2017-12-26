'敌方坦克
Public Class ClassDfTank
    '坦克所在置位
    Private x As Point
    '前进方向
    Private dfct_fx As fx
    '前进距离
    Private zds As List(Of ClassZd)
    Private re As Integer
    Public Sub New(ByVal x As Point, ByVal dfct_fx As fx)
        Me.x = x
        Me.dfct_fx = dfct_fx
        re = 0
        zds = New List(Of ClassZd)
    End Sub
    Public Function getzdsPosition() As List(Of Point)
        Dim li As List(Of Point) = New List(Of Point)
        For Each zd As ClassZd In zds
            li.Add(zd.getzdpositon())
        Next
        Return li
    End Function
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

    Public Sub Move(ByVal g As Graphics, ByVal p As Point)
        '2/5 概率向下，1/5概率向上，1/5概率向左，1/5概率向右
        Dim random As Random = New Random()
        Dim num As Integer = random.Next()
        If num Mod 5 = 0 Or num Mod 5 = 1 Then
            '向下
            dfct_fx = fx.down
            x.Y += 5
        ElseIf num Mod 5 = 2 Then
            '向上
            dfct_fx = fx.up
            x.Y -= 5
        ElseIf num Mod 5 = 3 Then
            '向左
            dfct_fx = fx.left
            x.X -= 5
        ElseIf num Mod 5 = 4 Then
            '向右
            dfct_fx = fx.right
            x.X += 5
        End If
        'MessageBox.Show(random.Next())


        'If x.X > p.X Then
        '    dfct_fx = fx.left
        '    x.X -= 5
        'Else
        '    dfct_fx = fx.right
        '    x.X += 5
        'End If
        '
        'If x.Y > p.Y Then
        '    dfct_fx = fx.down
        '    x.Y -= 5
        'Else
        '    dfct_fx = fx.up
        '    x.Y += 5
        'End If

        're += 1
        'If dfct_fx = fx.up Then
        '    If re > 30 Then
        '        dfct_fx = fx.down
        '        re = 0
        '    End If
        '    x.Y -= 5
        'ElseIf dfct_fx = fx.down Then
        '    If re > 30 Then
        '        dfct_fx = fx.up
        '        re = 0
        '    End If
        '    x.Y += 5
        'ElseIf dfct_fx = fx.left Then
        '    If re > 30 Then
        '        dfct_fx = fx.right
        '        re = 0
        '    End If
        '    x.X -= 5
        'ElseIf dfct_fx = fx.right Then
        '    If re > 30 Then
        '        dfct_fx = fx.left
        '        re = 0
        '    End If
        '    x.X += 5
        'End If
        Draw(g)
    End Sub

    Public Function getposition()
        Return x
    End Function

    Public Sub shot()
        'Throw New NotImplementedException()
        If dfct_fx = fx.up Then
            zds.Add(New ClassZd(New Point(x.X, x.Y - 20), dfct_fx))
        ElseIf dfct_fx = fx.down Then
            zds.Add(New ClassZd(New Point(x.X, x.Y), dfct_fx))
        ElseIf dfct_fx = fx.left Then
            zds.Add(New ClassZd(New Point(x.X - 10, x.Y - 10), dfct_fx))
        ElseIf dfct_fx = fx.right Then
            zds.Add(New ClassZd(New Point(x.X + 10, x.Y - 10), dfct_fx))
        End If
    End Sub



    Public Sub tankc_zd_move(ByVal g As Graphics)
        If Not zds.Count = 0 Then
            For i = 0 To zds.Count - 1
                zds(i).zd_move(g)
            Next
        End If
    End Sub
End Class
