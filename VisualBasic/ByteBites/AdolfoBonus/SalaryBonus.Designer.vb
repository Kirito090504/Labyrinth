<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SalaryBonus
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SalaryBonus))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.monthlySalary = New System.Windows.Forms.TextBox()
        Me.txtBonus = New System.Windows.Forms.TextBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(28, 30)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Salary:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(28, 78)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(148, 29)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Total Bonus:"
        '
        'monthlySalary
        '
        Me.monthlySalary.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.monthlySalary.Location = New System.Drawing.Point(191, 30)
        Me.monthlySalary.Margin = New System.Windows.Forms.Padding(4)
        Me.monthlySalary.Name = "monthlySalary"
        Me.monthlySalary.Size = New System.Drawing.Size(177, 22)
        Me.monthlySalary.TabIndex = 2
        '
        'txtBonus
        '
        Me.txtBonus.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.txtBonus.Location = New System.Drawing.Point(191, 78)
        Me.txtBonus.Margin = New System.Windows.Forms.Padding(4)
        Me.txtBonus.Name = "txtBonus"
        Me.txtBonus.Size = New System.Drawing.Size(177, 22)
        Me.txtBonus.TabIndex = 3
        '
        'btnCalculate
        '
        Me.btnCalculate.BackColor = System.Drawing.Color.Transparent
        Me.btnCalculate.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.Location = New System.Drawing.Point(132, 126)
        Me.btnCalculate.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(145, 34)
        Me.btnCalculate.TabIndex = 4
        Me.btnCalculate.Text = "Compute"
        Me.btnCalculate.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleGreen
        Me.BackgroundImage = Global.AdolfoBonus.My.Resources.Resources.OIP
        Me.ClientSize = New System.Drawing.Size(405, 175)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.txtBonus)
        Me.Controls.Add(Me.monthlySalary)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.Text = "Salary Bonus"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents monthlySalary As TextBox
    Friend WithEvents txtBonus As TextBox
    Friend WithEvents btnCalculate As Button
End Class
