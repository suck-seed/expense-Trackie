Imports System.Configuration

Public Class CategoryRepository

    Dim connectionString As String = ConfigurationManager.ConnectionStrings("expenseTrackie").ConnectionString
    Dim userId As Integer = SessionManager.Instance.currentUserId

    Public Function isDuplicateCategory(ByRef catName As String) As Boolean

    End Function

    Public Function addCategory(ByRef catName As String, ByRef catDescription As String, ByRef catColor As String)

    End Function

End Class
