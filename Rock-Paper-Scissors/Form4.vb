Public Class Form4
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Form1.Enabled = False
    End Sub

    Private Sub Form4_Closed(sender As Object, e As EventArgs) Handles MyBase.Closed
        Form1.Enabled = True
    End Sub
End Class