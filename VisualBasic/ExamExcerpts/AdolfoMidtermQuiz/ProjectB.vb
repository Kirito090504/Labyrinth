Public Class ProjectB
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Double.TryParse(inputfeet.Text, Nothing) Then
            Dim feet As Double = CDbl(inputfeet.Text)
            Dim yards As Double = feet / 3.0
            Dim inches As Double = feet * 12.0
            Dim centimeters As Double = inches * 2.54
            Dim meters As Double = centimeters / 100.0

            byards.Text = yards.ToString("F2") & " yards"
            binches.Text = inches.ToString("F2") & " inches"
            bcm.Text = centimeters.ToString("F2") & " centimeters"
            bm.Text = meters.ToString("F2") & " meters"
        Else
            MessageBox.Show("Invalid input. Please enter a valid number of feet.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        inputfeet.Clear()
        byards.Text = ""
        binches.Text = ""
        bcm.Text = ""
        bm.Text = ""
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Hide()
        ProjectA.Show()
    End Sub
End Class