<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CompareView
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
        Me.table_analysis = New System.Windows.Forms.TableLayoutPanel()
        Me.ElementHost1 = New System.Windows.Forms.Integration.ElementHost()
        Me.piechart_left = New LiveCharts.Wpf.PieChart()
        Me.ElementHost2 = New System.Windows.Forms.Integration.ElementHost()
        Me.piechart_right = New LiveCharts.Wpf.PieChart()
        Me.fPanel_categoryInsight_right = New System.Windows.Forms.FlowLayoutPanel()
        Me.fPanel_categoryInsight_left = New System.Windows.Forms.FlowLayoutPanel()
        Me.table_analysis.SuspendLayout()
        Me.SuspendLayout()
        '
        'table_analysis
        '
        Me.table_analysis.ColumnCount = 2
        Me.table_analysis.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.table_analysis.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.table_analysis.Controls.Add(Me.fPanel_categoryInsight_left, 0, 0)
        Me.table_analysis.Controls.Add(Me.fPanel_categoryInsight_right, 1, 0)
        Me.table_analysis.Controls.Add(Me.ElementHost2, 1, 1)
        Me.table_analysis.Controls.Add(Me.ElementHost1, 0, 1)
        Me.table_analysis.Dock = System.Windows.Forms.DockStyle.Fill
        Me.table_analysis.Location = New System.Drawing.Point(0, 0)
        Me.table_analysis.Name = "table_analysis"
        Me.table_analysis.RowCount = 2
        Me.table_analysis.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.table_analysis.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.table_analysis.Size = New System.Drawing.Size(1269, 967)
        Me.table_analysis.TabIndex = 8
        '
        'ElementHost1
        '
        Me.ElementHost1.BackColor = System.Drawing.Color.Transparent
        Me.ElementHost1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ElementHost1.Location = New System.Drawing.Point(0, 483)
        Me.ElementHost1.Margin = New System.Windows.Forms.Padding(0)
        Me.ElementHost1.Name = "ElementHost1"
        Me.ElementHost1.Padding = New System.Windows.Forms.Padding(10)
        Me.ElementHost1.Size = New System.Drawing.Size(634, 484)
        Me.ElementHost1.TabIndex = 12
        Me.ElementHost1.Text = "ElementHost1"
        Me.ElementHost1.Child = Me.piechart_left
        '
        'ElementHost2
        '
        Me.ElementHost2.BackColor = System.Drawing.Color.Transparent
        Me.ElementHost2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ElementHost2.Location = New System.Drawing.Point(634, 483)
        Me.ElementHost2.Margin = New System.Windows.Forms.Padding(0)
        Me.ElementHost2.Name = "ElementHost2"
        Me.ElementHost2.Padding = New System.Windows.Forms.Padding(10)
        Me.ElementHost2.Size = New System.Drawing.Size(635, 484)
        Me.ElementHost2.TabIndex = 13
        Me.ElementHost2.Text = "ElementHost2"
        Me.ElementHost2.Child = Me.piechart_right
        '
        'fPanel_categoryInsight_right
        '
        Me.fPanel_categoryInsight_right.BackColor = System.Drawing.Color.Transparent
        Me.fPanel_categoryInsight_right.Dock = System.Windows.Forms.DockStyle.Fill
        Me.fPanel_categoryInsight_right.Location = New System.Drawing.Point(637, 3)
        Me.fPanel_categoryInsight_right.Name = "fPanel_categoryInsight_right"
        Me.fPanel_categoryInsight_right.Padding = New System.Windows.Forms.Padding(10)
        Me.fPanel_categoryInsight_right.Size = New System.Drawing.Size(629, 477)
        Me.fPanel_categoryInsight_right.TabIndex = 14
        '
        'fPanel_categoryInsight_left
        '
        Me.fPanel_categoryInsight_left.BackColor = System.Drawing.Color.Transparent
        Me.fPanel_categoryInsight_left.Dock = System.Windows.Forms.DockStyle.Fill
        Me.fPanel_categoryInsight_left.Location = New System.Drawing.Point(3, 3)
        Me.fPanel_categoryInsight_left.Name = "fPanel_categoryInsight_left"
        Me.fPanel_categoryInsight_left.Padding = New System.Windows.Forms.Padding(10)
        Me.fPanel_categoryInsight_left.Size = New System.Drawing.Size(628, 477)
        Me.fPanel_categoryInsight_left.TabIndex = 15
        '
        'CompareView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.table_analysis)
        Me.Name = "CompareView"
        Me.Size = New System.Drawing.Size(1269, 967)
        Me.table_analysis.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents table_analysis As TableLayoutPanel
    Friend WithEvents fPanel_categoryInsight_left As FlowLayoutPanel
    Friend WithEvents fPanel_categoryInsight_right As FlowLayoutPanel
    Friend WithEvents ElementHost2 As Integration.ElementHost
    Friend piechart_right As LiveCharts.Wpf.PieChart
    Friend WithEvents ElementHost1 As Integration.ElementHost
    Friend piechart_left As LiveCharts.Wpf.PieChart
End Class
