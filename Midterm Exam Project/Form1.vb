Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        radInchestoMeters.Checked = True
        lblConversion.Visible = False
    End Sub
    Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click
        Dim strInput As String = txtInput.Text
        Dim decInput As Decimal
        Dim decInches As Decimal
        Dim decMeters As Decimal
        Dim decConversion As Decimal = 0D

        Dim strPositiveMsgBox As String = "Enter a positive number"
        Dim strNegativeMsgBox As String = "The measurement must be greater than zero"
        Dim strTitleMsgBox As String = "Input Error"

        If IsNumeric(strInput) Then
            decInput = Convert.ToDecimal(strInput)
            If decInput < 0 Then
                MessageBox.Show(strNegativeMsgBox, strTitleMsgBox)
            Else
                lblConversion.Visible = True
            End If
        Else
            MessageBox.Show(strPositiveMsgBox, strTitleMsgBox)
        End If

        If radInchestoMeters.Checked = True Then
            decConversion = decInput * 0.0254
            lblConversion.Text = decInput.ToString("F3") & " inches is " & decConversion.ToString("F3") & " meters."
        End If
        If radMeterstoInches.Checked = True Then
            decConversion = decInput * 39.370079
            lblConversion.Text = decInput.ToString("F3") & " meters is " & decConversion.ToString("F3") & " inches."
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtInput.Clear()
        txtInput.Focus()
        lblConversion.Text = ""
        radInchestoMeters.Checked = True


    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub


End Class
