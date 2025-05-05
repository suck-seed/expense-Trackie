
Imports System.Drawing.Drawing2D
Imports System.IO
Imports expense_Trackie.Application
Namespace Presentation

    Public Class MainWindow

        Dim _categoryManager As New CategoryManager()

#Region " predefined instance of userControls "


        ' this makes object defined here available in other forms too
        Dim _dayView As New DayView()
        Dim _monthView As New MonthView(_dayView)
        Dim _exportView As New exportView()
        Dim _calanderView As New CalanderView(_dayView)



        Public Sub UpdateDayView()
            _dayView.DisplayInformation()
        End Sub

        Public Sub UpdateMonth()
            _monthView.DisplayInformation()
        End Sub

        Public Sub UpdateCalander()
            _calanderView.DisplayInformation()
        End Sub


        Public Sub UpdateExport()
            _exportView.DisplayInformation()
            _exportView.LoadInformation()
        End Sub

#End Region


#Region " form load / calander load "

        ReadOnly _borderRadius As Integer = 20
        Dim _darkMode As Boolean = False

        Private Sub MybaseLoad(sender As Object, e As EventArgs) Handles MyBase.Load


            'If My.Settings.firstLoad = True Then

            panel_main.BackgroundImage = My.Resources.tutorial
            panel_main.BackgroundImageLayout = ImageLayout.Stretch

            'Else

            'radio_home.Checked = True


            'End If




            ' loading information to form

            If My.Settings.IsLightMode = False Then
                ForeColor = Color.White
                _darkMode = True
                Me.BackColor = ColorTranslator.FromHtml("#191D1C")
                panel_main.BackColor = ColorTranslator.FromHtml(My.Settings.darkPanelColor)
            Else
                Me.BackColor = ColorTranslator.FromHtml("#EEF4F9")
                panel_main.BackColor = ColorTranslator.FromHtml(My.Settings.lightPanelColor)
            End If

            ColorMode()

            LoadInformation()
            LoadUserInformation()

            LoadCalander()


            'rounded
            SetRoundedShape(Me, _borderRadius)
            Me.SetStyle(ControlStyles.ResizeRedraw, True)
            Me.SetStyle(ControlStyles.OptimizedDoubleBuffer, True)

            _monthView.LoadDays()


        End Sub

#End Region


#Region " round shaping "

        Private Sub SetRoundedShape(ctrl As Control, radius As Integer)
            Dim rPath As New GraphicsPath()

            ' Create a new rectangle that exactly fits the control's size
            Dim rect As New Rectangle(0, 0, ctrl.Width, ctrl.Height)

            ' Create rounded corners with arcs and straight lines
            rPath.AddArc(New Rectangle(rect.X, rect.Y, radius, radius), 180, 90) ' Top-left corner
            rPath.AddArc(New Rectangle(rect.Width - radius, rect.Y, radius, radius), -90, 90) ' Top-right corner
            rPath.AddArc(New Rectangle(rect.Width - radius, rect.Height - radius, radius, radius), 0, 90) ' Bottom-right corner
            rPath.AddArc(New Rectangle(rect.X, rect.Height - radius, radius, radius), 90, 90) ' Bottom-left corner
            rPath.CloseFigure()

            ' Apply the smooth path to the control's region
            ctrl.Region = New Region(rPath)
        End Sub


        Protected Overrides Sub OnPaint(e As PaintEventArgs)
            MyBase.OnPaint(e)

            ' Enable anti-aliasing for smoother edges
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias

            ' You can add additional painting code here for custom effects if needed
        End Sub


        Private Sub ExpenseDetailDisplay_Resize(sender As Object, e As EventArgs) Handles Me.Resize
            SetRoundedShape(Me, _borderRadius)
        End Sub

#End Region


#Region "Load Calander"
        Sub LoadCalander()

            panel_calender.Controls.Add(_calanderView)

        End Sub


#End Region


#Region " loadInformation() "



        Public Sub LoadUserInformation()

            MakePictureBoxCircular(img_profile)


            Dim path = SessionManager.Instance.CurrentProfileLink

            If Not String.IsNullOrEmpty(path) AndAlso File.Exists(path) Then
                ' Dispose old image (if any)
                If img_profile.Image IsNot Nothing Then
                    img_profile.Image.Dispose()
                    img_profile.Image = Nothing
                End If


                Dim raw = File.ReadAllBytes(path)
                Using ms As New MemoryStream(raw)
                    img_profile.Image = Image.FromStream(ms)
                End Using

            Else

                ' fallback to default
                If img_profile.Image IsNot Nothing Then
                    img_profile.Image.Dispose()
                End If
                img_profile.Image = My.Resources.defaultProfile

            End If


        End Sub


        Public Sub LoadInformation()

            'mainwindow category
            _categoryManager.GenerateCategoryCheckButtons(flowPanelCategory, AddressOf Checkbox_CheckChanged)


            ' dayview refresh



        End Sub

