Imports System.Drawing.Drawing2D
Imports expense_Trackie.Application

Namespace Presentation

    Public Class NewCategory


        ' MAIN FUNCTIONALITY
        Dim _catName As String
        Dim _catDescription As String
        Dim _catColor As String


#Region " load "
        Private Sub NewCategory_Load(sender As Object, e As EventArgs) Handles MyBase.Load


            LoadDefaultColor(panel_color, AddressOf ColorIdDefaultColor)

        End Sub

#End Region


#Region "category creation"

        Private Sub button_create_Click(sender As Object, e As EventArgs) Handles button_create.Click


            ' Error proofing

            If String.IsNullOrEmpty(txt_name.Text) Or String.IsNullOrEmpty(txt_description.Text) Or String.IsNullOrEmpty(_catColor) Then
                MsgBox("Please fill all the information.")
                Return
            End If



            ' Retrieving Information
            _catName = txt_name.Text
            _catDescription = txt_description.Text



            'adding into db
            Dim categoryManager As New CategoryManager()

            Dim catAdded As Integer = categoryManager.RegisterCategory(_catName, _catDescription, _catColor)

            If catAdded > 0 Then



                ' reloading category in mainwindow
                MainWindow.LoadInformation()

                ClearInputBox()

                MsgBox("Category added successfully")

            Else
                MsgBox("Category insertion failed. Please try again.")
            End If




        End Sub

#End Region


#Region "color selection"
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
            MainWindow.btn_delete.Image = My.Resources.delete3
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