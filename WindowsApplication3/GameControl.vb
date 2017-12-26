Public Class GameControl
    Public aliveTank As Integer
    Public killedTank As Integer
    Public initialTank As Integer
    Public totalTank As Integer


    Public Sub New()
        initialTank = 4
        totalTank = 20
        killedTank = 0
    End Sub

    Public Function generateABadTank(w As Integer, h As Integer) As ClassDfTank
        Dim r As Random = New Random()
        Dim p As Point = New Point(r.Next() Mod w, 0)
        Dim badTank As ClassDfTank = New ClassDfTank(p, fx.down)
        Return badTank
    End Function
End Class
