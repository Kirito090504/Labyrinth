Public Class HomeScreen
    Dim qua As Double
    Dim t As Double
    Dim taxed As Double
    Dim subt As Double


    Private Sub HomeScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Items.Add("Lion King")
        ComboBox1.Items.Add("Les Miserables")
        ComboBox1.Items.Add("Phantom of the Opera")
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedIndex = 0 Then
            Label2.Visible = True
            Label3.Visible = True
            Label4.Visible = True
            Label5.Visible = True
            total.Visible = True
            tax.Visible = True
            subtotal.Visible = True
            compute.Visible = True
            clear.Visible = True
            quantity.Visible = True
            RadioButton1.Visible = True
            RadioButton2.Visible = True
        ElseIf ComboBox1.SelectedIndex = 1 Then
            Label2.Visible = True
            Label3.Visible = True
            Label4.Visible = True
            Label5.Visible = True
            total.Visible = True
            tax.Visible = True
            subtotal.Visible = True
            compute.Visible = True
            clear.Visible = True
            quantity.Visible = True
            RadioButton1.Visible = True
            RadioButton2.Visible = True
        ElseIf ComboBox1.SelectedIndex = 2 Then
            Label2.Visible = True
            Label3.Visible = True
            Label4.Visible = True
            Label5.Visible = True
            total.Visible = True
            tax.Visible = True
            subtotal.Visible = True
            compute.Visible = True
            clear.Visible = True
            quantity.Visible = True
            RadioButton1.Visible = True
            RadioButton2.Visible = True
        End If
    End Sub

    Private Sub compute_Click(sender As Object, e As EventArgs) Handles compute.Click
        Double.TryParse(quantity.Text, qua)
        If ComboBox1.SelectedIndex = 0 Then
            If RadioButton1.Checked = True Then
                t = 135 * qua
                taxed = (135 * qua) * 0.12
                subt = t + taxed
                total.Text = t.ToString
                tax.Text = taxed.ToString
                subtotal.Text = subt.ToString
            ElseIf RadioButton2.Checked = True Then
                t = 92 * qua
                taxed = (92 * qua) * 0.12
                subt = t + taxed
                total.Text = t.ToString
                tax.Text = taxed.ToString
                subtotal.Text = subt.ToString
            End If
        ElseIf ComboBox1.SelectedIndex = 1 Then
            If RadioButton1.Checked = True Then
                t = 149 * qua
                taxed = (149 * qua) * 0.12
                subt = t + taxed
                total.Text = t.ToString
                tax.Text = taxed.ToString
                subtotal.Text = subt.ToString
            ElseIf RadioButton2.Checked = True Then
                t = 98 * qua
                taxed = (98 * qua) * 0.12
                subt = t + taxed
                total.Text = t.ToString
                tax.Text = taxed.ToString
                subtotal.Text = subt.ToString
            End If
        ElseIf ComboBox1.SelectedIndex = 2 Then
            If RadioButton1.Checked = True Then
                t = 128 * qua
                taxed = (128 * qua) * 0.12
                subt = t + taxed
                total.Text = t.ToString
                tax.Text = taxed.ToString
                subtotal.Text = subt.ToString
            ElseIf RadioButton2.Checked = True Then
                t = 82 * qua
                taxed = (82 * qua) * 0.12
                subt = t + taxed
                total.Text = t.ToString
                tax.Text = taxed.ToString
                subtotal.Text = subt.ToString
            End If
        End If
    End Sub

    Private Sub LionKingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LionKingToolStripMenuItem.Click
        Me.Hide()
        LionKing.Show()
    End Sub

    Private Sub LesMiserablesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LesMiserablesToolStripMenuItem.Click
        Me.Hide()
        LesMiserables.Show()
    End Sub

    Private Sub PhantomOfTheOperaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PhantomOfTheOperaToolStripMenuItem.Click
        Me.Hide()
        PhantomoftheOpera.Show()
    End Sub

    Private Sub clear_Click(sender As Object, e As EventArgs) Handles clear.Click
        ComboBox1.SelectedIndex = -1
        total.Text = ""
        tax.Text = ""
        subtotal.Text = ""
        quantity.Text = ""

        RadioButton1.Checked = False
        RadioButton2.Checked = False
    End Sub
End Class
