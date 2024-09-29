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



        If My.Settings.IsLightMode = False Then
            ForeColor = Color.White
            Me.BackColor = ColorTranslator.FromHtml(My.Settings.darkPanelColor)
            tpanelDate.BackColor = ColorTranslator.FromHtml(My.Settings.darkPanelColor)
            tpanel_expense.BackColor = ColorTranslator.FromHtml(My.Settings.darkPanelColor)
            lbl_day.BackColor = ColorTranslator.FromHtml(My.Settings.darkPanelColor)



        Else
            Me.BackColor = ColorTranslator.FromHtml(My.Settings.lightPanelColor)
            tpanelDate.BackColor = ColorTranslator.FromHtml(My.Settings.lightPanelColor)
            tpanel_expense.BackColor = ColorTranslator.FromHtml(My.Settings.lightPanelColor)
            lbl_day.BackColor = ColorTranslator.FromHtml(My.Settings.lightPanelColor)
        End If


    End Sub


    Protected Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ExStyle = cp.ExStyle Or &H2000000
            Return cp
        End Get
    End Property



End Class
