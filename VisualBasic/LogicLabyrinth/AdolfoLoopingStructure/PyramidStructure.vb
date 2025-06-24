Public Class PyramidStructure
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ListBox1.Items.Clear()

        If Integer.TryParse(TextBox1.Text, Nothing) Then
            Dim layers As Integer = Integer.Parse(TextBox1.Text)

            For i As Integer = 1 To layers

                Dim asterisks As String = New String("*"c, 2 * i - 1)

                Dim layerText As String = asterisks

                ListBox1.Items.Add(layerText)
            Next
        Else
            ListBox1.Items.Add("Please enter a valid number of layers.")
        End If
    End Sub

    Private Sub TimesTableToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TimesTableToolStripMenuItem.Click
        Me.Hide()
        TimesTable.Show()
    End Sub

    Private Sub FibonacciSequenceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FibonacciSequenceToolStripMenuItem.Click
        Me.Hide()
        FibonacciSequence.Show()
    End Sub

    'If we want the output to look like an actual pyramid, we can use this code to add spaces in front of every layer.

    'For i As Integer = 1 To layers
    'Dim spaces As String = New String(" "c, layers - i)

    'Dim asterisks As String = New String("*"c, 2 * i - 1)

    'Dim layerText As String = spaces & asterisks

    'lstResult.Items.Add(layerText)
    'Next

End Class