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
            Me.components = New System.ComponentModel.Container()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SignUp))
            Me.btn_signup = New System.Windows.Forms.Button()
            Me.txt_password = New System.Windows.Forms.TextBox()
            Me.txt_username = New System.Windows.Forms.TextBox()
            Me.txt_number = New System.Windows.Forms.TextBox()
            Me.SignInLL = New System.Windows.Forms.LinkLabel()
            Me.PromptL = New System.Windows.Forms.Label()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
            Me.lbl_info = New System.Windows.Forms.Label()
            Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
            Me.check_showPassword = New System.Windows.Forms.CheckBox()
            Me.img_profile = New System.Windows.Forms.PictureBox()
            Me.infoTool = New System.Windows.Forms.PictureBox()
            Me.svgInfo = New System.Windows.Forms.PictureBox()
            Me.button_close = New System.Windows.Forms.Button()
            Me.PictureBox1 = New System.Windows.Forms.PictureBox()
            Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
            Me.Label6 = New System.Windows.Forms.Label()
            Me.Label7 = New System.Windows.Forms.Label()
            Me.Label8 = New System.Windows.Forms.Label()
            Me.panel_topbar = New System.Windows.Forms.Panel()
            Me.TableLayoutPanel1.SuspendLayout()
            CType(Me.img_profile, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.infoTool, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.svgInfo, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.TableLayoutPanel2.SuspendLayout()
            Me.panel_topbar.SuspendLayout()
            Me.SuspendLayout()
            '
            'btn_signup
            '
            Me.btn_signup.BackColor = System.Drawing.SystemColors.InactiveCaptionText
            Me.btn_signup.FlatAppearance.BorderSize = 0
            Me.btn_signup.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btn_signup.Font = New System.Drawing.Font("IBM Plex Mono", 15.0!, System.Drawing.FontStyle.Bold)
            Me.btn_signup.ForeColor = System.Drawing.Color.Transparent
            Me.btn_signup.Location = New System.Drawing.Point(712, 555)
            Me.btn_signup.Name = "btn_signup"
            Me.btn_signup.Size = New System.Drawing.Size(247, 48)
            Me.btn_signup.TabIndex = 27
            Me.btn_signup.Text = "Sign Up"
            Me.btn_signup.UseVisualStyleBackColor = False
            '
            'txt_password
            '
            Me.txt_password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.txt_password.Dock = System.Windows.Forms.DockStyle.Fill
            Me.txt_password.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txt_password.Location = New System.Drawing.Point(3, 312)
            Me.txt_password.MaximumSize = New System.Drawing.Size(500, 500)
            Me.txt_password.MinimumSize = New System.Drawing.Size(20, 20)
            Me.txt_password.Name = "txt_password"
            Me.txt_password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
            Me.txt_password.Size = New System.Drawing.Size(265, 26)
            Me.txt_password.TabIndex = 26
            '
            'txt_username
            '
            Me.txt_username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.txt_username.Dock = System.Windows.Forms.DockStyle.Fill
            Me.txt_username.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txt_username.Location = New System.Drawing.Point(3, 152)
            Me.txt_username.Name = "txt_username"
            Me.txt_username.Size = New System.Drawing.Size(265, 26)
            Me.txt_username.TabIndex = 25
            '
            'txt_number
            '
            Me.txt_number.BackColor = System.Drawing.SystemColors.Window
            Me.txt_number.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.txt_number.Dock = System.Windows.Forms.DockStyle.Fill
            Me.txt_number.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txt_number.Location = New System.Drawing.Point(3, 232)
            Me.txt_number.Name = "txt_number"
            Me.txt_number.Size = New System.Drawing.Size(265, 26)
            Me.txt_number.TabIndex = 24
            '
            'SignInLL
            '
            Me.SignInLL.AutoSize = True
            Me.SignInLL.Font = New System.Drawing.Font("IBM Plex Mono", 9.0!)
            Me.SignInLL.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
            Me.SignInLL.LinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(196, Byte), Integer))
            Me.SignInLL.Location = New System.Drawing.Point(892, 613)
            Me.SignInLL.Name = "SignInLL"
            Me.SignInLL.Size = New System.Drawing.Size(56, 15)
            Me.SignInLL.TabIndex = 23
            Me.SignInLL.TabStop = True
            Me.SignInLL.Text = "Sign In"
            '
            'PromptL
            '
            Me.PromptL.AutoSize = True
            Me.PromptL.BackColor = System.Drawing.Color.Transparent
            Me.PromptL.Font = New System.Drawing.Font("IBM Plex Mono", 9.0!)
            Me.PromptL.Location = New System.Drawing.Point(719, 615)
            Me.PromptL.Name = "PromptL"
            Me.PromptL.Size = New System.Drawing.Size(175, 15)
            Me.PromptL.TabIndex = 22
            Me.PromptL.Text = "Already have an account?"
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.BackColor = System.Drawing.Color.Transparent
            Me.Label2.Font = New System.Drawing.Font("IBM Plex Mono", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label2.Location = New System.Drawing.Point(748, 80)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(167, 46)
            Me.Label2.TabIndex = 21
            Me.Label2.Text = "SIGN UP"
            '
            'lbl_info
            '
            Me.lbl_info.AutoSize = True
            Me.lbl_info.BackColor = System.Drawing.Color.Transparent
            Me.lbl_info.Dock = System.Windows.Forms.DockStyle.Fill
            Me.lbl_info.Font = New System.Drawing.Font("IBM Plex Mono", 9.0!)
            Me.lbl_info.ForeColor = System.Drawing.Color.Red
            Me.lbl_info.Location = New System.Drawing.Point(3, 0)
            Me.lbl_info.Name = "lbl_info"
            Me.lbl_info.Size = New System.Drawing.Size(299, 32)
            Me.lbl_info.TabIndex = 82
            Me.lbl_info.Text = "error"
            Me.lbl_info.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'TableLayoutPanel1
            '
            Me.TableLayoutPanel1.BackColor = System.Drawing.Color.Transparent
            Me.TableLayoutPanel1.ColumnCount = 1
            Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
            Me.TableLayoutPanel1.Controls.Add(Me.lbl_info, 0, 0)
            Me.TableLayoutPanel1.Location = New System.Drawing.Point(682, 517)
            Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
            Me.TableLayoutPanel1.RowCount = 1
            Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
            Me.TableLayoutPanel1.Size = New System.Drawing.Size(305, 32)
            Me.TableLayoutPanel1.TabIndex = 83
            '
            'check_showPassword
            '
            Me.check_showPassword.Appearance = System.Windows.Forms.Appearance.Button
            Me.check_showPassword.BackColor = System.Drawing.Color.Transparent
            Me.check_showPassword.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter
            Me.check_showPassword.FlatAppearance.BorderSize = 0
            Me.check_showPassword.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
            Me.check_showPassword.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
            Me.check_showPassword.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
            Me.check_showPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.check_showPassword.Image = Global.expense_Trackie.My.Resources.Resources.showpassword
            Me.check_showPassword.Location = New System.Drawing.Point(669, 447)
            Me.check_showPassword.Name = "check_showPassword"
            Me.check_showPassword.Size = New System.Drawing.Size(26, 34)
            Me.check_showPassword.TabIndex = 87
            Me.check_showPassword.TextAlign = System.Drawing.ContentAlignment.TopLeft
            Me.check_showPassword.UseVisualStyleBackColor = False
            '
            'img_profile
            '
            Me.img_profile.Anchor = System.Windows.Forms.AnchorStyles.None
            Me.img_profile.BackColor = System.Drawing.Color.Transparent
            Me.img_profile.Image = Global.expense_Trackie.My.Resources.Resources.profileLight
            Me.img_profile.Location = New System.Drawing.Point(100, 19)
            Me.img_profile.Name = "img_profile"
            Me.img_profile.Size = New System.Drawing.Size(70, 70)
            Me.img_profile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
            Me.img_profile.TabIndex = 81
            Me.img_profile.TabStop = False
            '
            'infoTool
            '
            Me.infoTool.BackColor = System.Drawing.Color.Transparent
            Me.infoTool.Image = Global.expense_Trackie.My.Resources.Resources.info
            Me.infoTool.Location = New System.Drawing.Point(975, 451)
            Me.infoTool.Name = "infoTool"
            Me.infoTool.Size = New System.Drawing.Size(23, 23)
            Me.infoTool.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
            Me.infoTool.TabIndex = 79
            Me.infoTool.TabStop = False
            '
            'svgInfo
            '
            Me.svgInfo.BackColor = System.Drawing.Color.Transparent
            Me.svgInfo.Image = CType(resources.GetObject("svgInfo.Image"), System.Drawing.Image)
            Me.svgInfo.Location = New System.Drawing.Point(993, 440)
            Me.svgInfo.Name = "svgInfo"
            Me.svgInfo.Size = New System.Drawing.Size(45, 46)
            Me.svgInfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
            Me.svgInfo.TabIndex = 80
            Me.svgInfo.TabStop = False
            '
            'button_close
            '
            Me.button_close.BackColor = System.Drawing.Color.Transparent
            Me.button_close.Dock = System.Windows.Forms.DockStyle.Right
            Me.button_close.FlatAppearance.BorderSize = 0
            Me.button_close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(35, Byte), Integer))
            Me.button_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.button_close.Image = Global.expense_Trackie.My.Resources.Resources.icons8_close_16
            Me.button_close.Location = New System.Drawing.Point(1019, 0)
            Me.button_close.Margin = New System.Windows.Forms.Padding(0)
            Me.button_close.Name = "button_close"
            Me.button_close.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.button_close.Size = New System.Drawing.Size(50, 46)
            Me.button_close.TabIndex = 42
            Me.button_close.UseVisualStyleBackColor = False
            '
            'PictureBox1
            '
            Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
            Me.PictureBox1.Image = Global.expense_Trackie.My.Resources.Resources.Sign_Up_Page
            Me.PictureBox1.Location = New System.Drawing.Point(-29, 15)
            Me.PictureBox1.Name = "PictureBox1"
            Me.PictureBox1.Size = New System.Drawing.Size(669, 614)
            Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
            Me.PictureBox1.TabIndex = 48
            Me.PictureBox1.TabStop = False
            '
            'TableLayoutPanel2
            '
            Me.TableLayoutPanel2.BackColor = System.Drawing.Color.Transparent
            Me.TableLayoutPanel2.ColumnCount = 1
            Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
            Me.TableLayoutPanel2.Controls.Add(Me.img_profile, 0, 0)
            Me.TableLayoutPanel2.Controls.Add(Me.Label6, 0, 5)
            Me.TableLayoutPanel2.Controls.Add(Me.Label7, 0, 1)
            Me.TableLayoutPanel2.Controls.Add(Me.Label8, 0, 3)
            Me.TableLayoutPanel2.Controls.Add(Me.txt_username, 0, 2)
            Me.TableLayoutPanel2.Controls.Add(Me.txt_password, 0, 6)
            Me.TableLayoutPanel2.Controls.Add(Me.txt_number, 0, 4)
            Me.TableLayoutPanel2.Location = New System.Drawing.Point(699, 139)
            Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
            Me.TableLayoutPanel2.RowCount = 7
            Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.47828!))
            Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.436401!))
            Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.436401!))
            Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.436401!))
            Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.436401!))
            Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.436401!))
            Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.436401!))
            Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
            Me.TableLayoutPanel2.Size = New System.Drawing.Size(271, 352)
            Me.TableLayoutPanel2.TabIndex = 88
            '
            'Label6
            '
            Me.Label6.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.Label6.Font = New System.Drawing.Font("IBM Plex Mono", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label6.Location = New System.Drawing.Point(3, 291)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(265, 18)
            Me.Label6.TabIndex = 3
            Me.Label6.Text = "Password"
            '
            'Label7
            '
            Me.Label7.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.Label7.Font = New System.Drawing.Font("IBM Plex Mono", 9.75!)
            Me.Label7.Location = New System.Drawing.Point(3, 131)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New System.Drawing.Size(265, 18)
            Me.Label7.TabIndex = 1
            Me.Label7.Text = "Username"
            '
            'Label8
            '
            Me.Label8.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.Label8.Font = New System.Drawing.Font("IBM Plex Mono", 9.75!)
            Me.Label8.Location = New System.Drawing.Point(3, 211)
            Me.Label8.Name = "Label8"
            Me.Label8.Size = New System.Drawing.Size(265, 18)
            Me.Label8.TabIndex = 2
            Me.Label8.Text = "Number"
            '
            'panel_topbar
            '
            Me.panel_topbar.BackColor = System.Drawing.Color.Transparent
            Me.panel_topbar.Controls.Add(Me.button_close)
            Me.panel_topbar.Dock = System.Windows.Forms.DockStyle.Top
            Me.panel_topbar.Location = New System.Drawing.Point(0, 0)
            Me.panel_topbar.Name = "panel_topbar"
            Me.panel_topbar.Size = New System.Drawing.Size(1069, 46)
            Me.panel_topbar.TabIndex = 89
            '
            'SignUp
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(1069, 650)
            Me.Controls.Add(Me.TableLayoutPanel2)
            Me.Controls.Add(Me.check_showPassword)
            Me.Controls.Add(Me.TableLayoutPanel1)
            Me.Controls.Add(Me.infoTool)
            Me.Controls.Add(Me.svgInfo)
            Me.Controls.Add(Me.PictureBox1)
            Me.Controls.Add(Me.btn_signup)
            Me.Controls.Add(Me.SignInLL)
            Me.Controls.Add(Me.PromptL)
            Me.Controls.Add(Me.Label2)
            Me.Controls.Add(Me.panel_topbar)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "SignUp"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "SignUp"
            Me.TableLayoutPanel1.ResumeLayout(False)
            Me.TableLayoutPanel1.PerformLayout()
            CType(Me.img_profile, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.infoTool, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.svgInfo, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.TableLayoutPanel2.ResumeLayout(False)
            Me.TableLayoutPanel2.PerformLayout()
            Me.panel_topbar.ResumeLayout(False)
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents btn_signup As Button
        Friend WithEvents txt_password As TextBox
        Friend WithEvents txt_username As TextBox
        Friend WithEvents txt_number As TextBox
        Friend WithEvents SignInLL As LinkLabel
        Friend WithEvents PromptL As Label
        Friend WithEvents Label2 As Label
        Friend WithEvents button_close As Button
        Friend WithEvents infoTool As PictureBox
        Friend WithEvents svgInfo As PictureBox
        Friend WithEvents ToolTip1 As ToolTip
        Friend WithEvents img_profile As PictureBox
        Friend WithEvents lbl_info As Label
        Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
        Friend WithEvents check_showPassword As CheckBox
        Friend WithEvents PictureBox1 As PictureBox
        Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
        Friend WithEvents Label6 As Label
        Friend WithEvents Label7 As Label
        Friend WithEvents Label8 As Label
        Friend WithEvents panel_topbar As Panel
    End Class
End NameSpace