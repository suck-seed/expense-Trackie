Imports System.Drawing.Drawing2D

Public Class SignUp


    Dim number As String
    Dim username As String
    Dim password As String
    Dim dateJoined As DateTime = DateTime.Now.ToString("yyyy-MM-dd")

    Private Sub btn_signup_Click(sender As Object, e As EventArgs) Handles btn_signup.Click

        number = txt_number.Text
        username = txt_username.Text
        password = txt_password.Text

        Dim usermanager As New UserManager

        Dim userId As Integer = usermanager.registerUser(username, number, password, dateJoined)


        If userId > 0 Then
            MsgBox("User registered sucessfully")


            Me.Hide()

            mainWindow.Show()




        Else
            'MsgBox("User registration failed. Please try again.")
        End If

    End Sub

































    ' other kura
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles SignInLL.LinkClicked
        Dim form2 As New SIgnIn
        form2.Show()
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

    Private Sub button_close_Click(sender As Object, e As EventArgs) Handles button_close.Click
        Me.Close()
    End Sub


End Class