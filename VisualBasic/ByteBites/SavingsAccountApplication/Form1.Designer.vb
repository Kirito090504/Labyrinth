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
        Me.depo = New System.Windows.Forms.TextBox()
        Me.anrate = New System.Windows.Forms.TextBox()
        Me.bal = New System.Windows.Forms.TextBox()
        Me.calc = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'depo
        '
        Me.depo.BackColor = System.Drawing.Color.LightSteelBlue
        Me.depo.Location = New System.Drawing.Point(288, 33)
        Me.depo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.depo.Name = "depo"
        Me.depo.Size = New System.Drawing.Size(209, 30)
        Me.depo.TabIndex = 0
        '
        'anrate
        '
        Me.anrate.BackColor = System.Drawing.Color.LightSteelBlue
        Me.anrate.Location = New System.Drawing.Point(288, 90)
        Me.anrate.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.anrate.Name = "anrate"
        Me.anrate.Size = New System.Drawing.Size(209, 30)
        Me.anrate.TabIndex = 1
        '
        'bal
        '
        Me.bal.BackColor = System.Drawing.Color.LightSteelBlue
        Me.bal.Location = New System.Drawing.Point(288, 147)
        Me.bal.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.bal.Name = "bal"
        Me.bal.Size = New System.Drawing.Size(209, 30)
        Me.bal.TabIndex = 2
        '
        'calc
        '
        Me.calc.BackColor = System.Drawing.Color.LightSteelBlue
        Me.calc.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.calc.Location = New System.Drawing.Point(269, 209)
        Me.calc.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.calc.Name = "calc"
        Me.calc.Size = New System.Drawing.Size(130, 42)
        Me.calc.TabIndex = 3
        Me.calc.Text = "Calculate"
        Me.calc.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(112, 209)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(130, 42)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Clear"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(174, 25)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Deposited amount:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 95)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(193, 25)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Annual Interest Rate:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 152)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(267, 25)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Balance(3yrs w/ Interet Rate):"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CadetBlue
        Me.ClientSize = New System.Drawing.Size(517, 269)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.calc)
        Me.Controls.Add(Me.bal)
        Me.Controls.Add(Me.anrate)
        Me.Controls.Add(Me.depo)
        Me.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Form1"
        Me.Text = "Savings Account"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents depo As TextBox
    Friend WithEvents anrate As TextBox
    Friend WithEvents bal As TextBox
    Friend WithEvents calc As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
