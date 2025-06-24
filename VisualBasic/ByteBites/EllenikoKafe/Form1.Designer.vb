<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.choice1 = New System.Windows.Forms.Button()
        Me.choice2 = New System.Windows.Forms.Button()
        Me.choice3 = New System.Windows.Forms.Button()
        Me.choice4 = New System.Windows.Forms.Button()
        Me.choice5 = New System.Windows.Forms.Button()
        Me.quantity1 = New System.Windows.Forms.NumericUpDown()
        Me.quantity2 = New System.Windows.Forms.NumericUpDown()
        Me.quantity3 = New System.Windows.Forms.NumericUpDown()
        Me.quantity4 = New System.Windows.Forms.NumericUpDown()
        Me.quantity5 = New System.Windows.Forms.NumericUpDown()
        Me.VOID = New System.Windows.Forms.Button()
        Me.checkout = New System.Windows.Forms.Button()
        Me.price1 = New System.Windows.Forms.Label()
        Me.price2 = New System.Windows.Forms.Label()
        Me.price3 = New System.Windows.Forms.Label()
        Me.price4 = New System.Windows.Forms.Label()
        Me.price5 = New System.Windows.Forms.Label()
        Me.LB1 = New System.Windows.Forms.ListBox()
        Me.LB2 = New System.Windows.Forms.ListBox()
        Me.total = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.quantity1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.quantity2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.quantity3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.quantity4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.quantity5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ComboBox1
        '
        Me.ComboBox1.BackColor = System.Drawing.Color.Bisque
        Me.ComboBox1.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(31, 75)
        Me.ComboBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(163, 28)
        Me.ComboBox1.TabIndex = 0
        Me.ComboBox1.Text = "Select Menu Type"
        '
        'choice1
        '
        Me.choice1.BackColor = System.Drawing.Color.Bisque
        Me.choice1.Font = New System.Drawing.Font("Lucida Calligraphy", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.choice1.Location = New System.Drawing.Point(111, 135)
        Me.choice1.Margin = New System.Windows.Forms.Padding(2)
        Me.choice1.Name = "choice1"
        Me.choice1.Size = New System.Drawing.Size(110, 47)
        Me.choice1.TabIndex = 1
        Me.choice1.UseVisualStyleBackColor = False
        '
        'choice2
        '
        Me.choice2.BackColor = System.Drawing.Color.Bisque
        Me.choice2.Font = New System.Drawing.Font("Lucida Bright", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.choice2.Location = New System.Drawing.Point(111, 200)
        Me.choice2.Margin = New System.Windows.Forms.Padding(2)
        Me.choice2.Name = "choice2"
        Me.choice2.Size = New System.Drawing.Size(110, 47)
        Me.choice2.TabIndex = 2
        Me.choice2.UseVisualStyleBackColor = False
        '
        'choice3
        '
        Me.choice3.BackColor = System.Drawing.Color.Bisque
        Me.choice3.Font = New System.Drawing.Font("Lucida Bright", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.choice3.Location = New System.Drawing.Point(111, 263)
        Me.choice3.Margin = New System.Windows.Forms.Padding(2)
        Me.choice3.Name = "choice3"
        Me.choice3.Size = New System.Drawing.Size(110, 47)
        Me.choice3.TabIndex = 3
        Me.choice3.UseVisualStyleBackColor = False
        '
        'choice4
        '
        Me.choice4.BackColor = System.Drawing.Color.Bisque
        Me.choice4.Font = New System.Drawing.Font("Lucida Bright", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.choice4.Location = New System.Drawing.Point(111, 324)
        Me.choice4.Margin = New System.Windows.Forms.Padding(2)
        Me.choice4.Name = "choice4"
        Me.choice4.Size = New System.Drawing.Size(110, 47)
        Me.choice4.TabIndex = 4
        Me.choice4.UseVisualStyleBackColor = False
        '
        'choice5
        '
        Me.choice5.BackColor = System.Drawing.Color.Bisque
        Me.choice5.Font = New System.Drawing.Font("Lucida Bright", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.choice5.Location = New System.Drawing.Point(111, 389)
        Me.choice5.Margin = New System.Windows.Forms.Padding(2)
        Me.choice5.Name = "choice5"
        Me.choice5.Size = New System.Drawing.Size(110, 47)
        Me.choice5.TabIndex = 5
        Me.choice5.UseVisualStyleBackColor = False
        '
        'quantity1
        '
        Me.quantity1.Font = New System.Drawing.Font("Lucida Bright", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.quantity1.Location = New System.Drawing.Point(31, 150)
        Me.quantity1.Margin = New System.Windows.Forms.Padding(2)
        Me.quantity1.Name = "quantity1"
        Me.quantity1.Size = New System.Drawing.Size(52, 22)
        Me.quantity1.TabIndex = 6
        '
        'quantity2
        '
        Me.quantity2.Font = New System.Drawing.Font("Lucida Bright", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.quantity2.Location = New System.Drawing.Point(31, 214)
        Me.quantity2.Margin = New System.Windows.Forms.Padding(2)
        Me.quantity2.Name = "quantity2"
        Me.quantity2.Size = New System.Drawing.Size(52, 22)
        Me.quantity2.TabIndex = 7
        '
        'quantity3
        '
        Me.quantity3.Font = New System.Drawing.Font("Lucida Bright", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.quantity3.Location = New System.Drawing.Point(31, 278)
        Me.quantity3.Margin = New System.Windows.Forms.Padding(2)
        Me.quantity3.Name = "quantity3"
        Me.quantity3.Size = New System.Drawing.Size(52, 22)
        Me.quantity3.TabIndex = 8
        '
        'quantity4
        '
        Me.quantity4.Font = New System.Drawing.Font("Lucida Bright", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.quantity4.Location = New System.Drawing.Point(31, 339)
        Me.quantity4.Margin = New System.Windows.Forms.Padding(2)
        Me.quantity4.Name = "quantity4"
        Me.quantity4.Size = New System.Drawing.Size(52, 22)
        Me.quantity4.TabIndex = 9
        '
        'quantity5
        '
        Me.quantity5.Font = New System.Drawing.Font("Lucida Bright", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.quantity5.Location = New System.Drawing.Point(31, 404)
        Me.quantity5.Margin = New System.Windows.Forms.Padding(2)
        Me.quantity5.Name = "quantity5"
        Me.quantity5.Size = New System.Drawing.Size(52, 22)
        Me.quantity5.TabIndex = 10
        '
        'VOID
        '
        Me.VOID.Location = New System.Drawing.Point(410, 438)
        Me.VOID.Margin = New System.Windows.Forms.Padding(2)
        Me.VOID.Name = "VOID"
        Me.VOID.Size = New System.Drawing.Size(107, 36)
        Me.VOID.TabIndex = 11
        Me.VOID.Text = "Button6"
        Me.VOID.UseVisualStyleBackColor = True
        '
        'checkout
        '
        Me.checkout.BackColor = System.Drawing.Color.Bisque
        Me.checkout.Font = New System.Drawing.Font("Lucida Calligraphy", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.checkout.Location = New System.Drawing.Point(532, 438)
        Me.checkout.Margin = New System.Windows.Forms.Padding(2)
        Me.checkout.Name = "checkout"
        Me.checkout.Size = New System.Drawing.Size(134, 36)
        Me.checkout.TabIndex = 12
        Me.checkout.Text = "Bill Checkout"
        Me.checkout.UseVisualStyleBackColor = False
        '
        'price1
        '
        Me.price1.AutoSize = True
        Me.price1.BackColor = System.Drawing.Color.Transparent
        Me.price1.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.price1.ForeColor = System.Drawing.Color.Snow
        Me.price1.Location = New System.Drawing.Point(274, 151)
        Me.price1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.price1.Name = "price1"
        Me.price1.Size = New System.Drawing.Size(105, 20)
        Me.price1.TabIndex = 13
        Me.price1.Text = "The price is.."
        '
        'price2
        '
        Me.price2.AutoSize = True
        Me.price2.BackColor = System.Drawing.Color.Transparent
        Me.price2.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.price2.ForeColor = System.Drawing.Color.Snow
        Me.price2.Location = New System.Drawing.Point(274, 216)
        Me.price2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.price2.Name = "price2"
        Me.price2.Size = New System.Drawing.Size(105, 20)
        Me.price2.TabIndex = 14
        Me.price2.Text = "The price is.."
        '
        'price3
        '
        Me.price3.AutoSize = True
        Me.price3.BackColor = System.Drawing.Color.Transparent
        Me.price3.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.price3.ForeColor = System.Drawing.Color.Snow
        Me.price3.Location = New System.Drawing.Point(274, 278)
        Me.price3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.price3.Name = "price3"
        Me.price3.Size = New System.Drawing.Size(105, 20)
        Me.price3.TabIndex = 15
        Me.price3.Text = "The price is.."
        '
        'price4
        '
        Me.price4.AutoSize = True
        Me.price4.BackColor = System.Drawing.Color.Transparent
        Me.price4.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.price4.ForeColor = System.Drawing.Color.Snow
        Me.price4.Location = New System.Drawing.Point(274, 339)
        Me.price4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.price4.Name = "price4"
        Me.price4.Size = New System.Drawing.Size(105, 20)
        Me.price4.TabIndex = 16
        Me.price4.Text = "The price is.."
        '
        'price5
        '
        Me.price5.AutoSize = True
        Me.price5.BackColor = System.Drawing.Color.Transparent
        Me.price5.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.price5.ForeColor = System.Drawing.Color.Snow
        Me.price5.Location = New System.Drawing.Point(274, 401)
        Me.price5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.price5.Name = "price5"
        Me.price5.Size = New System.Drawing.Size(105, 20)
        Me.price5.TabIndex = 17
        Me.price5.Text = "The price is.."
        '
        'LB1
        '
        Me.LB1.BackColor = System.Drawing.Color.Bisque
        Me.LB1.Font = New System.Drawing.Font("Lucida Bright", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LB1.FormattingEnabled = True
        Me.LB1.ItemHeight = 16
        Me.LB1.Location = New System.Drawing.Point(466, 135)
        Me.LB1.Margin = New System.Windows.Forms.Padding(2)
        Me.LB1.Name = "LB1"
        Me.LB1.Size = New System.Drawing.Size(121, 228)
        Me.LB1.TabIndex = 18
        '
        'LB2
        '
        Me.LB2.BackColor = System.Drawing.Color.Bisque
        Me.LB2.Font = New System.Drawing.Font("Lucida Bright", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LB2.FormattingEnabled = True
        Me.LB2.ItemHeight = 16
        Me.LB2.Location = New System.Drawing.Point(602, 135)
        Me.LB2.Margin = New System.Windows.Forms.Padding(2)
        Me.LB2.Name = "LB2"
        Me.LB2.Size = New System.Drawing.Size(121, 228)
        Me.LB2.TabIndex = 19
        '
        'total
        '
        Me.total.BackColor = System.Drawing.Color.Bisque
        Me.total.Font = New System.Drawing.Font("Lucida Bright", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.total.Location = New System.Drawing.Point(572, 389)
        Me.total.Margin = New System.Windows.Forms.Padding(2)
        Me.total.Name = "total"
        Me.total.Size = New System.Drawing.Size(140, 26)
        Me.total.TabIndex = 20
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Lucida Calligraphy", 31.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Bisque
        Me.Label1.Location = New System.Drawing.Point(218, 7)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(348, 56)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Elleniko Kafe"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Lucida Calligraphy", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FloralWhite
        Me.Label2.Location = New System.Drawing.Point(481, 97)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(239, 31)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Order Summary"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Lucida Calligraphy", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FloralWhite
        Me.Label3.Location = New System.Drawing.Point(482, 391)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 24)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Total:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(746, 496)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.total)
        Me.Controls.Add(Me.LB2)
        Me.Controls.Add(Me.LB1)
        Me.Controls.Add(Me.price5)
        Me.Controls.Add(Me.price4)
        Me.Controls.Add(Me.price3)
        Me.Controls.Add(Me.price2)
        Me.Controls.Add(Me.price1)
        Me.Controls.Add(Me.checkout)
        Me.Controls.Add(Me.VOID)
        Me.Controls.Add(Me.quantity5)
        Me.Controls.Add(Me.quantity4)
        Me.Controls.Add(Me.quantity3)
        Me.Controls.Add(Me.quantity2)
        Me.Controls.Add(Me.quantity1)
        Me.Controls.Add(Me.choice5)
        Me.Controls.Add(Me.choice4)
        Me.Controls.Add(Me.choice3)
        Me.Controls.Add(Me.choice2)
        Me.Controls.Add(Me.choice1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.quantity1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.quantity2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.quantity3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.quantity4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.quantity5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents choice1 As Button
    Friend WithEvents choice2 As Button
    Friend WithEvents choice3 As Button
    Friend WithEvents choice4 As Button
    Friend WithEvents choice5 As Button
    Friend WithEvents quantity1 As NumericUpDown
    Friend WithEvents quantity2 As NumericUpDown
    Friend WithEvents quantity3 As NumericUpDown
    Friend WithEvents quantity4 As NumericUpDown
    Friend WithEvents quantity5 As NumericUpDown
    Friend WithEvents VOID As Button
    Friend WithEvents checkout As Button
    Friend WithEvents price1 As Label
    Friend WithEvents price2 As Label
    Friend WithEvents price3 As Label
    Friend WithEvents price4 As Label
    Friend WithEvents price5 As Label
    Friend WithEvents LB1 As ListBox
    Friend WithEvents LB2 As ListBox
    Friend WithEvents total As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
