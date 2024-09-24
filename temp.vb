Public Class temp

    '' Increased radius for smoother, more gradual rounding
    'Private borderRadius As Integer = 90

    '' Form Load event to make the form border rounded and smooth
    'Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    '    ' Set the form's border style to None to remove the default border
    '    Me.FormBorderStyle = FormBorderStyle.None

    '    ' Set rounded corners
    '    SetRoundedShape(Me, borderRadius)

    '    ' Apply smoothing mode to improve the appearance
    '    Me.SetStyle(ControlStyles.ResizeRedraw, True)
    '    Me.SetStyle(ControlStyles.OptimizedDoubleBuffer, True)
    'End Sub

    '' Function to apply the rounded shape to the form
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

    '' Handle the Minimize button (optional, in case you need to minimize the form)
    'Private Sub ButtonMinimize_Click(sender As Object, e As EventArgs) Handles ButtonMinimize.Click
    '    Me.WindowState = FormWindowState.Minimized
    'End Sub

    '' Override OnPaint to apply anti-aliasing and make the edges smoother
    'Protected Overrides Sub OnPaint(e As PaintEventArgs)
    '    MyBase.OnPaint(e)

    '    ' Enable anti-aliasing for smoother edges
    '    e.Graphics.SmoothingMode = SmoothingMode.AntiAlias

    '    ' You can add additional painting code here for custom effects if needed
    'End Sub

End Class