Imports System.Configuration
Imports System.Data.SqlClient
Imports expense_Trackie.Application

Namespace DataLayer

    Public Class CategoryRepository

        ReadOnly _connectionString As String = ConfigurationManager.ConnectionStrings("expenseTrackie").ConnectionString

        ReadOnly _userId As Integer = SessionManager.Instance.CurrentUserId

#Region " is duplicate ? "


        Public Function IsDuplicateCategory(ByRef catName As String) As Boolean

            Using connection As New SqlConnection(_connectionString)

                connection.Open()

                Using command As New SqlCommand("checkDuplicateCategory", connection)
                    command.CommandType = CommandType.StoredProcedure


                    'linking parameter
                    command.Parameters.AddWithValue("@catName", catName)
                    command.Parameters.AddWithValue("@userId", _userId)


                    'adding output parameter
                    Dim existsParameter As New SqlParameter("@exists", SqlDbType.Bit)
                    existsParameter.Direction = ParameterDirection.Output

                    command.Parameters.Add(existsParameter)


                    'executing
                    command.ExecuteNonQuery()


                    ' fetching and converting output to boolean
                    Dim exists As Boolean = Convert.ToBoolean(existsParameter.Value)
                    Return exists

                    'will return TRUE if a category under same name exists

                End Using

                connection.Close()

            End Using

        End Function



        Public Function GetCategoryId(ByVal catName As String) As Integer

            Dim catId As Integer = 0

            Using connection As New SqlConnection(_connectionString)
                connection.Open()

                Using command As New SqlCommand("getCategoryId", connection)

                    command.CommandType = CommandType.StoredProcedure

                    'linking input paremeter
                    command.Parameters.AddWithValue("@catName", catName)
                    command.Parameters.AddWithValue("@userId", _userId)


                    'output paremeter
                    Dim catIDParemeter As New SqlParameter("@catId", SqlDbType.Int)
                    catIDParemeter.Direction = ParameterDirection.Output

                    command.Parameters.Add(catIDParemeter)

                    command.ExecuteNonQuery()


                    If Not IsDBNull(catIDParemeter.Value) Then
                        catId = Convert.ToInt32(catIDParemeter.Value)
                    End If

                    Return catId

                End Using
            End Using

        End Function

#End Region

#Region " add new category "


        Public Function AddCategory(ByRef catName As String, ByRef catDescription As String, ByRef catColor As String) As Integer
            Dim catId As Integer = 0

            Using connection As New SqlConnection(_connectionString)
                connection.Open()

                Using command As New SqlCommand("addNewCategory", connection)
                    command.CommandType = CommandType.StoredProcedure


                    'linking parameters
                    command.Parameters.AddWithValue("@catName", catName)
                    command.Parameters.AddWithValue("@description", catDescription)
                    command.Parameters.AddWithValue("@color", catColor)
                    command.Parameters.AddWithValue("@userId", _userId)


                    'creating output parameter
                    Dim catIdParameter As New SqlParameter("@catId", SqlDbType.Int)
                    catIdParameter.Direction = ParameterDirection.Output

                    command.Parameters.Add(catIdParameter)


                    'executing query
                    command.ExecuteNonQuery()


                    'fetching and retrieving catId, if added successfully, it'll be +ve number, else 0
                    catId = Convert.ToInt32(catIdParameter.Value)

                    Return catId

                End Using
            End Using

        End Function

#End Region


#Region " delete category "


        Public Function DeleteUserCategory(ByVal selectedCategory As Integer) As Integer

            Dim result As Integer = 0

            Using connection As New SqlConnection(_connectionString)
                connection.Open()

                Using command As New SqlCommand("deleteCategory", connection)
                    command.CommandType = CommandType.StoredProcedure

                    'linking parameter
                    command.Parameters.AddWithValue("@catId", selectedCategory)
                    command.Parameters.AddWithValue("@userId", _userId)



                    'output parameter
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



#Region " update category "

        Public Function UpdateCategoryInformation(ByVal catName As String, ByVal catDescription As String, ByVal catColor As String, ByVal catId As Integer) As Integer

            Dim result As Integer = 0

            Using connection As New SqlConnection(_connectionString)

                connection.Open()

                Using command As New SqlCommand("updateCategory", connection)
                    command.CommandType = CommandType.StoredProcedure


                    ' linking paremeter
                    command.Parameters.AddWithValue("@catName", catName)
                    command.Parameters.AddWithValue("@description", catDescription)
                    command.Parameters.AddWithValue("@color", catColor)

                    command.Parameters.AddWithValue("@catId", catId)
                    command.Parameters.AddWithValue("@userId", _userId)


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

#Region " get category : datatable "


        Public Function GetUserCategory() As DataTable

            Dim dataTable As New DataTable()


            ' query
            Using connection As New SqlConnection(_connectionString)
                connection.Open()


                Using command As New SqlCommand("getCategory", connection)
                    command.CommandType = CommandType.StoredProcedure


                    'setting up input parameter
                    command.Parameters.AddWithValue("@userId", _userId)


                    ' building a sql reader that reads the rows generated by procedure
                    Using dataReader As SqlDataReader = command.ExecuteReader()

                        ' loading the read rows into datatable
                        dataTable.Load(dataReader)
                    End Using


                End Using


            End Using

            Return dataTable

        End Function

#End Region


    End Class
End NameSpace