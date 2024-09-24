Imports System.Drawing.Drawing2D
Imports expense_Trackie.Application

Namespace Presentation

    Public Class SignIn

        ' SIGN IN SYSTEM
        Dim _username As String
        Dim _password As String
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



                MsgBox(SessionManager.Instance.CurrentUserId)
                MsgBox(SessionManager.Instance.CurrentUsername)
                MsgBox(SessionManager.Instance.CurrentPassword)
                MsgBox(SessionManager.Instance.CurrentNumber)
                MsgBox(SessionManager.Instance.CurrentDateJoined)
                MsgBox(SessionManager.Instance.CurrentProfileLink)

                MainWindow.Show()

                Me.Close()

                ClearInputFields()

            Else
                lbl_error.Text = "Failed logging user in"

            End If



        End Sub




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


        Private Sub ShowPassCB_CheckedChanged(sender As Object, e As EventArgs) Handles ShowPassCB.CheckedChanged
            If ShowPassCB.Checked = True Then
                txt_password.PasswordChar = ""

            Else
                txt_password.PasswordChar = "●"
            End If

        End Sub


        Private Sub txt_password_Leave(sender As Object, e As EventArgs) Handles txt_password.Leave
            txt_password.PasswordChar = "●"
            ShowPassCB.Checked = False

        End Sub


        Private Sub txt_username_Enter(sender As Object, e As EventArgs) Handles txt_username.Enter
            txt_password.PasswordChar = "●"
            ShowPassCB.Checked = False
        End Sub






#End Region


#Region " gradient "


        '---- gradient display ----'
        Private Sub Form1_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
            Dim rect As New Rectangle(0, 0, Me.ClientSize.Width, Me.ClientSize.Height)

            Dim startColor As Color = Color.Beige
            Dim endColor As Color = Color.AliceBlue

            Using brush As New LinearGradientBrush(rect, startColor, endColor, LinearGradientMode.Horizontal)
                e.Graphics.FillRectangle(brush, rect)
            End Using
        End Sub

        Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
            Me.Invalidate()
        End Sub



#End Region


#Region "error display"
        Private Sub txt_username_TextChanged(sender As Object, e As EventArgs) Handles txt_username.Enter
            lbl_error.Text = ""
        End Sub

        Private Sub txt_password_TextChanged(sender As Object, e As EventArgs) Handles txt_password.Enter
            lbl_error.Text = ""
        End Sub




#End Region


    End Class
End NameSpace