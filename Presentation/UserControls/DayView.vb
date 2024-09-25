Imports expense_Trackie.Application
Imports expense_Trackie.DataLayer

Namespace Presentation

    Public Class DayView

        Public _currentDate As DateTime = DateTime.Now
        Dim _filterCount As Integer = 1
        Dim darkMode As Boolean = False

#Region "initialization / load"

        Public Sub New()

            ' This call is required by the designer.
            InitializeComponent()
            DisplayInformation()

        End Sub



        Private Sub dayView_Load(sender As Object, e As EventArgs) Handles MyBase.Load

            If My.Settings.IsLightMode = False Then
                ForeColor = Color.White
                darkMode = True
                Me.BackColor = ColorTranslator.FromHtml(My.Settings.darkPanelColor)
            Else
                Me.BackColor = ColorTranslator.FromHtml(My.Settings.lightPanelColor)
            End If

            ColorMode()
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
            LoadExpenses()

            '            expenseManager.loadExpenses(mainWindow.flowPanelCategory, currentDate)


        End Sub
#End Region



#Region " filter "

        Private Sub btn_filter_Click(sender As Object, e As EventArgs) Handles btn_filter.Click

            ' 1 = default ( by time )
            ' 2 = ascending amount (small to large)
            ' 3 = descending amount ( large to small )
            If darkMode Then
                btn_filter.Image = My.Resources.filterWhiteSelected

            Else
                btn_filter.Image = My.Resources.filterDark


            End If

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
            If darkMode Then
                btn_previous.Image = My.Resources.leftWhiteSelected
            Else

                btn_previous.Image = My.Resources.leftDark

            End If


            panel_expense_display.Controls.Clear()

            'decreasing the date by 1
            _currentDate = _currentDate.AddDays(-1)
            SessionManager.Instance.CurrentDate = _currentDate

            DisplayInformation()

            'MsgBox(SessionManager.Instance.CurrentDate)
            timer_reset_image.Start()


        End Sub



        Public Sub btn_next_Click(sender As Object, e As EventArgs) Handles btn_next.Click

            If darkMode Then
                btn_next.Image = My.Resources.rightwhiteselected
            Else
                btn_next.Image = My.Resources.rightDark


            End If

            panel_expense_display.Controls.Clear()

            _currentDate = _currentDate.AddDays(1)
            SessionManager.Instance.CurrentDate = _currentDate


            DisplayInformation()

            'MsgBox(SessionManager.Instance.CurrentDate)

            timer_reset_image.Start()

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
        Private borderRadius As Integer = 31
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






#Region " light / dark"

        Public Sub ColorMode()

            If My.Settings.IsLightMode = False Then
                'lbl_category.ForeColor = foreColor


                btn_next.Image = My.Resources.rightWhite
                btn_previous.Image = My.Resources.leftWhite
                btn_filter.Image = My.Resources.filterWhite



            End If

        End Sub
#End Region


#Region " timer for buttons "

        Private Sub timer_revertImage_Tick(sender As Object, e As EventArgs) Handles timer_reset_image.Tick


            If darkMode Then

                btn_next.Image = My.Resources.rightWhite
                btn_previous.Image = My.Resources.leftWhite
                btn_filter.Image = My.Resources.filterWhite

            Else

                btn_next.Image = My.Resources.right
                btn_previous.Image = My.Resources.left
                btn_filter.Image = My.Resources.filter



            End If

            ' Stop the timer as the image has been reverted
            timer_reset_image.Stop()
        End Sub


#End Region

    End Class
End NameSpace