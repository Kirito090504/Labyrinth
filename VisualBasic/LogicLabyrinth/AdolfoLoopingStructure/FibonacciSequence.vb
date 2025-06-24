Public Class FibonacciSequence
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ListBox1.Items.Clear()

        If Integer.TryParse(TextBox1.Text, Nothing) Then
            Dim n As Integer = Integer.Parse(TextBox1.Text)

            Dim fibSeries As List(Of Integer) = GenerateFibonacciSeries(n)
            For Each num In fibSeries
                ListBox1.Items.Add(num)
            Next
        Else
            ListBox1.Items.Add("Please enter a valid number.")
        End If
    End Sub

    Private Function GenerateFibonacciSeries(n As Integer) As List(Of Integer)
        Dim fibSeries As New List(Of Integer)

        Dim num1 As Integer = 0
        Dim num2 As Integer = 1

        fibSeries.Add(num1)
        fibSeries.Add(num2)

        While (num1 + num2) <= n
            Dim nextNum As Integer = num1 + num2
            fibSeries.Add(nextNum)
            num1 = num2
            num2 = nextNum
        End While

        Return fibSeries
    End Function
End Class