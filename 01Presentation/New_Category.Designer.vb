<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class New_Category
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.txt_description = New System.Windows.Forms.TextBox()
        Me.txt_name = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tabelPanel_color = New System.Windows.Forms.TableLayoutPanel()
        Me.Radio_Color7 = New System.Windows.Forms.RadioButton()
        Me.Radio_Color6 = New System.Windows.Forms.RadioButton()
        Me.Radio_Color9 = New System.Windows.Forms.RadioButton()
        Me.Radio_Color8 = New System.Windows.Forms.RadioButton()
        Me.Radio_Color5 = New System.Windows.Forms.RadioButton()
        Me.Radio_Color2 = New System.Windows.Forms.RadioButton()
        Me.Radio_Color1 = New System.Windows.Forms.RadioButton()
        Me.Radio_Color4 = New System.Windows.Forms.RadioButton()
        Me.Radio_Color3 = New System.Windows.Forms.RadioButton()
        Me.btn_custom_color = New System.Windows.Forms.Button()
        Me.panel_topbar = New System.Windows.Forms.Panel()
        Me.button_close = New System.Windows.Forms.Button()
        Me.button_create = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.tabelPanel_color.SuspendLayout()
        Me.panel_topbar.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.txt_description, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_name, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.tabelPanel_color, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.btn_custom_color, 0, 6)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(43, 73)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 7
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28531!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28531!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28531!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28531!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28531!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28531!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28816!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(407, 301)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'txt_description
        '
        Me.txt_description.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_description.Font = New System.Drawing.Font("Cascadia Code", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_description.Location = New System.Drawing.Point(3, 129)
        Me.txt_description.Name = "txt_description"
        Me.txt_description.Size = New System.Drawing.Size(401, 25)
        Me.txt_description.TabIndex = 6
        '
        'txt_name
        '
        Me.txt_name.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_name.Font = New System.Drawing.Font("Cascadia Code", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_name.Location = New System.Drawing.Point(3, 45)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(401, 25)
        Me.txt_name.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label3.Font = New System.Drawing.Font("Cascadia Mono", 10.0!)
        Me.Label3.Location = New System.Drawing.Point(3, 192)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(401, 18)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Color"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label2.Font = New System.Drawing.Font("Cascadia Mono", 10.0!)
        Me.Label2.Location = New System.Drawing.Point(3, 108)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(401, 18)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Description"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label1.Font = New System.Drawing.Font("Cascadia Mono", 10.0!)
        Me.Label1.Location = New System.Drawing.Point(3, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(401, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Name"
        '
        'tabelPanel_color
        '
        Me.tabelPanel_color.ColumnCount = 9
        Me.tabelPanel_color.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
        Me.tabelPanel_color.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
        Me.tabelPanel_color.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
        Me.tabelPanel_color.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
        Me.tabelPanel_color.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
        Me.tabelPanel_color.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
        Me.tabelPanel_color.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
        Me.tabelPanel_color.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.7207!))
        Me.tabelPanel_color.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.47132!))
        Me.tabelPanel_color.Controls.Add(Me.Radio_Color7, 0, 0)
        Me.tabelPanel_color.Controls.Add(Me.Radio_Color6, 0, 0)
        Me.tabelPanel_color.Controls.Add(Me.Radio_Color9, 0, 0)
        Me.tabelPanel_color.Controls.Add(Me.Radio_Color8, 0, 0)
        Me.tabelPanel_color.Controls.Add(Me.Radio_Color5, 0, 0)
        Me.tabelPanel_color.Controls.Add(Me.Radio_Color2, 0, 0)
        Me.tabelPanel_color.Controls.Add(Me.Radio_Color1, 0, 0)
        Me.tabelPanel_color.Controls.Add(Me.Radio_Color4, 0, 0)
        Me.tabelPanel_color.Controls.Add(Me.Radio_Color3, 0, 0)
        Me.tabelPanel_color.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabelPanel_color.Location = New System.Drawing.Point(3, 213)
        Me.tabelPanel_color.Name = "tabelPanel_color"
        Me.tabelPanel_color.RowCount = 1
        Me.tabelPanel_color.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tabelPanel_color.Size = New System.Drawing.Size(401, 36)
        Me.tabelPanel_color.TabIndex = 5
        '
        'Radio_Color7
        '
        Me.Radio_Color7.Appearance = System.Windows.Forms.Appearance.Button
        Me.Radio_Color7.AutoSize = True
        Me.Radio_Color7.BackColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.Radio_Color7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Radio_Color7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Radio_Color7.Location = New System.Drawing.Point(267, 3)
        Me.Radio_Color7.Name = "Radio_Color7"
        Me.Radio_Color7.Size = New System.Drawing.Size(38, 30)
        Me.Radio_Color7.TabIndex = 8
        Me.Radio_Color7.TabStop = True
        Me.Radio_Color7.UseVisualStyleBackColor = False
        '
        'Radio_Color6
        '
        Me.Radio_Color6.Appearance = System.Windows.Forms.Appearance.Button
        Me.Radio_Color6.AutoSize = True
        Me.Radio_Color6.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.Radio_Color6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Radio_Color6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Radio_Color6.Location = New System.Drawing.Point(223, 3)
        Me.Radio_Color6.Name = "Radio_Color6"
        Me.Radio_Color6.Size = New System.Drawing.Size(38, 30)
        Me.Radio_Color6.TabIndex = 7
        Me.Radio_Color6.TabStop = True
        Me.Radio_Color6.UseVisualStyleBackColor = False
        '
        'Radio_Color9
        '
        Me.Radio_Color9.Appearance = System.Windows.Forms.Appearance.Button
        Me.Radio_Color9.AutoSize = True
        Me.Radio_Color9.BackColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.Radio_Color9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Radio_Color9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Radio_Color9.Location = New System.Drawing.Point(357, 3)
        Me.Radio_Color9.Name = "Radio_Color9"
        Me.Radio_Color9.Size = New System.Drawing.Size(41, 30)
        Me.Radio_Color9.TabIndex = 6
        Me.Radio_Color9.TabStop = True
        Me.Radio_Color9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Radio_Color9.UseVisualStyleBackColor = False
        '
        'Radio_Color8
        '
        Me.Radio_Color8.Appearance = System.Windows.Forms.Appearance.Button
        Me.Radio_Color8.AutoSize = True
        Me.Radio_Color8.BackColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.Radio_Color8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Radio_Color8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Radio_Color8.Location = New System.Drawing.Point(311, 3)
        Me.Radio_Color8.Name = "Radio_Color8"
        Me.Radio_Color8.Size = New System.Drawing.Size(40, 30)
        Me.Radio_Color8.TabIndex = 5
        Me.Radio_Color8.TabStop = True
        Me.Radio_Color8.UseVisualStyleBackColor = False
        '
        'Radio_Color5
        '
        Me.Radio_Color5.Appearance = System.Windows.Forms.Appearance.Button
        Me.Radio_Color5.AutoSize = True
        Me.Radio_Color5.BackColor = System.Drawing.Color.FromArgb(CType(CType(206, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.Radio_Color5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Radio_Color5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Radio_Color5.Location = New System.Drawing.Point(179, 3)
        Me.Radio_Color5.Name = "Radio_Color5"
        Me.Radio_Color5.Size = New System.Drawing.Size(38, 30)
        Me.Radio_Color5.TabIndex = 4
        Me.Radio_Color5.TabStop = True
        Me.Radio_Color5.UseVisualStyleBackColor = False
        '
        'Radio_Color2
        '
        Me.Radio_Color2.Appearance = System.Windows.Forms.Appearance.Button
        Me.Radio_Color2.AutoSize = True
        Me.Radio_Color2.BackColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.Radio_Color2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Radio_Color2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Radio_Color2.Location = New System.Drawing.Point(47, 3)
        Me.Radio_Color2.Name = "Radio_Color2"
        Me.Radio_Color2.Size = New System.Drawing.Size(38, 30)
        Me.Radio_Color2.TabIndex = 3
        Me.Radio_Color2.TabStop = True
        Me.Radio_Color2.UseVisualStyleBackColor = False
        '
        'Radio_Color1
        '
        Me.Radio_Color1.Appearance = System.Windows.Forms.Appearance.Button
        Me.Radio_Color1.AutoSize = True
        Me.Radio_Color1.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.Radio_Color1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Radio_Color1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Radio_Color1.Location = New System.Drawing.Point(3, 3)
        Me.Radio_Color1.Name = "Radio_Color1"
        Me.Radio_Color1.Size = New System.Drawing.Size(38, 30)
        Me.Radio_Color1.TabIndex = 2
        Me.Radio_Color1.TabStop = True
        Me.Radio_Color1.UseVisualStyleBackColor = False
        '
        'Radio_Color4
        '
        Me.Radio_Color4.Appearance = System.Windows.Forms.Appearance.Button
        Me.Radio_Color4.AutoSize = True
        Me.Radio_Color4.BackColor = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.Radio_Color4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Radio_Color4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Radio_Color4.Location = New System.Drawing.Point(135, 3)
        Me.Radio_Color4.Name = "Radio_Color4"
        Me.Radio_Color4.Size = New System.Drawing.Size(38, 30)
        Me.Radio_Color4.TabIndex = 1
        Me.Radio_Color4.TabStop = True
        Me.Radio_Color4.UseVisualStyleBackColor = False
        '
        'Radio_Color3
        '
        Me.Radio_Color3.Appearance = System.Windows.Forms.Appearance.Button
        Me.Radio_Color3.AutoSize = True
        Me.Radio_Color3.BackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(137, Byte), Integer))
        Me.Radio_Color3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Radio_Color3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Radio_Color3.Location = New System.Drawing.Point(91, 3)
        Me.Radio_Color3.Name = "Radio_Color3"
        Me.Radio_Color3.Size = New System.Drawing.Size(38, 30)
        Me.Radio_Color3.TabIndex = 0
        Me.Radio_Color3.TabStop = True
        Me.Radio_Color3.UseVisualStyleBackColor = False
        '
        'btn_custom_color
        '
        Me.btn_custom_color.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_custom_color.AutoSize = True
        Me.btn_custom_color.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_custom_color.FlatAppearance.BorderSize = 0
        Me.btn_custom_color.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_custom_color.Font = New System.Drawing.Font("Cascadia Mono", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_custom_color.Location = New System.Drawing.Point(146, 261)
        Me.btn_custom_color.Name = "btn_custom_color"
        Me.btn_custom_color.Size = New System.Drawing.Size(115, 30)
        Me.btn_custom_color.TabIndex = 7
        Me.btn_custom_color.Text = "Custom Color"
        Me.btn_custom_color.UseVisualStyleBackColor = False
        '
        'panel_topbar
        '
        Me.panel_topbar.BackColor = System.Drawing.Color.Transparent
        Me.panel_topbar.Controls.Add(Me.button_close)
        Me.panel_topbar.Controls.Add(Me.button_create)
        Me.panel_topbar.Controls.Add(Me.Label4)
        Me.panel_topbar.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel_topbar.Location = New System.Drawing.Point(0, 0)
        Me.panel_topbar.Margin = New System.Windows.Forms.Padding(0)
        Me.panel_topbar.Name = "panel_topbar"
        Me.panel_topbar.Size = New System.Drawing.Size(496, 46)
        Me.panel_topbar.TabIndex = 2
        '
        'button_close
        '
        Me.button_close.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
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
        'button_create
        '
        Me.button_create.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.button_create.FlatAppearance.BorderSize = 0
        Me.button_create.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.button_create.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button_create.Image = Global.expense_Trackie.My.Resources.Resources.icons8_tick_161
        Me.button_create.Location = New System.Drawing.Point(446, 0)
        Me.button_create.Margin = New System.Windows.Forms.Padding(0)
        Me.button_create.Name = "button_create"
        Me.button_create.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.button_create.Size = New System.Drawing.Size(50, 46)
        Me.button_create.TabIndex = 10
        Me.button_create.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Cascadia Mono", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(189, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(118, 21)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "New Category"
        '
        'New_Category
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(496, 427)
        Me.Controls.Add(Me.panel_topbar)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximumSize = New System.Drawing.Size(1920, 1200)
        Me.Name = "New_Category"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "New_Category"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.tabelPanel_color.ResumeLayout(False)
        Me.tabelPanel_color.PerformLayout()
        Me.panel_topbar.ResumeLayout(False)
        Me.panel_topbar.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents tabelPanel_color As TableLayoutPanel
    Friend WithEvents Radio_Color3 As RadioButton
    Friend WithEvents txt_name As TextBox
    Friend WithEvents txt_description As TextBox
    Friend WithEvents Radio_Color7 As RadioButton
    Friend WithEvents Radio_Color6 As RadioButton
    Friend WithEvents Radio_Color9 As RadioButton
    Friend WithEvents Radio_Color8 As RadioButton
    Friend WithEvents Radio_Color5 As RadioButton
    Friend WithEvents Radio_Color2 As RadioButton
    Friend WithEvents Radio_Color1 As RadioButton
    Friend WithEvents Radio_Color4 As RadioButton
    Friend WithEvents panel_topbar As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents button_close As Button
    Friend WithEvents button_create As Button
    Friend WithEvents btn_custom_color As Button
End Class
