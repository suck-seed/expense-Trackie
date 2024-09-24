Public Class monthDate


    Dim _day, _date, _weekday As String

    ' while we create new instance of this
    Public Sub New(ByVal day As String)

        ' This call is required by the designer.
        InitializeComponent()
        _day = day
        lbl_date.Text = day


        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub monthDate_Load(sender As Object, e As EventArgs) Handles Me.Load

    End Sub
End Class
