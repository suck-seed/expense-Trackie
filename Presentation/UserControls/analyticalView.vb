Imports System.Data.SQLite
Imports System.Windows.Forms.DataVisualization.Charting
Imports System.Windows.Media
Imports expense_Trackie.Application

Namespace Presentation

    Public Class analyticalView

        Private loggedInUserId As Integer = SessionManager.Instance.CurrentUserId

        ' Now pulls from your DatabaseSetup module
        Private ReadOnly _connStr As String = DatabaseSetup.ConnectionString
        Private _darkMode As Boolean = False

        Private ReadOnly _isYearly As Boolean
        Private ReadOnly _isMonthly As Boolean

        Public Sub New(isYearly As Boolean, isMonthly As Boolean)
            InitializeComponent()
            _isYearly = isYearly
            _isMonthly = isMonthly
        End Sub

        Private Sub analyticalView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            If Not My.Settings.IsLightMode Then
                _darkMode = True
                Me.BackColor = ColorTranslator.FromHtml(My.Settings.darkPanelColor)
            Else
                Me.BackColor = ColorTranslator.FromHtml(My.Settings.lightPanelColor)
            End If

            LoadInformation()
        End Sub

        Public Sub LoadInformation()
            LoadCategoryInfo()
            LoadPieChartData(_isYearly, _isMonthly)
            LoadChartData(_isYearly, _isMonthly)
        End Sub

        '------------------------------------------
        ' Bar‐Chart: total spent per category
        '------------------------------------------
        Private Sub LoadChartData(isYearly As Boolean, isMonthly As Boolean)
            chart_currentMonth.Series.Clear()
            Dim series = New Series("Expenses") With {.ChartType = SeriesChartType.Column}

            ' prepare year & month as strings for SQLite
            Dim yearStr = DateTime.Now.Year.ToString()
            Dim monthStr = DateTime.Now.Month.ToString("00")

            ' Build SQLite‐friendly query
            Dim sql = "
        SELECT c.catName, SUM(e.amount) AS totalSpent, c.color
        FROM expense e
        JOIN category c ON e.catId = c.catId
        WHERE e.userId = @UserId
          AND e.enabled = 1 AND c.enabled = 1
      "

            If isYearly Then
                sql &= " AND strftime('%Y', e.dateAdded) = @YearNum"
            Else
                ' monthly or default
                sql &= " AND strftime('%Y', e.dateAdded) = @YearNum
                 AND strftime('%m', e.dateAdded) = @MonthNum"
            End If

            sql &= " GROUP BY c.catName, c.color;"

            Using conn As New SQLiteConnection(_connStr)
                conn.Open()
                Using cmd As New SQLiteCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@UserId", loggedInUserId)
                    cmd.Parameters.AddWithValue("@YearNum", yearStr)
                    If Not isYearly Then
                        cmd.Parameters.AddWithValue("@MonthNum", monthStr)
                    End If

                    Using rdr = cmd.ExecuteReader()
                        If rdr.HasRows Then
                            While rdr.Read()
                                Dim name = rdr.GetString(0)
                                Dim total = rdr.GetDecimal(1)
                                Dim color = rdr.GetString(2)
                                series.Points.AddXY(name, total)
                                series.Points.Last().Color =
                                  System.Drawing.ColorTranslator.FromHtml(color)
                            End While
                        Else
                            series.Points.AddXY("No Expenses", 0)
                            series.Points(0).AxisLabel = "No Expenses Recorded"
                        End If
                    End Using
                End Using
            End Using

            chart_currentMonth.Series.Add(series)
            With chart_currentMonth.ChartAreas(0)
                .AxisX.Title = "Category Name"
                .AxisY.Title = "Total Spent"
                .AxisX.Interval = 1
                .AxisY.Minimum = 0
                .RecalculateAxesScale()
            End With

            chart_currentMonth.Refresh()
        End Sub

        '------------------------------------------
        ' Pie‐Chart: distribution per category
        '------------------------------------------
        Private Sub LoadPieChartData(isYearly As Boolean, isMonthly As Boolean)
            piechart_monthly.Series.Clear()

            Dim yearStr = DateTime.Now.Year.ToString()
            Dim monthStr = DateTime.Now.Month.ToString("00")

            Dim sql = "
        SELECT c.catName, SUM(e.amount) AS totalSpent, c.color
        FROM expense e
        JOIN category c ON e.catId = c.catId
        WHERE e.userId = @UserId
          AND e.enabled = 1 AND c.enabled = 1
      "

            If isMonthly Then
                sql &= " AND strftime('%Y',e.dateAdded)=@YearNum
                 AND strftime('%m',e.dateAdded)=@MonthNum"
            ElseIf isYearly Then
                sql &= " AND strftime('%Y',e.dateAdded)=@YearNum"
            End If

            sql &= " GROUP BY c.catName, c.color;"

            Dim expenses = New List(Of (Name As String, Total As Decimal, Color As String))()

            Using conn As New SQLiteConnection(_connStr)
                conn.Open()
                Using cmd As New SQLiteCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@UserId", loggedInUserId)
                    cmd.Parameters.AddWithValue("@YearNum", yearStr)
                    If isMonthly Then cmd.Parameters.AddWithValue("@MonthNum", monthStr)

                    Using rdr = cmd.ExecuteReader()
                        While rdr.Read()
                            expenses.Add((
                              rdr.GetString(0),
                              rdr.GetDecimal(1),
                              rdr.GetString(2)
                            ))
                        End While
                    End Using
                End Using
            End Using

            ' if no rows, show a 0‐slice
            If expenses.Count = 0 Then
                expenses.Add(("No Expenses", 0D, "#CCCCCC"))
            End If

            ' sort & populate LiveCharts pie
            Dim pc = New LiveCharts.SeriesCollection()
            For Each e In expenses.OrderByDescending(Function(x) x.Total)
                Dim slice = New LiveCharts.Wpf.PieSeries() With {
                  .Title = e.Name,
                  .Values = New LiveCharts.ChartValues(Of Decimal) From {e.Total},
                  .DataLabels = True,
                  .Fill = New SolidColorBrush(
                                   ColorConverter.ConvertFromString(e.Color)),
                  .Foreground = Brushes.Black,
                  .FontFamily = New FontFamily("IBM Plex Mono"),
                  .FontSize = 9
                }
                pc.Add(slice)
            Next

            piechart_monthly.Series = pc
        End Sub

        Public Sub LoadCategoryInfo()
            Dim m = New CategoryManager()
            m.GenerateCategoryUserControl(fPanel_categoryInsight, _isYearly, _isMonthly)
        End Sub

        ' … rest of your class unchanged …

    End Class
End Namespace
