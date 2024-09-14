Imports System.Configuration

Public Class ExpenseRepository


    Dim connectionString As String = ConfigurationManager.ConnectionStrings("expenseTrackie").ConnectionString
    Dim userId As Integer = SessionManager.Instance.currentUserId


End Class
