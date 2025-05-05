Namespace Presentation
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class AppSetting
        Inherits System.Windows.Forms.Form

        'Form overrides dispose to clean up the component list.
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
            Me.components = New System.ComponentModel.Container()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AppSetting))
            Me.timer_reset_image = New System.Windows.Forms.Timer(Me.components)
            Me.panel_topbar = New System.Windows.Forms.Panel()
            Me.button_close = New System.Windows.Forms.Button()
            Me.button_create = New System.Windows.Forms.Button()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
            Me.lbl_colorMode = New System.Windows.Forms.Label()
            Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
            Me.lightModeSelector = New System.Windows.Forms.RadioButton()
            Me.darkModeSelector = New System.Windows.Forms.RadioButton()
            Me.panel_back = New System.Windows.Forms.Panel()
            Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
            Me.lbl_info = New System.Windows.Forms.Label()
            Me.panel_topbar.SuspendLayout()
            Me.TableLayoutPanel1.SuspendLayout()
            Me.TableLayoutPanel2.SuspendLayout()
            Me.panel_back.SuspendLayout()
            Me.TableLayoutPanel3.SuspendLayout()
            Me.SuspendLayout()
            '
            'timer_reset_image
            '
            Me.timer_reset_image.Interval = 120
            '
            'panel_topbar
            '
            Me.panel_topbar.BackColor = System.Drawing.Color.Transparent
            Me.panel_topbar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.panel_topbar.Controls.Add(Me.button_close)
            Me.panel_topbar.Controls.Add(Me.button_create)
            Me.panel_topbar.Controls.Add(Me.Label4)
            Me.panel_topbar.Dock = System.Windows.Forms.DockStyle.Top
            Me.panel_topbar.Location = New System.Drawing.Point(0, 0)
            Me.panel_topbar.Margin = New System.Windows.Forms.Padding(0)
            Me.panel_topbar.Name = "panel_topbar"
            Me.panel_topbar.Size = New System.Drawing.Size(431, 46)
            Me.panel_topbar.TabIndex = 87
            '
            'button_close
            '
            Me.button_close.Dock = System.Windows.Forms.DockStyle.Left
            Me.button_close.FlatAppearance.BorderSize = 0
            Me.button_close.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
            Me.button_close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(35, Byte), Integer))
            Me.button_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.button_close.Image = Global.expense_Trackie.My.Resources.Resources.icons8_close_16
            Me.button_close.Location = New System.Drawing.Point(0, 0)
            Me.button_close.Margin = New System.Windows.Forms.Padding(0)
            Me.button_close.Name = "button_close"
            Me.button_close.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.button_close.Size = New System.Drawing.Size(50, 44)
            Me.button_close.TabIndex = 11
            Me.button_close.UseVisualStyleBackColor = True
            '
            'button_create
            '
            Me.button_create.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.button_create.FlatAppearance.BorderSize = 0
            Me.button_create.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
            Me.button_create.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(125, Byte), Integer))
            Me.button_create.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.button_create.Image = Global.expense_Trackie.My.Resources.Resources.tickRound
            Me.button_create.Location = New System.Drawing.Point(379, 0)
            Me.button_create.Margin = New System.Windows.Forms.Padding(0)
            Me.button_create.Name = "button_create"
            Me.button_create.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.button_create.Size = New System.Drawing.Size(50, 46)
            Me.button_create.TabIndex = 10
            Me.button_create.UseVisualStyleBackColor = True
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.Font = New System.Drawing.Font("Cascadia Mono", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label4.Location = New System.Drawing.Point(154, 11)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(109, 21)
            Me.Label4.TabIndex = 2
            Me.Label4.Text = "App Setting"
            '
            'TableLayoutPanel1
            '
            Me.TableLayoutPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.TableLayoutPanel1.BackColor = System.Drawing.Color.Transparent
            Me.TableLayoutPanel1.ColumnCount = 1
            Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
            Me.TableLayoutPanel1.Controls.Add(Me.lbl_colorMode, 0, 0)
            Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 1)
            Me.TableLayoutPanel1.Location = New System.Drawing.Point(40, 46)
            Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
            Me.TableLayoutPanel1.RowCount = 2
            Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28531!))
            Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.7457!))
            Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
            Me.TableLayoutPanel1.Size = New System.Drawing.Size(349, 94)
            Me.TableLayoutPanel1.TabIndex = 88
            '
            'lbl_colorMode
            '
            Me.lbl_colorMode.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.lbl_colorMode.Font = New System.Drawing.Font("IBM Plex Mono", 10.0!)
            Me.lbl_colorMode.Location = New System.Drawing.Point(3, 29)
            Me.lbl_colorMode.Name = "lbl_colorMode"
            Me.lbl_colorMode.Size = New System.Drawing.Size(343, 18)
            Me.lbl_colorMode.TabIndex = 0
            Me.lbl_colorMode.Text = "Color Mode"
            '
            'TableLayoutPanel2
            '
            Me.TableLayoutPanel2.ColumnCount = 2
            Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
            Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
            Me.TableLayoutPanel2.Controls.Add(Me.lightModeSelector, 0, 0)
            Me.TableLayoutPanel2.Controls.Add(Me.darkModeSelector, 1, 0)
            Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
            Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 50)
            Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
            Me.TableLayoutPanel2.RowCount = 1
            Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
            Me.TableLayoutPanel2.Size = New System.Drawing.Size(343, 41)
            Me.TableLayoutPanel2.TabIndex = 1
            '
            'lightModeSelector
            '
            Me.lightModeSelector.Appearance = System.Windows.Forms.Appearance.Button
            Me.lightModeSelector.AutoSize = True
            Me.lightModeSelector.Dock = System.Windows.Forms.DockStyle.Fill
            Me.lightModeSelector.FlatAppearance.BorderSize = 0
            Me.lightModeSelector.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
            Me.lightModeSelector.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
            Me.lightModeSelector.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
            Me.lightModeSelector.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.lightModeSelector.Image = Global.expense_Trackie.My.Resources.Resources.lightMode
            Me.lightModeSelector.Location = New System.Drawing.Point(3, 3)
            Me.lightModeSelector.Name = "lightModeSelector"
            Me.lightModeSelector.Size = New System.Drawing.Size(165, 35)
            Me.lightModeSelector.TabIndex = 0
            Me.lightModeSelector.TabStop = True
            Me.lightModeSelector.UseVisualStyleBackColor = True
            '
            'darkModeSelector
            '
            Me.darkModeSelector.Appearance = System.Windows.Forms.Appearance.Button
            Me.darkModeSelector.AutoSize = True
            Me.darkModeSelector.Dock = System.Windows.Forms.DockStyle.Fill
            Me.darkModeSelector.FlatAppearance.BorderSize = 0
            Me.darkModeSelector.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
            Me.darkModeSelector.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
            Me.darkModeSelector.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
            Me.darkModeSelector.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.darkModeSelector.Image = Global.expense_Trackie.My.Resources.Resources.darkMode
            Me.darkModeSelector.Location = New System.Drawing.Point(174, 3)
            Me.darkModeSelector.Name = "darkModeSelector"
            Me.darkModeSelector.Size = New System.Drawing.Size(166, 35)
            Me.darkModeSelector.TabIndex = 1
            Me.darkModeSelector.TabStop = True
            Me.darkModeSelector.UseVisualStyleBackColor = True
            '
            'panel_back
            '
            Me.panel_back.BackColor = System.Drawing.Color.Transparent
            Me.panel_back.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.panel_back.Controls.Add(Me.TableLayoutPanel3)
            Me.panel_back.Dock = System.Windows.Forms.DockStyle.Fill
            Me.panel_back.Location = New System.Drawing.Point(0, 0)
            Me.panel_back.Name = "panel_back"
            Me.panel_back.Size = New System.Drawing.Size(431, 413)
            Me.panel_back.TabIndex = 89
            '
            'TableLayoutPanel3
            '
            Me.TableLayoutPanel3.BackColor = System.Drawing.Color.Transparent
            Me.TableLayoutPanel3.ColumnCount = 1
            Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
            Me.TableLayoutPanel3.Controls.Add(Me.lbl_info, 0, 0)
            Me.TableLayoutPanel3.Location = New System.Drawing.Point(65, 377)
            Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
            Me.TableLayoutPanel3.RowCount = 1
            Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
            Me.TableLayoutPanel3.Size = New System.Drawing.Size(305, 32)
            Me.TableLayoutPanel3.TabIndex = 84
            '
            'lbl_info
            '
            Me.lbl_info.AutoSize = True
            Me.lbl_info.BackColor = System.Drawing.Color.Transparent
            Me.lbl_info.Dock = System.Windows.Forms.DockStyle.Fill
            Me.lbl_info.Font = New System.Drawing.Font("IBM Plex Mono", 9.0!)
            Me.lbl_info.ForeColor = System.Drawing.Color.Red
            Me.lbl_info.Location = New System.Drawing.Point(3, 0)
            Me.lbl_info.Name = "lbl_info"
            Me.lbl_info.Size = New System.Drawing.Size(299, 32)
            Me.lbl_info.TabIndex = 82
            Me.lbl_info.Text = "error"
            Me.lbl_info.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'AppSetting
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(431, 413)
            Me.Controls.Add(Me.TableLayoutPanel1)
            Me.Controls.Add(Me.panel_topbar)
            Me.Controls.Add(Me.panel_back)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "AppSetting"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "AppSetting"
            Me.panel_topbar.ResumeLayout(False)
            Me.panel_topbar.PerformLayout()
            Me.TableLayoutPanel1.ResumeLayout(False)
            Me.TableLayoutPanel2.ResumeLayout(False)
            Me.TableLayoutPanel2.PerformLayout()
            Me.panel_back.ResumeLayout(False)
            Me.TableLayoutPanel3.ResumeLayout(False)
            Me.TableLayoutPanel3.PerformLayout()
            Me.ResumeLayout(False)

        End Sub

        Friend WithEvents timer_reset_image As Timer
        Friend WithEvents panel_topbar As Panel
        Friend WithEvents button_close As Button
        Friend WithEvents button_create As Button
        Friend WithEvents Label4 As Label
        Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
        Friend WithEvents lbl_colorMode As Label
        Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
        Friend WithEvents lightModeSelector As RadioButton
        Friend WithEvents darkModeSelector As RadioButton
        Friend WithEvents panel_back As Panel
        Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
        Friend WithEvents lbl_info As Label
    End Class
End NameSpace