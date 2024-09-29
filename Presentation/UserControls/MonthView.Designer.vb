Namespace Presentation
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class MonthView
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
            Me.lbl_year = New System.Windows.Forms.Label()
            Me.btn_next = New System.Windows.Forms.Button()
            Me.btn_previous = New System.Windows.Forms.Button()
            Me.lbl_month = New System.Windows.Forms.Label()
            Me.lbl_total_amount = New System.Windows.Forms.Label()
            Me.Label9 = New System.Windows.Forms.Label()
            Me.btn_refresh = New System.Windows.Forms.Button()
            Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
            Me.Label7 = New System.Windows.Forms.Label()
            Me.Label6 = New System.Windows.Forms.Label()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.lbl_size = New System.Windows.Forms.Label()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.tpanel_day = New System.Windows.Forms.TableLayoutPanel()
            Me.timer_reset_image = New System.Windows.Forms.Timer(Me.components)
            Me.generalTable.SuspendLayout()
            Me.TableLayoutPanel3.SuspendLayout()
            Me.SuspendLayout()
            '
            'generalTable
            '
            Me.generalTable.BackColor = System.Drawing.Color.Transparent
            Me.generalTable.ColumnCount = 7
            Me.generalTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.54534!))
            Me.generalTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.788068!))
            Me.generalTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.60463!))
            Me.generalTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.94539!))
            Me.generalTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.86229!))
            Me.generalTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.67147!))
            Me.generalTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.510351!))
            Me.generalTable.Controls.Add(Me.lbl_year, 1, 0)
            Me.generalTable.Controls.Add(Me.btn_next, 2, 1)
            Me.generalTable.Controls.Add(Me.btn_previous, 0, 1)
            Me.generalTable.Controls.Add(Me.lbl_month, 1, 1)
            Me.generalTable.Controls.Add(Me.lbl_total_amount, 5, 1)
            Me.generalTable.Controls.Add(Me.Label9, 5, 0)
            Me.generalTable.Controls.Add(Me.btn_refresh, 4, 0)
            Me.generalTable.Dock = System.Windows.Forms.DockStyle.Top
            Me.generalTable.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize
            Me.generalTable.Location = New System.Drawing.Point(0, 0)
            Me.generalTable.Name = "generalTable"
            Me.generalTable.RowCount = 2
            Me.generalTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
            Me.generalTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
            Me.generalTable.Size = New System.Drawing.Size(1121, 86)
            Me.generalTable.TabIndex = 7
            '
            'lbl_year
            '
            Me.lbl_year.AutoSize = True
            Me.lbl_year.Dock = System.Windows.Forms.DockStyle.Fill
            Me.lbl_year.Font = New System.Drawing.Font("IBM Plex Mono", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lbl_year.Location = New System.Drawing.Point(121, 0)
            Me.lbl_year.Name = "lbl_year"
            Me.lbl_year.Size = New System.Drawing.Size(58, 43)
            Me.lbl_year.TabIndex = 0
            Me.lbl_year.Text = "2024"
            Me.lbl_year.TextAlign = System.Drawing.ContentAlignment.BottomCenter
            '
            'btn_next
            '
            Me.btn_next.Dock = System.Windows.Forms.DockStyle.Left
            Me.btn_next.FlatAppearance.BorderSize = 0
            Me.btn_next.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
            Me.btn_next.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
            Me.btn_next.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btn_next.Image = Global.expense_Trackie.My.Resources.Resources.right
            Me.btn_next.Location = New System.Drawing.Point(182, 43)
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
            Me.btn_previous.Location = New System.Drawing.Point(68, 43)
            Me.btn_previous.Margin = New System.Windows.Forms.Padding(0)
            Me.btn_previous.Name = "btn_previous"
            Me.btn_previous.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.btn_previous.Size = New System.Drawing.Size(50, 43)
            Me.btn_previous.TabIndex = 20
            Me.btn_previous.UseVisualStyleBackColor = True
            '
            'lbl_month
            '
            Me.lbl_month.AutoSize = True
            Me.lbl_month.Dock = System.Windows.Forms.DockStyle.Fill
            Me.lbl_month.Font = New System.Drawing.Font("IBM Plex Mono", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lbl_month.Location = New System.Drawing.Point(121, 43)
            Me.lbl_month.Name = "lbl_month"
            Me.lbl_month.Size = New System.Drawing.Size(58, 43)
            Me.lbl_month.TabIndex = 1
            Me.lbl_month.Text = "Sep"
            Me.lbl_month.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'lbl_total_amount
            '
            Me.lbl_total_amount.AutoSize = True
            Me.lbl_total_amount.Dock = System.Windows.Forms.DockStyle.Fill
            Me.lbl_total_amount.Font = New System.Drawing.Font("IBM Plex Mono SemiBold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lbl_total_amount.Location = New System.Drawing.Point(917, 43)
            Me.lbl_total_amount.Name = "lbl_total_amount"
            Me.lbl_total_amount.Size = New System.Drawing.Size(158, 43)
            Me.lbl_total_amount.TabIndex = 18
            Me.lbl_total_amount.Text = "Amount"
            Me.lbl_total_amount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'Label9
            '
            Me.Label9.AutoSize = True
            Me.Label9.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Label9.Font = New System.Drawing.Font("IBM Plex Mono", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label9.Location = New System.Drawing.Point(917, 0)
            Me.Label9.Name = "Label9"
            Me.Label9.Size = New System.Drawing.Size(158, 43)
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
            Me.btn_refresh.Location = New System.Drawing.Point(661, 3)
            Me.btn_refresh.Name = "btn_refresh"
            Me.btn_refresh.Size = New System.Drawing.Size(75, 23)
            Me.btn_refresh.TabIndex = 21
            Me.btn_refresh.UseVisualStyleBackColor = True
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
            Me.TableLayoutPanel3.Controls.Add(Me.lbl_size, 0, 0)
            Me.TableLayoutPanel3.Controls.Add(Me.Label3, 0, 0)
            Me.TableLayoutPanel3.Controls.Add(Me.Label2, 0, 0)
            Me.TableLayoutPanel3.Controls.Add(Me.Label1, 0, 0)
            Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top
            Me.TableLayoutPanel3.Location = New System.Drawing.Point(0, 86)
            Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
            Me.TableLayoutPanel3.RowCount = 1
            Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
            Me.TableLayoutPanel3.Size = New System.Drawing.Size(1121, 31)
            Me.TableLayoutPanel3.TabIndex = 28
            '
            'Label7
            '
            Me.Label7.AutoSize = True
            Me.Label7.BackColor = System.Drawing.Color.Transparent
            Me.Label7.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Label7.Font = New System.Drawing.Font("IBM Plex Mono", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label7.Location = New System.Drawing.Point(643, 0)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New System.Drawing.Size(154, 31)
            Me.Label7.TabIndex = 8
            Me.Label7.Text = "THU"
            Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'Label6
            '
            Me.Label6.AutoSize = True
            Me.Label6.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Label6.Font = New System.Drawing.Font("IBM Plex Mono", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label6.Location = New System.Drawing.Point(803, 0)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(154, 31)
            Me.Label6.TabIndex = 7
            Me.Label6.Text = "FRI"
            Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'Label5
            '
            Me.Label5.AutoSize = True
            Me.Label5.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Label5.Font = New System.Drawing.Font("IBM Plex Mono", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label5.ForeColor = System.Drawing.Color.IndianRed
            Me.Label5.Location = New System.Drawing.Point(963, 0)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(155, 31)
            Me.Label5.TabIndex = 6
            Me.Label5.Text = "SAT"
            Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'lbl_size
            '
            Me.lbl_size.AutoSize = True
            Me.lbl_size.Dock = System.Windows.Forms.DockStyle.Fill
            Me.lbl_size.Font = New System.Drawing.Font("IBM Plex Mono", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lbl_size.Location = New System.Drawing.Point(483, 0)
            Me.lbl_size.Name = "lbl_size"
            Me.lbl_size.Size = New System.Drawing.Size(154, 31)
            Me.lbl_size.TabIndex = 5
            Me.lbl_size.Text = "WED"
            Me.lbl_size.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Label3.Font = New System.Drawing.Font("IBM Plex Mono", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label3.Location = New System.Drawing.Point(3, 0)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(154, 31)
            Me.Label3.TabIndex = 4
            Me.Label3.Text = "SUN"
            Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Label2.Font = New System.Drawing.Font("IBM Plex Mono", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label2.Location = New System.Drawing.Point(163, 0)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(154, 31)
            Me.Label2.TabIndex = 3
            Me.Label2.Text = "MON"
            Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Label1.Font = New System.Drawing.Font("IBM Plex Mono", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.Location = New System.Drawing.Point(323, 0)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(154, 31)
            Me.Label1.TabIndex = 2
            Me.Label1.Text = "TUE"
            Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'tpanel_day
            '
            Me.tpanel_day.BackColor = System.Drawing.Color.Transparent
            Me.tpanel_day.ColumnCount = 7
            Me.tpanel_day.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
            Me.tpanel_day.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
            Me.tpanel_day.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
            Me.tpanel_day.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
            Me.tpanel_day.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
            Me.tpanel_day.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
            Me.tpanel_day.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
            Me.tpanel_day.Dock = System.Windows.Forms.DockStyle.Fill
            Me.tpanel_day.Location = New System.Drawing.Point(0, 117)
            Me.tpanel_day.Name = "tpanel_day"
            Me.tpanel_day.RowCount = 5
            Me.tpanel_day.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
            Me.tpanel_day.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
            Me.tpanel_day.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
            Me.tpanel_day.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
            Me.tpanel_day.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
            Me.tpanel_day.Size = New System.Drawing.Size(1121, 796)
            Me.tpanel_day.TabIndex = 29
            '
            'timer_reset_image
            '
            Me.timer_reset_image.Interval = 120
            '
            'MonthView
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.Transparent
            Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Controls.Add(Me.tpanel_day)
            Me.Controls.Add(Me.TableLayoutPanel3)
            Me.Controls.Add(Me.generalTable)
            Me.DoubleBuffered = True
            Me.Margin = New System.Windows.Forms.Padding(20)
            Me.Name = "MonthView"
            Me.Size = New System.Drawing.Size(1121, 913)
            Me.generalTable.ResumeLayout(False)
            Me.generalTable.PerformLayout()
            Me.TableLayoutPanel3.ResumeLayout(False)
            Me.TableLayoutPanel3.PerformLayout()
            Me.ResumeLayout(False)

        End Sub

        Friend WithEvents generalTable As TableLayoutPanel
        Public WithEvents lbl_year As Label
        Public WithEvents btn_next As Button
        Public WithEvents btn_previous As Button
        Public WithEvents lbl_month As Label
        Public WithEvents lbl_total_amount As Label
        Public WithEvents Label9 As Label
        Public WithEvents btn_refresh As Button
        Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
        Friend WithEvents Label7 As Label
        Friend WithEvents Label6 As Label
        Friend WithEvents Label5 As Label
        Friend WithEvents lbl_size As Label
        Friend WithEvents Label3 As Label
        Friend WithEvents Label2 As Label
        Friend WithEvents Label1 As Label
        Friend WithEvents tpanel_day As TableLayoutPanel
        Friend WithEvents timer_reset_image As Timer
    End Class
End NameSpace