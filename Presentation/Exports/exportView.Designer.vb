<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class exportView
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
        Me.components = New System.ComponentModel.Container()
        Me.timer_reset_image = New System.Windows.Forms.Timer(Me.components)
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.radio_7days = New System.Windows.Forms.RadioButton()
        Me.radio_14days = New System.Windows.Forms.RadioButton()
        Me.radio_30days = New System.Windows.Forms.RadioButton()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'timer_reset_image
        '
        Me.timer_reset_image.Interval = 120
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(192, 163)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(693, 468)
        Me.DataGridView1.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(382, 660)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(128, 64)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Type"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(562, 660)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(128, 64)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Type"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.TableLayoutPanel1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1082, 53)
        Me.Panel1.TabIndex = 3
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1082, 53)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.TableLayoutPanel2.ColumnCount = 3
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel2.Controls.Add(Me.radio_30days, 2, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.radio_14days, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.radio_7days, 0, 0)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(346, 47)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'radio_7days
        '
        Me.radio_7days.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.radio_7days.Appearance = System.Windows.Forms.Appearance.Button
        Me.radio_7days.BackColor = System.Drawing.Color.Linen
        Me.radio_7days.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.radio_7days.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.radio_7days.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.radio_7days.Font = New System.Drawing.Font("IBM Plex Mono", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radio_7days.Location = New System.Drawing.Point(13, 5)
        Me.radio_7days.Name = "radio_7days"
        Me.radio_7days.Size = New System.Drawing.Size(90, 36)
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
        Me.radio_14days.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.radio_14days.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.radio_14days.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.radio_14days.Font = New System.Drawing.Font("IBM Plex Mono", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radio_14days.Location = New System.Drawing.Point(128, 5)
        Me.radio_14days.Name = "radio_14days"
        Me.radio_14days.Size = New System.Drawing.Size(90, 36)
        Me.radio_14days.TabIndex = 1
        Me.radio_14days.TabStop = True
        Me.radio_14days.Text = "14 days"
        Me.radio_14days.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.radio_14days.UseVisualStyleBackColor = True
        '
        'radio_30days
        '
        Me.radio_30days.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.radio_30days.Appearance = System.Windows.Forms.Appearance.Button
        Me.radio_30days.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.radio_30days.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.radio_30days.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.radio_30days.Font = New System.Drawing.Font("IBM Plex Mono", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radio_30days.Location = New System.Drawing.Point(243, 5)
        Me.radio_30days.Name = "radio_30days"
        Me.radio_30days.Size = New System.Drawing.Size(90, 36)
        Me.radio_30days.TabIndex = 2
        Me.radio_30days.TabStop = True
        Me.radio_30days.Text = "30 days"
        Me.radio_30days.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.radio_30days.UseVisualStyleBackColor = True
        '
        'exportView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.DoubleBuffered = True
        Me.Name = "exportView"
        Me.Size = New System.Drawing.Size(1082, 784)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents timer_reset_image As Timer
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents radio_30days As RadioButton
    Friend WithEvents radio_14days As RadioButton
    Friend WithEvents radio_7days As RadioButton
End Class
