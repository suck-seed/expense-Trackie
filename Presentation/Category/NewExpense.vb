Imports System.Drawing.Drawing2D
Imports expense_Trackie.Application

Namespace Presentation


    Public Class NewExpense

        ' DATA MEMBERS
        Dim _amount As Decimal
        Dim _remarks As String
        Dim _dateAdded As DateTime
        ReadOnly _timeAdded As DateTime = DateTime.Now
        Dim _selectedCategoryId As Integer = 0


#Region " New( dayView ) "

        Dim dayView As DayView
        Dim monthView As MonthView
        Dim calanderView As CalanderView

        Public Sub New(ByRef dayViewInst As DayView, ByRef monthViewInst As MonthView, ByRef calanderViewInst As CalanderView)

            ' This call is required by the designer.
            InitializeComponent()

            dayView = dayViewInst
            monthView = monthViewInst
            calanderView = calanderViewInst


            ' Add any initialization after the InitializeComponent() call.

        End Sub

#End Region



#Region " loading categories "


        ' Loading custom categories
        Private Sub New_Expense_Load(sender As Object, e As EventArgs) Handles MyBase.Load



            'generating category on panel
            Dim categoryManager As New CategoryManager()
            categoryManager.GenerateCategoryRadioButtons(panel_radio_category, AddressOf GetSelectedRadioCategoryId)

        End Sub

#End Region



#Region " expense creation "




        Private Sub button_create_Click(sender As Object, e As EventArgs) Handles button_create.Click


            ' Error proofing

            If Not Decimal.TryParse(txt_Amount.Text, _amount) Then
                MsgBox("Amount should be Decimal ")
                Return
            End If

            If String.IsNullOrEmpty(txt_Amount.Text) Or String.IsNullOrEmpty(txt_Remarks.Text) Or _selectedCategoryId = 0 Then
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




            ' Backend implementation
            Dim expenseManager As New ExpenseManager()
            Dim expenseId As Integer = expenseManager.AddNewExpense(_amount, _remarks, _dateAdded, _timeAdded, _selectedCategoryId)

            If expenseId > 0 Then


                ' updating information in dayView
                'dayView.DisplayInformation()
                'monthView.DisplayInformation()
                ClearInputBox()



                dayView.DisplayInformation()



                monthView.DisplayInformation()


                calanderView.DisplayInformation()



            Else
                MsgBox("Failed adding expense ")
            End If



        End Sub


#End Region



#Region " clear inputs "

        Public Sub ClearInputBox()
            txt_Amount.Text = ""
            txt_Remarks.Text = ""

            For Each control In panel_radio_category.Controls

                If TypeOf (control) Is RadioButton Then

                    Dim radioButton As RadioButton = DirectCast(control, RadioButton)

                    If radioButton.Checked Then
                        radioButton.Checked = False
                    End If

                End If

            Next


        End Sub

#End Region





        ' Fetching categoryId

#Region " selected category "


        Public Sub GetSelectedRadioCategoryId(ByVal cId As Integer)

            For Each control In panel_radio_category.Controls

                If TypeOf (control) Is RadioButton Then

                    Dim radioButton As RadioButton = DirectCast(control, RadioButton)

                    If radioButton.Checked Then
                        _selectedCategoryId = CInt(radioButton.Tag)
                        Return
                    Else
                        _selectedCategoryId = 0
                    End If

                End If

            Next

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


#Region " key events "

        Private Sub EscPressed(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown

            If e.KeyCode = Keys.Escape Then
                Me.Close()
            End If

        End Sub

#End Region



#End Region



    End Class
End NameSpace