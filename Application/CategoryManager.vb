Imports expense_Trackie.DataLayer

Namespace Application
    Public Class CategoryManager

'        instance of CategoryRepository()    
        Private _categoryrepository As New CategoryRepository()



'        for adding category
        Public Function RegisterCategory(ByRef catName As String, ByRef catDescription As String, ByRef catColor As String) As Integer


'            checking is category already exists
            If _categoryrepository.IsDuplicateCategory(catName) Then
                MsgBox("A category with provided name already exists")
                Return -1
            End If


'            proceeding with adding category
            Dim added As Integer = _categoryrepository.AddCategory(catName, catDescription, catColor)
            Return added


        End Function



        Public Function DeleteCategory(ByRef categoryId As Integer) As Integer

            If _categoryrepository.DeleteUserCategory(categoryId) > 0 Then
                Return 1
            Else
                Return -1
            End If

'            Return -1

        End Function


'        for loading category 
        Public Sub GenerateCategoryRadioButtons(ByVal panel As FlowLayoutPanel)

'            loading a dataTable
            Dim categoryTable As DataTable = _categoryrepository.GetUserCategory()


'            panel work
            panel.Controls.Clear()


            For Each row As DataRow In categoryTable.Rows


'                variable for easy use
                Dim catId As Integer = CInt(row("catId"))
                Dim catName As String = row("catName").ToString

                Dim colorHex As String = row("color").ToString()
                Dim backColor As Color = ColorTranslator.FromHtml(colorHex)



'                assigning to radioButton
                Dim radioButton As New RadioButton

                radioButton.Text = catName
                radioButton.Tag = catId
                radioButton.BackColor = backColor


'                button cosmetics
                radioButton.Appearance = Appearance.Button
                radioButton.AutoSize = True
                radioButton.TextAlign = ContentAlignment.MiddleCenter
                radioButton.Font = New Font("Cascadia Mono SemiLight", 10, FontStyle.Regular)


                radioButton.FlatStyle = FlatStyle.Popup
                radioButton.FlatAppearance.BorderSize = 1
                radioButton.Margin = New Padding(8, 5, 8, 5)



'                adding to panel
                panel.Controls.Add(radioButton)


            Next

        End Sub


        Public Sub GenerateCategoryCheckButtons(ByVal panel As FlowLayoutPanel)

            ' loading a dataTable
            Dim categoryTable As DataTable = _categoryrepository.GetUserCategory()


            'panel work
            panel.Controls.Clear()


            For Each row As DataRow In categoryTable.Rows


                'variable for easy use
                Dim catId As Integer = row("catId")
                Dim catName As String = row("catName").ToString

                Dim colorHex As String = row("Color").ToString()
                Dim backColor As Color = ColorTranslator.FromHtml(colorHex)



                ' assigning to radioButton
                Dim checkButton As New CheckBox

                checkButton.Text = catName
                checkButton.Tag = catId
                checkButton.BackColor = backColor


                'button cosmetics
                checkButton.Appearance = Appearance.Button
                checkButton.AutoSize = True
                checkButton.TextAlign = ContentAlignment.MiddleCenter
                checkButton.Font = New Font("Cascadia Mono SemiLight", 11, FontStyle.Regular)


                checkButton.FlatStyle = FlatStyle.Flat

                checkButton.FlatAppearance.BorderSize = 1
                checkButton.Margin = New Padding(5, 8, 5, 8)
                'checkButton.Padding = New Padding(2)




                'adding to panel
                panel.Controls.Add(checkButton)


            Next


        End Sub


    End Class
End NameSpace