Imports System.Data.SQLite

Namespace DataLayer

    Public Class UserRepository

        ' DATA MEMBERS
        'ReadOnly _connectionString As String = ConfigurationManager.ConnectionStrings("expenseTrackie").ConnectionString
        Private ReadOnly _connectionString As String = DatabaseSetup.ConnectionString


        'Dim userId As Integer = SessionManager.Instance.currentUserId

        Sub New()

        End Sub

#Region "check duplicate user"

        Public Function IsDuplicateUser(ByVal username As String, ByVal number As String) As Boolean
            Using conn As New SQLiteConnection(_connectionString)
                conn.Open()
                Using cmd As New SQLiteCommand("SELECT COUNT(1) FROM userInfo WHERE (username = @u OR number = @n) AND enabled = 1;", conn)
                    cmd.Parameters.AddWithValue("@u", username)
                    cmd.Parameters.AddWithValue("@n", number)
                    Return CInt(cmd.ExecuteScalar()) > 0
                End Using
            End Using

        End Function


#End Region


#Region "add user"

        Public Function AddUser(ByVal username As String, ByVal number As String, ByVal password As String, ByVal dateJoined As DateTime, ByVal profileImageLink As String) As Integer

            Using conn As New SQLiteConnection(_connectionString)
                conn.Open()
                Using cmd As New SQLiteCommand(
          "INSERT INTO userInfo(username,password,number,dateJoined,profilePicturePath,enabled) " &
          "VALUES(@u,@p,@n,@d,@pp,1); SELECT last_insert_rowid();", conn)
                    cmd.Parameters.AddWithValue("@u", username)
                    cmd.Parameters.AddWithValue("@p", password)
                    cmd.Parameters.AddWithValue("@n", number)
                    cmd.Parameters.AddWithValue("@d", dateJoined.ToString("yyyy-MM-dd"))
                    cmd.Parameters.AddWithValue("@pp", profileImageLink)
                    Return CInt(cmd.ExecuteScalar())
                End Using
            End Using

        End Function


#End Region



#Region " update "
        Function UpdateUser(ByVal _username As String, ByVal _password As String, ByVal _number As String, ByVal _dailyLimit As Decimal, ByVal _profileLink As String, ByVal userId As Integer) As Integer

            Using conn As New SQLiteConnection(_connectionString)
                conn.Open()
                Using cmd As New SQLiteCommand(
          "UPDATE userInfo SET username=@u, number=@n, password=@p, dailyLimit=@dl, profilePicturePath=@pp WHERE id=@id;", conn)
                    cmd.Parameters.AddWithValue("@u", _username)
                    cmd.Parameters.AddWithValue("@n", _number)
                    cmd.Parameters.AddWithValue("@p", _password)
                    cmd.Parameters.AddWithValue("@dl", _dailyLimit)
                    cmd.Parameters.AddWithValue("@pp", _profileLink)
                    cmd.Parameters.AddWithValue("@id", userId)
                    Return cmd.ExecuteNonQuery()
                End Using
            End Using

        End Function

#End Region


#Region "signIn"


        Public Function SignIn(ByVal username As String, ByVal password As String) As Integer

            Using conn As New SQLiteConnection(_connectionString)
                conn.Open()
                Using cmd As New SQLiteCommand(
                  "SELECT id FROM userInfo WHERE username = @u AND password = @p AND enabled = 1;", conn)
                    cmd.Parameters.AddWithValue("@u", username)
                    cmd.Parameters.AddWithValue("@p", password)
                    Dim result = cmd.ExecuteScalar()
                    Return If(result IsNot Nothing, Convert.ToInt32(result), 0)
                End Using
            End Using
            ' if no match returns 0, if match returns userId


        End Function
#End Region



#Region "fetch user info"


        Public Function FetchUserInfo(ByVal userId As Integer) As DataTable

            Dim dt As New DataTable()
            Using conn As New SQLiteConnection(_connectionString)
                conn.Open()
                Using cmd As New SQLiteCommand(
          "SELECT username, password, number, dateJoined, profilePicturePath, dailyLimit " &
          "FROM userInfo WHERE id=@id AND enabled=1;", conn)
                    cmd.Parameters.AddWithValue("@id", userId)
                    Using reader As SQLiteDataReader = cmd.ExecuteReader()
                        dt.Load(reader)
                    End Using
                End Using
            End Using
            Return dt

        End Function

#End Region



#Region " delete "
        Public Function DeleteUserInfo(ByVal userId As Integer, ByVal username As String) As Integer

            Using conn As New SQLiteConnection(_connectionString)
                conn.Open()
                Using cmd As New SQLiteCommand(
          "UPDATE userInfo SET enabled=0, username=@u WHERE id=@id;", conn)
                    cmd.Parameters.AddWithValue("@u", username)
                    cmd.Parameters.AddWithValue("@id", userId)
                    Return cmd.ExecuteNonQuery()
                End Using
            End Using


        End Function
#End Region




#Region " forget password sign up reset "

        Public Function updatePasswordByUsername(ByVal username As String, ByVal password As String) As Integer


            Using conn As New SQLiteConnection(_connectionString)
                conn.Open()
                Using cmd As New SQLiteCommand(
          "UPDATE userInfo SET password=@p WHERE username=@u;", conn)
                    cmd.Parameters.AddWithValue("@u", username)
                    cmd.Parameters.AddWithValue("@p", password)
                    Return cmd.ExecuteNonQuery()
                End Using
            End Using



        End Function


#End Region

    End Class
End Namespace