Imports System.Drawing.Drawing2D

Public Class New_Expense

    'variable aight
    Dim amount As Decimal
    Dim remarks As String
    Dim dateAdded As DateTime
    Dim dateJoined As DateTime = DateTime.Now.ToString("yyyy-MM-dd")




    ' CREATE
    Private Sub button_create_Click(sender As Object, e As EventArgs) Handles button_create.Click

        amount = CDec(txt_Amount.Text)
        remarks = txt_Remarks.Text
        dateAdded = txt_date_picker.Value.ToString("yyyy-MM-dd")


        MsgBox(amount)
        MsgBox(remarks)
        MsgBox(dateAdded)




    End Sub






    ' CLOSE
    Private Sub button_close_Click(sender As Object, e As EventArgs) Handles button_close.Click
        Me.Close()
    End Sub




    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub






    ' TOPBAR MOVEMENT
    Dim mouse_move As System.Drawing.Point

    Private Sub topbar_MouseDown(sender As Object, e As MouseEventArgs) Handles panel_topbar.MouseDown
        mouse_move = New Point(-e.X, -e.Y)
    End Sub

    Private Sub topbar_MouseMove(sender As Object, e As MouseEventArgs) Handles panel_topbar.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Dim mouse_position As Point
            mouse_position = Control.MousePosition
            mouse_position.Offset(mouse_move.X, mouse_move.Y)
            Me.Location = mouse_position
        End If
    End Sub



    ' GRADIENT
    Private Sub Form1_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
        ' Get the client area of the form
        Dim rect As New Rectangle(0, 0, Me.ClientSize.Width, Me.ClientSize.Height)

        ' Define the start and end colors for the gradient
        Dim startColor As Color = Color.Beige
        Dim endColor As Color = Color.AliceBlue

        ' Create a LinearGradientBrush
        Using brush As New LinearGradientBrush(rect, startColor, endColor, LinearGradientMode.Horizontal)
            ' Fill the rectangle with the gradient
            e.Graphics.FillRectangle(brush, rect)
        End Using
    End Sub


End Class