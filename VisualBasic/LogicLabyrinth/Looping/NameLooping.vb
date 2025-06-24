Public Class NameLooping
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim numberOfTimes As Integer

        If Integer.TryParse(times.Text, numberOfTimes) AndAlso numberOfTimes > 0 Then
            namelist.Items.Clear()

            Dim name As String = firstname.Text.Trim()

            For i As Integer = 1 To numberOfTimes
                namelist.Items.Add(name)
            Next
        Else
            MessageBox.Show("Please enter a valid amount", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        HighestInteger.Show()
    End Sub
End Class
