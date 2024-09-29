Imports System.Drawing.Drawing2D
Imports expense_Trackie.DataLayer

Public Class UpdatePassword


#Region " load "

    Private borderRadius As Integer = 45
    Dim darkMode As Boolean = False

    Private Sub UpdatePassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        lbl_error.Text = ""

        If My.Settings.IsLightMode = False Then
            ForeColor = Color.White
            darkMode = True
            Me.BackColor = ColorTranslator.FromHtml("#191D1C")
        Else
            Me.BackColor = ColorTranslator.FromHtml("#EEF4F9")
        End If

        ColorMode()



        SetRoundedShape(Me, borderRadius)
        Me.SetStyle(ControlStyles.ResizeRedraw, True)
        Me.SetStyle(ControlStyles.OptimizedDoubleBuffer, True)




    End Sub



    Private Sub SetRoundedShape(ctrl As Control, radius As Integer)
        Dim rPath As New GraphicsPath()

        ' Create rounded corners with arcs and straight lines
        rPath.StartFigure()
        rPath.AddArc(New Rectangle(0, 0, radius, radius), 180, 90)  ' Top-left corner
        rPath.AddArc(New Rectangle(ctrl.Width - radius, 0, radius, radius), -90, 90)  ' Top-right corner
        rPath.AddArc(New Rectangle(ctrl.Width - radius, ctrl.Height - radius, radius, radius), 0, 90)  ' Bottom-right corner
        rPath.AddArc(New Rectangle(0, ctrl.Height - radius, radius, radius), 90, 90)  ' Bottom-left corner
        rPath.CloseFigure()

        ' Apply the smooth path to the form's region
        ctrl.Region = New Region(rPath)
    End Sub

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        MyBase.OnPaint(e)

        ' Enable anti-aliasing for smoother edges
        e.Graphics.SmoothingMode = SmoothingMode.AntiAlias

        ' You can add additional painting code here for custom effects if needed
    End Sub

#End Region


#Region " New "

    Dim storedUsername As String
    Dim storedVerificationCode As String

    Public Sub New(username As String, code As String)
        InitializeComponent()
        storedUsername = username
        storedVerificationCode = code
    End Sub

#End Region


#Region " main functionality "
    Private Sub btn_reset_Click(sender As Object, e As EventArgs) Handles btn_reset.Click

        Dim inputCode As String = txt_code.Text
        Dim newPassword As String = txt_password.Text

        If String.IsNullOrEmpty(newPassword) Then
            ShowError("Please fill up your password.")
            Return
        End If

        If newPassword.Length < 8 Then
            ShowError("Password must be at least 8 characters long.")
            Return
        End If

        If Not newPassword.Any(AddressOf Char.IsDigit) Then
            ShowError("Password must contain at least one number.")
            Return
        End If

        If Not newPassword.Any(Function(c) "@#%^".Contains(c)) Then
            ShowError("Password must contain at least one special character (@, #, %, ^).")
            Return
        End If

        If Not newPassword.Any(AddressOf Char.IsUpper) Then
            ShowError("Password must contain at least one uppercase letter.")
            Return
        End If

        If Not newPassword.Any(AddressOf Char.IsLower) Then
            ShowError("Password must contain at least one lowercase letter.")
            Return
        End If



        ' backend

        If inputCode = storedVerificationCode Then

            'usermanager
            Dim userRepo As New UserRepository
            If userRepo.updatePasswordByUsername(storedUsername, newPassword) Then

                lbl_error.ForeColor = Color.Green
                lbl_error.Text = " Password updated sucessfully"

                passUpdatedSplashScreen.Show()
                Me.Close()



            End If
        Else
            ShowError("Invalid verification code. Please try again.")
        End If


    End Sub


    Private Sub ShowError(ByVal errorS As String)
        lbl_error.ForeColor = Color.Red
        lbl_error.Text = errorS
    End Sub

#End Region





#Region " close "

    Private Sub button_close_Click(sender As Object, e As EventArgs) Handles button_close.Click
        Me.Close()
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
            txt_code.BackColor = ColorTranslator.FromHtml(My.Settings.darkPanelColor)
            txt_password.BackColor = ColorTranslator.FromHtml(My.Settings.darkPanelColor)
            txt_code.ForeColor = Color.White
            txt_password.ForeColor = Color.White

        End If

    End Sub
#End Region



#Region " topbar movement "
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

End Class