Imports System.Drawing.Drawing2D
Imports expense_Trackie.Application

Public Class deleteCategory

    Dim categoryManager As New CategoryManager
    Dim selectedCategoryId As Integer

    Private Sub deleteCategory_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        categoryManager.GenerateCategoryRadioButtons(flowPanel_category)

    End Sub




    Private Sub button_close_Click(sender As Object, e As EventArgs) Handles button_close.Click
        Me.Close()
    End Sub




    Private Sub button_delete_Click(sender As Object, e As EventArgs) Handles button_delete.Click

        If getSelectedCategoryId() = 0 Then
            MsgBox("Select a category to delete")
            Return
        End If


        selectedCategoryId = getSelectedCategoryId()

        Dim result As Integer = categoryManager.DeleteCategory(selectedCategoryId)

        If result > 0 Then

            ' generate panel with fresh category
            categoryManager.GenerateCategoryRadioButtons(flowPanel_category)
            categoryManager.GenerateCategoryCheckButtons(mainWindow.flowPanelCategory)
        Else

            MsgBox("Failed deleting category")

        End If


    End Sub




    Private Function getSelectedCategoryId() As Integer

        Dim id As Integer = 0

        For Each control In flowPanel_category.Controls

            If TypeOf (control) Is RadioButton Then

                Dim radioButton As RadioButton = DirectCast(control, RadioButton)

                If radioButton.Checked Then
                    id = CInt(radioButton.Tag)
                End If

            End If

        Next

        Return id

    End Function




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