Namespace Presentation
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class analyticalView
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
            Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
            Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
            Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
            Me.ExpenseTrackieDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.ExpenseTrackieDataSet = New expense_Trackie.expenseTrackieDataSet()
            Me.table_analysis = New System.Windows.Forms.TableLayoutPanel()
            Me.ElementHost1 = New System.Windows.Forms.Integration.ElementHost()
            Me.piechart_monthly = New LiveCharts.Wpf.PieChart()
            Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
            Me.fPanel_categoryInsight = New System.Windows.Forms.FlowLayoutPanel()
            Me.timer_reset_image = New System.Windows.Forms.Timer(Me.components)
            Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
            Me.chart_currentMonth = New System.Windows.Forms.DataVisualization.Charting.Chart()
            CType(Me.ExpenseTrackieDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ExpenseTrackieDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.table_analysis.SuspendLayout()
            Me.TableLayoutPanel2.SuspendLayout()
            Me.TableLayoutPanel1.SuspendLayout()
            CType(Me.chart_currentMonth, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'ExpenseTrackieDataSetBindingSource
            '
            Me.ExpenseTrackieDataSetBindingSource.DataSource = Me.ExpenseTrackieDataSet
            Me.ExpenseTrackieDataSetBindingSource.Position = 0
            '
            'ExpenseTrackieDataSet
            '
            Me.ExpenseTrackieDataSet.DataSetName = "expenseTrackieDataSet"
            Me.ExpenseTrackieDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
            '
            'table_analysis
            '
            Me.table_analysis.ColumnCount = 2
            Me.table_analysis.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
            Me.table_analysis.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
            Me.table_analysis.Controls.Add(Me.ElementHost1, 1, 0)
            Me.table_analysis.Controls.Add(Me.TableLayoutPanel2, 0, 0)
            Me.table_analysis.Dock = System.Windows.Forms.DockStyle.Top
            Me.table_analysis.Location = New System.Drawing.Point(0, 0)
            Me.table_analysis.Name = "table_analysis"
            Me.table_analysis.RowCount = 1
            Me.table_analysis.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
            Me.table_analysis.Size = New System.Drawing.Size(1269, 486)
            Me.table_analysis.TabIndex = 7
            '
            'ElementHost1
            '
            Me.ElementHost1.BackColor = System.Drawing.Color.Transparent
            Me.ElementHost1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.ElementHost1.Location = New System.Drawing.Point(634, 0)
            Me.ElementHost1.Margin = New System.Windows.Forms.Padding(0)
            Me.ElementHost1.Name = "ElementHost1"
            Me.ElementHost1.Padding = New System.Windows.Forms.Padding(10)
            Me.ElementHost1.Size = New System.Drawing.Size(635, 486)
            Me.ElementHost1.TabIndex = 8
            Me.ElementHost1.Text = "ElementHost1"
            Me.ElementHost1.Child = Me.piechart_monthly
            '
            'TableLayoutPanel2
            '
            Me.TableLayoutPanel2.ColumnCount = 1
            Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
            Me.TableLayoutPanel2.Controls.Add(Me.fPanel_categoryInsight, 0, 0)
            Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
            Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 3)
            Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
            Me.TableLayoutPanel2.RowCount = 1
            Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.77568!))
            Me.TableLayoutPanel2.Size = New System.Drawing.Size(628, 480)
            Me.TableLayoutPanel2.TabIndex = 9
            '
            'fPanel_categoryInsight
            '
            Me.fPanel_categoryInsight.BackColor = System.Drawing.Color.Transparent
            Me.fPanel_categoryInsight.Dock = System.Windows.Forms.DockStyle.Fill
            Me.fPanel_categoryInsight.Location = New System.Drawing.Point(3, 3)
            Me.fPanel_categoryInsight.Name = "fPanel_categoryInsight"
            Me.fPanel_categoryInsight.Padding = New System.Windows.Forms.Padding(10)
            Me.fPanel_categoryInsight.Size = New System.Drawing.Size(622, 474)
            Me.fPanel_categoryInsight.TabIndex = 10
            '
            'timer_reset_image
            '
            Me.timer_reset_image.Interval = 120
            '
            'TableLayoutPanel1
            '
            Me.TableLayoutPanel1.ColumnCount = 1
            Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
            Me.TableLayoutPanel1.Controls.Add(Me.chart_currentMonth, 0, 0)
            Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 486)
            Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
            Me.TableLayoutPanel1.RowCount = 1
            Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
            Me.TableLayoutPanel1.Size = New System.Drawing.Size(1269, 481)
            Me.TableLayoutPanel1.TabIndex = 8
            '
            'chart_currentMonth
            '
            Me.chart_currentMonth.BackColor = System.Drawing.Color.Transparent
            Me.chart_currentMonth.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Center
            Me.chart_currentMonth.BorderlineColor = System.Drawing.Color.Transparent
            ChartArea1.Name = "ChartArea1"
            Me.chart_currentMonth.ChartAreas.Add(ChartArea1)
            Me.chart_currentMonth.DataSource = Me.ExpenseTrackieDataSetBindingSource
            Me.chart_currentMonth.Dock = System.Windows.Forms.DockStyle.Fill
            Legend1.Name = "Legend1"
            Me.chart_currentMonth.Legends.Add(Legend1)
            Me.chart_currentMonth.Location = New System.Drawing.Point(3, 3)
            Me.chart_currentMonth.Name = "chart_currentMonth"
            Me.chart_currentMonth.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel
            Series1.ChartArea = "ChartArea1"
            Series1.Legend = "Legend1"
            Series1.Name = "Series1"
            Me.chart_currentMonth.Series.Add(Series1)
            Me.chart_currentMonth.Size = New System.Drawing.Size(1263, 475)
            Me.chart_currentMonth.TabIndex = 1
            Me.chart_currentMonth.Text = "Chart1"
            '
            'analyticalView
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.TableLayoutPanel1)
            Me.Controls.Add(Me.table_analysis)
            Me.DoubleBuffered = True
            Me.Margin = New System.Windows.Forms.Padding(0)
            Me.Name = "analyticalView"
            Me.Size = New System.Drawing.Size(1269, 967)
            CType(Me.ExpenseTrackieDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ExpenseTrackieDataSet, System.ComponentModel.ISupportInitialize).EndInit()
            Me.table_analysis.ResumeLayout(False)
            Me.TableLayoutPanel2.ResumeLayout(False)
            Me.TableLayoutPanel1.ResumeLayout(False)
            CType(Me.chart_currentMonth, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents ExpenseTrackieDataSetBindingSource As BindingSource
        Friend WithEvents ExpenseTrackieDataSet As expenseTrackieDataSet
        Friend WithEvents table_analysis As TableLayoutPanel
        Friend WithEvents ElementHost1 As Integration.ElementHost
        Friend piechart_monthly As LiveCharts.Wpf.PieChart
        Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
        Friend WithEvents fPanel_categoryInsight As FlowLayoutPanel
        Friend WithEvents timer_reset_image As Timer
        Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
        Friend WithEvents chart_currentMonth As DataVisualization.Charting.Chart
    End Class
End NameSpace