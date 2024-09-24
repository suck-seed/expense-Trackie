Namespace Presentation
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class DisplayProfile
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
            Me.Label4 = New System.Windows.Forms.Label()
            Me.panel_topbar = New System.Windows.Forms.Panel()
            Me.button_close = New System.Windows.Forms.Button()
            Me.btn_logout = New System.Windows.Forms.Button()
            Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
            Me.img_profile = New System.Windows.Forms.PictureBox()
            Me.txt_password1 = New System.Windows.Forms.TextBox()
            Me.txt_dailyLimit = New System.Windows.Forms.RichTextBox()
            Me.txt_number = New System.Windows.Forms.RichTextBox()
            Me.txt_username = New System.Windows.Forms.RichTextBox()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.btn_update = New System.Windows.Forms.Button()
            Me.btn_delete = New System.Windows.Forms.Button()
            Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
            Me.lbl_info = New System.Windows.Forms.Label()
            Me.check_showPassword = New System.Windows.Forms.CheckBox()
            Me.panel_topbar.SuspendLayout()
            Me.TableLayoutPanel1.SuspendLayout()
            CType(Me.img_profile, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.TableLayoutPanel2.SuspendLayout()
            Me.SuspendLayout()
            '
            'Label4
            '
            Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
            Me.Label4.AutoSize = True
            Me.Label4.Font = New System.Drawing.Font("Cascadia Mono", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label4.Location = New System.Drawing.Point(224, 11)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(73, 21)
            Me.Label4.TabIndex = 2
            Me.Label4.Text = "Profile"
            '
            'panel_topbar
            '
            Me.panel_topbar.BackColor = System.Drawing.Color.Transparent
            Me.panel_topbar.Controls.Add(Me.button_close)
            Me.panel_topbar.Controls.Add(Me.btn_logout)
            Me.panel_topbar.Controls.Add(Me.Label4)
            Me.panel_topbar.Dock = System.Windows.Forms.DockStyle.Top
            Me.panel_topbar.Location = New System.Drawing.Point(0, 0)
            Me.panel_topbar.Margin = New System.Windows.Forms.Padding(0)
            Me.panel_topbar.Name = "panel_topbar"
            Me.panel_topbar.Size = New System.Drawing.Size(536, 46)
            Me.panel_topbar.TabIndex = 6
            '
            'button_close
            '
            Me.button_close.Dock = System.Windows.Forms.DockStyle.Left
            Me.button_close.FlatAppearance.BorderSize = 0
            Me.button_close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(35, Byte), Integer))
            Me.button_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.button_close.Image = Global.expense_Trackie.My.Resources.Resources.icons8_close_16
            Me.button_close.Location = New System.Drawing.Point(0, 0)
            Me.button_close.Margin = New System.Windows.Forms.Padding(0)
            Me.button_close.Name = "button_close"
            Me.button_close.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.button_close.Size = New System.Drawing.Size(50, 46)
            Me.button_close.TabIndex = 11
            Me.button_close.UseVisualStyleBackColor = True
            '
            'btn_logout
            '
            Me.btn_logout.Dock = System.Windows.Forms.DockStyle.Right
            Me.btn_logout.FlatAppearance.BorderSize = 0
            Me.btn_logout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(125, Byte), Integer))
            Me.btn_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btn_logout.Image = Global.expense_Trackie.My.Resources.Resources.logout
            Me.btn_logout.Location = New System.Drawing.Point(486, 0)
            Me.btn_logout.Margin = New System.Windows.Forms.Padding(0)
            Me.btn_logout.Name = "btn_logout"
            Me.btn_logout.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.btn_logout.Size = New System.Drawing.Size(50, 46)
            Me.btn_logout.TabIndex = 10
            Me.btn_logout.UseVisualStyleBackColor = True
            '
            'TableLayoutPanel1
            '
            Me.TableLayoutPanel1.BackColor = System.Drawing.Color.Transparent
            Me.TableLayoutPanel1.ColumnCount = 1
            Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
            Me.TableLayoutPanel1.Controls.Add(Me.img_profile, 0, 0)
            Me.TableLayoutPanel1.Controls.Add(Me.txt_password1, 0, 4)
            Me.TableLayoutPanel1.Controls.Add(Me.txt_dailyLimit, 0, 8)
            Me.TableLayoutPanel1.Controls.Add(Me.txt_number, 0, 6)
            Me.TableLayoutPanel1.Controls.Add(Me.txt_username, 0, 2)
            Me.TableLayoutPanel1.Controls.Add(Me.Label3, 0, 5)
            Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 1)
            Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 3)
            Me.TableLayoutPanel1.Controls.Add(Me.Label5, 0, 7)
            Me.TableLayoutPanel1.Location = New System.Drawing.Point(60, 81)
            Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
            Me.TableLayoutPanel1.RowCount = 9
            Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.47828!))
            Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.436401!))
            Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.436401!))
            Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.436401!))
            Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.436401!))
            Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.436401!))
            Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.436401!))
            Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.436401!))
            Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.466907!))
            Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
            Me.TableLayoutPanel1.Size = New System.Drawing.Size(413, 404)
            Me.TableLayoutPanel1.TabIndex = 7
            '
            'img_profile
            '
            Me.img_profile.Anchor = System.Windows.Forms.AnchorStyles.None
            Me.img_profile.Image = Global.expense_Trackie.My.Resources.Resources.profileLight
            Me.img_profile.Location = New System.Drawing.Point(166, 11)
            Me.img_profile.Name = "img_profile"
            Me.img_profile.Size = New System.Drawing.Size(80, 80)
            Me.img_profile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
            Me.img_profile.TabIndex = 14
            Me.img_profile.TabStop = False
            '
            'txt_password1
            '
            Me.txt_password1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.txt_password1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.txt_password1.Font = New System.Drawing.Font("IBM Plex Mono", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txt_password1.Location = New System.Drawing.Point(3, 219)
            Me.txt_password1.Name = "txt_password1"
            Me.txt_password1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
            Me.txt_password1.Size = New System.Drawing.Size(407, 28)
            Me.txt_password1.TabIndex = 8
            '
            'txt_dailyLimit
            '
            Me.txt_dailyLimit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.txt_dailyLimit.Dock = System.Windows.Forms.DockStyle.Fill
            Me.txt_dailyLimit.Font = New System.Drawing.Font("IBM Plex Mono", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txt_dailyLimit.Location = New System.Drawing.Point(3, 371)
            Me.txt_dailyLimit.Multiline = False
            Me.txt_dailyLimit.Name = "txt_dailyLimit"
            Me.txt_dailyLimit.Size = New System.Drawing.Size(407, 30)
            Me.txt_dailyLimit.TabIndex = 12
            Me.txt_dailyLimit.Text = ""
            '
            'txt_number
            '
            Me.txt_number.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.txt_number.Dock = System.Windows.Forms.DockStyle.Fill
            Me.txt_number.Font = New System.Drawing.Font("IBM Plex Mono", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txt_number.Location = New System.Drawing.Point(3, 295)
            Me.txt_number.Multiline = False
            Me.txt_number.Name = "txt_number"
            Me.txt_number.Size = New System.Drawing.Size(407, 32)
            Me.txt_number.TabIndex = 12
            Me.txt_number.Text = ""
            '
            'txt_username
            '
            Me.txt_username.BackColor = System.Drawing.SystemColors.Window
            Me.txt_username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.txt_username.Dock = System.Windows.Forms.DockStyle.Fill
            Me.txt_username.Font = New System.Drawing.Font("IBM Plex Mono", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txt_username.Location = New System.Drawing.Point(3, 143)
            Me.txt_username.Multiline = False
            Me.txt_username.Name = "txt_username"
            Me.txt_username.Size = New System.Drawing.Size(407, 32)
            Me.txt_username.TabIndex = 13
            Me.txt_username.Text = ""
            '
            'Label3
            '
            Me.Label3.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.Label3.Font = New System.Drawing.Font("Cascadia Mono", 10.0!)
            Me.Label3.Location = New System.Drawing.Point(3, 274)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(407, 18)
            Me.Label3.TabIndex = 3
            Me.Label3.Text = "Number"
            '
            'Label1
            '
            Me.Label1.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.Label1.Font = New System.Drawing.Font("Cascadia Mono", 10.0!)
            Me.Label1.Location = New System.Drawing.Point(3, 122)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(407, 18)
            Me.Label1.TabIndex = 1
            Me.Label1.Text = "Username"
            '
            'Label2
            '
            Me.Label2.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.Label2.Font = New System.Drawing.Font("Cascadia Mono", 10.0!)
            Me.Label2.Location = New System.Drawing.Point(3, 198)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(407, 18)
            Me.Label2.TabIndex = 2
            Me.Label2.Text = "Password"
            '
            'Label5
            '
            Me.Label5.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.Label5.Font = New System.Drawing.Font("Cascadia Mono", 10.0!)
            Me.Label5.Location = New System.Drawing.Point(3, 350)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(407, 18)
            Me.Label5.TabIndex = 4
            Me.Label5.Text = "Daily Limit"
            '
            'btn_update
            '
            Me.btn_update.Anchor = System.Windows.Forms.AnchorStyles.None
            Me.btn_update.BackColor = System.Drawing.SystemColors.ButtonFace
            Me.btn_update.FlatAppearance.BorderSize = 0
            Me.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Popup
            Me.btn_update.Font = New System.Drawing.Font("Cascadia Mono", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btn_update.Location = New System.Drawing.Point(202, 530)
            Me.btn_update.Name = "btn_update"
            Me.btn_update.Size = New System.Drawing.Size(119, 36)
            Me.btn_update.TabIndex = 8
            Me.btn_update.Text = "Update"
            Me.btn_update.UseVisualStyleBackColor = False
            '
            'btn_delete
            '
            Me.btn_delete.Anchor = System.Windows.Forms.AnchorStyles.None
            Me.btn_delete.BackColor = System.Drawing.Color.IndianRed
            Me.btn_delete.FlatAppearance.BorderSize = 0
            Me.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup
            Me.btn_delete.Font = New System.Drawing.Font("Cascadia Mono", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btn_delete.Location = New System.Drawing.Point(202, 583)
            Me.btn_delete.Name = "btn_delete"
            Me.btn_delete.Size = New System.Drawing.Size(119, 36)
            Me.btn_delete.TabIndex = 10
            Me.btn_delete.Text = "Delete"
            Me.btn_delete.UseVisualStyleBackColor = False
            '
            'TableLayoutPanel2
            '
            Me.TableLayoutPanel2.BackColor = System.Drawing.Color.Transparent
            Me.TableLayoutPanel2.ColumnCount = 1
            Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
            Me.TableLayoutPanel2.Controls.Add(Me.lbl_info, 0, 0)
            Me.TableLayoutPanel2.Location = New System.Drawing.Point(110, 492)
            Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
            Me.TableLayoutPanel2.RowCount = 1
            Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
            Me.TableLayoutPanel2.Size = New System.Drawing.Size(305, 32)
            Me.TableLayoutPanel2.TabIndex = 84
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
            'check_showPassword
            '
            Me.check_showPassword.Appearance = System.Windows.Forms.Appearance.Button
            Me.check_showPassword.BackColor = System.Drawing.Color.Transparent
            Me.check_showPassword.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter
            Me.check_showPassword.FlatAppearance.BorderSize = 0
            Me.check_showPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.check_showPassword.Image = Global.expense_Trackie.My.Resources.Resources.showpassword
            Me.check_showPassword.Location = New System.Drawing.Point(476, 298)
            Me.check_showPassword.Name = "check_showPassword"
            Me.check_showPassword.Size = New System.Drawing.Size(26, 34)
            Me.check_showPassword.TabIndex = 85
            Me.check_showPassword.TextAlign = System.Drawing.ContentAlignment.TopLeft
            Me.check_showPassword.UseVisualStyleBackColor = False
            '
            'DisplayProfile
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(536, 637)
            Me.Controls.Add(Me.check_showPassword)
            Me.Controls.Add(Me.TableLayoutPanel2)
            Me.Controls.Add(Me.btn_delete)
            Me.Controls.Add(Me.btn_update)
            Me.Controls.Add(Me.TableLayoutPanel1)
            Me.Controls.Add(Me.panel_topbar)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            Me.KeyPreview = True
            Me.Name = "DisplayProfile"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "DisplayProfile"
            Me.panel_topbar.ResumeLayout(False)
            Me.panel_topbar.PerformLayout()
            Me.TableLayoutPanel1.ResumeLayout(False)
            Me.TableLayoutPanel1.PerformLayout()
            CType(Me.img_profile, System.ComponentModel.ISupportInitialize).EndInit()
            Me.TableLayoutPanel2.ResumeLayout(False)
            Me.TableLayoutPanel2.PerformLayout()
            Me.ResumeLayout(False)

        End Sub

        Friend WithEvents button_close As Button
        Friend WithEvents Label4 As Label
        Friend WithEvents panel_topbar As Panel
        Friend WithEvents btn_logout As Button
        Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
        Friend WithEvents Label3 As Label
        Friend WithEvents Label1 As Label
        Friend WithEvents Label2 As Label
        Friend WithEvents Label5 As Label
        Friend WithEvents txt_dailyLimit As RichTextBox
        Friend WithEvents txt_number As RichTextBox
        Friend WithEvents txt_username As RichTextBox
        Friend WithEvents txt_password1 As TextBox
        Friend WithEvents btn_update As Button
        Friend WithEvents btn_delete As Button
        Friend WithEvents img_profile As PictureBox
        Public WithEvents lbl_info As Label
        Public WithEvents TableLayoutPanel2 As TableLayoutPanel
        Friend WithEvents check_showPassword As CheckBox
    End Class
End NameSpace