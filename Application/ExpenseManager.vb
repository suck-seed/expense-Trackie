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

End Class
