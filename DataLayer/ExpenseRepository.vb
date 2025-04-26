Imports System.Data.SQLite
Imports expense_Trackie.Application

Namespace DataLayer

    Public Class ExpenseRepository


        'ReadOnly _connectionString As String = ConfigurationManager.ConnectionStrings("expenseTrackie").ConnectionString
        Private ReadOnly _connectionString As String = DatabaseSetup.ConnectionString

        ReadOnly _userId As Integer = SessionManager.Instance.CurrentUserId
        ReadOnly _selectedCategory As List(Of Integer) = SessionManager.SelectedCategoryIds
        ReadOnly _selectedCategory2 As List(Of Integer) = SessionManager.SelectedCategoryIds2
        ReadOnly _currentDate As DateTime = SessionManager.Instance.CurrentDate


        Public Function InsertExpense(ByVal amount As Decimal, ByVal remarks As String, ByVal dateAdded As DateTime, ByVal timeAdded As DateTime, ByVal categoryId As Integer) As Integer

            Dim expenseId As Integer = 0

            Using conn As New SQLiteConnection(_connectionString)
                conn.Open()
                Using cmd As New SQLiteCommand(
          "INSERT INTO expense(userId,catId,amount,remarks,dateAdded,timeAdded,enabled) VALUES(@uid,@cid,@amt,@rm,@da,@ta,1); SELECT last_insert_rowid();", conn)
                    cmd.Parameters.AddWithValue("@uid", _userId)
                    cmd.Parameters.AddWithValue("@cid", categoryId)
                    cmd.Parameters.AddWithValue("@amt", amount)
                    cmd.Parameters.AddWithValue("@rm", remarks)
                    cmd.Parameters.AddWithValue("@da", dateAdded.ToString("yyyy-MM-dd"))
                    cmd.Parameters.AddWithValue("@ta", timeAdded.ToString())
                    Return CInt(cmd.ExecuteScalar())
                End Using
            End Using


        End Function



        Public Function DeleteExpense(ByVal eId As Integer) As Integer

            'Dim result As Integer = 0

            Using conn As New SQLiteConnection(_connectionString)
                conn.Open()
                Using cmd As New SQLiteCommand(
          "UPDATE expense SET enabled=0 WHERE eId=@eid AND userId=@uid;", conn)
                    cmd.Parameters.AddWithValue("@eid", eId)
                    cmd.Parameters.AddWithValue("@uid", _userId)
                    Return cmd.ExecuteNonQuery()
                End Using
            End Using
        End Function



        Public Function GetTotalOfDayAllCategory(ByVal currentDate As DateTime) As Decimal
            ' datetime format = "yyyy-MM-dd"
            Dim total As Decimal = 0D
            Using conn As New SQLiteConnection(_connectionString)
                conn.Open()
                Using cmd As New SQLiteCommand(
          "SELECT IFNULL(ROUND(SUM(amount),2),0) FROM expense e JOIN category c ON e.catId=c.catId " &
          "WHERE e.userId=@uid AND e.dateAdded=@da AND e.enabled=1 AND c.enabled=1;", conn)
                    cmd.Parameters.AddWithValue("@uid", _userId)
                    cmd.Parameters.AddWithValue("@da", currentDate.ToString("yyyy-MM-dd"))
                    Dim result = cmd.ExecuteScalar()
                    If result IsNot Nothing AndAlso Not IsDBNull(result) Then
                        total = Convert.ToDecimal(result)
                    End If
                End Using
            End Using
            Return total


        End Function




        Public Function GetTotalOfMonthAllCategory(ByVal startingDate As DateTime, ByVal endingDate As DateTime) As Decimal
            ' datetime format = "yyyy-MM-dd"

            Dim total As Decimal = 0D
            Using conn As New SQLiteConnection(_connectionString)
                conn.Open()
                Using cmd As New SQLiteCommand(
          "SELECT IFNULL(ROUND(SUM(amount),2),0) FROM expense " &
          "WHERE userId=@uid AND dateAdded BETWEEN @sd AND @ed AND enabled=1;", conn)
                    cmd.Parameters.AddWithValue("@uid", _userId)
                    cmd.Parameters.AddWithValue("@sd", startingDate.ToString("yyyy-MM-dd"))
                    cmd.Parameters.AddWithValue("@ed", endingDate.ToString("yyyy-MM-dd"))
                    Dim result = cmd.ExecuteScalar()
                    If result IsNot Nothing AndAlso Not IsDBNull(result) Then
                        total = Convert.ToDecimal(result)
                    End If
                End Using
            End Using
            Return total


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






            Dim dt As New DataTable()
            Using conn As New SQLiteConnection(_connectionString)
                conn.Open()
                Using cmd As New SQLiteCommand(query, conn)
                    cmd.Parameters.AddWithValue("@userId", _userId)
                    cmd.Parameters.AddWithValue("@dateAdded", currentDate.ToString("yyyy-MM-dd"))
                    Using reader As SQLiteDataReader = cmd.ExecuteReader()
                        dt.Load(reader)
                    End Using
                End Using
            End Using
            Return dt


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

            Dim dt As New DataTable()

            Using conn As New SQLiteConnection(_connectionString)

                conn.Open()

                Using cmd As New SQLiteCommand(query, conn)
                    cmd.Parameters.AddWithValue("@userId", _userId)
                    cmd.Parameters.AddWithValue("@startDate", startDate.ToString("yyyy-MM-dd"))
                    cmd.Parameters.AddWithValue("@endDate", endDate.ToString("yyyy-MM-dd"))
                    Using reader As SQLiteDataReader = cmd.ExecuteReader()
                        dt.Load(reader)
                    End Using

                End Using

            End Using

            Return dt


        End Function



        Public Function GetTop3Month(ByVal currentDate As DateTime) As DataTable


            Dim query As String = "
            
            SELECT e.eId, e.remarks, e.timeAdded, e.amount, c.color
            FROM expense e
            JOIN category c
                ON e.catId = c.catId
            WHERE e.userId = @userId 
            AND e.enabled = 1
            AND c.enabled = 1 
            AND e.dateAdded = @dateAdded
            ORDER BY e.amount DESC LIMIT 3 
                            "

            Dim dt As New DataTable()
            Using conn As New SQLiteConnection(_connectionString)
                conn.Open()
                Using cmd As New SQLiteCommand(query, conn)
                    cmd.Parameters.AddWithValue("@userId", _userId)
                    cmd.Parameters.AddWithValue("@dateAdded", currentDate.ToString("yyyy-MM-dd"))
                    Using reader As SQLiteDataReader = cmd.ExecuteReader()
                        dt.Load(reader)
                    End Using
                End Using
            End Using
            Return dt

        End Function



        Public Function GetExpenseOfCategories(ByRef isYearly As Boolean, ByRef isMonthly As Boolean) As DataTable

            ' Get the current date for use in filtering
            Dim currentDate As DateTime = DateTime.Now

            ' Initialize the base query
            Dim query As String = "
                    SELECT 
                    c.catName AS CategoryName, 
                    c.color AS CategoryColor, 
                    IFNULL(ROUND(SUM(e.amount),2),0) AS TotalSpent, 
                    COUNT(e.eId) AS ExpenseCount 
                    FROM 
                    category c
                    LEFT JOIN 
                    expense e ON c.catId = e.catId AND e.userId = @userId AND e.enabled = 1
                    WHERE 
                    c.enabled = 1"




            ' Apply filters based on whether it's a yearly or monthly view
            If isYearly Then
                query &= " AND STRFTIME('%Y', e.dateAdded) = @currentYear"
            ElseIf isMonthly Then
                query &= " AND STRFTIME('%Y', e.dateAdded) = @currentYear AND STRFTIME('%m', e.dateAdded) = @currentMonth"
            End If

            ' Complete the query
            query &= "
                    GROUP BY 
                    c.catName, c.color 
                    ORDER BY 
                    TotalSpent DESC; "

            Dim dt As New DataTable()

            Using conn As New SQLiteConnection(_connectionString)

                conn.Open()

                Using cmd As New SQLiteCommand(query, conn)

                    cmd.Parameters.AddWithValue("@userId", _userId)
                    cmd.Parameters.AddWithValue("@currentYear", currentDate.ToString("yyyy"))

                    If isMonthly Then cmd.Parameters.AddWithValue("@currentMonth", currentDate.ToString("MM"))

                    Using reader As SQLiteDataReader = cmd.ExecuteReader()
                        dt.Load(reader)

                    End Using
                End Using
            End Using
            Return dt

        End Function

    End Class

End Namespace