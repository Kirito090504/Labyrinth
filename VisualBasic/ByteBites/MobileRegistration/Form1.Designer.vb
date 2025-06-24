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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.CorpID = New System.Windows.Forms.TextBox()
        Me.Ln = New System.Windows.Forms.TextBox()
        Me.quantity = New System.Windows.Forms.NumericUpDown()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.MA = New System.Windows.Forms.RadioButton()
        Me.MD = New System.Windows.Forms.RadioButton()
        Me.MS = New System.Windows.Forms.RadioButton()
        Me.Fn = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.IOS = New System.Windows.Forms.RadioButton()
        Me.Android = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.outlbl1 = New System.Windows.Forms.Label()
        Me.outlbl2 = New System.Windows.Forms.Label()
        Me.TotalBill = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        CType(Me.quantity, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CorpID
        '
        Me.CorpID.Location = New System.Drawing.Point(215, 86)
        Me.CorpID.Name = "CorpID"
        Me.CorpID.Size = New System.Drawing.Size(135, 22)
        Me.CorpID.TabIndex = 0
        '
        'Ln
        '
        Me.Ln.Location = New System.Drawing.Point(215, 138)
        Me.Ln.Name = "Ln"
        Me.Ln.Size = New System.Drawing.Size(135, 22)
        Me.Ln.TabIndex = 1
        '
        'quantity
        '
        Me.quantity.Location = New System.Drawing.Point(298, 233)
        Me.quantity.Name = "quantity"
        Me.quantity.Size = New System.Drawing.Size(52, 22)
        Me.quantity.TabIndex = 3
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.MA)
        Me.GroupBox1.Controls.Add(Me.MD)
        Me.GroupBox1.Controls.Add(Me.MS)
        Me.GroupBox1.Font = New System.Drawing.Font("OCR A Extended", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(51, 279)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(299, 165)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Courses"
        Me.GroupBox1.UseWaitCursor = True
        '
        'MA
        '
        Me.MA.AutoSize = True
        Me.MA.Location = New System.Drawing.Point(17, 131)
        Me.MA.Name = "MA"
        Me.MA.Size = New System.Drawing.Size(283, 28)
        Me.MA.TabIndex = 2
        Me.MA.TabStop = True
        Me.MA.Text = "Mobile Application"
        Me.MA.UseVisualStyleBackColor = True
        Me.MA.UseWaitCursor = True
        '
        'MD
        '
        Me.MD.AutoSize = True
        Me.MD.Location = New System.Drawing.Point(17, 82)
        Me.MD.Name = "MD"
        Me.MD.Size = New System.Drawing.Size(241, 28)
        Me.MD.TabIndex = 1
        Me.MD.TabStop = True
        Me.MD.Text = "Mobile Database"
        Me.MD.UseVisualStyleBackColor = True
        Me.MD.UseWaitCursor = True
        '
        'MS
        '
        Me.MS.AutoSize = True
        Me.MS.Location = New System.Drawing.Point(17, 37)
        Me.MS.Name = "MS"
        Me.MS.Size = New System.Drawing.Size(241, 28)
        Me.MS.TabIndex = 0
        Me.MS.TabStop = True
        Me.MS.Text = "Mobile Security"
        Me.MS.UseVisualStyleBackColor = True
        Me.MS.UseWaitCursor = True
        '
        'Fn
        '
        Me.Fn.Location = New System.Drawing.Point(215, 189)
        Me.Fn.Name = "Fn"
        Me.Fn.Size = New System.Drawing.Size(135, 22)
        Me.Fn.TabIndex = 5
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.IOS)
        Me.GroupBox2.Controls.Add(Me.Android)
        Me.GroupBox2.Font = New System.Drawing.Font("OCR A Extended", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(51, 458)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(258, 100)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Pre-Conference"
        '
        'IOS
        '
        Me.IOS.AutoSize = True
        Me.IOS.Location = New System.Drawing.Point(27, 64)
        Me.IOS.Name = "IOS"
        Me.IOS.Size = New System.Drawing.Size(73, 28)
        Me.IOS.TabIndex = 1
        Me.IOS.TabStop = True
        Me.IOS.Text = "IOS"
        Me.IOS.UseVisualStyleBackColor = True
        '
        'Android
        '
        Me.Android.AutoSize = True
        Me.Android.Location = New System.Drawing.Point(27, 30)
        Me.Android.Name = "Android"
        Me.Android.Size = New System.Drawing.Size(129, 28)
        Me.Android.TabIndex = 0
        Me.Android.TabStop = True
        Me.Android.Text = "Android"
        Me.Android.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("OCR A Extended", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(500, 316)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 23)
        Me.Label1.TabIndex = 6
        '
        'outlbl1
        '
        Me.outlbl1.AutoSize = True
        Me.outlbl1.BackColor = System.Drawing.Color.Transparent
        Me.outlbl1.Font = New System.Drawing.Font("OCR A Extended", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.outlbl1.ForeColor = System.Drawing.Color.White
        Me.outlbl1.Location = New System.Drawing.Point(482, 352)
        Me.outlbl1.Name = "outlbl1"
        Me.outlbl1.Size = New System.Drawing.Size(0, 24)
        Me.outlbl1.TabIndex = 7
        '
        'outlbl2
        '
        Me.outlbl2.AutoSize = True
        Me.outlbl2.BackColor = System.Drawing.Color.Transparent
        Me.outlbl2.Font = New System.Drawing.Font("OCR A Extended", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.outlbl2.ForeColor = System.Drawing.Color.White
        Me.outlbl2.Location = New System.Drawing.Point(436, 396)
        Me.outlbl2.Name = "outlbl2"
        Me.outlbl2.Size = New System.Drawing.Size(0, 24)
        Me.outlbl2.TabIndex = 8
        '
        'TotalBill
        '
        Me.TotalBill.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalBill.Location = New System.Drawing.Point(681, 458)
        Me.TotalBill.Name = "TotalBill"
        Me.TotalBill.Size = New System.Drawing.Size(210, 27)
        Me.TotalBill.TabIndex = 9
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("OCR A Extended", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(486, 511)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(168, 39)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Compute Cost"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("OCR A Extended", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(681, 511)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(168, 39)
        Me.Button2.TabIndex = 11
        Me.Button2.Text = "Clear Form"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("OCR A Extended", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(482, 458)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(164, 24)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Total Cost:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("OCR A Extended", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Snow
        Me.Label2.Location = New System.Drawing.Point(6, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(897, 35)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Mobile Development Conference Registration"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("OCR A Extended", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Snow
        Me.Label3.Location = New System.Drawing.Point(47, 86)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(130, 24)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Corp ID:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("OCR A Extended", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Snow
        Me.Label5.Location = New System.Drawing.Point(47, 138)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(145, 24)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Lastname:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("OCR A Extended", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Snow
        Me.Label6.Location = New System.Drawing.Point(47, 185)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(160, 24)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Firstname:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("OCR A Extended", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Snow
        Me.Label7.Location = New System.Drawing.Point(47, 233)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(190, 24)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "No. of Days:"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(504, 73)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(336, 227)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 18
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Visible = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(504, 73)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(336, 227)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 19
        Me.PictureBox2.TabStop = False
        Me.PictureBox2.Visible = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(504, 73)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(336, 227)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 20
        Me.PictureBox3.TabStop = False
        Me.PictureBox3.Visible = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(846, 138)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(103, 87)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 21
        Me.PictureBox4.TabStop = False
        Me.PictureBox4.Visible = False
        '
        'PictureBox5
        '
        Me.PictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(846, 138)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(103, 87)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 22
        Me.PictureBox5.TabStop = False
        Me.PictureBox5.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(961, 570)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TotalBill)
        Me.Controls.Add(Me.outlbl2)
        Me.Controls.Add(Me.outlbl1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Fn)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.quantity)
        Me.Controls.Add(Me.Ln)
        Me.Controls.Add(Me.CorpID)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "Registration"
        CType(Me.quantity, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CorpID As TextBox
    Friend WithEvents Ln As TextBox
    Friend WithEvents quantity As NumericUpDown
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents MA As RadioButton
    Friend WithEvents MD As RadioButton
    Friend WithEvents MS As RadioButton
    Friend WithEvents Fn As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents IOS As RadioButton
    Friend WithEvents Android As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents outlbl1 As Label
    Friend WithEvents outlbl2 As Label
    Friend WithEvents TotalBill As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
End Class
