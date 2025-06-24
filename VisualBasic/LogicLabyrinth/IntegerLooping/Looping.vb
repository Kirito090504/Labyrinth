Public Class Looping

    Private Sub findNumbersButton_Click(sender As Object, e As EventArgs) Handles findNumbersButton.Click

        Dim start As Integer
        Dim [end] As Integer

        If Integer.TryParse(firstinteger.Text, start) AndAlso Integer.TryParse(secondinteger.Text, [end]) Then
            If start <= [end] Then
                For i As Integer = start To [end]
                    If i Mod 2 = 0 Then
                        evenListBox.Items.Add(i)
                    Else
                        oddListBox.Items.Add(i)
                    End If
                Next
            Else
                MessageBox.Show("Start number should be less than or equal to end number.")
            End If
        Else
            MessageBox.Show("Please enter valid integer values for both start and end.")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        oddListBox.Items.Clear()
        evenListBox.Items.Clear()
        firstinteger.Clear()
        secondinteger.Clear()
    End Sub


End Class
