Imports expense_Trackie.Application
Imports expense_Trackie.DataLayer
Imports expense_Trackie._01Presentation

Public Class dayView

    Dim currentDate As DateTime = DateTime.Now
    Dim expenseManager As New ExpenseManager()
    Dim expenseRepository As New ExpenseRepository()

    'Add a reference to mainWindow to handle category changes
    Private mainWindow As mainWindow





    Public Sub New(ByRef parentWindow As mainWindow)

        ' This call is required by the designer.
        InitializeComponent()
        updateDisplayInformation()

    End Sub



    Private Sub dayView_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        updateDisplayInformation()

    End Sub



    '
    Public Sub updateDisplayInformation()


        lbl_month.Text = currentDate.ToString("MMM")
        lbl_day.Text = currentDate.ToString("dd")
        lbl_total_amount.Text = getTotal()
        loadExpenstions()
        'expenseManager.loadExpenstions(mainWindow.flowPanelCategory, currentDate)


    End Sub



#Region "getting total for a day"

    Private Function getTotal() As Decimal

        Dim total As Decimal = expenseManager.GetTotalOfDay(currentDate.ToString("yyyy-MM-dd"))
        Return total

    End Function

#End Region

#Region "loading expense in form"

    'Public Sub loadExpenstions()

    '    Dim expenseTable As DataTable = expenseRepository.getExpensesDynamically(currentDate.ToString("yyyy-MM-dd"))

    '    panel_expenses.Controls.Clear()


    '    For Each row As DataRow In expenseTable.Rows



    '        Dim timeAdded As String = row("timeAdded").ToString
    '        Dim time As DateTime = DateTime.Parse(timeAdded)
    '        Dim formattedTime As String = time.ToString("hh:mm tt")
    '        Dim amount As Decimal = row("amount")


    '        ' creating instance of the expense Detailed display
    '        Dim expenseDisplay As New expenseDetailDisplay()


    '        expenseDisplay.lbl_amount.Text = amount.ToString()
    '        expenseDisplay.lbl_remarks.Text = row("remarks").ToString
    '        expenseDisplay.lbl_time.Text = formattedTime
    '        expenseDisplay.BackColor = ColorTranslator.FromHtml(row("color").ToString())
    '        expenseDisplay.Tag = row("eId")
    '        expenseDisplay.AutoSize = False
    '        expenseDisplay.Visible = True



    '        ' sizing and centering


    '        expenseDisplay.Height = 70

    '        expenseDisplay.Width = Me.Width - lbl_total_amount.Width - btn_previous.Width



    '        expenseDisplay.Margin = New Padding(0, 20, 0, 20)
    '        expenseDisplay.Anchor = AnchorStyles.None



    '        panel_expenses.Controls.Add(expenseDisplay)


    '    Next
    'End Sub

    Public Sub loadExpenstions()

        Dim expenseTable As DataTable = expenseRepository.GetExpensesDynamically(currentDate.ToString("yyyy-MM-dd"))

        panel_expense_display.Controls.Clear()


        For Each row As DataRow In expenseTable.Rows



            Dim timeAdded As String = row("timeAdded").ToString
            Dim time As DateTime = DateTime.Parse(timeAdded)
            Dim formattedTime As String = time.ToString("hh:mm tt")
            Dim amount As Decimal = row("amount")


            ' creating instance of the expense Detailed display
            Dim expenseDisplay As New expenseDetailDisplay()


            expenseDisplay.lbl_amount.Text = amount.ToString()
            expenseDisplay.lbl_remarks.Text = row("remarks").ToString
            expenseDisplay.lbl_time.Text = formattedTime
            expenseDisplay.BackColor = ColorTranslator.FromHtml(row("color").ToString())
            expenseDisplay.Tag = row("eId")
            expenseDisplay.AutoSize = False
            expenseDisplay.Visible = True



            ' sizing and centering


            expenseDisplay.Height = 70

            expenseDisplay.Width = Me.Width - lbl_total_amount.Width - btn_previous.Width



            expenseDisplay.Margin = New Padding(0, 20, 0, 20)
            expenseDisplay.Anchor = AnchorStyles.None



            panel_expense_display.Controls.Add(expenseDisplay)


        Next
    End Sub

#End Region


#Region "navigatio"

    ' date navigation
    Private Sub btn_previous_Click(sender As Object, e As EventArgs) Handles btn_previous.Click

        panel_expense_display.Controls.Clear()

        'decreasing the date by 1
        currentDate = currentDate.AddDays(-1)
        SessionManager.Instance.currentDate = currentDate


        updateDisplayInformation()

        'MsgBox(SessionManager.Instance.currentDate)

    End Sub



    Private Sub btn_next_Click(sender As Object, e As EventArgs) Handles btn_next.Click


        panel_expense_display.Controls.Clear()

        currentDate = currentDate.AddDays(1)
        SessionManager.Instance.currentDate = currentDate


        updateDisplayInformation()

        'MsgBox(SessionManager.Instance.currentDate)

    End Sub

#End Region




End Class
