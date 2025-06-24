Public Class ProjectA

    Dim qua As Double
    Dim pou As Double
    Dim fc As Double
    Dim disc As Double
    Dim bill As Double

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Double.TryParse(quantity.Text, qua)
        Double.TryParse(priceofunit.Text, pou)

        Select Case qua
            Case 1 To 10
                fc = qua * pou
                fullcost.Text = fc.ToString("C2")
                disc = fc * 0.01
                discount.Text = disc.ToString("C2")
                bill = fc - disc
                totalbill.Text = bill.ToString("C2")
            Case 11 To 100
                fc = qua * pou
                fullcost.Text = fc.ToString("C2")
                disc = fc * 0.08
                discount.Text = disc.ToString("C2")
                bill = fc - disc
                totalbill.Text = bill.ToString("C2")
            Case >= 100
                fc = qua * pou
                fullcost.Text = fc.ToString("C2")
                disc = fc * 0.1
                discount.Text = disc.ToString("C2")
                bill = fc - disc
                totalbill.Text = bill.ToString("C2")
        End Select

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        ProjectB.Show()
    End Sub
End Class
