Public Class Form2

    Public Shared rnum As Integer
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Form1.Enabled = False

        If Form1.SFlag = 1 Then
            CheckBox1.Checked = False
        ElseIf Form1.SFlag = 0 Then
            CheckBox1.Checked = True
        End If

        roundnum.Text = rnum

        If ErrorProvider1.Equals(Nothing) Then
            Button1.Enabled = False
        Else
            Button1.Enabled = True
        End If
    End Sub

    Private Sub Form2_Closed(sender As Object, e As EventArgs) Handles MyBase.Closed
        Form1.Enabled = True
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        Form1.SFlag += 1
        If CheckBox1.Checked = False Then
            Shell("Dependencies/SoundVolumeView.exe /Mute Rock-Paper-Scissors.exe")
        Else
            Shell("Dependencies/SoundVolumeView.exe /UnMute Rock-Paper-Scissors.exe")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If CheckBox1.Checked = False Then
            Form1.SFlag = 1
        ElseIf CheckBox1.Checked = True Then
            Form1.SFlag = 0
        End If

        Close()
    End Sub

    Private Sub roundnum_TextChanged(sender As Object, e As EventArgs) Handles roundnum.TextChanged
        If roundnum.Text = "0" Then
            ErrorProvider1.SetError(roundnum, "Number of Rounds cannot be Zero!")
            Button1.Enabled = False
        ElseIf roundnum.Text.Length > 3 Then
            ErrorProvider1.SetError(roundnum, "Number of Rounds exceeding limit!")
            Button1.Enabled = False
        ElseIf Not IsNumeric(roundnum.Text) Then
            ErrorProvider1.SetError(roundnum, "Input Invalid!")
            Button1.Enabled = False
        Else
            ErrorProvider1.SetError(roundnum, "")
            rnum = Val(roundnum.Text)
            Button1.Enabled = True
        End If
    End Sub
End Class