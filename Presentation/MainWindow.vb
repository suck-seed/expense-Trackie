Imports System.Drawing.Drawing2D
Imports expense_Trackie.Application

Namespace Presentation

    Public Class MainWindow

#Region "form load"


        Private Sub MybaseLoad(sender As Object, e As EventArgs) Handles MyBase.Load


            LoadInformation()

            Dim categoryManager As New CategoryManager()
            categoryManager.GenerateCategoryCheckButtons(flowPanelCategory)

        End Sub

#End Region



#Region "load information during startup"

        Private Sub LoadInformation()
            Me.lbl_username.Text = SessionManager.Instance.CurrentUsername

            If Not String.IsNullOrEmpty(SessionManager.Instance.CurrentProfileLink) Then
                btn_profile.Image = Image.FromFile(SessionManager.Instance.CurrentProfileLink)
            End If



        End Sub

#End Region



#Region "calander/day"
        Private Sub radio_day_view_CheckedChanged(sender As Object, e As EventArgs) Handles radio_day_view.CheckedChanged

            If radio_month_view.Checked Then

                If radio_home.Checked Then
                    DisplayForm(New MonthView())
                End If
                radio_month_view.Image = My.Resources.monthDark

            Else

                radio_month_view.Image = My.Resources.monthLight

            End If

        End Sub



        Private Sub switch_Day_Calander_View(sender As Object, e As EventArgs) Handles radio_month_view.CheckedChanged, radio_day_view.CheckedChanged


            'checking day
            If radio_day_view.Checked Then

                If radio_home.Checked Then
                    DisplayForm(New DayView(Me))
                End If
                radio_day_view.Image = My.Resources.dayDark

            Else

                radio_day_view.Image = My.Resources.dayLight

            End If

            'checking month
            If radio_month_view.Checked Then

                If radio_home.Checked Then
                    DisplayForm(New MonthView())
                End If
                radio_month_view.Image = My.Resources.monthDark

            Else

                radio_month_view.Image = My.Resources.monthLight

            End If

            'debug



        End Sub


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



#Region "get selected category"


        ' retrieving categoryId
        Private Sub radio_all_Click(sender As Object, e As EventArgs) Handles radio_all.Click


            For Each control As Control In flowPanelCategory.Controls

                If TypeOf control Is CheckBox Then
                    Dim checkBox As CheckBox = DirectCast(control, CheckBox)

                    checkBox.Checked = False

                End If

            Next

            Dim selectedCategoryIds As New List(Of Integer)

            ' if all is selected
            selectedCategoryIds.Clear()
            SessionManager.SelectedCategoryIds = selectedCategoryIds

        End Sub

        Private Sub radio_custom_Click(sender As Object, e As EventArgs) Handles radio_custom.Click

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

        End Sub



#End Region


#Region "expense"

        Private Sub AddExpenseClicked(sender As Object, e As EventArgs) Handles button_add_expense.Click

            NewExpense.Show()

        End Sub



#End Region


#Region "category"
        Private Sub AddCategoryClicked(sender As Object, e As EventArgs) Handles add_category.Click

            NewCategory.Show()

            'Presentation.NewCategory.button_create.PerformClick()

        End Sub

        Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click

            btn_delete.Image = My.Resources.delete3Red
            DeleteCategory.Show()

        End Sub
#End Region


#Region "check / button visual cues"
        ' checked visual cues
        Private Sub RadioCheckedChanged(sender As Object, e As EventArgs) Handles radio_home.CheckedChanged, radio_analytical.CheckedChanged, radio_export.CheckedChanged

            ' for home button
            If radio_home.Checked Then
                radio_home.Image = My.Resources.homeDark
            Else
                radio_home.Image = My.Resources.homeLight
            End If


            ' for analytical button
            If radio_analytical.Checked Then
                radio_analytical.Image = My.Resources.barDark
            Else
                radio_analytical.Image = My.Resources.barLight
            End If


            ' for export button
            If radio_export.Checked Then
                radio_export.Image = My.Resources.exportDark
            Else
                radio_export.Image = My.Resources.exportLight
            End If

        End Sub


        Private Sub btn_delete_MouseHover(sender As Object, e As EventArgs) Handles btn_delete.MouseHover
            btn_delete.Image = My.Resources.delete3Red
        End Sub


        Private Sub btn_delete_MouseLeave(sender As Object, e As EventArgs) Handles btn_delete.MouseLeave
            btn_delete.Image = My.Resources.delete3
        End Sub


#End Region


