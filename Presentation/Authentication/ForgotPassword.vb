Imports System.Drawing.Drawing2D
Imports expense_Trackie.DataLayer

Public Class ForgotPassword



    Dim darkMode As Boolean = False
    Dim username As String

    Dim userRepo As New UserRepository


#Region " main functionality "

    Private Sub btn_sendCode_Click(sender As Object, e As EventArgs) Handles btn_sendCode.Click


        username = txt_username.Text
        If String.IsNullOrEmpty(username) Then
            ShowError("Username required.")
            Return
        End If



        'checking if userName exists or not
        If userRepo.IsDuplicateUser(username, "") Then

            'generate Code and show
            verificationCode = generateVerficationCode()
            notifyCode.Text = verificationCode
            notifyCode.BalloonTipTitle = "Verification Code"
            notifyCode.BalloonTipText = "Your verification code is: " & verificationCode
            'notifyCode.BalloonTipIcon = ToolTipIcon.Info
            notifyCode.ShowBalloonTip(5000)


            'me hide and update password showing
            Dim updatePass As New UpdatePassword(username, verificationCode)
            updatePass.Show()
            Me.Close()

        Else
            ShowError("Invalid Username !")
        End If

    End Sub


#End Region

    Private Sub ShowError(ByVal errorS As String)
        lbl_error.ForeColor = Color.Red
        lbl_error.Text = errorS
    End Sub

#Region "VerificationCodeMethod"
    Dim verificationCode As String

    Private Function generateVerficationCode()
        Dim rand As New Random()
        Dim code As String = rand.Next(100000, 999999).ToString()
        Return code
    End Function
#End Region


#Region " light / dark"

    Public Sub ColorMode()

        If My.Settings.IsLightMode = False Then
            'lbl_category.ForeColor = foreColor

            button_close.Image = My.Resources.crossWhite

            txt_username.BackColor = ColorTranslator.FromHtml(My.Settings.darkPanelColor)
            txt_securityCode.BackColor = ColorTranslator.FromHtml(My.Settings.darkPanelColor)

            txt_username.ForeColor = Color.White
            txt_securityCode.ForeColor = Color.White

        End If

    End Sub
#End Region



#Region "RoundedForm"
    Private borderRadius As Integer = 45

    Private Sub ForgetP_Load(sender As Object, e As EventArgs) Handles MyBase.Load


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



#Region "MouseHover"
    'Private Sub Button1_MouseEnter(sender As Object, e As EventArgs) Handles btn_sendCode.MouseEnter
    '    btn_sendCode.BackColor = Color.FromArgb(66, 143, 77)
    'End Sub

    'Private Sub Button1_MouseLeave(sender As Object, e As EventArgs) Handles btn_sendCode.MouseLeave
    '    btn_sendCode.BackColor = Color.FromArgb(120, 143, 104)
    'End Sub
#End Region



#Region " close "
    Private Sub button_close_Click(sender As Object, e As EventArgs) Handles button_close.Click
        Me.Close()
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