<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dayView
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.generalTable = New System.Windows.Forms.TableLayoutPanel()
        Me.btn_previous = New System.Windows.Forms.Button()
        Me.lbl_total_amount = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lbl_day = New System.Windows.Forms.Label()
        Me.lbl_month = New System.Windows.Forms.Label()
        Me.btn_next = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.panel_expense_display = New System.Windows.Forms.TableLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.generalTable.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.panel_expense_display.SuspendLayout()
        Me.SuspendLayout()
        '
        'generalTable
        '
        Me.generalTable.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.generalTable.BackColor = System.Drawing.Color.Transparent
        Me.generalTable.ColumnCount = 7
        Me.generalTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.16112!))
        Me.generalTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.030603!))
        Me.generalTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.32223!))
        Me.generalTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.38769!))
        Me.generalTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28531!))
        Me.generalTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28531!))
        Me.generalTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28816!))
        Me.generalTable.Controls.Add(Me.btn_previous, 0, 1)
        Me.generalTable.Controls.Add(Me.lbl_total_amount, 6, 1)
        Me.generalTable.Controls.Add(Me.Label9, 6, 0)
        Me.generalTable.Controls.Add(Me.lbl_day, 1, 1)
        Me.generalTable.Controls.Add(Me.lbl_month, 1, 0)
        Me.generalTable.Controls.Add(Me.btn_next, 2, 1)
        Me.generalTable.Dock = System.Windows.Forms.DockStyle.Top
        Me.generalTable.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize
        Me.generalTable.Location = New System.Drawing.Point(0, 0)
        Me.generalTable.Name = "generalTable"
        Me.generalTable.RowCount = 2
        Me.generalTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.generalTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.generalTable.Size = New System.Drawing.Size(1111, 86)
        Me.generalTable.TabIndex = 6
        '
        'btn_previous
        '
        Me.btn_previous.Dock = System.Windows.Forms.DockStyle.Right
        Me.btn_previous.FlatAppearance.BorderSize = 0
        Me.btn_previous.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.btn_previous.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_previous.Image = Global.expense_Trackie.My.Resources.Resources.icons8_back_16
        Me.btn_previous.Location = New System.Drawing.Point(74, 43)
        Me.btn_previous.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_previous.Name = "btn_previous"
        Me.btn_previous.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btn_previous.Size = New System.Drawing.Size(50, 43)
        Me.btn_previous.TabIndex = 20
        Me.btn_previous.UseVisualStyleBackColor = True
        '
        'lbl_total_amount
        '
        Me.lbl_total_amount.AutoSize = True
        Me.lbl_total_amount.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_total_amount.Font = New System.Drawing.Font("Cascadia Mono", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_total_amount.Location = New System.Drawing.Point(953, 43)
        Me.lbl_total_amount.Name = "lbl_total_amount"
        Me.lbl_total_amount.Size = New System.Drawing.Size(155, 43)
        Me.lbl_total_amount.TabIndex = 18
        Me.lbl_total_amount.Text = "Amount"
        Me.lbl_total_amount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label9.Font = New System.Drawing.Font("Cascadia Mono", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(953, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(155, 43)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "Total"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'lbl_day
        '
        Me.lbl_day.AutoSize = True
        Me.lbl_day.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_day.Font = New System.Drawing.Font("Cascadia Mono", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_day.Location = New System.Drawing.Point(127, 43)
        Me.lbl_day.Name = "lbl_day"
        Me.lbl_day.Size = New System.Drawing.Size(61, 43)
        Me.lbl_day.TabIndex = 1
        Me.lbl_day.Text = "10"
        Me.lbl_day.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_month
        '
        Me.lbl_month.AutoSize = True
        Me.lbl_month.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_month.Font = New System.Drawing.Font("Cascadia Mono", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_month.Location = New System.Drawing.Point(127, 0)
        Me.lbl_month.Name = "lbl_month"
        Me.lbl_month.Size = New System.Drawing.Size(61, 43)
        Me.lbl_month.TabIndex = 0
        Me.lbl_month.Text = "Sep"
        Me.lbl_month.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'btn_next
        '
        Me.btn_next.Dock = System.Windows.Forms.DockStyle.Left
        Me.btn_next.FlatAppearance.BorderSize = 0
        Me.btn_next.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.btn_next.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_next.Image = Global.expense_Trackie.My.Resources.Resources.icons8_forward_16
        Me.btn_next.Location = New System.Drawing.Point(191, 43)
        Me.btn_next.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_next.Name = "btn_next"
        Me.btn_next.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btn_next.Size = New System.Drawing.Size(50, 43)
        Me.btn_next.TabIndex = 19
        Me.btn_next.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.panel_expense_display)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 86)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1111, 808)
        Me.Panel1.TabIndex = 7
        '
        'panel_expense_display
        '
        Me.panel_expense_display.ColumnCount = 1
        Me.panel_expense_display.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.panel_expense_display.Controls.Add(Me.Label1, 0, 0)
        Me.panel_expense_display.Location = New System.Drawing.Point(155, 20)
        Me.panel_expense_display.Name = "panel_expense_display"
        Me.panel_expense_display.RowCount = 3
        Me.panel_expense_display.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.panel_expense_display.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.panel_expense_display.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.panel_expense_display.Size = New System.Drawing.Size(797, 758)
        Me.panel_expense_display.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Cascadia Mono", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(100, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(100, 0, 100, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(597, 252)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Amount"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dayView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.generalTable)
        Me.Name = "dayView"
        Me.Size = New System.Drawing.Size(1111, 894)
        Me.generalTable.ResumeLayout(False)
        Me.generalTable.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.panel_expense_display.ResumeLayout(False)
        Me.panel_expense_display.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents generalTable As TableLayoutPanel
    Friend WithEvents btn_previous As Button
    Friend WithEvents lbl_total_amount As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents lbl_day As Label
    Friend WithEvents lbl_month As Label
    Friend WithEvents btn_next As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents panel_expense_display As TableLayoutPanel
    Friend WithEvents Label1 As Label
End Class
