Imports expense_Trackie.Application
Imports expense_Trackie.DataLayer

Namespace Presentation

    Public Class DayView

        Public CurrentDate As DateTime = DateTime.Now
        Dim _filterCount As Integer = 1
        Dim _darkMode As Boolean = False

        Dim totalExpenseToday As Decimal
        Dim wasAboveLimit As Boolean = False

        Dim _calenderView As CalanderView

#Region "initialization / load"

        Public Sub New()

            ' This call is required by the designer.


            InitializeComponent()
            DisplayInformation()

        End Sub



        Private Sub dayView_Load(sender As Object, e As EventArgs) Handles MyBase.Load

            If My.Settings.IsLightMode = False Then
                ForeColor = Color.White
                _darkMode = True
                Me.BackColor = ColorTranslator.FromHtml(My.Settings.darkPanelColor)
                panel_expense_display.BackColor = ColorTranslator.FromHtml(My.Settings.darkPanelColor)

            Else
                Me.BackColor = ColorTranslator.FromHtml(My.Settings.lightPanelColor)
                panel_expense_display.BackColor = ColorTranslator.FromHtml(My.Settings.lightPanelColor)

            End If

            ColorMode()
            DisplayInformation()

            Me.Focus()
            Me.TabStop = True

        End Sub


#End Region


#Region "update display information"


        Public Sub DisplayInformation()


            LoadExpenses()

            lbl_month.Text = CurrentDate.ToString("MMM")
            lbl_day.Text = CurrentDate.ToString("dd")

            totalExpenseToday = GetTotal(CurrentDate)
            lbl_total_amount.Text = totalExpenseToday

            '            expenseManager.loadExpenses(mainWindow.flowPanelCategory, currentDate)
            ' checking if above limit or below limit
            If totalExpenseToday > SessionManager.Instance.CurrentDailyLimit Then

                wasAboveLimit = True

            End If


        End Sub
#End Region



#Region " filter "

        Private Sub btn_filter_Click(sender As Object, e As EventArgs) Handles btn_filter.Click

            ' 1 = default ( by time )
            ' 2 = ascending amount (small to large)
            ' 3 = descending amount ( large to small )
            If _darkMode Then
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
        Private Sub btn_previous_Click(sender As Object, e As EventArgs) Handles btn_previous.Click

            'visual cues
            If _darkMode Then
                btn_previous.Image = My.Resources.leftWhiteSelected
            Else

                btn_previous.Image = My.Resources.leftDark

            End If


            panel_expense_display.Controls.Clear()

            'decreasing the date by 1
            CurrentDate = CurrentDate.AddDays(-1)
            SessionManager.Instance.CurrentDate = CurrentDate

            DisplayInformation()

            'MsgBox(SessionManager.Instance.CurrentDate)
            timer_reset_image.Start()


        End Sub


        Private Sub btn_next_Click(sender As Object, e As EventArgs) Handles btn_next.Click

            If _darkMode Then
                btn_next.Image = My.Resources.rightwhiteselected
            Else
                btn_next.Image = My.Resources.rightDark


            End If

            panel_expense_display.Controls.Clear()

            CurrentDate = CurrentDate.AddDays(1)
            SessionManager.Instance.CurrentDate = CurrentDate


            DisplayInformation()

            'MsgBox(SessionManager.Instance.CurrentDate)

            timer_reset_image.Start()

        End Sub

#End Region





#Region "getting total for a day"

        Public Function GetTotal(ByVal currentDate As DateTime) As Decimal

            Dim expenseManager As New ExpenseManager()
            Dim total As Decimal = expenseManager.GetTotalOfDay(currentDate.ToString("yyyy-MM-dd"))
            Return total

        End Function

#End Region



#Region "loading expense in form"
        Private _borderRadius As Integer = 31
        Public Sub LoadExpenses()

            Dim expenseManager As New ExpenseManager()

            expenseManager.LoadDayExpenses(panel_expense_display, CurrentDate, _filterCount, AddressOf DeleteOnExpenseClick)

        End Sub







#End Region





#Region "expense delete functionality"

        Private Sub DeleteOnExpenseClick(ByVal eId As Integer)

            If MessageBox.Show("Do you want to delete expense ?", "Delete Expense", MessageBoxButtons.YesNo) = DialogResult.Yes Then

                Dim expenseRepository As New ExpenseRepository

                If expenseRepository.DeleteExpense(eId) > 0 Then


                    ' change the total, and the expenses displayed



                    ' refresh monthView
                    MainWindow.UpdateMonth()




                    'if aboveLimit is true and after deleting limit went below, then update calander display
                    If wasAboveLimit = True And GetTotal(CurrentDate) < SessionManager.Instance.CurrentDailyLimit Then

                        MainWindow.UpdateCalander()

                    End If




                    DisplayInformation()


                Else
                    MessageBox.Show("Error deleting expense", "Error")
                End If

            End If


        End Sub













#End Region






#Region " light / dark"

        Private Sub ColorMode()

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


            If _darkMode Then

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


        '#Region " to resolve flicker "
        '        Protected Overrides ReadOnly Property CreateParams() As CreateParams
        '            Get
        '                Dim cp As CreateParams = MyBase.CreateParams
        '                cp.ExStyle = cp.ExStyle Or &H2000000
        '                Return cp
        '            End Get
        '        End Property

        '#End Region

    End Class
End NameSpace