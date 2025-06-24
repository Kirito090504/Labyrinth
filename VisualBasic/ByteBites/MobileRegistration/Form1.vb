Public Class Form1



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim qua As Double
        Dim Bill As Double
        Dim PC As Double
        Dim Total As Double
        Double.TryParse(quantity.Text, qua)


        If qua > 4 Then
            MessageBox.Show("Please inputt a valid number of days from 1-4", "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

        If CorpID.Text.Length > 5 Or CorpID.Text.Length < 1 Then
            MessageBox.Show("Please inputt a valid number of Corporate ID", "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

        If MS.Checked = True Then
            outlbl1.Text = "You choose Mobile Security"
            Bill = 4000 * qua
            TotalBill.Text = Bill.ToString
            Label1.Text = "Thank you for registering!"
            PictureBox1.Visible = True
            PictureBox2.Visible = False
            PictureBox3.Visible = False
            If Android.Checked = True Then
                outlbl2.Text = "with Android Pre-Conference Course"
                PC = 5000
                Bill = 4000 * qua
                Total = Bill + PC
                TotalBill.Text = Total.ToString
                Label1.Text = "Thank you for registering!"
                PictureBox4.Visible = True
                PictureBox5.Visible = False
            ElseIf IOS.Checked = True Then
                outlbl2.Text = "with IOS Pre-Conference Course"
                PC = 5000
                Bill = 4000 * qua
                Total = Bill + PC
                TotalBill.Text = Total.ToString
                Label1.Text = "Thank you for registering!"
                PictureBox4.Visible = False
                PictureBox5.Visible = True
            End If
        ElseIf MD.Checked = True Then
            outlbl1.Text = "You choose Mobile Database"
            Bill = 4000 * qua
            TotalBill.Text = Bill.ToString
            Label1.Text = "Thank you for registering!"
            PictureBox1.Visible = False
            PictureBox2.Visible = True
            PictureBox3.Visible = False
            If Android.Checked = True Then
                outlbl2.Text = "with Android Pre-Conference Course"
                PC = 5000
                Bill = 4000 * qua
                Total = Bill + PC
                TotalBill.Text = Total.ToString
                Label1.Text = "Thank you for registering!"
                PictureBox4.Visible = True
                PictureBox5.Visible = False
            ElseIf IOS.Checked = True Then
                outlbl2.Text = "with IOS Pre-Conference Course"
                PC = 5000
                Bill = 4000 * qua
                Total = Bill + PC
                TotalBill.Text = Total.ToString
                Label1.Text = "Thank you for registering!"
                PictureBox4.Visible = False
                PictureBox5.Visible = True
            End If

        ElseIf MA.Checked = True Then
            outlbl1.Text = "You choose Mobile Application"
            Bill = 4000 * qua
            TotalBill.Text = Bill.ToString
            PictureBox1.Visible = False
            PictureBox2.Visible = False
            PictureBox3.Visible = True
            If Android.Checked = True Then
                outlbl2.Text = "with Android Pre-Conference Course"
                PC = 5000
                Bill = 4000 * qua
                Total = Bill + PC
                TotalBill.Text = Total.ToString
                Label1.Text = "Thank you for registering!"
                PictureBox4.Visible = True
                PictureBox5.Visible = False
            ElseIf IOS.Checked = True Then
                outlbl2.Text = "with IOS Pre-Conference Course"
                PC = 5000
                Bill = 4000 * qua
                Total = Bill + PC
                TotalBill.Text = Total.ToString
                Label1.Text = "Thank you for registering!"
                PictureBox4.Visible = False
                PictureBox5.Visible = True
            End If
        ElseIf MS.Checked = False And MA.Checked = False And MD.Checked = False Then
            outlbl1.Text = "You haven't chosen a Course Conference"
        End If


        Form2.Show()

        Form2.CID.Text = CorpID.Text
        Form2.LastName.Text = Ln.Text
        Form2.FirstName.Text = Fn.Text
        Form2.days.Text = quantity.Text
        Form2.course.Text = GroupBox1.Text
        Form2.precon.Text = GroupBox2.Text
        Form2.totalcost.Text = TotalBill.Text

        If MS.Checked = True Then
            Form2.course.Text = "Mobile Security"
        ElseIf MD.Checked = True Then
            Form2.course.Text = "Mobile Database"
        ElseIf MA.Checked = True Then
            Form2.course.Text = "Mobile Application"
        End If

        If Android.Checked = True Then
            Form2.precon.Text = "Android"
        ElseIf IOS.Checked = True Then
            Form2.precon.Text = "IOS"
        ElseIf Android.Checked = False And IOS.Checked = False Then
            Form2.precon.Text = "None"
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        CorpID.Clear()
        Ln.Clear()
        Fn.Clear()
        MS.Checked = False
        MD.Checked = False
        MA.Checked = False
        Android.Checked = False
        IOS.Checked = False
        TotalBill.Clear()
    End Sub
End Class
