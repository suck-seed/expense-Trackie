Imports System.IO
Imports expense_Trackie.Application
Imports expense_Trackie.DataLayer
'Imports Microsoft.Office.Interop.Excel

Public Class exportView


    Public SelectedDate As DateTime

    Dim _startDate, _endDate As DateTime
    Dim _selectedCategoryIds As New List(Of Integer)
    Dim _currentDate As DateTime = DateTime.Now
    Dim _userId As Integer = SessionManager.Instance.CurrentUserId

    Dim _filePath As String = "C:\Users\user\Downloads"


    'Dim time As DateTime = startDatePicker.Value.ToString("hh-mm-ss-tt")

    Dim _darkMode As Boolean = False


#Region " load "

    Private Sub exportView_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lbl_info.Text = ""
        dataGrid.ForeColor = Color.Black

        If My.Settings.IsLightMode = False Then
            ForeColor = Color.White
            _darkMode = True
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


    Public Sub DisplayInformation()


        lbl_month.Text = _currentDate.ToString("MMM")
        lbl_year.Text = _currentDate.ToString("yyyy")


        LoadCalander(AddressOf DateClicked)



    End Sub



#Region " category "

    Public Sub LoadInformation()

        'mainwindow category

        Dim categoryManager As New CategoryManager
        categoryManager.GenerateCategoryCheckButtonsExport(flowCategories, AddressOf Checkbox_CheckChanged)


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






            _selectedCategoryIds.Clear()


            LoadDataGridView()


        End If
    End Sub





    Private Sub Checkbox_CheckChanged(sender As Object, e As EventArgs)


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


    End Sub

#End Region



#Region " calander to selected individual days "




    Private Sub LoadCalander(handler As Action(Of DateTime))
        exportPanelDays.SuspendLayout()
        exportPanelDays.Controls.Clear()



        ' seting values
        Dim year As Integer = _currentDate.Year
        Dim month As Integer = _currentDate.Month

        Dim startOfTheMonth As New DateTime(year, month, 1)
        Dim daysInMonth As Integer = DateTime.DaysInMonth(year, month)
        Dim startDayOfWeek As Integer = Convert.ToInt32(startOfTheMonth.DayOfWeek.ToString("d"))


        ' Add empty placeholders for the days before the first day of the month
        For i As Integer = 1 To startDayOfWeek - 1 Step 1

            Dim md As New monthDate("")
            exportPanelDays.Controls.Add(md)

        Next

        ' Adding actual days with event
        For i As Integer = 1 To daysInMonth Step 1


            Dim currentDate As New DateTime(year, month, i)


            ' instance of dateDisplay usercontrol
            Dim dateDisplay As New monthDate(i.ToString())

            dateDisplay.Tag = currentDate





            AddHandler dateDisplay.lbl_date.Click, Sub() handler(currentDate)
            exportPanelDays.Controls.Add(dateDisplay)

        Next


        exportPanelDays.ResumeLayout(True)

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

        ClearLog()

        If radio_7days.Checked Then

            _startDate = _currentDate.AddDays(-7).ToString("yyyy-MM-dd")
            _endDate = _currentDate.ToString("yyyy-MM-dd")

            ResetCalanderDateColor()

            LoadDataGridView()
        End If

    End Sub

    Private Sub radio_14days_CheckedChanged(sender As Object, e As EventArgs) Handles radio_14days.CheckedChanged

        ClearLog()

        If radio_14days.Checked Then

            _startDate = _currentDate.AddDays(-14).ToString("yyyy-MM-dd")
            _endDate = _currentDate.ToString("yyyy-MM-dd")

            ResetCalanderDateColor()

            LoadDataGridView()

        End If

    End Sub

    Private Sub radio_30days_CheckedChanged(sender As Object, e As EventArgs) Handles radio_30days.CheckedChanged

        ClearLog()

        If radio_30days.Checked Then

            _startDate = _currentDate.AddDays(-30).ToString("yyyy-MM-dd")
            _endDate = _currentDate.ToString("yyyy-MM-dd")


            LoadDataGridView()

        End If

    End Sub



