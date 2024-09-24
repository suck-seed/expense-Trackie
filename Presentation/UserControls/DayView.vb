Imports expense_Trackie.Application
Imports expense_Trackie.DataLayer

Namespace Presentation

    Public Class DayView

        Public _currentDate As DateTime = DateTime.Now
        Dim _filterCount As Integer = 1


#Region "initialization / load"

        Public Sub New()

            ' This call is required by the designer.
            InitializeComponent()
            DisplayInformation()

        End Sub



        Private Sub dayView_Load(sender As Object, e As EventArgs) Handles MyBase.Load

            DisplayInformation()

            Me.Focus()
            Me.TabStop = True

        End Sub


#End Region


#Region "update display information"


        Public Sub DisplayInformation()


            lbl_month.Text = _currentDate.ToString("MMM")
            lbl_day.Text = _currentDate.ToString("dd")
            lbl_total_amount.Text = GetTotal()
            MsgBox(GetTotal())
            LoadExpenses()

            '            expenseManager.loadExpenses(mainWindow.flowPanelCategory, currentDate)


        End Sub
#End Region



#Region " filter "

        Private Sub btn_filter_Click(sender As Object, e As EventArgs) Handles btn_filter.Click

            ' 1 = default ( by time )
            ' 2 = ascending amount (small to large)
            ' 3 = descending amount ( large to small )
            btn_filter.Image = My.Resources.filterDark

            If _filterCount < 3 Then
                _filterCount += 1
            Else
                _filterCount = 1
            End If

            Select Case _filterCount
                Case 1
                    btn_filter.Text = "TIMe"

                Case 2
                    ' Sort by amount in ascending order
                    btn_filter.Text = "ASC"
                Case 3
                    ' Sort by amount in descending order
                    btn_filter.Text = "DES"

                Case Else

            End Select

            LoadExpenses()
            timer_reset_image.Start()


        End Sub
#End Region

#Region "navigatio"

        ' date navigation
        Public Sub btn_previous_Click(sender As Object, e As EventArgs) Handles btn_previous.Click

            'visual cues
            btn_previous.Image = My.Resources.leftDark

            panel_expense_display.Controls.Clear()

            'decreasing the date by 1
            _currentDate = _currentDate.AddDays(-1)
            SessionManager.Instance.CurrentDate = _currentDate

            DisplayInformation()

            'MsgBox(SessionManager.Instance.CurrentDate)
            timer_reset_image.Start()


        End Sub



        Public Sub btn_next_Click(sender As Object, e As EventArgs) Handles btn_next.Click

            btn_next.Image = My.Resources.rightDark

            panel_expense_display.Controls.Clear()

            _currentDate = _currentDate.AddDays(1)
            SessionManager.Instance.CurrentDate = _currentDate


            DisplayInformation()

            'MsgBox(SessionManager.Instance.CurrentDate)

            timer_reset_image.Start()

        End Sub

#End Region


#Region " visual cued for button "

        Private Sub timer_revertImage_Tick(sender As Object, e As EventArgs) Handles timer_reset_image.Tick
            ' Revert the image back to right
            btn_next.Image = My.Resources.right
            btn_previous.Image = My.Resources.left
            btn_filter.Image = My.Resources.filter

            ' Stop the timer as the image has been reverted
            timer_reset_image.Stop()
        End Sub

#End Region


#Region "getting total for a day"

        Private Function GetTotal() As Decimal

            Dim expenseManager As New ExpenseManager()
            Dim total As Decimal = expenseManager.GetTotalOfDay(_currentDate.ToString("yyyy-MM-dd"))
            Return total

        End Function

#End Region



#Region "loading expense in form"

        Public Sub LoadExpenses()

            Dim expenseManager As New ExpenseManager()

            expenseManager.LoadDayExpenses(panel_expense_display, _currentDate, _filterCount, AddressOf DeleteOnExpenseClick)

        End Sub




#End Region





#Region "expense delete functionality"
        Public Sub DeleteOnExpenseClick(ByVal eId As Integer)

            If MessageBox.Show("Do you want to delete expense ?", "Delete Expense", MessageBoxButtons.YesNo) = DialogResult.Yes Then

                Dim expenseRepository As New ExpenseRepository

                If expenseRepository.DeleteExpense(eId) > 0 Then

                    LoadExpenses()

                Else
                    MessageBox.Show("Error deleting expense", "Error")
                End If

            End If


        End Sub







#End Region






    End Class
End NameSpace