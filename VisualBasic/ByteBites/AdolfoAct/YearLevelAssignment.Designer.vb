<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class YearLevelAssignment
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(YearLevelAssignment))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MonthDisplayToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TollGateChargeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GradeConverterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CommissionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.inYear = New System.Windows.Forms.TextBox()
        Me.outYear = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.DarkGreen
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MonthDisplayToolStripMenuItem, Me.TollGateChargeToolStripMenuItem, Me.GradeConverterToolStripMenuItem, Me.CommissionToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(523, 25)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MonthDisplayToolStripMenuItem
        '
        Me.MonthDisplayToolStripMenuItem.Font = New System.Drawing.Font("Calisto MT", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MonthDisplayToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.MonthDisplayToolStripMenuItem.Name = "MonthDisplayToolStripMenuItem"
        Me.MonthDisplayToolStripMenuItem.Size = New System.Drawing.Size(119, 21)
        Me.MonthDisplayToolStripMenuItem.Text = "Month Display"
        '
        'TollGateChargeToolStripMenuItem
        '
        Me.TollGateChargeToolStripMenuItem.Font = New System.Drawing.Font("Calisto MT", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TollGateChargeToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.TollGateChargeToolStripMenuItem.Name = "TollGateChargeToolStripMenuItem"
        Me.TollGateChargeToolStripMenuItem.Size = New System.Drawing.Size(132, 21)
        Me.TollGateChargeToolStripMenuItem.Text = "Toll Gate Charge"
        '
        'GradeConverterToolStripMenuItem
        '
        Me.GradeConverterToolStripMenuItem.Font = New System.Drawing.Font("Calisto MT", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GradeConverterToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.GradeConverterToolStripMenuItem.Name = "GradeConverterToolStripMenuItem"
        Me.GradeConverterToolStripMenuItem.Size = New System.Drawing.Size(129, 21)
        Me.GradeConverterToolStripMenuItem.Text = "Grade Converter"
        '
        'CommissionToolStripMenuItem
        '
        Me.CommissionToolStripMenuItem.Font = New System.Drawing.Font("Calisto MT", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CommissionToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.CommissionToolStripMenuItem.Name = "CommissionToolStripMenuItem"
        Me.CommissionToolStripMenuItem.Size = New System.Drawing.Size(103, 21)
        Me.CommissionToolStripMenuItem.Text = "Commission"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(78, 205)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 23)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Year Level:"
        '
        'inYear
        '
        Me.inYear.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.inYear.Location = New System.Drawing.Point(252, 205)
        Me.inYear.Name = "inYear"
        Me.inYear.Size = New System.Drawing.Size(184, 30)
        Me.inYear.TabIndex = 3
        '
        'outYear
        '
        Me.outYear.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.outYear.Location = New System.Drawing.Point(252, 262)
        Me.outYear.Name = "outYear"
        Me.outYear.Size = New System.Drawing.Size(184, 30)
        Me.outYear.TabIndex = 4
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 31)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(495, 165)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(185, 318)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(128, 39)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Assign"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(78, 262)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 23)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Category:"
        '
        'YearLevelAssignment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkGreen
        Me.ClientSize = New System.Drawing.Size(523, 381)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.outYear)
        Me.Controls.Add(Me.inYear)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "YearLevelAssignment"
        Me.Text = "Year Category"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MonthDisplayToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TollGateChargeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GradeConverterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CommissionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents inYear As TextBox
    Friend WithEvents outYear As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
End Class
