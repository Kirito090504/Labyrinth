Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Summary.N.Text = Name1.Text
        Summary.A.Text = Address1.Text
        Summary.CN.Text = ContactNumber1.Text
        Summary.quantity2.Text = quantity.Text

        Dim BasePrice As Double
        Dim TaxPrice As Double
        Dim Sfee As Double
        Dim Total As Double
        Dim qua As Double
        Double.TryParse(quantity.Text, qua)

        If TL.Checked = True Then
            Summary.CandleStyle.Text = "Tea Lights"
            If Scented.Checked = True Then
                Summary.Scen.Text = "Yes"
                BasePrice = (5.75 + 0.75) * qua
                TaxPrice = BasePrice * 0.08
                Sfee = BasePrice * 0.03
                Total = BasePrice + TaxPrice + Sfee
                Summary.FinalPrice.Text = Total.ToString("C2")
            ElseIf Scented.Checked = False Then
                Summary.Scen.Text = "No"
                BasePrice = 5.75 * qua
                TaxPrice = BasePrice * 0.08
                Sfee = BasePrice * 0.03
                Total = BasePrice + TaxPrice + Sfee
                Summary.FinalPrice.Text = Total.ToString("C2")
            End If
        ElseIf V.Checked = True Then
            Summary.CandleStyle.Text = "Votives"
            If Scented.Checked = True Then
                Summary.Scen.Text = "Yes"
                BasePrice = (7.5 + 1.25) * qua
                TaxPrice = BasePrice * 0.08
                Sfee = BasePrice * 0.03
                Total = BasePrice + TaxPrice + Sfee
                Summary.FinalPrice.Text = Total.ToString("C2")
            ElseIf Scented.Checked = False Then
                Summary.Scen.Text = "No"
                BasePrice = 7.5 * qua
                TaxPrice = BasePrice * 0.08
                Sfee = BasePrice * 0.03
                Total = BasePrice + TaxPrice + Sfee
                Summary.FinalPrice.Text = Total.ToString("C2")
            End If
        ElseIf P.Checked = True Then
            Summary.CandleStyle.Text = "Pillar"
            If Scented.Checked = True Then
                Summary.Scen.Text = "Yes"
                BasePrice = (12.25 + 1.75) * qua
                TaxPrice = BasePrice * 0.08
                Sfee = BasePrice * 0.03
                Total = BasePrice + TaxPrice + Sfee
                Summary.FinalPrice.Text = Total.ToString("C2")
            ElseIf Scented.Checked = False Then
                Summary.Scen.Text = "No"
                BasePrice = 12.25 * qua
                TaxPrice = BasePrice * 0.08
                Sfee = BasePrice * 0.03
                Total = BasePrice + TaxPrice + Sfee
                Summary.FinalPrice.Text = Total.ToString("C2")
            End If
        End If

        If FB.Checked = True Then
            Summary.CandleColor.Text = "Federal Blue"
        ElseIf SY.Checked = True Then
            Summary.CandleColor.Text = "Sunflower Yellow"
        ElseIf CR.Checked = True Then
            Summary.CandleColor.Text = "Christmas Red"
        ElseIf LW.Checked = True Then
            Summary.CandleColor.Text = "Lily White"
        End If

        Summary.Show()
        Me.Hide()
    End Sub

End Class