#End Region


#Region " month/day "

        Dim firstHomeClick As Boolean = True

        Private Sub radio_home_view_clicked(sender As Object, e As EventArgs) Handles radio_home.CheckedChanged


            ' if clicked home for the first time
            If radio_home.Checked And firstHomeClick = True Then

                firstHomeClick = False
                panel_day_month.Visible = True
                radio_day_view.Checked = True

                panel_year_month.Visible = False


            ElseIf radio_home.Checked = True Then


                panel_day_month.Visible = True
                panel_main.Controls.Clear()

                panel_year_month.Visible = False


            End If


        End Sub

        Private Sub radio_month_view_CheckedChanged(sender As Object, e As EventArgs) Handles radio_month_view.CheckedChanged, radio_home.CheckedChanged

            If radio_home.Checked Then

                If radio_month_view.Checked Then

                    DisplayForm(_monthView)
                    '_monthView.LoadDays()

                    If _darkMode Then

                        radio_month_view.Image = My.Resources.monthWhiteSelected

                    Else
                        radio_month_view.Image = My.Resources.monthDark

                    End If


                Else

                    If _darkMode Then

                        radio_month_view.Image = My.Resources.monthWhite

                    Else
                        radio_month_view.Image = My.Resources.monthLight

                    End If
                End If

            End If





        End Sub



        Private Sub radio_day_view_checkChanged(sender As Object, e As EventArgs) Handles radio_day_view.CheckedChanged, radio_home.CheckedChanged


            'checking day
            If radio_home.Checked Then

                If radio_day_view.Checked Then

                    DisplayForm(_dayView)
                    '_dayView.LoadExpenses()

                    If _darkMode Then

                        radio_day_view.Image = My.Resources.dayViewWhiteSelected

                    Else
                        radio_day_view.Image = My.Resources.dayDark

                    End If

                Else

                    If _darkMode Then

                        radio_day_view.Image = My.Resources.dayViewWhite

                    Else
                        radio_day_view.Image = My.Resources.dayLight

                    End If

                End If

            End If





        End Sub

        Private currentView As String ' "DayView" or "MonthView"

        Private Sub DisplayForm(control As UserControl)




            panel_main.Controls.Clear()

            With control

                .Dock = DockStyle.Fill
                panel_main.Controls.Add(control)
                .BringToFront()
                .Show()

            End With


            'MessageBox.Show("Docking set to: " & form.Dock.ToString())
        End Sub

#End Region


#Region " export "

        Private Sub ExportRadioClicked(sender As Object, e As EventArgs) Handles radio_export.CheckedChanged
            panel_day_month.Visible = False



            If radio_export.Checked = True Then


                DisplayForm(_exportView)
                '_dayView.LoadExpenses()





            End If

        End Sub

#End Region


#Region " analytical view "

        Dim _analysisView As New analyticalView(0, 1)
        Dim isFirstTimeAnalysis = True

        Private Sub radionasas(sender As Object, e As EventArgs) Handles radio_analytical.CheckedChanged

            panel_day_month.Visible = False
            panel_year_month.Visible = True


            If isFirstTimeAnalysis Then
                DisplayForm(_analysisView)
                radio_analyze_monthly.Checked = True
            End If



        End Sub

        Private Sub ausahsuahsas(sender As Object, e As EventArgs) Handles radio_analyze_monthly.CheckedChanged

            If radio_analyze_monthly.Checked Then

                Dim AnalysisViewMonth As New analyticalView(0, 1)
                DisplayForm(AnalysisViewMonth)
            End If


        End Sub


        Private Sub ausahsuhsas(sender As Object, e As EventArgs) Handles radio_analysis_year.CheckedChanged

            If radio_analysis_year.Checked Then
                Dim AnalysisViewMonth As New analyticalView(1, 0)
                DisplayForm(AnalysisViewMonth)
            End If



        End Sub

        Private Sub ashsuas(sender As Object, e As EventArgs) Handles radio_analyze_monthly.CheckedChanged, radio_analysis_year.CheckedChanged

            If radio_analysis_year.Checked Then

                If _darkMode = True Then

                    radio_analysis_year.Image = My.Resources.YearAnalysisLightSelected
                Else
                    radio_analysis_year.Image = My.Resources.yearAnalysisDark

                End If
            Else
                If _darkMode = True Then

                    radio_analysis_year.Image = My.Resources.yearAnalysisWhite
                Else
                    radio_analysis_year.Image = My.Resources.yearAnalysis

                End If

            End If


            If radio_analyze_monthly.Checked Then

                If _darkMode = True Then

                    radio_analyze_monthly.Image = My.Resources.monthWhiteSelected
                Else
                    radio_analyze_monthly.Image = My.Resources.monthDark

                End If

            Else
                If _darkMode = True Then

                    radio_analyze_monthly.Image = My.Resources.monthWhite
                Else
                    radio_analyze_monthly.Image = My.Resources.monthLight

                End If
            End If

        End Sub



        'by default it is monthly view





