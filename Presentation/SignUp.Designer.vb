<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SignUp
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SignUp))
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ShowPassCB = New System.Windows.Forms.CheckBox()
        Me.btn_signup = New System.Windows.Forms.Button()
        Me.txt_password = New System.Windows.Forms.TextBox()
        Me.txt_username = New System.Windows.Forms.TextBox()
        Me.txt_number = New System.Windows.Forms.TextBox()
        Me.SignInLL = New System.Windows.Forms.LinkLabel()
        Me.PromptL = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 10.18868!)
        Me.Label4.Location = New System.Drawing.Point(608, 367)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 19)
        Me.Label4.TabIndex = 36
        Me.Label4.Text = "Password"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 10.18868!)
        Me.Label3.Location = New System.Drawing.Point(612, 269)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 19)
        Me.Label3.TabIndex = 35
        Me.Label3.Text = "Username"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 10.18868!)
        Me.Label1.Location = New System.Drawing.Point(612, 165)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 19)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "Number"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Image = CType(resources.GetObject("Label9.Image"), System.Drawing.Image)
        Me.Label9.Location = New System.Drawing.Point(570, 353)
        Me.Label9.Name = "Label9"
        Me.Label9.Padding = New System.Windows.Forms.Padding(15, 10, 15, 10)
        Me.Label9.Size = New System.Drawing.Size(30, 33)
        Me.Label9.TabIndex = 31
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Image = CType(resources.GetObject("Label8.Image"), System.Drawing.Image)
        Me.Label8.Location = New System.Drawing.Point(570, 255)
        Me.Label8.Name = "Label8"
        Me.Label8.Padding = New System.Windows.Forms.Padding(18, 10, 18, 10)
        Me.Label8.Size = New System.Drawing.Size(36, 33)
        Me.Label8.TabIndex = 30
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Image = CType(resources.GetObject("Label7.Image"), System.Drawing.Image)
        Me.Label7.Location = New System.Drawing.Point(570, 165)
        Me.Label7.Name = "Label7"
        Me.Label7.Padding = New System.Windows.Forms.Padding(18, 5, 18, 5)
        Me.Label7.Size = New System.Drawing.Size(36, 23)
        Me.Label7.TabIndex = 29
        '
        'ShowPassCB
        '
        Me.ShowPassCB.AutoSize = True
        Me.ShowPassCB.Font = New System.Drawing.Font("Century Gothic", 8.830189!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ShowPassCB.Location = New System.Drawing.Point(563, 436)
        Me.ShowPassCB.Name = "ShowPassCB"
        Me.ShowPassCB.Size = New System.Drawing.Size(117, 21)
        Me.ShowPassCB.TabIndex = 28
        Me.ShowPassCB.Text = "Show Password"
        Me.ShowPassCB.UseVisualStyleBackColor = True
        '
        'btn_signup
        '
        Me.btn_signup.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.btn_signup.Font = New System.Drawing.Font("Century Gothic", 14.26415!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_signup.ForeColor = System.Drawing.Color.Transparent
        Me.btn_signup.Location = New System.Drawing.Point(563, 509)
        Me.btn_signup.Name = "btn_signup"
        Me.btn_signup.Size = New System.Drawing.Size(247, 48)
        Me.btn_signup.TabIndex = 27
        Me.btn_signup.Text = "Sign Up"
        Me.btn_signup.UseVisualStyleBackColor = False
        '
        'txt_password
        '
        Me.txt_password.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_password.Location = New System.Drawing.Point(563, 399)
        Me.txt_password.MaximumSize = New System.Drawing.Size(500, 500)
        Me.txt_password.MinimumSize = New System.Drawing.Size(20, 20)
        Me.txt_password.Name = "txt_password"
        Me.txt_password.Size = New System.Drawing.Size(247, 26)
        Me.txt_password.TabIndex = 26
        '
        'txt_username
        '
        Me.txt_username.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_username.Location = New System.Drawing.Point(563, 301)
        Me.txt_username.Name = "txt_username"
        Me.txt_username.Size = New System.Drawing.Size(247, 26)
        Me.txt_username.TabIndex = 25
        '
        'txt_number
        '
        Me.txt_number.BackColor = System.Drawing.SystemColors.Window
        Me.txt_number.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_number.Location = New System.Drawing.Point(563, 198)
        Me.txt_number.Name = "txt_number"
        Me.txt_number.Size = New System.Drawing.Size(247, 26)
        Me.txt_number.TabIndex = 24
        '
        'SignInLL
        '
        Me.SignInLL.AutoSize = True
        Me.SignInLL.Font = New System.Drawing.Font("Century Gothic", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SignInLL.Location = New System.Drawing.Point(743, 560)
        Me.SignInLL.Name = "SignInLL"
        Me.SignInLL.Size = New System.Drawing.Size(53, 19)
        Me.SignInLL.TabIndex = 23
        Me.SignInLL.TabStop = True
        Me.SignInLL.Text = "Sign In"
        '
        'PromptL
        '
        Me.PromptL.AutoSize = True
        Me.PromptL.BackColor = System.Drawing.Color.Transparent
        Me.PromptL.Font = New System.Drawing.Font("Century Gothic", 8.830189!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PromptL.Location = New System.Drawing.Point(570, 562)
        Me.PromptL.Name = "PromptL"
        Me.PromptL.Size = New System.Drawing.Size(167, 17)
        Me.PromptL.TabIndex = 22
        Me.PromptL.Text = "Already have an account?"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 25.81132!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(556, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(153, 41)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "SIGN UP"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(-45, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(602, 623)
        Me.PictureBox1.TabIndex = 32
        Me.PictureBox1.TabStop = False
        '
        'SignUp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(835, 633)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.ShowPassCB)
        Me.Controls.Add(Me.btn_signup)
        Me.Controls.Add(Me.txt_password)
        Me.Controls.Add(Me.txt_username)
        Me.Controls.Add(Me.txt_number)
        Me.Controls.Add(Me.SignInLL)
        Me.Controls.Add(Me.PromptL)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "SignUp"
        Me.Text = "SignUp"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents ShowPassCB As CheckBox
    Friend WithEvents btn_signup As Button
    Friend WithEvents txt_password As TextBox
    Friend WithEvents txt_username As TextBox
    Friend WithEvents txt_number As TextBox
    Friend WithEvents SignInLL As LinkLabel
    Friend WithEvents PromptL As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
