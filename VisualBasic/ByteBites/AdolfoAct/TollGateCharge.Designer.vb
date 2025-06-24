<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TollGateCharge
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TollGateCharge))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Bus = New System.Windows.Forms.RadioButton()
        Me.LightTruck = New System.Windows.Forms.RadioButton()
        Me.Car = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.red = New System.Windows.Forms.RadioButton()
        Me.blue = New System.Windows.Forms.RadioButton()
        Me.yellow = New System.Windows.Forms.RadioButton()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MonthDisplayToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GradeConverterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.YearLevelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CommissionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.total_bill = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.PictureBox3)
        Me.GroupBox1.Controls.Add(Me.PictureBox2)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.Bus)
        Me.GroupBox1.Controls.Add(Me.LightTruck)
        Me.GroupBox1.Controls.Add(Me.Car)
        Me.GroupBox1.Font = New System.Drawing.Font("Stencil", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(19, 47)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(425, 312)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Vehicle Type"
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(6, 209)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(191, 97)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 5
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(6, 107)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(191, 97)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 4
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(32, 29)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(127, 72)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'Bus
        '
        Me.Bus.AutoSize = True
        Me.Bus.Font = New System.Drawing.Font("Calisto MT", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bus.ForeColor = System.Drawing.Color.White
        Me.Bus.Location = New System.Drawing.Point(213, 250)
        Me.Bus.Name = "Bus"
        Me.Bus.Size = New System.Drawing.Size(210, 30)
        Me.Bus.TabIndex = 2
        Me.Bus.TabStop = True
        Me.Bus.Text = "Bus/Heavy Truck"
        Me.Bus.UseVisualStyleBackColor = True
        '
        'LightTruck
        '
        Me.LightTruck.AutoSize = True
        Me.LightTruck.Font = New System.Drawing.Font("Calisto MT", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LightTruck.ForeColor = System.Drawing.Color.White
        Me.LightTruck.Location = New System.Drawing.Point(213, 143)
        Me.LightTruck.Name = "LightTruck"
        Me.LightTruck.Size = New System.Drawing.Size(149, 30)
        Me.LightTruck.TabIndex = 1
        Me.LightTruck.TabStop = True
        Me.LightTruck.Text = "Light Truck"
        Me.LightTruck.UseVisualStyleBackColor = True
        '
        'Car
        '
        Me.Car.AutoSize = True
        Me.Car.Font = New System.Drawing.Font("Calisto MT", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Car.ForeColor = System.Drawing.Color.White
        Me.Car.Location = New System.Drawing.Point(213, 48)
        Me.Car.Name = "Car"
        Me.Car.Size = New System.Drawing.Size(69, 30)
        Me.Car.TabIndex = 0
        Me.Car.TabStop = True
        Me.Car.Text = "Car"
        Me.Car.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.PictureBox6)
        Me.GroupBox2.Controls.Add(Me.PictureBox5)
        Me.GroupBox2.Controls.Add(Me.PictureBox4)
        Me.GroupBox2.Controls.Add(Me.red)
        Me.GroupBox2.Controls.Add(Me.blue)
        Me.GroupBox2.Controls.Add(Me.yellow)
        Me.GroupBox2.Font = New System.Drawing.Font("Stencil", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(19, 376)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(425, 240)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Ticket Type"
        '
        'PictureBox6
        '
        Me.PictureBox6.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), System.Drawing.Image)
        Me.PictureBox6.Location = New System.Drawing.Point(21, 168)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(191, 72)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox6.TabIndex = 8
        Me.PictureBox6.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(21, 99)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(191, 72)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox5.TabIndex = 7
        Me.PictureBox5.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(21, 30)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(191, 72)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox4.TabIndex = 6
        Me.PictureBox4.TabStop = False
        '
        'red
        '
        Me.red.AutoSize = True
        Me.red.Font = New System.Drawing.Font("Calisto MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.red.Location = New System.Drawing.Point(258, 193)
        Me.red.Name = "red"
        Me.red.Size = New System.Drawing.Size(65, 27)
        Me.red.TabIndex = 2
        Me.red.TabStop = True
        Me.red.Text = "Red"
        Me.red.UseVisualStyleBackColor = True
        '
        'blue
        '
        Me.blue.AutoSize = True
        Me.blue.Font = New System.Drawing.Font("Calisto MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.blue.Location = New System.Drawing.Point(254, 120)
        Me.blue.Name = "blue"
        Me.blue.Size = New System.Drawing.Size(69, 27)
        Me.blue.TabIndex = 1
        Me.blue.TabStop = True
        Me.blue.Text = "Blue"
        Me.blue.UseVisualStyleBackColor = True
        '
        'yellow
        '
        Me.yellow.AutoSize = True
        Me.yellow.Font = New System.Drawing.Font("Calisto MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.yellow.Location = New System.Drawing.Point(254, 45)
        Me.yellow.Name = "yellow"
        Me.yellow.Size = New System.Drawing.Size(91, 27)
        Me.yellow.TabIndex = 0
        Me.yellow.TabStop = True
        Me.yellow.Text = "Yellow"
        Me.yellow.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.DimGray
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MonthDisplayToolStripMenuItem, Me.GradeConverterToolStripMenuItem, Me.YearLevelToolStripMenuItem, Me.CommissionToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(469, 28)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MonthDisplayToolStripMenuItem
        '
        Me.MonthDisplayToolStripMenuItem.Font = New System.Drawing.Font("Calisto MT", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MonthDisplayToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.MonthDisplayToolStripMenuItem.Name = "MonthDisplayToolStripMenuItem"
        Me.MonthDisplayToolStripMenuItem.Size = New System.Drawing.Size(119, 24)
        Me.MonthDisplayToolStripMenuItem.Text = "Month Display"
        '
        'GradeConverterToolStripMenuItem
        '
        Me.GradeConverterToolStripMenuItem.Font = New System.Drawing.Font("Calisto MT", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GradeConverterToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.GradeConverterToolStripMenuItem.Name = "GradeConverterToolStripMenuItem"
        Me.GradeConverterToolStripMenuItem.Size = New System.Drawing.Size(129, 24)
        Me.GradeConverterToolStripMenuItem.Text = "Grade Converter"
        '
        'YearLevelToolStripMenuItem
        '
        Me.YearLevelToolStripMenuItem.Font = New System.Drawing.Font("Calisto MT", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.YearLevelToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.YearLevelToolStripMenuItem.Name = "YearLevelToolStripMenuItem"
        Me.YearLevelToolStripMenuItem.Size = New System.Drawing.Size(92, 24)
        Me.YearLevelToolStripMenuItem.Text = "Year Level"
        '
        'CommissionToolStripMenuItem
        '
        Me.CommissionToolStripMenuItem.Font = New System.Drawing.Font("Calisto MT", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CommissionToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.CommissionToolStripMenuItem.Name = "CommissionToolStripMenuItem"
        Me.CommissionToolStripMenuItem.Size = New System.Drawing.Size(103, 24)
        Me.CommissionToolStripMenuItem.Text = "Commission"
        '
        'total_bill
        '
        Me.total_bill.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.total_bill.Location = New System.Drawing.Point(237, 626)
        Me.total_bill.Name = "total_bill"
        Me.total_bill.Size = New System.Drawing.Size(207, 34)
        Me.total_bill.TabIndex = 4
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Calisto MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(19, 622)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(126, 38)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "ENTER"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TollGateCharge
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(469, 684)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.total_bill)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "TollGateCharge"
        Me.Text = "Toll Gate Charge"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Bus As RadioButton
    Friend WithEvents LightTruck As RadioButton
    Friend WithEvents Car As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents blue As RadioButton
    Friend WithEvents yellow As RadioButton
    Friend WithEvents red As RadioButton
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MonthDisplayToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GradeConverterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents YearLevelToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CommissionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents total_bill As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
End Class
