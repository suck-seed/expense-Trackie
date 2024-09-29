<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UpdatePassword
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UpdatePassword))
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.txt_secutiry_code = New System.Windows.Forms.Label()
        Me.Code = New System.Windows.Forms.Label()
        Me.txt_code = New System.Windows.Forms.TextBox()
        Me.txt_password = New System.Windows.Forms.TextBox()
        Me.panel_topbar = New System.Windows.Forms.Panel()
        Me.button_close = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.lbl_error = New System.Windows.Forms.Label()
        Me.btn_reset = New System.Windows.Forms.Button()
        Me.notifyCode = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.panel_topbar.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.txt_secutiry_code, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.Code, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.txt_code, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.txt_password, 0, 3)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(465, 160)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 4
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(271, 171)
        Me.TableLayoutPanel2.TabIndex = 101
        '
        'txt_secutiry_code
        '
        Me.txt_secutiry_code.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.txt_secutiry_code.Font = New System.Drawing.Font("IBM Plex Mono", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_secutiry_code.Location = New System.Drawing.Point(3, 108)
        Me.txt_secutiry_code.Name = "txt_secutiry_code"
        Me.txt_secutiry_code.Size = New System.Drawing.Size(265, 18)
        Me.txt_secutiry_code.TabIndex = 3
        Me.txt_secutiry_code.Text = "Password"
        '
        'Code
        '
        Me.Code.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Code.Font = New System.Drawing.Font("IBM Plex Mono", 9.75!)
        Me.Code.Location = New System.Drawing.Point(3, 24)
        Me.Code.Name = "Code"
        Me.Code.Size = New System.Drawing.Size(265, 18)
        Me.Code.TabIndex = 1
        Me.Code.Text = "Code"
        '
        'txt_code
        '
        Me.txt_code.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_code.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_code.Font = New System.Drawing.Font("IBM Plex Mono", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_code.Location = New System.Drawing.Point(3, 45)
        Me.txt_code.MaximumSize = New System.Drawing.Size(3000, 3000)
        Me.txt_code.MinimumSize = New System.Drawing.Size(20, 20)
        Me.txt_code.Name = "txt_code"
        Me.txt_code.Size = New System.Drawing.Size(265, 28)
        Me.txt_code.TabIndex = 55
        '
        'txt_password
        '
        Me.txt_password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_password.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_password.Font = New System.Drawing.Font("IBM Plex Mono", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_password.Location = New System.Drawing.Point(3, 129)
        Me.txt_password.Name = "txt_password"
        Me.txt_password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txt_password.Size = New System.Drawing.Size(265, 28)
        Me.txt_password.TabIndex = 56
        '
        'panel_topbar
        '
        Me.panel_topbar.BackColor = System.Drawing.Color.Transparent
        Me.panel_topbar.Controls.Add(Me.button_close)
        Me.panel_topbar.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel_topbar.Location = New System.Drawing.Point(0, 0)
        Me.panel_topbar.Name = "panel_topbar"
        Me.panel_topbar.Size = New System.Drawing.Size(814, 46)
        Me.panel_topbar.TabIndex = 98
        '
        'button_close
        '
        Me.button_close.BackColor = System.Drawing.Color.Transparent
        Me.button_close.Dock = System.Windows.Forms.DockStyle.Right
        Me.button_close.FlatAppearance.BorderSize = 0
        Me.button_close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.button_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button_close.Image = Global.expense_Trackie.My.Resources.Resources.icons8_close_16
        Me.button_close.Location = New System.Drawing.Point(764, 0)
        Me.button_close.Margin = New System.Windows.Forms.Padding(0)
        Me.button_close.Name = "button_close"
        Me.button_close.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.button_close.Size = New System.Drawing.Size(50, 46)
        Me.button_close.TabIndex = 41
        Me.button_close.UseVisualStyleBackColor = False
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.lbl_error, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(445, 426)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(305, 32)
        Me.TableLayoutPanel1.TabIndex = 103
        '
        'lbl_error
        '
        Me.lbl_error.AutoSize = True
        Me.lbl_error.BackColor = System.Drawing.Color.Transparent
        Me.lbl_error.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_error.Font = New System.Drawing.Font("IBM Plex Mono", 9.0!)
        Me.lbl_error.ForeColor = System.Drawing.Color.Red
        Me.lbl_error.Location = New System.Drawing.Point(3, 0)
        Me.lbl_error.Name = "lbl_error"
        Me.lbl_error.Size = New System.Drawing.Size(299, 32)
        Me.lbl_error.TabIndex = 82
        Me.lbl_error.Text = "error"
        Me.lbl_error.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_reset
        '
        Me.btn_reset.BackColor = System.Drawing.SystemColors.WindowText
        Me.btn_reset.FlatAppearance.BorderSize = 0
        Me.btn_reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_reset.Font = New System.Drawing.Font("IBM Plex Mono", 15.0!, System.Drawing.FontStyle.Bold)
        Me.btn_reset.ForeColor = System.Drawing.Color.Transparent
        Me.btn_reset.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_reset.Location = New System.Drawing.Point(476, 372)
        Me.btn_reset.Name = "btn_reset"
        Me.btn_reset.Size = New System.Drawing.Size(248, 48)
        Me.btn_reset.TabIndex = 102
        Me.btn_reset.Text = "Reset"
        Me.btn_reset.UseVisualStyleBackColor = False
        '
        'notifyCode
        '
        Me.notifyCode.Icon = CType(resources.GetObject("notifyCode.Icon"), System.Drawing.Icon)
        Me.notifyCode.Text = "NotifyIcon1"
        Me.notifyCode.Visible = True
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.expense_Trackie.My.Resources.Resources.Reset_Password
        Me.PictureBox2.InitialImage = Global.expense_Trackie.My.Resources.Resources.Forgot_Password
        Me.PictureBox2.Location = New System.Drawing.Point(12, 4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(379, 545)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 99
        Me.PictureBox2.TabStop = False
        '
        'UpdatePassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(814, 553)
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.btn_reset)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.panel_topbar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "UpdatePassword"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "UpdatePassword"
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.panel_topbar.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents txt_secutiry_code As Label
    Friend WithEvents Code As Label
    Friend WithEvents txt_code As TextBox
    Friend WithEvents txt_password As TextBox
    Friend WithEvents panel_topbar As Panel
    Friend WithEvents button_close As Button
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents lbl_error As Label
    Friend WithEvents btn_reset As Button
    Friend WithEvents notifyCode As NotifyIcon
    Friend WithEvents PictureBox2 As PictureBox
End Class
