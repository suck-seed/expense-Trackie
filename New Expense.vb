Public Class New_Expense

    'variable aight
    Dim amount As Double = 0
    Dim remarks As String
    Dim group As String
    Private categories As List(Of String)


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        remarks = txt_Remarks.Text.ToString()
        group = cmb_group.SelectedValue

        If Double.TryParse(txt_Amount.Text, amount) Then
            amount = CDbl(txt_Amount.Text())
        Else
            MessageBox.Show("Amount should be in Numeric/Double")
        End If

        'Insert this info to the database
        insert_to_db()




    End Sub


    Sub insert_to_db()

    End Sub

    Private Sub New_Expense_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub


End Class