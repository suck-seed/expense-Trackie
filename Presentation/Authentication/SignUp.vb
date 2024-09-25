Imports System.Drawing.Drawing2D
Imports expense_Trackie.Application

Namespace Presentation

    Public Class SignUp

        Const ImageFilter As String = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"
        Dim number As String
        Dim username As String
        Dim password As String
        Dim _imageAddress As String
        ReadOnly _dateJoined As DateTime = DateTime.Now.ToString("yyyy-MM-dd")

#Region " load "

        Dim darkMode As Boolean = False
        Private borderRadius As Integer = 20


        Private Sub Signup_Load(sender As Object, e As EventArgs) Handles MyBase.Load

            If My.Settings.IsLightMode = False Then
                ForeColor = Color.White
                darkMode = True
                Me.BackColor = ColorTranslator.FromHtml("#191D1C")
            Else
                Me.BackColor = ColorTranslator.FromHtml("#EEF4F9")
            End If



            ColorMode()

            MakePictureBoxCircular(img_profile)
            lbl_info.Text = ""

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



#Region "Signup"


        Private Sub btn_signup_Click(sender As Object, e As EventArgs) Handles btn_signup.Click


            If Not Integer.TryParse(txt_number.Text, number) Then
                lbl_info.Text = "Number cannot contain string characters"
                Return
            End If

            If txt_number.Text.Length > 10 Or txt_number.Text.Length < 10 Then
                lbl_info.Text = ("Number should be 10 char long")
                Return
            End If

            If String.IsNullOrEmpty(txt_number.Text) Or String.IsNullOrEmpty(txt_username.Text) Or String.IsNullOrEmpty(txt_password.Text) Then
                lbl_info.Text = "Fill all the fields"
                Return
            End If


            If txt_username.Text.Length < 8 Then
                lbl_info.Text = ("Username must be at least 8 char long")
                Return
            End If



            number = txt_number.Text
            username = txt_username.Text
            password = txt_password.Text



            'password validation ko laagi
            If password.Length < 8 Then
                lbl_info.Text = ("Password must be at least 8 char long")
                Return
            End If

            If Not password.Any(AddressOf Char.IsDigit) Then
                lbl_info.Text = ("Password must contain at least one number.")
                Return
            End If

            If Not password.Any(Function(c) "@#%^".Contains(c)) Then
                lbl_info.Text = ("Password must contain at least one special character (@, #, %, ^).")
                Return
            End If

            If Not password.Any(AddressOf Char.IsUpper) Then
                lbl_info.Text = ("Password must contain at least one uppercase letter.")
                Return
            End If

            If Not password.Any(AddressOf Char.IsLower) Then
                lbl_info.Text = ("Password must contain at least one lowercase letter.")
                Return
            End If





            ' backend handling
            Dim userManager As New UserManager

            Dim userId As Integer = userManager.RegisterUser(username, number, password, _dateJoined, _imageAddress)


            If userId > 0 Then

                lbl_info.Text = ("User registered successfully")

                If My.Settings.IsRemembered = False Then

                    If MessageBox.Show(" Want to be remembered ?", "Remember Credentials", MessageBoxButtons.YesNo) = DialogResult.Yes Then

                        My.Settings.SavedUsername = username
                        My.Settings.SavedPassword = EncryptPassword(password)
                        My.Settings.IsRemembered = True
                        'My.Settings.SavedPassword = (_password)

                        My.Settings.Save()

                    End If


                End If



                MainWindow.Show()
                Me.Close()
                ClearInputFields()

            Else
                lbl_info.Text = "User registration failed"
            End If

        End Sub

#End Region


#Region "fetching image"

        Private Sub profilePicture_Click(sender As Object, e As EventArgs) Handles img_profile.Click
            lbl_info.Text = ""

            Dim fileDialog As New OpenFileDialog


            fileDialog.Filter = ImageFilter

            If fileDialog.ShowDialog = DialogResult.OK Then

                _imageAddress = fileDialog.FileName
                img_profile.Image = Image.FromFile(_imageAddress)


            End If

        End Sub



#End Region



#Region "signIn passing"


        ' other kura
        Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles SignInLL.LinkClicked
            Dim form2 As New SignIn
            form2.Show()
            Me.Hide()
        End Sub

#End Region




#Region "other functionality"

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


        Private Sub txt_password_Leave(sender As Object, e As EventArgs) Handles txt_password.Leave
            txt_password.PasswordChar = "●"
            check_showPassword.Checked = False

        End Sub

        Private Sub txt_password_Enter(sender As Object, e As EventArgs) Handles txt_password.Enter

            lbl_info.Text = ""

        End Sub


        Private Sub txt_number_Enter(sender As Object, e As EventArgs) Handles txt_number.Enter
            txt_password.PasswordChar = "●"
            check_showPassword.Checked = False
            lbl_info.Text = ""

        End Sub

        Private Sub txt_username_Enter(sender As Object, e As EventArgs) Handles txt_username.Enter
            txt_password.PasswordChar = "●"
            check_showPassword.Checked = False
            lbl_info.Text = ""

        End Sub



#End Region





#Region " info board "

        Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles infoTool.MouseHover
            ToolTip1.SetToolTip(infoTool, "Make sure your password is 
        at least 8 characters and contains: 

        -> At least 1 Uppercase
        letter and 1 lowercase
        letter
        -> At least 1 number
        -> At least 1 special
        character(like @#%^)

            Avoid common passwords or
        strings like ""password"",
        ""qwerty"" or ""123456789""")

        End Sub

        Private Sub infoTool_MouseEnter(sender As Object, e As EventArgs) Handles infoTool.MouseEnter
            svgInfo.Visible = False

            If darkMode Then
                infoTool.Image = My.Resources.infoWhiteSelected
            Else

                infoTool.Image = My.Resources.infoDark

            End If

        End Sub

        Private Sub infoTool_MouseLeave(sender As Object, e As EventArgs) Handles infoTool.MouseLeave
            svgInfo.Visible = True

            If darkMode Then
                infoTool.Image = My.Resources.infoWhite
            Else

                infoTool.Image = My.Resources.info

            End If

        End Sub
#End Region



#Region " make picturebox circle "

        Public Sub MakePictureBoxCircular(ByVal picBox As PictureBox)
            ' Create a circular path
            Dim path As New GraphicsPath
            path.AddEllipse(0, 0, picBox.Width, picBox.Height)

            ' Apply the circular region to the PictureBox
            picBox.Region = New Region(path)
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


                check_showPassword.Image = My.Resources.eyeWhite
                infoTool.Image = My.Resources.infoWhite

            End If

        End Sub

        Private Sub button_close_Click(sender As Object, e As EventArgs) Handles button_close.Click
            Me.Close()
        End Sub
#End Region
    End Class
End NameSpace