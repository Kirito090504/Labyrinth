<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Commission
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Commission))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MonthDisplayToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TollGateChargeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GradeConverterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.YearLevelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.inSale = New System.Windows.Forms.TextBox()
        Me.outSale = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.SlateBlue
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MonthDisplayToolStripMenuItem, Me.TollGateChargeToolStripMenuItem, Me.GradeConverterToolStripMenuItem, Me.YearLevelToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(484, 30)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MonthDisplayToolStripMenuItem
        '
        Me.MonthDisplayToolStripMenuItem.Font = New System.Drawing.Font("Calisto MT", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MonthDisplayToolStripMenuItem.ForeColor = System.Drawing.Color.Snow
        Me.MonthDisplayToolStripMenuItem.Name = "MonthDisplayToolStripMenuItem"
        Me.MonthDisplayToolStripMenuItem.Size = New System.Drawing.Size(119, 26)
        Me.MonthDisplayToolStripMenuItem.Text = "Month Display"
        '
        'TollGateChargeToolStripMenuItem
        '
        Me.TollGateChargeToolStripMenuItem.Font = New System.Drawing.Font("Calisto MT", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TollGateChargeToolStripMenuItem.ForeColor = System.Drawing.Color.Snow
        Me.TollGateChargeToolStripMenuItem.Name = "TollGateChargeToolStripMenuItem"
        Me.TollGateChargeToolStripMenuItem.Size = New System.Drawing.Size(132, 26)
        Me.TollGateChargeToolStripMenuItem.Text = "Toll Gate Charge"
        '
        'GradeConverterToolStripMenuItem
        '
        Me.GradeConverterToolStripMenuItem.Font = New System.Drawing.Font("Calisto MT", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GradeConverterToolStripMenuItem.ForeColor = System.Drawing.Color.Snow
        Me.GradeConverterToolStripMenuItem.Name = "GradeConverterToolStripMenuItem"
        Me.GradeConverterToolStripMenuItem.Size = New System.Drawing.Size(129, 26)
        Me.GradeConverterToolStripMenuItem.Text = "Grade Converter"
        '
        'YearLevelToolStripMenuItem
        '
        Me.YearLevelToolStripMenuItem.Font = New System.Drawing.Font("Calisto MT", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.YearLevelToolStripMenuItem.ForeColor = System.Drawing.Color.Snow
        Me.YearLevelToolStripMenuItem.Name = "YearLevelToolStripMenuItem"
        Me.YearLevelToolStripMenuItem.Size = New System.Drawing.Size(92, 26)
        Me.YearLevelToolStripMenuItem.Text = "Year Level"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(30, 73)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(126, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Total Sales:"
        '
        'inSale
        '
        Me.inSale.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.inSale.Location = New System.Drawing.Point(247, 73)
        Me.inSale.Name = "inSale"
        Me.inSale.Size = New System.Drawing.Size(225, 30)
        Me.inSale.TabIndex = 2
        '
        'outSale
        '
        Me.outSale.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.outSale.Location = New System.Drawing.Point(247, 143)
        Me.outSale.Name = "outSale"
        Me.outSale.Size = New System.Drawing.Size(225, 30)
        Me.outSale.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button1.Location = New System.Drawing.Point(179, 203)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(120, 42)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Compute"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(30, 146)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(196, 25)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Total Commission:"
        '
        'Commission
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(484, 257)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.outSale)
        Me.Controls.Add(Me.inSale)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.ForeColor = System.Drawing.Color.Coral
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Commission"
        Me.Text = "Sales Commission"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MonthDisplayToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TollGateChargeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GradeConverterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents YearLevelToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents inSale As TextBox
    Friend WithEvents outSale As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
End Class
