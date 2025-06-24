Public Class Commission
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Sale As Double
        Dim Result As Double

        Double.TryParse(inSale.Text, Sale)

        Select Case Sale
            Case 0 To 30000
                Result = Sale * 0.02
                outSale.Text = "₱" & Result.ToString
            Case 30001 To 60000
                Result = Sale * 0.03
                outSale.Text = "₱" & Result.ToString
            Case 60001 To 90000
                Result = Sale * 0.04
                outSale.Text = "₱" & Result.ToString
            Case 90001 To 120000
                Result = Sale * 0.06
                outSale.Text = "₱" & Result.ToString
            Case 120001 To 150000
                Result = Sale * 0.08
                outSale.Text = "₱" & Result.ToString
            Case > 150_000
                Result = Sale * 0.1
                outSale.Text = "₱" & Result.ToString
        End Select
    End Sub

    Private Sub MonthDisplayToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MonthDisplayToolStripMenuItem.Click
        MonthDisplay.Show()
        Me.Hide()
    End Sub

    Private Sub TollGateChargeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TollGateChargeToolStripMenuItem.Click
        TollGateCharge.Show()
        Me.Hide()
    End Sub

    Private Sub GradeConverterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GradeConverterToolStripMenuItem.Click
        GradeConverter.Show()
        Me.Hide()
    End Sub

    Private Sub YearLevelToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles YearLevelToolStripMenuItem.Click
        YearLevelAssignment.Show()
        Me.Hide()
    End Sub
End Class