Imports System.Drawing.Drawing2D
Imports expense_Trackie.Application

Namespace Presentation

    Public Class DeleteCategory


        Dim _selectedCategoryId As Integer



#Region " New( dayView ) "

        Dim dayView As DayView

        Public Sub New(ByRef dayViewInst As DayView)

            ' This call is required by the designer.
            InitializeComponent()

            dayView = dayViewInst

            ' Add any initialization after the InitializeComponent() call.

        End Sub

#End Region



#Region " load "
        Private Sub deleteCategory_Load(sender As Object, e As EventArgs) Handles MyBase.Load

            Dim categoryManager As New CategoryManager
            categoryManager.GenerateCategoryRadioButtons(flowPanel_category)

        End Sub

#End Region




#Region " delete functionality "

        Private Sub button_delete_Click(sender As Object, e As EventArgs) Handles button_delete.Click

            If getSelectedCategoryId() = 0 Then
                MsgBox("Select a category to delete")
                Return
            End If


            _selectedCategoryId = getSelectedCategoryId()

            Dim categoryManager As New CategoryManager
            Dim result As Integer = categoryManager.DeleteCategory(_selectedCategoryId)

            If result > 0 Then

                ' Refresh information

                RefreshDisplay()

            Else

                MsgBox("Failed deleting category")

            End If


        End Sub

#End Region


#Region " update display "


        Public Sub RefreshDisplay()

            Dim categoryManager As New CategoryManager
            categoryManager.GenerateCategoryRadioButtons(flowPanel_category)
            categoryManager.GenerateCategoryCheckButtons(MainWindow.flowPanelCategory)
            dayView.UpdateDisplayInformation()

        End Sub

#End Region


#Region " selected category "

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

#End Region




#Region " gradient "

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




        Private Sub button_close_Click(sender As Object, e As EventArgs) Handles button_close.Click
            Me.Close()
        End Sub



    End Class
End NameSpace