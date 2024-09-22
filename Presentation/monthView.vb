Imports expense_Trackie.Application

Namespace Presentation

    Public Class MonthView

        Dim _currentDate As DateTime = DateTime.Now


#Region " load form "

        Dim _dayView As DayView

        Public Sub New(ByRef dayViewInst As DayView)

            InitializeComponent()
            _dayView = dayViewInst

        End Sub



        Private Sub monthView_Load(sender As Object, e As EventArgs) Handles MyBase.Load

            ' setting display date
            DisplayInformation()



        End Sub

#End Region


#Region " update displayed information "



        ' reflecting changes in information
        Public Sub DisplayInformation()

            lbl_year.Text = _currentDate.ToString("yyyy")
            lbl_year.Text = _currentDate.ToString("MMM")
            lbl_total_amount.Text = GetTotal()
            loadDays(AddressOf OnDateClick)

        End Sub

#End Region



#Region " get total "



        ' db ko kam
        Private Function GetTotal() As Decimal

            Dim expenseManager As New ExpenseManager()
            Return expenseManager.GetTotalOfMonth(_currentDate)

        End Function
#End Region



#Region " navigation "


        Private Sub btn_previous_Click(sender As Object, e As EventArgs) Handles btn_previous.Click

            _currentDate = _currentDate.AddMonths(-1)

            'updating the date and total
            DisplayInformation()

        End Sub

        Private Sub btn_next_Click(sender As Object, e As EventArgs) Handles btn_next.Click

            _currentDate = _currentDate.AddMonths(1)

            'updating the date and total
            DisplayInformation()

        End Sub
#End Region


        Public Sub loadDays(handler As Action(Of DateTime))

            'clear previous controls
            tpanel_day.SuspendLayout()
            tpanel_day.Controls.Clear()


            ' seting values
            Dim year As Integer = _currentDate.Year
            Dim month As Integer = _currentDate.Month

            Dim StartOfTheMonth As New DateTime(year, month, 1)
            Dim DaysInMonth As Integer = DateTime.DaysInMonth(year, month)
            Dim StartDayOfWeek As Integer = Convert.ToInt32(StartOfTheMonth.DayOfWeek.ToString("d"))


            Dim currentRow As Integer = 0
            Dim currentColumn As Integer = StartDayOfWeek
            Dim expenseManager As New ExpenseManager()


            ' Add empty placeholders for the days before the first day of the month
            For i As Integer = 1 To StartDayOfWeek - 1 Step 1

                Dim md As New monthExpense("")
                tpanel_day.Controls.Add(md)

            Next


            ' Adding actual days with event
            For i As Integer = 1 To DaysInMonth Step 1


                Dim currentDate As New DateTime(year, month, i)


                ' instance of dateDisplay usercontrol
                Dim dateDisplay As New monthExpense(i.ToString())

                dateDisplay.Width = lbl_size.Width

                dateDisplay.Tag = currentDate
                dateDisplay.Dock = DockStyle.Fill


                ' loading the expense on it (2/3 expense)
                expenseManager.LoadMonthExpenses(dateDisplay.tpanel_expense, currentDate)




                'event handler
                AddHandler dateDisplay.lbl_day.Click, Sub() handler(currentDate)


                ' Add the control to the TableLayoutPanel
                tpanel_day.Controls.Add(dateDisplay, currentColumn, currentRow)

                ' Move to the next column
                currentColumn += 1

                ' If we reach the end of the row, reset column and move to the next row
                If currentColumn >= 7 Then
                    currentColumn = 0
                    currentRow += 1
                End If


            Next


            tpanel_day.ResumeLayout(True)



        End Sub




        Public Sub OnDateClick(ByVal pressedDate As DateTime)

            MainWindow.radio_day_view.Checked = True
            MainWindow.radio_month_view.Checked = False
            MainWindow.radio_home.Checked = True

            _dayView._currentDate = pressedDate
            _dayView.DisplayInformation()

        End Sub


    End Class
End NameSpace