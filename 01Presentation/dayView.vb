Public Class dayView

    Dim currentDate As DateTime = DateTime.Now
    Dim expenseManager As New ExpenseManager()
    Dim currentDateString As DateTime = currentDate.ToString("yyyy-MM-dd")



    Dim expenseQuery As String

    Public Sub New(ByVal query As String)
        expenseQuery = query

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    ' setting default month,date, amount and view
    Private Sub dayView_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        updateDisplayInformation()
        expenseManager.generateExpenseDisplay(panel_expenseDisplay, expenseQuery, currentDateString)


    End Sub


    ' reflecting changes in frontend
    Public Sub updateDisplayInformation()


        lbl_month.Text = currentDate.ToString("MMM")
        lbl_day.Text = currentDate.ToString("dd")
        lbl_total_amount.Text = getTotal()


    End Sub



    ' db backend ko kam
    Private Function getTotal() As Decimal

        Dim total As Decimal = expenseManager.getTotalOfDay(currentDateString)
        Return total

    End Function




    ' date navigation
    Private Sub btn_previous_Click(sender As Object, e As EventArgs) Handles btn_previous.Click

        panel_expenseDisplay.Controls.Clear()

        'decreasing the date by 1
        currentDate = currentDate.AddDays(-1)


        'reflecting the date and total
        updateDisplayInformation()
        expenseManager.generateExpenseDisplay(panel_expenseDisplay, expenseQuery, currentDateString)

    End Sub



    Private Sub btn_next_Click(sender As Object, e As EventArgs) Handles btn_next.Click


        panel_expenseDisplay.Controls.Clear()

        currentDate = currentDate.AddDays(1)


        'reflecting the date and total
        updateDisplayInformation()
        expenseManager.generateExpenseDisplay(panel_expenseDisplay, expenseQuery, currentDateString)

    End Sub


End Class