#End Region


#Region "get selected category"


        Private Sub check_all_CheckedChanged(sender As Object, e As EventArgs) Handles check_all.CheckedChanged

            If check_all.Checked = True Then

                ' unchecking all the checks
                For Each control As Control In flowPanelCategory.Controls

                    If TypeOf control Is CheckBox Then
                        Dim checkBox As CheckBox = DirectCast(control, CheckBox)


                        If checkBox.Checked = True Then
                            checkBox.Checked = False
                        End If

                    End If

                Next



                ' clearning selectedCategoryIds
                Dim selectedCategoryIds As New List(Of Integer)

                ' if all is selected
                selectedCategoryIds.Clear()
                SessionManager.SelectedCategoryIds = selectedCategoryIds


            End If

        End Sub



        ' event handling
        Private Sub Checkbox_CheckChanged(sender As Object, e As EventArgs)

            check_all.Checked = False

            Dim selectedCategoryIds As New List(Of Integer)

            For Each control As Control In flowPanelCategory.Controls

                If TypeOf control Is CheckBox Then
                    Dim checkBox As CheckBox = DirectCast(control, CheckBox)

                    If checkBox.Checked Then
                        Dim categoryId As Integer = CInt(checkBox.Tag)
                        selectedCategoryIds.Add(categoryId)
                    End If

                End If

            Next

            SessionManager.SelectedCategoryIds = selectedCategoryIds

            'If panel_main.Controls(0) Is _dayView Then

            _dayView.LoadExpenses()

            'ElseIf panel_main.Controls(0) Is _monthView Then

            _monthView.LoadDays()

            'End If


        End Sub


#End Region


#Region " app settings "
        Private Sub btn_appSetting_Click(sender As Object, e As EventArgs) Handles btn_appSetting.Click

            If _darkMode Then
                btn_appSetting.Image = My.Resources.settingwhite32selected
            Else
                btn_appSetting.Image = My.Resources.setting32dark

            End If

            timer_reset_image.Start()

            AppSetting.Show()
        End Sub
#End Region


#Region "expense"

        Private Sub AddExpenseClicked(sender As Object, e As EventArgs) Handles button_add_expense.Click

            'NewExpense.Show()

            Dim newExpense As New NewExpense(_dayView, _monthView, _calanderView)
            newExpense.Show()

        End Sub



#End Region


#Region "category"
        Private Sub AddCategoryClicked(sender As Object, e As EventArgs) Handles add_category.Click

            If _darkMode Then
                add_category.Image = My.Resources.addwhiteselected
            Else
                add_category.Image = My.Resources.addDark

            End If

            NewCategory.Show()

            'Presentation.NewCategory.button_create.PerformClick()
            timer_reset_image.Start()

        End Sub

        Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click

            If _darkMode Then
                btn_delete.Image = My.Resources.deletewhiteselected

            Else

                btn_delete.Image = My.Resources.delete3Red

            End If

            'DeleteCategory.Show()

            Dim deleteCategory As New DeleteCategory(_dayView, _monthView, _calanderView)
            deleteCategory.Show()

            timer_reset_image.Start()


        End Sub

        Private Sub btn_edit_category_Click(sender As Object, e As EventArgs) Handles btn_edit_category.Click

            If _darkMode Then
                btn_edit_category.Image = My.Resources.editwhiteselected
            Else

                btn_edit_category.Image = My.Resources.editdark

            End If

            '

            'Presentation.NewCategory.button_create.PerformClick()


            Dim editCategory As New UpdateCategory(_dayView, _monthView)
            editCategory.Show()


            timer_reset_image.Start()

        End Sub

#End Region


#Region " display/setting profile "



        Private Sub img_profile_Click(sender As Object, e As EventArgs) Handles img_profile.Click
            Dim displayProfile As New DisplayProfile(_calanderView)
            displayProfile.Show()
        End Sub




