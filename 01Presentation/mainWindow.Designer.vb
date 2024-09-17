<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class mainWindow
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
        Me.flowPanelCategory = New System.Windows.Forms.FlowLayoutPanel()
        Me.lbl_username = New System.Windows.Forms.Label()
        Me.btn_profile = New System.Windows.Forms.Button()
        Me.tableLayoutCategorySelector = New System.Windows.Forms.TableLayoutPanel()
        Me.check_all = New System.Windows.Forms.CheckBox()
        Me.home_analysis_export_radio = New System.Windows.Forms.TableLayoutPanel()
        Me.radio_export = New System.Windows.Forms.RadioButton()
        Me.radio_analytical = New System.Windows.Forms.RadioButton()
        Me.radio_home = New System.Windows.Forms.RadioButton()
        Me.TableLayoutPanel8 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.add_category = New System.Windows.Forms.Button()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.table_calander_control = New System.Windows.Forms.TableLayoutPanel()
        Me.month_next = New System.Windows.Forms.Button()
        Me.month_previous = New System.Windows.Forms.Button()
        Me.label_date = New System.Windows.Forms.Label()
        Me.panel_topbar = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.radio_day_view = New System.Windows.Forms.RadioButton()
        Me.radio_month_view = New System.Windows.Forms.RadioButton()
        Me.button_min = New System.Windows.Forms.Button()
        Me.button_max = New System.Windows.Forms.Button()
        Me.button_close = New System.Windows.Forms.Button()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.panel_sidebar.SuspendLayout()
        Me.tableLayoutCategorySelector.SuspendLayout()
        Me.home_analysis_export_radio.SuspendLayout()
        Me.TableLayoutPanel8.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.table_calander_control.SuspendLayout()
        Me.panel_topbar.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'panel_main
        '
        Me.panel_main.BackColor = System.Drawing.Color.LightGray
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
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(22, 57)
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
        Me.button_add_expense.Cursor = System.Windows.Forms.Cursors.Hand
        Me.button_add_expense.Dock = System.Windows.Forms.DockStyle.Fill
        Me.button_add_expense.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.button_add_expense.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button_add_expense.Font = New System.Drawing.Font("Cascadia Mono", 13.0!)
        Me.button_add_expense.Image = Global.expense_Trackie.My.Resources.Resources.icons8_add_161
        Me.button_add_expense.Location = New System.Drawing.Point(52, 14)
        Me.button_add_expense.Name = "button_add_expense"
        Me.button_add_expense.Size = New System.Drawing.Size(142, 57)
        Me.button_add_expense.TabIndex = 7
        Me.button_add_expense.Text = "Add"
        Me.button_add_expense.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.button_add_expense.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.button_add_expense.UseVisualStyleBackColor = True
        '
        'panel_sidebar
        '
        Me.panel_sidebar.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.panel_sidebar.Controls.Add(Me.flowPanelCategory)
        Me.panel_sidebar.Controls.Add(Me.lbl_username)
        Me.panel_sidebar.Controls.Add(Me.btn_profile)
        Me.panel_sidebar.Controls.Add(Me.tableLayoutCategorySelector)
        Me.panel_sidebar.Controls.Add(Me.home_analysis_export_radio)
        Me.panel_sidebar.Controls.Add(Me.TableLayoutPanel8)
        Me.panel_sidebar.Controls.Add(Me.TableLayoutPanel4)
        Me.panel_sidebar.Controls.Add(Me.TableLayoutPanel3)
        Me.panel_sidebar.Controls.Add(Me.table_calander_control)
        Me.panel_sidebar.Controls.Add(Me.TableLayoutPanel2)
        Me.panel_sidebar.Dock = System.Windows.Forms.DockStyle.Left
        Me.panel_sidebar.Location = New System.Drawing.Point(0, 0)
        Me.panel_sidebar.Name = "panel_sidebar"
        Me.panel_sidebar.Size = New System.Drawing.Size(292, 1000)
        Me.panel_sidebar.TabIndex = 0
        '
        'flowPanelCategory
        '
        Me.flowPanelCategory.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.flowPanelCategory.AutoScroll = True
        Me.flowPanelCategory.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.flowPanelCategory.Location = New System.Drawing.Point(22, 594)
        Me.flowPanelCategory.Margin = New System.Windows.Forms.Padding(0)
        Me.flowPanelCategory.Name = "flowPanelCategory"
        Me.flowPanelCategory.Size = New System.Drawing.Size(247, 336)
        Me.flowPanelCategory.TabIndex = 12
        Me.flowPanelCategory.WrapContents = False
        '
        'lbl_username
        '
        Me.lbl_username.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lbl_username.AutoSize = True
        Me.lbl_username.Font = New System.Drawing.Font("SF Mono", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_username.Location = New System.Drawing.Point(66, 964)
        Me.lbl_username.Name = "lbl_username"
        Me.lbl_username.Size = New System.Drawing.Size(71, 16)
        Me.lbl_username.TabIndex = 11
        Me.lbl_username.Text = "username"
        '
        'btn_profile
        '
        Me.btn_profile.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_profile.FlatAppearance.BorderSize = 0
        Me.btn_profile.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_profile.Image = Global.expense_Trackie.My.Resources.Resources.profileLight
        Me.btn_profile.Location = New System.Drawing.Point(17, 941)
        Me.btn_profile.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_profile.Name = "btn_profile"
        Me.btn_profile.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btn_profile.Size = New System.Drawing.Size(50, 48)
        Me.btn_profile.TabIndex = 10
        Me.btn_profile.UseVisualStyleBackColor = True
        '
        'tableLayoutCategorySelector
        '
        Me.tableLayoutCategorySelector.AutoScroll = True
        Me.tableLayoutCategorySelector.BackColor = System.Drawing.Color.Transparent
        Me.tableLayoutCategorySelector.ColumnCount = 2
        Me.tableLayoutCategorySelector.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tableLayoutCategorySelector.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tableLayoutCategorySelector.Controls.Add(Me.check_all, 0, 0)
        Me.tableLayoutCategorySelector.Location = New System.Drawing.Point(22, 555)
        Me.tableLayoutCategorySelector.Margin = New System.Windows.Forms.Padding(0)
        Me.tableLayoutCategorySelector.MaximumSize = New System.Drawing.Size(247, 650)
        Me.tableLayoutCategorySelector.Name = "tableLayoutCategorySelector"
        Me.tableLayoutCategorySelector.RowCount = 1
        Me.tableLayoutCategorySelector.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tableLayoutCategorySelector.Size = New System.Drawing.Size(247, 39)
        Me.tableLayoutCategorySelector.TabIndex = 8
        '
        'check_all
        '
        Me.check_all.Appearance = System.Windows.Forms.Appearance.Button
        Me.check_all.AutoSize = True
        Me.check_all.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver
        Me.check_all.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.check_all.Font = New System.Drawing.Font("Cascadia Mono SemiLight", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.check_all.Location = New System.Drawing.Point(5, 5)
        Me.check_all.Margin = New System.Windows.Forms.Padding(5)
        Me.check_all.Name = "check_all"
        Me.check_all.Size = New System.Drawing.Size(42, 27)
        Me.check_all.TabIndex = 0
        Me.check_all.Text = "All"
        Me.check_all.UseVisualStyleBackColor = True
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
        Me.home_analysis_export_radio.Location = New System.Drawing.Point(45, 0)
        Me.home_analysis_export_radio.Margin = New System.Windows.Forms.Padding(0)
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
        Me.radio_export.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.radio_export.Image = Global.expense_Trackie.My.Resources.Resources.exportLight
        Me.radio_export.Location = New System.Drawing.Point(135, 3)
        Me.radio_export.Name = "radio_export"
        Me.radio_export.Size = New System.Drawing.Size(62, 41)
        Me.radio_export.TabIndex = 7
        Me.radio_export.UseVisualStyleBackColor = False
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
        Me.radio_analytical.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.radio_analytical.Image = Global.expense_Trackie.My.Resources.Resources.barLight
        Me.radio_analytical.Location = New System.Drawing.Point(69, 3)
        Me.radio_analytical.Name = "radio_analytical"
        Me.radio_analytical.Size = New System.Drawing.Size(60, 41)
        Me.radio_analytical.TabIndex = 8
        Me.radio_analytical.UseVisualStyleBackColor = False
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
        Me.radio_home.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.radio_home.Image = Global.expense_Trackie.My.Resources.Resources.homeLight
        Me.radio_home.Location = New System.Drawing.Point(3, 3)
        Me.radio_home.Name = "radio_home"
        Me.radio_home.Size = New System.Drawing.Size(60, 41)
        Me.radio_home.TabIndex = 6
        Me.radio_home.UseVisualStyleBackColor = False
        '
        'TableLayoutPanel8
        '
        Me.TableLayoutPanel8.ColumnCount = 3
        Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.0!))
        Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.52632!))
        Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.83806!))
        Me.TableLayoutPanel8.Controls.Add(Me.Label8, 0, 0)
        Me.TableLayoutPanel8.Controls.Add(Me.add_category, 2, 0)
        Me.TableLayoutPanel8.Location = New System.Drawing.Point(22, 503)
        Me.TableLayoutPanel8.Name = "TableLayoutPanel8"
        Me.TableLayoutPanel8.RowCount = 1
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel8.Size = New System.Drawing.Size(247, 45)
        Me.TableLayoutPanel8.TabIndex = 7
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label8.Font = New System.Drawing.Font("Cascadia Mono", 13.0!)
        Me.Label8.Location = New System.Drawing.Point(3, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(166, 45)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "My Category"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'add_category
        '
        Me.add_category.Cursor = System.Windows.Forms.Cursors.Hand
        Me.add_category.Dock = System.Windows.Forms.DockStyle.Fill
        Me.add_category.FlatAppearance.BorderSize = 0
        Me.add_category.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.add_category.Image = Global.expense_Trackie.My.Resources.Resources.icons8_add_161
        Me.add_category.Location = New System.Drawing.Point(200, 3)
        Me.add_category.Name = "add_category"
        Me.add_category.Size = New System.Drawing.Size(44, 39)
        Me.add_category.TabIndex = 2
        Me.add_category.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 1
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(22, 237)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 1
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(247, 260)
        Me.TableLayoutPanel4.TabIndex = 6
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
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(22, 194)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(247, 43)
        Me.TableLayoutPanel3.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label7.Font = New System.Drawing.Font("Cascadia Mono", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(143, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(29, 43)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "T"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label6.Font = New System.Drawing.Font("Cascadia Mono", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(178, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(29, 43)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "F"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label5.Font = New System.Drawing.Font("Cascadia Mono", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(213, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 43)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "S"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label4.Font = New System.Drawing.Font("Cascadia Mono", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(108, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 43)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "W"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Font = New System.Drawing.Font("Cascadia Mono", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 43)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "S"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Font = New System.Drawing.Font("Cascadia Mono", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(38, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 43)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "M"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Cascadia Mono", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(73, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 43)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "T"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'table_calander_control
        '
        Me.table_calander_control.ColumnCount = 3
        Me.table_calander_control.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.0!))
        Me.table_calander_control.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.table_calander_control.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.table_calander_control.Controls.Add(Me.month_next, 2, 0)
        Me.table_calander_control.Controls.Add(Me.month_previous, 1, 0)
        Me.table_calander_control.Controls.Add(Me.label_date, 0, 0)
        Me.table_calander_control.Location = New System.Drawing.Point(22, 149)
        Me.table_calander_control.Name = "table_calander_control"
        Me.table_calander_control.RowCount = 1
        Me.table_calander_control.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.table_calander_control.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45.0!))
        Me.table_calander_control.Size = New System.Drawing.Size(247, 45)
        Me.table_calander_control.TabIndex = 4
        '
        'month_next
        '
        Me.month_next.Cursor = System.Windows.Forms.Cursors.Hand
        Me.month_next.Dock = System.Windows.Forms.DockStyle.Fill
        Me.month_next.FlatAppearance.BorderSize = 0
        Me.month_next.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.month_next.Image = Global.expense_Trackie.My.Resources.Resources.icons8_forward_16
        Me.month_next.Location = New System.Drawing.Point(212, 3)
        Me.month_next.Name = "month_next"
        Me.month_next.Size = New System.Drawing.Size(32, 39)
        Me.month_next.TabIndex = 1
        Me.month_next.UseVisualStyleBackColor = True
        '
        'month_previous
        '
        Me.month_previous.Cursor = System.Windows.Forms.Cursors.Hand
        Me.month_previous.Dock = System.Windows.Forms.DockStyle.Fill
        Me.month_previous.FlatAppearance.BorderSize = 0
        Me.month_previous.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.month_previous.Image = Global.expense_Trackie.My.Resources.Resources.icons8_back_16
        Me.month_previous.Location = New System.Drawing.Point(175, 3)
        Me.month_previous.Name = "month_previous"
        Me.month_previous.Size = New System.Drawing.Size(31, 39)
        Me.month_previous.TabIndex = 0
        Me.month_previous.UseVisualStyleBackColor = True
        '
        'label_date
        '
        Me.label_date.AutoSize = True
        Me.label_date.Dock = System.Windows.Forms.DockStyle.Fill
        Me.label_date.Font = New System.Drawing.Font("Cascadia Mono", 10.0!)
        Me.label_date.Location = New System.Drawing.Point(3, 0)
        Me.label_date.Name = "label_date"
        Me.label_date.Size = New System.Drawing.Size(166, 45)
        Me.label_date.TabIndex = 0
        Me.label_date.Text = "September 2024"
        Me.label_date.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'panel_topbar
        '
        Me.panel_topbar.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.panel_topbar.Controls.Add(Me.TableLayoutPanel5)
        Me.panel_topbar.Controls.Add(Me.button_min)
        Me.panel_topbar.Controls.Add(Me.button_max)
        Me.panel_topbar.Controls.Add(Me.button_close)
        Me.panel_topbar.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel_topbar.Location = New System.Drawing.Point(292, 0)
        Me.panel_topbar.Name = "panel_topbar"
        Me.panel_topbar.Size = New System.Drawing.Size(1308, 48)
        Me.panel_topbar.TabIndex = 1
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel5.ColumnCount = 2
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel5.Controls.Add(Me.radio_day_view, 1, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.radio_month_view, 0, 0)
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(1057, 1)
        Me.TableLayoutPanel5.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 1
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47.0!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(99, 47)
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
        Me.radio_day_view.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.radio_day_view.Image = Global.expense_Trackie.My.Resources.Resources.dayLight
        Me.radio_day_view.Location = New System.Drawing.Point(52, 3)
        Me.radio_day_view.Name = "radio_day_view"
        Me.radio_day_view.Size = New System.Drawing.Size(44, 41)
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
        Me.radio_month_view.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.radio_month_view.Image = Global.expense_Trackie.My.Resources.Resources.monthLight
        Me.radio_month_view.Location = New System.Drawing.Point(3, 3)
        Me.radio_month_view.Name = "radio_month_view"
        Me.radio_month_view.Size = New System.Drawing.Size(43, 41)
        Me.radio_month_view.TabIndex = 6
        Me.radio_month_view.UseVisualStyleBackColor = True
        '
        'button_min
        '
        Me.button_min.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.button_min.FlatAppearance.BorderSize = 0
        Me.button_min.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button_min.Image = Global.expense_Trackie.My.Resources.Resources.icons8_horizontal_line_16
        Me.button_min.Location = New System.Drawing.Point(1158, 0)
        Me.button_min.Margin = New System.Windows.Forms.Padding(0)
        Me.button_min.Name = "button_min"
        Me.button_min.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.button_min.Size = New System.Drawing.Size(50, 48)
        Me.button_min.TabIndex = 6
        Me.button_min.UseVisualStyleBackColor = True
        '
        'button_max
        '
        Me.button_max.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.button_max.FlatAppearance.BorderSize = 0
        Me.button_max.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button_max.Image = Global.expense_Trackie.My.Resources.Resources.icons8_maximize_button_16
        Me.button_max.Location = New System.Drawing.Point(1208, 0)
        Me.button_max.Margin = New System.Windows.Forms.Padding(0)
        Me.button_max.Name = "button_max"
        Me.button_max.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.button_max.Size = New System.Drawing.Size(50, 48)
        Me.button_max.TabIndex = 0
        Me.button_max.UseVisualStyleBackColor = True
        '
        'button_close
        '
        Me.button_close.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.button_close.FlatAppearance.BorderSize = 0
        Me.button_close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.button_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button_close.Image = Global.expense_Trackie.My.Resources.Resources.icons8_close_16
        Me.button_close.Location = New System.Drawing.Point(1258, 0)
        Me.button_close.Margin = New System.Windows.Forms.Padding(0)
        Me.button_close.Name = "button_close"
        Me.button_close.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.button_close.Size = New System.Drawing.Size(50, 48)
        Me.button_close.TabIndex = 7
        Me.button_close.UseVisualStyleBackColor = True
        '
        'mainWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1600, 1000)
        Me.Controls.Add(Me.panel_main)
        Me.Controls.Add(Me.panel_topbar)
        Me.Controls.Add(Me.panel_sidebar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MinimumSize = New System.Drawing.Size(1600, 1000)
        Me.Name = "mainWindow"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "temp"
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.panel_sidebar.ResumeLayout(False)
        Me.panel_sidebar.PerformLayout()
        Me.tableLayoutCategorySelector.ResumeLayout(False)
        Me.tableLayoutCategorySelector.PerformLayout()
        Me.home_analysis_export_radio.ResumeLayout(False)
        Me.home_analysis_export_radio.PerformLayout()
        Me.TableLayoutPanel8.ResumeLayout(False)
        Me.TableLayoutPanel8.PerformLayout()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.table_calander_control.ResumeLayout(False)
        Me.table_calander_control.PerformLayout()
        Me.panel_topbar.ResumeLayout(False)
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.TableLayoutPanel5.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents panel_main As Panel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents panel_sidebar As Panel
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents table_calander_control As TableLayoutPanel
    Friend WithEvents label_date As Label
    Friend WithEvents button_add_expense As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TableLayoutPanel8 As TableLayoutPanel
    Friend WithEvents Label8 As Label
    Friend WithEvents add_category As Button
    Friend WithEvents month_next As Button
    Friend WithEvents month_previous As Button
    Friend WithEvents home_analysis_export_radio As TableLayoutPanel
    Friend WithEvents button_max As Button
    Friend WithEvents button_min As Button
    Friend WithEvents panel_topbar As Panel
    Friend WithEvents button_close As Button
    Friend WithEvents lbl_username As Label
    Friend WithEvents btn_profile As Button
    Friend WithEvents tableLayoutCategorySelector As TableLayoutPanel
    Friend WithEvents flowPanelCategory As FlowLayoutPanel
    Friend WithEvents radio_export As RadioButton
    Friend WithEvents radio_analytical As RadioButton
    Friend WithEvents radio_home As RadioButton
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents radio_day_view As RadioButton
    Friend WithEvents radio_month_view As RadioButton
    Friend WithEvents check_all As CheckBox
End Class
