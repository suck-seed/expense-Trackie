Imports System.Drawing.Drawing2D

Public Class AppSetting


    Dim isLightmode As Boolean = True
    Dim textColor As Color
    Dim isDarkMode As Boolean = False

#Region " load "

    Private Sub AppSetting_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbl_info.Text = ""
        ColorMode()

        If My.Settings.IsLightMode = False Then
            ForeColor = Color.White
            isDarkMode = True
            Me.BackColor = ColorTranslator.FromHtml("#191D1C")
        Else
            Me.BackColor = ColorTranslator.FromHtml("#EEF4F9")
        End If

    End Sub

#End Region



    Private Sub button_close_Click(sender As Object, e As EventArgs) Handles button_close.Click
        Me.Close()
    End Sub


#Region " checked changed "

    Private Sub lightMode_CheckedChanged(sender As Object, e As EventArgs) Handles lightMode.CheckedChanged


        If lightMode.Checked = True Then

            If isDarkMode Then
                lightMode.Image = My.Resources.lightmodeLightSelected
            Else
                lightMode.Image = My.Resources.lightModeSelected

            End If

            isLightmode = True
        Else
            If isDarkMode Then
                lightMode.Image = My.Resources.lightModeLight
            Else
                lightMode.Image = My.Resources.lightMode

            End If

            isLightmode = False

        End If
    End Sub

    Private Sub darkMode_CheckedChanged(sender As Object, e As EventArgs) Handles darkMode.CheckedChanged

        If darkMode.Checked = True Then

            If isDarkMode Then
                darkMode.Image = My.Resources.darkmodelightselected

            Else
                darkMode.Image = My.Resources.darkmodeselected

            End If

            isLightmode = False
        Else

            If isDarkMode Then
                darkMode.Image = My.Resources.darkmodeLight

            Else
                darkMode.Image = My.Resources.darkMode

            End If

            isLightmode = True

        End If
    End Sub

#End Region


#Region " main functionality "

    Private Sub button_create_Click(sender As Object, e As EventArgs) Handles button_create.Click
        My.Settings.IsLightMode = isLightmode
        My.Settings.textColor = textColor
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



        Dim rect As New Rectangle(0, 0, Me.ClientSize.Width, Me.ClientSize.Height)


        ' Create a LinearGradientBrush
        Using brush As New LinearGradientBrush(rect, startColor, endColor, LinearGradientMode.Horizontal)
            ' Fill the rectangle with the gradient
            e.Graphics.FillRectangle(brush, rect)
        End Using


    End Sub



#End Region



#Region " light / dark"

    Public Sub ColorMode()

        If My.Settings.IsLightMode = False Then
            'lbl_category.ForeColor = foreColor


            button_close.Image = My.Resources.crossWhite
            button_create.Image = My.Resources.checkwhite

            lightMode.Image = My.Resources.lightModeLight
            darkMode.Image = My.Resources.darkmodeLight



        End If

    End Sub
#End Region


End Class