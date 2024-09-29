Imports System.Drawing.Drawing2D
Imports expense_Trackie.Presentation

Public Class passUpdatedSplashScreen

    Private borderRadius As Integer = 60

    Private Sub passUpdatedSplashScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()

        SetRoundedShape(Me, borderRadius)
        Me.SetStyle(ControlStyles.ResizeRedraw, True)
        Me.SetStyle(ControlStyles.OptimizedDoubleBuffer, True)
    End Sub

    Private Sub SetRoundedShape(ctrl As Control, radius As Integer)
        Dim rPath As New GraphicsPath()

        ' Create rounded corners with arcs and straight lines
        rPath.StartFigure()
        rPath.AddArc(New Rectangle(0, 0, radius, radius), 180, 90)  ' Top-left corner
        rPath.AddArc(New Rectangle(ctrl.Width - radius, 0, radius, radius), -90, 90)  ' Top-right corner
        rPath.AddArc(New Rectangle(ctrl.Width - radius, ctrl.Height - radius, radius, radius), 0, 90)  ' Bottom-right corner
        rPath.AddArc(New Rectangle(0, ctrl.Height - radius, radius, radius), 90, 90)  ' Bottom-left corner
        rPath.CloseFigure()

        ' Apply the smooth path to the form's region
        ctrl.Region = New Region(rPath)
    End Sub

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        MyBase.OnPaint(e)
        e.Graphics.SmoothingMode = SmoothingMode.AntiAlias
    End Sub



#Region "ToShowAnotherForm"
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        SignIn.Show()
        Me.Close()
    End Sub
#End Region

End Class