#End Region


#Region "check / button visual cues"
        ' checked visual cues
        Private Sub RadioCheckedChanged(sender As Object, e As EventArgs) Handles radio_home.CheckedChanged, radio_analytical.CheckedChanged, radio_export.CheckedChanged

            ' for home button
            If radio_home.Checked Then

                If _darkMode Then
                    radio_home.Image = My.Resources.homewhiteselected
                Else
                    radio_home.Image = My.Resources.homeDark

                End If
            Else
                If _darkMode Then
                    radio_home.Image = My.Resources.homewhite
                Else
                    radio_home.Image = My.Resources.homeLight

                End If
            End If


            ' for analytical button
            If radio_analytical.Checked Then
                If _darkMode Then
                    radio_analytical.Image = My.Resources.barchartWhiteSelected

                Else
                    radio_analytical.Image = My.Resources.barDark

                End If
            Else
                If _darkMode Then
                    radio_analytical.Image = My.Resources.barchartWhite

                Else
                    radio_analytical.Image = My.Resources.barLight

                End If
            End If


            ' for export button
            If radio_export.Checked Then
                If _darkMode Then
                    radio_export.Image = My.Resources.exportWhiteSelected

                Else

                    radio_export.Image = My.Resources.exportDark

                End If
            Else
                If _darkMode Then
                    radio_export.Image = My.Resources.exportWhite

                Else

                    radio_export.Image = My.Resources.exportLight

                End If

            End If

        End Sub



#End Region


#Region "min/max/close"
        Private Sub ButtonMaxClick(sender As Object, e As EventArgs) Handles btn_max.Click

            'panel_main.Refresh()

            ' Get the working area
            Dim workignArea As Rectangle = Screen.FromControl(Me).WorkingArea

            If Me.Bounds = workignArea Then
                'Me.WindowState = FormWindowState.Normal

                Me.Size = New Size(1600, 1000)
                Me.Location = New Point(160, 100)

                If _darkMode Then
                    btn_max.Image = My.Resources.maximizeWhite

                Else
                    btn_max.Image = My.Resources.maximize

                End If

            Else
                Me.Location = workignArea.Location
                Me.Size = workignArea.Size
                'Me.Size = New Size(My.Computer.Screen.Bounds.Size.Width, My.Computer.Screen.Bounds.Height - 40)

                'Me.WindowState = FormWindowState.Maximized
                If _darkMode Then
                    btn_max.Image = My.Resources.restoreDownWhite

                Else
                    btn_max.Image = My.Resources.restore_down


                End If
            End If

        End Sub


        ' minimize on button click
        Private Sub ButtonMinClick(sender As Object, e As EventArgs) Handles btn_min.Click
            Me.WindowState = FormWindowState.Minimized

            panel_main.Refresh()
        End Sub

        ' close
        Private Sub ButtonCloseClick(sender As Object, e As EventArgs) Handles btn_close.Click
            Me.Close()

            EraseSessionInformation()


        End Sub

        Private Sub EraseSessionInformation()

            SessionManager.Instance.CurrentUserId = 0
            SessionManager.Instance.CurrentUsername = ""
            SessionManager.Instance.CurrentPassword = ""
            SessionManager.Instance.CurrentNumber = ""
            SessionManager.Instance.CurrentDateJoined = DateTime.Now
            SessionManager.Instance.CurrentProfileLink = ""

        End Sub


#End Region


#Region " mouse Movement "

        ' MOUSE MOVEMENT


        Dim _mouseMove As System.Drawing.Point


        Private Sub topbar_MouseDown(sender As Object, e As MouseEventArgs) Handles panel_top.MouseDown
            _mouseMove = New Point(-e.X, -e.Y)
        End Sub


        Private Sub topbar_MouseMove(sender As Object, e As MouseEventArgs) Handles panel_top.MouseMove

            If e.Button = Windows.Forms.MouseButtons.Left Then
                Dim position As Point
                position = Control.MousePosition
                position.Offset(_mouseMove.X, _mouseMove.Y)
                Me.Location = position
            End If

        End Sub


        Private _isMouseDown As Boolean = False


        Private Sub panel_topbar_MouseDown(sender As Object, e As MouseEventArgs) Handles panel_top.MouseDown
            If e.Button = MouseButtons.Left Then
                _isMouseDown = True
            End If
        End Sub


        Private Sub panel_topbar_MouseUp(sender As Object, e As MouseEventArgs) Handles panel_top.MouseUp
            _isMouseDown = False
        End Sub

        ' Handle MouseMove event and check if the mouse is down
        Private Sub panel_topbar_MouseMove(sender As Object, e As MouseEventArgs) Handles panel_top.MouseMove
            If _isMouseDown Then
                ' Your logic here
                If Me.Size = New Size(1920, 1200) Then

                    Me.Location = New Point(160, 5)
                    Me.Size = New Size(1600, 1000)

                    If My.Settings.IsLightMode = False Then
                        btn_max.Image = My.Resources.maximizeWhite
                    Else
                        btn_max.Image = My.Resources.maximize


                    End If
                End If
            End If
        End Sub












