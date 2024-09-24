Namespace Presentation
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class ExpenseDetailDisplay
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
            Me.lbl_time = New System.Windows.Forms.Label()
            Me.lbl_remarks = New System.Windows.Forms.Label()
            Me.lbl_amount = New System.Windows.Forms.Label()
            Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
            Me.generalTable.SuspendLayout()
            Me.TableLayoutPanel2.SuspendLayout()
            Me.SuspendLayout()
            '
            'generalTable
            '
            Me.generalTable.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
            Me.generalTable.BackColor = System.Drawing.Color.Transparent
            Me.generalTable.ColumnCount = 1
            Me.generalTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.321131!))
            Me.generalTable.Controls.Add(Me.lbl_time, 0, 1)
            Me.generalTable.Controls.Add(Me.lbl_remarks, 0, 0)
            Me.generalTable.Dock = System.Windows.Forms.DockStyle.Left
            Me.generalTable.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize
            Me.generalTable.Location = New System.Drawing.Point(0, 0)
            Me.generalTable.Margin = New System.Windows.Forms.Padding(0)
            Me.generalTable.Name = "generalTable"
            Me.generalTable.RowCount = 2
            Me.generalTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
            Me.generalTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
            Me.generalTable.Size = New System.Drawing.Size(772, 88)
            Me.generalTable.TabIndex = 7
            '
            'lbl_time
            '
            Me.lbl_time.AutoSize = True
            Me.lbl_time.Dock = System.Windows.Forms.DockStyle.Fill
            Me.lbl_time.Font = New System.Drawing.Font("IBM Plex Mono", 9.0!)
            Me.lbl_time.Location = New System.Drawing.Point(3, 44)
            Me.lbl_time.Name = "lbl_time"
            Me.lbl_time.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
            Me.lbl_time.Size = New System.Drawing.Size(766, 44)
            Me.lbl_time.TabIndex = 20
            Me.lbl_time.Text = "Time"
            Me.lbl_time.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'lbl_remarks
            '
            Me.lbl_remarks.AutoSize = True
            Me.lbl_remarks.Dock = System.Windows.Forms.DockStyle.Fill
            Me.lbl_remarks.Font = New System.Drawing.Font("IBM Plex Mono", 12.0!)
            Me.lbl_remarks.Location = New System.Drawing.Point(3, 0)
            Me.lbl_remarks.Name = "lbl_remarks"
            Me.lbl_remarks.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
            Me.lbl_remarks.Size = New System.Drawing.Size(766, 44)
            Me.lbl_remarks.TabIndex = 19
            Me.lbl_remarks.Text = "Remarks"
            Me.lbl_remarks.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'lbl_amount
            '
            Me.lbl_amount.AutoSize = True
            Me.lbl_amount.BackColor = System.Drawing.Color.Transparent
            Me.lbl_amount.Dock = System.Windows.Forms.DockStyle.Fill
            Me.lbl_amount.Font = New System.Drawing.Font("IBM Plex Mono SemiBold", 16.0!, System.Drawing.FontStyle.Bold)
            Me.lbl_amount.Location = New System.Drawing.Point(3, 0)
            Me.lbl_amount.Name = "lbl_amount"
            Me.lbl_amount.Size = New System.Drawing.Size(150, 88)
            Me.lbl_amount.TabIndex = 18
            Me.lbl_amount.Text = "Amount"
            Me.lbl_amount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'TableLayoutPanel2
            '
            Me.TableLayoutPanel2.ColumnCount = 1
            Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
            Me.TableLayoutPanel2.Controls.Add(Me.lbl_amount, 0, 0)
            Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Right
            Me.TableLayoutPanel2.Location = New System.Drawing.Point(770, 0)
            Me.TableLayoutPanel2.Margin = New System.Windows.Forms.Padding(0)
            Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
            Me.TableLayoutPanel2.RowCount = 1
            Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
            Me.TableLayoutPanel2.Size = New System.Drawing.Size(156, 88)
            Me.TableLayoutPanel2.TabIndex = 0
            '
            'ExpenseDetailDisplay
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.Transparent
            Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Controls.Add(Me.TableLayoutPanel2)
            Me.Controls.Add(Me.generalTable)
            Me.MinimumSize = New System.Drawing.Size(900, 90)
            Me.Name = "ExpenseDetailDisplay"
            Me.Size = New System.Drawing.Size(926, 88)
            Me.generalTable.ResumeLayout(False)
            Me.generalTable.PerformLayout()
            Me.TableLayoutPanel2.ResumeLayout(False)
            Me.TableLayoutPanel2.PerformLayout()
            Me.ResumeLayout(False)

        End Sub

        Friend WithEvents generalTable As TableLayoutPanel
        Friend WithEvents lbl_amount As Label
        Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
        Friend WithEvents lbl_remarks As Label
        Friend WithEvents lbl_time As Label
    End Class
End NameSpace