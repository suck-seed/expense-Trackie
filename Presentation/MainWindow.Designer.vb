Namespace Presentation
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
            Me.Label8 = New System.Windows.Forms.Label()
            Me.add_category = New System.Windows.Forms.Button()
            Me.panel_topbar = New System.Windows.Forms.Panel()
            Me.img_profile = New System.Windows.Forms.PictureBox()
            Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
            Me.radio_day_view = New System.Windows.Forms.RadioButton()
            Me.radio_month_view = New System.Windows.Forms.RadioButton()
            Me.button_min = New System.Windows.Forms.Button()
            Me.button_max = New System.Windows.Forms.Button()
            Me.home_analysis_export_radio = New System.Windows.Forms.TableLayoutPanel()
            Me.radio_export = New System.Windows.Forms.RadioButton()
            Me.radio_analytical = New System.Windows.Forms.RadioButton()
            Me.radio_home = New System.Windows.Forms.RadioButton()
            Me.button_close = New System.Windows.Forms.Button()
            Me.TableLayoutPanel2.SuspendLayout()
            Me.panel_sidebar.SuspendLayout()
            Me.tableLayoutCategorySelector.SuspendLayout()
            Me.TableLayoutPanel8.SuspendLayout()
            Me.panel_topbar.SuspendLayout()
            CType(Me.img_profile, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.TableLayoutPanel5.SuspendLayout()
            Me.home_analysis_export_radio.SuspendLayout()
            Me.SuspendLayout()
            '
            'panel_main
            '
            Me.panel_main.BackColor = System.Drawing.Color.Gainsboro
            Me.panel_main.Dock = System.Windows.Forms.DockStyle.Fill
            Me.panel_main.Location = New System.Drawing.Point(292, 48)
            Me.panel_main.Name = "panel_main"
            Me.panel_main.Size = New System.Drawing.Size(1308, 952)
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
            Me.button_add_expense.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonFace
            Me.button_add_expense.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonFace
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
            Me.panel_sidebar.Location = New System.Drawing.Point(0, 48)
            Me.panel_sidebar.Name = "panel_sidebar"
            Me.panel_sidebar.Size = New System.Drawing.Size(292, 952)
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
            Me.flowPanelCategory.Size = New System.Drawing.Size(247, 421)
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
            Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 34.0!))
            Me.TableLayoutPanel8.Controls.Add(Me.btn_edit_category, 0, 0)
            Me.TableLayoutPanel8.Controls.Add(Me.btn_delete, 0, 0)
            Me.TableLayoutPanel8.Controls.Add(Me.Label8, 0, 0)
            Me.TableLayoutPanel8.Controls.Add(Me.add_category, 3, 0)
            Me.TableLayoutPanel8.Location = New System.Drawing.Point(22, 418)
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
            Me.btn_edit_category.Location = New System.Drawing.Point(182, 3)
            Me.btn_edit_category.Name = "btn_edit_category"
            Me.btn_edit_category.Size = New System.Drawing.Size(27, 39)
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
            Me.btn_delete.Location = New System.Drawing.Point(149, 3)
            Me.btn_delete.Name = "btn_delete"
            Me.btn_delete.Size = New System.Drawing.Size(27, 39)
            Me.btn_delete.TabIndex = 3
            Me.btn_delete.UseVisualStyleBackColor = True
            '
            'Label8
            '
            Me.Label8.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Label8.Font = New System.Drawing.Font("IBM Plex Mono SemiBold", 14.0!, System.Drawing.FontStyle.Bold)
            Me.Label8.Location = New System.Drawing.Point(3, 0)
            Me.Label8.Name = "Label8"
            Me.Label8.Size = New System.Drawing.Size(140, 45)
            Me.Label8.TabIndex = 0
            Me.Label8.Text = "My Category"
            Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'add_category
            '
            Me.add_category.Cursor = System.Windows.Forms.Cursors.Hand
            Me.add_category.Dock = System.Windows.Forms.DockStyle.Fill
            Me.add_category.FlatAppearance.BorderSize = 0
            Me.add_category.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
            Me.add_category.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
            Me.add_category.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.add_category.Image = Global.expense_Trackie.My.Resources.Resources.icons8_add_161
            Me.add_category.Location = New System.Drawing.Point(215, 3)
            Me.add_category.Name = "add_category"
            Me.add_category.Size = New System.Drawing.Size(29, 39)
            Me.add_category.TabIndex = 2
            Me.add_category.UseVisualStyleBackColor = True
            '
            'panel_topbar
            '
            Me.panel_topbar.BackColor = System.Drawing.Color.Transparent
            Me.panel_topbar.Controls.Add(Me.img_profile)
            Me.panel_topbar.Controls.Add(Me.TableLayoutPanel5)
            Me.panel_topbar.Controls.Add(Me.button_min)
            Me.panel_topbar.Controls.Add(Me.button_max)
            Me.panel_topbar.Controls.Add(Me.home_analysis_export_radio)
            Me.panel_topbar.Controls.Add(Me.button_close)
            Me.panel_topbar.Dock = System.Windows.Forms.DockStyle.Top
            Me.panel_topbar.Location = New System.Drawing.Point(0, 0)
            Me.panel_topbar.Name = "panel_topbar"
            Me.panel_topbar.Size = New System.Drawing.Size(1600, 48)
            Me.panel_topbar.TabIndex = 1
            '
            'img_profile
            '
            Me.img_profile.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.img_profile.Image = Global.expense_Trackie.My.Resources.Resources.profileLight
            Me.img_profile.Location = New System.Drawing.Point(1403, 5)
            Me.img_profile.Margin = New System.Windows.Forms.Padding(0)
            Me.img_profile.Name = "img_profile"
            Me.img_profile.Size = New System.Drawing.Size(40, 40)
            Me.img_profile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
            Me.img_profile.TabIndex = 13
            Me.img_profile.TabStop = False
            '
            'TableLayoutPanel5
            '
            Me.TableLayoutPanel5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.TableLayoutPanel5.ColumnCount = 2
            Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
            Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
            Me.TableLayoutPanel5.Controls.Add(Me.radio_day_view, 1, 0)
            Me.TableLayoutPanel5.Controls.Add(Me.radio_month_view, 0, 0)
            Me.TableLayoutPanel5.Location = New System.Drawing.Point(1300, 1)
            Me.TableLayoutPanel5.Margin = New System.Windows.Forms.Padding(0, 2, 0, 2)
            Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
            Me.TableLayoutPanel5.RowCount = 1
            Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
            Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48.0!))
            Me.TableLayoutPanel5.Size = New System.Drawing.Size(99, 48)
            Me.TableLayoutPanel5.TabIndex = 10
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
            Me.radio_day_view.Location = New System.Drawing.Point(52, 3)
            Me.radio_day_view.Name = "radio_day_view"
            Me.radio_day_view.Size = New System.Drawing.Size(44, 42)
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
            Me.radio_month_view.Size = New System.Drawing.Size(43, 42)
            Me.radio_month_view.TabIndex = 6
            Me.radio_month_view.UseVisualStyleBackColor = True
            '
            'button_min
            '
            Me.button_min.Dock = System.Windows.Forms.DockStyle.Right
            Me.button_min.FlatAppearance.BorderSize = 0
            Me.button_min.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.button_min.Image = Global.expense_Trackie.My.Resources.Resources.icons8_horizontal_line_16
            Me.button_min.Location = New System.Drawing.Point(1450, 0)
            Me.button_min.Margin = New System.Windows.Forms.Padding(0, 0, 0, 2)
            Me.button_min.Name = "button_min"
            Me.button_min.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.button_min.Size = New System.Drawing.Size(50, 48)
            Me.button_min.TabIndex = 6
            Me.button_min.UseVisualStyleBackColor = True
            '
            'button_max
            '
            Me.button_max.Dock = System.Windows.Forms.DockStyle.Right
            Me.button_max.FlatAppearance.BorderSize = 0
            Me.button_max.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.button_max.Image = Global.expense_Trackie.My.Resources.Resources.icons8_maximize_button_16
            Me.button_max.Location = New System.Drawing.Point(1500, 0)
            Me.button_max.Margin = New System.Windows.Forms.Padding(0, 0, 0, 2)
            Me.button_max.Name = "button_max"
            Me.button_max.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.button_max.Size = New System.Drawing.Size(50, 48)
            Me.button_max.TabIndex = 0
            Me.button_max.UseVisualStyleBackColor = True
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
            'button_close
            '
            Me.button_close.Dock = System.Windows.Forms.DockStyle.Right
            Me.button_close.FlatAppearance.BorderSize = 0
            Me.button_close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(35, Byte), Integer))
            Me.button_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.button_close.Image = Global.expense_Trackie.My.Resources.Resources.icons8_close_16
            Me.button_close.Location = New System.Drawing.Point(1550, 0)
            Me.button_close.Margin = New System.Windows.Forms.Padding(0, 0, 0, 2)
            Me.button_close.Name = "button_close"
            Me.button_close.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.button_close.Size = New System.Drawing.Size(50, 48)
            Me.button_close.TabIndex = 7
            Me.button_close.UseVisualStyleBackColor = True
            '
            'MainWindow
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(252, Byte), Integer))
            Me.ClientSize = New System.Drawing.Size(1600, 1000)
            Me.Controls.Add(Me.panel_main)
            Me.Controls.Add(Me.panel_sidebar)
            Me.Controls.Add(Me.panel_topbar)
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
            Me.panel_topbar.ResumeLayout(False)
            CType(Me.img_profile, System.ComponentModel.ISupportInitialize).EndInit()
            Me.TableLayoutPanel5.ResumeLayout(False)
            Me.TableLayoutPanel5.PerformLayout()
            Me.home_analysis_export_radio.ResumeLayout(False)
            Me.home_analysis_export_radio.PerformLayout()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents panel_main As Panel
        Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
        Friend WithEvents panel_sidebar As Panel
        Friend WithEvents TableLayoutPanel8 As TableLayoutPanel
        Friend WithEvents Label8 As Label
        Friend WithEvents add_category As Button
        Friend WithEvents button_max As Button
        Friend WithEvents button_min As Button
        Friend WithEvents panel_topbar As Panel
        Friend WithEvents button_close As Button
        Friend WithEvents tableLayoutCategorySelector As TableLayoutPanel
        Friend WithEvents flowPanelCategory As FlowLayoutPanel
        Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
        Friend WithEvents radio_day_view As RadioButton
        Friend WithEvents radio_month_view As RadioButton
        Friend WithEvents btn_delete As Button
        Friend WithEvents home_analysis_export_radio As TableLayoutPanel
        Friend WithEvents radio_export As RadioButton
        Friend WithEvents radio_analytical As RadioButton
        Friend WithEvents radio_home As RadioButton
        Friend WithEvents btn_edit_category As Button
        Friend WithEvents button_add_expense As Button
        Friend WithEvents panel_calender As Panel
        Friend WithEvents img_profile As PictureBox
        Friend WithEvents check_all As CheckBox
    End Class
End NameSpace