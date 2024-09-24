Imports expense_Trackie.Application
Imports expense_Trackie.Presentation

Module Ui

    Sub ClearInputFields()

        ' new category
        NewCategory.txt_description.Text = ""
        NewCategory.txt_name.Text = ""

        'update category


        'new expense


        ' signup
        SignUp.txt_number.Text = ""
        SignUp.txt_password.Text = ""
        SignUp.txt_username.Text = ""


        ' sign in
        SignIn.txt_password.Text = ""
        SignIn.txt_username.Text = ""




    End Sub


    Sub ClearSessionInfo()

        SessionManager.Instance.CurrentUserId = 0
        SessionManager.Instance.CurrentUsername = ""
        SessionManager.Instance.CurrentPassword = ""
        SessionManager.Instance.CurrentNumber = ""
        SessionManager.Instance.CurrentDailyLimit = 0
        SessionManager.Instance.CurrentProfileLink = ""

    End Sub


    Sub ClearSavedInfo()
        My.Settings.SavedPassword = ""
        My.Settings.SavedUsername = ""
        My.Settings.Save()
    End Sub


End Module
