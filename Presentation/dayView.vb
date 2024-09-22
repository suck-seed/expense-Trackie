Imports expense_Trackie.Application

Namespace Presentation

    Public Class DayView

        Public _currentDate As DateTime = DateTime.Now


#Region "initialization / load"

        Public Sub New()

            ' This call is required by the designer.
            InitializeComponent()
            DisplayInformation()

        End Sub



        Private Sub dayView_Load(sender As Object, e As EventArgs) Handles MyBase.Load

            DisplayInformation()

        End Sub


#End Region


#Region "update display information"


        Public Sub DisplayInformation()


            lbl_month.Text = _currentDate.ToString("MMM")
            lbl_day.Text = _currentDate.ToString("dd")
            lbl_total_amount.Text = GetTotal()
            LoadExpenses()

            '            expenseManager.loadExpenses(mainWindow.flowPanelCategory, currentDate)


        End Sub
#End Region



#Region "navigatio"

        ' date navigation
        Private Sub btn_previous_Click(sender As Object, e As EventArgs) Handles btn_previous.Click

            panel_expense_display.Controls.Clear()

            'decreasing the date by 1
            _currentDate = _currentDate.AddDays(-1)
            SessionManager.Instance.CurrentDate = _currentDate

            DisplayInformation()

            'MsgBox(SessionManager.Instance.CurrentDate)

        End Sub



        Private Sub btn_next_Click(sender As Object, e As EventArgs) Handles btn_next.Click


            panel_expense_display.Controls.Clear()

            _currentDate = _currentDate.AddDays(1)
            SessionManager.Instance.CurrentDate = _currentDate


            DisplayInformation()

            'MsgBox(SessionManager.Instance.CurrentDate)

        End Sub

#End Region



#Region "getting total for a day"

        Private Function GetTotal() As Decimal

            Dim expenseManager As New ExpenseManager()
            Dim total As Decimal = expenseManager.GetTotalOfDay(_currentDate.ToString("yyyy-MM-dd"))
            Return total

        End Function

#End Region



#Region "loading expense in form"

        Public Sub LoadExpenses()

            Dim expenseManager As New ExpenseManager()

            expenseManager.LoadDayExpenses(panel_expense_display, _currentDate, AddressOf DeleteOnExpenseClick)

        End Sub

        Private Sub btn_refresh_Click(sender As Object, e As EventArgs) Handles btn_refresh.Click

            LoadExpenses()

        End Sub


#End Region


        Public Sub DeleteOnExpenseClick(ByVal eId As Integer)

            MsgBox(eId)


        End Sub






    End Class
End NameSpace