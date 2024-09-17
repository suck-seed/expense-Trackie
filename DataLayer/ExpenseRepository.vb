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


End Class
