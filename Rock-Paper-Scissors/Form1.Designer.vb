<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.round = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.WinC = New System.Windows.Forms.TextBox()
        Me.Ties = New System.Windows.Forms.TextBox()
        Me.WinU = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Scissors = New System.Windows.Forms.Button()
        Me.Paper = New System.Windows.Forms.Button()
        Me.Rock = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.CompPic = New System.Windows.Forms.PictureBox()
        Me.UserPic = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CompPic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserPic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'round
        '
        Me.round.BackColor = System.Drawing.Color.White
        Me.round.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.round.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.round.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.round.Location = New System.Drawing.Point(418, 16)
        Me.round.Name = "round"
        Me.round.ReadOnly = True
        Me.round.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.round.Size = New System.Drawing.Size(52, 24)
        Me.round.TabIndex = 27
        Me.round.TabStop = False
        Me.round.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Crimson
        Me.Label4.Location = New System.Drawing.Point(317, 17)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(97, 23)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "R O U N D"
        '
        'WinC
        '
        Me.WinC.BackColor = System.Drawing.Color.White
        Me.WinC.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.WinC.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.WinC.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WinC.Location = New System.Drawing.Point(545, 75)
        Me.WinC.Name = "WinC"
        Me.WinC.ReadOnly = True
        Me.WinC.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.WinC.Size = New System.Drawing.Size(52, 24)
        Me.WinC.TabIndex = 25
        Me.WinC.TabStop = False
        Me.WinC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Ties
        '
        Me.Ties.BackColor = System.Drawing.Color.White
        Me.Ties.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Ties.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Ties.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ties.Location = New System.Drawing.Point(362, 75)
        Me.Ties.Name = "Ties"
        Me.Ties.ReadOnly = True
        Me.Ties.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Ties.Size = New System.Drawing.Size(52, 24)
        Me.Ties.TabIndex = 24
        Me.Ties.TabStop = False
        Me.Ties.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'WinU
        '
        Me.WinU.BackColor = System.Drawing.Color.White
        Me.WinU.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.WinU.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.WinU.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WinU.Location = New System.Drawing.Point(174, 75)
        Me.WinU.Name = "WinU"
        Me.WinU.ReadOnly = True
        Me.WinU.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.WinU.Size = New System.Drawing.Size(52, 24)
        Me.WinU.TabIndex = 23
        Me.WinU.TabStop = False
        Me.WinU.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label3.Location = New System.Drawing.Point(541, 49)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 23)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "W I N"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label2.Location = New System.Drawing.Point(358, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 23)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "T I E S"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label1.Location = New System.Drawing.Point(170, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 23)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "W I N"
        '
        'Timer1
        '
        Me.Timer1.Interval = 500
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.White
        Me.TextBox1.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.TextBox1.Font = New System.Drawing.Font("ChicagoFLF", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.Color.Crimson
        Me.TextBox1.Location = New System.Drawing.Point(342, 178)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TextBox1.Size = New System.Drawing.Size(90, 89)
        Me.TextBox1.TabIndex = 28
        Me.TextBox1.TabStop = False
        Me.TextBox1.Text = "0"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label5.Location = New System.Drawing.Point(1, 425)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 15)
        Me.Label5.TabIndex = 31
        Me.Label5.Text = "Options"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label6.Location = New System.Drawing.Point(720, 425)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 15)
        Me.Label6.TabIndex = 33
        Me.Label6.Text = "About"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Rock_Paper_Scissors.My.Resources.Resources.howtoplay
        Me.PictureBox1.Location = New System.Drawing.Point(657, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(93, 22)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 37
        Me.PictureBox1.TabStop = False
        '
        'Scissors
        '
        Me.Scissors.BackColor = System.Drawing.Color.Transparent
        Me.Scissors.BackgroundImage = Global.Rock_Paper_Scissors.My.Resources.Resources.Scissors_Button_1
        Me.Scissors.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Scissors.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Scissors.FlatAppearance.BorderSize = 0
        Me.Scissors.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.Scissors.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.Scissors.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Scissors.Location = New System.Drawing.Point(449, 349)
        Me.Scissors.Name = "Scissors"
        Me.Scissors.Size = New System.Drawing.Size(80, 80)
        Me.Scissors.TabIndex = 36
        Me.Scissors.UseVisualStyleBackColor = False
        '
        'Paper
        '
        Me.Paper.BackColor = System.Drawing.Color.Transparent
        Me.Paper.BackgroundImage = Global.Rock_Paper_Scissors.My.Resources.Resources.Paper_Button_1
        Me.Paper.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Paper.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Paper.FlatAppearance.BorderSize = 0
        Me.Paper.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.Paper.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.Paper.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Paper.Location = New System.Drawing.Point(343, 349)
        Me.Paper.Name = "Paper"
        Me.Paper.Size = New System.Drawing.Size(80, 80)
        Me.Paper.TabIndex = 35
        Me.Paper.UseVisualStyleBackColor = False
        '
        'Rock
        '
        Me.Rock.BackColor = System.Drawing.Color.Transparent
        Me.Rock.BackgroundImage = CType(resources.GetObject("Rock.BackgroundImage"), System.Drawing.Image)
        Me.Rock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Rock.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Rock.FlatAppearance.BorderSize = 0
        Me.Rock.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.Rock.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.Rock.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Rock.Location = New System.Drawing.Point(237, 349)
        Me.Rock.Name = "Rock"
        Me.Rock.Size = New System.Drawing.Size(80, 80)
        Me.Rock.TabIndex = 34
        Me.Rock.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.BackgroundImage = Global.Rock_Paper_Scissors.My.Resources.Resources.About
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button2.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSteelBlue
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(724, 392)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(33, 32)
        Me.Button2.TabIndex = 32
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button1.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(6, 393)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(33, 32)
        Me.Button1.TabIndex = 30
        Me.Button1.UseVisualStyleBackColor = False
        '
        'CompPic
        '
        Me.CompPic.Location = New System.Drawing.Point(387, 108)
        Me.CompPic.Name = "CompPic"
        Me.CompPic.Size = New System.Drawing.Size(365, 230)
        Me.CompPic.TabIndex = 16
        Me.CompPic.TabStop = False
        '
        'UserPic
        '
        Me.UserPic.Location = New System.Drawing.Point(14, 108)
        Me.UserPic.Name = "UserPic"
        Me.UserPic.Size = New System.Drawing.Size(365, 230)
        Me.UserPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.UserPic.TabIndex = 15
        Me.UserPic.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(762, 442)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Scissors)
        Me.Controls.Add(Me.Paper)
        Me.Controls.Add(Me.Rock)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.round)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.WinC)
        Me.Controls.Add(Me.Ties)
        Me.Controls.Add(Me.WinU)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CompPic)
        Me.Controls.Add(Me.UserPic)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Rock-Paper-Scissors"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CompPic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserPic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents round As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents WinC As TextBox
    Friend WithEvents Ties As TextBox
    Friend WithEvents WinU As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents CompPic As PictureBox
    Friend WithEvents UserPic As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Rock As Button
    Friend WithEvents Paper As Button
    Friend WithEvents Scissors As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
