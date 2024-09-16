Imports System.Drawing.Drawing2D

Public Class New_Category




    ' MAIN FUNCTIONALITY

    Dim catName As String
    Dim catDescription As String
    Dim catColor As String

    Private Sub button_create_Click(sender As Object, e As EventArgs) Handles button_create.Click
        catName = txt_name.Text
        catDescription = txt_description.Text


        ' selecting the color
        For Each control As Control In tabelPanel_color.Controls

            If TypeOf control Is RadioButton Then

                Dim rb As RadioButton = DirectCast(control, RadioButton)

                If rb.Checked Then
                    catColor = rb.BackColor.Name
                End If

            End If

        Next



        ' adding category functionality
        Dim categorymanager As New CategoryManager()

        Dim added As Integer = categorymanager.registerCategory(catName, catDescription, catColor)

        If added > 0 Then
            MsgBox("Category added sucessfully")

        Else
            MsgBox("Category insertion failed. Please try again.")
        End If





    End Sub










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


End Class