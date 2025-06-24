Public Class TollGateCharge
    Private TBill As Double
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Car.Checked = True Then
            If yellow.Checked = True Then
                TBill = 10 * 20
                total_bill.Text = TBill.ToString("C2")
            ElseIf blue.Checked = True Then
                TBill = 10 * 25
                total_bill.Text = TBill.ToString("C2")
            ElseIf red.Checked = True Then
                TBill = 10 * 30
                total_bill.Text = TBill.ToString("C2")
            End If
        ElseIf LightTruck.Checked = True Then
            If yellow.Checked = True Then
                TBill = 15 * 20
                total_bill.Text = TBill.ToString("C2")
            ElseIf blue.Checked = True Then
                TBill = 15 * 25
                total_bill.Text = TBill.ToString("C2")
            ElseIf red.Checked = True Then
                TBill = 15 * 30
                total_bill.Text = TBill.ToString("C2")
            End If
        ElseIf Bus.Checked = True Then
            If yellow.Checked = True Then
                TBill = 25 * 20
                total_bill.Text = TBill.ToString("C2")
            ElseIf blue.Checked = True Then
                TBill = 25 * 25
                total_bill.Text = TBill.ToString("C2")
            ElseIf red.Checked = True Then
                TBill = 25 * 30
                total_bill.Text = TBill.ToString("C2")
            End If
        End If
    End Sub

    Private Sub MonthDisplayToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MonthDisplayToolStripMenuItem.Click
        MonthDisplay.Show()
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

    Private Sub CommissionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CommissionToolStripMenuItem.Click
        Commission.Show()
        Me.Hide()
    End Sub
End Class