Imports System.Globalization

Public Class MonthDisplay
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Get the month number from the TextBox
        Dim monthNumber As Integer
        If Integer.TryParse(MonthNumberTextBox.Text, monthNumber) AndAlso monthNumber >= 1 AndAlso monthNumber <= 12 Then
            ' Convert the month number to the month name
            Dim monthName As String = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(monthNumber)

            ' Display the month name in the Label
            Result.Text = monthName
        Else
            ' Display an error message if the input is invalid
            Result.Text = "Invalid input. Enter a number between 1 and 12."
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TollGateCharge.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        GradeConverter.Show()
        Me.Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        YearLevelAssignment.Show()
        Me.Hide()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Commission.Show()
        Me.Hide()
    End Sub
End Class
