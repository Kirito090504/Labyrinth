Public Class BMICalc

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ft As Double
        Dim inches As Double
        Dim kg As Double

        If Double.TryParse(Txtft.Text, ft) AndAlso Double.TryParse(TxtIn.Text, inches) AndAlso Double.TryParse(Txtkg.Text, kg) Then

            Dim meters = (ft / 3.281) + (inches / 39.37)
            Dim bmi As Double = kg / (meters) ^ 2

            ' Display BMI result
            BMILabel.Text = bmi.ToString("F2")

            ' Determine BMI category
            Dim bmiCategory As String

            Select Case bmi
                Case Is < 18.5
                    bmiCategory = "Underweight"
                    ProgressBar1.Value = 25
                    PictureBox1.Visible = True
                    PictureBox2.Visible = False
                    PictureBox3.Visible = False
                    PictureBox4.Visible = False
                Case Is < 24.9
                    bmiCategory = "Healthy Weight"
                    ProgressBar1.Value = 50
                    PictureBox1.Visible = False
                    PictureBox2.Visible = True
                    PictureBox3.Visible = False
                    PictureBox4.Visible = False
                Case Is < 29.9
                    bmiCategory = "Overweight"
                    ProgressBar1.Value = 75
                    PictureBox1.Visible = False
                    PictureBox2.Visible = False
                    PictureBox3.Visible = True
                    PictureBox4.Visible = False
                Case Else
                    bmiCategory = "Obese"
                    ProgressBar1.Value = 100
                    PictureBox1.Visible = False
                    PictureBox2.Visible = False
                    PictureBox3.Visible = False
                    PictureBox4.Visible = True
            End Select
            CategoryLabel.Text = bmiCategory
        Else
            MessageBox.Show("Please enter valid weight and height values.")
        End If
    End Sub
End Class
