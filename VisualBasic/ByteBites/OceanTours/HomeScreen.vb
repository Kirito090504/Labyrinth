Public Class HomeScreen

    Private Sub HomeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HomeToolStripMenuItem.Click
        Me.Show()
    End Sub

    Private Sub HawaiiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HawaiiToolStripMenuItem.Click
        Me.Hide()
        Hawaii_Trip.Show()
    End Sub

    Private Sub JamaicaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles JamaicaToolStripMenuItem.Click
        Me.Hide()
        Jamaica_Trip.Show()
    End Sub

    Private Sub MaldivesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MaldivesToolStripMenuItem.Click
        Me.Hide()
        Maldives_Trip.Show()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        Me.Hide()
        About_Form.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

End Class