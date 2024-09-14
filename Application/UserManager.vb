Public Class UserManager

    Dim userRepository As New UserRepository()
    Dim userId As Integer = 0

    'register if no duplicate exists
    Public Function registerUser(ByVal username As String, ByVal number As String, ByVal password As String, ByVal dateJoined As DateTime) As Integer

        If userRepository.isDuplicateUser(username, number) = 1 Then
            MsgBox("A user with above information already exists ")

            ' returing -1 to show 
            Return -1
        End If

        ' proceeding with adding the user

        userId = userRepository.addUser(username, number, password, dateJoined)

        ' if registeration successful we would store the returned userId as currentiD
        If userId > 0 Then
            SessionManager.Instance.currentUserId = userId

            MsgBox(SessionManager.Instance.currentUserId)

        End If

        Return userId

    End Function




    Public Function logUserIn(ByVal username As String, ByVal password As String) As Integer


        If userRepository.isDuplicateUser(username, "") = 1 Then

            ' since username exist, we proceed to login
            ' signIn from userRepository signIns and returns the 'id' of the user 
            userId = userRepository.signIn(username, password)

            If userId > 0 Then
                SessionManager.Instance.currentUserId = userId

            End If

            Return userId

        Else

            MsgBox("User under the username does not exists. ")
            Return -1


        End If









    End Function

End Class
