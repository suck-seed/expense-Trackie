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





    ''rounding
    'Private borderRadius As Integer = 31

    'Private Sub monthDate_Load(sender As Object, e As EventArgs) Handles Me.Load


    '    SetRoundedShape(Me, borderRadius)
    '    Me.SetStyle(ControlStyles.ResizeRedraw, True)
    '    Me.SetStyle(ControlStyles.OptimizedDoubleBuffer, True)
    'End Sub


    'Private Sub SetRoundedShape(ctrl As Control, radius As Integer)
    '    Dim rPath As New GraphicsPath()

    '    ' Create rounded corners with arcs and straight lines
    '    rPath.StartFigure()
    '    rPath.AddArc(New Rectangle(0, 0, radius, radius), 180, 90)  ' Top-left corner
    '    rPath.AddArc(New Rectangle(ctrl.Width - radius, 0, radius, radius), -90, 90)  ' Top-right corner
    '    rPath.AddArc(New Rectangle(ctrl.Width - radius, ctrl.Height - radius, radius, radius), 0, 90)  ' Bottom-right corner
    '    rPath.AddArc(New Rectangle(0, ctrl.Height - radius, radius, radius), 90, 90)  ' Bottom-left corner
    '    rPath.CloseFigure()

    '    ' Apply the smooth path to the form's region
    '    ctrl.Region = New Region(rPath)
    'End Sub


    'Protected Overrides Sub OnPaint(e As PaintEventArgs)
    '    MyBase.OnPaint(e)

    '    ' Enable anti-aliasing for smoother edges
    '    e.Graphics.SmoothingMode = SmoothingMode.AntiAlias

    '    ' You can add additional painting code here for custom effects if needed
    'End Sub

End Class
