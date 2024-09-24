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
            Me.button_close = New System.Windows.Forms.Button()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.PictureBox1 = New System.Windows.Forms.PictureBox()
            Me.infoTool = New System.Windows.Forms.PictureBox()
            Me.svgInfo = New System.Windows.Forms.PictureBox()
            Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
            Me.img_profile = New System.Windows.Forms.PictureBox()
            Me.lbl_info = New System.Windows.Forms.Label()
            Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
            CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.infoTool, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.svgInfo, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.img_profile, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.TableLayoutPanel1.SuspendLayout()
            Me.SuspendLayout()
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.BackColor = System.Drawing.Color.Transparent
            Me.Label4.Font = New System.Drawing.Font("IBM Plex Mono", 10.0!)
            Me.Label4.Location = New System.Drawing.Point(618, 447)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(72, 18)
            Me.Label4.TabIndex = 36
            Me.Label4.Text = "Password"
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.BackColor = System.Drawing.Color.Transparent
            Me.Label3.Font = New System.Drawing.Font("IBM Plex Mono", 10.0!)
            Me.Label3.Location = New System.Drawing.Point(618, 350)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(72, 18)
            Me.Label3.TabIndex = 35
            Me.Label3.Text = "Username"
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.BackColor = System.Drawing.Color.Transparent
            Me.Label1.Font = New System.Drawing.Font("IBM Plex Mono", 10.0!)
            Me.Label1.Location = New System.Drawing.Point(618, 247)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(56, 18)
            Me.Label1.TabIndex = 34
            Me.Label1.Text = "Number"
            '
            'ShowPassCB
            '
            Me.ShowPassCB.AutoSize = True
            Me.ShowPassCB.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.ShowPassCB.Font = New System.Drawing.Font("IBM Plex Mono", 9.0!)
            Me.ShowPassCB.Location = New System.Drawing.Point(621, 498)
            Me.ShowPassCB.Name = "ShowPassCB"
            Me.ShowPassCB.Size = New System.Drawing.Size(114, 19)
            Me.ShowPassCB.TabIndex = 28
            Me.ShowPassCB.Text = "Show Password"
            Me.ShowPassCB.UseVisualStyleBackColor = True
            '
            'btn_signup
            '
            Me.btn_signup.BackColor = System.Drawing.SystemColors.InactiveCaptionText
            Me.btn_signup.FlatAppearance.BorderSize = 0
            Me.btn_signup.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btn_signup.Font = New System.Drawing.Font("IBM Plex Mono", 15.0!, System.Drawing.FontStyle.Bold)
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
            Me.txt_password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
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
            Me.txt_username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.txt_username.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txt_username.Location = New System.Drawing.Point(620, 371)
            Me.txt_username.Name = "txt_username"
            Me.txt_username.Size = New System.Drawing.Size(247, 26)
            Me.txt_username.TabIndex = 25
            '
            'txt_number
            '
            Me.txt_number.BackColor = System.Drawing.SystemColors.Window
            Me.txt_number.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.txt_number.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txt_number.Location = New System.Drawing.Point(620, 268)
            Me.txt_number.Name = "txt_number"
            Me.txt_number.Size = New System.Drawing.Size(247, 26)
            Me.txt_number.TabIndex = 24
            '
            'SignInLL
            '
            Me.SignInLL.AutoSize = True
            Me.SignInLL.Font = New System.Drawing.Font("IBM Plex Mono", 9.0!)
            Me.SignInLL.Location = New System.Drawing.Point(800, 637)
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
            Me.PromptL.Location = New System.Drawing.Point(627, 639)
            Me.PromptL.Name = "PromptL"
            Me.PromptL.Size = New System.Drawing.Size(175, 15)
            Me.PromptL.TabIndex = 22
            Me.PromptL.Text = "Already have an account?"
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Font = New System.Drawing.Font("IBM Plex Mono", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label2.Location = New System.Drawing.Point(648, 62)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(167, 46)
            Me.Label2.TabIndex = 21
            Me.Label2.Text = "SIGN UP"
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
            Me.Label5.Font = New System.Drawing.Font("IBM Plex Mono", 10.0!)
            Me.Label5.Location = New System.Drawing.Point(703, 124)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(64, 18)
            Me.Label5.TabIndex = 43
            Me.Label5.Text = "Profile"
            '
            'PictureBox1
            '
            Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
            Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
            Me.PictureBox1.Location = New System.Drawing.Point(41, 62)
            Me.PictureBox1.Name = "PictureBox1"
            Me.PictureBox1.Size = New System.Drawing.Size(529, 591)
            Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
            Me.PictureBox1.TabIndex = 48
            Me.PictureBox1.TabStop = False
            '
            'infoTool
            '
            Me.infoTool.BackColor = System.Drawing.Color.Transparent
            Me.infoTool.Image = CType(resources.GetObject("infoTool.Image"), System.Drawing.Image)
            Me.infoTool.Location = New System.Drawing.Point(872, 470)
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
            Me.svgInfo.Location = New System.Drawing.Point(890, 459)
            Me.svgInfo.Name = "svgInfo"
            Me.svgInfo.Size = New System.Drawing.Size(45, 46)
            Me.svgInfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
            Me.svgInfo.TabIndex = 80
            Me.svgInfo.TabStop = False
            '
            'img_profile
            '
            Me.img_profile.Anchor = System.Windows.Forms.AnchorStyles.None
            Me.img_profile.Image = Global.expense_Trackie.My.Resources.Resources.profileLight
            Me.img_profile.Location = New System.Drawing.Point(702, 160)
            Me.img_profile.Name = "img_profile"
            Me.img_profile.Size = New System.Drawing.Size(70, 70)
            Me.img_profile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
            Me.img_profile.TabIndex = 81
            Me.img_profile.TabStop = False
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
            Me.TableLayoutPanel1.ColumnCount = 1
            Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
            Me.TableLayoutPanel1.Controls.Add(Me.lbl_info, 0, 0)
            Me.TableLayoutPanel1.Location = New System.Drawing.Point(590, 541)
            Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
            Me.TableLayoutPanel1.RowCount = 1
            Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
            Me.TableLayoutPanel1.Size = New System.Drawing.Size(305, 32)
            Me.TableLayoutPanel1.TabIndex = 83
            '
            'SignUp
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(969, 750)
            Me.Controls.Add(Me.TableLayoutPanel1)
            Me.Controls.Add(Me.img_profile)
            Me.Controls.Add(Me.infoTool)
            Me.Controls.Add(Me.svgInfo)
            Me.Controls.Add(Me.PictureBox1)
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
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            Me.Name = "SignUp"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "SignUp"
            CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.infoTool, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.svgInfo, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.img_profile, System.ComponentModel.ISupportInitialize).EndInit()
            Me.TableLayoutPanel1.ResumeLayout(False)
            Me.TableLayoutPanel1.PerformLayout()
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
        Friend WithEvents button_close As Button
        Friend WithEvents Label5 As Label
        Friend WithEvents PictureBox1 As PictureBox
        Friend WithEvents infoTool As PictureBox
        Friend WithEvents svgInfo As PictureBox
        Friend WithEvents ToolTip1 As ToolTip
        Friend WithEvents img_profile As PictureBox
        Friend WithEvents lbl_info As Label
        Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    End Class
End NameSpace