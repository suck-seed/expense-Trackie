Imports System.Drawing.Drawing2D
Imports expense_Trackie.Application

Namespace Presentation

    Public Class NewCategory


        ' MAIN FUNCTIONALITY
        Dim catName As String
        Dim catDescription As String
        Dim catColor As String
        Dim categorymanager As New CategoryManager()

#Region "category creation"

        Private Sub button_create_Click(sender As Object, e As EventArgs) Handles button_create.Click

            getDefaultColor()

            ' Error proffing

            If String.IsNullOrEmpty(txt_name.Text) Or String.IsNullOrEmpty(txt_description.Text) Or String.IsNullOrEmpty(catColor) Then
                MsgBox("Please fill all the information.")
                Return
            End If



            ' Retriving Information
            catName = txt_name.Text
            catDescription = txt_description.Text



            'adding into db


            Dim catAdded As Integer = categorymanager.RegisterCategory(catName, catDescription, catColor)

            If catAdded > 0 Then
                MsgBox("Category added sucessfully")


                ' reloading the categories in mainWindow after adding a category to reflect the added category
                categorymanager.GenerateCategoryCheckButtons(mainWindow.flowPanelCategory)

            Else
                MsgBox("Category insertion failed. Please try again.")
            End If

            categorymanager.GenerateCategoryCheckButtons(mainWindow.flowPanelCategory)


        End Sub

#End Region


#Region "color selection"
        ' Default color selection
        Private Sub getDefaultColor()

            For Each control As Control In tabelPanel_color.Controls

                If TypeOf control Is RadioButton Then

                    Dim rb As RadioButton = DirectCast(control, RadioButton)

                    If rb.Checked Then
                        catColor = ColorTranslator.ToHtml(rb.BackColor)
                        btn_custom_color.BackColor = SystemColors.ButtonFace
                    End If

                End If

            Next

        End Sub



        ' Custom color selection
        Private Sub btn_custom_color_Click(sender As Object, e As EventArgs) Handles btn_custom_color.Click



            ' unchecking all the radio buttons
            For Each control As Control In tabelPanel_color.Controls

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
                    catColor = String.Format("#{0:X2}{1:X2}{2:X2}", color.R, color.G, color.B)


                Else


                    ' if custom color, then using toHtml to convert to #
                    catColor = ColorTranslator.ToHtml(cd.Color)


                End If

            End If

            MsgBox("Custom color :" & catColor)

        End Sub


#End Region


#Region "junk"
        ' CLOSING

        Private Sub button_close_Click(sender As Object, e As EventArgs) Handles button_close.Click
            Me.Close()
        End Sub






        ' MOUSE MOVEMENT


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



        ' GRADIENT

        Private Sub Form1_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
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

    End Class
End NameSpace