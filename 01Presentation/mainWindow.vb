Public Class mainWindow

    Private categoryManager As New CategoryManager
    Private expenseManager As New ExpenseManager

    ' loading resources at startup
    Private Sub mybaseLoad(sender As Object, e As EventArgs) Handles MyBase.Load

        'setting the username 
        Me.lbl_username.Text = SessionManager.Instance.currentUsername


        'loading categoriesss 


        CategoryManager.generateCategoryCheckButtons(mainWindowCategory)



    End Sub


    ' loading expenses
    Private Sub check_all_CheckedChanged(sender As Object, e As EventArgs) Handles check_all.CheckedChanged

    End Sub



    ' calnder and day view switch
    Private Sub switch_Day_Calander_View(sender As Object, e As EventArgs) Handles radio_month_view.CheckedChanged, radio_day_view.CheckedChanged


        'checking month
        If radio_month_view.Checked Then

            If radio_home.Checked Then
                displayForm(New monthView())
            End If
            radio_month_view.Image = My.Resources.monthDark

        Else

            radio_month_view.Image = My.Resources.monthLight

        End If


        'checking day
        If radio_day_view.Checked Then

            If radio_home.Checked Then
                displayForm(New dayView())
            End If
            radio_day_view.Image = My.Resources.dayDark

        Else

            radio_day_view.Image = My.Resources.dayLight

        End If

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





















    ' ADD CATEGORY AND EXPENSE
    Private Sub addExpenseClicked(sender As Object, e As EventArgs) Handles button_add_expense.Click
        New_Expense.Show()
    End Sub

    Private Sub addCategoryClicked(sender As Object, e As EventArgs) Handles add_category.Click
        New_Category.Show()
    End Sub

    ' close
    Private Sub buttonCloseClick(sender As Object, e As EventArgs) Handles button_close.Click
        Me.Close()
    End Sub



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



    ' minimize and maximize changes in button
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




    ' window movement
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


End Class