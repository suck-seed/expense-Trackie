<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class exportView
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
        Me.timer_reset_image = New System.Windows.Forms.Timer(Me.components)
        Me.table_predefined = New System.Windows.Forms.TableLayoutPanel()
        Me.radio_30days = New System.Windows.Forms.RadioButton()
        Me.radio_7days = New System.Windows.Forms.RadioButton()
        Me.radio_14days = New System.Windows.Forms.RadioButton()
        Me.panel_filter = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.flowCategories = New System.Windows.Forms.FlowLayoutPanel()
        Me.TableLayoutPanel8 = New System.Windows.Forms.TableLayoutPanel()
        Me.lbl_category = New System.Windows.Forms.Label()
        Me.tableLayoutCategorySelector = New System.Windows.Forms.TableLayoutPanel()
        Me.check_all = New System.Windows.Forms.CheckBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.panel_calender = New System.Windows.Forms.Panel()
        Me.exportPanelDays = New System.Windows.Forms.FlowLayoutPanel()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.table_calander_control = New System.Windows.Forms.TableLayoutPanel()
        Me.lbl_year = New System.Windows.Forms.Label()
        Me.month_next = New System.Windows.Forms.Button()
        Me.month_previous = New System.Windows.Forms.Button()
        Me.lbl_month = New System.Windows.Forms.Label()
        Me.panel_custom_dates = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.startDatePicker = New System.Windows.Forms.DateTimePicker()
        Me.EndDatePicker = New System.Windows.Forms.DateTimePicker()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.panel_export_main = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.lbl_info = New System.Windows.Forms.Label()
        Me.dataGrid = New System.Windows.Forms.DataGridView()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.btn_xml = New System.Windows.Forms.Button()
        Me.btn_csv = New System.Windows.Forms.Button()
        Me.btn_excel = New System.Windows.Forms.Button()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.btn_fiterShow = New System.Windows.Forms.Button()
        Me.table_predefined.SuspendLayout()
        Me.panel_filter.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.TableLayoutPanel8.SuspendLayout()
        Me.tableLayoutCategorySelector.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.panel_calender.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.table_calander_control.SuspendLayout()
        Me.panel_custom_dates.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.panel_export_main.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.dataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'timer_reset_image
        '
        Me.timer_reset_image.Interval = 120
        '
        'table_predefined
        '
        Me.table_predefined.ColumnCount = 3
        Me.table_predefined.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.table_predefined.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.table_predefined.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.table_predefined.Controls.Add(Me.radio_30days, 2, 0)
        Me.table_predefined.Controls.Add(Me.radio_7days, 0, 0)
        Me.table_predefined.Controls.Add(Me.radio_14days, 1, 0)
        Me.table_predefined.Dock = System.Windows.Forms.DockStyle.Fill
        Me.table_predefined.Location = New System.Drawing.Point(0, 0)
        Me.table_predefined.Margin = New System.Windows.Forms.Padding(0)
        Me.table_predefined.Name = "table_predefined"
        Me.table_predefined.RowCount = 1
        Me.table_predefined.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.table_predefined.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 66.0!))
        Me.table_predefined.Size = New System.Drawing.Size(290, 66)
        Me.table_predefined.TabIndex = 0
        '
        'radio_30days
        '
        Me.radio_30days.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.radio_30days.Appearance = System.Windows.Forms.Appearance.Button
        Me.radio_30days.BackColor = System.Drawing.Color.DimGray
        Me.radio_30days.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.radio_30days.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.radio_30days.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.radio_30days.Font = New System.Drawing.Font("IBM Plex Mono", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radio_30days.Location = New System.Drawing.Point(196, 15)
        Me.radio_30days.Name = "radio_30days"
        Me.radio_30days.Size = New System.Drawing.Size(90, 36)
        Me.radio_30days.TabIndex = 2
        Me.radio_30days.TabStop = True
        Me.radio_30days.Text = "30 days"
        Me.radio_30days.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.radio_30days.UseVisualStyleBackColor = False
        '
        'radio_7days
        '
        Me.radio_7days.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.radio_7days.Appearance = System.Windows.Forms.Appearance.Button
        Me.radio_7days.BackColor = System.Drawing.Color.DimGray
        Me.radio_7days.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.radio_7days.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.radio_7days.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.radio_7days.Font = New System.Drawing.Font("IBM Plex Mono", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radio_7days.Location = New System.Drawing.Point(3, 15)
        Me.radio_7days.Name = "radio_7days"
        Me.radio_7days.Size = New System.Drawing.Size(89, 36)
        Me.radio_7days.TabIndex = 0
        Me.radio_7days.TabStop = True
        Me.radio_7days.Text = "7 days"
        Me.radio_7days.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.radio_7days.UseVisualStyleBackColor = False
        '
        'radio_14days
        '
        Me.radio_14days.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.radio_14days.Appearance = System.Windows.Forms.Appearance.Button
        Me.radio_14days.BackColor = System.Drawing.Color.DimGray
        Me.radio_14days.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.radio_14days.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.radio_14days.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.radio_14days.Font = New System.Drawing.Font("IBM Plex Mono", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radio_14days.Location = New System.Drawing.Point(99, 15)
        Me.radio_14days.Name = "radio_14days"
        Me.radio_14days.Size = New System.Drawing.Size(89, 36)
        Me.radio_14days.TabIndex = 1
        Me.radio_14days.TabStop = True
        Me.radio_14days.Text = "14 days"
        Me.radio_14days.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.radio_14days.UseVisualStyleBackColor = False
        '
        'panel_filter
        '
        Me.panel_filter.BackColor = System.Drawing.Color.Transparent
        Me.panel_filter.Controls.Add(Me.Panel4)
        Me.panel_filter.Controls.Add(Me.Panel3)
        Me.panel_filter.Controls.Add(Me.panel_custom_dates)
        Me.panel_filter.Controls.Add(Me.Panel2)
        Me.panel_filter.Controls.Add(Me.Panel1)
        Me.panel_filter.Dock = System.Windows.Forms.DockStyle.Left
        Me.panel_filter.Location = New System.Drawing.Point(0, 0)
        Me.panel_filter.Margin = New System.Windows.Forms.Padding(0)
        Me.panel_filter.Name = "panel_filter"
        Me.panel_filter.Size = New System.Drawing.Size(292, 892)
        Me.panel_filter.TabIndex = 3
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.flowCategories)
        Me.Panel4.Controls.Add(Me.TableLayoutPanel8)
        Me.Panel4.Controls.Add(Me.tableLayoutCategorySelector)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(0, 528)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(292, 364)
        Me.Panel4.TabIndex = 9
        '
        'flowCategories
        '
        Me.flowCategories.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.flowCategories.AutoScroll = True
        Me.flowCategories.Location = New System.Drawing.Point(21, 90)
        Me.flowCategories.Margin = New System.Windows.Forms.Padding(0)
        Me.flowCategories.Name = "flowCategories"
        Me.flowCategories.Size = New System.Drawing.Size(247, 255)
        Me.flowCategories.TabIndex = 14
        '
        'TableLayoutPanel8
        '
        Me.TableLayoutPanel8.ColumnCount = 4
        Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.5446!))
        Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.96244!))
        Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.49296!))
        Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 34.0!))
        Me.TableLayoutPanel8.Controls.Add(Me.lbl_category, 0, 0)
        Me.TableLayoutPanel8.Location = New System.Drawing.Point(21, 3)
        Me.TableLayoutPanel8.Name = "TableLayoutPanel8"
        Me.TableLayoutPanel8.RowCount = 1
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel8.Size = New System.Drawing.Size(247, 45)
        Me.TableLayoutPanel8.TabIndex = 8
        '
        'lbl_category
        '
        Me.lbl_category.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_category.Font = New System.Drawing.Font("IBM Plex Mono SemiBold", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_category.Location = New System.Drawing.Point(3, 0)
        Me.lbl_category.Name = "lbl_category"
        Me.lbl_category.Size = New System.Drawing.Size(140, 45)
        Me.lbl_category.TabIndex = 0
        Me.lbl_category.Text = "Category"
        Me.lbl_category.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tableLayoutCategorySelector
        '
        Me.tableLayoutCategorySelector.AutoScroll = True
        Me.tableLayoutCategorySelector.BackColor = System.Drawing.Color.Transparent
        Me.tableLayoutCategorySelector.ColumnCount = 1
        Me.tableLayoutCategorySelector.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tableLayoutCategorySelector.Controls.Add(Me.check_all, 0, 0)
        Me.tableLayoutCategorySelector.Location = New System.Drawing.Point(21, 51)
        Me.tableLayoutCategorySelector.Margin = New System.Windows.Forms.Padding(0)
        Me.tableLayoutCategorySelector.MaximumSize = New System.Drawing.Size(247, 650)
        Me.tableLayoutCategorySelector.Name = "tableLayoutCategorySelector"
        Me.tableLayoutCategorySelector.RowCount = 1
        Me.tableLayoutCategorySelector.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tableLayoutCategorySelector.Size = New System.Drawing.Size(244, 39)
        Me.tableLayoutCategorySelector.TabIndex = 13
        '
        'check_all
        '
        Me.check_all.Appearance = System.Windows.Forms.Appearance.Button
        Me.check_all.BackColor = System.Drawing.Color.GhostWhite
        Me.check_all.Dock = System.Windows.Forms.DockStyle.Left
        Me.check_all.Font = New System.Drawing.Font("IBM Plex Mono", 10.0!)
        Me.check_all.Location = New System.Drawing.Point(6, 5)
        Me.check_all.Margin = New System.Windows.Forms.Padding(6, 5, 8, 5)
        Me.check_all.Name = "check_all"
        Me.check_all.Size = New System.Drawing.Size(52, 29)
        Me.check_all.TabIndex = 0
        Me.check_all.Text = "All"
        Me.check_all.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.check_all.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.panel_calender)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 194)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(292, 334)
        Me.Panel3.TabIndex = 8
        '
        'panel_calender
        '
        Me.panel_calender.Controls.Add(Me.exportPanelDays)
        Me.panel_calender.Controls.Add(Me.TableLayoutPanel3)
        Me.panel_calender.Controls.Add(Me.table_calander_control)
        Me.panel_calender.Location = New System.Drawing.Point(21, 17)
        Me.panel_calender.Name = "panel_calender"
        Me.panel_calender.Size = New System.Drawing.Size(247, 295)
        Me.panel_calender.TabIndex = 4
        '
        'exportPanelDays
        '
        Me.exportPanelDays.Location = New System.Drawing.Point(0, 79)
        Me.exportPanelDays.Margin = New System.Windows.Forms.Padding(0)
        Me.exportPanelDays.Name = "exportPanelDays"
        Me.exportPanelDays.Size = New System.Drawing.Size(247, 216)
        Me.exportPanelDays.TabIndex = 31
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
        Me.TableLayoutPanel3.Controls.Add(Me.Label8, 0, 0)
        Me.TableLayoutPanel3.Font = New System.Drawing.Font("IBM Plex Mono", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(0, 45)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(247, 31)
        Me.TableLayoutPanel3.TabIndex = 30
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
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label8.Font = New System.Drawing.Font("IBM Plex Mono", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(73, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(29, 31)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "T"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.table_calander_control.TabIndex = 29
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
        'panel_custom_dates
        '
        Me.panel_custom_dates.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panel_custom_dates.Controls.Add(Me.TableLayoutPanel5)
        Me.panel_custom_dates.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel_custom_dates.Location = New System.Drawing.Point(0, 119)
        Me.panel_custom_dates.Margin = New System.Windows.Forms.Padding(0)
        Me.panel_custom_dates.Name = "panel_custom_dates"
        Me.panel_custom_dates.Size = New System.Drawing.Size(292, 75)
        Me.panel_custom_dates.TabIndex = 7
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.ColumnCount = 3
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.25605!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.74394!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 14.0!))
        Me.TableLayoutPanel5.Controls.Add(Me.Label10, 0, 1)
        Me.TableLayoutPanel5.Controls.Add(Me.Label9, 0, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.startDatePicker, 1, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.EndDatePicker, 1, 1)
        Me.TableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel5.Margin = New System.Windows.Forms.Padding(0, 4, 0, 0)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 2
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(290, 73)
        Me.TableLayoutPanel5.TabIndex = 5
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label10.Font = New System.Drawing.Font("IBM Plex Mono", 10.0!)
        Me.Label10.Location = New System.Drawing.Point(3, 36)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(88, 37)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "End Date"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label9.Font = New System.Drawing.Font("IBM Plex Mono", 10.0!)
        Me.Label9.Location = New System.Drawing.Point(3, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(88, 36)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "Start Date"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'startDatePicker
        '
        Me.startDatePicker.Dock = System.Windows.Forms.DockStyle.Fill
        Me.startDatePicker.Location = New System.Drawing.Point(97, 3)
        Me.startDatePicker.Name = "startDatePicker"
        Me.startDatePicker.Size = New System.Drawing.Size(175, 20)
        Me.startDatePicker.TabIndex = 3
        '
        'EndDatePicker
        '
        Me.EndDatePicker.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EndDatePicker.Location = New System.Drawing.Point(97, 39)
        Me.EndDatePicker.Name = "EndDatePicker"
        Me.EndDatePicker.Size = New System.Drawing.Size(175, 20)
        Me.EndDatePicker.TabIndex = 4
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.table_predefined)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 51)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(292, 68)
        Me.Panel2.TabIndex = 6
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(292, 51)
        Me.Panel1.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("IBM Plex Mono", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(90, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 28)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Filter "
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'panel_export_main
        '
        Me.panel_export_main.BackColor = System.Drawing.Color.Transparent
        Me.panel_export_main.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panel_export_main.Controls.Add(Me.TableLayoutPanel2)
        Me.panel_export_main.Controls.Add(Me.TableLayoutPanel1)
        Me.panel_export_main.Controls.Add(Me.TableLayoutPanel4)
        Me.panel_export_main.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel_export_main.Location = New System.Drawing.Point(292, 0)
        Me.panel_export_main.Name = "panel_export_main"
        Me.panel_export_main.Size = New System.Drawing.Size(921, 892)
        Me.panel_export_main.TabIndex = 4
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.lbl_info, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.dataGrid, 0, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 50)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(919, 740)
        Me.TableLayoutPanel2.TabIndex = 4
        '
        'lbl_info
        '
        Me.lbl_info.AutoSize = True
        Me.lbl_info.BackColor = System.Drawing.Color.Transparent
        Me.lbl_info.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_info.Font = New System.Drawing.Font("IBM Plex Mono", 9.0!)
        Me.lbl_info.ForeColor = System.Drawing.Color.Red
        Me.lbl_info.Location = New System.Drawing.Point(3, 720)
        Me.lbl_info.Name = "lbl_info"
        Me.lbl_info.Size = New System.Drawing.Size(913, 20)
        Me.lbl_info.TabIndex = 83
        Me.lbl_info.Text = "error"
        Me.lbl_info.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dataGrid
        '
        Me.dataGrid.AllowUserToOrderColumns = True
        Me.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dataGrid.Location = New System.Drawing.Point(40, 40)
        Me.dataGrid.Margin = New System.Windows.Forms.Padding(40)
        Me.dataGrid.Name = "dataGrid"
        Me.dataGrid.Size = New System.Drawing.Size(839, 640)
        Me.dataGrid.TabIndex = 1
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.Controls.Add(Me.btn_xml, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btn_csv, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btn_excel, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 790)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(919, 100)
        Me.TableLayoutPanel1.TabIndex = 3
        '
        'btn_xml
        '
        Me.btn_xml.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_xml.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.btn_xml.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btn_xml.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btn_xml.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_xml.Image = Global.expense_Trackie.My.Resources.Resources.xml
        Me.btn_xml.Location = New System.Drawing.Point(730, 22)
        Me.btn_xml.Margin = New System.Windows.Forms.Padding(0, 0, 0, 2)
        Me.btn_xml.Name = "btn_xml"
        Me.btn_xml.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btn_xml.Size = New System.Drawing.Size(71, 54)
        Me.btn_xml.TabIndex = 4
        Me.btn_xml.UseVisualStyleBackColor = True
        '
        'btn_csv
        '
        Me.btn_csv.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_csv.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.btn_csv.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btn_csv.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btn_csv.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_csv.Image = Global.expense_Trackie.My.Resources.Resources.csv
        Me.btn_csv.Location = New System.Drawing.Point(423, 22)
        Me.btn_csv.Margin = New System.Windows.Forms.Padding(0, 0, 0, 2)
        Me.btn_csv.Name = "btn_csv"
        Me.btn_csv.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btn_csv.Size = New System.Drawing.Size(71, 54)
        Me.btn_csv.TabIndex = 3
        Me.btn_csv.UseVisualStyleBackColor = True
        '
        'btn_excel
        '
        Me.btn_excel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_excel.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.btn_excel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btn_excel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btn_excel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_excel.Image = Global.expense_Trackie.My.Resources.Resources.excel
        Me.btn_excel.Location = New System.Drawing.Point(117, 22)
        Me.btn_excel.Margin = New System.Windows.Forms.Padding(0, 0, 0, 2)
        Me.btn_excel.Name = "btn_excel"
        Me.btn_excel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btn_excel.Size = New System.Drawing.Size(71, 54)
        Me.btn_excel.TabIndex = 2
        Me.btn_excel.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.TableLayoutPanel4.ColumnCount = 1
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.btn_fiterShow, 0, 0)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel4.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 1
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(919, 50)
        Me.TableLayoutPanel4.TabIndex = 1
        '
        'btn_fiterShow
        '
        Me.btn_fiterShow.Dock = System.Windows.Forms.DockStyle.Left
        Me.btn_fiterShow.FlatAppearance.BorderSize = 0
        Me.btn_fiterShow.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.btn_fiterShow.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btn_fiterShow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btn_fiterShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_fiterShow.Image = Global.expense_Trackie.My.Resources.Resources.exportFilter
        Me.btn_fiterShow.Location = New System.Drawing.Point(1, 1)
        Me.btn_fiterShow.Margin = New System.Windows.Forms.Padding(0, 0, 0, 2)
        Me.btn_fiterShow.Name = "btn_fiterShow"
        Me.btn_fiterShow.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btn_fiterShow.Size = New System.Drawing.Size(50, 46)
        Me.btn_fiterShow.TabIndex = 1
        Me.btn_fiterShow.UseVisualStyleBackColor = True
        '
        'exportView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Controls.Add(Me.panel_export_main)
        Me.Controls.Add(Me.panel_filter)
        Me.DoubleBuffered = True
        Me.Margin = New System.Windows.Forms.Padding(0)
        Me.Name = "exportView"
        Me.Size = New System.Drawing.Size(1213, 892)
        Me.table_predefined.ResumeLayout(False)
        Me.panel_filter.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.TableLayoutPanel8.ResumeLayout(False)
        Me.tableLayoutCategorySelector.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.panel_calender.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.table_calander_control.ResumeLayout(False)
        Me.table_calander_control.PerformLayout()
        Me.panel_custom_dates.ResumeLayout(False)
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.TableLayoutPanel5.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.panel_export_main.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        CType(Me.dataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents timer_reset_image As Timer
    Friend WithEvents table_predefined As TableLayoutPanel
    Friend WithEvents radio_30days As RadioButton
    Friend WithEvents radio_14days As RadioButton
    Friend WithEvents radio_7days As RadioButton
    Friend WithEvents panel_filter As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents panel_calender As Panel
    Friend WithEvents exportPanelDays As FlowLayoutPanel
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents table_calander_control As TableLayoutPanel
    Friend WithEvents lbl_year As Label
    Friend WithEvents month_next As Button
    Friend WithEvents month_previous As Button
    Friend WithEvents lbl_month As Label
    Friend WithEvents panel_export_main As Panel
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents btn_fiterShow As Button
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents startDatePicker As DateTimePicker
    Friend WithEvents EndDatePicker As DateTimePicker
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents panel_custom_dates As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents TableLayoutPanel8 As TableLayoutPanel
    Friend WithEvents lbl_category As Label
    Friend WithEvents flowCategories As FlowLayoutPanel
    Friend WithEvents tableLayoutCategorySelector As TableLayoutPanel
    Friend WithEvents check_all As CheckBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Public WithEvents dataGrid As DataGridView
    Friend WithEvents lbl_info As Label
    Friend WithEvents btn_excel As Button
    Friend WithEvents btn_xml As Button
    Friend WithEvents btn_csv As Button
End Class
