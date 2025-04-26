Imports System.Data.SqlClient
Imports System.Data.SQLite
Imports System.IO
Imports expense_Trackie.Application

Namespace DataLayer

    Public Class CategoryRepository

        'ReadOnly _connectionString As String = ConfigurationManager.ConnectionStrings("expenseTrackie").ConnectionString

        Private ReadOnly _connectionString As String = DatabaseSetup.ConnectionString



        ReadOnly _userId As Integer = SessionManager.Instance.CurrentUserId

#Region " is duplicate ? "


        Public Function IsDuplicateCategory(ByRef catName As String) As Boolean

            Try

                Using conn As New SQLiteConnection(_connectionString)
                    conn.Open()
                    Using cmd As New SQLiteCommand(
          "SELECT COUNT(1) FROM category WHERE catName=@n AND userId=@u AND enabled=1;", conn)
                        cmd.Parameters.AddWithValue("@n", catName)
                        cmd.Parameters.AddWithValue("@u", _userId)
                        Return CInt(cmd.ExecuteScalar()) > 0
                    End Using
                End Using

            Catch ex As SqlException
                Throw New Exception("Error checking for duplicated category", ex)

                Return True
            Catch ex As IOException
                Throw New Exception("I/O error loading query", ex)

                Return True
            End Try


        End Function



        Public Function GetCategoryId(ByVal catName As String) As Integer

            Try

                Dim catId As Integer = 0
                Using conn As New SQLiteConnection(_connectionString)
                    conn.Open()
                    Using cmd As New SQLiteCommand(
          "SELECT catId FROM category WHERE catName=@n AND userId=@u AND enabled=1;", conn)
                        cmd.Parameters.AddWithValue("@n", catName)
                        cmd.Parameters.AddWithValue("@u", _userId)
                        Dim result = cmd.ExecuteScalar()
                        If result IsNot Nothing AndAlso Not IsDBNull(result) Then
                            catId = Convert.ToInt32(result)
                        End If
                    End Using
                End Using
                Return catId

            Catch ex As SqlException
                Throw New Exception("Error checking for category", ex)

                Return 0
            Catch ex As IOException
                Throw New Exception("I/O error loading query", ex)

                Return 0
            End Try

        End Function

#End Region

#Region " add new category "


        Public Function AddCategory(ByRef catName As String, ByRef catDescription As String, ByRef catColor As String) As Integer
            'Dim catId As Integer = 0

            Try
                Using conn As New SQLiteConnection(_connectionString)
                    conn.Open()
                    Using cmd As New SQLiteCommand(
                      "INSERT INTO category(userId,catName,description,color,enabled) VALUES(@u,@n,@d,@c,1); SELECT last_insert_rowid();", conn)
                        cmd.Parameters.AddWithValue("@u", _userId)
                        cmd.Parameters.AddWithValue("@n", catName)
                        cmd.Parameters.AddWithValue("@d", catDescription)
                        cmd.Parameters.AddWithValue("@c", catColor)
                        Return CInt(cmd.ExecuteScalar())
                    End Using

                End Using

            Catch ex As SqlException
                Throw New Exception("Error adding category", ex)

                Return 0
            Catch ex As IOException
                Throw New Exception("I/O error loading query", ex)

                Return 0
            End Try

        End Function

#End Region


#Region " delete category "


        Public Function DeleteUserCategory(ByVal selectedCategory As Integer) As Integer

            'Dim result As Integer = 0
            Try
                Using conn As New SQLiteConnection(_connectionString)
                    conn.Open()
                    Using cmd As New SQLiteCommand(
                      "UPDATE category SET enabled=0 WHERE catId=@cid AND userId=@uid;", conn)
                        cmd.Parameters.AddWithValue("@cid", selectedCategory)
                        cmd.Parameters.AddWithValue("@uid", _userId)
                        Return cmd.ExecuteNonQuery()
                    End Using
                End Using



            Catch ex As SqlException
                Throw New Exception("Error deleting category", ex)

                Return 0
            Catch ex As IOException
                Throw New Exception("I/O error loading query", ex)

                Return 0
            End Try

        End Function

#End Region



#Region " update category "

        Public Function UpdateCategoryInformation(ByVal catName As String, ByVal catDescription As String, ByVal catColor As String, ByVal catId As Integer) As Integer

            'Dim result As Integer = 0
            Try
                Using conn As New SQLiteConnection(_connectionString)
                    conn.Open()
                    Using cmd As New SQLiteCommand(
          "UPDATE category SET catName=@n, description=@d, color=@c WHERE catId=@cid AND userId=@uid;", conn)
                        cmd.Parameters.AddWithValue("@n", catName)
                        cmd.Parameters.AddWithValue("@d", catDescription)
                        cmd.Parameters.AddWithValue("@c", catColor)
                        cmd.Parameters.AddWithValue("@cid", catId)
                        cmd.Parameters.AddWithValue("@uid", _userId)
                        Return cmd.ExecuteNonQuery()
                    End Using
                End Using


            Catch ex As SqlException
                Throw New Exception("Error updating for category", ex)

                Return 0
            Catch ex As IOException
                Throw New Exception("I/O error loading query", ex)

                Return 0
            End Try

        End Function

#End Region

#Region " get category : datatable "


        Public Function GetUserCategory() As DataTable

            Dim dt As New DataTable()
            Using conn As New SQLiteConnection(_connectionString)
                conn.Open()
                Using cmd As New SQLiteCommand(
          "SELECT catId, catName, description, color FROM category WHERE userId=@uid AND enabled=1;", conn)
                    cmd.Parameters.AddWithValue("@uid", _userId)
                    Using reader As SQLiteDataReader = cmd.ExecuteReader()
                        dt.Load(reader)
                    End Using
                End Using
            End Using
            Return dt

        End Function

#End Region


    End Class
End Namespace