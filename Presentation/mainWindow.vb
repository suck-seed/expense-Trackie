Public Class mainWindow

    ' VARIABLES REQUIRED
    Dim currentUser As Integer = 1




    ' SWITCHING BETWEEN CALANDER AND DAY VIEW

    Private Sub monthViewClick(sender As Object, e As EventArgs) Handles btn_month_view.Click

        If radio_home.Checked Then
            displayForm(New monthView())
        End If

    End Sub

    Private Sub dayViewClick(sender As Object, e As EventArgs) Handles btn_day_view.Click
        If radio_home.Checked Then
            displayForm(New dayView())
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





    ' ON CLICK EVENT
    Private Sub addExpenseClicked(sender As Object, e As EventArgs) Handles button_add_expense.Click
        New_Expense.Show()
    End Sub

    Private Sub addCategoryClicked(sender As Object, e As EventArgs) Handles add_category.Click
        New_Category.Show()
    End Sub


    ' CLOSE ON CLICK

    Private Sub buttonCloseClick(sender As Object, e As EventArgs) Handles button_close.Click
        Me.Close()
    End Sub



    ' MIN MAX BAR CHANGES
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


    ' MINMIZE ON CLICK
    Private Sub buttonMinClick(sender As Object, e As EventArgs) Handles button_min.Click
        Me.WindowState = FormWindowState.Minimized

        panel_main.Refresh()
    End Sub




    ' WINDOW MOVEMENT
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





    ' LINE DRAWING 

    Dim pen As New Pen(Color.LightGray, 0.5)

    Private Sub sidebar_Paint(sender As Object, e As PaintEventArgs) Handles panel_sidebar.Paint

        Line_below_main_buttons(e.Graphics)

    End Sub

    Private Sub topbar_Paint(sender As Object, e As PaintEventArgs) Handles panel_topbar.Paint
        Line_below_top_bar(e.Graphics)
    End Sub

    Private Sub Line_below_main_buttons(graphics As Graphics)
        graphics.DrawLine(pen, 0, panel_topbar.Height, panel_sidebar.Width, panel_topbar.Height)
    End Sub

    Private Sub Line_below_top_bar(graphics As Graphics)
        'graphics.DrawLine(pen, topbar.Location.X, topbar.Height, topbar.Width, topbar.Height)
        graphics.DrawLine(pen, 0, panel_topbar.Height, Me.Width, panel_topbar.Height)
    End Sub

    Private Sub mainWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


End Class