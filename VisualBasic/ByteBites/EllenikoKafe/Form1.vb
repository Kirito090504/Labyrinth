Imports System.Runtime.CompilerServices

' Hours wasted on this project: 8

Public Class Form1

    'Declaration of variables used for calculation of orders
    Dim qua1 As Double
    Dim qua2 As Double
    Dim qua3 As Double
    Dim qua4 As Double
    Dim qua5 As Double

    Dim tax1 As Double
    Dim tax2 As Double
    Dim tax3 As Double
    Dim tax4 As Double
    Dim tax5 As Double

    Dim bill1 As Double
    Dim bill2 As Double
    Dim bill3 As Double
    Dim bill4 As Double
    Dim bill5 As Double

    Dim bprice1 As Double
    Dim bprice2 As Double
    Dim bprice3 As Double
    Dim bprice4 As Double
    Dim bprice5 As Double

    Dim cost1 As Double
    Dim cost2 As Double
    Dim cost3 As Double
    Dim cost4 As Double
    Dim cost5 As Double

    Dim finalprice As Double

    Dim items(,) As String = {
            {"Pancake ", "Hotdog", "Bread", "Cake", "Egg"},
            {"Chicken", "Beef and Mushroom", "Pork Steak", "Spaghetti", "Rice"},
            {"Chicken", "Beef and Mushroom", "Pork Adobo", "Rice", "Chocolate"}
        }

    Dim item_prices(,) As Double = {
            {110.0, 40.0, 45.0, 75.0, 20.0},
            {150.0, 170.0, 120.0, 90.0, 30.0},
            {150.0, 170.0, 130.0, 30.0, 250.0}
    }

    Dim item_quantites(,) As Integer = {
            {0, 0, 0, 0, 0},
            {0, 0, 0, 0, 0},
            {0, 0, 0, 0, 0}
    }

    Dim total_prices(,) As Double = {
            {0, 0, 0, 0, 0},
            {0, 0, 0, 0, 0},
            {0, 0, 0, 0, 0}
    }

    Private Sub addOrder(button_number As Integer)
        ' Get the user inputs.
        Dim quantity_to_add As Integer = quantity1.Value
        Dim menu_type As Integer = ComboBox1.SelectedIndex

        ' Store the old order into a variable.
        Dim old_order As String = item_quantites(menu_type, button_number).ToString() & items(menu_type, button_number)
        Dim old_order_index As Integer = LB1.Items.IndexOf(old_order)

        ' Compute the new order quantity and total cost
        Dim item_price As Double = item_prices(menu_type, button_number)
        item_quantites(menu_type, button_number) += quantity_to_add
        total_prices(menu_type, button_number) = item_price * item_quantites(menu_type, button_number)

        ' Get the new order.
        Dim new_order As String = item_quantites(menu_type, button_number).ToString() & items(menu_type, button_number)

        ' Check if old order is in order list.
        If LB1.Items.Contains(old_order) Then
            LB1.Items.RemoveAt(old_order_index)
            LB2.Items.RemoveAt(old_order_index)
            LB1.Items.Add(new_order)  ' Replace old order with new order
            LB2.Items.Add(total_prices(menu_type, button_number))  ' Set the new total price.
        Else
            LB1.Items.Add(new_order)
            LB2.Items.Add(total_prices(menu_type, button_number))
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Items.Add("Breakfast")
        ComboBox1.Items.Add("Lunch")
        ComboBox1.Items.Add("Dinner")
    End Sub

    'Changes the label of buttons and display their respective prices dependent on ComboBox choice
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        choice1.Text = items(ComboBox1.SelectedIndex, 0)
        choice2.Text = items(ComboBox1.SelectedIndex, 1)
        choice3.Text = items(ComboBox1.SelectedIndex, 2)
        choice4.Text = items(ComboBox1.SelectedIndex, 3)
        choice5.Text = items(ComboBox1.SelectedIndex, 4)

        price1.Text = item_prices(ComboBox1.SelectedIndex, 0).ToString("C2")
        price2.Text = item_prices(ComboBox1.SelectedIndex, 1).ToString("C2")
        price3.Text = item_prices(ComboBox1.SelectedIndex, 2).ToString("C2")
        price4.Text = item_prices(ComboBox1.SelectedIndex, 3).ToString("C2")
        price5.Text = item_prices(ComboBox1.SelectedIndex, 4).ToString("C2")
    End Sub

    Private Sub choice1_Click(sender As Object, e As EventArgs) Handles choice1.Click
        addOrder(0)
    End Sub

    Private Sub choice2_Click(sender As Object, e As EventArgs) Handles choice2.Click
        'Double.TryParse(quantity2.Value, qua2)
        'If ComboBox1.SelectedIndex = 0 Then
        '    tax2 = (40 * qua2) * 0.12
        '    bill2 = 40 * qua2
        '    bprice2 = tax2 + bill2
        '    cost2 = bprice2.ToString

        '    ' set the text to show
        '    Dim order_text As String = qua2.ToString & "Hotdog"
        '    If LB1.Items.Contains(order_text) Then
        '        cost2 += bprice2
        '        LB2.Items.Insert(LB1.Items.IndexOf(order_text), cost2)
        '    Else
        '        LB1.Items.Add(order_text)
        '        LB2.Items.Add(cost2)
        '    End If
        'ElseIf ComboBox1.SelectedIndex = 1 Then
        '    tax2 = (170 * qua2) * 0.12
        '    bill2 = 170 * qua2
        '    bprice2 = tax2 + bill2
        '    cost2 = bprice2.ToString
        '    LB1.Items.Add(qua2.ToString & "Beef and Mushroom")
        '    LB2.Items.Add(cost2)
        'ElseIf ComboBox1.SelectedIndex = 2 Then
        '    tax2 = (170 * qua2) * 0.12
        '    bill2 = 170 * qua2
        '    bprice2 = tax2 + bill2
        '    cost2 = bprice2.ToString
        '    LB1.Items.Add(qua2.ToString & "Beef and Mushroom")
        '    LB2.Items.Add(cost2)
        'End If

        addOrder(1)
    End Sub

    Private Sub choice3_Click(sender As Object, e As EventArgs) Handles choice3.Click
        Double.TryParse(quantity3.Value, qua3)
        If ComboBox1.SelectedIndex = 0 Then
            tax3 = (45 * qua3) * 0.12
            bill3 = 45 * qua3
            bprice3 = tax3 + bill3
            cost3 = bprice3.ToString
            LB1.Items.Add(qua3.ToString & "Bread")
            LB2.Items.Add(cost3)
        ElseIf ComboBox1.SelectedIndex = 1 Then
            tax3 = (120 * qua3) * 0.12
            bill3 = 120 * qua3
            bprice3 = tax3 + bill3
            cost3 = bprice3.ToString
            LB1.Items.Add(qua3.ToString & "Pork Steak")
            LB2.Items.Add(cost3)
        ElseIf ComboBox1.SelectedIndex = 2 Then
            tax3 = (130 * qua3) * 0.12
            bill3 = 130 * qua3
            bprice3 = tax3 + bill3
            cost3 = bprice3.ToString
            LB1.Items.Add(qua3.ToString & "Pork Adobo")
            LB2.Items.Add(cost3)
        End If
    End Sub

    Private Sub choice4_Click(sender As Object, e As EventArgs) Handles choice4.Click
        Double.TryParse(quantity4.Value, qua4)
        If ComboBox1.SelectedIndex = 0 Then
            tax4 = (75 * qua4) * 0.12
            bill4 = 75 * qua4
            bprice4 = tax4 + bill4
            cost4 = bprice4.ToString
            LB1.Items.Add(qua4.ToString & "Cake")
            LB2.Items.Add(cost4)
        ElseIf ComboBox1.SelectedIndex = 1 Then
            tax4 = (90 * qua4) * 0.12
            bill4 = 90 * qua4
            bprice4 = tax4 + bill4
            cost4 = bprice4.ToString
            LB1.Items.Add(qua4.ToString & "Spaghetti")
            LB2.Items.Add(cost4)
        ElseIf ComboBox1.SelectedIndex = 2 Then
            tax4 = (30 * qua4) * 0.12
            bill4 = 30 * qua4
            bprice4 = tax4 + bill4
            cost4 = bprice4.ToString
            LB1.Items.Add(qua4.ToString & "Rice")
            LB2.Items.Add(cost4)
        End If
    End Sub

    Private Sub choice5_Click(sender As Object, e As EventArgs) Handles choice5.Click
        Double.TryParse(quantity5.Value, qua5)
        If ComboBox1.SelectedIndex = 0 Then
            tax5 = (20 * qua5) * 0.12
            bill5 = 20 * qua5
            bprice5 = tax5 + bill5
            cost5 = bprice5.ToString
            LB1.Items.Add(qua5.ToString & "Egg")
            LB2.Items.Add(cost5)
        ElseIf ComboBox1.SelectedIndex = 1 Then
            tax5 = (30 * qua5) * 0.12
            bill5 = 30 * qua5
            bprice5 = tax5 + bill5
            cost5 = bprice5.ToString
            LB1.Items.Add(qua5.ToString & "Rice")
            LB2.Items.Add(cost5)
        ElseIf ComboBox1.SelectedIndex = 2 Then
            tax5 = (250 * qua5) * 0.12
            bill5 = 250 * qua5
            bprice5 = tax5 + bill5
            cost5 = bprice5.ToString
            LB1.Items.Add(qua5.ToString & "Chocolate")
            LB2.Items.Add(cost5)
        End If
    End Sub

    Private Sub checkout_Click(sender As Object, e As EventArgs) Handles checkout.Click

        Dim total_bill As Double = 0

        For Each menu_type As Double In item_prices
            For Each order As Double In item_prices
                total_bill += order
            Next
        Next

        total.Text = total_bill.ToString("C2")
    End Sub

    Private Sub VOID_Click(sender As Object, e As EventArgs) Handles VOID.Click
        Dim selected_index As Integer = LB1.SelectedIndex
        LB1.Items.RemoveAt(selected_index)
        LB2.Items.RemoveAt(selected_index)
    End Sub
End Class