Public Class Order_Summary
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim pay As Double
        Dim totbill As Double
        Double.TryParse(payment.Text, pay)
        Double.TryParse(tb.Text, totbill)

        If pay < totbill Then
            MessageBox.Show("Insufficient Payment", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            sukli.Text = pay - tb.Text
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Form1.Show()

        Form1.LB1.Items.Clear()
        Form1.LB2.Items.Clear()
        Form1.quantity1.Value = 0
        Form1.quantity2.Value = 0
        Form1.quantity3.Value = 0
        Form1.quantity4.Value = 0
        Form1.quantity5.Value = 0
        Form1.ComboBox1.SelectedIndex = -1
        Form1.TotalBill.Clear()

        Form1.PictureBox1.Visible = False
        Form1.PictureBox2.Visible = False
        Form1.PictureBox3.Visible = False
        Form1.PictureBox4.Visible = False
        Form1.PictureBox5.Visible = False
        Form1.PictureBox6.Visible = False
        Form1.PictureBox7.Visible = False
        Form1.PictureBox8.Visible = False
        Form1.PictureBox9.Visible = False
        Form1.PictureBox10.Visible = False
        Form1.PictureBox11.Visible = False
        Form1.PictureBox12.Visible = False
        Form1.PictureBox13.Visible = False
        Form1.PictureBox14.Visible = False
        Form1.PictureBox15.Visible = False

        Form1.choice1.Text = ""
        Form1.choice2.Text = ""
        Form1.choice3.Text = ""
        Form1.choice4.Text = ""
        Form1.choice5.Text = ""

        Form1.price1.Text = ""
        Form1.price2.Text = ""
        Form1.price3.Text = ""
        Form1.price4.Text = ""
        Form1.price5.Text = ""

    End Sub
End Class