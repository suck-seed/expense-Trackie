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
        Me.panel_expenses = New System.Windows.Forms.FlowLayoutPanel()
        Me.generalTable.SuspendLayout()
        Me.SuspendLayout()
        '
        'generalTable
        '
        Me.generalTable.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.generalTable.ColumnCount = 7
        Me.generalTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.321131!))
        Me.generalTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.901831!))
        Me.generalTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.29451!))
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
        Me.btn_previous.Location = New System.Drawing.Point(31, 43)
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
        Me.lbl_day.Location = New System.Drawing.Point(84, 43)
        Me.lbl_day.Name = "lbl_day"
        Me.lbl_day.Size = New System.Drawing.Size(93, 43)
        Me.lbl_day.TabIndex = 1
        Me.lbl_day.Text = "10"
        Me.lbl_day.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_month
        '
        Me.lbl_month.AutoSize = True
        Me.lbl_month.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_month.Font = New System.Drawing.Font("Cascadia Mono", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_month.Location = New System.Drawing.Point(84, 0)
        Me.lbl_month.Name = "lbl_month"
        Me.lbl_month.Size = New System.Drawing.Size(93, 43)
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
        Me.btn_next.Location = New System.Drawing.Point(180, 43)
        Me.btn_next.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_next.Name = "btn_next"
        Me.btn_next.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btn_next.Size = New System.Drawing.Size(50, 43)
        Me.btn_next.TabIndex = 19
        Me.btn_next.UseVisualStyleBackColor = True
        '
        'panel_expenses
        '
        Me.panel_expenses.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.panel_expenses.AutoScroll = True
        Me.panel_expenses.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.panel_expenses.Location = New System.Drawing.Point(0, 86)
        Me.panel_expenses.Margin = New System.Windows.Forms.Padding(0)
        Me.panel_expenses.Name = "panel_expenses"
        Me.panel_expenses.Size = New System.Drawing.Size(1111, 808)
        Me.panel_expenses.TabIndex = 7
        '
        'dayView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.panel_expenses)
        Me.Controls.Add(Me.generalTable)
        Me.Name = "dayView"
        Me.Size = New System.Drawing.Size(1111, 894)
        Me.generalTable.ResumeLayout(False)
        Me.generalTable.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents generalTable As TableLayoutPanel
    Friend WithEvents btn_previous As Button
    Friend WithEvents lbl_total_amount As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents lbl_day As Label
    Friend WithEvents lbl_month As Label
    Friend WithEvents btn_next As Button
    Friend WithEvents panel_expenses As FlowLayoutPanel
End Class
