﻿Namespace Presentation
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class NewCategory
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NewCategory))
            Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
            Me.txt_description = New System.Windows.Forms.RichTextBox()
            Me.txt_name = New System.Windows.Forms.RichTextBox()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.panel_color = New System.Windows.Forms.TableLayoutPanel()
            Me.btn_custom_color = New System.Windows.Forms.Button()
            Me.panel_topbar = New System.Windows.Forms.Panel()
            Me.button_close = New System.Windows.Forms.Button()
            Me.button_create = New System.Windows.Forms.Button()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.timer_reset_image = New System.Windows.Forms.Timer(Me.components)
            Me.panel_back = New System.Windows.Forms.Panel()
            Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
            Me.lbl_info = New System.Windows.Forms.Label()
            Me.TableLayoutPanel1.SuspendLayout()
            Me.panel_topbar.SuspendLayout()
            Me.panel_back.SuspendLayout()
            Me.TableLayoutPanel2.SuspendLayout()
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
            Me.TableLayoutPanel1.Controls.Add(Me.panel_color, 0, 5)
            Me.TableLayoutPanel1.Controls.Add(Me.btn_custom_color, 0, 6)
            Me.TableLayoutPanel1.Location = New System.Drawing.Point(43, 65)
            Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
            Me.TableLayoutPanel1.RowCount = 7
            Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28531!))
            Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.62791!))
            Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.27907!))
            Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.62791!))
            Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.62459!))
            Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.6113!))
            Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.60465!))
            Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
            Me.TableLayoutPanel1.Size = New System.Drawing.Size(407, 315)
            Me.TableLayoutPanel1.TabIndex = 1
            '
            'txt_description
            '
            Me.txt_description.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.txt_description.Dock = System.Windows.Forms.DockStyle.Fill
            Me.txt_description.Font = New System.Drawing.Font("IBM Plex Mono", 11.0!)
            Me.txt_description.Location = New System.Drawing.Point(3, 133)
            Me.txt_description.Multiline = False
            Me.txt_description.Name = "txt_description"
            Me.txt_description.Size = New System.Drawing.Size(401, 30)
            Me.txt_description.TabIndex = 12
            Me.txt_description.Text = ""
            '
            'txt_name
            '
            Me.txt_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.txt_name.Font = New System.Drawing.Font("IBM Plex Mono", 11.0!)
            Me.txt_name.Location = New System.Drawing.Point(3, 47)
            Me.txt_name.Multiline = False
            Me.txt_name.Name = "txt_name"
            Me.txt_name.Size = New System.Drawing.Size(401, 29)
            Me.txt_name.TabIndex = 11
            Me.txt_name.Text = ""
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.Label3.Font = New System.Drawing.Font("Cascadia Mono", 10.0!)
            Me.Label3.Location = New System.Drawing.Point(3, 187)
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
            Me.Label2.Location = New System.Drawing.Point(3, 112)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(401, 18)
            Me.Label2.TabIndex = 2
            Me.Label2.Text = "Description"
            '
            'Label1
            '
            Me.Label1.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.Label1.Font = New System.Drawing.Font("Cascadia Mono", 10.0!)
            Me.Label1.Location = New System.Drawing.Point(3, 26)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(401, 18)
            Me.Label1.TabIndex = 0
            Me.Label1.Text = "Name"
            '
            'panel_color
            '
            Me.panel_color.ColumnCount = 9
            Me.panel_color.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
            Me.panel_color.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
            Me.panel_color.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
            Me.panel_color.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
            Me.panel_color.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
            Me.panel_color.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
            Me.panel_color.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
            Me.panel_color.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.7207!))
            Me.panel_color.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.47132!))
            Me.panel_color.Dock = System.Windows.Forms.DockStyle.Fill
            Me.panel_color.Location = New System.Drawing.Point(3, 208)
            Me.panel_color.Name = "panel_color"
            Me.panel_color.RowCount = 1
            Me.panel_color.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
            Me.panel_color.Size = New System.Drawing.Size(401, 45)
            Me.panel_color.TabIndex = 5
            '
            'btn_custom_color
            '
            Me.btn_custom_color.Anchor = System.Windows.Forms.AnchorStyles.None
            Me.btn_custom_color.AutoSize = True
            Me.btn_custom_color.BackColor = System.Drawing.SystemColors.ButtonFace
            Me.btn_custom_color.FlatAppearance.BorderSize = 0
            Me.btn_custom_color.FlatStyle = System.Windows.Forms.FlatStyle.Popup
            Me.btn_custom_color.Font = New System.Drawing.Font("Cascadia Mono", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btn_custom_color.Location = New System.Drawing.Point(146, 270)
            Me.btn_custom_color.Name = "btn_custom_color"
            Me.btn_custom_color.Size = New System.Drawing.Size(115, 30)
            Me.btn_custom_color.TabIndex = 7
            Me.btn_custom_color.Text = "Custom Color"
            Me.btn_custom_color.UseVisualStyleBackColor = False
            '
            'panel_topbar
            '
            Me.panel_topbar.BackColor = System.Drawing.Color.Transparent
            Me.panel_topbar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
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
            Me.button_close.Dock = System.Windows.Forms.DockStyle.Left
            Me.button_close.FlatAppearance.BorderSize = 0
            Me.button_close.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
            Me.button_close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(35, Byte), Integer))
            Me.button_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.button_close.Image = Global.expense_Trackie.My.Resources.Resources.icons8_close_16
            Me.button_close.Location = New System.Drawing.Point(0, 0)
            Me.button_close.Margin = New System.Windows.Forms.Padding(0)
            Me.button_close.Name = "button_close"
            Me.button_close.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.button_close.Size = New System.Drawing.Size(50, 44)
            Me.button_close.TabIndex = 11
            Me.button_close.UseVisualStyleBackColor = True
            '
            'button_create
            '
            Me.button_create.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.button_create.FlatAppearance.BorderSize = 0
            Me.button_create.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
            Me.button_create.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(125, Byte), Integer))
            Me.button_create.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.button_create.Image = Global.expense_Trackie.My.Resources.Resources.tickRound
            Me.button_create.Location = New System.Drawing.Point(444, 0)
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
            'timer_reset_image
            '
            Me.timer_reset_image.Interval = 120
            '
            'panel_back
            '
            Me.panel_back.BackColor = System.Drawing.Color.Transparent
            Me.panel_back.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.panel_back.Controls.Add(Me.TableLayoutPanel2)
            Me.panel_back.Dock = System.Windows.Forms.DockStyle.Fill
            Me.panel_back.Location = New System.Drawing.Point(0, 0)
            Me.panel_back.Name = "panel_back"
            Me.panel_back.Size = New System.Drawing.Size(496, 427)
            Me.panel_back.TabIndex = 7
            '
            'TableLayoutPanel2
            '
            Me.TableLayoutPanel2.BackColor = System.Drawing.Color.Transparent
            Me.TableLayoutPanel2.ColumnCount = 1
            Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
            Me.TableLayoutPanel2.Controls.Add(Me.lbl_info, 0, 0)
            Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 398)
            Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
            Me.TableLayoutPanel2.RowCount = 1
            Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
            Me.TableLayoutPanel2.Size = New System.Drawing.Size(494, 27)
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
            Me.lbl_info.Size = New System.Drawing.Size(488, 27)
            Me.lbl_info.TabIndex = 82
            Me.lbl_info.Text = "error"
            Me.lbl_info.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'NewCategory
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.SystemColors.Window
            Me.ClientSize = New System.Drawing.Size(496, 427)
            Me.Controls.Add(Me.panel_topbar)
            Me.Controls.Add(Me.TableLayoutPanel1)
            Me.Controls.Add(Me.panel_back)
            Me.DoubleBuffered = True
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.KeyPreview = True
            Me.MaximumSize = New System.Drawing.Size(496, 427)
            Me.MinimizeBox = False
            Me.Name = "NewCategory"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "New_Category"
            Me.TableLayoutPanel1.ResumeLayout(False)
            Me.TableLayoutPanel1.PerformLayout()
            Me.panel_topbar.ResumeLayout(False)
            Me.panel_topbar.PerformLayout()
            Me.panel_back.ResumeLayout(False)
            Me.TableLayoutPanel2.ResumeLayout(False)
            Me.TableLayoutPanel2.PerformLayout()
            Me.ResumeLayout(False)

        End Sub

        Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
        Friend WithEvents Label2 As Label
        Friend WithEvents Label1 As Label
        Friend WithEvents Label3 As Label
        Friend WithEvents panel_topbar As Panel
        Friend WithEvents Label4 As Label
        Friend WithEvents button_close As Button
        Friend WithEvents button_create As Button
        Friend WithEvents btn_custom_color As Button
        Friend WithEvents txt_description As RichTextBox
        Friend WithEvents txt_name As RichTextBox
        Friend WithEvents panel_color As TableLayoutPanel
        Friend WithEvents timer_reset_image As Timer
        Friend WithEvents panel_back As Panel
        Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
        Friend WithEvents lbl_info As Label
    End Class
End NameSpace