#End Region


#Region " gradient "



        Private Sub Form1_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint


            Dim startColor As Color
            Dim endColor As Color

            'MessageBox.Show("Is Light Mode: " & My.Settings.IsLightMode.ToString())

            ' Force light or dark mode for testing
            If My.Settings.IsLightMode Then
                startColor = ColorTranslator.FromHtml(My.Settings.lightModeStartColor)
                endColor = ColorTranslator.FromHtml(My.Settings.lightModeEndColor)
            Else
                startColor = ColorTranslator.FromHtml(My.Settings.darkModeStartColor)
                endColor = ColorTranslator.FromHtml(My.Settings.darkModeEndColor)
            End If



            Dim rect As New Rectangle(0, 0, Me.ClientSize.Width, Me.ClientSize.Height)


            ' Create a LinearGradientBrush
            Using brush As New LinearGradientBrush(rect, startColor, endColor, LinearGradientMode.Horizontal)
                ' Fill the rectangle with the gradient
                e.Graphics.FillRectangle(brush, rect)
            End Using


        End Sub




#End Region


#Region " key handling "
#End Region


#Region " light / dark"

        Private Sub ColorMode()

            If My.Settings.IsLightMode = False Then
                'lbl_category.ForeColor = foreColor

                check_all.ForeColor = Color.Black

                button_add_expense.BackColor = ColorTranslator.FromHtml(My.Settings.darkPanelColor)
                button_add_expense.Image = My.Resources.addwhite1


                ForeColor = Color.White
                _darkMode = True
                Me.BackColor = ColorTranslator.FromHtml("#191D1C")
                panel_main.BackColor = ColorTranslator.FromHtml(My.Settings.darkPanelColor)


                radio_home.Image = My.Resources.homewhite
                radio_analytical.Image = My.Resources.barchartWhite
                radio_export.Image = My.Resources.exportWhite

                radio_day_view.Image = My.Resources.dayViewWhite
                radio_month_view.Image = My.Resources.monthWhite
                btn_appSetting.Image = My.Resources.settingwhite32

                btn_min.Image = My.Resources.minimizeWhite
                btn_max.Image = My.Resources.maximizeWhite


                btn_close.Image = My.Resources.crossWhite

                btn_delete.Image = My.Resources.deleteWhite
                btn_edit_category.Image = My.Resources.editWhite
                add_category.Image = My.Resources.addWhite


                radio_analyze_monthly.Image = My.Resources.monthWhite
                radio_analysis_year.Image = My.Resources.yearAnalysisWhite

            Else
                Me.BackColor = ColorTranslator.FromHtml("#EEF4F9")
                panel_main.BackColor = ColorTranslator.FromHtml(My.Settings.lightPanelColor)
                button_add_expense.BackColor = ColorTranslator.FromHtml(My.Settings.lightPanelColor)


            End If

        End Sub
#End Region


#Region " timer for buttons "

        Private Sub timer_revertImage_Tick(sender As Object, e As EventArgs) Handles timer_reset_image.Tick
            ' Revert the image back to right
            If _darkMode Then

                btn_edit_category.Image = My.Resources.editWhite
                add_category.Image = My.Resources.addWhite
                btn_delete.Image = My.Resources.deleteWhite
                btn_appSetting.Image = My.Resources.settingwhite32



            Else

                btn_edit_category.Image = My.Resources.edit
                add_category.Image = My.Resources.add
                btn_delete.Image = My.Resources.delete3
                btn_appSetting.Image = My.Resources.setting32

            End If





            ' Stop the timer as the image has been reverted
            timer_reset_image.Stop()
        End Sub

#End Region


#Region " to resolve flicker "
        Protected Overrides ReadOnly Property CreateParams() As CreateParams
            Get
                Dim cp As CreateParams = MyBase.CreateParams
                cp.ExStyle = cp.ExStyle Or &H2000000
                Return cp
            End Get
        End Property





#End Region


    End Class
End Namespace