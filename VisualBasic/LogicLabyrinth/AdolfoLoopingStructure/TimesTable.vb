Public Class TimesTable
    Private Sub gen_Click(sender As Object, e As EventArgs) Handles gen.Click
        ListBox1.Items.Clear()

        If Integer.TryParse(inBox.Text, Nothing) Then
            Dim number As Integer = Integer.Parse(inBox.Text)

            For i As Integer = 1 To 12
                Dim result As Integer = number * i
                ListBox1.Items.Add($"{number} x {i} = {result}")
            Next
        Else
            ListBox1.Items.Add("Please enter a valid number.")
        End If
    End Sub

    Private Sub LayerLoopingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LayerLoopingToolStripMenuItem.Click
        Me.Hide()
        PyramidStructure.Show()
    End Sub

    Private Sub FibonacciSequenceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FibonacciSequenceToolStripMenuItem.Click
        Me.Hide()
        FibonacciSequence.Show()
    End Sub
End Class
