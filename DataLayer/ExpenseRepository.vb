Imports System.Configuration
Imports System.Data.SqlClient

Public Class ExpenseRepository


    Dim connectionString As String = ConfigurationManager.ConnectionStrings("expenseTrackie").ConnectionString
    Dim userId As Integer = SessionManager.Instance.currentUserId


    Public Function insertExpense(ByVal amount As Decimal, ByVal remarks As String, ByVal dateAdded As DateTime, ByVal timeAdded As DateTime, ByVal categoryId As Integer) As Integer

        Dim expenseId As Integer = 0

        Using connection As New SqlConnection(connectionString)
            connection.Open()

            Using command As New SqlCommand("addNewExpense", connection)
                command.CommandType = CommandType.StoredProcedure


                'paremeter linking
                command.Parameters.AddWithValue("@amount", amount)
                command.Parameters.AddWithValue("@remarks", remarks)
                command.Parameters.AddWithValue("@dateAdded", dateAdded)
                command.Parameters.AddWithValue("@timeAdded", timeAdded)
                command.Parameters.AddWithValue("@catId", categoryId)
                command.Parameters.AddWithValue("@userId", userId)


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



    Public Function getTotalOfDayAllCategory(ByVal currentDate As DateTime) As Decimal
        ' datetime format = "yyyy-MM-dd"

        Dim total As Decimal = 0

        Using connection As New SqlConnection(connectionString)
            connection.Open()

            Using command As New SqlCommand("getTotalOfDayAllCategory", connection)
                command.CommandType = CommandType.StoredProcedure


                'linking input paremeter
                command.Parameters.AddWithValue("@userId", userId)
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




    Public Function getTotalOfMonthAllCategory(ByVal startingDate As DateTime, ByVal endingDate As DateTime) As Decimal
        ' datetime format = "yyyy-MM-dd"

        Dim total As Decimal = 0

        Using connection As New SqlConnection(connectionString)
            connection.Open()

            Using command As New SqlCommand("getTotalOfMonth", connection)
                command.CommandType = CommandType.StoredProcedure


                'linking input paremeter
                command.Parameters.AddWithValue("@userId", userId)
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



    Public Function getUserExpenseAllCategory(ByVal currentDate As DateTime) As DataTable

        Dim dataTable As New DataTable()

        Using connection As New SqlConnection(connectionString)
            connection.Open()

            Using command As New SqlCommand("getUserExpenseAllCategory", connection)
                command.CommandType = CommandType.StoredProcedure



                ' linking input paremeter
                command.Parameters.AddWithValue("@userId", userId)
                command.Parameters.AddWithValue("@dateAdded", currentDate)



                ' building a sqlreader that reads the rows generated by procedure
                Using dataReader As SqlDataReader = command.ExecuteReader()

                    ' loading the read rows into datatable
                    dataTable.Load(dataReader)
                End Using



            End Using

        End Using

        Return dataTable

    End Function

End Class
