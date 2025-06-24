Public Class CandyBill
    Private zkg As Double

    Private Sub BttnCompute_Click(sender As Object, e As EventArgs) Handles BttnCompute.Click
        'variable declartion
        Dim zkg As Double
        Dim xkg As Double
        Dim vkg As Double
        Dim nkg As Double
        Dim TotalA As Double
        Dim TotalB As Double
        Dim TotalC As Double
        Dim TotalD As Double
        Dim totalAmount

        Double.TryParse(AKG.Value, zkg)
        TotalA = zkg * 42.25
        inCA.Text = ("₱" & TotalA)

        Double.TryParse(BKG.Value, xkg)
        TotalB = xkg * 36.75
        inCB.Text = ("₱" & TotalB)

        Double.TryParse(CKG.Value, vkg)
        TotalC = vkg * 48.0
        inCC.Text = ("₱" & TotalC)

        Double.TryParse(DKG.Value, nkg)
        TotalD = nkg * 29.5
        inCD.Text = ("₱" & TotalD)

        totalAmount = TotalA + TotalB + TotalC + TotalD

        Total.Text = "₱" + Convert.ToString(totalAmount)
    End Sub

End Class
