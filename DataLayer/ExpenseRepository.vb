Imports System.Configuration
Imports System.Data.SqlClient
Imports expense_Trackie.Application

Namespace DataLayer

    Public Class ExpenseRepository


        ReadOnly _connectionString As String = ConfigurationManager.ConnectionStrings("expenseTrackie").ConnectionString
        ReadOnly _userId As Integer = SessionManager.Instance.CurrentUserId
        ReadOnly _selectedCategory As List(Of Integer) = SessionManager.SelectedCategoryIds
        ReadOnly _currentDate as DateTime = SessionManager.Instance.CurrentDate


        Public Function InsertExpense(ByVal amount As Decimal, ByVal remarks As String, ByVal dateAdded As DateTime, ByVal timeAdded As DateTime, ByVal categoryId As Integer) As Integer

            Dim expenseId As Integer = 0

            Using connection As New SqlConnection(_connectionString)
                connection.Open()

                Using command As New SqlCommand("addNewExpense", connection)
                    command.CommandType = CommandType.StoredProcedure


                    'paremeter linking
                    command.Parameters.AddWithValue("@amount", amount)
                    command.Parameters.AddWithValue("@remarks", remarks)
                    command.Parameters.AddWithValue("@dateAdded", dateAdded)
                    command.Parameters.AddWithValue("@timeAdded", timeAdded)
                    command.Parameters.AddWithValue("@catId", categoryId)
                    command.Parameters.AddWithValue("@userId", _userId)


                    'output paremeter

                    Dim expenseIdParemeter As New SqlParameter("@eId", SqlDbType.Int)
                    expenseIdParemeter.Direction = ParameterDirection.Output

                    command.Parameters.Add(expenseIdParemeter)


                    command.ExecuteNonQuery()


                    'fetching output paremeter
                    expenseId = Convert.ToInt32(expenseIdParemeter.Value)


                    Return expenseId



                End Using

                connection.Close()

            End Using


        End Function



        Public Function GetTotalOfDayAllCategory(ByVal currentDate As DateTime) As Decimal
            ' datetime format = "yyyy-MM-dd"

            Dim total As Decimal = 0

            Using connection As New SqlConnection(_connectionString)
                connection.Open()

                Using command As New SqlCommand("getTotalOfDayAllCategory", connection)
                    command.CommandType = CommandType.StoredProcedure


                    'linking input paremeter
                    command.Parameters.AddWithValue("@userId", _userId)
                    command.Parameters.AddWithValue("@dateAdded", currentDate)



                    ' creating output paremeter
                    Dim totalParemeter As New SqlParameter("@total", SqlDbType.Decimal)
                    totalParemeter.Direction = ParameterDirection.Output

                    command.Parameters.Add(totalParemeter)


                    'executing query
                    command.ExecuteNonQuery()



                    'fetching total and assigning to total variable
                    If Not IsDBNull(totalParemeter.Value) Then
                        total = Convert.ToDecimal(totalParemeter.Value)
                    End If


                    'returning 
                    Return total

                End Using


            End Using


        End Function




        Public Function GetTotalOfMonthAllCategory(ByVal startingDate As DateTime, ByVal endingDate As DateTime) As Decimal
            ' datetime format = "yyyy-MM-dd"

            Dim total As Decimal = 0

            Using connection As New SqlConnection(_connectionString)
                connection.Open()

                Using command As New SqlCommand("getTotalOfMonth", connection)
                    command.CommandType = CommandType.StoredProcedure


                    'linking input paremeter
                    command.Parameters.AddWithValue("@userId", _userId)
                    command.Parameters.AddWithValue("@startingDate", startingDate)
                    command.Parameters.AddWithValue("@endingDate", endingDate)



                    ' creating output paremeter
                    Dim totalParemeter As New SqlParameter("@total", SqlDbType.Decimal)
                    totalParemeter.Direction = ParameterDirection.Output

                    command.Parameters.Add(totalParemeter)


                    'executing query
                    command.ExecuteNonQuery()



                    'fetching total and assigning to total variable
                    If Not IsDBNull(totalParemeter.Value) Then
                        total = Convert.ToDecimal(totalParemeter.Value)
                    End If


                    'returning 
                    Return total

                End Using


            End Using


        End Function



        'Public Function getUserExpenseAllCategory(ByVal currentDate As DateTime) As DataTable

        '    Dim dataTable As New DataTable()

        '    Using connection As New SqlConnection(connectionString)
        '        connection.Open()

        '        Using command As New SqlCommand("getUserExpenseAllCategory", connection)
        '            command.CommandType = CommandType.StoredProcedure



        '            ' linking input paremeter
        '            command.Parameters.AddWithValue("@userId", userId)
        '            command.Parameters.AddWithValue("@dateAdded", currentDate)



        '            ' building a sqlreader that reads the rows generated by procedure
        '            Using dataReader As SqlDataReader = command.ExecuteReader()

        '                ' loading the read rows into datatable
        '                dataTable.Load(dataReader)
        '            End Using



        '        End Using

        '    End Using

        '    Return dataTable

        'End Function




        ' to get expenses dynamically
        Public Function GetExpensesDynamically(ByVal currentDate As DateTime) As DataTable

            ' base query
            Dim query As String = " SELECT eId,remarks,timeAdded,amount,color
		                        FROM expense e
	                        	JOIN category c
	                        	on e.catId = c.catId
	                        	WHERE e.userId = @userId 
			                    AND e.enabled = 1
			                    AND c.enabled = 1 
			                    AND e.dateAdded = @dateAdded  
                            "


            If _selectedCategory.Count > 0 Then

                'adding category filter
                query &= "AND c.catId IN ( " & String.Join(",", _selectedCategory) & " ) "

            End If


            Dim dataTable As New DataTable()

            Using connection As New SqlConnection(_connectionString)
                connection.Open()

                Using command As New SqlCommand(query, connection)

                    command.Parameters.AddWithValue("@userId", _userId)
                    command.Parameters.AddWithValue("@dateAdded", currentDate)


                    Using dataReader As SqlDataReader = command.ExecuteReader()

                        dataTable.Load(dataReader)

                    End Using


                End Using

            End Using

            Return dataTable


        End Function

    End Class

End NameSpace