Imports System.Drawing.Drawing2D
Imports expense_Trackie.Application

Namespace Presentation

    Public Class DisplayProfile


#Region " data members "

        ' data members
        Dim _usernameChanged As Boolean = False
        Dim _passwordChanged As Boolean = False
        Dim _numberChanged As Boolean = False
        Dim _dailyLimitChanged As Boolean = False
        Dim _profileLinkChanged As Boolean = False


        Dim _currentId As Integer
        Dim _currentUsername As String
        Dim _currentPassword As String
        Dim _currentNumber As String
        Dim _currentDailyLimit As Decimal
        Dim _currentProfilePictureLink As String


        'Dim currentPassword As 
        Dim _username As String
        Dim _password As String
        Dim _number As String
        Dim _dailyLimit As Decimal
        Dim _profileLink As String = ""


        'for refreshing or not calander
        Dim _enteredLimit As Decimal
        Dim _lastSessionLimit As Decimal = SessionManager.Instance.CurrentDailyLimit

#End Region

#Region " new instance created "

        Dim _calanderView As CalanderView

        Public Sub New(ByRef calanderView As CalanderView)

            ' This call is required by the designer.
            InitializeComponent()

            ' Add any initialization after the InitializeComponent() call.
            _calanderView = calanderView

        End Sub

#End Region


#Region " load "

        Dim darkMode As Boolean = False


        Private Sub DisplayProfile_Load(sender As Object, e As EventArgs) Handles MyBase.Load


            If My.Settings.IsLightMode = False Then
                ForeColor = Color.White
                darkMode = True
                Me.BackColor = ColorTranslator.FromHtml("#191D1C")
            Else
                Me.BackColor = ColorTranslator.FromHtml("#EEF4F9")
            End If

            ColorMode()


            lbl_info.Text = ""
            ' loading
            MakePictureBoxCircular(img_profile)

            LoadCurrentUserInformation()

            txt_username.Text = _currentUsername
            txt_password1.Text = _currentPassword
            txt_number.Text = _currentNumber
            txt_dailyLimit.Text = _currentDailyLimit

            If Not String.IsNullOrEmpty(_currentProfilePictureLink) Then

                img_profile.Image = Image.FromFile(_currentProfilePictureLink)

            End If

        End Sub

        Public Sub LoadCurrentUserInformation()

            _currentId = SessionManager.Instance.CurrentUserId
            _currentUsername = SessionManager.Instance.CurrentUsername
            _currentPassword = SessionManager.Instance.CurrentPassword
            _currentNumber = SessionManager.Instance.CurrentNumber
            _currentDailyLimit = SessionManager.Instance.CurrentDailyLimit
            _currentProfilePictureLink = SessionManager.Instance.CurrentProfileLink
            _profileLink = _currentProfilePictureLink

        End Sub

#End Region



#Region " update button clicked "


        Private Sub btn_Update_Clicked(sender As Object, e As EventArgs) Handles btn_update.Click


            'MsgBox("Button pressed")


            If _profileLink <> _currentProfilePictureLink Then
                _profileLinkChanged = True
            Else
                _profileLinkChanged = False
            End If


            If String.IsNullOrEmpty(txt_username.Text) Or String.IsNullOrEmpty(txt_password1.Text) Or String.IsNullOrEmpty(txt_number.Text) Then
                lbl_info.Text = (" Fill all the required information.")
                Return
            End If

            ' is info changed or not
            If Not _usernameChanged And Not _passwordChanged And Not _numberChanged And Not _dailyLimitChanged And Not _profileLinkChanged Then
                lbl_info.Text = ("Please change atleast one information")
                Return
            End If

            If Not Decimal.TryParse(txt_dailyLimit.Text, _dailyLimit) Then
                lbl_info.Text = ("Amount should be Decimal ")
                Return
            Else
                _dailyLimit = CDec(txt_dailyLimit.Text)
                _enteredLimit = _dailyLimit
            End If


            'is the formatting correct?
            'make changes in db
            _username = txt_username.Text
            _password = txt_password1.Text
            _number = txt_number.Text


            Dim userManager As New UserManager

            If userManager.UpdateUserInfo(_username, _password, _number, _dailyLimit, _profileLink, _currentId, lbl_info) > 0 Then

                ' if saved password strings arent empty
                'If Not String.IsNullOrEmpty(My.Settings.SavedUsername) And Not String.IsNullOrEmpty(My.Settings.SavedPassword) Then

                If My.Settings.IsRemembered = True Then

                    'updating saved passwordId
                    My.Settings.SavedUsername = _username
                    My.Settings.SavedPassword = EncryptPassword(_password)
                    My.Settings.Save()


                End If



                lbl_info.ForeColor = Color.Green
                lbl_info.Text = (" Updated successfully ")

                LoadCurrentUserInformation()

                'reflect changes in mainwindow
                MainWindow.LoadUserInformation()

                If _enteredLimit <> _lastSessionLimit Then
                    _calanderView.DisplayInformation()

                End If

            End If


        End Sub



