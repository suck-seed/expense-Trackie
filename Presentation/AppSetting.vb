Imports System.Drawing.Drawing2D

Namespace Presentation

    Public Class AppSetting


        Dim _isLightmode As Boolean = True
        Dim _isDarkMode As Boolean = False
        ReadOnly _borderRadius As Integer = 22


#Region " load "

        Private Sub AppSetting_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            lbl_info.Text = ""

            If My.Settings.IsLightMode = False Then

                'DARKMODE

                ForeColor = Color.White
                _isDarkMode = True
                darkModeSelector.Checked = True

            Else

                lightModeSelector.Checked = True

            End If

            ColorMode()
            'rounded
            SetRoundedShape(Me, _borderRadius)
            Me.SetStyle(ControlStyles.ResizeRedraw, True)
            Me.SetStyle(ControlStyles.OptimizedDoubleBuffer, True)


        End Sub

#End Region


#Region " checked changed "

        Private Sub lightMode_CheckedChanged(sender As Object, e As EventArgs) Handles lightModeSelector.CheckedChanged


            If lightModeSelector.Checked = True Then

                If _isDarkMode Then
                    lightModeSelector.Image = My.Resources.lightmodeLightSelected
                    darkModeSelector.Image = My.Resources.darkmodeLight
                Else
                    lightModeSelector.Image = My.Resources.lightModeSelected
                    darkModeSelector.Image = My.Resources.darkMode

                End If

                _isLightmode = True
            Else
                If _isDarkMode Then
                    lightModeSelector.Image = My.Resources.lightModeLight
                    darkModeSelector.Image = My.Resources.darkmodelightselected
                Else
                    lightModeSelector.Image = My.Resources.lightMode
                    darkModeSelector.Image = My.Resources.darkmodeselected


                End If

                _isLightmode = False

            End If
        End Sub

        Private Sub darkMode_CheckedChanged(sender As Object, e As EventArgs) Handles darkModeSelector.CheckedChanged

            If darkModeSelector.Checked = True Then

                If _isDarkMode Then
                    darkModeSelector.Image = My.Resources.darkmodelightselected

                Else
                    darkModeSelector.Image = My.Resources.darkmodeselected

                End If

                _isLightmode = False
            Else

                If _isDarkMode Then
                    darkModeSelector.Image = My.Resources.darkmodeLight

                Else
                    darkModeSelector.Image = My.Resources.darkMode

                End If

                _isLightmode = True

            End If
        End Sub

#End Region


#Region " main functionality "

        Private Sub button_create_Click(sender As Object, e As EventArgs) Handles button_create.Click
            My.Settings.IsLightMode = _isLightmode

            My.Settings.Save()


            System.Windows.Forms.Application.Restart()

        End Sub

#End Region


#Region " gradient "



        Private Sub Form1_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint


            Dim startColor As Color
            Dim endColor As Color

            If My.Settings.IsLightMode = True Then

                startColor = ColorTranslator.FromHtml(My.Settings.lightModeStartColor)
                endColor = ColorTranslator.FromHtml(My.Settings.lightModeEndColor)

            ElseIf My.Settings.IsLightMode = False Then

                startColor = ColorTranslator.FromHtml(My.Settings.darkModeStartColor)
                endColor = ColorTranslator.FromHtml(My.Settings.darkModeEndColor)

            End If



            Dim rect As New Rectangle(0, 0, panel_topbar.Width, panel_topbar.Height)


            ' Create a LinearGradientBrush
            Using brush As New LinearGradientBrush(rect, startColor, endColor, LinearGradientMode.Horizontal)
                ' Fill the rectangle with the gradient
                e.Graphics.FillRectangle(brush, rect)
            End Using


        End Sub



#End Region


#Region " light / dark"

        Private Sub ColorMode()

            If My.Settings.IsLightMode = False Then
                'lbl_category.ForeColor = foreColor


                ' DARK MODE

                button_close.Image = My.Resources.crossWhite
                button_create.Image = My.Resources.checkwhite

                lightModeSelector.Image = My.Resources.lightModeLight
                darkModeSelector.Image = My.Resources.darkmodelightselected





                panel_back.BackColor = ColorTranslator.FromHtml(My.Settings.darkPanelColor)
                TableLayoutPanel1.BackColor = ColorTranslator.FromHtml(My.Settings.darkPanelColor)

            Else

                panel_back.BackColor = ColorTranslator.FromHtml(My.Settings.lightPanelColor)
                TableLayoutPanel1.BackColor = ColorTranslator.FromHtml(My.Settings.lightPanelColor)


                lightModeSelector.Image = My.Resources.lightModeSelected
                darkModeSelector.Image = My.Resources.darkMode



            End If

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

#End Region


#Region " round shaping "

        Private Sub SetRoundedShape(ctrl As Control, radius As Integer)
            Dim rPath As New GraphicsPath()

            ' new rectangle
            Dim rect As New Rectangle(0, 0, ctrl.Width, ctrl.Height)

            ' roudning and arch for the corners
            rPath.AddArc(New Rectangle(rect.X, rect.Y, radius, radius), 180, 90) ' Top-left corner
            rPath.AddArc(New Rectangle(rect.Width - radius, rect.Y, radius, radius), -90, 90) ' Top-right corner
            rPath.AddArc(New Rectangle(rect.Width - radius, rect.Height - radius, radius, radius), 0, 90) ' Bottom-right corner
            rPath.AddArc(New Rectangle(rect.X, rect.Height - radius, radius, radius), 90, 90) ' Bottom-left corner
            rPath.CloseFigure()

            ' applying smooth path to controls region
            ctrl.Region = New Region(rPath)
        End Sub


        Protected Overrides Sub OnPaint(e As PaintEventArgs)
            MyBase.OnPaint(e)

            ' Enable anti-aliasing for smoother edges
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias

        End Sub


        Private Sub ExpenseDetailDisplay_Resize(sender As Object, e As EventArgs) Handles Me.Resize
            SetRoundedShape(Me, _borderRadius)
        End Sub

#End Region

        Private Sub button_close_Click(sender As Object, e As EventArgs) Handles button_close.Click
            Me.Close()
        End Sub

    End Class
End NameSpace