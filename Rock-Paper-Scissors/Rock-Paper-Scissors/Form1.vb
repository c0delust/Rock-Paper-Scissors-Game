Public Class Form1

    Shared random As New Random()
    Dim num As Integer
    Dim Flag As Integer = 0
    Public Shared RFlag As Integer = 0
    Public Shared SFlag As Integer = 0

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Form6.Show()
        WinU.Text = "0"
        WinC.Text = "0"
        Ties.Text = "0"
        round.Text = "0"
        TextBox1.Text = "3"
        TextBox1.Visible = False
        Form2.rnum = "10"
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        Select Case Flag
            Case 1
                If Val(TextBox1.Text) = 0 Then
                    UserPic.ImageLocation = "Dependencies\Rock.png"
                    Driver()
                    TimerStop()
                Else
                    My.Computer.Audio.Play("Dependencies\tick.wav")
                    TextBox1.Text = Val(TextBox1.Text) - 1
                End If
            Case 2
                If Val(TextBox1.Text) = 0 Then
                    UserPic.ImageLocation = "Dependencies\Paper.png"
                    Driver()
                    TimerStop()
                Else
                    My.Computer.Audio.Play("Dependencies\tick.wav")
                    TextBox1.Text = Val(TextBox1.Text) - 1
                End If
            Case 3
                If Val(TextBox1.Text) = 0 Then
                    UserPic.ImageLocation = "Dependencies\Scissors.png"
                    Driver()
                    TimerStop()
                Else
                    My.Computer.Audio.Play("Dependencies\tick.wav")
                    TextBox1.Text = Val(TextBox1.Text) - 1
                End If
            Case 0
                Exit Sub
        End Select

    End Sub

    Public Sub TimerStart()
        UserPic.ImageLocation = ""
        CompPic.ImageLocation = ""
        TextBox1.Visible = True
        Timer1.Enabled = True
        Timer1.Start()
    End Sub
    Public Sub TimerStop()
        My.Computer.Audio.Play("Dependencies\appear.wav")
        Timer1.Stop()
        Timer1.Enabled = False
        TextBox1.Visible = False
        TextBox1.Text = "3"
    End Sub

    Private Sub Rock_Click(sender As Object, e As EventArgs) Handles Rock.Click
        My.Computer.Audio.Play("Dependencies\click.wav")
        Result()
        If RFlag = 0 Then
            Flag = 1
            TimerStart()
        End If
    End Sub

    Private Sub Rock_MouseEnter(sender As Object, e As EventArgs) Handles Rock.MouseEnter
        Rock.BackgroundImage = My.Resources.Rock_Button_2
    End Sub
    Private Sub Rock_MouseLeave(sender As Object, e As EventArgs) Handles Rock.MouseLeave
        Rock.BackgroundImage = My.Resources.Rock_Button_1
    End Sub

    Private Sub Paper_Click(sender As Object, e As EventArgs) Handles Paper.Click
        My.Computer.Audio.Play("Dependencies\click.wav")
        Result()
        If RFlag = 0 Then
            Flag = 2
            TimerStart()
        End If
    End Sub

    Private Sub Paper_MouseEnter(sender As Object, e As EventArgs) Handles Paper.MouseEnter
        Paper.BackgroundImage = My.Resources.Paper_Button_2
    End Sub
    Private Sub Paper_MouseLeave(sender As Object, e As EventArgs) Handles Paper.MouseLeave
        Paper.BackgroundImage = My.Resources.Paper_Button_1
    End Sub

    Private Sub Scissors_Click(sender As Object, e As EventArgs) Handles Scissors.Click
        My.Computer.Audio.Play("Dependencies\click.wav")
        Result()
        If RFlag = 0 Then
            Flag = 3
            TimerStart()
        End If
    End Sub

    Private Sub Scissors_MouseEnter(sender As Object, e As EventArgs) Handles Scissors.MouseEnter
        Scissors.BackgroundImage = My.Resources.Scissors_Button_2
    End Sub
    Private Sub Scissors_MouseLeave(sender As Object, e As EventArgs) Handles Scissors.MouseLeave
        Scissors.BackgroundImage = My.Resources.Scissors_Button_1
    End Sub

    Public Sub Driver()

        num = random.Next(0, 1500)

        If (num <= 500) Then
            CompPic.ImageLocation = "Dependencies\RPaper.png"
        ElseIf (num >= 500 And num <= 1000) Then
            CompPic.ImageLocation = "Dependencies\RRock.png"
        Else
            CompPic.ImageLocation = "Dependencies\RScissors.png"
        End If

        num = -1
        round.Text = Val(round.Text) + 1

        If (UserPic.ImageLocation = "Dependencies\Rock.png" And CompPic.ImageLocation = "Dependencies\RRock.png") Then
            Ties.Text = Val(Ties.Text) + 1
        ElseIf (UserPic.ImageLocation = "Dependencies\Paper.png" And CompPic.ImageLocation = "Dependencies\RPaper.png") Then
            Ties.Text = Val(Ties.Text) + 1
        ElseIf (UserPic.ImageLocation = "Dependencies\Scissors.png" And CompPic.ImageLocation = "Dependencies\RScissors.png") Then
            Ties.Text = Val(Ties.Text) + 1
        End If

        If (UserPic.ImageLocation = "Dependencies\Rock.png" And CompPic.ImageLocation = "Dependencies\RScissors.png") Then
            WinU.Text = Val(WinU.Text) + 1
        ElseIf (UserPic.ImageLocation = "Dependencies\Paper.png" And CompPic.ImageLocation = "Dependencies\RRock.png") Then
            WinU.Text = Val(WinU.Text) + 1
        ElseIf (UserPic.ImageLocation = "Dependencies\Scissors.png" And CompPic.ImageLocation = "Dependencies\RPaper.png") Then
            WinU.Text = Val(WinU.Text) + 1

        ElseIf (CompPic.ImageLocation = "Dependencies\RRock.png" And UserPic.ImageLocation = "Dependencies\Scissors.png") Then
            WinC.Text = Val(WinC.Text) + 1
        ElseIf (CompPic.ImageLocation = "Dependencies\RScissors.png" And UserPic.ImageLocation = "Dependencies\Paper.png") Then
            WinC.Text = Val(WinC.Text) + 1
        ElseIf (CompPic.ImageLocation = "Dependencies\RPaper.png" And UserPic.ImageLocation = "Dependencies\Rock.png") Then
            WinC.Text = Val(WinC.Text) + 1

        End If
    End Sub

    Public Sub Result()
        If Form2.rnum = Val(round.Text) Then
            TimerStop()
            RFlag = 1
            If (Val(WinU.Text) > Val(WinC.Text)) Then
                My.Computer.Audio.Play("Dependencies\click.wav")
                System.Threading.Thread.Sleep(200)
                round.Text = "0"
                Form3.Show()
                Form3.PictureBox1.ImageLocation = "Dependencies\Won.gif"
                My.Computer.Audio.Play("Dependencies\Won.wav")
            ElseIf (Val(WinC.Text) > Val(WinU.Text)) Then
                My.Computer.Audio.Play("Dependencies\click.wav")
                System.Threading.Thread.Sleep(200)
                round.Text = "0"
                Form3.Show()
                Form3.PictureBox1.ImageLocation = "Dependencies\Lost.gif"
                My.Computer.Audio.Play("Dependencies\Lost.wav")
            ElseIf (Val(WinC.Text) = Val(WinU.Text)) Then
                My.Computer.Audio.Play("Dependencies\click.wav")
                round.Text = "0"
                System.Threading.Thread.Sleep(200)
                Form3.Show()
                Form3.PictureBox1.ImageLocation = "Dependencies\Tie.png"
                My.Computer.Audio.Play("Dependencies\Ties.wav")
            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form2.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form4.Show()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Form5.Show()
    End Sub
End Class
