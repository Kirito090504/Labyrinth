<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MinuteConverter
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MinuteConverter))
        Me.Title1 = New System.Windows.Forms.Label()
        Me.Title2 = New System.Windows.Forms.Label()
        Me.H = New System.Windows.Forms.TextBox()
        Me.M = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Out = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Title1
        '
        Me.Title1.AutoSize = True
        Me.Title1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Title1.Location = New System.Drawing.Point(39, 43)
        Me.Title1.Name = "Title1"
        Me.Title1.Size = New System.Drawing.Size(103, 32)
        Me.Title1.TabIndex = 0
        Me.Title1.Text = "Hours:"
        '
        'Title2
        '
        Me.Title2.AutoSize = True
        Me.Title2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Title2.Location = New System.Drawing.Point(39, 108)
        Me.Title2.Name = "Title2"
        Me.Title2.Size = New System.Drawing.Size(130, 32)
        Me.Title2.TabIndex = 1
        Me.Title2.Text = "Minutes:"
        '
        'H
        '
        Me.H.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.H.Location = New System.Drawing.Point(208, 50)
        Me.H.Name = "H"
        Me.H.Size = New System.Drawing.Size(172, 27)
        Me.H.TabIndex = 2
        '
        'M
        '
        Me.M.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.M.Location = New System.Drawing.Point(208, 115)
        Me.M.Name = "M"
        Me.M.Size = New System.Drawing.Size(172, 27)
        Me.M.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(138, 228)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(146, 43)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "CONVERT"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 177)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(215, 32)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Total Minutes: "
        '
        'Out
        '
        Me.Out.AutoSize = True
        Me.Out.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Out.Location = New System.Drawing.Point(233, 177)
        Me.Out.Name = "Out"
        Me.Out.Size = New System.Drawing.Size(31, 32)
        Me.Out.TabIndex = 6
        Me.Out.Text = "0"
        '
        'MinuteConverter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LavenderBlush
        Me.ClientSize = New System.Drawing.Size(428, 292)
        Me.Controls.Add(Me.Out)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.M)
        Me.Controls.Add(Me.H)
        Me.Controls.Add(Me.Title2)
        Me.Controls.Add(Me.Title1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MinuteConverter"
        Me.Text = "Minute Converter"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Title1 As Label
    Friend WithEvents Title2 As Label
    Friend WithEvents H As TextBox
    Friend WithEvents M As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Out As Label
End Class
