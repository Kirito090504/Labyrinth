<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MonthDisplay
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MonthNumberTextBox = New System.Windows.Forms.TextBox()
        Me.Result = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(50, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(259, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Input the number of the month:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(95, 110)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(171, 19)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Name of the Month:"
        '
        'MonthNumberTextBox
        '
        Me.MonthNumberTextBox.Location = New System.Drawing.Point(133, 61)
        Me.MonthNumberTextBox.Name = "MonthNumberTextBox"
        Me.MonthNumberTextBox.Size = New System.Drawing.Size(100, 22)
        Me.MonthNumberTextBox.TabIndex = 2
        '
        'Result
        '
        Me.Result.Location = New System.Drawing.Point(99, 155)
        Me.Result.Name = "Result"
        Me.Result.Size = New System.Drawing.Size(167, 22)
        Me.Result.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Century", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(133, 200)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 26)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "ENTER"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.Button2.Location = New System.Drawing.Point(74, 234)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(107, 23)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "Toll Gate Charge"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Beige
        Me.Button3.Location = New System.Drawing.Point(74, 263)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(107, 23)
        Me.Button3.TabIndex = 7
        Me.Button3.Text = "Grade"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Beige
        Me.Button4.Location = New System.Drawing.Point(187, 234)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(104, 23)
        Me.Button4.TabIndex = 8
        Me.Button4.Text = "Year Level"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.Beige
        Me.Button5.Location = New System.Drawing.Point(187, 263)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(104, 23)
        Me.Button5.TabIndex = 9
        Me.Button5.Text = "Commission"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'MonthDisplay
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Beige
        Me.ClientSize = New System.Drawing.Size(351, 298)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Result)
        Me.Controls.Add(Me.MonthNumberTextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MonthDisplay"
        Me.Text = "Display the Month"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents MonthNumberTextBox As TextBox
    Friend WithEvents Result As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
End Class
