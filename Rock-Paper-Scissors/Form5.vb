Public Class Form5
    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Form1.Enabled = False
    End Sub
    Private Sub Form5_Closed(sender As Object, e As EventArgs) Handles MyBase.Closed
        Form1.Enabled = True
    End Sub
    Private Sub Form5_DoubleClick(sender As Object, e As EventArgs) Handles MyBase.DoubleClick
        Close()
    End Sub

End Class