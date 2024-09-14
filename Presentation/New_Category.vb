Imports System.Drawing.Drawing2D

Public Class New_Category




    ' MAIN FUNCTIONALITY

    Dim catName As String
    Dim catDescription As String
    Dim catColor As String

    Private Sub button_create_Click(sender As Object, e As EventArgs) Handles button_create.Click
        catName = txt_name.Text
        catDescription = txt_description.Text

        If Radio_Color1.Checked Then
            catColor = Radio_Color1.BackColor.Name

        ElseIf Radio_Color2.Checked Then
            catColor = Radio_Color2.BackColor.Name

        ElseIf Radio_Color3.Checked Then
            catColor = Radio_Color3.BackColor.Name

        ElseIf Radio_Color4.Checked Then
            catColor = Radio_Color4.BackColor.Name

        ElseIf Radio_Color5.Checked Then
            catColor = Radio_Color5.BackColor.Name

        ElseIf Radio_Color6.Checked Then
            catColor = Radio_Color6.BackColor.Name

        ElseIf Radio_Color7.Checked Then
            catColor = Radio_Color7.BackColor.Name

        ElseIf Radio_Color8.Checked Then
            catColor = Radio_Color8.BackColor.Name

        ElseIf Radio_Color9.Checked Then
            catColor = Radio_Color9.BackColor.Name

        Else
            MsgBox("Provide all information")
        End If


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

    Private Sub Radio_Color3_CheckedChanged(sender As Object, e As EventArgs) Handles Radio_Color3.CheckedChanged

    End Sub

    Private Sub Radio_Color4_CheckedChanged(sender As Object, e As EventArgs) Handles Radio_Color4.CheckedChanged

    End Sub

    Private Sub Radio_Color5_CheckedChanged(sender As Object, e As EventArgs) Handles Radio_Color5.CheckedChanged

    End Sub

    Private Sub Radio_Color6_CheckedChanged(sender As Object, e As EventArgs) Handles Radio_Color6.CheckedChanged

    End Sub

    Private Sub Radio_Color7_CheckedChanged(sender As Object, e As EventArgs) Handles Radio_Color7.CheckedChanged

    End Sub

    Private Sub Radio_Color8_CheckedChanged(sender As Object, e As EventArgs) Handles Radio_Color8.CheckedChanged

    End Sub

    Private Sub Radio_Color9_CheckedChanged(sender As Object, e As EventArgs) Handles Radio_Color9.CheckedChanged

    End Sub

    Private Sub Radio_Color1_CheckedChanged(sender As Object, e As EventArgs) Handles Radio_Color1.CheckedChanged

    End Sub
End Class