Imports System.Drawing.Drawing2D
Imports expense_Trackie.Application

Namespace Presentation

    Public Class NewExpense

        ' DATA MEMBERS
        Dim _amount As Decimal
        Dim _remarks As String
        Dim _dateAdded As DateTime
        ReadOnly _timeAdded As DateTime = DateTime.Now
        Dim _selectedCategoryId As Integer

        'custom event to trigger when an expense is added to refresh the day and month view
        Public Shared Event ExpenseAdded As EventHandler


        ' expense creation
        Private Sub button_create_Click(sender As Object, e As EventArgs) Handles button_create.Click


            ' Error proofing

            If Not Decimal.TryParse(txt_Amount.Text, _amount) Then
                MsgBox("Amount should be Decimal ")
                Return
            End If

            If String.IsNullOrEmpty(txt_Amount.Text) Or String.IsNullOrEmpty(txt_Remarks.Text) Or GetSelectedCategoryId() = 0 Then
                MsgBox("Provide all the required information ")
                Return
            End If


            If txt_Remarks.Text.Length > 255 Then
                MsgBox("Remarks cant be longer than 255 characters.")
            End If





            ' Retrieving Information
            _amount = CDec(txt_Amount.Text)
            _remarks = txt_Remarks.Text
            _dateAdded = txt_date_picker.Value.ToString("yyyy-MM-dd")
            _selectedCategoryId = GetSelectedCategoryId()



            ' Backend implementation
            Dim expenseManager As New ExpenseManager()
            Dim expenseId As Integer = expenseManager.AddNewExpense(_amount, _remarks, _dateAdded, _timeAdded, _selectedCategoryId)

            If expenseId > 0 Then
                MsgBox("Expense added successfully")

                RaiseEvent ExpenseAdded(Me, EventArgs.Empty)


                Me.Close()
            Else
                MsgBox("Failed adding expense ")
            End If



        End Sub



        ' Loading custom categories
        Private Sub New_Expense_Load(sender As Object, e As EventArgs) Handles MyBase.Load



            'generating category on panel
            Dim categoryManager As New CategoryManager()
            categoryManager.GenerateCategoryRadioButtons(flowPanel_category)

        End Sub


        ' Fetching categoryId
        Private Function GetSelectedCategoryId() As Integer

            Dim id As Integer = 0

            For Each control In flowPanel_category.Controls

                If TypeOf (control) Is RadioButton  Then

                    Dim radioButton As RadioButton = DirectCast(control, RadioButton)

                    If radioButton.Checked Then
                        id = CInt(radioButton.Tag)
                    End If

                End If

            Next

            Return id

        End Function






















        ' CLOSE
        Private Sub button_close_Click(sender As Object, e As EventArgs) Handles button_close.Click
            Me.Close()
        End Sub




        Protected Overrides Sub Finalize()
            MyBase.Finalize()
        End Sub






        ' TOPBAR MOVEMENT
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


    End Class
End NameSpace
