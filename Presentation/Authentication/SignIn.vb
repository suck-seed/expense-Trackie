﻿Imports System.Drawing.Drawing2D
Imports expense_Trackie.Application

Namespace Presentation

    Public Class SignIn

        ' SIGN IN SYSTEM
        Dim _username As String
        Dim _password As String


#Region " load "

        Private borderRadius As Integer = 20

        Dim darkMode As Boolean = False
        Private Sub SignIn_Load(sender As Object, e As EventArgs) Handles MyBase.Load

            ' iniatialize the db's 
            DatabaseSetup.InitializeDatabase()


            ' move on to the ui rendering
            lbl_error.Text = ""

            If My.Settings.IsLightMode = False Then
                ForeColor = Color.White
                darkMode = True
                Me.BackColor = ColorTranslator.FromHtml("#191D1C")
            Else
                Me.BackColor = ColorTranslator.FromHtml("#EEF4F9")
            End If

            ColorMode()

            'If Not String.IsNullOrEmpty(My.Settings.SavedUsername) And Not String.IsNullOrEmpty(My.Settings.SavedPassword) Then
            If My.Settings.IsRemembered = True Then

                _username = My.Settings.SavedUsername
                _password = DecryptPassword(My.Settings.SavedPassword)
                '_password = (My.Settings.SavedPassword)

                txt_username.Text = _username
                txt_password.Text = _password

                ' performing the click event on signin button
                SignInBtn_Click(sender, e)

            End If

            'rounded
            SetRoundedShape(Me, borderRadius)
            Me.SetStyle(ControlStyles.ResizeRedraw, True)
            Me.SetStyle(ControlStyles.OptimizedDoubleBuffer, True)

        End Sub

        Private Sub SetRoundedShape(ctrl As Control, radius As Integer)
            Dim rPath As New GraphicsPath()

            ' Create a new rectangle that exactly fits the control's size
            Dim rect As New Rectangle(0, 0, ctrl.Width, ctrl.Height)

            ' Create rounded corners with arcs and straight lines
            rPath.AddArc(New Rectangle(rect.X, rect.Y, radius, radius), 180, 90) ' Top-left corner
            rPath.AddArc(New Rectangle(rect.Width - radius, rect.Y, radius, radius), -90, 90) ' Top-right corner
            rPath.AddArc(New Rectangle(rect.Width - radius, rect.Height - radius, radius, radius), 0, 90) ' Bottom-right corner
            rPath.AddArc(New Rectangle(rect.X, rect.Height - radius, radius, radius), 90, 90) ' Bottom-left corner
            rPath.CloseFigure()

            ' Apply the smooth path to the control's region
            ctrl.Region = New Region(rPath)
        End Sub


        Protected Overrides Sub OnPaint(e As PaintEventArgs)
            MyBase.OnPaint(e)

            ' Enable anti-aliasing for smoother edges
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias

            ' You can add additional painting code here for custom effects if needed
        End Sub


        Private Sub ExpenseDetailDisplay_Resize(sender As Object, e As EventArgs) Handles Me.Resize
            SetRoundedShape(Me, borderRadius)
        End Sub

#End Region


#Region " sign in clicked "

        Private Sub SignInBtn_Click(sender As Object, e As EventArgs) Handles SignInBtn.Click

            _username = txt_username.Text
            _password = txt_password.Text


            ' 
            If String.IsNullOrEmpty(_username) Or String.IsNullOrEmpty(_password) Then
                lbl_error.Text = "Please fill all information"
                Return

            End If





            ' application and backend referral
            Dim userManager As New UserManager()

            Dim userId As Integer = userManager.LogUserIn(_username, _password)

            If userId > 0 Then



                'MsgBox(SessionManager.Instance.CurrentUserId)
                'MsgBox(SessionManager.Instance.CurrentUsername)
                'MsgBox(SessionManager.Instance.CurrentPassword)
                'MsgBox(SessionManager.Instance.CurrentNumber)
                'MsgBox(SessionManager.Instance.CurrentDateJoined)
                'MsgBox(SessionManager.Instance.CurrentProfileLink)


                'If String.IsNullOrEmpty(My.Settings.SavedUsername) And String.IsNullOrEmpty(My.Settings.SavedPassword) Then

                If My.Settings.IsRemembered = False Then

                    If MessageBox.Show(" Want to be remembered ?", "Remember Credentials", MessageBoxButtons.YesNo) = DialogResult.Yes Then

                        My.Settings.SavedUsername = _username
                        My.Settings.SavedPassword = EncryptPassword(_password)
                        My.Settings.IsRemembered = True
                        'My.Settings.SavedPassword = (_password)

                        My.Settings.Save()

                    End If


                End If


                MainWindow.Show()

                Me.Close()

                ClearInputFields()

            Else
                lbl_error.Text = "Failed logging user in"

            End If



        End Sub

#End Region



#Region " close / signup "


        ' other kura
        Private Sub button_close_Click(sender As Object, e As EventArgs) Handles button_close.Click
            Me.Close()
        End Sub


        Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles SignUpLL.LinkClicked
            SignUp.Show()
            Me.Close()
        End Sub

#End Region


#Region " password visibility "


        Private Sub ShowPassCB_CheckedChanged(sender As Object, e As EventArgs) Handles check_showPassword.CheckedChanged
            If check_showPassword.Checked = True Then
                txt_password.PasswordChar = ""

                If darkMode Then
                    check_showPassword.Image = My.Resources.eyeWhiteSelected
                Else

                    check_showPassword.Image = My.Resources.showpasswordDark

                End If

            Else
                txt_password.PasswordChar = "●"

                If darkMode Then
                    check_showPassword.Image = My.Resources.eyeWhite
                Else

                    check_showPassword.Image = My.Resources.showpassword

                End If

            End If

        End Sub



        Private Sub txt_username_Enter(sender As Object, e As EventArgs) Handles txt_username.Enter
            txt_password.PasswordChar = "●"
            check_showPassword.Checked = False
            lbl_error.Text = ""
        End Sub

        Private Sub txt_password_Enter(sender As Object, e As EventArgs) Handles txt_password.Enter

            lbl_error.Text = ""
        End Sub


        Private Sub txt_password_Leave(sender As Object, e As EventArgs) Handles txt_password.Leave
            txt_password.PasswordChar = "●"
            check_showPassword.Checked = False
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


#Region "error display"








#End Region




#Region " light / dark"

        Public Sub ColorMode()

            If My.Settings.IsLightMode = False Then
                'lbl_category.ForeColor = foreColor

                button_close.Image = My.Resources.crossWhite


                check_showPassword.Image = My.Resources.eyeWhite


                txt_username.BackColor = ColorTranslator.FromHtml(My.Settings.darkPanelColor)
                txt_password.BackColor = ColorTranslator.FromHtml(My.Settings.darkPanelColor)


                txt_username.ForeColor = Color.White
                txt_password.ForeColor = Color.White

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



#Region " forgort password "
        Private Sub lbl_forget_password_Click(sender As Object, e As EventArgs) Handles lbl_forget_password.Click
            ForgotPassword.Show()
            Me.Close()
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



#Region " key events "

        Private Sub EscPressed(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown

            If e.KeyCode = Keys.Escape Then
                Me.Close()
            End If

        End Sub

#End Region



    End Class
End Namespace