Imports System.Drawing.Drawing2D

Public Class New_Expense

    'variable aight
    Dim _amount As Double = 0
    Dim _remarks As String
    Dim _group As String
    Private _categories As List(Of String)


    Dim mouse_move As System.Drawing.Point

    ' CREATE
    Private Sub button_create_Click(sender As Object, e As EventArgs) Handles button_create.Click
        _remarks = txt_Remarks.Text.ToString()
        'group = cmb_Group.SelectedValue

        If Double.TryParse(txt_Amount.Text, _amount) Then
            _amount = CDbl(txt_Amount.Text())
        Else
            Const message As String = "Amount should be in Numeric Form"
            MessageBox.Show(message)
        End If

        'Insert this info to the database
        insert_to_db()

    End Sub

    ' CLOSE
    Private Sub button_close_Click(sender As Object, e As EventArgs) Handles button_close.Click
        Me.Close()
    End Sub





    Private Sub insert_to_db()

    End Sub

    Private Sub New_Expense_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub





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