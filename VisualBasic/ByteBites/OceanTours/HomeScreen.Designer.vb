<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HomeScreen
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HomeScreen))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.HomeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TourDestinationsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HawaiiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.JamaicaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MaldivesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.LightCyan
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HomeToolStripMenuItem, Me.TourDestinationsToolStripMenuItem, Me.AboutToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(851, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'HomeToolStripMenuItem
        '
        Me.HomeToolStripMenuItem.Name = "HomeToolStripMenuItem"
        Me.HomeToolStripMenuItem.Size = New System.Drawing.Size(64, 24)
        Me.HomeToolStripMenuItem.Text = "Home"
        '
        'TourDestinationsToolStripMenuItem
        '
        Me.TourDestinationsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HawaiiToolStripMenuItem, Me.JamaicaToolStripMenuItem, Me.MaldivesToolStripMenuItem})
        Me.TourDestinationsToolStripMenuItem.Name = "TourDestinationsToolStripMenuItem"
        Me.TourDestinationsToolStripMenuItem.Size = New System.Drawing.Size(138, 24)
        Me.TourDestinationsToolStripMenuItem.Text = "Tour Destinations"
        '
        'HawaiiToolStripMenuItem
        '
        Me.HawaiiToolStripMenuItem.Name = "HawaiiToolStripMenuItem"
        Me.HawaiiToolStripMenuItem.Size = New System.Drawing.Size(151, 26)
        Me.HawaiiToolStripMenuItem.Text = "Hawaii"
        '
        'JamaicaToolStripMenuItem
        '
        Me.JamaicaToolStripMenuItem.Name = "JamaicaToolStripMenuItem"
        Me.JamaicaToolStripMenuItem.Size = New System.Drawing.Size(151, 26)
        Me.JamaicaToolStripMenuItem.Text = "Jamaica"
        '
        'MaldivesToolStripMenuItem
        '
        Me.MaldivesToolStripMenuItem.Name = "MaldivesToolStripMenuItem"
        Me.MaldivesToolStripMenuItem.Size = New System.Drawing.Size(151, 26)
        Me.MaldivesToolStripMenuItem.Text = "Maldives"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(64, 24)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(47, 24)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'HomeScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(851, 485)
        Me.Controls.Add(Me.MenuStrip1)
        Me.DoubleBuffered = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "HomeScreen"
        Me.Text = "HomeScreen"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents HomeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TourDestinationsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HawaiiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents JamaicaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MaldivesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
End Class
