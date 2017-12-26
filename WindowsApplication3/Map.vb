Public Class Map
    Public m_map(20, 31) As Integer
    Public W As Integer = 30
    Public H As Integer = 30
    Public LA_ONE_H As Integer = 60 'lable1的高度主机1P的高度
    Public LA_ONE_W As Integer = 60
    Public LA2_H As Integer = 15

    Private Sub Map_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        m_map = {{-1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1},
{-1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1},
{-1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1},
{-1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1},
{1, 1, 1, -1, -1, 1, 1, 1, -1, -1, 1, 1, 1, -1, -1, 1, 1, 1, -1, -1, 1, 1, 1, -1, -1, 1, 1, 1, -1, -1, 1, 1},
{1, 1, 1, -1, -1, 1, 1, 1, -1, -1, 1, 1, 1, -1, -1, 1, 1, 1, -1, -1, 1, 1, 1, -1, -1, 1, 1, 1, -1, -1, 1, 1},
{-1, -1, -1, -1, -1, 1, 1, 1, -1, -1, 1, 1, 1, -1, -1, 1, 1, 1, -1, -1, 1, 1, 1, -1, -1, -1, -1, -1, -1, -1, 1, 1},
{-1, -1, -1, -1, -1, 1, 1, 1, -1, -1, 1, 1, 1, -1, -1, 2, 2, 1, -1, -1, 1, 1, 1, -1, -1, -1, -1, -1, -1, -1, 1, 1},
{1, 1, 1, -1, -1, 2, 2, 1, -1, -1, 1, 1, 1, -1, -1, 2, 2, 1, -1, -1, 1, 1, 1, -1, -1, 1, 1, 1, -1, -1, 1, 1},
{1, 1, 1, -1, -1, 1, 1, 1, -1, 1, 3, 3, 1, -1, -1, 3, 3, 1, -1, -1, 1, 1, 1, -1, -1, 1, 2, 2, -1, -1, 1, 1},
{1, 1, 1, -1, -1, 1, 1, 1, -1, -1, 3, 3, 1, -1, -1, 3, 3, 1, -1, -1, 1, 1, 1, -1, -1, 1, 2, 2, -1, -1, 1, 1},
{1, 1, 1, 1, 1, 1, 1, 1, -1, -1, 1, 1, 1, -1, -1, 1, 1, 1, -1, -1, 1, 1, 1, -1, -1, 1, 1, 1, -1, -1, 1, 1},
{1, 1, 1, -2, -2, 1, 1, 1, -1, -1, 1, 1, 1, -2, -2, 1, 1, 1, -1, -1, 1, 1, 1, -1, -1, 1, 1, 1, -1, -1, 1, 1},
{1, 1, 1, -2, -2, 1, 1, 1, -1, -1, 1, 1, 1, -2, -2, 1, 1, 1, -1, -1, 1, 1, 1, -1, -1, -1, -1, -1, -1, -1, 1, 1},
{1, 1, 1, 1, 1, 1, 1, 1, -1, -1, 1, 1, 1, -1, -1, 1, 1, 1, -1, -1, 1, 1, 1, -1, -1, -1, -1, -1, -1, -1, 1, 1},
{-1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1},
{-1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1},
{1, 1, 1, 1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1},
{-1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 1, 1, 1, 1, 1, -1, -1, -1, -1, -1, -1, -1, -1, -1},
{-1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 2, 2, 2, 2, 1, -1, -1, -1, 1, 1, 1, 1, -1, -1, -1, -1, -1, -1, -1, -1},
{-1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 2, 4, 5, 2, -1, -1, 1, 1, 1, 1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1},
{-1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 2, 6, 7, 2, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1}
}
        Dim g As Graphics = PictureBox1.CreateGraphics()
        Dim P As Pen = New Pen(Color.Red)
        g.DrawRectangle(P, New Rectangle(1, 2, 20, 40))
        'beginGame()
    End Sub
    Private Sub beginGame()
        Dim g As Graphics = PictureBox1.CreateGraphics()
        Dim walls_image As Image = Image.FromFile("walls.gif")
        Dim steels_image As Image = Image.FromFile("steel.gif")
        Dim water_image As Image = Image.FromFile("water.gif")
        Dim symbol11_image As Image = Image.FromFile("symbol.gif")
        Dim symbol22_image As Image = Image.FromFile("symbol.gif")
        Dim symbo333_image As Image = Image.FromFile("symbol.gif")
        Dim symbo444_image As Image = Image.FromFile("symbol.gif")
        For i = 0 To m_map.GetLength(0) - 1
            For j = 0 To m_map.GetLength(1) - 1
                Select Case m_map(i, j)
                    Case 1
                        g.DrawImage(walls_image, j * W, i * H, W, H) '砖
                    Case 2
                        g.DrawImage(steels_image, j * W, i * H, W, H) '砧石
                    Case 3
                        g.DrawImage(water_image, j * W, i * H, W, H) '水地
                    Case 4
                        g.DrawImage(symbol11_image, j * W, i * H, W, H) 'BOSS
                    Case 5
                        g.DrawImage(symbol22_image, j * W, i * H, W, H) 'BOSS
                    Case 6
                        g.DrawImage(symbo333_image, j * W, i * H, W, H) 'BOSS
                    Case 7
                        g.DrawImage(symbo444_image, j * W, i * H, W, H) 'BOSS
                    Case -1
                        ClearSelectedBlock(j * W, i * W, g) '无东西
                    Case -2
                        ' g.DrawImage(grass_image, j * W, i * H, W, H) '草地
                End Select
            Next
        Next
        ' g.DrawImage(symbol11_image, PictureBox1.Width \ 2 - W, 23 * H, W, H)
        'g.DrawImage(symbol22_image, PictureBox1.Width \ 2 - W, 24 * H, W, H)
    End Sub

    Private Sub ClearSelectedBlock(ByVal x As Integer, ByVal y As Integer, ByVal g As Graphics)
        '清除选中方块
        Dim myBrush As SolidBrush = New SolidBrush(PictureBox1.BackColor)  '定义背景色画刷
        Dim b1 As Rectangle = New Rectangle(x, y, W, H)
        g.FillRectangle(myBrush, b1)
        '
    End Sub


End Class