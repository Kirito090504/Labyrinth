<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SalaryCalculator
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SalaryCalculator))
        Me.daysTextBox = New System.Windows.Forms.TextBox()
        Me.calculateButton = New System.Windows.Forms.Button()
        Me.resultLabel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'daysTextBox
        '
        Me.daysTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.daysTextBox.Location = New System.Drawing.Point(372, 34)
        Me.daysTextBox.Name = "daysTextBox"
        Me.daysTextBox.Size = New System.Drawing.Size(187, 34)
        Me.daysTextBox.TabIndex = 0
        '
        'calculateButton
        '
        Me.calculateButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.calculateButton.Location = New System.Drawing.Point(183, 157)
        Me.calculateButton.Name = "calculateButton"
        Me.calculateButton.Size = New System.Drawing.Size(215, 40)
        Me.calculateButton.TabIndex = 1
        Me.calculateButton.Text = "CALCULATE"
        Me.calculateButton.UseVisualStyleBackColor = True
        '
        'resultLabel
        '
        Me.resultLabel.AutoSize = True
        Me.resultLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.resultLabel.Location = New System.Drawing.Point(58, 104)
        Me.resultLabel.Name = "resultLabel"
        Me.resultLabel.Size = New System.Drawing.Size(219, 29)
        Me.resultLabel.TabIndex = 2
        Me.resultLabel.Text = "TOTAL EARNING"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(336, 32)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Input total days of work:"
        '
        'SalaryCalculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LemonChiffon
        Me.ClientSize = New System.Drawing.Size(586, 223)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.resultLabel)
        Me.Controls.Add(Me.calculateButton)
        Me.Controls.Add(Me.daysTextBox)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "SalaryCalculator"
        Me.Text = "Salaray Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents daysTextBox As TextBox
    Friend WithEvents calculateButton As Button
    Friend WithEvents resultLabel As Label
    Friend WithEvents Label1 As Label
End Class
