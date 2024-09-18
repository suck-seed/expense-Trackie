Public Class ExpenseManager

    Dim expenseRepository As New ExpenseRepository()
    Dim currentTime As DateTime = SessionManager.Instance.currentDate

    Public Function addNewExpense(ByVal amount As Decimal, ByVal remarks As String, ByVal dateAdded As DateTime, ByVal timeAdded As DateTime, ByVal categoryId As Integer) As Integer

        Dim added As Integer = expenseRepository.insertExpense(amount, remarks, dateAdded, timeAdded, categoryId)

        If added > 0 Then
            'debug
            MsgBox("Expense added successfully")

            Return added
        End If


        ' returns -1 if above isnt returned, meaning adding expense failed
        Return -1

    End Function




    Public Function getTotalOfDay(ByRef currentDate As DateTime) As Decimal

        Return expenseRepository.getTotalOfDayAllCategory(currentDate)

    End Function





    Public Function getTotalOfMonth(ByVal currentDate As DateTime) As Decimal

        Dim startingDate As New DateTime(currentDate.Year, currentDate.Month, 1)
        Dim endingDate As New DateTime(currentDate.Year, currentDate.Month, DateTime.DaysInMonth(currentDate.Year, currentDate.Month))

        Return expenseRepository.getTotalOfMonthAllCategory(startingDate, endingDate)

    End Function




    ' load expense into panel
    'Public Sub loadExpenstions(ByRef panel As Panel, ByRef currentDate As DateTime)

    '    Dim expenseTable As DataTable = expenseRepository.getExpensesDynamically(currentDate.ToString("yyyy-MM-dd"))

    '    panel.Controls.Clear()


    '    For Each row As DataRow In expenseTable.Rows



    '        Dim timeAdded As String = row("timeAdded").ToString
    '        Dim time As DateTime = DateTime.Parse(timeAdded)
    '        Dim formattedTime As String = time.ToString("hh:mm tt")
    '        Dim amount As Decimal = row("amount")


    '        ' creating instance of the expense Detailed display
    '        Dim expenseDisplay As New expenseDetailDisplay()


    '        expenseDisplay.lbl_amount.Text = amount.ToString()
    '        expenseDisplay.lbl_remarks.Text = row("remarks").ToString
    '        expenseDisplay.lbl_time.Text = formattedTime
    '        expenseDisplay.BackColor = ColorTranslator.FromHtml(row("color").ToString())
    '        expenseDisplay.Tag = row("eId")

    '        expenseDisplay.Margin = New Padding(10)
    '        expenseDisplay.AutoSize = False
    '        expenseDisplay.Visible = True

    '        expenseDisplay.Anchor = AnchorStyles.None

    '        panel.Controls.Add(expenseDisplay)


    '    Next
    'End Sub




End Class
