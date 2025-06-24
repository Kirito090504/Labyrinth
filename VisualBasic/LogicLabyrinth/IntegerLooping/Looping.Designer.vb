<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Looping
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Looping))
        Me.firstinteger = New System.Windows.Forms.TextBox()
        Me.secondinteger = New System.Windows.Forms.TextBox()
        Me.oddListBox = New System.Windows.Forms.ListBox()
        Me.evenListBox = New System.Windows.Forms.ListBox()
        Me.findNumbersButton = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'firstinteger
        '
        Me.firstinteger.BackColor = System.Drawing.Color.MistyRose
        Me.firstinteger.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.firstinteger.Location = New System.Drawing.Point(44, 68)
        Me.firstinteger.Name = "firstinteger"
        Me.firstinteger.Size = New System.Drawing.Size(123, 28)
        Me.firstinteger.TabIndex = 0
        '
        'secondinteger
        '
        Me.secondinteger.BackColor = System.Drawing.Color.MistyRose
        Me.secondinteger.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.secondinteger.Location = New System.Drawing.Point(44, 149)
        Me.secondinteger.Name = "secondinteger"
        Me.secondinteger.Size = New System.Drawing.Size(123, 28)
        Me.secondinteger.TabIndex = 1
        '
        'oddListBox
        '
        Me.oddListBox.BackColor = System.Drawing.Color.Bisque
        Me.oddListBox.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.oddListBox.FormattingEnabled = True
        Me.oddListBox.ItemHeight = 21
        Me.oddListBox.Location = New System.Drawing.Point(31, 240)
        Me.oddListBox.Name = "oddListBox"
        Me.oddListBox.Size = New System.Drawing.Size(136, 193)
        Me.oddListBox.TabIndex = 2
        '
        'evenListBox
        '
        Me.evenListBox.BackColor = System.Drawing.Color.Bisque
        Me.evenListBox.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.evenListBox.FormattingEnabled = True
        Me.evenListBox.ItemHeight = 21
        Me.evenListBox.Location = New System.Drawing.Point(219, 240)
        Me.evenListBox.Name = "evenListBox"
        Me.evenListBox.Size = New System.Drawing.Size(137, 193)
        Me.evenListBox.TabIndex = 3
        '
        'findNumbersButton
        '
        Me.findNumbersButton.BackColor = System.Drawing.Color.Linen
        Me.findNumbersButton.Font = New System.Drawing.Font("Century Gothic", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.findNumbersButton.Location = New System.Drawing.Point(249, 63)
        Me.findNumbersButton.Name = "findNumbersButton"
        Me.findNumbersButton.Size = New System.Drawing.Size(91, 36)
        Me.findNumbersButton.TabIndex = 4
        Me.findNumbersButton.Text = "FIND"
        Me.findNumbersButton.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Linen
        Me.Button1.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(249, 126)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(91, 36)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "CLEAR"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Century", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(132, 21)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "First Integer:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Century", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 114)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(151, 21)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Second Integer:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Century", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(29, 204)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(138, 21)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Odd Numbers:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Century", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(215, 204)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(146, 21)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Even Numbers:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(387, 448)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.findNumbersButton)
        Me.Controls.Add(Me.evenListBox)
        Me.Controls.Add(Me.oddListBox)
        Me.Controls.Add(Me.secondinteger)
        Me.Controls.Add(Me.firstinteger)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents firstinteger As TextBox
    Friend WithEvents secondinteger As TextBox
    Friend WithEvents oddListBox As ListBox
    Friend WithEvents evenListBox As ListBox
    Friend WithEvents findNumbersButton As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
