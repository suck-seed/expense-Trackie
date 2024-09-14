Public Class UserManager

    Dim userRepository As New UserRepository()


    'register if no duplicate exists
    Public Function registerUser(ByVal username As String, ByVal number As String, ByVal password As String, ByVal dateJoined As DateTime) As Integer

        If userRepository.isDuplicateUser(username, number) = 1 Then
            MsgBox("A user with above information already exists ")

            ' returing -1 to show 
            Return -1
        End If

        ' proceeding with adding the user

        Dim userId As Integer = userRepository.addUser(username, number, password, dateJoined)

        ' if registeration successful we would store the returned userId as currentiD
        If userId > 0 Then
            SessionManager.Instance.currentUserId = userId

            MsgBox(SessionManager.Instance.currentUserId)

        End If

        Return userId

    End Function

End Class
