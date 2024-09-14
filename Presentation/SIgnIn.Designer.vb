<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SIgnIn
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SIgnIn))
        Me.FPassLL = New System.Windows.Forms.Label()
        Me.ShowPassCB = New System.Windows.Forms.CheckBox()
        Me.PromptL = New System.Windows.Forms.Label()
        Me.SignUpLL = New System.Windows.Forms.LinkLabel()
        Me.SignInBtn = New System.Windows.Forms.Button()
        Me.txt_password = New System.Windows.Forms.TextBox()
        Me.txt_username = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Password = New System.Windows.Forms.Label()
        Me.Email = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FPassLL
        '
        Me.FPassLL.AutoSize = True
        Me.FPassLL.BackColor = System.Drawing.Color.Transparent
        Me.FPassLL.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FPassLL.ForeColor = System.Drawing.Color.Blue
        Me.FPassLL.Location = New System.Drawing.Point(600, 492)
        Me.FPassLL.Name = "FPassLL"
        Me.FPassLL.Size = New System.Drawing.Size(112, 17)
        Me.FPassLL.TabIndex = 39
        Me.FPassLL.Text = "Forget Password?"
        '
        'ShowPassCB
        '
        Me.ShowPassCB.AutoSize = True
        Me.ShowPassCB.BackColor = System.Drawing.Color.Transparent
        Me.ShowPassCB.Font = New System.Drawing.Font("Century Gothic", 8.150944!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ShowPassCB.Location = New System.Drawing.Point(543, 375)
        Me.ShowPassCB.Name = "ShowPassCB"
        Me.ShowPassCB.Size = New System.Drawing.Size(110, 20)
        Me.ShowPassCB.TabIndex = 36
        Me.ShowPassCB.Text = "Show Password"
        Me.ShowPassCB.UseVisualStyleBackColor = False
        '
        'PromptL
        '
        Me.PromptL.AutoSize = True
        Me.PromptL.BackColor = System.Drawing.Color.Transparent
        Me.PromptL.Font = New System.Drawing.Font("Century Gothic", 8.830189!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PromptL.Location = New System.Drawing.Point(540, 544)
        Me.PromptL.Name = "PromptL"
        Me.PromptL.Size = New System.Drawing.Size(152, 17)
        Me.PromptL.TabIndex = 35
        Me.PromptL.Text = "Don't have an account?"
        '
        'SignUpLL
        '
        Me.SignUpLL.AutoSize = True
        Me.SignUpLL.BackColor = System.Drawing.Color.Transparent
        Me.SignUpLL.Font = New System.Drawing.Font("Century Gothic", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SignUpLL.Location = New System.Drawing.Point(729, 542)
        Me.SignUpLL.Name = "SignUpLL"
        Me.SignUpLL.Size = New System.Drawing.Size(60, 19)
        Me.SignUpLL.TabIndex = 34
        Me.SignUpLL.TabStop = True
        Me.SignUpLL.Text = "Sign Up"
        '
        'SignInBtn
        '
        Me.SignInBtn.BackColor = System.Drawing.SystemColors.WindowText
        Me.SignInBtn.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SignInBtn.ForeColor = System.Drawing.Color.Transparent
        Me.SignInBtn.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.SignInBtn.Location = New System.Drawing.Point(543, 441)
        Me.SignInBtn.Name = "SignInBtn"
        Me.SignInBtn.Size = New System.Drawing.Size(248, 48)
        Me.SignInBtn.TabIndex = 33
        Me.SignInBtn.Text = "Sign In"
        Me.SignInBtn.UseVisualStyleBackColor = False
        '
        'txt_password
        '
        Me.txt_password.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.txt_password.Location = New System.Drawing.Point(541, 343)
        Me.txt_password.Name = "txt_password"
        Me.txt_password.Size = New System.Drawing.Size(248, 26)
        Me.txt_password.TabIndex = 32
        '
        'txt_username
        '
        Me.txt_username.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.txt_username.Location = New System.Drawing.Point(542, 245)
        Me.txt_username.MaximumSize = New System.Drawing.Size(3000, 3000)
        Me.txt_username.MinimumSize = New System.Drawing.Size(20, 20)
        Me.txt_username.Name = "txt_username"
        Me.txt_username.Size = New System.Drawing.Size(247, 26)
        Me.txt_username.TabIndex = 31
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 25.81132!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(535, 98)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(147, 41)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "SIGN IN"
        '
        'Password
        '
        Me.Password.AutoSize = True
        Me.Password.BackColor = System.Drawing.Color.Transparent
        Me.Password.Font = New System.Drawing.Font("Century Gothic", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Password.Location = New System.Drawing.Point(586, 306)
        Me.Password.Name = "Password"
        Me.Password.Size = New System.Drawing.Size(72, 19)
        Me.Password.TabIndex = 29
        Me.Password.Text = "Password"
        '
        'Email
        '
        Me.Email.AutoSize = True
        Me.Email.BackColor = System.Drawing.Color.Transparent
        Me.Email.Font = New System.Drawing.Font("Century Gothic", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Email.Location = New System.Drawing.Point(586, 209)
        Me.Email.Name = "Email"
        Me.Email.Size = New System.Drawing.Size(77, 19)
        Me.Email.TabIndex = 28
        Me.Email.Text = "Username"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Image = CType(resources.GetObject("Label7.Image"), System.Drawing.Image)
        Me.Label7.Location = New System.Drawing.Point(539, 287)
        Me.Label7.Name = "Label7"
        Me.Label7.Padding = New System.Windows.Forms.Padding(20)
        Me.Label7.Size = New System.Drawing.Size(40, 53)
        Me.Label7.TabIndex = 38
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Image = CType(resources.GetObject("Label6.Image"), System.Drawing.Image)
        Me.Label6.Location = New System.Drawing.Point(540, 189)
        Me.Label6.Name = "Label6"
        Me.Label6.Padding = New System.Windows.Forms.Padding(20)
        Me.Label6.Size = New System.Drawing.Size(40, 53)
        Me.Label6.TabIndex = 37
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(92, 125)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(395, 394)
        Me.PictureBox1.TabIndex = 40
        Me.PictureBox1.TabStop = False
        '
        'SIgnIn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(917, 685)
        Me.Controls.Add(Me.FPassLL)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.ShowPassCB)
        Me.Controls.Add(Me.PromptL)
        Me.Controls.Add(Me.SignUpLL)
        Me.Controls.Add(Me.SignInBtn)
        Me.Controls.Add(Me.txt_password)
        Me.Controls.Add(Me.txt_username)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Password)
        Me.Controls.Add(Me.Email)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "SIgnIn"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SIgnIn"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents FPassLL As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents ShowPassCB As CheckBox
    Friend WithEvents PromptL As Label
    Friend WithEvents SignUpLL As LinkLabel
    Friend WithEvents SignInBtn As Button
    Friend WithEvents txt_password As TextBox
    Friend WithEvents txt_username As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Password As Label
    Friend WithEvents Email As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
