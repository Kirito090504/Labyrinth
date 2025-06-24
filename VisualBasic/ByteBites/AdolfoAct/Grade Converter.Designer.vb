<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GradeConverter
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GradeConverter))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.inGrade = New System.Windows.Forms.TextBox()
        Me.outGrade = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MonthDisplayToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TollGateChargeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.YearLevelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CommissionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(20, 31)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(519, 180)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(68, 237)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(169, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Student Grade:"
        '
        'inGrade
        '
        Me.inGrade.Location = New System.Drawing.Point(287, 240)
        Me.inGrade.Name = "inGrade"
        Me.inGrade.Size = New System.Drawing.Size(212, 22)
        Me.inGrade.TabIndex = 3
        '
        'outGrade
        '
        Me.outGrade.Location = New System.Drawing.Point(287, 308)
        Me.outGrade.Name = "outGrade"
        Me.outGrade.Size = New System.Drawing.Size(212, 22)
        Me.outGrade.TabIndex = 4
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.DarkGreen
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MonthDisplayToolStripMenuItem, Me.TollGateChargeToolStripMenuItem, Me.YearLevelToolStripMenuItem, Me.CommissionToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(528, 28)
        Me.MenuStrip1.TabIndex = 5
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
        'TollGateChargeToolStripMenuItem
        '
        Me.TollGateChargeToolStripMenuItem.Font = New System.Drawing.Font("Calisto MT", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TollGateChargeToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.TollGateChargeToolStripMenuItem.Name = "TollGateChargeToolStripMenuItem"
        Me.TollGateChargeToolStripMenuItem.Size = New System.Drawing.Size(132, 24)
        Me.TollGateChargeToolStripMenuItem.Text = "Toll Gate Charge"
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
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(210, 363)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(139, 31)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Calculate"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(68, 305)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 25)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Grade:"
        '
        'GradeConverter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkGreen
        Me.ClientSize = New System.Drawing.Size(528, 416)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.outGrade)
        Me.Controls.Add(Me.inGrade)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "GradeConverter"
        Me.Text = "Baliuag University Grade Converter"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents inGrade As TextBox
    Friend WithEvents outGrade As TextBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MonthDisplayToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TollGateChargeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents YearLevelToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CommissionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
End Class
