<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HomeScreen
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HomeScreen))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FeaturedPlaysToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.LionKingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LesMiserablesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PhantomOfTheOperaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.quantity = New System.Windows.Forms.TextBox()
        Me.compute = New System.Windows.Forms.Button()
        Me.clear = New System.Windows.Forms.Button()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.total = New System.Windows.Forms.Label()
        Me.tax = New System.Windows.Forms.Label()
        Me.subtotal = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Lucida Calligraphy", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Snow
        Me.Label1.Location = New System.Drawing.Point(12, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(484, 48)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Broadway Ticket Play"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.DarkRed
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FeaturedPlaysToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(515, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FeaturedPlaysToolStripMenuItem
        '
        Me.FeaturedPlaysToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LionKingToolStripMenuItem, Me.LesMiserablesToolStripMenuItem, Me.PhantomOfTheOperaToolStripMenuItem})
        Me.FeaturedPlaysToolStripMenuItem.ForeColor = System.Drawing.Color.Snow
        Me.FeaturedPlaysToolStripMenuItem.Name = "FeaturedPlaysToolStripMenuItem"
        Me.FeaturedPlaysToolStripMenuItem.Size = New System.Drawing.Size(95, 20)
        Me.FeaturedPlaysToolStripMenuItem.Text = "Featured Plays"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.ForeColor = System.Drawing.Color.Snow
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(38, 20)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'ComboBox1
        '
        Me.ComboBox1.Font = New System.Drawing.Font("Lucida Bright", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(174, 105)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(150, 25)
        Me.ComboBox1.TabIndex = 2
        Me.ComboBox1.Text = "Select Play"
        '
        'LionKingToolStripMenuItem
        '
        Me.LionKingToolStripMenuItem.Name = "LionKingToolStripMenuItem"
        Me.LionKingToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
        Me.LionKingToolStripMenuItem.Text = "Lion King"
        '
        'LesMiserablesToolStripMenuItem
        '
        Me.LesMiserablesToolStripMenuItem.Name = "LesMiserablesToolStripMenuItem"
        Me.LesMiserablesToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
        Me.LesMiserablesToolStripMenuItem.Text = "Les Miserables"
        '
        'PhantomOfTheOperaToolStripMenuItem
        '
        Me.PhantomOfTheOperaToolStripMenuItem.Name = "PhantomOfTheOperaToolStripMenuItem"
        Me.PhantomOfTheOperaToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
        Me.PhantomOfTheOperaToolStripMenuItem.Text = "Phantom of the Opera"
        '
        'quantity
        '
        Me.quantity.Font = New System.Drawing.Font("Lucida Bright", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.quantity.Location = New System.Drawing.Point(235, 154)
        Me.quantity.Name = "quantity"
        Me.quantity.Size = New System.Drawing.Size(89, 23)
        Me.quantity.TabIndex = 3
        Me.quantity.Visible = False
        '
        'compute
        '
        Me.compute.Font = New System.Drawing.Font("Lucida Bright", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.compute.Location = New System.Drawing.Point(245, 214)
        Me.compute.Name = "compute"
        Me.compute.Size = New System.Drawing.Size(92, 42)
        Me.compute.TabIndex = 4
        Me.compute.Text = "Compute"
        Me.compute.UseVisualStyleBackColor = True
        Me.compute.Visible = False
        '
        'clear
        '
        Me.clear.Font = New System.Drawing.Font("Lucida Bright", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clear.Location = New System.Drawing.Point(355, 214)
        Me.clear.Name = "clear"
        Me.clear.Size = New System.Drawing.Size(92, 39)
        Me.clear.TabIndex = 5
        Me.clear.Text = "Clear"
        Me.clear.UseVisualStyleBackColor = True
        Me.clear.Visible = False
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.BackColor = System.Drawing.Color.Transparent
        Me.RadioButton1.Font = New System.Drawing.Font("Lucida Bright", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton1.ForeColor = System.Drawing.Color.Snow
        Me.RadioButton1.Location = New System.Drawing.Point(64, 214)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(98, 19)
        Me.RadioButton1.TabIndex = 6
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Orchestra "
        Me.RadioButton1.UseVisualStyleBackColor = False
        Me.RadioButton1.Visible = False
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.BackColor = System.Drawing.Color.Transparent
        Me.RadioButton2.Font = New System.Drawing.Font("Lucida Bright", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton2.ForeColor = System.Drawing.Color.Snow
        Me.RadioButton2.Location = New System.Drawing.Point(64, 247)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(96, 19)
        Me.RadioButton2.TabIndex = 7
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Mezzanine"
        Me.RadioButton2.UseVisualStyleBackColor = False
        Me.RadioButton2.Visible = False
        '
        'total
        '
        Me.total.AutoSize = True
        Me.total.BackColor = System.Drawing.Color.Transparent
        Me.total.Font = New System.Drawing.Font("Lucida Bright", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.total.ForeColor = System.Drawing.Color.Snow
        Me.total.Location = New System.Drawing.Point(255, 283)
        Me.total.Name = "total"
        Me.total.Size = New System.Drawing.Size(0, 15)
        Me.total.TabIndex = 8
        Me.total.Visible = False
        '
        'tax
        '
        Me.tax.AutoSize = True
        Me.tax.BackColor = System.Drawing.Color.Transparent
        Me.tax.Font = New System.Drawing.Font("Lucida Bright", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tax.ForeColor = System.Drawing.Color.Snow
        Me.tax.Location = New System.Drawing.Point(255, 312)
        Me.tax.Name = "tax"
        Me.tax.Size = New System.Drawing.Size(0, 15)
        Me.tax.TabIndex = 9
        Me.tax.Visible = False
        '
        'subtotal
        '
        Me.subtotal.AutoSize = True
        Me.subtotal.BackColor = System.Drawing.Color.Transparent
        Me.subtotal.Font = New System.Drawing.Font("Lucida Bright", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.subtotal.ForeColor = System.Drawing.Color.Snow
        Me.subtotal.Location = New System.Drawing.Point(255, 344)
        Me.subtotal.Name = "subtotal"
        Me.subtotal.Size = New System.Drawing.Size(0, 15)
        Me.subtotal.TabIndex = 10
        Me.subtotal.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Lucida Bright", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Snow
        Me.Label2.Location = New System.Drawing.Point(171, 283)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 15)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Total:"
        Me.Label2.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Lucida Bright", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Snow
        Me.Label3.Location = New System.Drawing.Point(171, 312)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 15)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Tax:"
        Me.Label3.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Lucida Bright", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Snow
        Me.Label4.Location = New System.Drawing.Point(171, 344)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 15)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Sub Total:"
        Me.Label4.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Lucida Bright", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Snow
        Me.Label5.Location = New System.Drawing.Point(181, 155)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(36, 17)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Pax:"
        Me.Label5.Visible = False
        '
        'HomeScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(515, 378)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.subtotal)
        Me.Controls.Add(Me.tax)
        Me.Controls.Add(Me.total)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.clear)
        Me.Controls.Add(Me.compute)
        Me.Controls.Add(Me.quantity)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "HomeScreen"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FeaturedPlaysToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents LionKingToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LesMiserablesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PhantomOfTheOperaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents quantity As TextBox
    Friend WithEvents compute As Button
    Friend WithEvents clear As Button
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents total As Label
    Friend WithEvents tax As Label
    Friend WithEvents subtotal As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
End Class
