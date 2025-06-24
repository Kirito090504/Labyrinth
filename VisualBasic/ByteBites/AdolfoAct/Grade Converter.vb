Public Class GradeConverter

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Grade As Double

        Double.TryParse(inGrade.Text, Grade)

        Select Case Grade
            Case 90 To 100
                outGrade.Text = "1.00"
            Case 80 To 89
                outGrade.Text = "2.00"
            Case 70 To 79
                outGrade.Text = "3.00"
            Case 60 To 69
                outGrade.Text = "4.00"
            Case Is <= 60
                outGrade.Text = "5.00"
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

    Private Sub YearLevelToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles YearLevelToolStripMenuItem.Click
        YearLevelAssignment.Show()
        Me.Hide()
    End Sub

    Private Sub CommissionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CommissionToolStripMenuItem.Click
        Commission.Show()
        Me.Hide()
    End Sub
End Class