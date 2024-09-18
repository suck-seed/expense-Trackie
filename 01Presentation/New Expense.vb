Imports System.Drawing.Drawing2D

Public Class New_Expense

    ' DATA MEMBERS
    Dim amount As Decimal
    Dim remarks As String
    Dim dateAdded As DateTime
    Dim timeAdded As DateTime = DateTime.Now
    Dim selectedCategoryId As Integer

    'custom event to trigger when a expense is added to refresh the day and month view
    Public Shared Event ExpenseAdded As EventHandler



    Dim expenseManager As New ExpenseManager()


    ' expese creation
    Private Sub button_create_Click(sender As Object, e As EventArgs) Handles button_create.Click


        ' Error proffing

        If Not Decimal.TryParse(txt_Amount.Text, amount) Then
            MsgBox("Amount should be Decimal ")
            Return
        End If

        If String.IsNullOrEmpty(txt_Amount.Text) Or String.IsNullOrEmpty(txt_Remarks.Text) Or getSelectedCategoryId() = 0 Then
            MsgBox("Provide all the required information ")
            Return
        End If


        If txt_Remarks.Text.Length > 255 Then
            MsgBox("Remarks cant be longer than 255 characters.")
        End If





        ' Retriving Information
        amount = CDec(txt_Amount.Text)
        remarks = txt_Remarks.Text
        dateAdded = txt_date_picker.Value.ToString("yyyy-MM-dd")
        selectedCategoryId = getSelectedCategoryId()



        ' Backend implementation
        Dim expenseId As Integer = expenseManager.addNewExpense(amount, remarks, dateAdded, timeAdded, selectedCategoryId)

        If expenseId > 0 Then
            MsgBox("Expense added sucessfully")

            RaiseEvent ExpenseAdded(Me, EventArgs.Empty)


            Me.Close()
        Else
            MsgBox("Failed adding expense ")
        End If



    End Sub



    ' Loading custom categories
    Private Sub New_Expense_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim categorymanager As New CategoryManager()

        'generating category on panel
        categorymanager.generateCategoryRadioButtons(flowPanel_category)

    End Sub


    ' Fetching categoryId
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






















    ' CLOSE
    Private Sub button_close_Click(sender As Object, e As EventArgs) Handles button_close.Click
        Me.Close()
    End Sub




    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub






    ' TOPBAR MOVEMENT
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