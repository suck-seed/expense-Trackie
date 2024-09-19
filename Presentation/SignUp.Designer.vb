Namespace Presentation
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class SignUp
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SignUp))
            Me.Label4 = New System.Windows.Forms.Label()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.ShowPassCB = New System.Windows.Forms.CheckBox()
            Me.btn_signup = New System.Windows.Forms.Button()
            Me.txt_password = New System.Windows.Forms.TextBox()
            Me.txt_username = New System.Windows.Forms.TextBox()
            Me.txt_number = New System.Windows.Forms.TextBox()
            Me.SignInLL = New System.Windows.Forms.LinkLabel()
            Me.PromptL = New System.Windows.Forms.Label()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.PictureBox1 = New System.Windows.Forms.PictureBox()
            Me.button_close = New System.Windows.Forms.Button()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.btn_select_profile = New System.Windows.Forms.Button()
            Me.profilePicture = New System.Windows.Forms.Button()
            Me.pictureBoxProfile = New System.Windows.Forms.PictureBox()
            CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.pictureBoxProfile, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.BackColor = System.Drawing.Color.Transparent
            Me.Label4.Font = New System.Drawing.Font("Cascadia Mono SemiLight", 11.25!)
            Me.Label4.Location = New System.Drawing.Point(613, 447)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(81, 20)
            Me.Label4.TabIndex = 36
            Me.Label4.Text = "Password"
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.BackColor = System.Drawing.Color.Transparent
            Me.Label3.Font = New System.Drawing.Font("Cascadia Mono SemiLight", 11.25!)
            Me.Label3.Location = New System.Drawing.Point(617, 349)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(81, 20)
            Me.Label3.TabIndex = 35
            Me.Label3.Text = "Username"
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.BackColor = System.Drawing.Color.Transparent
            Me.Label1.Font = New System.Drawing.Font("Cascadia Mono SemiLight", 11.25!)
            Me.Label1.Location = New System.Drawing.Point(617, 245)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(63, 20)
            Me.Label1.TabIndex = 34
            Me.Label1.Text = "Number"
            '
            'ShowPassCB
            '
            Me.ShowPassCB.AutoSize = True
            Me.ShowPassCB.Font = New System.Drawing.Font("Cascadia Mono", 8.25!)
            Me.ShowPassCB.Location = New System.Drawing.Point(621, 498)
            Me.ShowPassCB.Name = "ShowPassCB"
            Me.ShowPassCB.Size = New System.Drawing.Size(104, 19)
            Me.ShowPassCB.TabIndex = 28
            Me.ShowPassCB.Text = "Show Password"
            Me.ShowPassCB.UseVisualStyleBackColor = True
            '
            'btn_signup
            '
            Me.btn_signup.BackColor = System.Drawing.SystemColors.InactiveCaptionText
            Me.btn_signup.FlatAppearance.BorderSize = 0
            Me.btn_signup.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btn_signup.Font = New System.Drawing.Font("Cascadia Code", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btn_signup.ForeColor = System.Drawing.Color.Transparent
            Me.btn_signup.Location = New System.Drawing.Point(620, 579)
            Me.btn_signup.Name = "btn_signup"
            Me.btn_signup.Size = New System.Drawing.Size(247, 48)
            Me.btn_signup.TabIndex = 27
            Me.btn_signup.Text = "Sign Up"
            Me.btn_signup.UseVisualStyleBackColor = False
            '
            'txt_password
            '
            Me.txt_password.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txt_password.Location = New System.Drawing.Point(620, 469)
            Me.txt_password.MaximumSize = New System.Drawing.Size(500, 500)
            Me.txt_password.MinimumSize = New System.Drawing.Size(20, 20)
            Me.txt_password.Name = "txt_password"
            Me.txt_password.Size = New System.Drawing.Size(247, 26)
            Me.txt_password.TabIndex = 26
            '
            'txt_username
            '
            Me.txt_username.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txt_username.Location = New System.Drawing.Point(620, 371)
            Me.txt_username.Name = "txt_username"
            Me.txt_username.Size = New System.Drawing.Size(247, 26)
            Me.txt_username.TabIndex = 25
            '
            'txt_number
            '
            Me.txt_number.BackColor = System.Drawing.SystemColors.Window
            Me.txt_number.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txt_number.Location = New System.Drawing.Point(620, 268)
            Me.txt_number.Name = "txt_number"
            Me.txt_number.Size = New System.Drawing.Size(247, 26)
            Me.txt_number.TabIndex = 24
            '
            'SignInLL
            '
            Me.SignInLL.AutoSize = True
            Me.SignInLL.Font = New System.Drawing.Font("Cascadia Mono", 9.0!)
            Me.SignInLL.Location = New System.Drawing.Point(800, 637)
            Me.SignInLL.Name = "SignInLL"
            Me.SignInLL.Size = New System.Drawing.Size(56, 16)
            Me.SignInLL.TabIndex = 23
            Me.SignInLL.TabStop = True
            Me.SignInLL.Text = "Sign In"
            '
            'PromptL
            '
            Me.PromptL.AutoSize = True
            Me.PromptL.BackColor = System.Drawing.Color.Transparent
            Me.PromptL.Font = New System.Drawing.Font("Cascadia Mono", 9.0!)
            Me.PromptL.Location = New System.Drawing.Point(627, 639)
            Me.PromptL.Name = "PromptL"
            Me.PromptL.Size = New System.Drawing.Size(175, 16)
            Me.PromptL.TabIndex = 22
            Me.PromptL.Text = "Already have an account?"
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Font = New System.Drawing.Font("Cascadia Mono", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label2.Location = New System.Drawing.Point(613, 62)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(167, 46)
            Me.Label2.TabIndex = 21
            Me.Label2.Text = "SIGN UP"
            '
            'PictureBox1
            '
            Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
            Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
            Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.PictureBox1.Location = New System.Drawing.Point(5, 62)
            Me.PictureBox1.Name = "PictureBox1"
            Me.PictureBox1.Size = New System.Drawing.Size(602, 623)
            Me.PictureBox1.TabIndex = 32
            Me.PictureBox1.TabStop = False
            '
            'button_close
            '
            Me.button_close.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.button_close.BackColor = System.Drawing.Color.Transparent
            Me.button_close.FlatAppearance.BorderSize = 0
            Me.button_close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(35, Byte), Integer))
            Me.button_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.button_close.Image = Global.expense_Trackie.My.Resources.Resources.icons8_close_16
            Me.button_close.Location = New System.Drawing.Point(917, 0)
            Me.button_close.Margin = New System.Windows.Forms.Padding(0)
            Me.button_close.Name = "button_close"
            Me.button_close.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.button_close.Size = New System.Drawing.Size(50, 46)
            Me.button_close.TabIndex = 42
            Me.button_close.UseVisualStyleBackColor = False
            '
            'Label5
            '
            Me.Label5.AutoSize = True
            Me.Label5.BackColor = System.Drawing.Color.Transparent
            Me.Label5.Font = New System.Drawing.Font("Cascadia Mono SemiLight", 11.25!)
            Me.Label5.Location = New System.Drawing.Point(617, 159)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(72, 20)
            Me.Label5.TabIndex = 43
            Me.Label5.Text = "Profile"
            '
            'btn_select_profile
            '
            Me.btn_select_profile.Font = New System.Drawing.Font("Cascadia Mono", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btn_select_profile.Location = New System.Drawing.Point(621, 181)
            Me.btn_select_profile.Name = "btn_select_profile"
            Me.btn_select_profile.Size = New System.Drawing.Size(75, 23)
            Me.btn_select_profile.TabIndex = 44
            Me.btn_select_profile.Text = "Select"
            Me.btn_select_profile.UseVisualStyleBackColor = True
            '
            'profilePicture
            '
            Me.profilePicture.FlatAppearance.BorderSize = 0
            Me.profilePicture.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.profilePicture.Image = Global.expense_Trackie.My.Resources.Resources.profileLight
            Me.profilePicture.Location = New System.Drawing.Point(705, 159)
            Me.profilePicture.Name = "profilePicture"
            Me.profilePicture.Size = New System.Drawing.Size(51, 45)
            Me.profilePicture.TabIndex = 45
            Me.profilePicture.UseVisualStyleBackColor = True
            '
            'pictureBoxProfile
            '
            Me.pictureBoxProfile.Location = New System.Drawing.Point(762, 159)
            Me.pictureBoxProfile.Name = "pictureBoxProfile"
            Me.pictureBoxProfile.Size = New System.Drawing.Size(59, 45)
            Me.pictureBoxProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
            Me.pictureBoxProfile.TabIndex = 46
            Me.pictureBoxProfile.TabStop = False
            '
            'SignUp
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(969, 750)
            Me.Controls.Add(Me.pictureBoxProfile)
            Me.Controls.Add(Me.profilePicture)
            Me.Controls.Add(Me.btn_select_profile)
            Me.Controls.Add(Me.Label5)
            Me.Controls.Add(Me.button_close)
            Me.Controls.Add(Me.Label4)
            Me.Controls.Add(Me.Label3)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.ShowPassCB)
            Me.Controls.Add(Me.btn_signup)
            Me.Controls.Add(Me.txt_password)
            Me.Controls.Add(Me.txt_username)
            Me.Controls.Add(Me.txt_number)
            Me.Controls.Add(Me.SignInLL)
            Me.Controls.Add(Me.PromptL)
            Me.Controls.Add(Me.Label2)
            Me.Controls.Add(Me.PictureBox1)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            Me.Name = "SignUp"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "SignUp"
            CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.pictureBoxProfile, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        Friend WithEvents Label4 As Label
        Friend WithEvents Label3 As Label
        Friend WithEvents Label1 As Label
        Friend WithEvents ShowPassCB As CheckBox
        Friend WithEvents btn_signup As Button
        Friend WithEvents txt_password As TextBox
        Friend WithEvents txt_username As TextBox
        Friend WithEvents txt_number As TextBox
        Friend WithEvents SignInLL As LinkLabel
        Friend WithEvents PromptL As Label
        Friend WithEvents Label2 As Label
        Friend WithEvents PictureBox1 As PictureBox
        Friend WithEvents button_close As Button
        Friend WithEvents Label5 As Label
        Friend WithEvents btn_select_profile As Button
        Friend WithEvents profilePicture As Button
        Friend WithEvents pictureBoxProfile As PictureBox
    End Class
End NameSpace