Public Class UserManager

    Dim userRepository As New UserRepository()
    Dim userId As Integer = 0

    'register if no duplicate exists
    Public Function registerUser(ByVal username As String, ByVal number As String, ByVal password As String, ByVal dateJoined As DateTime) As Integer


        If userRepository.isDuplicateUser(username, number) Then
            MsgBox("A user with above information already exists ")


            Return -1
        End If


        userId = userRepository.addUser(username, number, password, dateJoined)

        ' if registeration successful we would store the returned userId as currentiD
        If userId > 0 Then
            SessionManager.Instance.currentUserId = userId
            SessionManager.Instance.currentUsername = username
            SessionManager.Instance.currentNumber = number
            SessionManager.Instance.currentPassword = password
            SessionManager.Instance.currentLoginTime = DateTime.Now

            MsgBox(SessionManager.Instance.currentUserId)

        End If

        Return userId

    End Function




    Public Function logUserIn(ByVal username As String, ByVal password As String) As Integer


        If userRepository.isDuplicateUser(username, "") Then

            ' since username exist, we proceed to login
            ' signIn from userRepository signIns and returns the 'id' of the user 

            userId = userRepository.signIn(username, password)

            If userId > 0 Then

                SessionManager.Instance.currentUserId = userId
                SessionManager.Instance.currentUsername = username
                SessionManager.Instance.currentPassword = password
                SessionManager.Instance.currentLoginTime = DateTime.Now

            End If

            Return userId

        Else

            MsgBox("User under the username does not exists. ")
            Return -1


        End If


    End Function

End Class
