<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProjectA
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
        Me.priceofunit = New System.Windows.Forms.TextBox()
        Me.fullcost = New System.Windows.Forms.TextBox()
        Me.discount = New System.Windows.Forms.TextBox()
        Me.totalbill = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.quantity = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'priceofunit
        '
        Me.priceofunit.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.priceofunit.Location = New System.Drawing.Point(253, 64)
        Me.priceofunit.Name = "priceofunit"
        Me.priceofunit.Size = New System.Drawing.Size(142, 28)
        Me.priceofunit.TabIndex = 0
        '
        'fullcost
        '
        Me.fullcost.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fullcost.Location = New System.Drawing.Point(252, 170)
        Me.fullcost.Name = "fullcost"
        Me.fullcost.Size = New System.Drawing.Size(141, 28)
        Me.fullcost.TabIndex = 1
        '
        'discount
        '
        Me.discount.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.discount.Location = New System.Drawing.Point(253, 225)
        Me.discount.Name = "discount"
        Me.discount.Size = New System.Drawing.Size(140, 28)
        Me.discount.TabIndex = 2
        '
        'totalbill
        '
        Me.totalbill.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totalbill.Location = New System.Drawing.Point(251, 287)
        Me.totalbill.Name = "totalbill"
        Me.totalbill.Size = New System.Drawing.Size(142, 28)
        Me.totalbill.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Button1.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(146, 342)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(110, 43)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Calculate"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'quantity
        '
        Me.quantity.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.quantity.Location = New System.Drawing.Point(253, 114)
        Me.quantity.Name = "quantity"
        Me.quantity.Size = New System.Drawing.Size(141, 28)
        Me.quantity.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(185, 19)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Input the price of unit:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 123)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(207, 19)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Input the quantity of unit:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 179)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 19)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Total cost:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 234)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 19)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Discount:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 296)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(186, 19)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Total discounted cost:"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Button2.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(378, 367)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(33, 28)
        Me.Button2.TabIndex = 12
        Me.Button2.Text = "B"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'ProjectA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightCyan
        Me.ClientSize = New System.Drawing.Size(414, 397)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.quantity)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.totalbill)
        Me.Controls.Add(Me.discount)
        Me.Controls.Add(Me.fullcost)
        Me.Controls.Add(Me.priceofunit)
        Me.Name = "ProjectA"
        Me.Text = "Project A"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents priceofunit As TextBox
    Friend WithEvents fullcost As TextBox
    Friend WithEvents discount As TextBox
    Friend WithEvents totalbill As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents quantity As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Button2 As Button
End Class