#End Region



#Region " selection 2 dates "

    Dim _startDateselected As Boolean = False
    Dim _endDateSelected As Boolean = False

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles startDatePicker.ValueChanged

        _startDate = startDatePicker.Value.ToString("yyyy-MM-dd")

        ResetCalanderDateColor()
        ClearLog()

        For Each control As Control In table_predefined.Controls

            If TypeOf control Is RadioButton Then
                Dim radioButton As RadioButton = DirectCast(control, RadioButton)

                If radioButton.Checked Then

                    radioButton.Checked = False

                End If

            End If

        Next


        _startDateselected = True
        If _startDateselected And _endDateSelected Then
            LoadDataGridView()

            _startDateselected = False
            _endDateSelected = False



        End If






    End Sub

    Private Sub DateTimePicker2_ValueChanged(sender As Object, e As EventArgs) Handles EndDatePicker.ValueChanged

        _endDate = EndDatePicker.Value.ToString("yyyy-MM-dd")

        ResetCalanderDateColor()
        ClearLog()

        For Each control As Control In table_predefined.Controls

            If TypeOf control Is RadioButton Then
                Dim radioButton As RadioButton = DirectCast(control, RadioButton)

                If radioButton.Checked Then

                    radioButton.Checked = False

                End If

            End If

        Next

        _endDateSelected = True
        If _startDateselected And _endDateSelected Then
            LoadDataGridView()

            _startDateselected = False
            _endDateSelected = False




        End If



    End Sub


#End Region



#Region " single date selected in calander "

    Private previouslySelectedLabel As Label = Nothing

    Public Sub DateClicked(ByVal currentDate As DateTime)

        ClearLog()

        ' unchecking predefined buttons
        For Each control As Control In table_predefined.Controls

            If TypeOf control Is RadioButton Then
                Dim radioButton As RadioButton = DirectCast(control, RadioButton)

                If radioButton.Checked Then

                    radioButton.Checked = False

                End If

            End If

        Next


        ' Set font of previously selected date back to normal (if any)
        If previouslySelectedLabel IsNot Nothing Then
            previouslySelectedLabel.Font = New Font(previouslySelectedLabel.Font, FontStyle.Regular)
            previouslySelectedLabel.Font = New Font(previouslySelectedLabel.Font.FontFamily, 8) ' Reset to default size (you can adjust)
            previouslySelectedLabel.ForeColor = ForeColor

        End If


        SelectedDate = currentDate

        _startDate = currentDate
        _endDate = currentDate


        ' Find the label associated with the clicked date
        For Each control As Control In exportPanelDays.Controls
            If TypeOf control Is monthDate Then
                Dim monthDateControl As monthDate = DirectCast(control, monthDate)

                If CDate(monthDateControl.Tag) = currentDate Then
                    ' Change the font of the selected label
                    monthDateControl.lbl_date.Font = New Font(monthDateControl.lbl_date.Font, FontStyle.Bold)
                    monthDateControl.lbl_date.Font = New Font(monthDateControl.lbl_date.Font.FontFamily, 11) ' Set to 13px

                    If My.Settings.IsLightMode = False Then

                        monthDateControl.lbl_date.ForeColor = ColorTranslator.FromHtml("#00af71")

                    Else
                        monthDateControl.lbl_date.ForeColor = ColorTranslator.FromHtml("#007c50")

                    End If


                    ' Store the currently selected label for future reference
                    previouslySelectedLabel = monthDateControl.lbl_date
                End If
            End If
        Next



        LoadDataGridView()

        ' got to update the datagrid vieww

    End Sub



    Private Sub ResetCalanderDateColor()
        For Each control As Control In exportPanelDays.Controls
            If TypeOf control Is monthDate Then
                Dim monthDateControl As monthDate = DirectCast(control, monthDate)


                ' Change the font of the selected label
                monthDateControl.lbl_date.Font = New Font(monthDateControl.lbl_date.Font, FontStyle.Regular)
                monthDateControl.lbl_date.Font = New Font(monthDateControl.lbl_date.Font.FontFamily, 8) ' Set to 13px
                monthDateControl.lbl_date.ForeColor = ForeColor



            End If

        Next
    End Sub

