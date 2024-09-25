Imports expense_Trackie.Application
'Imports Microsoft.Office.Interop.Excel
Public Class exportView


    Public selectedDate As DateTime

    Dim startDate, endDate As DateTime
    Dim _selectedCategoryIds As New List(Of Integer)
    Dim _currentDate As DateTime = DateTime.Now
    Dim _userId As Integer = SessionManager.Instance.CurrentUserId

    Dim filePath As String = "C:\Users\user\Downloads"

    Dim darkMode As Boolean = False


#Region " load "

    Private Sub exportView_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lbl_info.Text = ""

        If My.Settings.IsLightMode = False Then
            ForeColor = Color.White
            darkMode = True
            Me.BackColor = ColorTranslator.FromHtml(My.Settings.darkPanelColor)
        Else
            Me.BackColor = ColorTranslator.FromHtml(My.Settings.lightPanelColor)
        End If


        ColorMode()


        'hiding filter bar
        panel_filter.Visible = False

        DisplayInformation()
        LoadInformation()

    End Sub

#End Region


#Region " category "

    Public Sub LoadInformation()

        'mainwindow category

        Dim _categoryManager As New CategoryManager
        _categoryManager.GenerateCategoryCheckButtonsExport(flowCategories, AddressOf Checkbox_CheckChanged)


        ' 


    End Sub


    Private Sub check_all_CheckedChanged(sender As Object, e As EventArgs) Handles check_all.CheckedChanged

        If check_all.Checked = True Then

            ' unchecking all the checks
            For Each control As Control In flowCategories.Controls

                If TypeOf control Is CheckBox Then
                    Dim checkBox As CheckBox = DirectCast(control, CheckBox)

                    If checkBox.Checked Then
                        checkBox.Checked = False

                    End If
                End If

            Next



            ' clearning selectedCategoryIds
            'Dim selectedCategoryIds As New List(Of Integer)

            ' if all is selected
            _selectedCategoryIds.Clear()
            'SessionManager.SelectedCategoryIds = selectedCategoryIds

            LoadDataGridView()


        End If
    End Sub





    Private Sub Checkbox_CheckChanged(sender As Object, e As EventArgs)

        MsgBox("hello")

        _selectedCategoryIds.Clear()

        check_all.Checked = False

        'Dim selectedCategoryIds As New List(Of Integer)


        For Each control As Control In flowCategories.Controls

            If TypeOf control Is CheckBox Then
                Dim checkBox As CheckBox = DirectCast(control, CheckBox)

                If checkBox.Checked = True Then
                    Dim categoryId As Integer = CInt(checkBox.Tag)

                    MsgBox(categoryId)
                    MsgBox(CInt(checkBox.Tag))

                    _selectedCategoryIds.Add(categoryId)
                End If

            End If

        Next

        SessionManager.SelectedCategoryIds = _selectedCategoryIds

        LoadDataGridView()

        MsgBox("hello")

    End Sub

#End Region



#Region " calander to selected individual days "




    Private Sub LoadCalander(handler As Action(Of DateTime))
        exportPanelDays.SuspendLayout()
        exportPanelDays.Controls.Clear()



        ' seting values
        Dim year As Integer = _currentDate.Year
        Dim month As Integer = _currentDate.Month

        Dim StartOfTheMonth As New DateTime(year, month, 1)
        Dim DaysInMonth As Integer = DateTime.DaysInMonth(year, month)
        Dim StartDayOfWeek As Integer = Convert.ToInt32(StartOfTheMonth.DayOfWeek.ToString("d"))


        ' Add empty placeholders for the days before the first day of the month
        For i As Integer = 1 To StartDayOfWeek - 1 Step 1

            Dim md As New monthDate("")
            exportPanelDays.Controls.Add(md)

        Next

        ' Adding actual days with event
        For i As Integer = 1 To DaysInMonth Step 1


            Dim currentDate As New DateTime(year, month, i)


            ' instance of dateDisplay usercontrol
            Dim dateDisplay As New monthDate(i.ToString())

            dateDisplay.Tag = currentDate





            AddHandler dateDisplay.lbl_date.Click, Sub() handler(currentDate)
            exportPanelDays.Controls.Add(dateDisplay)

        Next


        exportPanelDays.ResumeLayout(True)

    End Sub





    Public Sub DisplayInformation()


        lbl_month.Text = _currentDate.ToString("MMM")
        lbl_year.Text = _currentDate.ToString("yyyy")


        LoadCalander(AddressOf DateClicked)



    End Sub



    Private Sub month_previous_Click(sender As Object, e As EventArgs) Handles month_previous.Click

        exportPanelDays.Controls.Clear()

        'decreasing the date by 1
        _currentDate = _currentDate.AddMonths(-1)
        DisplayInformation()


    End Sub

    Private Sub month_next_Click(sender As Object, e As EventArgs) Handles month_next.Click

        exportPanelDays.Controls.Clear()

        _currentDate = _currentDate.AddMonths(1)
        DisplayInformation()

    End Sub

#End Region



#Region " show side filter panel "
    Private Sub btn_fiterShow_Click(sender As Object, e As EventArgs) Handles btn_fiterShow.Click

        If My.Settings.IsLightMode = False Then
            btn_fiterShow.Image = My.Resources.exportFilterWhiteSelected
        Else
            btn_fiterShow.Image = My.Resources.exportFilterDark
        End If

        panel_filter.Visible = Not panel_filter.Visible

        timer_reset_image.Start()

    End Sub

