Imports System.Configuration
Imports expense_Trackie.Application

Public Class CompareView


    Private loggedInUserId As Integer = SessionManager.Instance.CurrentUserId
    ReadOnly _connectionString As String = ConfigurationManager.ConnectionStrings("expenseTrackie").ConnectionString
    Dim _darkMode As Boolean = False


    Dim dateRight As Date
    Dim dateLeft As Date

#Region " month / year "

    'Public Sub monthSelected(sender As Object, e As EventArgs) Handles 
    Public Sub New(ByVal dateLeftParam As Date, ByVal dateRightParam As Date)

        InitializeComponent()
        'MessageBox.Show("isYearly :" & isYearly & "  isMonthly :" & isMonthly)

        dateLeft = dateLeftParam
        dateRight = dateRightParam






    End Sub

#End Region


End Class
