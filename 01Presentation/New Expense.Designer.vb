<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class New_Expense
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
        Me.txt_Remarks = New System.Windows.Forms.TextBox()
        Me.txt_Amount = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_date_picker = New System.Windows.Forms.DateTimePicker()
        Me.panel_topbar = New System.Windows.Forms.Panel()
        Me.button_close = New System.Windows.Forms.Button()
        Me.button_create = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
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
        Me.TableLayoutPanel1.Controls.Add(Me.txt_Remarks, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_Amount, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 0, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.Label5, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_date_picker, 0, 5)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(38, 73)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 8
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.49938!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.49938!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.49938!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.49938!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.49938!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.49938!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.50187!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.50187!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(416, 318)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'txt_Remarks
        '
        Me.txt_Remarks.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_Remarks.Font = New System.Drawing.Font("Cascadia Mono", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Remarks.Location = New System.Drawing.Point(3, 120)
        Me.txt_Remarks.Name = "txt_Remarks"
        Me.txt_Remarks.Size = New System.Drawing.Size(410, 25)
        Me.txt_Remarks.TabIndex = 6
        '
        'txt_Amount
        '
        Me.txt_Amount.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_Amount.Font = New System.Drawing.Font("Cascadia Mono", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Amount.Location = New System.Drawing.Point(3, 42)
        Me.txt_Amount.Name = "txt_Amount"
        Me.txt_Amount.Size = New System.Drawing.Size(410, 25)
        Me.txt_Amount.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label2.Font = New System.Drawing.Font("Cascadia Mono", 10.0!)
        Me.Label2.Location = New System.Drawing.Point(3, 99)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(410, 18)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Remarks"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label1.Font = New System.Drawing.Font("Cascadia Mono", 10.0!)
        Me.Label1.Location = New System.Drawing.Point(3, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(410, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Amount"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label3.Font = New System.Drawing.Font("Cascadia Mono", 10.0!)
        Me.Label3.Location = New System.Drawing.Point(3, 255)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(410, 18)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Category"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label5.Font = New System.Drawing.Font("Cascadia Mono", 10.0!)
        Me.Label5.Location = New System.Drawing.Point(3, 177)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(410, 18)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Date"
        '
        'txt_date_picker
        '
        Me.txt_date_picker.Font = New System.Drawing.Font("Cascadia Code", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_date_picker.Location = New System.Drawing.Point(3, 198)
        Me.txt_date_picker.Name = "txt_date_picker"
        Me.txt_date_picker.Size = New System.Drawing.Size(203, 20)
        Me.txt_date_picker.TabIndex = 8
        '
        'panel_topbar
        '
        Me.panel_topbar.Controls.Add(Me.button_close)
        Me.panel_topbar.Controls.Add(Me.button_create)
        Me.panel_topbar.Controls.Add(Me.Label4)
        Me.panel_topbar.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel_topbar.Location = New System.Drawing.Point(0, 0)
        Me.panel_topbar.Name = "panel_topbar"
        Me.panel_topbar.Size = New System.Drawing.Size(496, 46)
        Me.panel_topbar.TabIndex = 3
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
        Me.button_close.TabIndex = 9
        Me.button_close.UseVisualStyleBackColor = True
        '
        'button_create
        '
        Me.button_create.Dock = System.Windows.Forms.DockStyle.Right
        Me.button_create.FlatAppearance.BorderSize = 0
        Me.button_create.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.button_create.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button_create.Image = Global.expense_Trackie.My.Resources.Resources.icons8_tick_161
        Me.button_create.Location = New System.Drawing.Point(446, 0)
        Me.button_create.Margin = New System.Windows.Forms.Padding(0)
        Me.button_create.Name = "button_create"
        Me.button_create.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.button_create.Size = New System.Drawing.Size(50, 46)
        Me.button_create.TabIndex = 8
        Me.button_create.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Cascadia Mono", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(193, 11)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(109, 21)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "New Expense" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'New_Expense
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(496, 522)
        Me.Controls.Add(Me.panel_topbar)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximumSize = New System.Drawing.Size(1920, 1200)
        Me.Name = "New_Expense"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "New_Expense"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.panel_topbar.ResumeLayout(False)
        Me.panel_topbar.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_Remarks As TextBox
    Friend WithEvents txt_Amount As TextBox
    Friend WithEvents panel_topbar As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents button_create As Button
    Friend WithEvents button_close As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_date_picker As DateTimePicker
End Class
