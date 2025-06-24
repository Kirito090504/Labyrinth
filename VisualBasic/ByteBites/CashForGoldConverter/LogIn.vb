Public Class LogIn

    Dim user As String
    Dim pass As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        user = Convert.ToString(Username.Text)
        pass = Convert.ToString(Password.Text)

        If user = "admin" AndAlso pass = "admin" Then
            If MessageBox.Show("Log-in Successful!", "Log-in Success", MessageBoxButtons.OK, MessageBoxIcon.Exclamation) Then
                DialogResult = DialogResult.OK
                CashforGold.Show()
                Me.Hide()
            End If
        Else
            MessageBox.Show("Incorrect Username or Passwor", "Log-in Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            If DialogResult = DialogResult.OK Then
                Me.Show()
            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim result As DialogResult

        MessageBox.Show("Are you sure you want to close the program?", "Close Program", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If result = DialogResult.Yes Then
            Me.Close()
        ElseIf result = DialogResult.No Then
            Me.Show()
        End If
    End Sub
End Class
