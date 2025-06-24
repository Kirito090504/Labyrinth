Public Class Form1
    Private Sub Compute_Click(sender As Object, e As EventArgs) Handles Compute.Click


        Dim qua As Double
        Dim TotalBill As Double
        Dim DiscountedBill As Double
        Double.TryParse(Quantity.Text, qua)

        If ComboBox1.Text = "Select Tour" Then
            MessageBox.Show("Select a Valid Tour", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf ComboBox1.Text = "Golden Gate Tour ($79.99)" Then
            If ListBox.SelectedIndex = 0 Then
                DiscountedBill = 0
                TotalBill = 79.99 * qua
                Disc.Text = DiscountedBill.ToString("C2")
                Bill.Text = TotalBill.ToString("C2")
            ElseIf ListBox.SelectedIndex = 1 Then
                DiscountedBill = (79.99 * qua) * 0.1
                TotalBill = (79.99 * qua) - DiscountedBill
                Disc.Text = DiscountedBill.ToString("C2")
                Bill.Text = TotalBill.ToString("C2")
            ElseIf ListBox.SelectedIndex = 2 Then
                DiscountedBill = (79.99 * qua) * 0.2
                TotalBill = (79.99 * qua) - DiscountedBill
                Disc.Text = DiscountedBill.ToString("C2")
                Bill.Text = TotalBill.ToString("C2")
            ElseIf ListBox.SelectedIndex = 3 Then
                DiscountedBill = (79.99 * qua) * 0.25
                TotalBill = (79.99 * qua) - DiscountedBill
                Disc.Text = DiscountedBill.ToString("C2")
                Bill.Text = TotalBill.ToString("C2")
            End If
        ElseIf ComboBox1.Text = "Waterfront Tour ($69.99)" Then
            If ListBox.SelectedIndex = 0 Then
                DiscountedBill = 0
                TotalBill = 69.99 * qua
                Disc.Text = DiscountedBill.ToString("C2")
                Bill.Text = TotalBill.ToString("C2")
            ElseIf ListBox.SelectedIndex = 1 Then
                DiscountedBill = (69.99 * qua) * 0.1
                TotalBill = (69.99 * qua) - DiscountedBill
                Disc.Text = DiscountedBill.ToString("C2")
                Bill.Text = TotalBill.ToString("C2")
            ElseIf ListBox.SelectedIndex = 2 Then
                DiscountedBill = (79.99 * qua) * 0.2
                TotalBill = (69.99 * qua) - DiscountedBill
                Disc.Text = DiscountedBill.ToString("C2")
                Bill.Text = TotalBill.ToString("C2")
            ElseIf ListBox.SelectedIndex = 3 Then
                DiscountedBill = (69.99 * qua) * 0.25
                TotalBill = (69.99 * qua) - DiscountedBill
                Disc.Text = DiscountedBill.ToString("C2")
                Bill.Text = TotalBill.ToString("C2")
            End If
        End If

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Items.Add("Select Tour")
        ComboBox1.Items.Add("Golden Gate Tour ($79.99)")
        ComboBox1.Items.Add("Waterfront Tour ($69.99)")

        ListBox.Items.Add("None")
        ListBox.Items.Add("Military Discount (10%)")
        ListBox.Items.Add("Student Discount (20%)")
        ListBox.Items.Add("Senior Citizen Discount (25%)")
    End Sub

    Private Sub Clear_Click(sender As Object, e As EventArgs) Handles Clear.Click
        ComboBox1.Text = "Select Tour"
        ListBox.SelectedIndex = 1
        Quantity.Clear()
        Disc.Clear()
        Bill.Clear()
    End Sub

End Class
