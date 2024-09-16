Public Class CategoryManager

    Private categoryrepository As New CategoryRepository()


    Public Function registerCategory(ByRef catName As String, ByRef catDescription As String, ByRef catColor As String) As Integer


        ' checking is category alreadye exists
        If categoryrepository.isDuplicateCategory(catName) Then
            MsgBox("A category with provided name already exists")
            Return -1
        End If


        'proceeding with adding category
        Dim added As Integer = categoryrepository.addCategory(catName, catDescription, catColor)
        Return added


    End Function

End Class
