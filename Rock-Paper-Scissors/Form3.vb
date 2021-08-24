Public Class Form3

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Form1.Enabled = False
    End Sub

    Private Sub Form3_Closed(sender As Object, e As EventArgs) Handles MyBase.Closed
        Form1.Enabled = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Application.Exit()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form1.round.Text = "0"
        Form1.WinU.Text = "0"
        Form1.WinC.Text = "0"
        Form1.Ties.Text = "0"
        Form1.RFlag = 0
        Form1.UserPic.Image = Nothing
        Form1.CompPic.Image = Nothing
        Close()
    End Sub
End Class