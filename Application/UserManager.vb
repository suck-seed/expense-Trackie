Public Class UserManager

    Dim userRepository As New UserRepository()
    Dim userId As Integer = 0

#Region "register"

    Public Function registerUser(ByVal username As String, ByVal number As String, ByVal password As String, ByVal dateJoined As DateTime, ByVal imageAddress As String) As Integer


        If userRepository.isDuplicateUser(username, number) Then
            MsgBox("A user with above information already exists ")


            Return -1
        End If


        userId = userRepository.addUser(username, number, password, dateJoined, imageAddress)

        ' if registeration successful we would store the returned userId as currentiD
        If userId > 0 Then

            setUserSessionInformation(userId)

        End If

        Return userId

    End Function


#End Region


#Region "login"


    Public Function logUserIn(ByVal username As String, ByVal password As String) As Integer


        If userRepository.isDuplicateUser(username, "") Then

            ' since username exist, we proceed to login
            ' signIn from userRepository signIns and returns the 'id' of the user 

            userId = userRepository.signIn(username, password)

            If userId > 0 Then

                setUserSessionInformation(userId)


            End If
            Return userId


        Else

            MsgBox("User under the username does not exists. ")
            Return -1


        End If


    End Function
#End Region


#Region "setting session user info"



    Public Sub setUserSessionInformation(ByVal userId As Integer)

        Dim dataTable As DataTable = userRepository.fetchUserInfo(userId)


        SessionManager.Instance.currentUserId = userId
        SessionManager.Instance.currentLoginTime = DateTime.Now

        For Each row As DataRow In dataTable.Rows


            SessionManager.Instance.currentUsername = row("username").ToString
            SessionManager.Instance.currentPassword = row("password").ToString
            SessionManager.Instance.currentNumber = row("number").ToString
            SessionManager.Instance.currentdateJoined = DateTime.Parse(row("dateJoined").ToString)
            SessionManager.Instance.currentProfileLink = row("profilePicturePath").ToString


        Next


    End Sub

#End Region

End Class
