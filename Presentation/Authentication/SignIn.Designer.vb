Namespace Presentation
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class SignIn
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SignIn))
            Me.FPassLL = New System.Windows.Forms.Label()
            Me.ShowPassCB = New System.Windows.Forms.CheckBox()
            Me.PromptL = New System.Windows.Forms.Label()
            Me.SignUpLL = New System.Windows.Forms.LinkLabel()
            Me.SignInBtn = New System.Windows.Forms.Button()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.label_password = New System.Windows.Forms.Label()
            Me.Email = New System.Windows.Forms.Label()
            Me.button_close = New System.Windows.Forms.Button()
            Me.PictureBox1 = New System.Windows.Forms.PictureBox()
            Me.txt_password = New System.Windows.Forms.TextBox()
            Me.txt_username = New System.Windows.Forms.TextBox()
            Me.lbl_error_log = New System.Windows.Forms.Label()
            Me.lbl_error = New System.Windows.Forms.Label()
            CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'FPassLL
            '
            Me.FPassLL.AutoSize = True
            Me.FPassLL.BackColor = System.Drawing.Color.Transparent
            Me.FPassLL.Font = New System.Drawing.Font("IBM Plex Mono", 10.0!)
            Me.FPassLL.ForeColor = System.Drawing.Color.Blue
            Me.FPassLL.Location = New System.Drawing.Point(644, 501)
            Me.FPassLL.Name = "FPassLL"
            Me.FPassLL.Size = New System.Drawing.Size(136, 18)
            Me.FPassLL.TabIndex = 39
            Me.FPassLL.Text = "Forget Password?"
            '
            'ShowPassCB
            '
            Me.ShowPassCB.AutoSize = True
            Me.ShowPassCB.BackColor = System.Drawing.Color.Transparent
            Me.ShowPassCB.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.ShowPassCB.Font = New System.Drawing.Font("IBM Plex Mono", 9.0!)
            Me.ShowPassCB.Location = New System.Drawing.Point(573, 369)
            Me.ShowPassCB.Name = "ShowPassCB"
            Me.ShowPassCB.Size = New System.Drawing.Size(114, 19)
            Me.ShowPassCB.TabIndex = 36
            Me.ShowPassCB.Text = "Show Password"
            Me.ShowPassCB.UseVisualStyleBackColor = False
            '
            'PromptL
            '
            Me.PromptL.AutoSize = True
            Me.PromptL.BackColor = System.Drawing.Color.Transparent
            Me.PromptL.Font = New System.Drawing.Font("IBM Plex Mono", 10.0!)
            Me.PromptL.Location = New System.Drawing.Point(570, 543)
            Me.PromptL.Name = "PromptL"
            Me.PromptL.Size = New System.Drawing.Size(184, 18)
            Me.PromptL.TabIndex = 35
            Me.PromptL.Text = "Don't have an account?"
            '
            'SignUpLL
            '
            Me.SignUpLL.AutoSize = True
            Me.SignUpLL.BackColor = System.Drawing.Color.Transparent
            Me.SignUpLL.Font = New System.Drawing.Font("IBM Plex Mono", 10.0!)
            Me.SignUpLL.Location = New System.Drawing.Point(759, 541)
            Me.SignUpLL.Name = "SignUpLL"
            Me.SignUpLL.Size = New System.Drawing.Size(64, 18)
            Me.SignUpLL.TabIndex = 34
            Me.SignUpLL.TabStop = True
            Me.SignUpLL.Text = "Sign Up"
            '
            'SignInBtn
            '
            Me.SignInBtn.BackColor = System.Drawing.SystemColors.WindowText
            Me.SignInBtn.FlatAppearance.BorderSize = 0
            Me.SignInBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.SignInBtn.Font = New System.Drawing.Font("IBM Plex Mono", 15.0!)
            Me.SignInBtn.ForeColor = System.Drawing.Color.Transparent
            Me.SignInBtn.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.SignInBtn.Location = New System.Drawing.Point(573, 441)
            Me.SignInBtn.Name = "SignInBtn"
            Me.SignInBtn.Size = New System.Drawing.Size(248, 48)
            Me.SignInBtn.TabIndex = 33
            Me.SignInBtn.Text = "Sign In"
            Me.SignInBtn.UseVisualStyleBackColor = False
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.BackColor = System.Drawing.Color.Transparent
            Me.Label3.Font = New System.Drawing.Font("IBM Plex Mono", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label3.Location = New System.Drawing.Point(565, 106)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(314, 46)
            Me.Label3.TabIndex = 30
            Me.Label3.Text = "Welcome Back !"
            '
            'label_password
            '
            Me.label_password.AutoSize = True
            Me.label_password.BackColor = System.Drawing.Color.Transparent
            Me.label_password.Font = New System.Drawing.Font("IBM Plex Mono", 11.0!)
            Me.label_password.Location = New System.Drawing.Point(568, 305)
            Me.label_password.Name = "label_password"
            Me.label_password.Size = New System.Drawing.Size(81, 19)
            Me.label_password.TabIndex = 29
            Me.label_password.Text = "Password"
            '
            'Email
            '
            Me.Email.AutoSize = True
            Me.Email.BackColor = System.Drawing.Color.Transparent
            Me.Email.Font = New System.Drawing.Font("IBM Plex Mono", 11.0!)
            Me.Email.Location = New System.Drawing.Point(567, 214)
            Me.Email.Name = "Email"
            Me.Email.Size = New System.Drawing.Size(81, 19)
            Me.Email.TabIndex = 28
            Me.Email.Text = "Username"
            Me.Email.TextAlign = System.Drawing.ContentAlignment.BottomRight
            '
            'button_close
            '
            Me.button_close.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.button_close.BackColor = System.Drawing.Color.Transparent
            Me.button_close.FlatAppearance.BorderSize = 0
            Me.button_close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(35, Byte), Integer))
            Me.button_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.button_close.Image = Global.expense_Trackie.My.Resources.Resources.icons8_close_16
            Me.button_close.Location = New System.Drawing.Point(867, 0)
            Me.button_close.Margin = New System.Windows.Forms.Padding(0)
            Me.button_close.Name = "button_close"
            Me.button_close.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.button_close.Size = New System.Drawing.Size(50, 46)
            Me.button_close.TabIndex = 41
            Me.button_close.UseVisualStyleBackColor = False
            '
            'PictureBox1
            '
            Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
            Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
            Me.PictureBox1.Location = New System.Drawing.Point(36, 60)
            Me.PictureBox1.Name = "PictureBox1"
            Me.PictureBox1.Size = New System.Drawing.Size(484, 529)
            Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
            Me.PictureBox1.TabIndex = 42
            Me.PictureBox1.TabStop = False
            '
            'txt_password
            '
            Me.txt_password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.txt_password.Font = New System.Drawing.Font("IBM Plex Mono", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txt_password.Location = New System.Drawing.Point(567, 329)
            Me.txt_password.Name = "txt_password"
            Me.txt_password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
            Me.txt_password.Size = New System.Drawing.Size(248, 28)
            Me.txt_password.TabIndex = 56
            '
            'txt_username
            '
            Me.txt_username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.txt_username.Font = New System.Drawing.Font("IBM Plex Mono", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txt_username.Location = New System.Drawing.Point(568, 241)
            Me.txt_username.MaximumSize = New System.Drawing.Size(3000, 3000)
            Me.txt_username.MinimumSize = New System.Drawing.Size(20, 20)
            Me.txt_username.Name = "txt_username"
            Me.txt_username.Size = New System.Drawing.Size(247, 28)
            Me.txt_username.TabIndex = 55
            '
            'lbl_error_log
            '
            Me.lbl_error_log.AutoSize = True
            Me.lbl_error_log.BackColor = System.Drawing.Color.Transparent
            Me.lbl_error_log.Font = New System.Drawing.Font("IBM Plex Mono", 10.0!)
            Me.lbl_error_log.ForeColor = System.Drawing.Color.Red
            Me.lbl_error_log.Location = New System.Drawing.Point(569, 419)
            Me.lbl_error_log.Name = "lbl_error_log"
            Me.lbl_error_log.Size = New System.Drawing.Size(0, 18)
            Me.lbl_error_log.TabIndex = 57
            '
            'lbl_error
            '
            Me.lbl_error.AutoSize = True
            Me.lbl_error.BackColor = System.Drawing.Color.Transparent
            Me.lbl_error.Font = New System.Drawing.Font("IBM Plex Mono", 9.0!)
            Me.lbl_error.ForeColor = System.Drawing.Color.Red
            Me.lbl_error.Location = New System.Drawing.Point(584, 417)
            Me.lbl_error.Name = "lbl_error"
            Me.lbl_error.Size = New System.Drawing.Size(0, 15)
            Me.lbl_error.TabIndex = 58
            Me.lbl_error.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'SignIn
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(917, 668)
            Me.Controls.Add(Me.lbl_error)
            Me.Controls.Add(Me.lbl_error_log)
            Me.Controls.Add(Me.txt_password)
            Me.Controls.Add(Me.txt_username)
            Me.Controls.Add(Me.PictureBox1)
            Me.Controls.Add(Me.button_close)
            Me.Controls.Add(Me.FPassLL)
            Me.Controls.Add(Me.ShowPassCB)
            Me.Controls.Add(Me.PromptL)
            Me.Controls.Add(Me.SignUpLL)
            Me.Controls.Add(Me.SignInBtn)
            Me.Controls.Add(Me.Label3)
            Me.Controls.Add(Me.label_password)
            Me.Controls.Add(Me.Email)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            Me.Name = "SignIn"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "SIgnIn"
            CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        Friend WithEvents FPassLL As Label
        Friend WithEvents ShowPassCB As CheckBox
        Friend WithEvents PromptL As Label
        Friend WithEvents SignUpLL As LinkLabel
        Friend WithEvents SignInBtn As Button
        Friend WithEvents Label3 As Label
        Friend WithEvents label_password As Label
        Friend WithEvents Email As Label
        Friend WithEvents button_close As Button
        Friend WithEvents PictureBox1 As PictureBox
        Friend WithEvents txt_password As TextBox
        Friend WithEvents txt_username As TextBox
        Friend WithEvents lbl_error_log As Label
        Friend WithEvents lbl_error As Label
    End Class
End NameSpace