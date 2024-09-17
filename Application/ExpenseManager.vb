Public Class ExpenseManager

    Dim expenseRepository As New ExpenseRepository()

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



    Public Sub generateExpenseDisplay(ByVal panel As Panel, ByVal query As String, ByVal currentDate As DateTime)

        Dim expenseTable As New DataTable

        If query = "all" Then
            expenseTable = expenseRepository.getUserExpenseAllCategory(currentDate)
        End If


        panel.Controls.Clear()


        For Each row As DataRow In expenseTable.Rows

            Dim expenseId As Integer = row("eId")
            Dim remarks As String = row("remarks").ToString

            Dim timeAdded As String = row("timeAdded").ToString
            Dim time As DateTime = DateTime.Parse(timeAdded)
            Dim formattedTime As String = time.ToString("hh:mm tt")

            Dim amount As Decimal = row("amount")

            Dim colorHex As String = row("color").ToString()
            Dim backColor As Color = ColorTranslator.FromHtml(colorHex)




            ' creating instance of the expense Detailed display
            Dim expenseContainer As New expenseDetailDisplay()


            expenseContainer.lbl_amount.Text = amount.ToString()
            expenseContainer.lbl_remarks.Text = remarks
            expenseContainer.lbl_time.Text = formattedTime
            expenseContainer.BackColor = backColor
            expenseContainer.Tag = expenseId

            expenseContainer.Margin = New Padding(200, 20, 200, 10)
            expenseContainer.Width = panel.Width - 400
            expenseContainer.Height = 90

            expenseContainer.AutoSize = False


            expenseContainer.Visible = True





            panel.Controls.Add(expenseContainer)
            expenseContainer.Anchor = AnchorStyles.Top And AnchorStyles.Right

        Next


    End Sub

End Class
