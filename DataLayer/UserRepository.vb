Imports System.Configuration
Imports System.Data.SqlClient

Namespace DataLayer

    Public Class UserRepository

        ' DATA MEMBERS
        ReadOnly _connectionString As String = ConfigurationManager.ConnectionStrings("expenseTrackie").ConnectionString

        'Dim userId As Integer = SessionManager.Instance.currentUserId

        Sub New()

        End Sub

#Region "check duplicate user"

        Public Function IsDuplicateUser(ByVal username As String, ByVal number As String) As Boolean

            Using connection As New SqlConnection(_connectionString)

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


#End Region


#Region "add user"

        Public Function AddUser(ByVal username As String, ByVal number As String, ByVal password As String, ByVal dateJoined As DateTime, ByVal profileImageLink As String) As Integer

            Dim userId As Integer = 0

            Using connection As New SqlConnection(_connectionString)

                connection.Open()

                Using command As New SqlCommand("addUser", connection)
                    command.CommandType = CommandType.StoredProcedure


                    ' adding input paremeter
                    command.Parameters.AddWithValue("@username", username)
                    command.Parameters.AddWithValue("@password", password)
                    command.Parameters.AddWithValue("@number", number)
                    command.Parameters.AddWithValue("@dateJoined", dateJoined)
                    command.Parameters.AddWithValue("@profilePicturePath", profileImageLink)

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


#End Region



#Region " update "
        Function UpdateUser(ByVal _username As String, ByVal _password As String, ByVal _number As String, ByVal _dailyLimit As Decimal, ByVal _profileLink As String, ByVal userId As Integer) As Integer

            Dim result As Integer = 0

            Using connection As New SqlConnection(_connectionString)

                connection.Open()

                Using command As New SqlCommand("updateUserInfo", connection)
                    command.CommandType = CommandType.StoredProcedure


                    ' linking paremeter
                    command.Parameters.AddWithValue("@username", _username)
                    command.Parameters.AddWithValue("@number", _number)
                    command.Parameters.AddWithValue("@password", _password)

                    command.Parameters.AddWithValue("@dailyLimit", _dailyLimit)
                    command.Parameters.AddWithValue("@profilePicturePath", _profileLink)
                    command.Parameters.AddWithValue("@userId", userId)


                    'output paremeter
                    Dim resultParameter As New SqlParameter("@result", SqlDbType.Int)
                    resultParameter.Direction = ParameterDirection.Output

                    command.Parameters.Add(resultParameter)


                    command.ExecuteNonQuery()


                    result = Convert.ToInt32(resultParameter.Value)


                    Return result

                End Using

            End Using

        End Function

#End Region


#Region "signIn"


        Public Function SignIn(ByVal username As String, ByVal password As String) As Integer

            Dim userId As Integer = 0

            Using connection As New SqlConnection(_connectionString)

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
#End Region



#Region "fetch user info"


        Public Function FetchUserInfo(ByVal userId As Integer) As DataTable

            Dim dataTable As New DataTable()


            Using connection As New SqlConnection(_connectionString)
                connection.Open()


                Using command As New SqlCommand("fetchUserInfo", connection)
                    command.CommandType = CommandType.StoredProcedure


                    'linking input paremeter
                    command.Parameters.AddWithValue("@id", userId)



                    ' building a sqlreader that reads the rows generated by procedure
                    Using dataReader As SqlDataReader = command.ExecuteReader()

                        ' loading the read rows into datatable
                        dataTable.Load(dataReader)
                    End Using



                End Using

            End Using


            Return dataTable

        End Function

#End Region



#Region " delete "
        Function DeleteUserInfo(ByVal userId As Integer) As Integer

            Dim result As Integer = 0

            Using connection As New SqlConnection(_connectionString)

                connection.Open()

                Using command As New SqlCommand("deleteUserInfo", connection)
                    command.CommandType = CommandType.StoredProcedure


                    ' linking paremeter
                    command.Parameters.AddWithValue("@userId", userId)


                    'output paremeter
                    Dim resultParameter As New SqlParameter("@result", SqlDbType.Int)
                    resultParameter.Direction = ParameterDirection.Output

                    command.Parameters.Add(resultParameter)


                    command.ExecuteNonQuery()


                    result = Convert.ToInt32(resultParameter.Value)


                    Return result

                End Using

            End Using


        End Function
#End Region

    End Class
End NameSpace