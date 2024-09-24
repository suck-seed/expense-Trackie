Imports expense_Trackie.DataLayer
Imports expense_Trackie.Presentation

Namespace Application

    Public Class UserManager

        Dim _userRepository As New UserRepository()
        Dim _userId As Integer = 0

#Region "register"

        Public Function RegisterUser(ByVal username As String, ByVal number As String, ByVal password As String, ByVal dateJoined As DateTime, ByVal imageAddress As String) As Integer

            ' if both username and number exists
            If _userRepository.IsDuplicateUser(username, "") Then
                SignUp.lbl_info.Text = " Username already exists "
                Return -1
            End If

            If _userRepository.IsDuplicateUser("", number) Then
                SignUp.lbl_info.Text = (" Number already in use ")
                Return -1
            End If

            'If _userRepository.IsDuplicateUser(username, number) Then
            '    MsgBox("A user with above information already exists "
            '    Return -1
            'End If


            _userId = _userRepository.AddUser(username, number, password, dateJoined, imageAddress)

            ' if registration successful we would store the returned userId as current id
            If _userId > 0 Then

                SetUserSessionInformation(_userId)

            End If

            Return _userId

        End Function


#End Region


#Region "login"


        Public Function LogUserIn(ByVal username As String, ByVal password As String) As Integer


            If _userRepository.IsDuplicateUser(username, "") Then

                ' since username exist, we proceed to login
                ' signIn from userRepository signIns and returns the 'id' of the user 

                _userId = _userRepository.SignIn(username, password)

                If _userId > 0 Then


                    SetUserSessionInformation(_userId)


                End If
                Return _userId


            Else

                SignIn.lbl_error.Text = " User does not exist "
                'MessageBox.Show(" User does not exist ", " Invalid username ")
                Return -1


            End If


        End Function
#End Region

#Region " update "

        Public Function UpdateUserInfo(ByVal _username As String, ByVal _password As String, ByVal _number As String, ByVal _dailyLimit As Decimal, ByVal _profileLink As String, ByVal userId As Integer, ByRef lbl_info As Label) As Integer

            Dim currentUsername As String = SessionManager.Instance.CurrentUsername
            Dim currentNumber As String = SessionManager.Instance.CurrentNumber


            ' different username number but already exists to other

            If _userRepository.IsDuplicateUser(_username, "") And _username <> currentUsername Then
                lbl_info.Text = " Username already exists "

                Return -1
            End If

            If _userRepository.IsDuplicateUser("", _number) And _number <> currentNumber Then

                lbl_info.Text = (" Number already is in use ")
                Return -1
            End If




            ' EVERYTHING ELSE THAN username & number is changed
            If _userRepository.IsDuplicateUser(_username, "") = True And _username = currentUsername And _userRepository.IsDuplicateUser("", _number) = True And _number = currentNumber Then

                If _userRepository.UpdateUser(_username, _password, _number, _dailyLimit, _profileLink, userId) > 0 Then


                    SetUserSessionInformation(userId)
                    Return 1
                Else

                    Return -1

                End If

            End If


            ' anything else bhaye ma
            If _userRepository.UpdateUser(_username, _password, _number, _dailyLimit, _profileLink, userId) > 0 Then


                SetUserSessionInformation(userId)
                Return 1
            Else

                Return -1

            End If




        End Function

#End Region


#Region "delete user"

        Public Function DeleteUser(ByVal currentId As Integer) As Integer

            If _userRepository.DeleteUserInfo(currentId) Then
                Return 1
            Else
                Return -1
            End If

        End Function

#End Region


#Region "setting session user info"

        Private Sub SetUserSessionInformation(ByVal userId As Integer)

            Dim dataTable As DataTable = _userRepository.FetchUserInfo(userId)


            SessionManager.Instance.CurrentUserId = userId
            SessionManager.Instance.CurrentLoginTime = DateTime.Now

            For Each row As DataRow In dataTable.Rows


                SessionManager.Instance.CurrentUsername = row("username").ToString
                SessionManager.Instance.CurrentPassword = row("password").ToString
                SessionManager.Instance.CurrentNumber = row("number").ToString
                SessionManager.Instance.CurrentDateJoined = DateTime.Parse(row("dateJoined").ToString)
                SessionManager.Instance.CurrentProfileLink = row("profilePicturePath").ToString

                If Not IsDBNull(row("dailyLimit")) Then
                    SessionManager.Instance.CurrentDailyLimit = CDec(row("dailyLimit"))
                End If


            Next


        End Sub

#End Region

    End Class
End NameSpace