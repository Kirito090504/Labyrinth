Public Class Form1
    Private Sub calc_Click(sender As Object, e As EventArgs) Handles calc.Click

        If Double.TryParse(depo.Text, Nothing) AndAlso Double.TryParse(anrate.Text, Nothing) Then

            Dim initialDeposit As Double = Double.Parse(depo.Text)
            Dim annualInterestRate As Double = Double.Parse(anrate.Text) / 100

            Dim accountBalance As Double = CalculateCompoundInterest(initialDeposit, annualInterestRate, 3)

            bal.Text = accountBalance.ToString("C2")
        Else
            MessageBox.Show("Please enter valid values for Initial Deposit and Annual Interest Rate.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub
    Private Function CalculateCompoundInterest(principal As Double, rate As Double, years As Integer) As Double
        Dim compoundInterest As Double = principal * Math.Pow((1 + rate), years)
        Return compoundInterest
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        depo.Text = ""
        anrate.Text = ""
        bal.Text = ""
    End Sub
End Class
