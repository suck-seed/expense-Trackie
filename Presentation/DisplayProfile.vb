Imports System.Drawing.Drawing2D
Imports expense_Trackie.Application
Imports expense_Trackie.Presentation

Public Class DisplayProfile


#Region " data members "

    ' data members
    Dim usernameChanged As Boolean = False
    Dim passwordChanged As Boolean = False
    Dim numberChanged As Boolean = False
    Dim dailyLimitChanged As Boolean = False
    Dim profileLinkChanged As Boolean = False


    Dim currentId As Integer
    Dim currentUsername As String
    Dim currentPassword As String
    Dim currentNumber As String
    Dim currentDailyLimit As Decimal
    Dim currentProfilePictureLink As String


    'Dim currentPassword As 
    Dim _username As String
    Dim _password As String
    Dim _number As String
    Dim _dailyLimit As Decimal
    Dim _profileLink As String = ""

#End Region

    '#Region " new instance created "

    '    Public Sub New()

    '        ' This call is required by the designer.
    '        InitializeComponent()

    '        ' Add any initialization after the InitializeComponent() call.

    '    End Sub

    '#End Region


#Region " load "

    Private Sub DisplayProfile_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        ' loading


        loadInformation()

        txt_username.Text = currentUsername
        txt_password.Text = currentPassword
        txt_number.Text = currentNumber
        txt_dailyLimit.Text = currentDailyLimit

        If Not String.IsNullOrEmpty(currentProfilePictureLink) Then

            btn_profile.Image = Image.FromFile(currentProfilePictureLink)

        End If

    End Sub

    Public Sub loadInformation()

        currentId = SessionManager.Instance.CurrentUserId
        currentUsername = SessionManager.Instance.CurrentUsername
        currentPassword = SessionManager.Instance.CurrentPassword
        currentNumber = SessionManager.Instance.CurrentNumber
        currentDailyLimit = SessionManager.Instance.CurrentDailyLimit
        currentProfilePictureLink = SessionManager.Instance.CurrentProfileLink
        _profileLink = currentProfilePictureLink

    End Sub

#End Region



#Region " update button clicked "


    Private Sub btn_Update_Clicked(sender As Object, e As EventArgs) Handles btn_update.Click


        MsgBox("Button pressed")


        If _profileLink <> currentProfilePictureLink Then
            profileLinkChanged = True
        Else
            profileLinkChanged = False
        End If


        If String.IsNullOrEmpty(txt_username.Text) Or String.IsNullOrEmpty(txt_password.Text) Or String.IsNullOrEmpty(txt_number.Text) Then
            MsgBox(" Fill all the required information.")
            Return
        End If

        ' is info changed or not
        If Not usernameChanged And Not passwordChanged And Not numberChanged And Not dailyLimitChanged And Not profileLinkChanged Then
            MsgBox("Please change atleast one information")
            Return
        End If

        If Not Decimal.TryParse(txt_dailyLimit.Text, _dailyLimit) Then
            MsgBox("Amount should be Decimal ")
            Return
        Else
            _dailyLimit = CDec(txt_dailyLimit.Text)
        End If


        'is the formatting correct?
        'make changes in db
        _username = txt_username.Text
        _password = txt_password.Text
        _number = txt_number.Text


        Dim userManager As New UserManager

        If userManager.UpdateUserInfo(_username, _password, _number, _dailyLimit, _profileLink, currentId) > 0 Then

            MsgBox("Updated successfully")

            'reflect changes in mainwindow
            loadInformation()
            MainWindow.LoadInformation()


        End If




    End Sub

#End Region


#Region " is properties even changes? "

    Private Sub txt_username_TextChanged(sender As Object, e As EventArgs) Handles txt_username.TextChanged
        If txt_username.Text <> currentUsername Then
            usernameChanged = True
        Else
            usernameChanged = False

        End If


    End Sub

    Private Sub txt_password_TextChanged(sender As Object, e As EventArgs) Handles txt_password.TextChanged
        If txt_password.Text <> currentPassword Then
            passwordChanged = True

        Else
            passwordChanged = False

        End If


    End Sub

    Private Sub txt_number_TextChanged(sender As Object, e As EventArgs) Handles txt_number.TextChanged
        If txt_number.Text <> currentNumber Then
            numberChanged = True
        Else
            numberChanged = False
        End If


    End Sub

    Private Sub txt_dailyLimit_TextChanged(sender As Object, e As EventArgs) Handles txt_dailyLimit.TextChanged
        Dim dailylimit As Decimal
        If Decimal.TryParse(txt_dailyLimit.Text, dailylimit) Then

            If CDec(txt_dailyLimit.Text) <> currentDailyLimit Then
                dailyLimitChanged = True

            Else
                dailyLimitChanged = False
            End If

        End If
    End Sub



    Private Sub btn_profile_Click(sender As Object, e As EventArgs) Handles btn_profile.Click
        Dim fileDialog As New OpenFileDialog


        Const ImageFilter As String = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"
        fileDialog.Filter = ImageFilter

        If fileDialog.ShowDialog = DialogResult.OK Then

            _profileLink = fileDialog.FileName
            btn_profile.Image = Image.FromFile(_profileLink)


        End If
    End Sub


#End Region


#Region " logout "

    Private Sub btn_logout_Click(sender As Object, e As EventArgs) Handles btn_logout.Click

        If MessageBox.Show("Do you want to logout ?", "Logout", MessageBoxButtons.YesNo) = DialogResult.Yes Then

            ClearSessionInfo()

            Me.Close()
            MainWindow.Close()
            SignIn.Show()


        End If



    End Sub

#End Region


#Region " log out "
    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click

        If MessageBox.Show("Do you want to delete account ?", "Delete Account", MessageBoxButtons.YesNo) = DialogResult.Yes Then

            '
            Dim userManager As New UserManager

            If userManager.DeleteUser(currentId) > 0 Then

                ClearSessionInfo()
                Me.Close()
                MainWindow.Close()
                SignIn.Show()


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

    Private Sub button_close_Click(sender As Object, e As EventArgs) Handles button_close.Click
        Me.Close()
    End Sub












#End Region


End Class