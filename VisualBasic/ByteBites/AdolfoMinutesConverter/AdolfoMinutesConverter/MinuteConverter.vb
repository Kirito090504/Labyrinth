Public Class MinuteConverter
    Private Hours As Double = 60
    Private Minutes As Double = 1


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'variable declarations 
        Dim TH As Double
        Dim TM As Double
        Static Total As Double

        'calc
        Double.TryParse(H.Text, TH)
        Double.TryParse(M.Text, TM)

        TH *= Hours
        TM *= Minutes

        Total = TH + TM

        Out.Text = Convert.ToString(Total)

    End Sub
End Class
