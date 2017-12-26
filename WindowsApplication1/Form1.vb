Imports Syste
Imports System.Windows.Forms

Public Class Form1
    Inherits Form

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Up Then
            MessageBox.Show("up")
        ElseIf e.KeyCode = Keys.Down Then
            MessageBox.Show("down")
        ElseIf e.KeyCode = Keys.Left Then
            MessageBox.Show("left")
        ElseIf e.KeyCode = Keys.Right Then
            MessageBox.Show("right")
        End If





    End Sub
End Class 'Form1


