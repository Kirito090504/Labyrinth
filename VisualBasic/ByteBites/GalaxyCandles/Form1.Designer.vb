<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Name1 = New System.Windows.Forms.TextBox()
        Me.Address1 = New System.Windows.Forms.TextBox()
        Me.ContactNumber1 = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.P = New System.Windows.Forms.RadioButton()
        Me.V = New System.Windows.Forms.RadioButton()
        Me.TL = New System.Windows.Forms.RadioButton()
        Me.quantity = New System.Windows.Forms.NumericUpDown()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.LW = New System.Windows.Forms.RadioButton()
        Me.CR = New System.Windows.Forms.RadioButton()
        Me.SY = New System.Windows.Forms.RadioButton()
        Me.FB = New System.Windows.Forms.RadioButton()
        Me.Scented = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.quantity, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Name1
        '
        Me.Name1.Font = New System.Drawing.Font("Segoe Script", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name1.Location = New System.Drawing.Point(266, 57)
        Me.Name1.Name = "Name1"
        Me.Name1.Size = New System.Drawing.Size(197, 35)
        Me.Name1.TabIndex = 0
        '
        'Address1
        '
        Me.Address1.Font = New System.Drawing.Font("Segoe Script", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Address1.Location = New System.Drawing.Point(266, 113)
        Me.Address1.Name = "Address1"
        Me.Address1.Size = New System.Drawing.Size(197, 35)
        Me.Address1.TabIndex = 1
        '
        'ContactNumber1
        '
        Me.ContactNumber1.Font = New System.Drawing.Font("Segoe Script", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContactNumber1.Location = New System.Drawing.Point(266, 171)
        Me.ContactNumber1.Name = "ContactNumber1"
        Me.ContactNumber1.Size = New System.Drawing.Size(197, 35)
        Me.ContactNumber1.TabIndex = 2
        Me.ContactNumber1.Text = " "
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Name1)
        Me.GroupBox1.Controls.Add(Me.ContactNumber1)
        Me.GroupBox1.Controls.Add(Me.Address1)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe Script", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Snow
        Me.GroupBox1.Location = New System.Drawing.Point(25, 121)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(491, 237)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Customer Information"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe Print", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(36, 171)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(188, 35)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Contact Number:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe Print", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(37, 113)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 35)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Address:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe Print", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(37, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 35)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Name:"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.P)
        Me.GroupBox2.Controls.Add(Me.V)
        Me.GroupBox2.Controls.Add(Me.TL)
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe Script", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Snow
        Me.GroupBox2.Location = New System.Drawing.Point(25, 374)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(491, 236)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Candle Style"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe Print", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(366, 26)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(71, 35)
        Me.Label10.TabIndex = 7
        Me.Label10.Text = "Price:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe Print", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(353, 181)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(99, 35)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "$ 12.25"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe Print", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(353, 123)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(84, 35)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "$ 7.50"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe Print", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(353, 62)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(84, 35)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "$ 5.75"
        '
        'P
        '
        Me.P.AutoSize = True
        Me.P.Font = New System.Drawing.Font("Segoe Print", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.P.Location = New System.Drawing.Point(42, 179)
        Me.P.Name = "P"
        Me.P.Size = New System.Drawing.Size(90, 39)
        Me.P.TabIndex = 3
        Me.P.TabStop = True
        Me.P.Text = "Pillar"
        Me.P.UseVisualStyleBackColor = True
        '
        'V
        '
        Me.V.AutoSize = True
        Me.V.Font = New System.Drawing.Font("Segoe Script", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.V.Location = New System.Drawing.Point(42, 122)
        Me.V.Name = "V"
        Me.V.Size = New System.Drawing.Size(102, 36)
        Me.V.TabIndex = 2
        Me.V.TabStop = True
        Me.V.Text = "Votive"
        Me.V.UseVisualStyleBackColor = True
        '
        'TL
        '
        Me.TL.AutoSize = True
        Me.TL.Font = New System.Drawing.Font("Segoe Print", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TL.Location = New System.Drawing.Point(42, 62)
        Me.TL.Name = "TL"
        Me.TL.Size = New System.Drawing.Size(131, 39)
        Me.TL.TabIndex = 1
        Me.TL.TabStop = True
        Me.TL.Text = "Tea Light"
        Me.TL.UseVisualStyleBackColor = True
        '
        'quantity
        '
        Me.quantity.Location = New System.Drawing.Point(703, 473)
        Me.quantity.Name = "quantity"
        Me.quantity.Size = New System.Drawing.Size(114, 22)
        Me.quantity.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.LW)
        Me.GroupBox3.Controls.Add(Me.CR)
        Me.GroupBox3.Controls.Add(Me.SY)
        Me.GroupBox3.Controls.Add(Me.FB)
        Me.GroupBox3.Font = New System.Drawing.Font("Segoe Script", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.Snow
        Me.GroupBox3.Location = New System.Drawing.Point(531, 121)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(296, 237)
        Me.GroupBox3.TabIndex = 4
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Candle Color"
        '
        'LW
        '
        Me.LW.AutoSize = True
        Me.LW.Font = New System.Drawing.Font("Segoe Print", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LW.Location = New System.Drawing.Point(54, 178)
        Me.LW.Name = "LW"
        Me.LW.Size = New System.Drawing.Size(139, 39)
        Me.LW.TabIndex = 3
        Me.LW.TabStop = True
        Me.LW.Text = "Lily White"
        Me.LW.UseVisualStyleBackColor = True
        '
        'CR
        '
        Me.CR.AutoSize = True
        Me.CR.Font = New System.Drawing.Font("Segoe Print", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CR.Location = New System.Drawing.Point(54, 133)
        Me.CR.Name = "CR"
        Me.CR.Size = New System.Drawing.Size(183, 39)
        Me.CR.TabIndex = 2
        Me.CR.TabStop = True
        Me.CR.Text = "Christmas Red"
        Me.CR.UseVisualStyleBackColor = True
        '
        'SY
        '
        Me.SY.AutoSize = True
        Me.SY.Font = New System.Drawing.Font("Segoe Print", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SY.Location = New System.Drawing.Point(54, 88)
        Me.SY.Name = "SY"
        Me.SY.Size = New System.Drawing.Size(208, 39)
        Me.SY.TabIndex = 1
        Me.SY.TabStop = True
        Me.SY.Text = "Sunflower Yellow"
        Me.SY.UseVisualStyleBackColor = True
        '
        'FB
        '
        Me.FB.AutoSize = True
        Me.FB.Font = New System.Drawing.Font("Segoe Print", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FB.Location = New System.Drawing.Point(54, 43)
        Me.FB.Name = "FB"
        Me.FB.Size = New System.Drawing.Size(160, 39)
        Me.FB.TabIndex = 0
        Me.FB.TabStop = True
        Me.FB.Text = "Federal Blue"
        Me.FB.UseVisualStyleBackColor = True
        '
        'Scented
        '
        Me.Scented.AutoSize = True
        Me.Scented.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Scented.Location = New System.Drawing.Point(799, 406)
        Me.Scented.Name = "Scented"
        Me.Scented.Size = New System.Drawing.Size(18, 17)
        Me.Scented.TabIndex = 5
        Me.Scented.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Mistral", 37.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(226, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(355, 76)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Galaxy Candles"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Segoe Print", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Snow
        Me.Label5.Location = New System.Drawing.Point(533, 400)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(99, 35)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Scented:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Segoe Script", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Snow
        Me.Label6.Location = New System.Drawing.Point(533, 465)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(119, 33)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Quantity:"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Segoe Print", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(585, 541)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(198, 39)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Check Out"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(846, 622)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Scented)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.quantity)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.Text = "Galaxy's Candles"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.quantity, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Name1 As TextBox
    Friend WithEvents Address1 As TextBox
    Friend WithEvents ContactNumber1 As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents P As RadioButton
    Friend WithEvents V As RadioButton
    Friend WithEvents TL As RadioButton
    Friend WithEvents quantity As NumericUpDown
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents LW As RadioButton
    Friend WithEvents CR As RadioButton
    Friend WithEvents SY As RadioButton
    Friend WithEvents FB As RadioButton
    Friend WithEvents Scented As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
End Class
