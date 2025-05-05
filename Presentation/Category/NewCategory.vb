Imports System.Drawing.Drawing2D
Imports expense_Trackie.Application

Namespace Presentation

    Public Class NewCategory


        ' MAIN FUNCTIONALITY
        Dim _catName As String
        Dim _catDescription As String
        Dim _catColor As String


#Region " load "

        Dim darkMode As Boolean = False

        Private Sub NewCategory_Load(sender As Object, e As EventArgs) Handles MyBase.Load

            ClearInfo()

            If My.Settings.IsLightMode = False Then
                ForeColor = Color.White
                darkMode = True
                Me.BackColor = ColorTranslator.FromHtml("#191D1C")
            Else
                Me.BackColor = ColorTranslator.FromHtml("#EEF4F9")
            End If

            ColorMode()

            LoadDefaultColor(panel_color, AddressOf ColorIdDefaultColor)

        End Sub



#End Region



#Region " info label"
        Private Sub ClearInfo()
            lbl_info.Text = ""
        End Sub

        Private Sub DisplayError(erroString As String)

            lbl_info.ForeColor = Color.Red
            lbl_info.Text = erroString

        End Sub


        Private Sub txt_name_Enter(sender As Object, e As EventArgs) Handles txt_name.Enter
            ClearInfo()
        End Sub

        Private Sub txt_description_Enter(sender As Object, e As EventArgs) Handles txt_description.Enter
            ClearInfo()

        End Sub
#End Region



#Region "category creation"

        Private Sub button_create_Click(sender As Object, e As EventArgs) Handles button_create.Click


            ' Error proofing

            If String.IsNullOrEmpty(txt_name.Text) Or String.IsNullOrEmpty(txt_description.Text) Or String.IsNullOrEmpty(_catColor) Then
                DisplayError("Please fill all the information.")
                Return
            End If



            ' Retrieving Information
            _catName = txt_name.Text
            _catDescription = txt_description.Text



            'adding into db
            Dim categoryManager As New CategoryManager()

            Dim catAdded As Integer = categoryManager.RegisterCategory(_catName, _catDescription, _catColor)

            If catAdded > 0 Then

                lbl_info.ForeColor = Color.Green
                lbl_info.Text = "Category added sucessfully !"

                ' reloading category in mainwindow
                MainWindow.LoadInformation()
                MainWindow.UpdateExport()

                ClearInputBox()

                'MsgBox("Category added successfully")

            ElseIf catAdded = -1 Then

                DisplayError("Category with above name already exists !")

            Else
                DisplayError("Category insertion failed. Please try again.")
            End If




        End Sub

#End Region



        ' Default color selection

#Region " color selection "

        Private Sub ColorIdDefaultColor()

            For Each control As Control In panel_color.Controls

                If TypeOf control Is RadioButton Then

                    Dim rb As RadioButton = DirectCast(control, RadioButton)

                    If rb.Checked Then


                        _catColor = ColorTranslator.ToHtml(rb.BackColor)
                        btn_custom_color.BackColor = SystemColors.ButtonFace

                    End If


                End If

            Next

        End Sub


        Private Sub btn_custom_color_Click(sender As Object, e As EventArgs) Handles btn_custom_color.Click


            ' unchecking default color
            For Each control As Control In panel_color.Controls

                If TypeOf control Is RadioButton Then

                    Dim rb As RadioButton = DirectCast(control, RadioButton)

                    rb.Checked = False

                End If

            Next



            ' setting custom color
            Dim cd As New ColorDialog()


            If cd.ShowDialog() = DialogResult.OK Then

                btn_custom_color.BackColor = cd.Color

                If cd.Color.IsNamedColor Then


                    ' if known color, using string format to convert to #
                    Dim color As Color = cd.Color
                    _catColor = String.Format("#{0:X2}{1:X2}{2:X2}", color.R, color.G, color.B)


                Else


                    ' if custom color, then using toHtml to convert to #
                    _catColor = ColorTranslator.ToHtml(cd.Color)


                End If

            End If

            MsgBox("Custom color :" & _catColor)



        End Sub







#End Region





#Region "clear inputs"

        Public Sub ClearInputBox()
            txt_description.Text = ""
            txt_name.Text = ""
        End Sub

#End Region



#Region "junk"
        ' CLOSING

        Private Sub button_close_Click(sender As Object, e As EventArgs) Handles button_close.Click
            Me.Close()
        End Sub






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



        ' GRADIENT





#End Region




#Region " key events "

        Private Sub EscPressed(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown

            If e.KeyCode = Keys.Escape Then
                Me.Close()
            End If

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

        Public Sub ColorMode()

            If My.Settings.IsLightMode = False Then

                button_close.Image = My.Resources.crossWhite
                button_create.Image = My.Resources.checkwhite

                btn_custom_color.ForeColor = Color.Black

                txt_name.BackColor = ColorTranslator.FromHtml(My.Settings.darkPanelColor)
                txt_description.BackColor = ColorTranslator.FromHtml(My.Settings.darkPanelColor)

                txt_name.ForeColor = Color.White
                txt_description.ForeColor = Color.White

                panel_back.BackColor = ColorTranslator.FromHtml(My.Settings.darkPanelColor)
                TableLayoutPanel1.BackColor = ColorTranslator.FromHtml(My.Settings.darkPanelColor)

            Else

                panel_back.BackColor = ColorTranslator.FromHtml(My.Settings.lightPanelColor)
                TableLayoutPanel1.BackColor = ColorTranslator.FromHtml(My.Settings.lightPanelColor)



            End If

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