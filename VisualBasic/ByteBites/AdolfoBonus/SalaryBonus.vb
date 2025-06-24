Public Class SalaryBonus
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim monthlySalary As Double

        If Double.TryParse(Me.monthlySalary.Text, monthlySalary) Then
            Dim bonus As Double

            If monthlySalary < 5000.0 Then
                bonus = monthlySalary * 0.5
            Else
                bonus = 15000.0
            End If

            txtBonus.Text = bonus.ToString("C")
        Else
            MessageBox.Show("Please enter a valid monthly salary.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class