#End Region


#Region " is properties even changes? "

        Private Sub txt_username_TextChanged(sender As Object, e As EventArgs) Handles txt_username.TextChanged
            If txt_username.Text <> _currentUsername Then
                _usernameChanged = True
            Else
                _usernameChanged = False

            End If


        End Sub

        Private Sub txt_password_TextChanged(sender As Object, e As EventArgs) Handles txt_password1.TextChanged
            If txt_password1.Text <> _currentPassword Then
                _passwordChanged = True

            Else
                _passwordChanged = False

            End If


        End Sub

        Private Sub txt_number_TextChanged(sender As Object, e As EventArgs) Handles txt_number.TextChanged
            If txt_number.Text <> _currentNumber Then
                _numberChanged = True
            Else
                _numberChanged = False
            End If


        End Sub

        Private Sub txt_dailyLimit_TextChanged(sender As Object, e As EventArgs) Handles txt_dailyLimit.TextChanged
            Dim dailylimit As Decimal
            If Decimal.TryParse(txt_dailyLimit.Text, dailylimit) Then

                If CDec(txt_dailyLimit.Text) <> _currentDailyLimit Then
                    _dailyLimitChanged = True

                Else
                    _dailyLimitChanged = False
                End If

            End If
        End Sub



        Private Sub ImageProfileClick(sender As Object, e As EventArgs) Handles img_profile.Click
            Dim fileDialog As New OpenFileDialog


            Const imageFilter As String = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"
            fileDialog.Filter = imageFilter

            If fileDialog.ShowDialog = DialogResult.OK Then

                _profileLink = fileDialog.FileName
                img_profile.Image = Image.FromFile(_profileLink)


            End If
        End Sub


#End Region


#Region " logout "

        Private Sub btn_logout_Click(sender As Object, e As EventArgs) Handles btn_logout.Click

            If MessageBox.Show("Do you want to logout ?", "Logout", MessageBoxButtons.YesNo) = DialogResult.Yes Then


                ClearSessionInfo()
                ClearSavedInfo()

                SignIn.Show()
                Me.Close()
                MainWindow.Close()



            End If



        End Sub

#End Region


#Region " delete account "
        Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click

            If MessageBox.Show("Do you want to delete account ?", "Delete Account", MessageBoxButtons.YesNo) = DialogResult.Yes Then

                '
                Dim userManager As New UserManager

                If userManager.DeleteUser(_currentId) > 0 Then

                    ClearSessionInfo()
                    ClearSavedInfo()

                    SignIn.Show()
                    Me.Close()
                    MainWindow.Close()



                End If




            End If

        End Sub

#End Region




#Region " mouse movement / gradient "

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



        Private Sub button_close_Click(sender As Object, e As EventArgs) Handles button_close.Click
            Me.Close()
        End Sub












#End Region



#Region " key events "

        Private Sub EscPressed(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown

            If e.KeyCode = Keys.Escape Then
                Me.Close()
            End If

        End Sub





#End Region


#Region " password show / clearning label info"
        Private Sub check_showPassword_CheckedChanged(sender As Object, e As EventArgs) Handles check_showPassword.CheckedChanged

            If check_showPassword.Checked = True Then
                txt_password1.PasswordChar = ""

                If darkMode Then
                    check_showPassword.Image = My.Resources.eyeWhiteSelected
                Else

                    check_showPassword.Image = My.Resources.showpasswordDark

                End If

            Else
                txt_password1.PasswordChar = "●"

                If darkMode Then
                    check_showPassword.Image = My.Resources.eyeWhite
                Else

                    check_showPassword.Image = My.Resources.showpassword

                End If

            End If

        End Sub

        Private Sub txt_username_Enter(sender As Object, e As EventArgs) Handles txt_username.Enter
            lbl_info.Text = ""
            txt_password1.PasswordChar = "●"
            check_showPassword.Checked = False
        End Sub

        Private Sub txt_number_Enter(sender As Object, e As EventArgs) Handles txt_number.Enter
            lbl_info.Text = ""
            txt_password1.PasswordChar = "●"
            check_showPassword.Checked = False
        End Sub

        Private Sub txt_dailyLimit_Enter(sender As Object, e As EventArgs) Handles txt_dailyLimit.Enter
            lbl_info.Text = ""
            txt_password1.PasswordChar = "●"
            check_showPassword.Checked = False
        End Sub

        Private Sub txt_password1_Enter(sender As Object, e As EventArgs) Handles txt_password1.Enter
            lbl_info.Text = ""
        End Sub



        'clearing lbl_info and all

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

                btn_logout.Image = My.Resources.logoutwhite

                check_showPassword.Image = My.Resources.eyeWhite

                btn_update.ForeColor = Color.Black

            End If

        End Sub
#End Region

    End Class
End NameSpace