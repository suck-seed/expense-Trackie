Imports System.Drawing.Drawing2D
Imports expense_Trackie.Application

Namespace Presentation


    Public Class NewExpense

        ' DATA MEMBERS
        Dim _amount As Decimal
        Dim _remarks As String
        Dim _dateAdded As DateTime
        Dim _timeAdded As DateTime
        Dim _selectedCategoryId As Integer = 0

        Dim wasBelowLimit As Boolean = False


#Region " New( dayView ) "

        Dim _dayView As DayView
        Dim _monthView As MonthView
        Dim _calanderView As CalanderView

        Public Sub New(ByRef dayViewInst As DayView, ByRef monthViewInst As MonthView, ByRef calanderViewInst As CalanderView)

            ' This call is required by the designer.
            InitializeComponent()

            _dayView = dayViewInst
            _monthView = monthViewInst
            _calanderView = calanderViewInst


            ' Add any initialization after the InitializeComponent() call.

        End Sub

#End Region



#Region " loading categories "

        Dim _darkMode As Boolean = False

        ' Loading custom categories
        Private Sub New_Expense_Load(sender As Object, e As EventArgs) Handles MyBase.Load

            lbl_info.Text = ""

            If My.Settings.IsLightMode = False Then
                ForeColor = Color.White
                _darkMode = True

            Else

            End If

            ColorMode()

            txt_date_picker.Value = _dayView.CurrentDate

            'generating category on panel
            Dim categoryManager As New CategoryManager()
            categoryManager.GenerateCategoryRadioButtons(panel_radio_category, AddressOf GetSelectedRadioCategoryId)

        End Sub

#End Region



#Region " expense creation "




        Private Sub button_create_Click(sender As Object, e As EventArgs) Handles button_create.Click






            lbl_info.ForeColor = Color.Red

            ' Error proofing

            If Not Decimal.TryParse(txt_Amount.Text, _amount) Then
                ErrorLog("Amount should be Decimal ")
                Return
            End If

            If String.IsNullOrEmpty(txt_Amount.Text) Or String.IsNullOrEmpty(txt_Remarks.Text) Or _selectedCategoryId = 0 Then
                ErrorLog("Provide all the required information ")

                Return
            End If


            If txt_Remarks.Text.Length > 255 Then
                ErrorLog("Remarks cant be longer than 255 chars")
                Return
            End If





            ' Retrieving Information
            _amount = CDec(txt_Amount.Text)
            _remarks = txt_Remarks.Text
            _dateAdded = txt_date_picker.Value.ToString("yyyy-MM-dd")
            _timeAdded = txt_time_picker.Value



            'checking limit for calander
            If GetTotal(_dateAdded) < SessionManager.Instance.CurrentDailyLimit Then

                wasBelowLimit = True

            End If


            ' Backend implementation
            Dim expenseManager As New ExpenseManager()
            Dim expenseId As Integer = expenseManager.AddNewExpense(_amount, _remarks, _dateAdded, _timeAdded, _selectedCategoryId)

            If expenseId > 0 Then


                ' updating information in dayView
                'dayView.DisplayInformation()
                'monthView.DisplayInformation()


                ' If dayinview is = currentDate in dayView then only refresh DisplayInformation
                If _dayView.CurrentDate.ToString("yyyy-MM-dd") = _dateAdded.ToString("yyyy-MM-dd") Then

                    _dayView.DisplayInformation()

                End If

                ClearInputBox()

                lbl_info.ForeColor = Color.ForestGreen
                lbl_info.Text = " Added expense !"



                _monthView.DisplayInformation()




                ' if add gareko day ko total > dailyLimit, refresh it

                If wasBelowLimit = True And GetTotal(_dateAdded) > SessionManager.Instance.CurrentDailyLimit Then

                    _calanderView.DisplayInformation()

                End If




            Else

                ErrorLog("Failed Adding Expense")

            End If



        End Sub


        Private Sub ErrorLog(ByVal errorInfo As String)

            lbl_info.ForeColor = Color.Red
            lbl_info.Text = errorInfo

        End Sub

        Private Sub ClearLog()
            lbl_info.Text = ""
        End Sub



#End Region

#Region " clearning error "

        Private Sub Clear_lbl_info(sender As Object, e As EventArgs) Handles txt_Amount.Enter, txt_Remarks.Enter

            ClearLog()
        End Sub

#End Region


#Region " clear inputs "

        Private Sub ClearInputBox()
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
                        ClearLog()
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
#End Region



#Region " key events "

        Private Sub EscPressed(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown

            If e.KeyCode = Keys.Escape Then
                ClearLog()
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



            Dim rect As New Rectangle(0, 0, Me.ClientSize.Width, Me.ClientSize.Height)


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
                'lbl_category.ForeColor = foreColor

                button_close.Image = My.Resources.crossWhite
                button_create.Image = My.Resources.checkwhite




                txt_Amount.BackColor = ColorTranslator.FromHtml(My.Settings.darkPanelColor)
                txt_Remarks.BackColor = ColorTranslator.FromHtml(My.Settings.darkPanelColor)

                txt_Remarks.ForeColor = Color.White
                txt_Amount.ForeColor = Color.White



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
End NameSpace