Imports System.Configuration
Imports System.Data.SqlClient

Public Class UserRepository

    ' DATAMEMBERS
    Dim connectionString As String = ConfigurationManager.ConnectionStrings("expenseTrackie").ConnectionString

    'Dim userId As Integer = SessionManager.Instance.currentUserId

    Sub New()

    End Sub


    Public Function isDuplicateUser(ByVal username As String, ByVal number As String) As Boolean

        Using connection As New SqlConnection(connectionString)

            connection.Open()

            Using command As New SqlCommand("checkDuplicateUser", connection)
                command.CommandType = CommandType.StoredProcedure


                ' adding input paremeters
                command.Parameters.AddWithValue("@username", username)
                command.Parameters.AddWithValue("@number", number)


                ' adding output paremeter
                Dim existsParemeter As New SqlParameter("@exists", SqlDbType.Bit)
                existsParemeter.Direction = ParameterDirection.Output

                command.Parameters.Add(existsParemeter)


                ' executing non query
                command.ExecuteNonQuery()



                ' fetching and converting output to boolean
                Dim exists As Boolean = Convert.ToBoolean(existsParemeter.Value)


                ' returns true if its duplicate
                Return exists


            End Using


        End Using

    End Function



    Public Function addUser(ByVal username As String, ByVal number As String, ByVal password As String, ByVal dateJoined As DateTime) As Integer

        Dim userId As Integer = 0

        Using connection As New SqlConnection(connectionString)

            connection.Open()

            Using command As New SqlCommand("addNewUser", connection)
                command.CommandType = CommandType.StoredProcedure


                ' adding input paremeter
                command.Parameters.AddWithValue("@username", username)
                command.Parameters.AddWithValue("@password", password)
                command.Parameters.AddWithValue("@number", number)
                command.Parameters.AddWithValue("@dateJoined", dateJoined)


                ' adding output paremeter
                Dim userIdParemeter As New SqlParameter("@userId", SqlDbType.Int)
                userIdParemeter.Direction = ParameterDirection.Output

                command.Parameters.Add(userIdParemeter)



                ' executing non query
                command.ExecuteNonQuery()

                ' converting from sqlDb to vbDatatype
                If Not IsDBNull(userIdParemeter.Value) Then
                    userId = Convert.ToInt32(userIdParemeter.Value)
                End If





            End Using

            connection.Close()
        End Using


        ' returns the fetched userId / 0
        Return userId

    End Function


    Public Function signIn(ByVal username As String, ByVal password As String) As Integer

        Dim userId As Integer = 0

        Using connection As New SqlConnection(connectionString)

            connection.Open()

            Using command As New SqlCommand("logUserIn", connection)
                command.CommandType = CommandType.StoredProcedure


                ' input paremeter linking
                command.Parameters.AddWithValue("@username", username)
                command.Parameters.AddWithValue("@password", password)


                ' output paremeter creating
                Dim userIdParemeter As New SqlParameter("@userId", SqlDbType.Int)
                userIdParemeter.Direction = ParameterDirection.Output

                command.Parameters.Add(userIdParemeter)



                'executing procedure
                command.ExecuteNonQuery()

                ' if tyo output paremeter isnt null, we retrive the value
                ' convert it to vb integer and assign to userId and return
                If Not IsDBNull(userIdParemeter.Value) Then
                    userId = Convert.ToInt32(userIdParemeter.Value)
                End If


            End Using

            connection.Close()
        End Using

        ' if no match returns 0, if match returns userId
        Return userId

    End Function
End Class
