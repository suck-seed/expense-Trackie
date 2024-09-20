Imports System.Drawing.Drawing2D
Imports expense_Trackie.Application

Namespace Presentation

    Public Class UpdateCategory

        Dim _catName As String
        Dim _catDescription As String
        Dim _catColor As String


        Dim selectedId As Integer
        Dim selectedName As String
        Dim selectedDescription As String
        Dim selectedColor As String


        Dim nameChanged As Boolean = False
        Dim descriptionChanged As Boolean = False
        Dim colorChanged As Boolean = False

#Region " New( dayView ) "

        Dim _dayView As DayView
        Dim _monthView As MonthView

        Public Sub New(ByRef dayViewInst As DayView, ByRef monthViewInst As MonthView)

            ' This call is required by the designer.
            InitializeComponent()

            _dayView = dayViewInst
            _monthView = monthViewInst

            ' Add any initialization after the InitializeComponent() call.

        End Sub

#End Region



#Region " on load "

        Private Sub UpdateCategory_Load(sender As Object, e As EventArgs) Handles MyBase.Load

            'generating category on panel
            Dim categoryManager As New CategoryManager()
            categoryManager.GenerateCategoryRadioButtons(panel_radio_category, AddressOf LoadCategoryInfo)


            LoadDefaultColor(panel_color, AddressOf ColorIdDefaultColor)


        End Sub

#End Region


#Region " category selected, load info on input box "


        Public Sub LoadCategoryInfo()

            For Each control In panel_radio_category.Controls

                If TypeOf control Is RadioButton Then

                    Dim radioButton As RadioButton = DirectCast(control, RadioButton)

                    If radioButton.Checked Then

                        ' storing selected category id
                        selectedName = radioButton.Text.ToString
                        selectedDescription = radioButton.AccessibleDescription.ToString
                        selectedColor = ColorTranslator.ToHtml(radioButton.BackColor)
                        selectedId = radioButton.Tag

                        ' displaying in input box
                        txt_name.Text = selectedName
                        txt_description.Text = selectedDescription




                        ' checking the colors
                        For Each ctrl In panel_color.Controls


                            If TypeOf ctrl Is RadioButton Then

                                Dim radioButton1 As RadioButton = DirectCast(ctrl, RadioButton)

                                Dim radioBackColor As String = ColorTranslator.ToHtml(radioButton1.BackColor)

                                If radioBackColor = selectedColor Then

                                    radioButton1.Checked = True
                                    Return
                                Else
                                    btn_custom_color.BackColor = ColorTranslator.FromHtml(selectedColor)
                                End If

                            End If


                        Next


                    End If

                End If

            Next

        End Sub

#End Region


#Region " main functionality "

        Private Sub button_create_Click(sender As Object, e As EventArgs) Handles button_create.Click

            ' is color changed
            If _catColor <> selectedColor Then
                colorChanged = True
            End If


            ' fool proffing
            If String.IsNullOrEmpty(txt_name.Text) Or String.IsNullOrEmpty(txt_description.Text) Or String.IsNullOrEmpty(_catColor) Then
                MsgBox("Please fill all the information.")
                Return
            End If



            ' is information even changed

            If Not nameChanged And Not descriptionChanged And Not colorChanged Then

                MsgBox("Please change atleast one information")
                Return
            End If




            ' everything passed, assigning inform
            _catName = txt_name.Text
            _catDescription = txt_description.Text
            ' _catColor assigned
            ' selectedId as id


            Dim categoryManager As New CategoryManager()

            If categoryManager.UpdateCategory(_catName, _catDescription, _catColor, selectedId) > 0 Then

                ' updating display information
                categoryManager.GenerateCategoryRadioButtons(panel_radio_category, AddressOf LoadCategoryInfo)

                MainWindow.LoadInformation()
                _dayView.UpdateDisplayInformation()



                ' updated !!
                MsgBox(" Category update ! ")

            Else

                MsgBox(" Failed updating category information ")

            End If






        End Sub


#End Region


#Region " color selection "

        Private Sub ColorIdDefaultColor()

            For Each control As Control In panel_color.Controls

                If TypeOf control Is RadioButton Then

                    Dim rb As RadioButton = DirectCast(control, RadioButton)

                    If rb.Checked Then


                        _catColor = ColorTranslator.ToHtml(rb.BackColor)
                        btn_custom_color.BackColor = SystemColors.ButtonFace

                    End If


                End If

            Next

        End Sub


        Private Sub btn_custom_color_Click(sender As Object, e As EventArgs) Handles btn_custom_color.Click


            ' unchecking default color
            For Each control As Control In panel_color.Controls

                If TypeOf control Is RadioButton Then

                    Dim rb As RadioButton = DirectCast(control, RadioButton)

                    rb.Checked = False

                End If

            Next



            ' setting custom color
            Dim cd As New ColorDialog()


            If cd.ShowDialog() = DialogResult.OK Then

                btn_custom_color.BackColor = cd.Color

                If cd.Color.IsNamedColor Then


                    ' if known color, using string format to convert to #
                    Dim color As Color = cd.Color
                    _catColor = String.Format("#{0:X2}{1:X2}{2:X2}", color.R, color.G, color.B)


                Else


                    ' if custom color, then using toHtml to convert to #
                    _catColor = ColorTranslator.ToHtml(cd.Color)


                End If

            End If

            MsgBox("Custom color :" & _catColor)



        End Sub



#End Region


#Region " is information changed? "

        Private Sub txt_name_TextChanged(sender As Object, e As EventArgs) Handles txt_name.TextChanged

            'If txt_name.Text = selectedName Then
            '    nameChanged = False
            'Else
            '    nameChanged = True
            'End If

            If txt_name.Text <> selectedName Then
                nameChanged = True
            End If

        End Sub

        Private Sub txt_description_TextChanged(sender As Object, e As EventArgs) Handles txt_description.TextChanged

            'If txt_description.Text = selectedDescription Then
            '    descriptionChanged = False
            'Else
            '    descriptionChanged = True
            'End If

            If txt_description.Text <> selectedDescription Then
                descriptionChanged = True
            End If

        End Sub


#End Region


#Region " gradient "

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

        Private Sub button_close_Click(sender As Object, e As EventArgs) Handles button_close.Click
            Me.Close()
        End Sub







#End Region



    End Class
End Namespace