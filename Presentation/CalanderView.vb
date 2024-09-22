Imports expense_Trackie.Application
Imports expense_Trackie.Presentation

Public Class CalanderView


    Dim _currentDate As DateTime = DateTime.Now

#Region " new / load"

    Dim _dayView As DayView

    Public Sub New(ByRef dayViewInst As DayView)

        InitializeComponent()

        _dayView = dayViewInst
        DisplayInformation()

    End Sub


    Private Sub CalanderView_Load(sender As Object, e As EventArgs) Handles Me.Load
        DisplayInformation()
    End Sub


#End Region




    Public Sub DisplayInformation()


        lbl_month.Text = _currentDate.ToString("MMM")
        lbl_year.Text = _currentDate.ToString("yyyy")


        ShowDays(AddressOf DateClicked)



    End Sub




#Region " navigation "


    Private Sub month_previous_Click(sender As Object, e As EventArgs) Handles month_previous.Click

        fpanel_dates.Controls.Clear()

        'decreasing the date by 1
        _currentDate = _currentDate.AddMonths(-1)
        DisplayInformation()


    End Sub

    Private Sub month_next_Click(sender As Object, e As EventArgs) Handles month_next.Click

        fpanel_dates.Controls.Clear()

        _currentDate = _currentDate.AddMonths(1)
        DisplayInformation()

    End Sub

#End Region





#Region " showing days "

    Public Sub ShowDays(handler As Action(Of DateTime))


        'clear previous controls
        fpanel_dates.SuspendLayout()
        fpanel_dates.Controls.Clear()


        ' seting values
        Dim year As Integer = _currentDate.Year
        Dim month As Integer = _currentDate.Month

        Dim StartOfTheMonth As New DateTime(year, month, 1)
        Dim DaysInMonth As Integer = DateTime.DaysInMonth(year, month)
        Dim StartDayOfWeek As Integer = Convert.ToInt32(StartOfTheMonth.DayOfWeek.ToString("d"))



        ' Add empty placeholders for the days before the first day of the month
        For i As Integer = 1 To StartDayOfWeek - 1 Step 1

            Dim md As New monthDate("")
            fpanel_dates.Controls.Add(md)

        Next


        ' Adding actual days with event
        For i As Integer = 1 To DaysInMonth Step 1


            Dim currentDate As New DateTime(year, month, i)


            ' instance of dateDisplay usercontrol
            Dim dateDisplay As New monthDate(i.ToString())

            dateDisplay.Tag = currentDate


            ' setting back red if 
            Dim total As Decimal = GetTotal(currentDate)
            If total > SessionManager.Instance.CurrentDailyLimit Then

                dateDisplay.lbl_date.BackColor = ColorTranslator.FromHtml("#fa5252")


            End If

            AddHandler dateDisplay.lbl_date.Click, Sub() handler(currentDate)
            fpanel_dates.Controls.Add(dateDisplay)

        Next


        fpanel_dates.ResumeLayout(True)

    End Sub


#End Region




    Private Function GetTotal(ByVal currentdate As DateTime) As Decimal

        Dim expenseManager As New ExpenseManager()
        Dim total As Decimal = expenseManager.GetTotalOfDay(currentdate.ToString("yyyy-MM-dd"))
        Return total

    End Function



    Public Sub DateClicked(ByVal currentDate As DateTime)


        'MainWindow.panel_main.Controls.Clear()

        MainWindow.radio_day_view.Checked = True
        MainWindow.radio_month_view.Checked = False
        MainWindow.radio_home.Checked = True

        _dayView._currentDate = currentDate
        _dayView.DisplayInformation()

    End Sub


End Class