#Region "min/max/close"
        Private Sub ButtonMaxClick(sender As Object, e As EventArgs) Handles button_max.Click

            'panel_main.Refresh()

            If Me.Size = New Size(1920, 1200) Then
                'Me.WindowState = FormWindowState.Normal

                Me.Size = New Size(1600, 1000)
                Me.Location = New Point(160, 100)
                button_max.Image = My.Resources.icons8_maximize_button_16

            Else
                Me.Location = New Point(0, 0)
                Me.Size = New Size(1920, 1200)

                'Me.WindowState = FormWindowState.Maximized
                button_max.Image = My.Resources.restore_down
            End If

        End Sub


        ' minimize on button click
        Private Sub ButtonMinClick(sender As Object, e As EventArgs) Handles button_min.Click
            Me.WindowState = FormWindowState.Minimized

            panel_main.Refresh()
        End Sub

        ' close
        Private Sub ButtonCloseClick(sender As Object, e As EventArgs) Handles button_close.Click
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


        Private Sub topbar_MouseDown(sender As Object, e As MouseEventArgs) Handles panel_topbar.MouseDown
            _mouseMove = New Point(-e.X, -e.Y)
        End Sub


        Private Sub topbar_MouseMove(sender As Object, e As MouseEventArgs) Handles panel_topbar.MouseMove

            If e.Button = Windows.Forms.MouseButtons.Left Then
                Dim position As Point
                position = Control.MousePosition
                position.Offset(_mouseMove.X, _mouseMove.Y)
                Me.Location = position
            End If

        End Sub


        Private isMouseDown As Boolean = False


        Private Sub panel_topbar_MouseDown(sender As Object, e As MouseEventArgs) Handles panel_topbar.MouseDown
            If e.Button = MouseButtons.Left Then
                isMouseDown = True
            End If
        End Sub


        Private Sub panel_topbar_MouseUp(sender As Object, e As MouseEventArgs) Handles panel_topbar.MouseUp
            isMouseDown = False
        End Sub

        ' Handle MouseMove event and check if the mouse is down
        Private Sub panel_topbar_MouseMove(sender As Object, e As MouseEventArgs) Handles panel_topbar.MouseMove
            If isMouseDown Then
                ' Your logic here
                If Me.Size = New Size(1920, 1200) Then

                    Me.Location = New Point(160, 5)
                    Me.Size = New Size(1600, 1000)

                    button_max.Image = My.Resources.icons8_maximize_button_16
                End If
            End If
        End Sub










#End Region


#Region " gradient "

        Private Sub mainWindow_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
            ' Get the client area of the form
            Dim rect As New Rectangle(0, 0, Me.ClientSize.Width, Me.ClientSize.Height)

            ' Define the start and end colors for the gradient
            Dim startColor As Color = Color.Beige
            Dim endColor As Color = Color.AliceBlue

            ' Create a LinearGradientBrush
            Using brush As New LinearGradientBrush(rect, startColor, endColor, LinearGradientMode.Horizontal)
                ' Fill the rectangle with the gradient
                e.Graphics.FillRectangle(brush, rect)
            End Using
        End Sub


#End Region


#Region "debug"

        'Private Sub btn_debug_Click(sender As Object, e As EventArgs) Handles btn_debug.Click

        '    Dim selectedCategoryIds As New List(Of Integer)

        '    ' if all is selected
        '    If radio_all.Checked() Then

        '        selectedCategoryIds.Clear()

        '    End If


        '    If radio_custom.Checked Then
        '        For Each control As Control In flowPanelCategory.Controls

        '            If TypeOf control Is CheckBox Then
        '                Dim checkBox As CheckBox = DirectCast(control, CheckBox)

        '                If checkBox.Checked Then
        '                    Dim categoryId As Integer = CInt(checkBox.Tag)
        '                    selectedCategoryIds.Add(categoryId)
        '                End If

        '            End If

        '        Next

        '    End If

        '    ' setting session manager ko ma value
        '    SessionManager.SelectedCategoryIds = selectedCategoryIds



        '    ' Display the selected category IDs
        '    If SessionManager.SelectedCategoryIds.Count > 0 Then
        '        ' Convert list of integers to a comma-separated string
        '        Dim categoryIdString As String = String.Join(", ", SessionManager.SelectedCategoryIds)
        '        MessageBox.Show("Selected Categories: " & categoryIdString)
        '    Else
        '        MessageBox.Show("No categories selected.")
        '    End If

        'End Sub



#End Region


    End Class
End NameSpace