Imports System.Configuration
Imports System.Data.SqlClient
Imports expense_Trackie.Application

Namespace DataLayer

    Public Class ExpenseRepository


        ReadOnly _connectionString As String = ConfigurationManager.ConnectionStrings("expenseTrackie").ConnectionString
        ReadOnly _userId As Integer = SessionManager.Instance.CurrentUserId
        ReadOnly _selectedCategory As List(Of Integer) = SessionManager.SelectedCategoryIds
        ReadOnly _selectedCategory2 As List(Of Integer) = SessionManager.SelectedCategoryIds2
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



        Public Function DeleteExpense(ByVal eId As Integer) As Integer

            Dim result As Integer = 0

            Using connection As New SqlConnection(_connectionString)
                connection.Open()

                Using command As New SqlCommand("deleteExpense", connection)
                    command.CommandType = CommandType.StoredProcedure


                    'linking paremeter
                    command.Parameters.AddWithValue("@eId", eId)
                    command.Parameters.AddWithValue("@userId", _userId)


                    'linking output paremeter
                    ' creating output paremeter
                    Dim resultParemeter As New SqlParameter("@result", SqlDbType.Int)
                    resultParemeter.Direction = ParameterDirection.Output

                    command.Parameters.Add(resultParemeter)



                    command.ExecuteNonQuery()

                    result = Convert.ToInt32(resultParemeter.Value)


                    Return result

                End Using
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
                    totalParemeter.Precision = 10
                    totalParemeter.Scale = 2
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
                    totalParemeter.Precision = 10
                    totalParemeter.Scale = 2
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
        Public Function GetExpensesDynamically(ByVal currentDate As DateTime, ByVal filterCount As Integer) As DataTable

            ' base query
            Dim query As String = " SELECT e.eId, e.remarks, e.timeAdded, e.amount, c.color
		                        FROM expense e
	                        	JOIN category c
	                        	on e.catId = c.catId
	                        	WHERE e.userId = @userId 
			                    AND e.enabled = 1
			                    AND c.enabled = 1 
			                    AND e.dateAdded = @dateAdded  
                            "

            ' filtering by category selected
            If _selectedCategory.Count > 0 Then

                'adding category filter
                query &= "AND c.catId IN ( " & String.Join(",", _selectedCategory) & " ) "

            End If


            ' select case for sorting
            Select Case filterCount
                Case 2
                    ' Sort by amount in ascending order
                    query &= " ORDER BY e.amount ASC"
                Case 3
                    ' Sort by amount in descending order
                    query &= " ORDER BY e.amount DESC"
                Case Else
                    ' Default sort, maybe by timeAdded (you can adjust this)
                    query &= " ORDER BY e.timeAdded ASC"
            End Select






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





        Public Function GetExpenseExport(ByVal startDate As DateTime, ByVal endDate As DateTime, ByVal selectedCategoryIds As List(Of Integer)) As DataTable


            Dim query As String = "
            
            SELECT e.eId,e.amount ,e.remarks, c.catName  ,e.dateAdded ,e.timeAdded, c.color, c.[description]
            FROM expense e
            JOIN category c 
            on e.catId = c.catId
            WHERE e.userId = @userId 
                    AND e.enabled = 1 
                    AND c.enabled = 1
                    AND (e.dateAdded BETWEEN @startDate AND @endDate )
                            "




            If selectedCategoryIds IsNot Nothing AndAlso selectedCategoryIds.Count > 0 Then
                ' Add category filter dynamically

                query &= " AND c.catId IN ( " & String.Join(",", selectedCategoryIds) & " ) "


            End If


            'If _selectedCategory2 IsNot Nothing AndAlso _selectedCategory2.Count > 0 Then
            '    ' Add category filter dynamically

            '    query &= " AND c.catId IN ( " & String.Join(",", _selectedCategory2) & " ) "

            'End If


            Dim dataTable As New DataTable()

            Using connection As New SqlConnection(_connectionString)
                connection.Open()

                Using command As New SqlCommand(query, connection)

                    command.Parameters.AddWithValue("@userId", _userId)
                    command.Parameters.AddWithValue("@startDate", startDate)
                    command.Parameters.AddWithValue("@endDate", endDate)


                    Using dataReader As SqlDataReader = command.ExecuteReader()

                        dataTable.Load(dataReader)

                    End Using


                End Using

            End Using

            Return dataTable


        End Function



    End Class

End NameSpace