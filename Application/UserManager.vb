Imports expense_Trackie.DataLayer

Namespace Application

    Public Class UserManager

        Dim _userRepository As New UserRepository()
        Dim _userId As Integer = 0

#Region "register"

        Public Function RegisterUser(ByVal username As String, ByVal number As String, ByVal password As String, ByVal dateJoined As DateTime, ByVal imageAddress As String) As Integer


            If _userRepository.IsDuplicateUser(username, number) Then
                MsgBox("A user with above information already exists ")


                Return -1
            End If


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

                MsgBox("User under the username does not exists. ")
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


            Next


        End Sub

#End Region

    End Class
End NameSpace