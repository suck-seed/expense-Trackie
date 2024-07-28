Public Class Baseform
    Inherits Form

    Public Sub New()
        InitializeComponent()
        SetDefaultFont(Me.Controls)
    End Sub

    Private Sub SetDefaultFont(controls As Control.ControlCollection)
        For Each control As Control In controls
            control.Font = New Font("Arial", 12) ' Set your desired font family and size
            If control.HasChildren Then
                SetDefaultFont(control.Controls)
            End If
        Next
    End Sub

    Protected Overrides Sub OnControlAdded(e As ControlEventArgs)
        MyBase.OnControlAdded(e)
        e.Control.Font = New Font("Segoe UI", 12) ' Set your desired font family and size
    End Sub

End Class

