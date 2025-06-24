Public Class SalaryCalculator
    Private Sub calculateButton_Click(sender As Object, e As EventArgs) Handles calculateButton.Click
        Dim daysWorked As Integer

        If Integer.TryParse(daysTextBox.Text, daysWorked) Then
            ' Calculate earnings based on the formula
            Dim earnings As Double = CalculateEarnings(daysWorked)

            ' Display the result in the label
            resultLabel.Text = $"Earnings after {daysWorked} days: {earnings:C}"
        Else
            MessageBox.Show("Please enter a valid number of days.")
        End If
    End Sub

    Private Function CalculateEarnings(daysWorked As Integer) As Double
        Dim baseAmount As Double = 100 ' Initial earning on the first day
        Dim totalEarnings As Double = baseAmount

        For day As Integer = 2 To daysWorked
            baseAmount *= 2 ' Double the base amount each day
            totalEarnings += baseAmount ' Add to the total earnings
        Next

        Return totalEarnings
    End Function
End Class
