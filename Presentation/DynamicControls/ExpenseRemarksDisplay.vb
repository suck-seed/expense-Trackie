Imports System.Drawing.Drawing2D

Public Class ExpenseRemarksDisplay

    Private borderRadius As Integer = 12

    Private Sub ExpenseDetailDisplay_Load(sender As Object, e As EventArgs) Handles Me.Load

        Me.BorderStyle = BorderStyle.None
        SetRoundedShape(Me, borderRadius)
        Me.SetStyle(ControlStyles.ResizeRedraw, True)
        Me.SetStyle(ControlStyles.OptimizedDoubleBuffer, True)

    End Sub


    Private Sub SetRoundedShape(ctrl As Control, radius As Integer)
        Dim rPath As New GraphicsPath()

        ' Create a new rectangle that exactly fits the control's size
        Dim rect As New Rectangle(0, 0, ctrl.Width, ctrl.Height)

        ' Create rounded corners with arcs and straight lines
        rPath.AddArc(New Rectangle(rect.X, rect.Y, radius, radius), 180, 90) ' Top-left corner
        rPath.AddArc(New Rectangle(rect.Width - radius, rect.Y, radius, radius), -90, 90) ' Top-right corner
        rPath.AddArc(New Rectangle(rect.Width - radius, rect.Height - radius, radius, radius), 0, 90) ' Bottom-right corner
        rPath.AddArc(New Rectangle(rect.X, rect.Height - radius, radius, radius), 90, 90) ' Bottom-left corner
        rPath.CloseFigure()

        ' Apply the smooth path to the control's region
        ctrl.Region = New Region(rPath)
    End Sub

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        MyBase.OnPaint(e)

        ' Enable anti-aliasing for smoother edges
        e.Graphics.SmoothingMode = SmoothingMode.AntiAlias

        ' You can add additional painting code here for custom effects if needed
    End Sub


    Private Sub ExpenseDetailDisplay_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        SetRoundedShape(Me, borderRadius)
    End Sub


End Class
