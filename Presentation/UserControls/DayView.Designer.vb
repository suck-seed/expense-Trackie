Namespace Presentation
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class DayView
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
            Me.components = New System.ComponentModel.Container()
            Me.generalTable = New System.Windows.Forms.TableLayoutPanel()
            Me.lbl_month = New System.Windows.Forms.Label()
            Me.btn_next = New System.Windows.Forms.Button()
            Me.btn_previous = New System.Windows.Forms.Button()
            Me.lbl_day = New System.Windows.Forms.Label()
            Me.lbl_total_amount = New System.Windows.Forms.Label()
            Me.Label9 = New System.Windows.Forms.Label()
            Me.btn_refresh = New System.Windows.Forms.Button()
            Me.btn_filter = New System.Windows.Forms.Button()
            Me.timer_reset_image = New System.Windows.Forms.Timer(Me.components)
            Me.panel_expense_display = New System.Windows.Forms.TableLayoutPanel()
            Me.generalTable.SuspendLayout()
            Me.SuspendLayout()
            '
            'generalTable
            '
            Me.generalTable.BackColor = System.Drawing.Color.Transparent
            Me.generalTable.ColumnCount = 7
            Me.generalTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.54534!))
            Me.generalTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.178514!))
            Me.generalTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.90552!))
            Me.generalTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.94539!))
            Me.generalTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.86229!))
            Me.generalTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.67147!))
            Me.generalTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.510351!))
            Me.generalTable.Controls.Add(Me.lbl_month, 1, 0)
            Me.generalTable.Controls.Add(Me.btn_next, 2, 1)
            Me.generalTable.Controls.Add(Me.btn_previous, 0, 1)
            Me.generalTable.Controls.Add(Me.lbl_day, 1, 1)
            Me.generalTable.Controls.Add(Me.lbl_total_amount, 5, 1)
            Me.generalTable.Controls.Add(Me.Label9, 5, 0)
            Me.generalTable.Controls.Add(Me.btn_refresh, 0, 0)
            Me.generalTable.Controls.Add(Me.btn_filter, 4, 1)
            Me.generalTable.Dock = System.Windows.Forms.DockStyle.Top
            Me.generalTable.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize
            Me.generalTable.Location = New System.Drawing.Point(0, 0)
            Me.generalTable.Name = "generalTable"
            Me.generalTable.RowCount = 2
            Me.generalTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
            Me.generalTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
            Me.generalTable.Size = New System.Drawing.Size(1109, 86)
            Me.generalTable.TabIndex = 6
            '
            'lbl_month
            '
            Me.lbl_month.AutoSize = True
            Me.lbl_month.Dock = System.Windows.Forms.DockStyle.Fill
            Me.lbl_month.Font = New System.Drawing.Font("IBM Plex Mono", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lbl_month.Location = New System.Drawing.Point(119, 0)
            Me.lbl_month.Name = "lbl_month"
            Me.lbl_month.Size = New System.Drawing.Size(51, 43)
            Me.lbl_month.TabIndex = 0
            Me.lbl_month.Text = "Sep"
            Me.lbl_month.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            '
            'btn_next
            '
            Me.btn_next.Dock = System.Windows.Forms.DockStyle.Left
            Me.btn_next.FlatAppearance.BorderSize = 0
            Me.btn_next.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
            Me.btn_next.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
            Me.btn_next.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btn_next.Image = Global.expense_Trackie.My.Resources.Resources.right
            Me.btn_next.Location = New System.Drawing.Point(173, 43)
            Me.btn_next.Margin = New System.Windows.Forms.Padding(0)
            Me.btn_next.Name = "btn_next"
            Me.btn_next.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.btn_next.Size = New System.Drawing.Size(50, 43)
            Me.btn_next.TabIndex = 19
            Me.btn_next.UseVisualStyleBackColor = True
            '
            'btn_previous
            '
            Me.btn_previous.Dock = System.Windows.Forms.DockStyle.Right
            Me.btn_previous.FlatAppearance.BorderSize = 0
            Me.btn_previous.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
            Me.btn_previous.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
            Me.btn_previous.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btn_previous.Image = Global.expense_Trackie.My.Resources.Resources.left
            Me.btn_previous.Location = New System.Drawing.Point(66, 43)
            Me.btn_previous.Margin = New System.Windows.Forms.Padding(0)
            Me.btn_previous.Name = "btn_previous"
            Me.btn_previous.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.btn_previous.Size = New System.Drawing.Size(50, 43)
            Me.btn_previous.TabIndex = 20
            Me.btn_previous.UseVisualStyleBackColor = True
            '
            'lbl_day
            '
            Me.lbl_day.AutoSize = True
            Me.lbl_day.Dock = System.Windows.Forms.DockStyle.Fill
            Me.lbl_day.Font = New System.Drawing.Font("IBM Plex Mono", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lbl_day.Location = New System.Drawing.Point(119, 43)
            Me.lbl_day.Name = "lbl_day"
            Me.lbl_day.Size = New System.Drawing.Size(51, 43)
            Me.lbl_day.TabIndex = 1
            Me.lbl_day.Text = "10"
            Me.lbl_day.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'lbl_total_amount
            '
            Me.lbl_total_amount.AutoSize = True
            Me.lbl_total_amount.Dock = System.Windows.Forms.DockStyle.Fill
            Me.lbl_total_amount.Font = New System.Drawing.Font("IBM Plex Mono SemiBold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lbl_total_amount.Location = New System.Drawing.Point(909, 43)
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
            Me.Label9.Font = New System.Drawing.Font("IBM Plex Mono", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label9.Location = New System.Drawing.Point(909, 0)
            Me.Label9.Name = "Label9"
            Me.Label9.Size = New System.Drawing.Size(155, 43)
            Me.Label9.TabIndex = 7
            Me.Label9.Text = "Total"
            Me.Label9.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            '
            'btn_refresh
            '
            Me.btn_refresh.FlatAppearance.BorderSize = 0
            Me.btn_refresh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
            Me.btn_refresh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
            Me.btn_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btn_refresh.Location = New System.Drawing.Point(3, 3)
            Me.btn_refresh.Name = "btn_refresh"
            Me.btn_refresh.Size = New System.Drawing.Size(75, 23)
            Me.btn_refresh.TabIndex = 21
            Me.btn_refresh.UseVisualStyleBackColor = True
            '
            'btn_filter
            '
            Me.btn_filter.Dock = System.Windows.Forms.DockStyle.Right
            Me.btn_filter.FlatAppearance.BorderSize = 0
            Me.btn_filter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
            Me.btn_filter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
            Me.btn_filter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btn_filter.Font = New System.Drawing.Font("IBM Plex Mono", 9.0!)
            Me.btn_filter.Image = Global.expense_Trackie.My.Resources.Resources.filter
            Me.btn_filter.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.btn_filter.Location = New System.Drawing.Point(857, 46)
            Me.btn_filter.Name = "btn_filter"
            Me.btn_filter.Size = New System.Drawing.Size(46, 37)
            Me.btn_filter.TabIndex = 23
            Me.btn_filter.Text = "TIMe"
            Me.btn_filter.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.btn_filter.UseVisualStyleBackColor = True
            '
            'timer_reset_image
            '
            Me.timer_reset_image.Interval = 120
            '
            'panel_expense_display
            '
            Me.panel_expense_display.AutoScroll = True
            Me.panel_expense_display.BackColor = System.Drawing.Color.Transparent
            Me.panel_expense_display.ColumnCount = 1
            Me.panel_expense_display.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
            Me.panel_expense_display.Dock = System.Windows.Forms.DockStyle.Fill
            Me.panel_expense_display.Location = New System.Drawing.Point(0, 86)
            Me.panel_expense_display.Margin = New System.Windows.Forms.Padding(0)
            Me.panel_expense_display.Name = "panel_expense_display"
            Me.panel_expense_display.RowCount = 1
            Me.panel_expense_display.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
            Me.panel_expense_display.Size = New System.Drawing.Size(1109, 806)
            Me.panel_expense_display.TabIndex = 7
            '
            'DayView
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Controls.Add(Me.panel_expense_display)
            Me.Controls.Add(Me.generalTable)
            Me.DoubleBuffered = True
            Me.Name = "DayView"
            Me.Size = New System.Drawing.Size(1109, 892)
            Me.generalTable.ResumeLayout(False)
            Me.generalTable.PerformLayout()
            Me.ResumeLayout(False)

        End Sub

        Friend WithEvents generalTable As TableLayoutPanel
        Public WithEvents btn_previous As Button
        Public WithEvents lbl_total_amount As Label
        Public WithEvents Label9 As Label
        Public WithEvents lbl_day As Label
        Public WithEvents lbl_month As Label
        Public WithEvents btn_next As Button
        Public WithEvents btn_refresh As Button
        Friend WithEvents timer_reset_image As Timer
        Public WithEvents panel_expense_display As TableLayoutPanel
        Friend WithEvents btn_filter As Button
    End Class
End NameSpace