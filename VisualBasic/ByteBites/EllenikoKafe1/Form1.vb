Imports System.Runtime.CompilerServices
Imports System.Security.Policy

Public Class Form1

    'Declaration of variables used for calculation of orders
    Dim qua1 As Double
    Dim qua2 As Double
    Dim qua3 As Double
    Dim qua4 As Double
    Dim qua5 As Double

    Dim bill1 As Double
    Dim bill2 As Double
    Dim bill3 As Double
    Dim bill4 As Double
    Dim bill5 As Double

    Dim cost1 As Double
    Dim cost2 As Double
    Dim cost3 As Double
    Dim cost4 As Double
    Dim cost5 As Double

    Dim finalprice As Double
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Items.Add("Breakfast")
        ComboBox1.Items.Add("Lunch")
        ComboBox1.Items.Add("Dinner")
    End Sub

    'Changes the label of buttons and display their respective prices dependent on ComboBox choice
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedIndex = 0 Then
            choice1.Text = "Pancake"
            choice2.Text = "Hotdog"
            choice3.Text = "Bread"
            choice4.Text = "Cake"
            choice5.Text = "Egg"

            price1.Text = "Php 110.00"
            price2.Text = "Php 40.00"
            price3.Text = "Php 45.00"
            price4.Text = "Php 75.00"
            price5.Text = "Php 20.00"

            PictureBox1.Visible = True
            PictureBox2.Visible = True
            PictureBox3.Visible = True
            PictureBox4.Visible = True
            PictureBox5.Visible = True
            PictureBox6.Visible = False
            PictureBox7.Visible = False
            PictureBox8.Visible = False
            PictureBox9.Visible = False
            PictureBox10.Visible = False
            PictureBox11.Visible = False
            PictureBox12.Visible = False
            PictureBox13.Visible = False
            PictureBox14.Visible = False
            PictureBox15.Visible = False
        ElseIf ComboBox1.SelectedIndex = 1 Then
            choice1.Text = "Chicken"
            choice2.Text = "Beef and Mushroom"
            choice3.Text = "Pork Steak"
            choice4.Text = "Spaghetti"
            choice5.Text = "Rice"

            price1.Text = "Php 150.00"
            price2.Text = "Php 170.00"
            price3.Text = "Php 120.00"
            price4.Text = "Php 90.00"
            price5.Text = "Php 30.00"

            PictureBox1.Visible = False
            PictureBox2.Visible = False
            PictureBox3.Visible = False
            PictureBox4.Visible = False
            PictureBox5.Visible = False
            PictureBox6.Visible = True
            PictureBox7.Visible = True
            PictureBox8.Visible = True
            PictureBox9.Visible = True
            PictureBox10.Visible = True
            PictureBox11.Visible = False
            PictureBox12.Visible = False
            PictureBox13.Visible = False
            PictureBox14.Visible = False
            PictureBox15.Visible = False
        ElseIf ComboBox1.SelectedIndex = 2 Then
            choice1.Text = "Chicken"
            choice2.Text = "Beef and Mushroom"
            choice3.Text = "Pork Adobo"
            choice4.Text = "Rice"
            choice5.Text = "Chocolate"

            price1.Text = "Php 150.00"
            price2.Text = "Php 170.00"
            price3.Text = "Php 130.00"
            price4.Text = "Php 30.00"
            price5.Text = "Php 250.00"

            PictureBox1.Visible = False
            PictureBox2.Visible = False
            PictureBox3.Visible = False
            PictureBox4.Visible = False
            PictureBox5.Visible = False
            PictureBox6.Visible = False
            PictureBox7.Visible = False
            PictureBox8.Visible = False
            PictureBox9.Visible = False
            PictureBox10.Visible = False
            PictureBox11.Visible = True
            PictureBox12.Visible = True
            PictureBox13.Visible = True
            PictureBox14.Visible = True
            PictureBox15.Visible = True
        End If
    End Sub

    Private Sub choice1_Click(sender As Object, e As EventArgs) Handles choice1.Click
        Double.TryParse(quantity1.Value, qua1)
        If ComboBox1.SelectedIndex = 0 Then
            bill1 = 110 * qua1
            cost1 = bill1.ToString
            LB1.Items.Add(qua1.ToString + " " + "Pancake")
            LB2.Items.Add(cost1)
        ElseIf ComboBox1.SelectedIndex = 1 Then
            bill1 = 150 * qua1
            cost1 = bill1.ToString
            LB1.Items.Add(qua1.ToString + " " + "Chicken")
            LB2.Items.Add(cost1)
        ElseIf ComboBox1.SelectedIndex = 2 Then
            bill1 = 150 * qua1
            cost1 = bill1.ToString
            LB1.Items.Add(qua1.ToString + " " + "Chicken")
            LB2.Items.Add(cost1)
        End If
    End Sub

    Private Sub choice2_Click(sender As Object, e As EventArgs) Handles choice2.Click
        Double.TryParse(quantity2.Value, qua2)
        If ComboBox1.SelectedIndex = 0 Then
            bill2 = 40 * qua2
            cost2 = bill2.ToString
            LB1.Items.Add(qua2.ToString + " " + "Hotdog")
            LB2.Items.Add(cost2)
        ElseIf ComboBox1.SelectedIndex = 1 Then
            bill2 = 170 * qua2
            cost2 = bill2.ToString
            LB1.Items.Add(qua2.ToString + " " + "Beef and Mushroom")
            LB2.Items.Add(cost2)
        ElseIf ComboBox1.SelectedIndex = 2 Then
            bill2 = 170 * qua2
            cost2 = bill2.ToString
            LB1.Items.Add(qua2.ToString + " " + "Beef and Mushroom")
            LB2.Items.Add(cost2)
        End If
    End Sub
    Private Sub choice3_Click(sender As Object, e As EventArgs) Handles choice3.Click
        Double.TryParse(quantity3.Value, qua3)
        If ComboBox1.SelectedIndex = 0 Then
            bill3 = 45 * qua3
            cost3 = bill3.ToString
            LB1.Items.Add(qua3.ToString + " " + "Bread")
            LB2.Items.Add(cost3)
        ElseIf ComboBox1.SelectedIndex = 1 Then
            bill3 = 120 * qua3
            cost3 = bill3.ToString
            LB1.Items.Add(qua3.ToString + " " + "Pork Steak")
            LB2.Items.Add(cost3)
        ElseIf ComboBox1.SelectedIndex = 2 Then
            bill3 = 130 * qua3
            cost3 = bill3.ToString
            LB1.Items.Add(qua3.ToString + " " + "Pork Adobo")
            LB2.Items.Add(cost3)
        End If
    End Sub

    Private Sub choice4_Click(sender As Object, e As EventArgs) Handles choice4.Click
        Double.TryParse(quantity4.Value, qua4)
        If ComboBox1.SelectedIndex = 0 Then
            bill4 = 75 * qua4
            cost4 = bill4.ToString
            LB1.Items.Add(qua4.ToString + " " + "Cake")
            LB2.Items.Add(cost4)
        ElseIf ComboBox1.SelectedIndex = 1 Then
            bill4 = 90 * qua4
            cost4 = bill4.ToString
            LB1.Items.Add(qua4.ToString + " " + "Spaghetti")
            LB2.Items.Add(cost4)
        ElseIf ComboBox1.SelectedIndex = 2 Then
            bill4 = 30 * qua4
            cost4 = bill4.ToString
            LB1.Items.Add(qua4.ToString + " " + "Rice")
            LB2.Items.Add(cost4)
        End If
    End Sub

    Private Sub choice5_Click(sender As Object, e As EventArgs) Handles choice5.Click
        Double.TryParse(quantity5.Value, qua5)
        If ComboBox1.SelectedIndex = 0 Then
            bill5 = 20 * qua5
            cost5 = bill5.ToString
            LB1.Items.Add(qua5.ToString + " " + "Egg")
            LB2.Items.Add(cost5)
        ElseIf ComboBox1.SelectedIndex = 1 Then
            bill5 = 30 * qua5
            cost5 = bill5.ToString
            LB1.Items.Add(qua5.ToString + " " + "Rice")
            LB2.Items.Add(cost5)
        ElseIf ComboBox1.SelectedIndex = 2 Then
            bill5 = 250 * qua5
            cost5 = bill5.ToString
            LB1.Items.Add(qua5.ToString + " " + "Chocolate")
            LB2.Items.Add(cost5)
        End If
    End Sub

    Private precedingButtonClicked As Boolean = False

    Private Sub checkout_Click(sender As Object, e As EventArgs) Handles checkout.Click
        finalprice = LB2.Items.Cast(Of Double).Sum
        TotalBill.Text = finalprice.ToString("C2")

        precedingButtonClicked = True
    End Sub

    Private Sub VOID_Click(sender As Object, e As EventArgs) Handles VOID.Click
        Dim selected_index As Integer = LB1.SelectedIndex
        LB1.Items.RemoveAt(selected_index)
        LB2.Items.RemoveAt(selected_index)
    End Sub

    Private Sub LB2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LB2.SelectedIndexChanged
        LB1.SelectedIndex = LB2.SelectedIndex
    End Sub

    Private Sub LB1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LB1.SelectedIndexChanged
        LB2.SelectedIndex = LB1.SelectedIndex
    End Sub

    Private Sub CO_Click(sender As Object, e As EventArgs) Handles CO.Click

        If precedingButtonClicked Then
            Me.Hide()
            Order_Summary.Show()
        Else
            MessageBox.Show("Please check your bill first!!")
        End If

        Dim taxed As Double

        For Each item_list1 As Object In LB1.Items
            Order_Summary.outlist1.Items.Add(item_list1)
        Next

        For Each item_list2 As Object In LB2.Items
            Order_Summary.outlist2.Items.Add(item_list2)
        Next

        taxed = finalprice * 0.12

        Order_Summary.b.Text = finalprice - taxed
        Order_Summary.tax.Text = taxed
        Order_Summary.tb.Text = finalprice

        Dim sum As Double = 0.0

        For Each item As Object In LB1.Items
            Dim stringValue As String = item.ToString()

            Dim numericPart As String = ExtractNumericPart(stringValue)

            Dim numericValue As Double
            If Double.TryParse(numericPart, numericValue) Then
                sum += numericValue

                Order_Summary.TextBox1.Text = sum.ToString
            End If
        Next
    End Sub

    Private Function ExtractNumericPart(input As String) As String
        Dim index As Integer = input.IndexOf(" ")

        If index >= 0 Then
            Return input.Substring(0, index).Trim()
        Else
            Return input.Trim()
        End If
    End Function
End Class