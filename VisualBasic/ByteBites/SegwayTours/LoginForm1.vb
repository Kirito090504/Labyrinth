Public Class LoginForm1

    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See https://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.

    Dim user As String
    Dim pass As String


    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click

        user = Convert.ToString(Username.Text)
        pass = Convert.ToString(Password.Text)

        If user = "Chie" AndAlso pass = "secret12345" Then
            If MessageBox.Show("Log-in Successful!", "Log-in Success", MessageBoxButtons.OK, MessageBoxIcon.Exclamation
                               ) Then
                DialogResult = DialogResult.OK
                Form1.Show()
                Me.Hide()
            End If
        Else
            MessageBox.Show("Incorrect Username or Passwor", "Log-in Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            If DialogResult = DialogResult.OK Then
                Me.Show()
            End If
        End If

    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Dim result As DialogResult

        MessageBox.Show("Are you sure you want to close the program?", "Close Program", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If result = DialogResult.Yes Then
            Me.Close()
        ElseIf result = DialogResult.No Then
            Me.Show()
        End If

    End Sub

    Private Sub UsernameTextBox_TextChanged(sender As Object, e As EventArgs) Handles Username.TextChanged

    End Sub

    Private Sub LoginForm1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
