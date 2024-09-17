Public Class monthView

    Dim currentDate As DateTime = DateTime.Now
    Dim expenseManager As New ExpenseManager()


    Private Sub monthView_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' setting display date
        updateDisplayInformation()



    End Sub


    ' reflecting changes in information
    Private Sub updateDisplayInformation()

        lbl_year.Text = currentDate.ToString("yyyy")
        lbl_month.Text = currentDate.ToString("MMM")
        lbl_amount.Text = getTotal()

    End Sub


    ' db ko kam
    Private Function getTotal() As Decimal

    End Function



    Private Sub btn_previous_Click(sender As Object, e As EventArgs) Handles btn_previous.Click

        currentDate = currentDate.AddMonths(-1)

        'updating the date and total
        updateDisplayInformation()

    End Sub

    Private Sub btn_next_Click(sender As Object, e As EventArgs) Handles btn_next.Click

        currentDate = currentDate.AddMonths(1)

        'updating the date and total
        updateDisplayInformation()

    End Sub




End Class