#End Region



#Region " load datagridview "

    Dim _dataTable As New Data.DataTable

    Private Sub LoadDataGridView()

        dataGrid.ClearSelection()

        If _startDate <> DateTime.MinValue AndAlso _endDate <> DateTime.MinValue Then
            Dim expenseManager As New ExpenseManager

            expenseManager.GetExpenseForExport(dataGrid, _startDate, _endDate, _selectedCategoryIds)

            Dim expenseRepository As New ExpenseRepository
            _dataTable = expenseRepository.GetExpenseExport(_startDate, _endDate, _selectedCategoryIds)

        Else

            lbl_info.Text = "StartDate or EndDate is not set"

        End If




    End Sub

#End Region



#Region "  black/white "

    Private Sub ColorMode()


        If _darkMode Then
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



            dataGrid.BackgroundColor = ColorTranslator.FromHtml(My.Settings.darkPanelColor)


        Else
            check_all.ForeColor = Color.Black
            dataGrid.BackgroundColor = ColorTranslator.FromHtml(My.Settings.lightPanelColor)


        End If



    End Sub










#End Region



#Region " timer for buttons "

    Private Sub timer_revertImage_Tick(sender As Object, e As EventArgs) Handles timer_reset_image.Tick


        If _darkMode Then

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

        Dim filePath As String = GetSaveFilePath("CSV Files|*.csv", "Save CSV File")

        If Not String.IsNullOrEmpty(filePath) Then


            Using writer As New StreamWriter(filePath)



                For Each col As DataColumn In _dataTable.Columns
                    writer.Write(col.ColumnName & ",")
                Next
                writer.WriteLine()




                For Each row As DataRow In _dataTable.Rows
                    For Each col As DataColumn In _dataTable.Columns
                        writer.Write(row(col).ToString() & ",")
                    Next
                    writer.WriteLine()
                Next



            End Using

            ExportLog(filePath)


        End If


    End Sub

    Private Sub btn_xml_Click(sender As Object, e As EventArgs) Handles btn_xml.Click
        Dim filePath As String = GetSaveFilePath("XML Files|*.xml", "Save XML File")

        If Not String.IsNullOrEmpty(filePath) Then

            If String.IsNullOrEmpty(_dataTable.TableName) Then
                _dataTable.TableName = "ExpenseData" ' You can use any meaningful name here
            End If

            _dataTable.WriteXml(filePath, XmlWriteMode.WriteSchema)


            ExportLog(filePath)

        End If

    End Sub


    Private Sub ExportLog(ByVal filepath As String)
        lbl_info.ForeColor = ColorTranslator.FromHtml("#00af71")
        lbl_info.Text = "Exported sucessfully to " & filepath
    End Sub


    Private Sub ClearLog()
        lbl_info.Text = ""
    End Sub

    Private Function GetSaveFilePath(filter As String, title As String) As String
        Dim sfd As New SaveFileDialog()

        ' Set filter for file types
        sfd.Filter = filter
        sfd.Title = title

        If sfd.ShowDialog() = DialogResult.OK Then
            Return sfd.FileName
        End If

        Return Nothing
    End Function


#End Region


    '#Region " to resolve flicker "
    '    Protected Overrides ReadOnly Property CreateParams() As CreateParams
    '        Get
    '            Dim cp As CreateParams = MyBase.CreateParams
    '            cp.ExStyle = cp.ExStyle Or &H2000000
    '            Return cp
    '        End Get
    '    End Property

    '#End Region



End Class
