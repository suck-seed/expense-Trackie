Imports System.Drawing.Drawing2D
Imports expense_Trackie.Application

Namespace Presentation

    Public Class DeleteCategory


        Dim _selectedCategoryId As Integer = 0

        Dim _dayView As DayView
        Dim _monthView As MonthView
        Dim _calanderView As CalanderView

        ReadOnly _borderRadius As Integer = 22


#Region " New( dayView ) "



        Public Sub New(ByRef dayViewInst As DayView, ByRef monthViewInst As MonthView, ByRef calanderViewInst As CalanderView)

            ' This call is required by the designer.
            InitializeComponent()

            _dayView = dayViewInst
            _monthView = monthViewInst
            _calanderView = calanderViewInst

            ' Add any initialization after the InitializeComponent() call.

        End Sub

#End Region



#Region " load "
        Dim darkMode As Boolean = False


        Private Sub deleteCategory_Load(sender As Object, e As EventArgs) Handles MyBase.Load

            ClearInfo()

            If My.Settings.IsLightMode = False Then
                ForeColor = Color.White
                darkMode = True
                Me.BackColor = ColorTranslator.FromHtml("#191D1C")
            Else
                Me.BackColor = ColorTranslator.FromHtml("#EEF4F9")
            End If

            ColorMode()
            'rounded
            SetRoundedShape(Me, _borderRadius)
            Me.SetStyle(ControlStyles.ResizeRedraw, True)
            Me.SetStyle(ControlStyles.OptimizedDoubleBuffer, True)

            Dim categoryManager As New CategoryManager
            categoryManager.GenerateCategoryRadioButtons(flowPanel_category, AddressOf GetSelectedRadioCategoryId)


        End Sub

#End Region



#Region " info label"
        Private Sub ClearInfo()
            lbl_info.Text = ""
        End Sub

        Private Sub DisplayError(erroString As String)

            lbl_info.ForeColor = Color.Red
            lbl_info.Text = erroString

        End Sub

        Private Sub DisplaySucess(succString As String)

            lbl_info.ForeColor = Color.Green
            lbl_info.Text = succString

        End Sub



#End Region



#Region " delete functionality "

        Private Sub button_delete_Click(sender As Object, e As EventArgs) Handles button_delete.Click

            If _selectedCategoryId = 0 Then
                DisplayError("Select a category to delete")
                Return
            End If

            Dim categoryManager As New CategoryManager
            Dim result As Integer = categoryManager.DeleteCategory(_selectedCategoryId)

            If result > 0 Then

                ' Refresh information
                DisplaySucess("Category deleted sucessfully")
                RefreshDisplay()

            Else

                DisplayError("Failed deleting category")

            End If


        End Sub

#End Region


#Region " Refresh display "


        Public Sub RefreshDisplay()

            Dim categoryManager As New CategoryManager

            ' repaining in delete panel
            categoryManager.GenerateCategoryRadioButtons(flowPanel_category, AddressOf GetSelectedRadioCategoryId)

            'reloading in mainwindow
            MainWindow.LoadInformation()

            'reloading in dayView

            _dayView.DisplayInformation()

            _monthView.DisplayInformation()

            _calanderView.DisplayInformation()

            MainWindow.UpdateExport()
            'refreshing calander

        End Sub

#End Region


#Region " selected category "


        Public Sub GetSelectedRadioCategoryId(ByVal cId As Integer)

            For Each control In flowPanel_category.Controls

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



            Dim rect As New Rectangle(0, 0, panel_topbar.Width, panel_topbar.Height)


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




#Region " key events "

        Private Sub EscPressed(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown

            If e.KeyCode = Keys.Escape Then
                Me.Close()
            End If

        End Sub

#End Region



#Region " light / dark"

        Public Sub ColorMode()

            If My.Settings.IsLightMode = False Then
                'lbl_category.ForeColor = foreColor

                button_close.Image = My.Resources.crossWhite
                button_delete.Image = My.Resources.checkwhite


                panel_back.BackColor = ColorTranslator.FromHtml(My.Settings.darkPanelColor)
                TableLayoutPanel1.BackColor = ColorTranslator.FromHtml(My.Settings.darkPanelColor)

            Else

                panel_back.BackColor = ColorTranslator.FromHtml(My.Settings.lightPanelColor)
                TableLayoutPanel1.BackColor = ColorTranslator.FromHtml(My.Settings.lightPanelColor)




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


#Region " mouse movement "


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



#Region " round shaping "

        Private Sub SetRoundedShape(ctrl As Control, radius As Integer)
            Dim rPath As New GraphicsPath()

            ' new rectangle
            Dim rect As New Rectangle(0, 0, ctrl.Width, ctrl.Height)

            ' roudning and arch for the corners
            rPath.AddArc(New Rectangle(rect.X, rect.Y, radius, radius), 180, 90) ' Top-left corner
            rPath.AddArc(New Rectangle(rect.Width - radius, rect.Y, radius, radius), -90, 90) ' Top-right corner
            rPath.AddArc(New Rectangle(rect.Width - radius, rect.Height - radius, radius, radius), 0, 90) ' Bottom-right corner
            rPath.AddArc(New Rectangle(rect.X, rect.Height - radius, radius, radius), 90, 90) ' Bottom-left corner
            rPath.CloseFigure()

            ' applying smooth path to controls region
            ctrl.Region = New Region(rPath)
        End Sub


        Protected Overrides Sub OnPaint(e As PaintEventArgs)
            MyBase.OnPaint(e)

            ' Enable anti-aliasing for smoother edges
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias

        End Sub


        Private Sub ExpenseDetailDisplay_Resize(sender As Object, e As EventArgs) Handles Me.Resize
            SetRoundedShape(Me, _borderRadius)
        End Sub

#End Region

    End Class
End NameSpace