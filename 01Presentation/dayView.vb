Public Class dayView

    Dim currentDate As DateTime = DateTime.Now
    Dim expenseManager As New ExpenseManager()


    ' setting default month,date, amount and view
    Private Sub dayView_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        updateDisplayInformation()



    End Sub


    ' reflecting changes in frontend
    Public Sub updateDisplayInformation()


        lbl_month.Text = currentDate.ToString("MMM")
        lbl_day.Text = currentDate.ToString("dd")
        lbl_total_amount.Text = getTotal()
        expenseManager.loadExpenstions(panel_expenses, currentDate)


    End Sub



    ' db backend ko kam
    Private Function getTotal() As Decimal

        Dim total As Decimal = expenseManager.getTotalOfDay(currentDate.ToString("yyyy-MM-dd"))
        Return total

    End Function




    ' date navigation
    Private Sub btn_previous_Click(sender As Object, e As EventArgs) Handles btn_previous.Click

        panel_expenses.Controls.Clear()

        'decreasing the date by 1
        currentDate = currentDate.AddDays(-1)


        'reflecting the date and total
        updateDisplayInformation()


    End Sub



    Private Sub btn_next_Click(sender As Object, e As EventArgs) Handles btn_next.Click


        panel_expenses.Controls.Clear()

        currentDate = currentDate.AddDays(1)


        'reflecting the date and total
        updateDisplayInformation()


    End Sub






End Class
