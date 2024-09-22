Imports expense_Trackie.DataLayer
Imports expense_Trackie.Presentation

Namespace Application
    Public Class ExpenseManager

        Dim _expenseRepository As New ExpenseRepository()


#Region " add new expense "


        Public Function AddNewExpense(ByVal amount As Decimal, ByVal remarks As String, ByVal dateAdded As DateTime, ByVal timeAdded As DateTime, ByVal categoryId As Integer) As Integer

            Dim added As Integer = _expenseRepository.InsertExpense(amount, remarks, dateAdded, timeAdded, categoryId)

            If added > 0 Then
                'debug
                MsgBox("Expense added successfully")

                Return added
            End If


            ' returns -1 if above isn't returned, meaning adding expense failed
            Return -1

        End Function

#End Region



#Region " total dayView "



        Public Function GetTotalOfDay(ByRef currentDate As DateTime) As Decimal

            Return _expenseRepository.GetTotalOfDayAllCategory(currentDate)

        End Function

#End Region




        Public Function GetTotalOfMonth(ByVal currentDate As DateTime) As Decimal

            Dim startingDate As New DateTime(currentDate.Year, currentDate.Month, 1)
            Dim endingDate As New DateTime(currentDate.Year, currentDate.Month, DateTime.DaysInMonth(currentDate.Year, currentDate.Month))

            Return _expenseRepository.GetTotalOfMonthAllCategory(startingDate, endingDate)

        End Function




        ' load expense into panel
        Public Sub LoadDayExpenses(ByRef panel As TableLayoutPanel, ByRef currentDate As DateTime, handler As Action(Of Integer))



            Dim expenseTable As DataTable = _expenseRepository.GetExpensesDynamically(currentDate.ToString("yyyy-MM-dd"))

            panel.SuspendLayout()
            panel.Controls.Clear()
            panel.RowCount = 0
            panel.RowStyles.Clear()
            panel.Padding = New Padding(0, 10, 0, 10)

            For Each row As DataRow In expenseTable.Rows


                'parsing values from row
                Dim amount As String = row("amount").ToString()
                Dim remarks As String = row("remarks").ToString()

                Dim timeAdded As String = row("timeAdded").ToString
                Dim time As DateTime = DateTime.Parse(timeAdded)
                Dim formattedTime As String = time.ToString("hh:mm tt")



                ' creating instance of the expense Detailed display
                Dim expenseInfo As New ExpenseDetailDisplay()


                'setting values in the display
                expenseInfo.lbl_amount.Text = amount
                expenseInfo.lbl_remarks.Text = remarks
                expenseInfo.lbl_time.Text = formattedTime
                expenseInfo.BackColor = ColorTranslator.FromHtml(row("color").ToString())
                expenseInfo.Tag = row("eId")

                'sizing the panels
                expenseInfo.Margin = New Padding(100, 10, 100, 10)
                expenseInfo.AutoSize = False
                expenseInfo.Visible = True
                expenseInfo.Anchor = AnchorStyles.Top
                expenseInfo.Dock = DockStyle.Top




                'event handler
                Dim eId As Integer = CInt(expenseInfo.Tag)
                AddHandler expenseInfo.lbl_amount.Click, Sub() handler(eId)
                AddHandler expenseInfo.lbl_remarks.Click, Sub() handler(eId)
                AddHandler expenseInfo.lbl_amount.Click, Sub() handler(eId)


                'row management
                panel.RowCount += 1
                panel.RowStyles.Add(New RowStyle(SizeType.Absolute, 90))


                'adding into table layout panel
                panel.Controls.Add(expenseInfo, 0, panel.RowCount - 1)



                ' adding arko row for spacing
                panel.RowCount += 1
                panel.RowStyles.Add(New RowStyle(SizeType.Absolute, 20))

            Next

            panel.ResumeLayout(True)

        End Sub





#Region " load expense in monthView "

        Public Sub LoadMonthExpenses(ByRef panel As TableLayoutPanel, ByRef currentDate As DateTime)


            Dim expenseTable As DataTable = _expenseRepository.GetExpensesDynamically(currentDate.ToString("yyyy-MM-dd"))

            panel.SuspendLayout()
            panel.Controls.Clear()
            panel.RowCount = 0
            panel.RowStyles.Clear()
            panel.Padding = New Padding(0, 10, 0, 10)

            For Each row As DataRow In expenseTable.Rows


                'parsing values from row
                Dim amount As String = row("amount").ToString()
                Dim remarks As String = row("remarks").ToString()

                Dim timeAdded As String = row("timeAdded").ToString
                Dim time As DateTime = DateTime.Parse(timeAdded)
                Dim formattedTime As String = time.ToString("hh:mm tt")



                ' creating instance of the expense Detailed display
                Dim expenseInfo As New ExpenseRemarksDisplay()


                'setting values in the display
                expenseInfo.lbl_remark.Text = remarks
                expenseInfo.BackColor = ColorTranslator.FromHtml(row("color").ToString())
                expenseInfo.Tag = row("eId")

                'sizing the panels
                'expenseInfo.Margin = New Padding(100, 10, 100, 10)
                expenseInfo.AutoSize = False
                expenseInfo.Visible = True
                expenseInfo.Anchor = AnchorStyles.Top
                expenseInfo.Dock = DockStyle.Top




                'row management
                panel.RowCount += 1
                panel.RowStyles.Add(New RowStyle(SizeType.Absolute, 30))


                'adding into table layout panel
                panel.Controls.Add(expenseInfo, 0, panel.RowCount - 1)

                If panel.RowCount > 5 Then
                    Return
                End If

                ' adding arko row for spacing
                panel.RowCount += 1
                panel.RowStyles.Add(New RowStyle(SizeType.Absolute, 5))

            Next

            panel.ResumeLayout(True)


        End Sub


#End Region



    End Class

End NameSpace