Public Class YearLevelAssignment
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Year As Double

        Double.TryParse(inYear.Text, Year)

        Select Case Year
            Case = 1
                outYear.Text = "Freshman"
            Case = 2
                outYear.Text = "Sophomore"
            Case = 3
                outYear.Text = "Junior2"
            Case = 4
                outYear.Text = "Senior"
            Case Else
                outYear.Text = "Invalid Entry"
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

    Private Sub CommissionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CommissionToolStripMenuItem.Click
        Commission.Show()
        Me.Hide()
    End Sub
End Class