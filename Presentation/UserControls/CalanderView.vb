Imports expense_Trackie.Application

Namespace Presentation

    Public Class CalanderView


        Dim _currentDate As DateTime = DateTime.Now

#Region " new / load"

        Dim _dayView As DayView

        Public Sub New(ByRef dayViewInst As DayView)

            InitializeComponent()

            _dayView = dayViewInst
            DisplayInformation()

        End Sub


        Dim _darkMode As Boolean = False

        Private Sub CalanderView_Load(sender As Object, e As EventArgs) Handles Me.Load

            If My.Settings.IsLightMode = False Then

                _darkMode = True
            Else

            End If

            ColorMode()
            DisplayInformation()



        End Sub


#End Region




        Public Sub DisplayInformation()


            lbl_month.Text = _currentDate.ToString("MMM")
            lbl_year.Text = _currentDate.ToString("yyyy")


            ShowDays(AddressOf DateClicked)



        End Sub




#Region " navigation "


        Private Sub month_previous_Click(sender As Object, e As EventArgs) Handles month_previous.Click

            fpanel_dates.Controls.Clear()

            'decreasing the date by 1
            _currentDate = _currentDate.AddMonths(-1)
            DisplayInformation()


        End Sub

        Private Sub month_next_Click(sender As Object, e As EventArgs) Handles month_next.Click

            fpanel_dates.Controls.Clear()

            _currentDate = _currentDate.AddMonths(1)
            DisplayInformation()

        End Sub

#End Region





#Region " showing days "

        Private Sub ShowDays(handler As Action(Of DateTime))


            'clear previous controls
            fpanel_dates.SuspendLayout()
            fpanel_dates.Controls.Clear()


            ' seting values
            Dim year As Integer = _currentDate.Year
            Dim month As Integer = _currentDate.Month

            Dim startOfTheMonth As New DateTime(year, month, 1)
            Dim daysInMonth As Integer = DateTime.DaysInMonth(year, month)
            Dim startDayOfWeek As Integer = Convert.ToInt32(startOfTheMonth.DayOfWeek.ToString("d"))



            ' Add empty placeholders for the days before the first day of the month
            For i As Integer = 1 To startDayOfWeek - 1 Step 1

                Dim md As New monthDate("")
                fpanel_dates.Controls.Add(md)

            Next


            ' Adding actual days with event
            For i As Integer = 1 To daysInMonth Step 1


                Dim currentDate As New DateTime(year, month, i)


                ' instance of dateDisplay usercontrol
                Dim dateDisplay As New monthDate(i.ToString())

                dateDisplay.Tag = currentDate

                If currentDate = DateTime.Now.ToString("yyyy-MM-dd") Then
                    ' Change the font of the selected label
                    dateDisplay.lbl_date.Font = New Font(dateDisplay.lbl_date.Font, FontStyle.Bold)
                    dateDisplay.lbl_date.Font = New Font(dateDisplay.lbl_date.Font.FontFamily, 11) ' Set to 13px

                End If


                ' setting back red if 
                Dim total As Decimal = GetTotal(currentDate)
                If total > SessionManager.Instance.CurrentDailyLimit Then

                    dateDisplay.lbl_date.BackColor = ColorTranslator.FromHtml("#fa5252")


                End If

                AddHandler dateDisplay.lbl_date.Click, Sub() handler(currentDate)
                fpanel_dates.Controls.Add(dateDisplay)

            Next


            fpanel_dates.ResumeLayout(True)

        End Sub


#End Region



#Region " get total "


        Private Function GetTotal(ByVal currentdate As DateTime) As Decimal

            Dim expenseManager As New ExpenseManager()
            Dim total As Decimal = expenseManager.GetTotalOfDay(currentdate.ToString("yyyy-MM-dd"))
            Return total

        End Function

#End Region


#Region " dateClicked "

        Private Sub DateClicked(ByVal currentDate As DateTime)


            'MainWindow.panel_main.Controls.Clear()
            'If MainWindow.radio_home.Checked = True Then

            MainWindow.radio_day_view.Checked = True
            MainWindow.radio_month_view.Checked = False
            MainWindow.radio_home.Checked = True

            _dayView.CurrentDate = currentDate
            _dayView.DisplayInformation()

            'End If


            'If MainWindow.radio_export.Checked = True Then

            '    _exportView.selectedDate = currentDate

            'End If


        End Sub


#End Region


#Region " light / dark"

        Private Sub ColorMode()

            If My.Settings.IsLightMode = False Then
                'lbl_category.ForeColor = foreColor

                month_previous.Image = My.Resources.previousWhite
                month_next.Image = My.Resources.nextWhite




            End If

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