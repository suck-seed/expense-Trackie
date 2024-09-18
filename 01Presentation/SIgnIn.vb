Imports System.Drawing.Drawing2D

Public Class SIgnIn

    ' SIGN IN SYSTEM
    Dim username As String
    Dim password As String
    Private Sub SignInBtn_Click(sender As Object, e As EventArgs) Handles SignInBtn.Click

        username = txt_username.Text
        password = txt_password.Text


        ' 
        If String.IsNullOrEmpty(username) Or String.IsNullOrEmpty(password) Then
            MsgBox("Please fill all details")
            Return

        End If





        ' application and backend referal
        Dim usermanager As New UserManager()

        Dim userId As Integer = usermanager.logUserIn(username, password)

        If userId > 0 Then

            MsgBox("Login sucessful")

            MsgBox(SessionManager.Instance.currentUserId)
            MsgBox(SessionManager.Instance.currentUsername)
            MsgBox(SessionManager.Instance.currentPassword)
            MsgBox(SessionManager.Instance.currentNumber)
            MsgBox(SessionManager.Instance.currentdateJoined)
            MsgBox(SessionManager.Instance.currentProfileLink)

            Me.Hide()

            Dim mainScreen As New mainWindow
            mainScreen.Show()

        Else
            MsgBox("User login failed. Please try again.")
        End If



    End Sub






    ' other kura
    Private Sub button_close_Click(sender As Object, e As EventArgs) Handles button_close.Click
        Me.Close()
    End Sub


    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles SignUpLL.LinkClicked
        Dim form1 As New SignUp
        form1.Show()
        Me.Hide()
    End Sub

    Private Sub PassTxt_Enter(sender As Object, e As EventArgs) Handles txt_password.Enter
        UpdatePasswordVisibility()
    End Sub

    Private Sub PassTxt_Leave(sender As Object, e As EventArgs) Handles txt_password.Leave
        If String.IsNullOrWhiteSpace(txt_password.Text) Then
            txt_password.PasswordChar = ControlChars.NullChar ' Remove PasswordChar to show default text
        End If
    End Sub

    Private Sub ShowPassCB_CheckedChanged(sender As Object, e As EventArgs) Handles ShowPassCB.CheckedChanged
        UpdatePasswordVisibility()
    End Sub

    Private Sub UpdatePasswordVisibility()
        If ShowPassCB.Checked Then
            ' Show the password
            txt_password.PasswordChar = ControlChars.NullChar
        Else
            ' Hide the password, unless the TextBox is empty and showing default text
            If txt_password.Text <> "Enter Password" Then
                txt_password.PasswordChar = "*"c
            Else
                txt_password.PasswordChar = ControlChars.NullChar
            End If
        End If
    End Sub

    Private Sub ShowPassCB_GotFocus(sender As Object, e As EventArgs) Handles ShowPassCB.GotFocus
        UpdatePasswordVisibility()
    End Sub


    '---- GRADIENT MILAUNA LAI ----'
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

    Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        ' Redraw the form when it is resized to update the gradient
        Me.Invalidate()
    End Sub


End Class