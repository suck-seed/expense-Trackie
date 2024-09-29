Namespace Presentation
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class CalanderView
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
            Me.fpanel_dates = New System.Windows.Forms.FlowLayoutPanel()
            Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
            Me.Label7 = New System.Windows.Forms.Label()
            Me.Label6 = New System.Windows.Forms.Label()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.table_calander_control = New System.Windows.Forms.TableLayoutPanel()
            Me.lbl_year = New System.Windows.Forms.Label()
            Me.month_next = New System.Windows.Forms.Button()
            Me.month_previous = New System.Windows.Forms.Button()
            Me.lbl_month = New System.Windows.Forms.Label()
            Me.TableLayoutPanel3.SuspendLayout()
            Me.table_calander_control.SuspendLayout()
            Me.SuspendLayout()
            '
            'fpanel_dates
            '
            Me.fpanel_dates.BackColor = System.Drawing.Color.Transparent
            Me.fpanel_dates.Location = New System.Drawing.Point(0, 79)
            Me.fpanel_dates.Margin = New System.Windows.Forms.Padding(0)
            Me.fpanel_dates.Name = "fpanel_dates"
            Me.fpanel_dates.Size = New System.Drawing.Size(247, 216)
            Me.fpanel_dates.TabIndex = 28
            '
            'TableLayoutPanel3
            '
            Me.TableLayoutPanel3.ColumnCount = 7
            Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
            Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
            Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
            Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
            Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
            Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
            Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
            Me.TableLayoutPanel3.Controls.Add(Me.Label7, 0, 0)
            Me.TableLayoutPanel3.Controls.Add(Me.Label6, 0, 0)
            Me.TableLayoutPanel3.Controls.Add(Me.Label5, 0, 0)
            Me.TableLayoutPanel3.Controls.Add(Me.Label4, 0, 0)
            Me.TableLayoutPanel3.Controls.Add(Me.Label3, 0, 0)
            Me.TableLayoutPanel3.Controls.Add(Me.Label2, 0, 0)
            Me.TableLayoutPanel3.Controls.Add(Me.Label1, 0, 0)
            Me.TableLayoutPanel3.Font = New System.Drawing.Font("IBM Plex Mono", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.TableLayoutPanel3.Location = New System.Drawing.Point(0, 45)
            Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
            Me.TableLayoutPanel3.RowCount = 1
            Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
            Me.TableLayoutPanel3.Size = New System.Drawing.Size(247, 31)
            Me.TableLayoutPanel3.TabIndex = 27
            '
            'Label7
            '
            Me.Label7.AutoSize = True
            Me.Label7.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Label7.Font = New System.Drawing.Font("IBM Plex Mono", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label7.Location = New System.Drawing.Point(143, 0)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New System.Drawing.Size(29, 31)
            Me.Label7.TabIndex = 8
            Me.Label7.Text = "T"
            Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'Label6
            '
            Me.Label6.AutoSize = True
            Me.Label6.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Label6.Font = New System.Drawing.Font("IBM Plex Mono", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label6.Location = New System.Drawing.Point(178, 0)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(29, 31)
            Me.Label6.TabIndex = 7
            Me.Label6.Text = "F"
            Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'Label5
            '
            Me.Label5.AutoSize = True
            Me.Label5.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Label5.Font = New System.Drawing.Font("IBM Plex Mono", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label5.ForeColor = System.Drawing.Color.IndianRed
            Me.Label5.Location = New System.Drawing.Point(213, 0)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(31, 31)
            Me.Label5.TabIndex = 6
            Me.Label5.Text = "S"
            Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Label4.Font = New System.Drawing.Font("IBM Plex Mono", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label4.Location = New System.Drawing.Point(108, 0)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(29, 31)
            Me.Label4.TabIndex = 5
            Me.Label4.Text = "W"
            Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Label3.Font = New System.Drawing.Font("IBM Plex Mono", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label3.Location = New System.Drawing.Point(3, 0)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(29, 31)
            Me.Label3.TabIndex = 4
            Me.Label3.Text = "S"
            Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Label2.Font = New System.Drawing.Font("IBM Plex Mono", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label2.Location = New System.Drawing.Point(38, 0)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(29, 31)
            Me.Label2.TabIndex = 3
            Me.Label2.Text = "M"
            Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Label1.Font = New System.Drawing.Font("IBM Plex Mono", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.Location = New System.Drawing.Point(73, 0)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(29, 31)
            Me.Label1.TabIndex = 2
            Me.Label1.Text = "T"
            Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'table_calander_control
            '
            Me.table_calander_control.ColumnCount = 4
            Me.table_calander_control.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.38461!))
            Me.table_calander_control.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.29959!))
            Me.table_calander_control.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.04348!))
            Me.table_calander_control.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.04348!))
            Me.table_calander_control.Controls.Add(Me.lbl_year, 1, 0)
            Me.table_calander_control.Controls.Add(Me.month_next, 3, 0)
            Me.table_calander_control.Controls.Add(Me.month_previous, 2, 0)
            Me.table_calander_control.Controls.Add(Me.lbl_month, 0, 0)
            Me.table_calander_control.Location = New System.Drawing.Point(0, 0)
            Me.table_calander_control.Margin = New System.Windows.Forms.Padding(0)
            Me.table_calander_control.Name = "table_calander_control"
            Me.table_calander_control.RowCount = 1
            Me.table_calander_control.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
            Me.table_calander_control.Size = New System.Drawing.Size(247, 45)
            Me.table_calander_control.TabIndex = 26
            '
            'lbl_year
            '
            Me.lbl_year.AutoSize = True
            Me.lbl_year.Dock = System.Windows.Forms.DockStyle.Left
            Me.lbl_year.Font = New System.Drawing.Font("IBM Plex Mono", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lbl_year.Location = New System.Drawing.Point(41, 0)
            Me.lbl_year.Name = "lbl_year"
            Me.lbl_year.Size = New System.Drawing.Size(40, 45)
            Me.lbl_year.TabIndex = 0
            Me.lbl_year.Text = "2024"
            Me.lbl_year.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'month_next
            '
            Me.month_next.Cursor = System.Windows.Forms.Cursors.Hand
            Me.month_next.Dock = System.Windows.Forms.DockStyle.Fill
            Me.month_next.FlatAppearance.BorderSize = 0
            Me.month_next.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
            Me.month_next.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
            Me.month_next.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.month_next.Image = Global.expense_Trackie.My.Resources.Resources.nextTight
            Me.month_next.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.month_next.Location = New System.Drawing.Point(217, 3)
            Me.month_next.Name = "month_next"
            Me.month_next.Size = New System.Drawing.Size(27, 39)
            Me.month_next.TabIndex = 1
            Me.month_next.UseVisualStyleBackColor = True
            '
            'month_previous
            '
            Me.month_previous.Cursor = System.Windows.Forms.Cursors.Hand
            Me.month_previous.Dock = System.Windows.Forms.DockStyle.Fill
            Me.month_previous.FlatAppearance.BorderSize = 0
            Me.month_previous.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
            Me.month_previous.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
            Me.month_previous.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.month_previous.Image = Global.expense_Trackie.My.Resources.Resources.previousTight
            Me.month_previous.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.month_previous.Location = New System.Drawing.Point(185, 3)
            Me.month_previous.Name = "month_previous"
            Me.month_previous.Size = New System.Drawing.Size(26, 39)
            Me.month_previous.TabIndex = 0
            Me.month_previous.UseVisualStyleBackColor = True
            '
            'lbl_month
            '
            Me.lbl_month.AutoSize = True
            Me.lbl_month.Dock = System.Windows.Forms.DockStyle.Fill
            Me.lbl_month.Font = New System.Drawing.Font("IBM Plex Mono", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lbl_month.Location = New System.Drawing.Point(3, 0)
            Me.lbl_month.Name = "lbl_month"
            Me.lbl_month.Size = New System.Drawing.Size(32, 45)
            Me.lbl_month.TabIndex = 2
            Me.lbl_month.Text = "Sep"
            Me.lbl_month.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'CalanderView
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.Transparent
            Me.Controls.Add(Me.fpanel_dates)
            Me.Controls.Add(Me.TableLayoutPanel3)
            Me.Controls.Add(Me.table_calander_control)
            Me.DoubleBuffered = True
            Me.Name = "CalanderView"
            Me.Size = New System.Drawing.Size(247, 295)
            Me.TableLayoutPanel3.ResumeLayout(False)
            Me.TableLayoutPanel3.PerformLayout()
            Me.table_calander_control.ResumeLayout(False)
            Me.table_calander_control.PerformLayout()
            Me.ResumeLayout(False)

        End Sub

        Friend WithEvents fpanel_dates As FlowLayoutPanel
        Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
        Friend WithEvents Label7 As Label
        Friend WithEvents Label6 As Label
        Friend WithEvents Label5 As Label
        Friend WithEvents Label4 As Label
        Friend WithEvents Label3 As Label
        Friend WithEvents Label2 As Label
        Friend WithEvents Label1 As Label
        Friend WithEvents table_calander_control As TableLayoutPanel
        Friend WithEvents lbl_month As Label
        Friend WithEvents lbl_year As Label
        Friend WithEvents month_next As Button
        Friend WithEvents month_previous As Button
    End Class
End NameSpace