Namespace Application
    Public Class SessionManager

        Private Sub New()

        End Sub

        Private Shared _instance As SessionManager


        ' user Info
        Public Property CurrentUserId As Integer
        Public Property CurrentUsername As String
        Public Property CurrentNumber As String
        Public Property CurrentPassword As String
        Public Property CurrentDailyLimit As Decimal
        Public Property CurrentLoginTime As DateTime
        Public Property CurrentProfileLink As String
        Public Property CurrentDateJoined As DateTime
        Public Property TextColor As Color = Color.White




        ' expense display management
        Public Property CurrentDate As DateTime



        Public Shared ReadOnly Property Instance() As SessionManager
            Get
                If _instance Is Nothing Then
                    _instance = New SessionManager()
                End If
                Return _instance
            End Get
        End Property



        ' selected category
        Private Shared _selectedCategoryIds As List(Of Integer)

        Public Shared Property SelectedCategoryIds As List(Of Integer)
            Get
                If _selectedCategoryIds Is Nothing Then
                    _selectedCategoryIds = New List(Of Integer)
                End If
                Return _selectedCategoryIds
            End Get
            Set(value As List(Of Integer))
                _selectedCategoryIds = value
            End Set
        End Property




        Private Shared _selectedCategoryIds2 As List(Of Integer)

        Public Shared Property SelectedCategoryIds2 As List(Of Integer)
            Get
                If _selectedCategoryIds2 Is Nothing Then
                    _selectedCategoryIds2 = New List(Of Integer)
                End If
                Return _selectedCategoryIds2
            End Get
            Set(value As List(Of Integer))
                _selectedCategoryIds2 = value
            End Set
        End Property



    End Class




    ' to access
    ' SessionManager.Instance._____ = what we want to assign
End NameSpace