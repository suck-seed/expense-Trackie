Namespace Presentation
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class MonthView
        Inherits System.Windows.Forms.UserControl

        'UserControl overrides dispose to clean up the component list.
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
            Me.top_table_day_form = New System.Windows.Forms.TableLayoutPanel()
            Me.btn_previous = New System.Windows.Forms.Button()
            Me.lbl_amount = New System.Windows.Forms.Label()
            Me.Label9 = New System.Windows.Forms.Label()
            Me.lbl_month = New System.Windows.Forms.Label()
            Me.lbl_year = New System.Windows.Forms.Label()
            Me.btn_next = New System.Windows.Forms.Button()
            Me.top_table_day_form.SuspendLayout()
            Me.SuspendLayout()
            '
            'top_table_day_form
            '
            Me.top_table_day_form.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
            Me.top_table_day_form.ColumnCount = 7
            Me.top_table_day_form.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.321131!))
            Me.top_table_day_form.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.901831!))
            Me.top_table_day_form.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.29451!))
            Me.top_table_day_form.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.38769!))
            Me.top_table_day_form.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28531!))
            Me.top_table_day_form.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28531!))
            Me.top_table_day_form.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28816!))
            Me.top_table_day_form.Controls.Add(Me.btn_previous, 0, 1)
            Me.top_table_day_form.Controls.Add(Me.lbl_amount, 6, 1)
            Me.top_table_day_form.Controls.Add(Me.Label9, 6, 0)
            Me.top_table_day_form.Controls.Add(Me.lbl_month, 1, 1)
            Me.top_table_day_form.Controls.Add(Me.lbl_year, 1, 0)
            Me.top_table_day_form.Controls.Add(Me.btn_next, 2, 1)
            Me.top_table_day_form.Dock = System.Windows.Forms.DockStyle.Top
            Me.top_table_day_form.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize
            Me.top_table_day_form.Location = New System.Drawing.Point(0, 0)
            Me.top_table_day_form.Name = "top_table_day_form"
            Me.top_table_day_form.RowCount = 2
            Me.top_table_day_form.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
            Me.top_table_day_form.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
            Me.top_table_day_form.Size = New System.Drawing.Size(1123, 86)
            Me.top_table_day_form.TabIndex = 9
            '
            'btn_previous
            '
            Me.btn_previous.Dock = System.Windows.Forms.DockStyle.Right
            Me.btn_previous.FlatAppearance.BorderSize = 0
            Me.btn_previous.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
            Me.btn_previous.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btn_previous.Image = Global.expense_Trackie.My.Resources.Resources.icons8_back_16
            Me.btn_previous.Location = New System.Drawing.Point(32, 43)
            Me.btn_previous.Margin = New System.Windows.Forms.Padding(0)
            Me.btn_previous.Name = "btn_previous"
            Me.btn_previous.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.btn_previous.Size = New System.Drawing.Size(50, 43)
            Me.btn_previous.TabIndex = 20
            Me.btn_previous.UseVisualStyleBackColor = True
            '
            'lbl_amount
            '
            Me.lbl_amount.AutoSize = True
            Me.lbl_amount.Dock = System.Windows.Forms.DockStyle.Fill
            Me.lbl_amount.Font = New System.Drawing.Font("Cascadia Mono", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lbl_amount.Location = New System.Drawing.Point(962, 43)
            Me.lbl_amount.Name = "lbl_amount"
            Me.lbl_amount.Size = New System.Drawing.Size(158, 43)
            Me.lbl_amount.TabIndex = 18
            Me.lbl_amount.Text = "Amount"
            Me.lbl_amount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'Label9
            '
            Me.Label9.AutoSize = True
            Me.Label9.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Label9.Font = New System.Drawing.Font("Cascadia Mono", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label9.Location = New System.Drawing.Point(962, 0)
            Me.Label9.Name = "Label9"
            Me.Label9.Size = New System.Drawing.Size(158, 43)
            Me.Label9.TabIndex = 7
            Me.Label9.Text = "Total"
            Me.Label9.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            '
            'lbl_month
            '
            Me.lbl_month.AutoSize = True
            Me.lbl_month.Dock = System.Windows.Forms.DockStyle.Fill
            Me.lbl_month.Font = New System.Drawing.Font("Cascadia Mono", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lbl_month.Location = New System.Drawing.Point(85, 43)
            Me.lbl_month.Name = "lbl_month"
            Me.lbl_month.Size = New System.Drawing.Size(94, 43)
            Me.lbl_month.TabIndex = 1
            Me.lbl_month.Text = "Sep"
            Me.lbl_month.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'lbl_year
            '
            Me.lbl_year.AutoSize = True
            Me.lbl_year.Dock = System.Windows.Forms.DockStyle.Fill
            Me.lbl_year.Font = New System.Drawing.Font("Cascadia Mono", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lbl_year.Location = New System.Drawing.Point(85, 0)
            Me.lbl_year.Name = "lbl_year"
            Me.lbl_year.Size = New System.Drawing.Size(94, 43)
            Me.lbl_year.TabIndex = 0
            Me.lbl_year.Text = "2024"
            Me.lbl_year.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            '
            'btn_next
            '
            Me.btn_next.Dock = System.Windows.Forms.DockStyle.Left
            Me.btn_next.FlatAppearance.BorderSize = 0
            Me.btn_next.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
            Me.btn_next.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btn_next.Image = Global.expense_Trackie.My.Resources.Resources.icons8_forward_16
            Me.btn_next.Location = New System.Drawing.Point(182, 43)
            Me.btn_next.Margin = New System.Windows.Forms.Padding(0)
            Me.btn_next.Name = "btn_next"
            Me.btn_next.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.btn_next.Size = New System.Drawing.Size(50, 43)
            Me.btn_next.TabIndex = 19
            Me.btn_next.UseVisualStyleBackColor = True
            '
            'monthView
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.top_table_day_form)
            Me.Name = "monthView"
            Me.Size = New System.Drawing.Size(1123, 856)
            Me.top_table_day_form.ResumeLayout(False)
            Me.top_table_day_form.PerformLayout()
            Me.ResumeLayout(False)

        End Sub

        Friend WithEvents top_table_day_form As TableLayoutPanel
        Friend WithEvents btn_previous As Button
        Friend WithEvents lbl_amount As Label
        Friend WithEvents Label9 As Label
        Friend WithEvents lbl_month As Label
        Friend WithEvents lbl_year As Label
        Friend WithEvents btn_next As Button
    End Class
End NameSpace