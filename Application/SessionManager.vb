Public Class SessionManager

    Private Sub New()

    End Sub

    Private Shared _instance As SessionManager


    ' user Info
    Public Property currentUserId As Integer = 1
    Public Property currentUsername As String
    Public Property currentNumber As String
    Public Property currentPassword As String
    Public Property currentLoginTime As DateTime




    ' expense display management
    Public Property currentDate As DateTime = DateTime.Now




    Public Shared ReadOnly Property Instance() As SessionManager
        Get
            If _instance Is Nothing Then
                _instance = New SessionManager()
            End If
            Return _instance
        End Get
    End Property



End Class




' to access
' SessionManager.Instance._____ = what we want to assign