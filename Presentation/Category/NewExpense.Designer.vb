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
            Me.Label4 = New System.Windows.Forms.Label()
            Me.panel_topbar = New System.Windows.Forms.Panel()
            Me.button_close = New System.Windows.Forms.Button()
            Me.button_create = New System.Windows.Forms.Button()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
            Me.txt_Remarks = New System.Windows.Forms.RichTextBox()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.txt_date_picker = New System.Windows.Forms.DateTimePicker()
            Me.panel_radio_category = New System.Windows.Forms.FlowLayoutPanel()
            Me.txt_Amount = New System.Windows.Forms.RichTextBox()
            Me.timer_reset_image = New System.Windows.Forms.Timer(Me.components)
            Me.panel_topbar.SuspendLayout()
            Me.TableLayoutPanel1.SuspendLayout()
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
            Me.panel_topbar.Controls.Add(Me.button_close)
            Me.panel_topbar.Controls.Add(Me.button_create)
            Me.panel_topbar.Controls.Add(Me.Label4)
            Me.panel_topbar.Dock = System.Windows.Forms.DockStyle.Top
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
            Me.button_close.Size = New System.Drawing.Size(50, 46)
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
            Me.button_create.Location = New System.Drawing.Point(460, 0)
            Me.button_create.Margin = New System.Windows.Forms.Padding(0)
            Me.button_create.Name = "button_create"
            Me.button_create.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.button_create.Size = New System.Drawing.Size(50, 46)
            Me.button_create.TabIndex = 10
            Me.button_create.UseVisualStyleBackColor = True
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.Label2.Font = New System.Drawing.Font("Cascadia Mono", 10.0!)
            Me.Label2.Location = New System.Drawing.Point(3, 87)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(431, 18)
            Me.Label2.TabIndex = 2
            Me.Label2.Text = "Remarks"
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.Label1.Font = New System.Drawing.Font("Cascadia Mono", 10.0!)
            Me.Label1.Location = New System.Drawing.Point(3, 17)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(431, 18)
            Me.Label1.TabIndex = 0
            Me.Label1.Text = "Amount"
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.Label3.Font = New System.Drawing.Font("Cascadia Mono", 10.0!)
            Me.Label3.Location = New System.Drawing.Point(3, 157)
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
            Me.TableLayoutPanel1.Controls.Add(Me.txt_Remarks, 0, 3)
            Me.TableLayoutPanel1.Controls.Add(Me.Label5, 0, 6)
            Me.TableLayoutPanel1.Controls.Add(Me.Label3, 0, 4)
            Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 2)
            Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
            Me.TableLayoutPanel1.Controls.Add(Me.txt_date_picker, 0, 5)
            Me.TableLayoutPanel1.Controls.Add(Me.panel_radio_category, 0, 7)
            Me.TableLayoutPanel1.Controls.Add(Me.txt_Amount, 0, 1)
            Me.TableLayoutPanel1.Location = New System.Drawing.Point(35, 78)
            Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
            Me.TableLayoutPanel1.RowCount = 8
            Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.13008!))
            Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.130081!))
            Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.130081!))
            Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.130081!))
            Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.130081!))
            Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.130081!))
            Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.130081!))
            Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 43.08943!))
            Me.TableLayoutPanel1.Size = New System.Drawing.Size(437, 442)
            Me.TableLayoutPanel1.TabIndex = 3
            '
            'txt_Remarks
            '
            Me.txt_Remarks.Dock = System.Windows.Forms.DockStyle.Fill
            Me.txt_Remarks.Font = New System.Drawing.Font("Cascadia Mono", 9.75!)
            Me.txt_Remarks.Location = New System.Drawing.Point(3, 108)
            Me.txt_Remarks.Multiline = False
            Me.txt_Remarks.Name = "txt_Remarks"
            Me.txt_Remarks.Size = New System.Drawing.Size(431, 29)
            Me.txt_Remarks.TabIndex = 11
            Me.txt_Remarks.Text = ""
            '
            'Label5
            '
            Me.Label5.AutoSize = True
            Me.Label5.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.Label5.Font = New System.Drawing.Font("Cascadia Mono", 10.0!)
            Me.Label5.Location = New System.Drawing.Point(3, 227)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(431, 18)
            Me.Label5.TabIndex = 8
            Me.Label5.Text = "Category"
            '
            'txt_date_picker
            '
            Me.txt_date_picker.Location = New System.Drawing.Point(3, 178)
            Me.txt_date_picker.Name = "txt_date_picker"
            Me.txt_date_picker.Size = New System.Drawing.Size(200, 20)
            Me.txt_date_picker.TabIndex = 7
            '
            'panel_radio_category
            '
            Me.panel_radio_category.Dock = System.Windows.Forms.DockStyle.Fill
            Me.panel_radio_category.Location = New System.Drawing.Point(0, 245)
            Me.panel_radio_category.Margin = New System.Windows.Forms.Padding(0)
            Me.panel_radio_category.Name = "panel_radio_category"
            Me.panel_radio_category.Size = New System.Drawing.Size(437, 197)
            Me.panel_radio_category.TabIndex = 9
            '
            'txt_Amount
            '
            Me.txt_Amount.Font = New System.Drawing.Font("Cascadia Mono", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txt_Amount.Location = New System.Drawing.Point(3, 38)
            Me.txt_Amount.Multiline = False
            Me.txt_Amount.Name = "txt_Amount"
            Me.txt_Amount.Size = New System.Drawing.Size(417, 29)
            Me.txt_Amount.TabIndex = 10
            Me.txt_Amount.Text = ""
            '
            'timer_reset_image
            '
            Me.timer_reset_image.Interval = 120
            '
            'NewExpense
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(510, 561)
            Me.Controls.Add(Me.panel_topbar)
            Me.Controls.Add(Me.TableLayoutPanel1)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            Me.KeyPreview = True
            Me.MinimizeBox = False
            Me.Name = "NewExpense"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "NewExpense"
            Me.panel_topbar.ResumeLayout(False)
            Me.panel_topbar.PerformLayout()
            Me.TableLayoutPanel1.ResumeLayout(False)
            Me.TableLayoutPanel1.PerformLayout()
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
        Friend WithEvents panel_radio_category As FlowLayoutPanel
        Friend WithEvents txt_Remarks As RichTextBox
        Friend WithEvents txt_Amount As RichTextBox
        Friend WithEvents timer_reset_image As Timer
    End Class
End NameSpace