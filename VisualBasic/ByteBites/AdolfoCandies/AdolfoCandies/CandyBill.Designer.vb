<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CandyBill
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CandyBill))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.inCA = New System.Windows.Forms.TextBox()
        Me.inCB = New System.Windows.Forms.TextBox()
        Me.inCC = New System.Windows.Forms.TextBox()
        Me.inCD = New System.Windows.Forms.TextBox()
        Me.BttnCompute = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Total = New System.Windows.Forms.Label()
        Me.AKG = New System.Windows.Forms.NumericUpDown()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.BKG = New System.Windows.Forms.NumericUpDown()
        Me.CKG = New System.Windows.Forms.NumericUpDown()
        Me.DKG = New System.Windows.Forms.NumericUpDown()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        CType(Me.AKG, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BKG, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CKG, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DKG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Italic)
        Me.Label1.Location = New System.Drawing.Point(47, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(123, 37)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Candy A:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 9.75!)
        Me.Label2.Location = New System.Drawing.Point(57, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 21)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Php42.25/kg"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Italic)
        Me.Label3.Location = New System.Drawing.Point(47, 140)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(122, 37)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Candy B:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 9.75!)
        Me.Label4.Location = New System.Drawing.Point(57, 177)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 21)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Php36.75/kg"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calibri", 9.75!)
        Me.Label5.Location = New System.Drawing.Point(57, 356)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 21)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Php29.50/kg"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Italic)
        Me.Label6.Location = New System.Drawing.Point(47, 319)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(124, 37)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Candy D:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Italic)
        Me.Label7.Location = New System.Drawing.Point(47, 231)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(122, 37)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Candy C:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Calibri", 9.75!)
        Me.Label8.Location = New System.Drawing.Point(57, 268)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(100, 21)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Php48.00/kg"
        '
        'inCA
        '
        Me.inCA.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.inCA.Location = New System.Drawing.Point(424, 69)
        Me.inCA.Name = "inCA"
        Me.inCA.Size = New System.Drawing.Size(181, 26)
        Me.inCA.TabIndex = 9
        '
        'inCB
        '
        Me.inCB.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.inCB.Location = New System.Drawing.Point(424, 155)
        Me.inCB.Name = "inCB"
        Me.inCB.Size = New System.Drawing.Size(181, 26)
        Me.inCB.TabIndex = 10
        '
        'inCC
        '
        Me.inCC.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.inCC.Location = New System.Drawing.Point(424, 246)
        Me.inCC.Name = "inCC"
        Me.inCC.Size = New System.Drawing.Size(181, 26)
        Me.inCC.TabIndex = 11
        '
        'inCD
        '
        Me.inCD.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.inCD.Location = New System.Drawing.Point(424, 329)
        Me.inCD.Name = "inCD"
        Me.inCD.Size = New System.Drawing.Size(181, 26)
        Me.inCD.TabIndex = 12
        '
        'BttnCompute
        '
        Me.BttnCompute.Font = New System.Drawing.Font("Calibri", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BttnCompute.Location = New System.Drawing.Point(61, 409)
        Me.BttnCompute.Name = "BttnCompute"
        Me.BttnCompute.Size = New System.Drawing.Size(210, 51)
        Me.BttnCompute.TabIndex = 13
        Me.BttnCompute.Text = "COMPUTE"
        Me.BttnCompute.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Calibri", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(304, 414)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(140, 40)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Total Bill:"
        '
        'Total
        '
        Me.Total.AutoSize = True
        Me.Total.Font = New System.Drawing.Font("Calibri", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Total.Location = New System.Drawing.Point(441, 414)
        Me.Total.Name = "Total"
        Me.Total.Size = New System.Drawing.Size(68, 40)
        Me.Total.TabIndex = 15
        Me.Total.Text = "Php"
        '
        'AKG
        '
        Me.AKG.DecimalPlaces = 2
        Me.AKG.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AKG.Increment = New Decimal(New Integer() {25, 0, 0, 131072})
        Me.AKG.Location = New System.Drawing.Point(209, 64)
        Me.AKG.Name = "AKG"
        Me.AKG.Size = New System.Drawing.Size(120, 27)
        Me.AKG.TabIndex = 16
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Calibri", 11.0!)
        Me.Label10.Location = New System.Drawing.Point(335, 65)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(28, 23)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "kg"
        '
        'BKG
        '
        Me.BKG.DecimalPlaces = 2
        Me.BKG.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BKG.Increment = New Decimal(New Integer() {25, 0, 0, 131072})
        Me.BKG.Location = New System.Drawing.Point(209, 156)
        Me.BKG.Name = "BKG"
        Me.BKG.Size = New System.Drawing.Size(120, 27)
        Me.BKG.TabIndex = 21
        '
        'CKG
        '
        Me.CKG.DecimalPlaces = 2
        Me.CKG.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.CKG.Increment = New Decimal(New Integer() {25, 0, 0, 131072})
        Me.CKG.Location = New System.Drawing.Point(209, 242)
        Me.CKG.Name = "CKG"
        Me.CKG.Size = New System.Drawing.Size(120, 26)
        Me.CKG.TabIndex = 22
        '
        'DKG
        '
        Me.DKG.DecimalPlaces = 2
        Me.DKG.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.DKG.Increment = New Decimal(New Integer() {25, 0, 0, 131072})
        Me.DKG.Location = New System.Drawing.Point(209, 330)
        Me.DKG.Name = "DKG"
        Me.DKG.Size = New System.Drawing.Size(120, 26)
        Me.DKG.TabIndex = 23
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Calibri", 11.0!)
        Me.Label11.Location = New System.Drawing.Point(335, 160)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(28, 23)
        Me.Label11.TabIndex = 24
        Me.Label11.Text = "kg"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Calibri", 11.0!)
        Me.Label12.Location = New System.Drawing.Point(335, 242)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(28, 23)
        Me.Label12.TabIndex = 25
        Me.Label12.Text = "kg"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Calibri", 11.0!)
        Me.Label13.Location = New System.Drawing.Point(335, 333)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(28, 23)
        Me.Label13.TabIndex = 26
        Me.Label13.Text = "kg"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightPink
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(667, 516)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.DKG)
        Me.Controls.Add(Me.CKG)
        Me.Controls.Add(Me.BKG)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.AKG)
        Me.Controls.Add(Me.Total)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.BttnCompute)
        Me.Controls.Add(Me.inCD)
        Me.Controls.Add(Me.inCC)
        Me.Controls.Add(Me.inCB)
        Me.Controls.Add(Me.inCA)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.Color.Black
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Candy Bill Calculator"
        CType(Me.AKG, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BKG, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CKG, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DKG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents inCA As TextBox
    Friend WithEvents inCB As TextBox
    Friend WithEvents inCC As TextBox
    Friend WithEvents inCD As TextBox
    Friend WithEvents BttnCompute As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents Total As Label
    Friend WithEvents AKG As NumericUpDown
    Friend WithEvents Label10 As Label
    Friend WithEvents BKG As NumericUpDown
    Friend WithEvents CKG As NumericUpDown
    Friend WithEvents DKG As NumericUpDown
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
End Class
