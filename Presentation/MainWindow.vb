Imports System.Drawing.Drawing2D
Imports expense_Trackie.Application
Imports expense_Trackie.DataLayer

Namespace _01Presentation

    Public Class mainWindow

        Private categoryManager As New CategoryManager
        Private expenseManager As New ExpenseManager
        Private categoryRepository As New CategoryRepository

        Public Event CategoryChanged As EventHandler

#Region "form load"


        Private Sub mybaseLoad(sender As Object, e As EventArgs) Handles MyBase.Load


            loadInformation()
            categoryManager.GenerateCategoryCheckButtons(flowPanelCategory)

        End Sub

#End Region



#Region "load information during startup"

        Public Sub loadInformation()
            Me.lbl_username.Text = SessionManager.Instance.currentUsername

            If Not String.IsNullOrEmpty(SessionManager.Instance.currentProfileLink) Then
                btn_profile.Image = Image.FromFile(SessionManager.Instance.currentProfileLink)
            End If



        End Sub

#End Region



#Region "calander/day"
        Private Sub radio_day_view_CheckedChanged(sender As Object, e As EventArgs) Handles radio_day_view.CheckedChanged

            If radio_month_view.Checked Then

                If radio_home.Checked Then
                    displayForm(New monthView())
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
                    displayForm(New dayView(Me))
                End If
                radio_day_view.Image = My.Resources.dayDark

            Else

                radio_day_view.Image = My.Resources.dayLight

            End If

            'checking month
            If radio_month_view.Checked Then

                If radio_home.Checked Then
                    displayForm(New monthView())
                End If
                radio_month_view.Image = My.Resources.monthDark

            Else

                radio_month_view.Image = My.Resources.monthLight

            End If

            'debug



        End Sub


        Private Sub displayForm(control As UserControl)

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


        ' retriving categoryId
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

        Private Sub addExpenseClicked(sender As Object, e As EventArgs) Handles button_add_expense.Click
            New_Expense.Show()
        End Sub

#End Region


#Region "category"
        Private Sub addCategoryClicked(sender As Object, e As EventArgs) Handles add_category.Click

            'Dim newCategory As New New_Category()
            'newCategory.Show()

            New_Category.Show()

        End Sub

        Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click

            Dim deleteCat As New deleteCategory()
            deleteCat.Show()

        End Sub
#End Region


#Region "check background change"
        ' checked visual cues
        Private Sub radioCheckedChanged(sender As Object, e As EventArgs) Handles radio_home.CheckedChanged, radio_analytical.CheckedChanged, radio_export.CheckedChanged

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


#End Region


#Region "min/max/close"
        Private Sub buttonMaxClick(sender As Object, e As EventArgs) Handles button_max.Click

            panel_main.Refresh()

            If Me.WindowState = FormWindowState.Maximized Then
                Me.WindowState = FormWindowState.Normal
                button_max.Image = My.Resources.icons8_maximize_button_16

            Else
                Me.WindowState = FormWindowState.Maximized
                button_max.Image = My.Resources.restore_down
            End If

        End Sub


        ' minimize on button click
        Private Sub buttonMinClick(sender As Object, e As EventArgs) Handles button_min.Click
            Me.WindowState = FormWindowState.Minimized

            panel_main.Refresh()
        End Sub

        ' close
        Private Sub buttonCloseClick(sender As Object, e As EventArgs) Handles button_close.Click
            Me.Close()
            eraseSessionInformation()

        End Sub

        Public Sub eraseSessionInformation()

            SessionManager.Instance.currentUserId = 0
            SessionManager.Instance.currentUsername = ""
            SessionManager.Instance.currentPassword = ""
            SessionManager.Instance.currentNumber = ""
            SessionManager.Instance.currentdateJoined = DateTime.Now
            SessionManager.Instance.currentProfileLink = ""

        End Sub


#End Region


#Region "mouse Movement/paint"
        Dim mouse_move As System.Drawing.Point

        Private Sub topbar_MouseDown(sender As Object, e As MouseEventArgs) Handles panel_topbar.MouseDown
            mouse_move = New Point(-e.X, -e.Y)
        End Sub

        Private Sub topbar_MouseMove(sender As Object, e As MouseEventArgs) Handles panel_topbar.MouseMove
            If e.Button = Windows.Forms.MouseButtons.Left Then
                Dim mouse_position As Point
                mouse_position = Control.MousePosition
                mouse_position.Offset(mouse_move.X, mouse_move.Y)
                Me.Location = mouse_position
            End If
        End Sub

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