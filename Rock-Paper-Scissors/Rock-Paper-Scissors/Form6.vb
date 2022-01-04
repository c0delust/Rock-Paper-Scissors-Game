Public Class Form6

    Private Const AW_BLEND = &H80000  'Uses a fade effect. This flag can be used only if hwnd is a top-level window.
    Private Declare Function AnimateWindow Lib "user32" (ByVal hwnd As Int32, ByVal dwTime As Int32, ByVal dwFlags As Int32) As Boolean
    Dim winHide As Integer = &H10000
    Dim winBlend As Integer = &H80000

    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Form1.Enabled = False
        Me.TopMost = True
        ProgressBar1.Minimum = 0
        ProgressBar1.Maximum = 101
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(1)
        Label3.Text = ProgressBar1.Value
        If ProgressBar1.Value = 101 Then
            Timer1.Stop()
            Threading.Thread.Sleep(500)
            Form1.Enabled = True
            Close()
        End If
        FileExistCheck()
    End Sub

    Private Sub FileExistCheck()
        Select Case ProgressBar1.Value
            Case 5
                Label4.Text = ("Dependencies\About.png")
                If Not System.IO.File.Exists("Dependencies\About.png") Then
                    Stopper()
                    MsgBox("Dependencies\About.png - File not Found", Title:="Error !")
                    AppExit()
                End If
            Case 10
                Label4.Text = ("Dependencies\appear.wav")
                If Not System.IO.File.Exists("Dependencies\appear.wav") Then
                    Stopper()
                    MsgBox("Dependencies\appear.wav - File not Found", Title:="Error !")
                    AppExit()
                End If
            Case 15
                Label4.Text = ("Dependencies\click.wav")
                If Not System.IO.File.Exists("Dependencies\click.wav") Then
                    Stopper()
                    MsgBox("Dependencies\click.wav - File not Found", Title:="Error !")
                    AppExit()
                End If
            Case 20
                Label4.Text = ("Dependencies\Lost.gif")
                If Not System.IO.File.Exists("Dependencies\Lost.gif") Then
                    Stopper()
                    MsgBox("Dependencies\Lost.gif - File not Found", Title:="Error !")
                    AppExit()
                End If
            Case 25
                Label4.Text = ("Dependencies\Lost.wav")
                If Not System.IO.File.Exists("Dependencies\Lost.wav") Then
                    Stopper()
                    MsgBox("Dependencies\Lost.wav - File not Found", Title:="Error !")
                    AppExit()
                End If
            Case 30
                Label4.Text = ("Dependencies\main.ico")
                If Not System.IO.File.Exists("Dependencies\main.ico") Then
                    Stopper()
                    MsgBox("Dependencies\main.ico - File not Found", Title:="Error !")
                    AppExit()
                End If
            Case 35
                Label4.Text = ("Dependencies\main_icon.ico")
                If Not System.IO.File.Exists("Dependencies\main_icon.ico") Then
                    Stopper()
                    MsgBox("Dependencies\main_icon.ico - File not Found", Title:="Error !")
                    AppExit()
                End If
            Case 40
                Label4.Text = ("Dependencies\Paper.png")
                If Not System.IO.File.Exists("Dependencies\Paper.png") Then
                    Stopper()
                    MsgBox("Dependencies\Paper.png - File not Found", Title:="Error !")
                    AppExit()
                End If
            Case 45
                Label4.Text = ("Dependencies\Rock.png")
                If Not System.IO.File.Exists("Dependencies\Rock.png") Then
                    Stopper()
                    MsgBox("Dependencies\Rock.png - File not Found", Title:="Error !")
                    AppExit()
                End If
            Case 50
                Label4.Text = ("Dependencies\RPaper.png")
                If Not System.IO.File.Exists("Dependencies\RPaper.png") Then
                    Stopper()
                    MsgBox("Dependencies\RPaper.png - File not Found", Title:="Error !")
                    AppExit()
                End If
            Case 55
                Label4.Text = ("Dependencies\RRock.png")
                If Not System.IO.File.Exists("Dependencies\RRock.png") Then
                    Stopper()
                    MsgBox("Dependencies\RRock.png - File not Found", Title:="Error !")
                    AppExit()
                End If
            Case 60
                Label4.Text = ("Dependencies\RScissors.png")
                If Not System.IO.File.Exists("Dependencies\RScissors.png") Then
                    Stopper()
                    MsgBox("Dependencies\RScissors.png - File not Found", Title:="Error !")
                    AppExit()
                End If
            Case 65
                Label4.Text = ("Dependencies\Scissors.png")
                If Not System.IO.File.Exists("Dependencies\Scissors.png") Then
                    Stopper()
                    MsgBox("Dependencies\Scissors.png - File not Found", Title:="Error !")
                    AppExit()
                End If
            Case 70
                Label4.Text = ("Dependencies\SoundVolumeView.exe")
                If Not System.IO.File.Exists("Dependencies\SoundVolumeView.exe") Then
                    Stopper()
                    MsgBox("Dependencies\SoundVolumeView.exe - File not Found", Title:="Error !")
                    AppExit()
                End If
            Case 75
                Label4.Text = ("Dependencies\tick.wav")
                If Not System.IO.File.Exists("Dependencies\tick.wav") Then
                    Stopper()
                    MsgBox("Dependencies\tick.wav - File not Found", Title:="Error !")
                    AppExit()
                End If
            Case 80
                Label4.Text = ("Dependencies\Tie.png")
                If Not System.IO.File.Exists("Dependencies\Tie.png") Then
                    Stopper()
                    MsgBox("Dependencies\Tie.png - File not Found", Title:="Error !")
                    AppExit()
                End If
            Case 85
                Label4.Text = ("Dependencies\Ties.wav")
                If Not System.IO.File.Exists("Dependencies\Ties.wav") Then
                    Stopper()
                    MsgBox("Dependencies\Ties.wav - File not Found", Title:="Error !")
                    AppExit()
                End If
            Case 90
                Label4.Text = ("Dependencies\Won.gif")
                If Not System.IO.File.Exists("Dependencies\Won.gif") Then
                    Stopper()
                    MsgBox("Dependencies\Won.gif - File not Found", Title:="Error !")
                    AppExit()
                End If
            Case 95
                Label4.Text = ("Dependencies\Won.wav")
                If Not System.IO.File.Exists("Dependencies\Won.wav") Then
                    Stopper()
                    MsgBox("Dependencies\Won.wav - File not Found", Title:="Error !")
                    AppExit()
                End If
            Case 100
                Label4.Text = ("Ok")
        End Select
    End Sub

    Private Sub Stopper()
        Me.TopMost = False
        Timer1.Stop()
        My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Asterisk)
    End Sub

    Private Sub AppExit()
        AnimateWindow(Me.Handle.ToInt32, CInt(500), winHide Or winBlend)
        AnimateWindow(Form1.Handle.ToInt32, CInt(1000), winHide Or winBlend)
        Application.Exit()
    End Sub

End Class