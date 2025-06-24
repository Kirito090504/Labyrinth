<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Reservation_Form
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Reservation_Form))
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.quantity = New System.Windows.Forms.TextBox()
        Me.CB1 = New System.Windows.Forms.CheckBox()
        Me.CB2 = New System.Windows.Forms.CheckBox()
        Me.CB3 = New System.Windows.Forms.CheckBox()
        Me.CB4 = New System.Windows.Forms.CheckBox()
        Me.FindCost = New System.Windows.Forms.Button()
        Me.clr = New System.Windows.Forms.Button()
        Me.totalbill = New System.Windows.Forms.Label()
        Me.length = New System.Windows.Forms.Label()
        Me.LB1 = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ComboBox1
        '
        Me.ComboBox1.BackColor = System.Drawing.Color.LightCyan
        Me.ComboBox1.Font = New System.Drawing.Font("Lucida Bright", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(147, 35)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(188, 28)
        Me.ComboBox1.TabIndex = 0
        '
        'quantity
        '
        Me.quantity.BackColor = System.Drawing.Color.LightCyan
        Me.quantity.Font = New System.Drawing.Font("Lucida Bright", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.quantity.Location = New System.Drawing.Point(41, 145)
        Me.quantity.Name = "quantity"
        Me.quantity.Size = New System.Drawing.Size(143, 28)
        Me.quantity.TabIndex = 1
        Me.quantity.Visible = False
        '
        'CB1
        '
        Me.CB1.AutoSize = True
        Me.CB1.BackColor = System.Drawing.Color.Transparent
        Me.CB1.Font = New System.Drawing.Font("Lucida Calligraphy", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CB1.ForeColor = System.Drawing.Color.White
        Me.CB1.Location = New System.Drawing.Point(274, 146)
        Me.CB1.Name = "CB1"
        Me.CB1.Size = New System.Drawing.Size(135, 27)
        Me.CB1.TabIndex = 2
        Me.CB1.Text = "CheckBox1"
        Me.CB1.UseVisualStyleBackColor = False
        Me.CB1.Visible = False
        '
        'CB2
        '
        Me.CB2.AutoSize = True
        Me.CB2.BackColor = System.Drawing.Color.Transparent
        Me.CB2.Font = New System.Drawing.Font("Lucida Calligraphy", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CB2.ForeColor = System.Drawing.Color.White
        Me.CB2.Location = New System.Drawing.Point(274, 185)
        Me.CB2.Name = "CB2"
        Me.CB2.Size = New System.Drawing.Size(138, 27)
        Me.CB2.TabIndex = 3
        Me.CB2.Text = "CheckBox2"
        Me.CB2.UseVisualStyleBackColor = False
        Me.CB2.Visible = False
        '
        'CB3
        '
        Me.CB3.AutoSize = True
        Me.CB3.BackColor = System.Drawing.Color.Transparent
        Me.CB3.Font = New System.Drawing.Font("Lucida Calligraphy", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CB3.ForeColor = System.Drawing.Color.White
        Me.CB3.Location = New System.Drawing.Point(274, 227)
        Me.CB3.Name = "CB3"
        Me.CB3.Size = New System.Drawing.Size(137, 27)
        Me.CB3.TabIndex = 4
        Me.CB3.Text = "CheckBox3"
        Me.CB3.UseVisualStyleBackColor = False
        Me.CB3.Visible = False
        '
        'CB4
        '
        Me.CB4.AutoSize = True
        Me.CB4.BackColor = System.Drawing.Color.Transparent
        Me.CB4.Font = New System.Drawing.Font("Lucida Calligraphy", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CB4.ForeColor = System.Drawing.Color.White
        Me.CB4.Location = New System.Drawing.Point(274, 270)
        Me.CB4.Name = "CB4"
        Me.CB4.Size = New System.Drawing.Size(139, 27)
        Me.CB4.TabIndex = 5
        Me.CB4.Text = "CheckBox4"
        Me.CB4.UseVisualStyleBackColor = False
        Me.CB4.Visible = False
        '
        'FindCost
        '
        Me.FindCost.BackColor = System.Drawing.Color.LightCyan
        Me.FindCost.Font = New System.Drawing.Font("Lucida Bright", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FindCost.Location = New System.Drawing.Point(95, 332)
        Me.FindCost.Name = "FindCost"
        Me.FindCost.Size = New System.Drawing.Size(117, 40)
        Me.FindCost.TabIndex = 6
        Me.FindCost.Text = "Find Cost"
        Me.FindCost.UseVisualStyleBackColor = False
        Me.FindCost.Visible = False
        '
        'clr
        '
        Me.clr.BackColor = System.Drawing.Color.LightCyan
        Me.clr.Font = New System.Drawing.Font("Lucida Bright", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clr.Location = New System.Drawing.Point(259, 332)
        Me.clr.Name = "clr"
        Me.clr.Size = New System.Drawing.Size(117, 40)
        Me.clr.TabIndex = 7
        Me.clr.Text = "Clear"
        Me.clr.UseVisualStyleBackColor = False
        Me.clr.Visible = False
        '
        'totalbill
        '
        Me.totalbill.AutoSize = True
        Me.totalbill.BackColor = System.Drawing.Color.Transparent
        Me.totalbill.Font = New System.Drawing.Font("Lucida Bright", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totalbill.ForeColor = System.Drawing.Color.White
        Me.totalbill.Location = New System.Drawing.Point(255, 565)
        Me.totalbill.Name = "totalbill"
        Me.totalbill.Size = New System.Drawing.Size(0, 20)
        Me.totalbill.TabIndex = 9
        Me.totalbill.Visible = False
        '
        'length
        '
        Me.length.AutoSize = True
        Me.length.BackColor = System.Drawing.Color.Transparent
        Me.length.Font = New System.Drawing.Font("Lucida Bright", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.length.ForeColor = System.Drawing.Color.White
        Me.length.Location = New System.Drawing.Point(255, 608)
        Me.length.Name = "length"
        Me.length.Size = New System.Drawing.Size(0, 20)
        Me.length.TabIndex = 10
        Me.length.Visible = False
        '
        'LB1
        '
        Me.LB1.BackColor = System.Drawing.Color.LightCyan
        Me.LB1.Font = New System.Drawing.Font("Lucida Bright", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LB1.FormattingEnabled = True
        Me.LB1.ItemHeight = 20
        Me.LB1.Location = New System.Drawing.Point(223, 404)
        Me.LB1.Name = "LB1"
        Me.LB1.Size = New System.Drawing.Size(186, 144)
        Me.LB1.TabIndex = 11
        Me.LB1.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Lucida Calligraphy", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(50, 106)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(122, 23)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "No. of Pax"
        Me.Label1.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Lucida Calligraphy", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(73, 463)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 23)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Tour:"
        Me.Label2.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Lucida Calligraphy", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(73, 564)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 23)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Cost:"
        Me.Label3.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Lucida Calligraphy", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(73, 605)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 23)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Length:"
        Me.Label4.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Lucida Calligraphy", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(255, 106)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(174, 23)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Select Iteneray:"
        Me.Label5.Visible = False
        '
        'Reservation_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(482, 637)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.CB4)
        Me.Controls.Add(Me.CB3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.CB2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.CB1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LB1)
        Me.Controls.Add(Me.length)
        Me.Controls.Add(Me.totalbill)
        Me.Controls.Add(Me.clr)
        Me.Controls.Add(Me.FindCost)
        Me.Controls.Add(Me.quantity)
        Me.Controls.Add(Me.ComboBox1)
        Me.Name = "Reservation_Form"
        Me.Text = "Reservation Form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents quantity As TextBox
    Friend WithEvents CB1 As CheckBox
    Friend WithEvents CB2 As CheckBox
    Friend WithEvents CB3 As CheckBox
    Friend WithEvents CB4 As CheckBox
    Friend WithEvents FindCost As Button
    Friend WithEvents clr As Button
    Friend WithEvents totalbill As Label
    Friend WithEvents length As Label
    Friend WithEvents LB1 As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
End Class
