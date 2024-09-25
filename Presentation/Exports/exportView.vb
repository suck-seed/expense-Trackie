Public Class exportView


    Public selectedDate As DateTime

    Dim startDate, endDate As DateTime


    Dim darkMode As Boolean = False
    Private Sub exportView_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        If My.Settings.IsLightMode = False Then
            ForeColor = Color.White
            darkMode = True
            Me.BackColor = ColorTranslator.FromHtml(My.Settings.darkPanelColor)
        Else
            Me.BackColor = ColorTranslator.FromHtml(My.Settings.lightPanelColor)
        End If

        ColorMode()
    End Sub


#Region "  black/white "

    Private Sub ColorMode()

    End Sub

#End Region


#Region " timer for buttons "

    Private Sub timer_revertImage_Tick(sender As Object, e As EventArgs) Handles timer_reset_image.Tick


        If darkMode Then

            'btn_next.Image = My.Resources.rightWhite
            'btn_previous.Image = My.Resources.leftWhite
            'btn_filter.Image = My.Resources.filterWhite

        Else

            'btn_next.Image = My.Resources.right
            'btn_previous.Image = My.Resources.left
            'btn_filter.Image = My.Resources.filter



        End If

        ' Stop the timer as the image has been reverted
        timer_reset_image.Stop()
    End Sub


#End Region
End Class
