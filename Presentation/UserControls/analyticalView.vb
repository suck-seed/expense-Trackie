Imports System.Configuration
Imports System.Data.SqlClient
Imports System.Windows.Forms.DataVisualization.Charting
Imports System.Windows.Media
Imports expense_Trackie.Application

Namespace Presentation
    Public Class analyticalView



        Private loggedInUserId As Integer = SessionManager.Instance.CurrentUserId
        ReadOnly _connectionString As String = ConfigurationManager.ConnectionStrings("expenseTrackie").ConnectionString
        Dim _darkMode As Boolean = False


        Dim _isYearly As Boolean
        Dim _isMonthly As Boolean

#Region " month / year "

        'Public Sub monthSelected(sender As Object, e As EventArgs) Handles 
        Public Sub New(ByVal isYearly As Boolean, ByVal isMonthly As Boolean)

            InitializeComponent()
            'MessageBox.Show("isYearly :" & isYearly & "  isMonthly :" & isMonthly)

            _isYearly = isYearly
            _isMonthly = isMonthly


        End Sub

        'Public Sub monthSelected(sender As Object, e As EventArgs) Handles 

#End Region



#Region " load "

        Private Sub analyticalView_Load(sender As Object, e As EventArgs) Handles MyBase.Load

            If My.Settings.IsLightMode = False Then
                _darkMode = True
                Me.BackColor = ColorTranslator.FromHtml(My.Settings.darkPanelColor)
            Else
                Me.BackColor = ColorTranslator.FromHtml(My.Settings.lightPanelColor)
            End If

            LoadInformation()


        End Sub

#End Region




#Region " load information "

        Public Sub LoadInformation()



            LoadCategoryInfo()
            LoadPieChartData(_isYearly, _isMonthly)
            LoadChartData(_isYearly, _isMonthly)
        End Sub

#End Region

#Region " barchart "


        Private Sub LoadChartData(isYearly As Boolean, isMonthly As Boolean)
            ' Clear the chart
            chart_currentMonth.Series.Clear()

            ' Create a new series for the chart
            Dim series As New Series("Expenses")
            series.ChartType = SeriesChartType.Column

            ' Determine the current year and month
            Dim currentYear As Integer = DateTime.Now.Year
            Dim currentMonth As Integer = DateTime.Now.Month

            ' SQL Query for monthly or yearly data
            Dim query As String

            If isYearly Then
                ' Yearly data query
                query = "SELECT c.catName, SUM(e.amount) AS totalSpent, c.color " &
            "FROM expense e " &
            "JOIN category c ON e.catId = c.catId " &
            "WHERE e.userId = @UserId " &
            "AND YEAR(e.dateAdded) = @YearNumber " &
            "AND e.enabled = 1 AND c.enabled = 1 " &
            "GROUP BY c.catName, c.color;"
            ElseIf isMonthly Then
                ' Monthly data query
                query = "SELECT c.catName, SUM(e.amount) AS totalSpent, c.color " &
            "FROM expense e " &
            "JOIN category c ON e.catId = c.catId " &
            "WHERE e.userId = @UserId " &
            "AND MONTH(e.dateAdded) = @MonthNumber " &
            "AND YEAR(e.dateAdded) = @YearNumber " &
            "AND e.enabled = 1 AND c.enabled = 1 " &
            "GROUP BY c.catName, c.color;"
            Else
                ' Default case: Display current month and year if neither isYearly nor isMonthly is true
                query = "SELECT c.catName, SUM(e.amount) AS totalSpent, c.color " &
            "FROM expense e " &
            "JOIN category c ON e.catId = c.catId " &
            "WHERE e.userId = @UserId " &
            "AND MONTH(e.dateAdded) = @MonthNumber " &
            "AND YEAR(e.dateAdded) = @YearNumber " &
            "AND e.enabled = 1 AND c.enabled = 1 " &
            "GROUP BY c.catName, c.color;"
            End If

            ' Database connection string (replace with your details)
            Using connection As New SqlConnection(_connectionString)
                Using command As New SqlCommand(query, connection)
                    ' Add parameters to the query
                    command.Parameters.AddWithValue("@UserId", loggedInUserId)
                    command.Parameters.AddWithValue("@YearNumber", currentYear)

                    ' If not a yearly view, add the month parameter
                    If isMonthly OrElse Not isYearly Then
                        command.Parameters.AddWithValue("@MonthNumber", currentMonth)
                    End If

                    ' Open the connection
                    connection.Open()

                    ' Execute the query and read the data
                    Using reader As SqlDataReader = command.ExecuteReader()
                        If reader.HasRows Then
                            ' Process the data
                            While reader.Read()
                                Dim categoryName As String = reader("catName").ToString()
                                Dim totalSpent As Decimal = Convert.ToDecimal(reader("totalSpent"))
                                Dim categoryColor As String = reader("color").ToString()

                                ' Add data point to the series
                                series.Points.AddXY(categoryName, totalSpent)

                                ' Set the color for each data point
                                Dim pointIndex As Integer = series.Points.Count - 1
                                series.Points(pointIndex).Color = System.Drawing.ColorTranslator.FromHtml(categoryColor)
                            End While
                        Else
                            ' No expenses found for this user in this month/year, add a placeholder bar
                            series.Points.AddXY("No Expenses", 0)
                            series.Points(0).AxisLabel = "No Expenses Recorded"
                        End If
                    End Using
                End Using
            End Using

            ' Add the series to the chart
            chart_currentMonth.Series.Add(series)

            ' Customize chart axes
            chart_currentMonth.ChartAreas(0).AxisX.Title = "Category Name"
            chart_currentMonth.ChartAreas(0).AxisY.Title = "Total Spent"
            chart_currentMonth.ChartAreas(0).AxisX.Interval = 1 ' Ensure categories are spaced out
            chart_currentMonth.ChartAreas(0).RecalculateAxesScale()

            ' Ensure the Y-axis shows at least 0
            chart_currentMonth.ChartAreas(0).AxisY.Minimum = 0

            ' Refresh the chart to reflect the changes
            chart_currentMonth.Refresh()
        End Sub

