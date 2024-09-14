<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class monthView
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
        Me.txt_total_amount = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_month = New System.Windows.Forms.Label()
        Me.txt_year = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.button_create = New System.Windows.Forms.Button()
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
        Me.top_table_day_form.Controls.Add(Me.Button1, 0, 1)
        Me.top_table_day_form.Controls.Add(Me.txt_total_amount, 6, 1)
        Me.top_table_day_form.Controls.Add(Me.Label9, 6, 0)
        Me.top_table_day_form.Controls.Add(Me.txt_month, 1, 1)
        Me.top_table_day_form.Controls.Add(Me.txt_year, 1, 0)
        Me.top_table_day_form.Controls.Add(Me.button_create, 2, 1)
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
        'txt_total_amount
        '
        Me.txt_total_amount.AutoSize = True
        Me.txt_total_amount.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_total_amount.Font = New System.Drawing.Font("Cascadia Mono", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_total_amount.Location = New System.Drawing.Point(962, 43)
        Me.txt_total_amount.Name = "txt_total_amount"
        Me.txt_total_amount.Size = New System.Drawing.Size(158, 43)
        Me.txt_total_amount.TabIndex = 18
        Me.txt_total_amount.Text = "Amount"
        Me.txt_total_amount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        'txt_month
        '
        Me.txt_month.AutoSize = True
        Me.txt_month.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_month.Font = New System.Drawing.Font("Cascadia Mono", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_month.Location = New System.Drawing.Point(85, 43)
        Me.txt_month.Name = "txt_month"
        Me.txt_month.Size = New System.Drawing.Size(94, 43)
        Me.txt_month.TabIndex = 1
        Me.txt_month.Text = "Sep"
        Me.txt_month.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txt_year
        '
        Me.txt_year.AutoSize = True
        Me.txt_year.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_year.Font = New System.Drawing.Font("Cascadia Mono", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_year.Location = New System.Drawing.Point(85, 0)
        Me.txt_year.Name = "txt_year"
        Me.txt_year.Size = New System.Drawing.Size(94, 43)
        Me.txt_year.TabIndex = 0
        Me.txt_year.Text = "2024"
        Me.txt_year.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Button1
        '
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Image = Global.expense_Trackie.My.Resources.Resources.icons8_back_16
        Me.Button1.Location = New System.Drawing.Point(32, 43)
        Me.Button1.Margin = New System.Windows.Forms.Padding(0)
        Me.Button1.Name = "Button1"
        Me.Button1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Button1.Size = New System.Drawing.Size(50, 43)
        Me.Button1.TabIndex = 20
        Me.Button1.UseVisualStyleBackColor = True
        '
        'button_create
        '
        Me.button_create.Dock = System.Windows.Forms.DockStyle.Left
        Me.button_create.FlatAppearance.BorderSize = 0
        Me.button_create.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.button_create.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button_create.Image = Global.expense_Trackie.My.Resources.Resources.icons8_forward_16
        Me.button_create.Location = New System.Drawing.Point(182, 43)
        Me.button_create.Margin = New System.Windows.Forms.Padding(0)
        Me.button_create.Name = "button_create"
        Me.button_create.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.button_create.Size = New System.Drawing.Size(50, 43)
        Me.button_create.TabIndex = 19
        Me.button_create.UseVisualStyleBackColor = True
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
    Friend WithEvents Button1 As Button
    Friend WithEvents txt_total_amount As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txt_month As Label
    Friend WithEvents txt_year As Label
    Friend WithEvents button_create As Button
End Class
