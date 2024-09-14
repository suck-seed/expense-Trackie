Imports System.Configuration

Public Class UserRepository




    Dim connectionString As String = ConfigurationManager.ConnectionStrings("expenseTrackie").ConnectionString
    Dim userId As Integer = SessionManager.Instance.currentUserId

    Sub New()

    End Sub


    Public Function checkUserExistance() As Integer


    End Function



    Public Function addUser()

    End Function


    Public Function getUserId()

    End Function

End Class
