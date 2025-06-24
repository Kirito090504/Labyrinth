Public Class CashforGold

    Dim qua As Double
    Dim calc As Double
    Private Sub CashforGold_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        comboGold.Items.Add("Calculate the Amount earned Based on Gold collected")
        comboGold.Items.Add("Calculate Amount of Gold Needed to Make Target Goal")
    End Sub

    Private Sub comboGold_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboGold.SelectedIndexChanged
        If comboGold.SelectedIndex = 0 Then
            lblGoal.Text = "Ounces Collected:"
            btnFind.Text = "Find Amount Earned"
        ElseIf comboGold.SelectedIndex = 1 Then
            lblGoal.Text = "Target Goal Amount:"
            btnFind.Text = "Find Target Amount of Gold"
        End If
    End Sub

    Private Sub btnFind_Click(sender As Object, e As EventArgs) Handles btnFind.Click
        Double.TryParse(txtgold.Text, qua)
        If comboGold.SelectedIndex = 0 Then
            calc = qua * 1556.65
            lblResult.Text = "$ " + calc.ToString + " " + "will be earned by selling the gold"
            lblResult.Visible = True
        ElseIf comboGold.SelectedIndex = 1 Then
            calc = qua / 1556.65
            lblResult.Text = calc.ToString("F2") + " " + "ounches of gold needed to reach your goal"
            lblResult.Visible = True
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        comboGold.SelectedIndex = -1
        lblGoal.Text = "Goal:"
        txtgold.Text = ""
        btnFind.Text = "Find"
        lblResult.Text = " "
    End Sub
End Class