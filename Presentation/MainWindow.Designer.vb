﻿Namespace Presentation
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class MainWindow
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
            Me.components = New System.ComponentModel.Container()
            Me.panel_main = New System.Windows.Forms.Panel()
            Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
            Me.button_add_expense = New System.Windows.Forms.Button()
            Me.panel_sidebar = New System.Windows.Forms.Panel()
            Me.panel_calender = New System.Windows.Forms.Panel()
            Me.flowPanelCategory = New System.Windows.Forms.FlowLayoutPanel()
            Me.tableLayoutCategorySelector = New System.Windows.Forms.TableLayoutPanel()
            Me.check_all = New System.Windows.Forms.CheckBox()
            Me.TableLayoutPanel8 = New System.Windows.Forms.TableLayoutPanel()
            Me.btn_edit_category = New System.Windows.Forms.Button()
            Me.btn_delete = New System.Windows.Forms.Button()
            Me.lbl_category = New System.Windows.Forms.Label()
            Me.add_category = New System.Windows.Forms.Button()
            Me.timer_reset_image = New System.Windows.Forms.Timer(Me.components)
            Me.home_analysis_export_radio = New System.Windows.Forms.TableLayoutPanel()
            Me.radio_export = New System.Windows.Forms.RadioButton()
            Me.radio_analytical = New System.Windows.Forms.RadioButton()
            Me.radio_home = New System.Windows.Forms.RadioButton()
            Me.panel_day_month = New System.Windows.Forms.TableLayoutPanel()
            Me.radio_day_view = New System.Windows.Forms.RadioButton()
            Me.radio_month_view = New System.Windows.Forms.RadioButton()
            Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
            Me.btn_appSetting = New System.Windows.Forms.Button()
            Me.btn_close = New System.Windows.Forms.Button()
            Me.img_profile = New System.Windows.Forms.PictureBox()
            Me.btn_max = New System.Windows.Forms.Button()
            Me.btn_min = New System.Windows.Forms.Button()
            Me.panel_top = New System.Windows.Forms.Panel()
            Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
            Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
            Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
            Me.panel_year_month = New System.Windows.Forms.TableLayoutPanel()
            Me.radio_analysis_year = New System.Windows.Forms.RadioButton()
            Me.radio_analyze_monthly = New System.Windows.Forms.RadioButton()
            Me.TableLayoutPanel2.SuspendLayout()
            Me.panel_sidebar.SuspendLayout()
            Me.tableLayoutCategorySelector.SuspendLayout()
            Me.TableLayoutPanel8.SuspendLayout()
            Me.home_analysis_export_radio.SuspendLayout()
            Me.panel_day_month.SuspendLayout()
            Me.TableLayoutPanel1.SuspendLayout()
            CType(Me.img_profile, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panel_top.SuspendLayout()
            Me.TableLayoutPanel3.SuspendLayout()
            Me.panel_year_month.SuspendLayout()
            Me.SuspendLayout()
            '
            'panel_main
            '
            Me.panel_main.BackColor = System.Drawing.Color.DimGray
            Me.panel_main.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.panel_main.Dock = System.Windows.Forms.DockStyle.Fill
            Me.panel_main.Location = New System.Drawing.Point(292, 50)
            Me.panel_main.Margin = New System.Windows.Forms.Padding(0)
            Me.panel_main.Name = "panel_main"
            Me.panel_main.Size = New System.Drawing.Size(1308, 950)
            Me.panel_main.TabIndex = 2
            '
            'TableLayoutPanel2
            '
            Me.TableLayoutPanel2.ColumnCount = 3
            Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
            Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.0!))
            Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
            Me.TableLayoutPanel2.Controls.Add(Me.button_add_expense, 1, 1)
            Me.TableLayoutPanel2.Location = New System.Drawing.Point(22, 7)
            Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
            Me.TableLayoutPanel2.RowCount = 3
            Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.1579!))
            Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 73.68421!))
            Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.1579!))
            Me.TableLayoutPanel2.Size = New System.Drawing.Size(247, 86)
            Me.TableLayoutPanel2.TabIndex = 3
            '
            'button_add_expense
            '
            Me.button_add_expense.BackColor = System.Drawing.SystemColors.ButtonFace
            Me.button_add_expense.Cursor = System.Windows.Forms.Cursors.Hand
            Me.button_add_expense.FlatAppearance.BorderColor = System.Drawing.Color.Black
            Me.button_add_expense.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
            Me.button_add_expense.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
            Me.button_add_expense.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.button_add_expense.Font = New System.Drawing.Font("IBM Plex Mono SemiBold", 13.0!, System.Drawing.FontStyle.Bold)
            Me.button_add_expense.Image = Global.expense_Trackie.My.Resources.Resources.icons8_add_161
            Me.button_add_expense.Location = New System.Drawing.Point(52, 14)
            Me.button_add_expense.Name = "button_add_expense"
            Me.button_add_expense.Size = New System.Drawing.Size(142, 57)
            Me.button_add_expense.TabIndex = 8
            Me.button_add_expense.Text = "Add"
            Me.button_add_expense.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.button_add_expense.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
            Me.button_add_expense.UseVisualStyleBackColor = False
            '
            'panel_sidebar
            '
            Me.panel_sidebar.BackColor = System.Drawing.Color.Transparent
            Me.panel_sidebar.Controls.Add(Me.panel_calender)
            Me.panel_sidebar.Controls.Add(Me.flowPanelCategory)
            Me.panel_sidebar.Controls.Add(Me.tableLayoutCategorySelector)
            Me.panel_sidebar.Controls.Add(Me.TableLayoutPanel8)
            Me.panel_sidebar.Controls.Add(Me.TableLayoutPanel2)
            Me.panel_sidebar.Dock = System.Windows.Forms.DockStyle.Left
            Me.panel_sidebar.Location = New System.Drawing.Point(0, 50)
            Me.panel_sidebar.Margin = New System.Windows.Forms.Padding(0)
            Me.panel_sidebar.Name = "panel_sidebar"
            Me.panel_sidebar.Size = New System.Drawing.Size(292, 950)
            Me.panel_sidebar.TabIndex = 0
            '
            'panel_calender
            '
            Me.panel_calender.Location = New System.Drawing.Point(22, 100)
            Me.panel_calender.Name = "panel_calender"
            Me.panel_calender.Size = New System.Drawing.Size(247, 295)
            Me.panel_calender.TabIndex = 0
            '
            'flowPanelCategory
            '
            Me.flowPanelCategory.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.flowPanelCategory.AutoScroll = True
            Me.flowPanelCategory.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
            Me.flowPanelCategory.Location = New System.Drawing.Point(22, 509)
            Me.flowPanelCategory.Margin = New System.Windows.Forms.Padding(0)
            Me.flowPanelCategory.Name = "flowPanelCategory"
            Me.flowPanelCategory.Size = New System.Drawing.Size(247, 419)
            Me.flowPanelCategory.TabIndex = 12
            Me.flowPanelCategory.WrapContents = False
            '
            'tableLayoutCategorySelector
            '
            Me.tableLayoutCategorySelector.AutoScroll = True
            Me.tableLayoutCategorySelector.BackColor = System.Drawing.Color.Transparent
            Me.tableLayoutCategorySelector.ColumnCount = 1
            Me.tableLayoutCategorySelector.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
            Me.tableLayoutCategorySelector.Controls.Add(Me.check_all, 0, 0)
            Me.tableLayoutCategorySelector.Location = New System.Drawing.Point(22, 470)
            Me.tableLayoutCategorySelector.Margin = New System.Windows.Forms.Padding(0)
            Me.tableLayoutCategorySelector.MaximumSize = New System.Drawing.Size(247, 650)
            Me.tableLayoutCategorySelector.Name = "tableLayoutCategorySelector"
            Me.tableLayoutCategorySelector.RowCount = 1
            Me.tableLayoutCategorySelector.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
            Me.tableLayoutCategorySelector.Size = New System.Drawing.Size(244, 39)
            Me.tableLayoutCategorySelector.TabIndex = 8
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
            'TableLayoutPanel8
            '
            Me.TableLayoutPanel8.ColumnCount = 4
            Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.5446!))
            Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.96244!))
            Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.49296!))
            Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 41.0!))
            Me.TableLayoutPanel8.Controls.Add(Me.btn_edit_category, 0, 0)
            Me.TableLayoutPanel8.Controls.Add(Me.btn_delete, 0, 0)
            Me.TableLayoutPanel8.Controls.Add(Me.lbl_category, 0, 0)
            Me.TableLayoutPanel8.Controls.Add(Me.add_category, 3, 0)
            Me.TableLayoutPanel8.Location = New System.Drawing.Point(22, 418)
            Me.TableLayoutPanel8.Margin = New System.Windows.Forms.Padding(0)
            Me.TableLayoutPanel8.Name = "TableLayoutPanel8"
            Me.TableLayoutPanel8.RowCount = 1
            Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
            Me.TableLayoutPanel8.Size = New System.Drawing.Size(247, 45)
            Me.TableLayoutPanel8.TabIndex = 7
            '
            'btn_edit_category
            '
            Me.btn_edit_category.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btn_edit_category.Dock = System.Windows.Forms.DockStyle.Fill
            Me.btn_edit_category.FlatAppearance.BorderSize = 0
            Me.btn_edit_category.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
            Me.btn_edit_category.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
            Me.btn_edit_category.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btn_edit_category.Image = Global.expense_Trackie.My.Resources.Resources.edit
            Me.btn_edit_category.Location = New System.Drawing.Point(173, 0)
            Me.btn_edit_category.Margin = New System.Windows.Forms.Padding(0)
            Me.btn_edit_category.Name = "btn_edit_category"
            Me.btn_edit_category.Size = New System.Drawing.Size(31, 45)
            Me.btn_edit_category.TabIndex = 4
            Me.btn_edit_category.UseVisualStyleBackColor = True
            '
            'btn_delete
            '
            Me.btn_delete.Cursor = System.Windows.Forms.Cursors.Hand
            Me.btn_delete.Dock = System.Windows.Forms.DockStyle.Fill
            Me.btn_delete.FlatAppearance.BorderSize = 0
            Me.btn_delete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
            Me.btn_delete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
            Me.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btn_delete.Image = Global.expense_Trackie.My.Resources.Resources.delete3
            Me.btn_delete.Location = New System.Drawing.Point(141, 0)
            Me.btn_delete.Margin = New System.Windows.Forms.Padding(0)
            Me.btn_delete.Name = "btn_delete"
            Me.btn_delete.Size = New System.Drawing.Size(32, 45)
            Me.btn_delete.TabIndex = 3
            Me.btn_delete.UseVisualStyleBackColor = True
            '
            'lbl_category
            '
            Me.lbl_category.Dock = System.Windows.Forms.DockStyle.Fill
            Me.lbl_category.Font = New System.Drawing.Font("IBM Plex Mono SemiBold", 14.0!, System.Drawing.FontStyle.Bold)
            Me.lbl_category.Location = New System.Drawing.Point(3, 0)
            Me.lbl_category.Name = "lbl_category"
            Me.lbl_category.Size = New System.Drawing.Size(135, 45)
            Me.lbl_category.TabIndex = 0
            Me.lbl_category.Text = "My Category"
            Me.lbl_category.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'add_category
            '
            Me.add_category.Cursor = System.Windows.Forms.Cursors.Hand
            Me.add_category.Dock = System.Windows.Forms.DockStyle.Fill
            Me.add_category.FlatAppearance.BorderSize = 0
            Me.add_category.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
            Me.add_category.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
            Me.add_category.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.add_category.Image = Global.expense_Trackie.My.Resources.Resources.add
            Me.add_category.Location = New System.Drawing.Point(204, 0)
            Me.add_category.Margin = New System.Windows.Forms.Padding(0)
            Me.add_category.Name = "add_category"
            Me.add_category.Size = New System.Drawing.Size(43, 45)
            Me.add_category.TabIndex = 2
            Me.add_category.UseVisualStyleBackColor = True
            '
            'timer_reset_image
            '
            Me.timer_reset_image.Interval = 120
            '
            'home_analysis_export_radio
            '
            Me.home_analysis_export_radio.ColumnCount = 3
            Me.home_analysis_export_radio.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
            Me.home_analysis_export_radio.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
            Me.home_analysis_export_radio.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
            Me.home_analysis_export_radio.Controls.Add(Me.radio_export, 2, 0)
            Me.home_analysis_export_radio.Controls.Add(Me.radio_analytical, 1, 0)
            Me.home_analysis_export_radio.Controls.Add(Me.radio_home, 0, 0)
            Me.home_analysis_export_radio.Location = New System.Drawing.Point(45, 1)
            Me.home_analysis_export_radio.Margin = New System.Windows.Forms.Padding(0, 2, 0, 2)
            Me.home_analysis_export_radio.Name = "home_analysis_export_radio"
            Me.home_analysis_export_radio.RowCount = 1
            Me.home_analysis_export_radio.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
            Me.home_analysis_export_radio.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47.0!))
            Me.home_analysis_export_radio.Size = New System.Drawing.Size(200, 47)
            Me.home_analysis_export_radio.TabIndex = 0
            '
            'radio_export
            '
            Me.radio_export.Appearance = System.Windows.Forms.Appearance.Button
            Me.radio_export.AutoSize = True
            Me.radio_export.BackColor = System.Drawing.Color.Transparent
            Me.radio_export.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
            Me.radio_export.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter
            Me.radio_export.Cursor = System.Windows.Forms.Cursors.Hand
            Me.radio_export.Dock = System.Windows.Forms.DockStyle.Fill
            Me.radio_export.FlatAppearance.BorderSize = 0
            Me.radio_export.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
            Me.radio_export.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
            Me.radio_export.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
            Me.radio_export.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.radio_export.Image = Global.expense_Trackie.My.Resources.Resources.exportLight
            Me.radio_export.Location = New System.Drawing.Point(135, 3)
            Me.radio_export.Name = "radio_export"
            Me.radio_export.Size = New System.Drawing.Size(62, 41)
            Me.radio_export.TabIndex = 7
            Me.radio_export.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            Me.radio_export.UseVisualStyleBackColor = True
            '
            'radio_analytical
            '
            Me.radio_analytical.Appearance = System.Windows.Forms.Appearance.Button
            Me.radio_analytical.AutoSize = True
            Me.radio_analytical.BackColor = System.Drawing.Color.Transparent
            Me.radio_analytical.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
            Me.radio_analytical.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter
            Me.radio_analytical.Cursor = System.Windows.Forms.Cursors.Hand
            Me.radio_analytical.Dock = System.Windows.Forms.DockStyle.Fill
            Me.radio_analytical.FlatAppearance.BorderSize = 0
            Me.radio_analytical.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
            Me.radio_analytical.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
            Me.radio_analytical.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
            Me.radio_analytical.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.radio_analytical.Image = Global.expense_Trackie.My.Resources.Resources.barLight
            Me.radio_analytical.Location = New System.Drawing.Point(69, 3)
            Me.radio_analytical.Name = "radio_analytical"
            Me.radio_analytical.Size = New System.Drawing.Size(60, 41)
            Me.radio_analytical.TabIndex = 8
            Me.radio_analytical.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            Me.radio_analytical.UseVisualStyleBackColor = True
            '
            'radio_home
            '
            Me.radio_home.Appearance = System.Windows.Forms.Appearance.Button
            Me.radio_home.AutoSize = True
            Me.radio_home.BackColor = System.Drawing.Color.Transparent
            Me.radio_home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
            Me.radio_home.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter
            Me.radio_home.Cursor = System.Windows.Forms.Cursors.Hand
            Me.radio_home.Dock = System.Windows.Forms.DockStyle.Fill
            Me.radio_home.FlatAppearance.BorderSize = 0
            Me.radio_home.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
            Me.radio_home.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
            Me.radio_home.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
            Me.radio_home.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.radio_home.Image = Global.expense_Trackie.My.Resources.Resources.homeLight
            Me.radio_home.Location = New System.Drawing.Point(3, 3)
            Me.radio_home.Name = "radio_home"
            Me.radio_home.Size = New System.Drawing.Size(60, 41)
            Me.radio_home.TabIndex = 6
            Me.radio_home.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            Me.radio_home.UseVisualStyleBackColor = False
            '
            'panel_day_month
            '
            Me.panel_day_month.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.panel_day_month.ColumnCount = 2
            Me.panel_day_month.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
            Me.panel_day_month.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
            Me.panel_day_month.Controls.Add(Me.radio_day_view, 1, 0)
            Me.panel_day_month.Controls.Add(Me.radio_month_view, 0, 0)
            Me.panel_day_month.Location = New System.Drawing.Point(1241, 0)
            Me.panel_day_month.Margin = New System.Windows.Forms.Padding(0)
            Me.panel_day_month.Name = "panel_day_month"
            Me.panel_day_month.RowCount = 1
            Me.panel_day_month.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
            Me.panel_day_month.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
            Me.panel_day_month.Size = New System.Drawing.Size(100, 50)
            Me.panel_day_month.TabIndex = 10
            Me.panel_day_month.Visible = False
            '
            'radio_day_view
            '
            Me.radio_day_view.Appearance = System.Windows.Forms.Appearance.Button
            Me.radio_day_view.AutoSize = True
            Me.radio_day_view.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
            Me.radio_day_view.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter
            Me.radio_day_view.Cursor = System.Windows.Forms.Cursors.Hand
            Me.radio_day_view.Dock = System.Windows.Forms.DockStyle.Fill
            Me.radio_day_view.FlatAppearance.BorderSize = 0
            Me.radio_day_view.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
            Me.radio_day_view.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
            Me.radio_day_view.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
            Me.radio_day_view.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.radio_day_view.Image = Global.expense_Trackie.My.Resources.Resources.dayLight
            Me.radio_day_view.Location = New System.Drawing.Point(53, 3)
            Me.radio_day_view.Name = "radio_day_view"
            Me.radio_day_view.Size = New System.Drawing.Size(44, 44)
            Me.radio_day_view.TabIndex = 8
            Me.radio_day_view.UseVisualStyleBackColor = True
            '
            'radio_month_view
            '
            Me.radio_month_view.Appearance = System.Windows.Forms.Appearance.Button
            Me.radio_month_view.AutoSize = True
            Me.radio_month_view.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
            Me.radio_month_view.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter
            Me.radio_month_view.Cursor = System.Windows.Forms.Cursors.Hand
            Me.radio_month_view.Dock = System.Windows.Forms.DockStyle.Fill
            Me.radio_month_view.FlatAppearance.BorderSize = 0
            Me.radio_month_view.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
            Me.radio_month_view.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
            Me.radio_month_view.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
            Me.radio_month_view.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.radio_month_view.Image = Global.expense_Trackie.My.Resources.Resources.monthLight
            Me.radio_month_view.Location = New System.Drawing.Point(3, 3)
            Me.radio_month_view.Name = "radio_month_view"
            Me.radio_month_view.Size = New System.Drawing.Size(44, 44)
            Me.radio_month_view.TabIndex = 6
            Me.radio_month_view.UseVisualStyleBackColor = True
            '
            'TableLayoutPanel1
            '
            Me.TableLayoutPanel1.BackColor = System.Drawing.Color.Transparent
            Me.TableLayoutPanel1.ColumnCount = 5
            Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
            Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
            Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
            Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
            Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
            Me.TableLayoutPanel1.Controls.Add(Me.btn_appSetting, 0, 0)
            Me.TableLayoutPanel1.Controls.Add(Me.btn_close, 4, 0)
            Me.TableLayoutPanel1.Controls.Add(Me.img_profile, 1, 0)
            Me.TableLayoutPanel1.Controls.Add(Me.btn_max, 3, 0)
            Me.TableLayoutPanel1.Controls.Add(Me.btn_min, 2, 0)
            Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right
            Me.TableLayoutPanel1.Location = New System.Drawing.Point(1350, 0)
            Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(0)
            Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
            Me.TableLayoutPanel1.RowCount = 1
            Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
            Me.TableLayoutPanel1.Size = New System.Drawing.Size(250, 50)
            Me.TableLayoutPanel1.TabIndex = 15
            '
            'btn_appSetting
            '
            Me.btn_appSetting.Dock = System.Windows.Forms.DockStyle.Fill
            Me.btn_appSetting.FlatAppearance.BorderSize = 0
            Me.btn_appSetting.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
            Me.btn_appSetting.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
            Me.btn_appSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btn_appSetting.Image = Global.expense_Trackie.My.Resources.Resources.setting32
            Me.btn_appSetting.Location = New System.Drawing.Point(3, 3)
            Me.btn_appSetting.Name = "btn_appSetting"
            Me.btn_appSetting.Size = New System.Drawing.Size(44, 44)
            Me.btn_appSetting.TabIndex = 14
            Me.btn_appSetting.UseVisualStyleBackColor = True
            '
            'btn_close
            '
            Me.btn_close.FlatAppearance.BorderSize = 0
            Me.btn_close.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(35, Byte), Integer))
            Me.btn_close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(35, Byte), Integer))
            Me.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btn_close.Image = Global.expense_Trackie.My.Resources.Resources.icons8_close_16
            Me.btn_close.Location = New System.Drawing.Point(200, 0)
            Me.btn_close.Margin = New System.Windows.Forms.Padding(0)
            Me.btn_close.Name = "btn_close"
            Me.btn_close.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.btn_close.Size = New System.Drawing.Size(50, 50)
            Me.btn_close.TabIndex = 7
            Me.btn_close.UseVisualStyleBackColor = True
            '
            'img_profile
            '
            Me.img_profile.Anchor = System.Windows.Forms.AnchorStyles.None
            Me.img_profile.Image = Global.expense_Trackie.My.Resources.Resources.profileLight
            Me.img_profile.Location = New System.Drawing.Point(52, 2)
            Me.img_profile.Margin = New System.Windows.Forms.Padding(0)
            Me.img_profile.Name = "img_profile"
            Me.img_profile.Size = New System.Drawing.Size(45, 45)
            Me.img_profile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
            Me.img_profile.TabIndex = 13
            Me.img_profile.TabStop = False
            '
            'btn_max
            '
            Me.btn_max.FlatAppearance.BorderSize = 0
            Me.btn_max.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
            Me.btn_max.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
            Me.btn_max.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
            Me.btn_max.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btn_max.Image = Global.expense_Trackie.My.Resources.Resources.maximize
            Me.btn_max.Location = New System.Drawing.Point(150, 0)
            Me.btn_max.Margin = New System.Windows.Forms.Padding(0)
            Me.btn_max.Name = "btn_max"
            Me.btn_max.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.btn_max.Size = New System.Drawing.Size(50, 50)
            Me.btn_max.TabIndex = 0
            Me.btn_max.UseVisualStyleBackColor = True
            '
            'btn_min
            '
            Me.btn_min.FlatAppearance.BorderSize = 0
            Me.btn_min.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
            Me.btn_min.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
            Me.btn_min.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
            Me.btn_min.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btn_min.Image = Global.expense_Trackie.My.Resources.Resources.minimize
            Me.btn_min.Location = New System.Drawing.Point(100, 0)
            Me.btn_min.Margin = New System.Windows.Forms.Padding(0)
            Me.btn_min.Name = "btn_min"
            Me.btn_min.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.btn_min.Size = New System.Drawing.Size(50, 50)
            Me.btn_min.TabIndex = 6
            Me.btn_min.UseVisualStyleBackColor = True
            '
            'panel_top
            '
            Me.panel_top.BackColor = System.Drawing.Color.Transparent
            Me.panel_top.Controls.Add(Me.TableLayoutPanel3)
            Me.panel_top.Controls.Add(Me.panel_year_month)
            Me.panel_top.Controls.Add(Me.TableLayoutPanel1)
            Me.panel_top.Controls.Add(Me.panel_day_month)
            Me.panel_top.Controls.Add(Me.home_analysis_export_radio)
            Me.panel_top.Dock = System.Windows.Forms.DockStyle.Top
            Me.panel_top.Location = New System.Drawing.Point(0, 0)
            Me.panel_top.Margin = New System.Windows.Forms.Padding(0)
            Me.panel_top.Name = "panel_top"
            Me.panel_top.Size = New System.Drawing.Size(1600, 50)
            Me.panel_top.TabIndex = 1
            '
            'TableLayoutPanel3
            '
            Me.TableLayoutPanel3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.TableLayoutPanel3.ColumnCount = 2
            Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
            Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
            Me.TableLayoutPanel3.Controls.Add(Me.DateTimePicker1, 0, 0)
            Me.TableLayoutPanel3.Controls.Add(Me.DateTimePicker2, 1, 0)
            Me.TableLayoutPanel3.Location = New System.Drawing.Point(738, 9)
            Me.TableLayoutPanel3.Margin = New System.Windows.Forms.Padding(0)
            Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
            Me.TableLayoutPanel3.RowCount = 1
            Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
            Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41.0!))
            Me.TableLayoutPanel3.Size = New System.Drawing.Size(393, 41)
            Me.TableLayoutPanel3.TabIndex = 18
            Me.TableLayoutPanel3.Visible = False
            '
            'DateTimePicker1
            '
            Me.DateTimePicker1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.DateTimePicker1.Location = New System.Drawing.Point(3, 3)
            Me.DateTimePicker1.Name = "DateTimePicker1"
            Me.DateTimePicker1.Size = New System.Drawing.Size(190, 20)
            Me.DateTimePicker1.TabIndex = 0
            '
            'DateTimePicker2
            '
            Me.DateTimePicker2.Dock = System.Windows.Forms.DockStyle.Fill
            Me.DateTimePicker2.Location = New System.Drawing.Point(199, 3)
            Me.DateTimePicker2.Name = "DateTimePicker2"
            Me.DateTimePicker2.Size = New System.Drawing.Size(191, 20)
            Me.DateTimePicker2.TabIndex = 1
            '
            'panel_year_month
            '
            Me.panel_year_month.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.panel_year_month.ColumnCount = 2
            Me.panel_year_month.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
            Me.panel_year_month.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
            Me.panel_year_month.Controls.Add(Me.radio_analysis_year, 0, 0)
            Me.panel_year_month.Controls.Add(Me.radio_analyze_monthly, 1, 0)
            Me.panel_year_month.Location = New System.Drawing.Point(1241, 0)
            Me.panel_year_month.Margin = New System.Windows.Forms.Padding(0)
            Me.panel_year_month.Name = "panel_year_month"
            Me.panel_year_month.RowCount = 1
            Me.panel_year_month.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
            Me.panel_year_month.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
            Me.panel_year_month.Size = New System.Drawing.Size(100, 50)
            Me.panel_year_month.TabIndex = 16
            Me.panel_year_month.Visible = False
            '
            'radio_analysis_year
            '
            Me.radio_analysis_year.Appearance = System.Windows.Forms.Appearance.Button
            Me.radio_analysis_year.AutoSize = True
            Me.radio_analysis_year.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
            Me.radio_analysis_year.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter
            Me.radio_analysis_year.Cursor = System.Windows.Forms.Cursors.Hand
            Me.radio_analysis_year.Dock = System.Windows.Forms.DockStyle.Fill
            Me.radio_analysis_year.FlatAppearance.BorderSize = 0
            Me.radio_analysis_year.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
            Me.radio_analysis_year.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
            Me.radio_analysis_year.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
            Me.radio_analysis_year.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.radio_analysis_year.Image = Global.expense_Trackie.My.Resources.Resources.yearAnalysis
            Me.radio_analysis_year.Location = New System.Drawing.Point(3, 3)
            Me.radio_analysis_year.Name = "radio_analysis_year"
            Me.radio_analysis_year.Size = New System.Drawing.Size(44, 44)
            Me.radio_analysis_year.TabIndex = 7
            Me.radio_analysis_year.UseVisualStyleBackColor = True
            '
            'radio_analyze_monthly
            '
            Me.radio_analyze_monthly.Appearance = System.Windows.Forms.Appearance.Button
            Me.radio_analyze_monthly.AutoSize = True
            Me.radio_analyze_monthly.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
            Me.radio_analyze_monthly.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter
            Me.radio_analyze_monthly.Cursor = System.Windows.Forms.Cursors.Hand
            Me.radio_analyze_monthly.Dock = System.Windows.Forms.DockStyle.Fill
            Me.radio_analyze_monthly.FlatAppearance.BorderSize = 0
            Me.radio_analyze_monthly.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
            Me.radio_analyze_monthly.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
            Me.radio_analyze_monthly.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
            Me.radio_analyze_monthly.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.radio_analyze_monthly.Image = Global.expense_Trackie.My.Resources.Resources.monthLight
            Me.radio_analyze_monthly.Location = New System.Drawing.Point(53, 3)
            Me.radio_analyze_monthly.Name = "radio_analyze_monthly"
            Me.radio_analyze_monthly.Size = New System.Drawing.Size(44, 44)
            Me.radio_analyze_monthly.TabIndex = 6
            Me.radio_analyze_monthly.UseVisualStyleBackColor = True
            '
            'MainWindow
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(28, Byte), Integer))
            Me.ClientSize = New System.Drawing.Size(1600, 1000)
            Me.Controls.Add(Me.panel_main)
            Me.Controls.Add(Me.panel_sidebar)
            Me.Controls.Add(Me.panel_top)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            Me.KeyPreview = True
            Me.MinimumSize = New System.Drawing.Size(1600, 1000)
            Me.Name = "MainWindow"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "temp"
            Me.TableLayoutPanel2.ResumeLayout(False)
            Me.panel_sidebar.ResumeLayout(False)
            Me.tableLayoutCategorySelector.ResumeLayout(False)
            Me.TableLayoutPanel8.ResumeLayout(False)
            Me.home_analysis_export_radio.ResumeLayout(False)
            Me.home_analysis_export_radio.PerformLayout()
            Me.panel_day_month.ResumeLayout(False)
            Me.panel_day_month.PerformLayout()
            Me.TableLayoutPanel1.ResumeLayout(False)
            CType(Me.img_profile, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panel_top.ResumeLayout(False)
            Me.TableLayoutPanel3.ResumeLayout(False)
            Me.panel_year_month.ResumeLayout(False)
            Me.panel_year_month.PerformLayout()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents panel_main As Panel
        Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
        Friend WithEvents panel_sidebar As Panel
        Friend WithEvents TableLayoutPanel8 As TableLayoutPanel
        Friend WithEvents lbl_category As Label
        Friend WithEvents add_category As Button
        Friend WithEvents tableLayoutCategorySelector As TableLayoutPanel
        Friend WithEvents flowPanelCategory As FlowLayoutPanel
        Friend WithEvents btn_delete As Button
        Friend WithEvents btn_edit_category As Button
        Friend WithEvents button_add_expense As Button
        Friend WithEvents panel_calender As Panel
        Friend WithEvents check_all As CheckBox
        Friend WithEvents timer_reset_image As Timer
        Friend WithEvents home_analysis_export_radio As TableLayoutPanel
        Friend WithEvents radio_export As RadioButton
        Friend WithEvents radio_analytical As RadioButton
        Friend WithEvents radio_home As RadioButton
        Friend WithEvents panel_day_month As TableLayoutPanel
        Friend WithEvents radio_day_view As RadioButton
        Friend WithEvents radio_month_view As RadioButton
        Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
        Friend WithEvents btn_appSetting As Button
        Friend WithEvents btn_close As Button
        Friend WithEvents img_profile As PictureBox
        Friend WithEvents btn_max As Button
        Friend WithEvents btn_min As Button
        Friend WithEvents panel_top As Panel
        Public WithEvents radio_analysis_year As RadioButton
        Public WithEvents radio_analyze_monthly As RadioButton
        Public WithEvents panel_year_month As TableLayoutPanel
        Public WithEvents TableLayoutPanel3 As TableLayoutPanel
        Friend WithEvents DateTimePicker2 As DateTimePicker
        Friend WithEvents DateTimePicker1 As DateTimePicker
    End Class
End NameSpace