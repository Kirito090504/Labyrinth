Public Class HighestInteger
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim integersList As New List(Of Integer)

        For i As Integer = 1 To 10
            Dim input As String = InputBox("Enter Integer " & i & ":", "Input")
            Dim value As Integer

            If Integer.TryParse(input, value) Then
                integersList.Add(value)
                integerlistbox.Items.Add(value)
            Else
                MessageBox.Show("Invalid input. Please enter a valid integer.")
                Exit Sub
            End If
        Next

        ' Find the highest integer
        Dim highest As Integer = integersList.Max()
        LHI.Text = "Highest Integer: " & highest.ToString()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        NameLooping.Show()
    End Sub
End Class