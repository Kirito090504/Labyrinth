﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NameLooping
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NameLooping))
        Me.firstname = New System.Windows.Forms.TextBox()
        Me.times = New System.Windows.Forms.TextBox()
        Me.namelist = New System.Windows.Forms.ListBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'firstname
        '
        Me.firstname.BackColor = System.Drawing.Color.CadetBlue
        Me.firstname.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.firstname.ForeColor = System.Drawing.Color.Snow
        Me.firstname.Location = New System.Drawing.Point(184, 26)
        Me.firstname.Name = "firstname"
        Me.firstname.Size = New System.Drawing.Size(164, 28)
        Me.firstname.TabIndex = 0
        '
        'times
        '
        Me.times.BackColor = System.Drawing.Color.CadetBlue
        Me.times.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.times.ForeColor = System.Drawing.Color.Snow
        Me.times.Location = New System.Drawing.Point(248, 75)
        Me.times.Name = "times"
        Me.times.Size = New System.Drawing.Size(100, 30)
        Me.times.TabIndex = 1
        '
        'namelist
        '
        Me.namelist.BackColor = System.Drawing.Color.CadetBlue
        Me.namelist.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.namelist.ForeColor = System.Drawing.Color.Snow
        Me.namelist.FormattingEnabled = True
        Me.namelist.ItemHeight = 21
        Me.namelist.Location = New System.Drawing.Point(38, 126)
        Me.namelist.Name = "namelist"
        Me.namelist.Size = New System.Drawing.Size(279, 319)
        Me.namelist.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.CadetBlue
        Me.Button1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Snow
        Me.Button1.Location = New System.Drawing.Point(110, 465)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(132, 43)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "GENERATE"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.CadetBlue
        Me.Label1.Location = New System.Drawing.Point(12, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(131, 23)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Input Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.CadetBlue
        Me.Label2.Location = New System.Drawing.Point(12, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(230, 23)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Enter how many times:"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.CadetBlue
        Me.Button2.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(327, 497)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(31, 26)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "B"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'NameLooping
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(360, 520)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.namelist)
        Me.Controls.Add(Me.times)
        Me.Controls.Add(Me.firstname)
        Me.Name = "NameLooping"
        Me.Text = "Name Looping"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents firstname As TextBox
    Friend WithEvents times As TextBox
    Friend WithEvents namelist As ListBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button2 As Button
End Class