#End Region



#Region " selections predefined"


    Private Sub radio_7days_CheckedChanged(sender As Object, e As EventArgs) Handles radio_7days.CheckedChanged

        If radio_7days.Checked Then

            startDate = _currentDate.AddDays(-7).ToString("yyyy-MM-dd")
            endDate = _currentDate.ToString("yyyy-MM-dd")



            LoadDataGridView()
        End If

    End Sub

    Private Sub radio_14days_CheckedChanged(sender As Object, e As EventArgs) Handles radio_14days.CheckedChanged

        If radio_14days.Checked Then

            startDate = _currentDate.AddDays(-14).ToString("yyyy-MM-dd")
            endDate = _currentDate.ToString("yyyy-MM-dd")



            LoadDataGridView()

        End If

    End Sub

    Private Sub radio_30days_CheckedChanged(sender As Object, e As EventArgs) Handles radio_30days.CheckedChanged

        If radio_30days.Checked Then

            startDate = _currentDate.AddDays(-30).ToString("yyyy-MM-dd")
            endDate = _currentDate.ToString("yyyy-MM-dd")


            LoadDataGridView()

        End If

    End Sub



#End Region



#Region " selection 2 dates "

    Dim startDateselected As Boolean = False
    Dim endDateSelected As Boolean = False

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles startDatePicker.ValueChanged

        startDate = startDatePicker.Value.ToString("yyyy-MM-dd")



        For Each control As Control In table_predefined.Controls

            If TypeOf control Is RadioButton Then
                Dim radioButton As RadioButton = DirectCast(control, RadioButton)

                If radioButton.Checked Then

                    radioButton.Checked = False

                End If

            End If

        Next


        startDateselected = True
        If startDateselected And endDateSelected Then
            LoadDataGridView()

            startDateselected = False
            endDateSelected = False



        End If






    End Sub

    Private Sub DateTimePicker2_ValueChanged(sender As Object, e As EventArgs) Handles EndDatePicker.ValueChanged

        endDate = EndDatePicker.Value.ToString("yyyy-MM-dd")


        For Each control As Control In table_predefined.Controls

            If TypeOf control Is RadioButton Then
                Dim radioButton As RadioButton = DirectCast(control, RadioButton)

                If radioButton.Checked Then

                    radioButton.Checked = False

                End If

            End If

        Next

        endDateSelected = True
        If startDateselected And endDateSelected Then
            LoadDataGridView()

            startDateselected = False
            endDateSelected = False




        End If



    End Sub


#End Region



#Region " single date selected in calander "

    Public Sub DateClicked(ByVal currentDate As DateTime)

        ' unchecking predefined buttons
        For Each control As Control In table_predefined.Controls

            If TypeOf control Is RadioButton Then
                Dim radioButton As RadioButton = DirectCast(control, RadioButton)

                If radioButton.Checked Then

                    radioButton.Checked = False

                End If

            End If

        Next



        selectedDate = currentDate

        startDate = currentDate
        endDate = currentDate



        LoadDataGridView()

        ' got to update the datagrid vieww

    End Sub

#End Region



#Region " load datagridview "

    Private Sub LoadDataGridView()

        dataGrid.ClearSelection()

        If startDate <> DateTime.MinValue AndAlso endDate <> DateTime.MinValue Then
            Dim expenseManager As New ExpenseManager

            expenseManager.GetExpenseForExport(dataGrid, startDate, endDate, _selectedCategoryIds)
        Else

            lbl_info.Text = "StartDate or EndDate is not set"

        End If




    End Sub

#End Region



#Region "  black/white "

    Private Sub ColorMode()


        If darkMode Then
            radio_14days.ForeColor = Color.Black
            radio_30days.ForeColor = Color.Black
            radio_7days.ForeColor = Color.Black
            btn_fiterShow.Image = My.Resources.exportFilterWhite
            month_previous.Image = My.Resources.previousWhite
            month_next.Image = My.Resources.nextWhite
            check_all.ForeColor = Color.Black

            btn_excel.Image = My.Resources.excelWhite
            btn_csv.Image = My.Resources.csvWhite
            btn_xml.Image = My.Resources.xmlWhite



        Else
            check_all.ForeColor = Color.Black

        End If



    End Sub










#End Region



#Region " timer for buttons "

    Private Sub timer_revertImage_Tick(sender As Object, e As EventArgs) Handles timer_reset_image.Tick


        If darkMode Then

            btn_fiterShow.Image = My.Resources.exportFilterWhite

        Else

            btn_fiterShow.Image = My.Resources.exportFilter

        End If

        ' Stop the timer as the image has been reverted
        timer_reset_image.Stop()
    End Sub


#End Region



#Region " main functionality "
    Private Sub btn_excel_Click(sender As Object, e As EventArgs) Handles btn_excel.Click

    End Sub

    Private Sub btn_csv_Click(sender As Object, e As EventArgs) Handles btn_csv.Click

    End Sub

    Private Sub btn_xml_Click(sender As Object, e As EventArgs) Handles btn_xml.Click

    End Sub

#End Region



End Class
