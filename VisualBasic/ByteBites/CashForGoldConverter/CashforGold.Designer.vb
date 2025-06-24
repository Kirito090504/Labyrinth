<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CashforGold
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CashforGold))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.comboGold = New System.Windows.Forms.ComboBox()
        Me.lblGoal = New System.Windows.Forms.Label()
        Me.txtgold = New System.Windows.Forms.TextBox()
        Me.btnFind = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.lblResult = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(169, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(258, 50)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cash for Gold"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(142, 62)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(311, 293)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(10, 376)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(175, 25)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Select Gold Option:"
        '
        'comboGold
        '
        Me.comboGold.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comboGold.FormattingEnabled = True
        Me.comboGold.Location = New System.Drawing.Point(48, 416)
        Me.comboGold.Name = "comboGold"
        Me.comboGold.Size = New System.Drawing.Size(504, 33)
        Me.comboGold.TabIndex = 3
        Me.comboGold.Text = "Select Option"
        '
        'lblGoal
        '
        Me.lblGoal.AutoSize = True
        Me.lblGoal.BackColor = System.Drawing.Color.Transparent
        Me.lblGoal.Font = New System.Drawing.Font("Segoe UI Semibold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGoal.Location = New System.Drawing.Point(70, 488)
        Me.lblGoal.Name = "lblGoal"
        Me.lblGoal.Size = New System.Drawing.Size(54, 25)
        Me.lblGoal.TabIndex = 4
        Me.lblGoal.Text = "Goal:"
        '
        'txtgold
        '
        Me.txtgold.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtgold.Location = New System.Drawing.Point(306, 482)
        Me.txtgold.Name = "txtgold"
        Me.txtgold.Size = New System.Drawing.Size(147, 31)
        Me.txtgold.TabIndex = 5
        '
        'btnFind
        '
        Me.btnFind.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFind.Location = New System.Drawing.Point(118, 537)
        Me.btnFind.Name = "btnFind"
        Me.btnFind.Size = New System.Drawing.Size(173, 73)
        Me.btnFind.TabIndex = 6
        Me.btnFind.Text = "Find"
        Me.btnFind.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(297, 537)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(173, 73)
        Me.btnClear.TabIndex = 7
        Me.btnClear.Text = "Clear Form"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'lblResult
        '
        Me.lblResult.AutoSize = True
        Me.lblResult.BackColor = System.Drawing.Color.Transparent
        Me.lblResult.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResult.Location = New System.Drawing.Point(87, 630)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(59, 25)
        Me.lblResult.TabIndex = 8
        Me.lblResult.Text = "Result"
        Me.lblResult.Visible = False
        '
        'CashforGold
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(605, 674)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnFind)
        Me.Controls.Add(Me.txtgold)
        Me.Controls.Add(Me.lblGoal)
        Me.Controls.Add(Me.comboGold)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "CashforGold"
        Me.Text = "Cash for Gold"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents comboGold As ComboBox
    Friend WithEvents lblGoal As Label
    Friend WithEvents txtgold As TextBox
    Friend WithEvents btnFind As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents lblResult As Label
End Class
