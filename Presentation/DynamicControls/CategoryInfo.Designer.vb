<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CategoryInfo
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
        Me.generalTable = New System.Windows.Forms.TableLayoutPanel()
        Me.lbl_category_name = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.lbl_amount = New System.Windows.Forms.Label()
        Me.lbl_number = New System.Windows.Forms.Label()
        Me.generalTable.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'generalTable
        '
        Me.generalTable.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.generalTable.BackColor = System.Drawing.Color.Transparent
        Me.generalTable.ColumnCount = 2
        Me.generalTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 77.19299!))
        Me.generalTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.80702!))
        Me.generalTable.Controls.Add(Me.lbl_category_name, 0, 0)
        Me.generalTable.Controls.Add(Me.lbl_number, 1, 0)
        Me.generalTable.Dock = System.Windows.Forms.DockStyle.Top
        Me.generalTable.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize
        Me.generalTable.Location = New System.Drawing.Point(0, 0)
        Me.generalTable.Margin = New System.Windows.Forms.Padding(1)
        Me.generalTable.Name = "generalTable"
        Me.generalTable.RowCount = 1
        Me.generalTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.generalTable.Size = New System.Drawing.Size(185, 52)
        Me.generalTable.TabIndex = 9
        '
        'lbl_category_name
        '
        Me.lbl_category_name.AutoEllipsis = True
        Me.lbl_category_name.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_category_name.Font = New System.Drawing.Font("IBM Plex Mono", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_category_name.Location = New System.Drawing.Point(3, 0)
        Me.lbl_category_name.Name = "lbl_category_name"
        Me.lbl_category_name.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.lbl_category_name.Size = New System.Drawing.Size(136, 52)
        Me.lbl_category_name.TabIndex = 19
        Me.lbl_category_name.Text = "Food"
        Me.lbl_category_name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.lbl_amount, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 52)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(1)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(185, 48)
        Me.TableLayoutPanel1.TabIndex = 10
        '
        'lbl_amount
        '
        Me.lbl_amount.AutoSize = True
        Me.lbl_amount.BackColor = System.Drawing.Color.Transparent
        Me.lbl_amount.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_amount.Font = New System.Drawing.Font("IBM Plex Mono SemiBold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_amount.Location = New System.Drawing.Point(3, 0)
        Me.lbl_amount.Name = "lbl_amount"
        Me.lbl_amount.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.lbl_amount.Size = New System.Drawing.Size(179, 48)
        Me.lbl_amount.TabIndex = 20
        Me.lbl_amount.Text = "10000"
        Me.lbl_amount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl_number
        '
        Me.lbl_number.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_number.Font = New System.Drawing.Font("IBM Plex Mono", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_number.Location = New System.Drawing.Point(145, 0)
        Me.lbl_number.Name = "lbl_number"
        Me.lbl_number.Size = New System.Drawing.Size(37, 52)
        Me.lbl_number.TabIndex = 20
        Me.lbl_number.Text = "5"
        Me.lbl_number.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CategoryInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.generalTable)
        Me.Margin = New System.Windows.Forms.Padding(10)
        Me.Name = "CategoryInfo"
        Me.Size = New System.Drawing.Size(185, 100)
        Me.generalTable.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents generalTable As TableLayoutPanel
    Friend WithEvents lbl_category_name As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents lbl_amount As Label
    Friend WithEvents lbl_number As Label
End Class
