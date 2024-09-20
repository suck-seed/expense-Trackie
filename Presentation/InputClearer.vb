Imports expense_Trackie.Presentation

Module Ui

    Sub ClearInputFields()

        ' new category
        NewCategory.txt_description.Text = ""
        NewCategory.txt_name.Text = ""

        'new expense


        ' signup
        SignUp.txt_number.Text = ""
        SignUp.txt_password.Text = ""
        SignUp.txt_username.Text = ""


        ' sign in
        SignIn.txt_password.Text = ""
        SignIn.txt_username.Text = ""




    End Sub


    Sub LoadDefaultColor(ByRef panel As TableLayoutPanel, ByRef handler As EventHandler)

        Dim colorList As New List(Of String) From {
    "#d97373",  ' Light Red
    "#cdc2a5",  ' Beige
    "#6a9c89",  ' Teal Green
    "#8eaccd",  ' Light Blue
    "#ced4da",  ' Light Gray
    "#f7b5ca",  ' Light Pink
    "#bb9ab1",  ' Pale Violet
    "#b4b4b8",  ' Gray
    "#e2bfa7"   ' Peach
}


        panel.Controls.Clear()


        For i As Integer = 0 To colorList.Count - 1

            Dim rb As New RadioButton

            rb.Appearance = Appearance.Button
            rb.Dock = DockStyle.Fill
            rb.BackColor = ColorTranslator.FromHtml(colorList(i))

            rb.Tag = colorList(i)


            ' handler
            AddHandler rb.CheckedChanged, handler

            panel.Controls.Add(rb, i, 0)

        Next

    End Sub

End Module
