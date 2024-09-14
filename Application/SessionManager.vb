Public Class SessionManager

    Private Sub New()

    End Sub

    Private Shared _instance As SessionManager

    Public Property currentUserId As Integer
    Public Property currentUsername As String


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