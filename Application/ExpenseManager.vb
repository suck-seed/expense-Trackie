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


End Class
