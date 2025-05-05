Namespace Presentation
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class NewExpense
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
            Me.components = New System.ComponentModel.Container()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NewExpense))
            Me.Label4 = New System.Windows.Forms.Label()
            Me.panel_topbar = New System.Windows.Forms.Panel()
            Me.button_close = New System.Windows.Forms.Button()
            Me.button_create = New System.Windows.Forms.Button()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
            Me.txt_time_picker = New System.Windows.Forms.DateTimePicker()
            Me.panel_radio_category = New System.Windows.Forms.FlowLayoutPanel()
            Me.txt_Remarks = New System.Windows.Forms.RichTextBox()
            Me.txt_date_picker = New System.Windows.Forms.DateTimePicker()
            Me.txt_Amount = New System.Windows.Forms.RichTextBox()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.time_select = New System.Windows.Forms.Label()
            Me.timer_reset_image = New System.Windows.Forms.Timer(Me.components)
            Me.panel_back = New System.Windows.Forms.Panel()
            Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
            Me.lbl_info = New System.Windows.Forms.Label()
            Me.panel_topbar.SuspendLayout()
            Me.TableLayoutPanel1.SuspendLayout()
            Me.panel_back.SuspendLayout()
            Me.TableLayoutPanel2.SuspendLayout()
            Me.SuspendLayout()
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.Font = New System.Drawing.Font("Cascadia Mono", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label4.Location = New System.Drawing.Point(189, 9)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(109, 21)
            Me.Label4.TabIndex = 2
            Me.Label4.Text = "New Expense"
            '
            'panel_topbar
            '
            Me.panel_topbar.BackColor = System.Drawing.Color.Transparent
            Me.panel_topbar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.panel_topbar.Controls.Add(Me.button_close)
            Me.panel_topbar.Controls.Add(Me.button_create)
            Me.panel_topbar.Controls.Add(Me.Label4)
            Me.panel_topbar.Dock = System.Windows.Forms.DockStyle.Top
            Me.panel_topbar.Font = New System.Drawing.Font("IBM Plex Mono", 10.0!)
            Me.panel_topbar.Location = New System.Drawing.Point(0, 0)
            Me.panel_topbar.Margin = New System.Windows.Forms.Padding(0)
            Me.panel_topbar.Name = "panel_topbar"
            Me.panel_topbar.Size = New System.Drawing.Size(510, 46)
            Me.panel_topbar.TabIndex = 4
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
            Me.button_close.Size = New System.Drawing.Size(50, 44)
            Me.button_close.TabIndex = 11
            Me.button_close.UseVisualStyleBackColor = True
            '
            'button_create
            '
            Me.button_create.Dock = System.Windows.Forms.DockStyle.Right
            Me.button_create.FlatAppearance.BorderSize = 0
            Me.button_create.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(125, Byte), Integer))
            Me.button_create.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.button_create.Image = Global.expense_Trackie.My.Resources.Resources.tickRound
            Me.button_create.Location = New System.Drawing.Point(458, 0)
            Me.button_create.Margin = New System.Windows.Forms.Padding(0)
            Me.button_create.Name = "button_create"
            Me.button_create.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.button_create.Size = New System.Drawing.Size(50, 44)
            Me.button_create.TabIndex = 10
            Me.button_create.UseVisualStyleBackColor = True
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.Label2.Font = New System.Drawing.Font("IBM Plex Mono", 10.0!)
            Me.Label2.Location = New System.Drawing.Point(3, 90)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(431, 18)
            Me.Label2.TabIndex = 2
            Me.Label2.Text = "Remarks"
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.Label1.Font = New System.Drawing.Font("IBM Plex Mono", 10.0!)
            Me.Label1.Location = New System.Drawing.Point(3, 18)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(431, 18)
            Me.Label1.TabIndex = 0
            Me.Label1.Text = "Amount"
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.Label3.Font = New System.Drawing.Font("IBM Plex Mono", 10.0!)
            Me.Label3.Location = New System.Drawing.Point(3, 162)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(431, 18)
            Me.Label3.TabIndex = 4
            Me.Label3.Text = "Date"
            '
            'TableLayoutPanel1
            '
            Me.TableLayoutPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.TableLayoutPanel1.BackColor = System.Drawing.Color.Transparent
            Me.TableLayoutPanel1.ColumnCount = 1
            Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
            Me.TableLayoutPanel1.Controls.Add(Me.txt_time_picker, 0, 7)
            Me.TableLayoutPanel1.Controls.Add(Me.panel_radio_category, 0, 9)
            Me.TableLayoutPanel1.Controls.Add(Me.txt_Remarks, 0, 3)
            Me.TableLayoutPanel1.Controls.Add(Me.Label3, 0, 4)
            Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 2)
            Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
            Me.TableLayoutPanel1.Controls.Add(Me.txt_date_picker, 0, 5)
            Me.TableLayoutPanel1.Controls.Add(Me.txt_Amount, 0, 1)
            Me.TableLayoutPanel1.Controls.Add(Me.Label5, 0, 8)
            Me.TableLayoutPanel1.Controls.Add(Me.time_select, 0, 6)
            Me.TableLayoutPanel1.Location = New System.Drawing.Point(35, 78)
            Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
            Me.TableLayoutPanel1.RowCount = 10
            Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.992982!))
            Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.992983!))
            Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.992983!))
            Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.992983!))
            Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.992983!))
            Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.992983!))
            Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.992983!))
            Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.992913!))
            Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.992913!))
            Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.0633!))
            Me.TableLayoutPanel1.Size = New System.Drawing.Size(437, 515)
            Me.TableLayoutPanel1.TabIndex = 3
            '
            'txt_time_picker
            '
            Me.txt_time_picker.CalendarFont = New System.Drawing.Font("IBM Plex Mono", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txt_time_picker.Dock = System.Windows.Forms.DockStyle.Left
            Me.txt_time_picker.Format = System.Windows.Forms.DateTimePickerFormat.Time
            Me.txt_time_picker.Location = New System.Drawing.Point(3, 255)
            Me.txt_time_picker.Name = "txt_time_picker"
            Me.txt_time_picker.ShowUpDown = True
            Me.txt_time_picker.Size = New System.Drawing.Size(97, 20)
            Me.txt_time_picker.TabIndex = 13
            '
            'panel_radio_category
            '
            Me.panel_radio_category.Dock = System.Windows.Forms.DockStyle.Fill
            Me.panel_radio_category.Location = New System.Drawing.Point(0, 324)
            Me.panel_radio_category.Margin = New System.Windows.Forms.Padding(0)
            Me.panel_radio_category.Name = "panel_radio_category"
            Me.panel_radio_category.Size = New System.Drawing.Size(437, 191)
            Me.panel_radio_category.TabIndex = 13
            '
            'txt_Remarks
            '
            Me.txt_Remarks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.txt_Remarks.Dock = System.Windows.Forms.DockStyle.Fill
            Me.txt_Remarks.Font = New System.Drawing.Font("IBM Plex Mono", 11.0!)
            Me.txt_Remarks.Location = New System.Drawing.Point(3, 111)
            Me.txt_Remarks.Multiline = False
            Me.txt_Remarks.Name = "txt_Remarks"
            Me.txt_Remarks.Size = New System.Drawing.Size(431, 30)
            Me.txt_Remarks.TabIndex = 11
            Me.txt_Remarks.Text = ""
            '
            'txt_date_picker
            '
            Me.txt_date_picker.CalendarFont = New System.Drawing.Font("IBM Plex Mono", 8.249999!)
            Me.txt_date_picker.Dock = System.Windows.Forms.DockStyle.Left
            Me.txt_date_picker.Location = New System.Drawing.Point(3, 183)
            Me.txt_date_picker.Name = "txt_date_picker"
            Me.txt_date_picker.Size = New System.Drawing.Size(200, 20)
            Me.txt_date_picker.TabIndex = 7
            '
            'txt_Amount
            '
            Me.txt_Amount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.txt_Amount.Dock = System.Windows.Forms.DockStyle.Fill
            Me.txt_Amount.Font = New System.Drawing.Font("IBM Plex Mono", 11.0!)
            Me.txt_Amount.Location = New System.Drawing.Point(3, 39)
            Me.txt_Amount.Multiline = False
            Me.txt_Amount.Name = "txt_Amount"
            Me.txt_Amount.Size = New System.Drawing.Size(431, 30)
            Me.txt_Amount.TabIndex = 10
            Me.txt_Amount.Text = ""
            '
            'Label5
            '
            Me.Label5.AutoSize = True
            Me.Label5.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.Label5.Font = New System.Drawing.Font("IBM Plex Mono", 10.0!)
            Me.Label5.Location = New System.Drawing.Point(3, 306)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(431, 18)
            Me.Label5.TabIndex = 8
            Me.Label5.Text = "Category"
            '
            'time_select
            '
            Me.time_select.AutoSize = True
            Me.time_select.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.time_select.Font = New System.Drawing.Font("IBM Plex Mono", 10.0!)
            Me.time_select.Location = New System.Drawing.Point(3, 234)
            Me.time_select.Name = "time_select"
            Me.time_select.Size = New System.Drawing.Size(431, 18)
            Me.time_select.TabIndex = 12
            Me.time_select.Text = "Time"
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
            Me.panel_back.Size = New System.Drawing.Size(510, 648)
            Me.panel_back.TabIndex = 7
            '
            'TableLayoutPanel2
            '
            Me.TableLayoutPanel2.BackColor = System.Drawing.Color.Transparent
            Me.TableLayoutPanel2.ColumnCount = 1
            Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
            Me.TableLayoutPanel2.Controls.Add(Me.lbl_info, 0, 0)
            Me.TableLayoutPanel2.Location = New System.Drawing.Point(101, 611)
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
            'NewExpense
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(510, 648)
            Me.Controls.Add(Me.panel_topbar)
            Me.Controls.Add(Me.TableLayoutPanel1)
            Me.Controls.Add(Me.panel_back)
            Me.DoubleBuffered = True
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.KeyPreview = True
            Me.MinimizeBox = False
            Me.Name = "NewExpense"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "NewExpense"
            Me.panel_topbar.ResumeLayout(False)
            Me.panel_topbar.PerformLayout()
            Me.TableLayoutPanel1.ResumeLayout(False)
            Me.TableLayoutPanel1.PerformLayout()
            Me.panel_back.ResumeLayout(False)
            Me.TableLayoutPanel2.ResumeLayout(False)
            Me.TableLayoutPanel2.PerformLayout()
            Me.ResumeLayout(False)

        End Sub

        Friend WithEvents button_close As Button
        Friend WithEvents Label4 As Label
        Friend WithEvents panel_topbar As Panel
        Friend WithEvents button_create As Button
        Friend WithEvents Label2 As Label
        Friend WithEvents Label1 As Label
        Friend WithEvents Label3 As Label
        Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
        Friend WithEvents Label5 As Label
        Friend WithEvents txt_date_picker As DateTimePicker
        Friend WithEvents txt_Remarks As RichTextBox
        Friend WithEvents txt_Amount As RichTextBox
        Friend WithEvents timer_reset_image As Timer
        Friend WithEvents panel_back As Panel
        Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
        Friend WithEvents lbl_info As Label
        Friend WithEvents time_select As Label
        Friend WithEvents txt_time_picker As DateTimePicker
        Friend WithEvents panel_radio_category As FlowLayoutPanel
    End Class
End NameSpace