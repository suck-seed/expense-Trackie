Imports System.Configuration
Imports System.Data.SqlClient

Public Class CategoryRepository

    Dim connectionString As String = ConfigurationManager.ConnectionStrings("expenseTrackie").ConnectionString
    Dim userId As Integer = SessionManager.Instance.currentUserId

    Public Function isDuplicateCategory(ByRef catName As String) As Boolean

        Using connection As New SqlConnection(connectionString)

            connection.Open()

            Using command As New SqlCommand("checkDuplicateCategory", connection)
                command.CommandType = CommandType.StoredProcedure


                'linking paremeter
                command.Parameters.AddWithValue("@catName", catName)
                command.Parameters.AddWithValue("@userId", userId)


                'adding output paremeter
                Dim existsParemeter As New SqlParameter("@exists", SqlDbType.Bit)
                existsParemeter.Direction = ParameterDirection.Output

                command.Parameters.Add(existsParemeter)


                'executing
                command.ExecuteNonQuery()


                ' fetching and converting output to boolean
                Dim exists As Boolean = Convert.ToBoolean(existsParemeter.Value)
                Return exists

                'will return TRUE if a category under same name exists

            End Using

            connection.Close()

        End Using

    End Function

    Public Function addCategory(ByRef catName As String, ByRef catDescription As String, ByRef catColor As String) As Integer
        Dim catId As Integer = 0

        Using connection As New SqlConnection(connectionString)
            connection.Open()

            Using command As New SqlCommand("addNewCategory", connection)
                command.CommandType = CommandType.StoredProcedure


                'linking paremeters
                command.Parameters.AddWithValue("@catName", catName)
                command.Parameters.AddWithValue("@description", catDescription)
                command.Parameters.AddWithValue("@color", catColor)
                command.Parameters.AddWithValue("@userId", userId)


                'creating output paremeter
                Dim catIdParemeter As New SqlParameter("@catId", SqlDbType.Int)
                catIdParemeter.Direction = ParameterDirection.Output

                command.Parameters.Add(catIdParemeter)


                'executing query
                command.ExecuteNonQuery()


                'fetching and retriving catId, if added successfully, it'll be +ve number, else 0
                catId = Convert.ToInt32(catIdParemeter.Value)

                Return catId

            End Using
        End Using

    End Function

End Class
