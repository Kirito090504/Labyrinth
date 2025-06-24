<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HighestInteger
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HighestInteger))
        Me.integerlistbox = New System.Windows.Forms.ListBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.LHI = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'integerlistbox
        '
        Me.integerlistbox.BackColor = System.Drawing.Color.LightSteelBlue
        Me.integerlistbox.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.integerlistbox.FormattingEnabled = True
        Me.integerlistbox.ItemHeight = 21
        Me.integerlistbox.Location = New System.Drawing.Point(29, 60)
        Me.integerlistbox.Name = "integerlistbox"
        Me.integerlistbox.Size = New System.Drawing.Size(240, 298)
        Me.integerlistbox.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Button1.Font = New System.Drawing.Font("Century Gothic", 10.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(97, 364)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(92, 38)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "INPUT"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'LHI
        '
        Me.LHI.AutoSize = True
        Me.LHI.BackColor = System.Drawing.Color.Transparent
        Me.LHI.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LHI.ForeColor = System.Drawing.Color.White
        Me.LHI.Location = New System.Drawing.Point(41, 21)
        Me.LHI.Name = "LHI"
        Me.LHI.Size = New System.Drawing.Size(228, 23)
        Me.LHI.TabIndex = 3
        Me.LHI.Text = "The Highest Integer is.."
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Button2.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(0, 0)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(25, 23)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "B"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'HighestInteger
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(303, 411)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.LHI)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.integerlistbox)
        Me.Name = "HighestInteger"
        Me.Text = "Highest Integer"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents integerlistbox As ListBox
    Friend WithEvents Button1 As Button
    Friend WithEvents LHI As Label
    Friend WithEvents Button2 As Button
End Class
