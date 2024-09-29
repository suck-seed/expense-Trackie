Namespace Presentation
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class DeleteCategory
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
            Me.button_close = New System.Windows.Forms.Button()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.panel_topbar = New System.Windows.Forms.Panel()
            Me.button_delete = New System.Windows.Forms.Button()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
            Me.flowPanel_category = New System.Windows.Forms.FlowLayoutPanel()
            Me.timer_reset_image = New System.Windows.Forms.Timer(Me.components)
            Me.panel_back = New System.Windows.Forms.Panel()
            Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
            Me.lbl_info = New System.Windows.Forms.Label()
            Me.panel_topbar.SuspendLayout()
            Me.TableLayoutPanel1.SuspendLayout()
            Me.panel_back.SuspendLayout()
            Me.TableLayoutPanel2.SuspendLayout()
            Me.SuspendLayout()
            '
            'button_close
            '
            Me.button_close.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.button_close.FlatAppearance.BorderSize = 0
            Me.button_close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(35, Byte), Integer))
            Me.button_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.button_close.Image = Global.expense_Trackie.My.Resources.Resources.icons8_close_16
            Me.button_close.Location = New System.Drawing.Point(-2, 0)
            Me.button_close.Margin = New System.Windows.Forms.Padding(0)
            Me.button_close.Name = "button_close"
            Me.button_close.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.button_close.Size = New System.Drawing.Size(50, 46)
            Me.button_close.TabIndex = 11
            Me.button_close.UseVisualStyleBackColor = True
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.Font = New System.Drawing.Font("Cascadia Mono", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label4.Location = New System.Drawing.Point(189, 9)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(145, 21)
            Me.Label4.TabIndex = 2
            Me.Label4.Text = "Delete Category"
            '
            'panel_topbar
            '
            Me.panel_topbar.BackColor = System.Drawing.Color.Transparent
            Me.panel_topbar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.panel_topbar.Controls.Add(Me.button_close)
            Me.panel_topbar.Controls.Add(Me.button_delete)
            Me.panel_topbar.Controls.Add(Me.Label4)
            Me.panel_topbar.Dock = System.Windows.Forms.DockStyle.Top
            Me.panel_topbar.Location = New System.Drawing.Point(0, 0)
            Me.panel_topbar.Margin = New System.Windows.Forms.Padding(0)
            Me.panel_topbar.Name = "panel_topbar"
            Me.panel_topbar.Size = New System.Drawing.Size(531, 46)
            Me.panel_topbar.TabIndex = 4
            '
            'button_delete
            '
            Me.button_delete.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.button_delete.FlatAppearance.BorderSize = 0
            Me.button_delete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(125, Byte), Integer))
            Me.button_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.button_delete.Image = Global.expense_Trackie.My.Resources.Resources.tickRound
            Me.button_delete.Location = New System.Drawing.Point(479, 0)
            Me.button_delete.Margin = New System.Windows.Forms.Padding(0)
            Me.button_delete.Name = "button_delete"
            Me.button_delete.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.button_delete.Size = New System.Drawing.Size(50, 46)
            Me.button_delete.TabIndex = 10
            Me.button_delete.UseVisualStyleBackColor = True
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.Label1.Font = New System.Drawing.Font("Cascadia Mono", 10.0!)
            Me.Label1.Location = New System.Drawing.Point(3, 21)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(417, 18)
            Me.Label1.TabIndex = 0
            Me.Label1.Text = "Category"
            '
            'TableLayoutPanel1
            '
            Me.TableLayoutPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.TableLayoutPanel1.BackColor = System.Drawing.Color.Transparent
            Me.TableLayoutPanel1.ColumnCount = 1
            Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
            Me.TableLayoutPanel1.Controls.Add(Me.flowPanel_category, 0, 1)
            Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
            Me.TableLayoutPanel1.Location = New System.Drawing.Point(54, 69)
            Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
            Me.TableLayoutPanel1.RowCount = 2
            Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.63123!))
            Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 89.36877!))
            Me.TableLayoutPanel1.Size = New System.Drawing.Size(423, 367)
            Me.TableLayoutPanel1.TabIndex = 3
            '
            'flowPanel_category
            '
            Me.flowPanel_category.AutoScroll = True
            Me.flowPanel_category.Dock = System.Windows.Forms.DockStyle.Fill
            Me.flowPanel_category.Location = New System.Drawing.Point(3, 42)
            Me.flowPanel_category.Name = "flowPanel_category"
            Me.flowPanel_category.Size = New System.Drawing.Size(417, 322)
            Me.flowPanel_category.TabIndex = 10
            '
            'timer_reset_image
            '
            Me.timer_reset_image.Interval = 120
            '
            'panel_back
            '
            Me.panel_back.BackColor = System.Drawing.Color.Transparent
            Me.panel_back.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.panel_back.Controls.Add(Me.TableLayoutPanel2)
            Me.panel_back.Dock = System.Windows.Forms.DockStyle.Fill
            Me.panel_back.Location = New System.Drawing.Point(0, 0)
            Me.panel_back.Name = "panel_back"
            Me.panel_back.Size = New System.Drawing.Size(531, 482)
            Me.panel_back.TabIndex = 7
            '
            'TableLayoutPanel2
            '
            Me.TableLayoutPanel2.BackColor = System.Drawing.Color.Transparent
            Me.TableLayoutPanel2.ColumnCount = 1
            Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
            Me.TableLayoutPanel2.Controls.Add(Me.lbl_info, 0, 0)
            Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 453)
            Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
            Me.TableLayoutPanel2.RowCount = 1
            Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
            Me.TableLayoutPanel2.Size = New System.Drawing.Size(529, 27)
            Me.TableLayoutPanel2.TabIndex = 85
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
            Me.lbl_info.Size = New System.Drawing.Size(523, 27)
            Me.lbl_info.TabIndex = 82
            Me.lbl_info.Text = "error"
            Me.lbl_info.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'DeleteCategory
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(531, 482)
            Me.Controls.Add(Me.panel_topbar)
            Me.Controls.Add(Me.TableLayoutPanel1)
            Me.Controls.Add(Me.panel_back)
            Me.DoubleBuffered = True
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            Me.KeyPreview = True
            Me.Name = "DeleteCategory"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "deleteCategory"
            Me.panel_topbar.ResumeLayout(False)
            Me.panel_topbar.PerformLayout()
            Me.TableLayoutPanel1.ResumeLayout(False)
            Me.TableLayoutPanel1.PerformLayout()
            Me.panel_back.ResumeLayout(False)
            Me.TableLayoutPanel2.ResumeLayout(False)
            Me.TableLayoutPanel2.PerformLayout()
            Me.ResumeLayout(False)

        End Sub

        Friend WithEvents button_close As Button
        Friend WithEvents Label4 As Label
        Friend WithEvents panel_topbar As Panel
        Friend WithEvents button_delete As Button
        Friend WithEvents Label1 As Label
        Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
        Friend WithEvents flowPanel_category As FlowLayoutPanel
        Friend WithEvents timer_reset_image As Timer
        Friend WithEvents panel_back As Panel
        Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
        Friend WithEvents lbl_info As Label
    End Class
End NameSpace