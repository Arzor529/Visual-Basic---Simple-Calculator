Public Class Form1
    Private Sub getResult(num1 As Decimal, num2 As Decimal, strOperator As String)

        Dim strResult As String = ""

        Try
            If strOperator = "+" Then
                strResult = CStr(num1 + num2)
            ElseIf strOperator = "-" Then
                strResult = CStr(num1 - num2)
            ElseIf strOperator = "*" Then
                strResult = CStr(num1 * num2)
            ElseIf strOperator = "/" Then
                strResult = CStr(num1 / num2)
            End If
        Catch ex As System.DivideByZeroException
            MessageBox.Show("Cannot divide by 0", "error")
        End Try

        txtResult.Text = strResult

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            Dim val1 As Decimal = txtVal1.Text
            Dim val2 As Decimal = txtVal2.Text
            getResult(val1, val2, "+")
        Catch ex As System.InvalidCastException
            MessageBox.Show("Please fill in both boxes and enter only numbers", "Error")
        End Try
    End Sub

    Private Sub btnMinus_Click(sender As Object, e As EventArgs) Handles btnMinus.Click
        Try
            Dim val1 As Decimal = txtVal1.Text
            Dim val2 As Decimal = txtVal2.Text
            getResult(val1, val2, "-")
        Catch ex As System.InvalidCastException
            MessageBox.Show("Please fill in both boxes and enter only numbers", "Error")
        End Try
    End Sub

    Private Sub btnMultiply_Click(sender As Object, e As EventArgs) Handles btnMultiply.Click
        Try
            Dim val1 As Decimal = txtVal1.Text
            Dim val2 As Decimal = txtVal2.Text
            getResult(val1, val2, "*")
        Catch ex As System.InvalidCastException
            MessageBox.Show("Please fill in both boxes and enter only numbers", "Error")
        End Try
    End Sub

    Private Sub btnDivide_Click(sender As Object, e As EventArgs) Handles btnDivide.Click
        Try
            Dim val1 As Decimal = txtVal1.Text
            Dim val2 As Decimal = txtVal2.Text
            getResult(val1, val2, "/")
        Catch ex As System.InvalidCastException
            MessageBox.Show("Please fill in both boxes and enter only numbers", "Error")
        End Try
    End Sub
End Class


