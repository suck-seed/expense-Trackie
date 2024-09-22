Public Class monthExpense

    Dim _day As String

    Public Sub New(ByVal day As String)

        ' This call is required by the designer.
        InitializeComponent()
        _day = day
        lbl_day.Text = day


        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub monthDate_Load(sender As Object, e As EventArgs) Handles Me.Load

    End Sub


End Class
