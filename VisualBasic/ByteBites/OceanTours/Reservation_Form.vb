Public Class Reservation_Form

    Dim qua As Double

    Dim cost1 As Double
    Dim cost2 As Double
    Dim cost3 As Double
    Dim cost4 As Double
    Dim totalcost As Double

    Dim time1 As Double
    Dim time2 As Double
    Dim time3 As Double
    Dim time4 As Double
    Dim totaltime As Double

    Private Sub Reservation_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Items.Add("Hawaii")
        ComboBox1.Items.Add("Jamaica")
        ComboBox1.Items.Add("Maldives")
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedIndex = 0 Then

            CB1.Text = "Deep Sea Fishing"
            CB2.Text = "Kayaking"
            CB3.Text = "Scuba"
            CB4.Text = "Snorkeling"

            Label1.Visible = True
            Label5.Visible = True
            quantity.Visible = True
            CB1.Visible = True
            CB2.Visible = True
            CB2.Visible = True
            CB3.Visible = True
            CB4.Visible = True
            FindCost.Visible = True
            clr.Visible = True
            Label2.Visible = True
            Label3.Visible = True
            Label4.Visible = True
            LB1.Visible = True
            totalbill.Visible = True
            length.Visible = True
        ElseIf ComboBox1.SelectedIndex = 1 Then
            CB1.Text = "Glass Bottom Boat"
            CB2.Text = "Parasailing"
            CB3.Text = "Snorkeling"

            Label1.Visible = True
            Label5.Visible = True
            quantity.Visible = True
            CB1.Visible = True
            CB2.Visible = True
            CB2.Visible = True
            CB3.Visible = True
            CB4.Visible = False
            FindCost.Visible = True
            clr.Visible = True
            Label2.Visible = True
            Label3.Visible = True
            Label4.Visible = True
            LB1.Visible = True
            totalbill.Visible = True
            length.Visible = True
        ElseIf ComboBox1.SelectedIndex = 2 Then
            CB1.Text = "Deep Sea Fishing"
            CB2.Text = "Glass Bottom Boat"
            CB3.Text = "Scuba"
            CB4.Text = "Snorkeling"

            Label1.Visible = True
            Label5.Visible = True
            quantity.Visible = True
            CB1.Visible = True
            CB2.Visible = True
            CB2.Visible = True
            CB3.Visible = True
            CB4.Visible = True
            FindCost.Visible = True
            clr.Visible = True
            Label2.Visible = True
            Label3.Visible = True
            Label4.Visible = True
            LB1.Visible = True
            totalbill.Visible = True
            length.Visible = True

        End If
    End Sub

    Private Sub quantity_TextChanged(sender As Object, e As EventArgs) Handles quantity.TextChanged
        Double.TryParse(quantity.Text, qua)
        If qua > 99 Then
            MessageBox.Show("Please enter a number between 1-99", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub FindCost_Click(sender As Object, e As EventArgs) Handles FindCost.Click
        Double.TryParse(quantity.Text, qua)
        If ComboBox1.SelectedIndex = 0 Then
            If CB1.Checked = True Then
                LB1.Items.Add("Deep Sea Fishing")
                cost1 = qua * 199
                time1 = 8

                If CB2.Checked = True Then
                    LB1.Items.Add("Kayaking")
                    cost2 = qua * 89
                    time2 = 2

                    If CB3.Checked = True Then
                        LB1.Items.Add("Scuba")
                        cost3 = qua * 119
                        time3 = 3

                        If CB4.Checked = True Then
                            LB1.Items.Add("Snorkeling")
                            cost4 = qua * 89
                            time4 = 4
                        End If
                    End If
                End If
            End If
            totalcost = cost1 + cost2 + cost3 + cost4
            totaltime = time1 + time2 + time3 + time4
            totalbill.Text = totalcost.ToString
            length.Text = totaltime.ToString

        ElseIf ComboBox1.SelectedIndex = 1 Then
            If CB1.Checked = True Then
                LB1.Items.Add("Glass Bottom Boat")
                cost1 = qua * 39
                time1 = 2
                If CB2.Checked = True Then
                    LB1.Items.Add("Parasailing")
                    cost2 = qua * 119
                    time2 = 2
                    If CB3.Checked = True Then
                        LB1.Items.Add("Snorkeling")
                        cost3 = qua * 59
                        time3 = 2
                    End If
                End If
            End If
            totalcost = cost1 + cost2 + cost3
            totaltime = time1 + time2 + time3
            totalbill.Text = totalcost.ToString
            length.Text = totaltime.ToString

        ElseIf ComboBox1.SelectedIndex = 2 Then
            If CB1.Checked = True Then
                LB1.Items.Add("Deep Sea Fishing")
                cost1 = qua * 89
                time1 = 4
                If CB2.Checked = True Then
                    LB1.Items.Add("Glass Bottom Boat")
                    cost2 = qua * 29
                    time2 = 2
                    If CB3.Checked = True Then
                        LB1.Items.Add("Scuba")
                        cost3 = qua * 119
                        time3 = 3
                        If CB4.Checked = True Then
                            LB1.Items.Add("Snorkeling")
                            cost4 = qua * 59
                            time4 = 3
                        End If
                    End If
                End If
            End If
            totalcost = cost1 + cost2 + cost3 + cost4
            totaltime = time1 + time2 + time3 + time4
            totalbill.Text = totalcost.ToString
            length.Text = totaltime.ToString
        End If
    End Sub

    Private Sub clr_Click(sender As Object, e As EventArgs) Handles clr.Click
        ComboBox1.SelectedIndex = -1
        quantity.Text = ""
        CB1.Text = ""
        CB2.Text = ""
        CB3.Text = ""
        CB4.Text = ""
        CB1.Checked = False
        CB2.Checked = False
        CB3.Checked = False
        CB4.Checked = False
        LB1.Items.Clear()
        totalbill.Text = ""
        length.Text = ""
    End Sub
End Class