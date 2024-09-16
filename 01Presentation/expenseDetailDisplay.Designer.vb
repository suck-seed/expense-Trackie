<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class expenseDetailDisplay
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
        Me.txt_amount = New System.Windows.Forms.Label()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.txt_remarks = New System.Windows.Forms.Label()
        Me.txt_time = New System.Windows.Forms.Label()
        Me.generalTable.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'generalTable
        '
        Me.generalTable.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.generalTable.ColumnCount = 1
        Me.generalTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.321131!))
        Me.generalTable.Controls.Add(Me.txt_time, 0, 1)
        Me.generalTable.Controls.Add(Me.txt_remarks, 0, 0)
        Me.generalTable.Dock = System.Windows.Forms.DockStyle.Left
        Me.generalTable.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize
        Me.generalTable.Location = New System.Drawing.Point(0, 0)
        Me.generalTable.Margin = New System.Windows.Forms.Padding(0)
        Me.generalTable.Name = "generalTable"
        Me.generalTable.RowCount = 2
        Me.generalTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.generalTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.generalTable.Size = New System.Drawing.Size(772, 87)
        Me.generalTable.TabIndex = 7
        '
        'txt_amount
        '
        Me.txt_amount.AutoSize = True
        Me.txt_amount.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_amount.Font = New System.Drawing.Font("Cascadia Mono", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_amount.Location = New System.Drawing.Point(3, 0)
        Me.txt_amount.Name = "txt_amount"
        Me.txt_amount.Size = New System.Drawing.Size(150, 87)
        Me.txt_amount.TabIndex = 18
        Me.txt_amount.Text = "Amount"
        Me.txt_amount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.txt_amount, 0, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(772, 0)
        Me.TableLayoutPanel2.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(156, 87)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'txt_remarks
        '
        Me.txt_remarks.AutoSize = True
        Me.txt_remarks.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_remarks.Font = New System.Drawing.Font("Cascadia Mono", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_remarks.Location = New System.Drawing.Point(3, 0)
        Me.txt_remarks.Name = "txt_remarks"
        Me.txt_remarks.Size = New System.Drawing.Size(766, 43)
        Me.txt_remarks.TabIndex = 19
        Me.txt_remarks.Text = "Remarks"
        Me.txt_remarks.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt_time
        '
        Me.txt_time.AutoSize = True
        Me.txt_time.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_time.Font = New System.Drawing.Font("Cascadia Mono", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_time.Location = New System.Drawing.Point(3, 43)
        Me.txt_time.Name = "txt_time"
        Me.txt_time.Size = New System.Drawing.Size(766, 44)
        Me.txt_time.TabIndex = 20
        Me.txt_time.Text = "Time"
        Me.txt_time.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'expenseDetailDisplay
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.Controls.Add(Me.generalTable)
        Me.Name = "expenseDetailDisplay"
        Me.Size = New System.Drawing.Size(928, 87)
        Me.generalTable.ResumeLayout(False)
        Me.generalTable.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents generalTable As TableLayoutPanel
    Friend WithEvents txt_amount As Label
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents txt_remarks As Label
    Friend WithEvents txt_time As Label
End Class