#End Region




#Region " category Info Load"

        Public Sub LoadCategoryInfo()

            Dim categoryManager As New CategoryManager
            categoryManager.GenerateCategoryUserControl(fPanel_categoryInsight, _isYearly, _isMonthly)

        End Sub
#End Region


#Region " monthly pie chart"

        Dim currentMonthPieChart As Integer = DateTime.Now.Month
        Dim currentYearPieChart As Integer = DateTime.Now.Year

        Private Sub LoadPieChartData(ByVal isYearly As Boolean, ByVal isMonthly As Boolean)
            ' Clear existing data points
            piechart_monthly.Series.Clear()

            ' SQL query base
            Dim query As String = "SELECT c.catName, SUM(e.amount) AS totalSpent, c.color " &
                  "FROM expense e " &
                  "JOIN category c ON e.catId = c.catId " &
                  "WHERE e.userId = @UserId " &
                  "AND e.enabled = 1 AND c.enabled = 1 "

            ' Modify the query based on whether it's monthly or yearly
            If isMonthly Then
                query &= "AND MONTH(e.dateAdded) = @MonthNumber AND YEAR(e.dateAdded) = @YearNumber "
            ElseIf isYearly Then
                query &= "AND YEAR(e.dateAdded) = @YearNumber "
            End If

            query &= "GROUP BY c.catName, c.color;"

            ' Connect to the database and execute the query
            Using connection As New SqlConnection(_connectionString)


                Using command As New SqlCommand(query, connection)

                    command.Parameters.AddWithValue("@UserId", loggedInUserId)

                    ' Add month and year parameters based on isMonthly or isYearly
                    If isMonthly Then
                        command.Parameters.AddWithValue("@MonthNumber", currentMonthPieChart)
                        command.Parameters.AddWithValue("@YearNumber", currentYearPieChart)
                    ElseIf isYearly Then
                        command.Parameters.AddWithValue("@YearNumber", currentYearPieChart)
                    End If

                    connection.Open()



                    Using reader As SqlDataReader = command.ExecuteReader()


                        If reader.HasRows Then

                            Dim expenses As New List(Of (CategoryName As String, TotalSpent As Decimal, Color As String))()


                            While reader.Read()
                                Dim categoryName As String = reader("catName").ToString()
                                Dim totalSpent As Decimal = Convert.ToDecimal(reader("totalSpent"))
                                Dim categoryColor As String = reader("color").ToString()

                                ' Add the data to the list
                                expenses.Add((categoryName, totalSpent, categoryColor))
                            End While



                            ' Sort the list by totalSpent in descending order
                            expenses = expenses.OrderByDescending(Function(exp) exp.TotalSpent).ToList()



                            Dim pieSeries As New LiveCharts.SeriesCollection()



                            ' Create PieSeries from sorted expenses
                            For Each expense In expenses
                                Dim pieSlice As New LiveCharts.Wpf.PieSeries() With {
                                        .Title = expense.CategoryName,
                                        .Values = New LiveCharts.ChartValues(Of Decimal) From {expense.TotalSpent},
                                        .DataLabels = True,
                                        .Fill = New SolidColorBrush(System.Windows.Media.ColorConverter.ConvertFromString(expense.Color)),
                                        .Foreground = System.Windows.Media.Brushes.Black, ' Sets text color to black
                                        .FontFamily = New System.Windows.Media.FontFamily("IBM Plex Mono"), ' Sets font family
                                        .FontSize = 9
                                }

                                ' Add the pie slice to the series
                                pieSeries.Add(pieSlice)
                            Next



                            ' Add the series to the pie chart
                            piechart_monthly.Series = pieSeries
                        Else



                            ' No expenses found for the current period (month or year)
                            Dim emptySeries As New LiveCharts.Wpf.PieSeries() With {
                                        .Title = "No Expenses",
                                        .Values = New LiveCharts.ChartValues(Of Decimal) From {0},
                                        .DataLabels = True
                                 }
                            piechart_monthly.Series = New LiveCharts.SeriesCollection() From {emptySeries}




                        End If

                    End Using

                End Using

            End Using

        End Sub



#End Region




#Region " timer for buttons "

        Private Sub timer_revertImage_Tick(sender As Object, e As EventArgs) Handles timer_reset_image.Tick
            ' Revert the image back to right
            If My.Settings.IsLightMode = False Then


                MainWindow.radio_analyze_monthly.Image = My.Resources.monthWhite
                MainWindow.radio_analysis_year.Image = My.Resources.yearAnalysisWhite



            Else



                MainWindow.radio_analyze_monthly.Image = My.Resources.monthLight
                MainWindow.radio_analysis_year.Image = My.Resources.yearAnalysis


            End If





            ' Stop the timer as the image has been reverted
            timer_reset_image.Stop()
        End Sub

#End Region



#Region " to resolve flicker "
        Protected Overrides ReadOnly Property CreateParams() As CreateParams
            Get
                Dim cp As CreateParams = MyBase.CreateParams
                cp.ExStyle = cp.ExStyle Or &H2000000
                Return cp
            End Get
        End Property

#End Region

    End Class
End Namespace