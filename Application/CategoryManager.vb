Imports expense_Trackie.DataLayer
Imports expense_Trackie.Presentation

Namespace Application
    Public Class CategoryManager

        '        instance of CategoryRepository()    
        Private _categoryrepository As New CategoryRepository()


#Region " register category "

        '        for adding category
        Public Function RegisterCategory(ByRef catName As String, ByRef catDescription As String, ByRef catColor As String) As Integer


            '            checking is category already exists
            If _categoryrepository.IsDuplicateCategory(catName) Then
                NewCategory.lbl_info.ForeColor = Color.Red
                NewCategory.lbl_info.Text = "A category with provided name already exists"
                Return -1
            End If


            '            proceeding with adding category
            Dim added As Integer = _categoryrepository.AddCategory(catName, catDescription, catColor)
            Return added


        End Function

#End Region


#Region " delete category "


        Public Function DeleteCategory(ByRef categoryId As Integer) As Integer

            If _categoryrepository.DeleteUserCategory(categoryId) > 0 Then
                Return 1
            Else
                Return -1
            End If

            '            Return -1

        End Function

#End Region


#Region " update category "

        Public Function UpdateCategory(ByVal catName As String, ByVal catDescription As String, ByVal catColor As String, ByVal selectedId As Integer) As Integer



            If _categoryrepository.IsDuplicateCategory(catName) And _categoryrepository.GetCategoryId(catName) <> selectedId Then

                MsgBox(" Category with provided name already exist !")
                Return -1
            End If



            If _categoryrepository.UpdateCategoryInformation(catName, catDescription, catColor, selectedId) > 0 Then

                Return 1

            Else
                Return -1
            End If


        End Function

#End Region

#Region " generate category : radio "

        '        for loading category 
        Public Sub GenerateCategoryRadioButtons(ByVal panel As FlowLayoutPanel, handler As Action(Of Integer))

            '            loading a dataTable
            Dim categoryTable As DataTable = _categoryrepository.GetUserCategory()


            '            panel work
            panel.SuspendLayout()
            panel.Controls.Clear()


            For Each row As DataRow In categoryTable.Rows


                '                variable for easy use
                Dim catId As Integer = CInt(row("catId"))
                Dim catName As String = row("catName").ToString
                Dim catDescription As String = row("description")
                Dim colorHex As String = row("color").ToString()
                Dim backColor As Color = ColorTranslator.FromHtml(colorHex)



                '                assigning to radioButton
                Dim radioButton As New RadioButton

                radioButton.Text = catName
                radioButton.Tag = catId
                radioButton.BackColor = backColor
                radioButton.AccessibleDescription = catDescription


                '                button cosmetics
                radioButton.Appearance = Appearance.Button
                radioButton.AutoSize = True
                radioButton.TextAlign = ContentAlignment.MiddleCenter
                radioButton.Font = New Font("Cascadia Mono SemiLight", 10, FontStyle.Regular)
                radioButton.ForeColor = Color.Black

                'radioButton.FlatStyle = FlatStyle.Popup
                radioButton.FlatAppearance.BorderSize = 1
                radioButton.Margin = New Padding(8, 5, 8, 5)



                ' event handler for CheckChanged event
                AddHandler radioButton.CheckedChanged, Sub() handler(radioButton.Tag)


                '                adding to panel
                panel.Controls.Add(radioButton)


            Next

            panel.ResumeLayout()

        End Sub


#End Region



#Region " generate category : check "

        Public Sub GenerateCategoryCheckButtons(ByVal panel As FlowLayoutPanel, handler As EventHandler)

            ' loading a dataTable
            Dim categoryTable As DataTable = _categoryrepository.GetUserCategory()


            'panel work
            panel.SuspendLayout()
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
                checkButton.Font = New Font("IBM Plex Mono", 11, FontStyle.Regular)
                checkButton.ForeColor = Color.Black


                'checkButton.FlatStyle = FlatStyle.Flat

                checkButton.FlatAppearance.BorderSize = 1
                checkButton.Margin = New Padding(5, 8, 5, 8)
                'checkButton.Padding = New Padding(2)



                ' adding handler for checkChanged event
                AddHandler checkButton.CheckedChanged, handler

                'adding to panel
                panel.Controls.Add(checkButton)


            Next

            panel.ResumeLayout(True)

        End Sub

        Public Sub GenerateCategoryCheckButtonsExport(ByVal panel As FlowLayoutPanel, handler As EventHandler)

            ' loading a dataTable
            Dim categoryTable As DataTable = _categoryrepository.GetUserCategory()


            'panel work
            panel.SuspendLayout()
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
                checkButton.Font = New Font("IBM Plex Mono", 11, FontStyle.Regular)
                checkButton.ForeColor = Color.Black


                'checkButton.FlatStyle = FlatStyle.Flat

                checkButton.FlatAppearance.BorderSize = 1
                checkButton.Margin = New Padding(5, 8, 5, 8)
                'checkButton.Padding = New Padding(2)



                ' adding handler for checkChanged event
                AddHandler checkButton.CheckedChanged, handler

                'adding to panel
                panel.Controls.Add(checkButton)


            Next

            panel.ResumeLayout(True)

        End Sub


#End Region



#Region " generate category user control "

        Public Sub GenerateCategoryUserControl(ByRef fpanel As FlowLayoutPanel, ByRef isYearly As Boolean, ByRef isMonthly As Boolean)

            Dim expenseRepo As New ExpenseRepository
            Dim categoryTable As DataTable = expenseRepo.GetExpenseOfCategories(isYearly, isMonthly)


            fpanel.SuspendLayout()
            fpanel.Controls.Clear()

            For Each row As DataRow In categoryTable.Rows


                Dim name As String = row("Categoryname").ToString()
                Dim count As String = row("ExpenseCount").ToString()
                Dim total As String = row("TotalSpent").ToString



                'setting values
                Dim categoryInfo As New CategoryInfo

                categoryInfo.lbl_category_name.Text = name
                categoryInfo.lbl_number.Text = count
                categoryInfo.lbl_amount.Text = total


                'setting baclcolor
                categoryInfo.BackColor = ColorTranslator.FromHtml(row("CategoryColor").ToString())




                'adding into panel
                fpanel.Controls.Add(categoryInfo)

            Next

            fpanel.ResumeLayout(True)

        End Sub

#End Region


    End Class
End NameSpace