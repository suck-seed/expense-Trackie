<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class monthExpense
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.lbl_day = New System.Windows.Forms.Label()
        Me.tpanel_expense = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.lbl_day, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel1.Font = New System.Drawing.Font("IBM Plex Mono", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(190, 31)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'lbl_day
        '
        Me.lbl_day.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_day.AutoSize = True
        Me.lbl_day.Font = New System.Drawing.Font("Cascadia Mono", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_day.Location = New System.Drawing.Point(88, 7)
        Me.lbl_day.Name = "lbl_day"
        Me.lbl_day.Size = New System.Drawing.Size(14, 16)
        Me.lbl_day.TabIndex = 0
        Me.lbl_day.Text = "d"
        '
        'tpanel_expense
        '
        Me.tpanel_expense.BackColor = System.Drawing.Color.Transparent
        Me.tpanel_expense.ColumnCount = 1
        Me.tpanel_expense.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tpanel_expense.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tpanel_expense.Location = New System.Drawing.Point(0, 31)
        Me.tpanel_expense.Margin = New System.Windows.Forms.Padding(0)
        Me.tpanel_expense.Name = "tpanel_expense"
        Me.tpanel_expense.RowCount = 1
        Me.tpanel_expense.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tpanel_expense.Size = New System.Drawing.Size(190, 159)
        Me.tpanel_expense.TabIndex = 1
        '
        'monthExpense
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.tpanel_expense)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Margin = New System.Windows.Forms.Padding(2, 0, 1, 0)
        Me.Name = "monthExpense"
        Me.Size = New System.Drawing.Size(190, 190)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents lbl_day As Label
    Friend WithEvents tpanel_expense As TableLayoutPanel
End Class
