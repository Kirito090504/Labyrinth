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
        Me.components = New System.ComponentModel.Container()
        Dim Student_NumberLabel As System.Windows.Forms.Label
        Dim Last_NameLabel As System.Windows.Forms.Label
        Dim First_NameLabel As System.Windows.Forms.Label
        Dim Middle_NameLabel As System.Windows.Forms.Label
        Dim ProgramLabel As System.Windows.Forms.Label
        Dim Year_LevelLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.ListofStudentsDataSet = New AdolfoStudentRecords.ListofStudentsDataSet()
        Me.StudentListBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StudentListTableAdapter = New AdolfoStudentRecords.ListofStudentsDataSetTableAdapters.StudentListTableAdapter()
        Me.TableAdapterManager = New AdolfoStudentRecords.ListofStudentsDataSetTableAdapters.TableAdapterManager()
        Me.StudentListBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.StudentListBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Student_NumberTextBox = New System.Windows.Forms.TextBox()
        Me.Last_NameTextBox = New System.Windows.Forms.TextBox()
        Me.First_NameTextBox = New System.Windows.Forms.TextBox()
        Me.Middle_NameTextBox = New System.Windows.Forms.TextBox()
        Me.ProgramTextBox = New System.Windows.Forms.TextBox()
        Me.Year_LevelTextBox = New System.Windows.Forms.TextBox()
        Me.StudentListDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Student_NumberLabel = New System.Windows.Forms.Label()
        Last_NameLabel = New System.Windows.Forms.Label()
        First_NameLabel = New System.Windows.Forms.Label()
        Middle_NameLabel = New System.Windows.Forms.Label()
        ProgramLabel = New System.Windows.Forms.Label()
        Year_LevelLabel = New System.Windows.Forms.Label()
        CType(Me.ListofStudentsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentListBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StudentListBindingNavigator.SuspendLayout()
        CType(Me.StudentListDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Student_NumberLabel
        '
        Student_NumberLabel.AutoSize = True
        Student_NumberLabel.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Student_NumberLabel.Location = New System.Drawing.Point(75, 58)
        Student_NumberLabel.Name = "Student_NumberLabel"
        Student_NumberLabel.Size = New System.Drawing.Size(151, 21)
        Student_NumberLabel.TabIndex = 1
        Student_NumberLabel.Text = "Student Number:"
        '
        'Last_NameLabel
        '
        Last_NameLabel.AutoSize = True
        Last_NameLabel.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Last_NameLabel.Location = New System.Drawing.Point(465, 60)
        Last_NameLabel.Name = "Last_NameLabel"
        Last_NameLabel.Size = New System.Drawing.Size(105, 21)
        Last_NameLabel.TabIndex = 3
        Last_NameLabel.Text = "Last Name:"
        '
        'First_NameLabel
        '
        First_NameLabel.AutoSize = True
        First_NameLabel.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        First_NameLabel.Location = New System.Drawing.Point(465, 103)
        First_NameLabel.Name = "First_NameLabel"
        First_NameLabel.Size = New System.Drawing.Size(101, 21)
        First_NameLabel.TabIndex = 5
        First_NameLabel.Text = "First Name:"
        '
        'Middle_NameLabel
        '
        Middle_NameLabel.AutoSize = True
        Middle_NameLabel.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Middle_NameLabel.Location = New System.Drawing.Point(451, 148)
        Middle_NameLabel.Name = "Middle_NameLabel"
        Middle_NameLabel.Size = New System.Drawing.Size(129, 21)
        Middle_NameLabel.TabIndex = 7
        Middle_NameLabel.Text = "Middle Name:"
        '
        'ProgramLabel
        '
        ProgramLabel.AutoSize = True
        ProgramLabel.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ProgramLabel.Location = New System.Drawing.Point(142, 103)
        ProgramLabel.Name = "ProgramLabel"
        ProgramLabel.Size = New System.Drawing.Size(84, 21)
        ProgramLabel.TabIndex = 9
        ProgramLabel.Text = "Program:"
        '
        'Year_LevelLabel
        '
        Year_LevelLabel.AutoSize = True
        Year_LevelLabel.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Year_LevelLabel.Location = New System.Drawing.Point(123, 144)
        Year_LevelLabel.Name = "Year_LevelLabel"
        Year_LevelLabel.Size = New System.Drawing.Size(103, 21)
        Year_LevelLabel.TabIndex = 11
        Year_LevelLabel.Text = "Year Level:"
        '
        'ListofStudentsDataSet
        '
        Me.ListofStudentsDataSet.DataSetName = "ListofStudentsDataSet"
        Me.ListofStudentsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'StudentListBindingSource
        '
        Me.StudentListBindingSource.DataMember = "StudentList"
        Me.StudentListBindingSource.DataSource = Me.ListofStudentsDataSet
        '
        'StudentListTableAdapter
        '
        Me.StudentListTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.StudentListTableAdapter = Me.StudentListTableAdapter
        Me.TableAdapterManager.UpdateOrder = AdolfoStudentRecords.ListofStudentsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'StudentListBindingNavigator
        '
        Me.StudentListBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.StudentListBindingNavigator.BindingSource = Me.StudentListBindingSource
        Me.StudentListBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.StudentListBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.StudentListBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StudentListBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.StudentListBindingNavigatorSaveItem})
        Me.StudentListBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.StudentListBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.StudentListBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.StudentListBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.StudentListBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.StudentListBindingNavigator.Name = "StudentListBindingNavigator"
        Me.StudentListBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.StudentListBindingNavigator.Size = New System.Drawing.Size(883, 27)
        Me.StudentListBindingNavigator.TabIndex = 0
        Me.StudentListBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(45, 24)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 27)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 27)
        '
        'StudentListBindingNavigatorSaveItem
        '
        Me.StudentListBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.StudentListBindingNavigatorSaveItem.Image = CType(resources.GetObject("StudentListBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.StudentListBindingNavigatorSaveItem.Name = "StudentListBindingNavigatorSaveItem"
        Me.StudentListBindingNavigatorSaveItem.Size = New System.Drawing.Size(29, 24)
        Me.StudentListBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Student_NumberTextBox
        '
        Me.Student_NumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentListBindingSource, "Student Number", True))
        Me.Student_NumberTextBox.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Student_NumberTextBox.Location = New System.Drawing.Point(257, 55)
        Me.Student_NumberTextBox.Name = "Student_NumberTextBox"
        Me.Student_NumberTextBox.Size = New System.Drawing.Size(136, 28)
        Me.Student_NumberTextBox.TabIndex = 2
        '
        'Last_NameTextBox
        '
        Me.Last_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentListBindingSource, "Last Name", True))
        Me.Last_NameTextBox.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Last_NameTextBox.Location = New System.Drawing.Point(595, 55)
        Me.Last_NameTextBox.Name = "Last_NameTextBox"
        Me.Last_NameTextBox.Size = New System.Drawing.Size(172, 28)
        Me.Last_NameTextBox.TabIndex = 4
        '
        'First_NameTextBox
        '
        Me.First_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentListBindingSource, "First Name", True))
        Me.First_NameTextBox.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.First_NameTextBox.Location = New System.Drawing.Point(595, 96)
        Me.First_NameTextBox.Name = "First_NameTextBox"
        Me.First_NameTextBox.Size = New System.Drawing.Size(172, 28)
        Me.First_NameTextBox.TabIndex = 6
        '
        'Middle_NameTextBox
        '
        Me.Middle_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentListBindingSource, "Middle Name", True))
        Me.Middle_NameTextBox.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Middle_NameTextBox.Location = New System.Drawing.Point(595, 141)
        Me.Middle_NameTextBox.Name = "Middle_NameTextBox"
        Me.Middle_NameTextBox.Size = New System.Drawing.Size(172, 28)
        Me.Middle_NameTextBox.TabIndex = 8
        '
        'ProgramTextBox
        '
        Me.ProgramTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentListBindingSource, "Program", True))
        Me.ProgramTextBox.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProgramTextBox.Location = New System.Drawing.Point(257, 96)
        Me.ProgramTextBox.Name = "ProgramTextBox"
        Me.ProgramTextBox.Size = New System.Drawing.Size(136, 28)
        Me.ProgramTextBox.TabIndex = 10
        '
        'Year_LevelTextBox
        '
        Me.Year_LevelTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentListBindingSource, "Year Level", True))
        Me.Year_LevelTextBox.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Year_LevelTextBox.Location = New System.Drawing.Point(257, 141)
        Me.Year_LevelTextBox.Name = "Year_LevelTextBox"
        Me.Year_LevelTextBox.Size = New System.Drawing.Size(136, 28)
        Me.Year_LevelTextBox.TabIndex = 12
        '
        'StudentListDataGridView
        '
        Me.StudentListDataGridView.AutoGenerateColumns = False
        Me.StudentListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.StudentListDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.StudentListDataGridView.DataSource = Me.StudentListBindingSource
        Me.StudentListDataGridView.Location = New System.Drawing.Point(37, 211)
        Me.StudentListDataGridView.Name = "StudentListDataGridView"
        Me.StudentListDataGridView.RowHeadersWidth = 51
        Me.StudentListDataGridView.RowTemplate.Height = 24
        Me.StudentListDataGridView.Size = New System.Drawing.Size(804, 396)
        Me.StudentListDataGridView.TabIndex = 13
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Student Number"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Student Number"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 125
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Last Name"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Last Name"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 125
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "First Name"
        Me.DataGridViewTextBoxColumn3.HeaderText = "First Name"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 125
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Middle Name"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Middle Name"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 125
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Program"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Program"
        Me.DataGridViewTextBoxColumn5.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 125
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Year Level"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Year Level"
        Me.DataGridViewTextBoxColumn6.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 125
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(883, 631)
        Me.Controls.Add(Me.StudentListDataGridView)
        Me.Controls.Add(Year_LevelLabel)
        Me.Controls.Add(Me.Year_LevelTextBox)
        Me.Controls.Add(ProgramLabel)
        Me.Controls.Add(Me.ProgramTextBox)
        Me.Controls.Add(Middle_NameLabel)
        Me.Controls.Add(Me.Middle_NameTextBox)
        Me.Controls.Add(First_NameLabel)
        Me.Controls.Add(Me.First_NameTextBox)
        Me.Controls.Add(Last_NameLabel)
        Me.Controls.Add(Me.Last_NameTextBox)
        Me.Controls.Add(Student_NumberLabel)
        Me.Controls.Add(Me.Student_NumberTextBox)
        Me.Controls.Add(Me.StudentListBindingNavigator)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.ListofStudentsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentListBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StudentListBindingNavigator.ResumeLayout(False)
        Me.StudentListBindingNavigator.PerformLayout()
        CType(Me.StudentListDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListofStudentsDataSet As ListofStudentsDataSet
    Friend WithEvents StudentListBindingSource As BindingSource
    Friend WithEvents StudentListTableAdapter As ListofStudentsDataSetTableAdapters.StudentListTableAdapter
    Friend WithEvents TableAdapterManager As ListofStudentsDataSetTableAdapters.TableAdapterManager
    Friend WithEvents StudentListBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents StudentListBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents Student_NumberTextBox As TextBox
    Friend WithEvents Last_NameTextBox As TextBox
    Friend WithEvents First_NameTextBox As TextBox
    Friend WithEvents Middle_NameTextBox As TextBox
    Friend WithEvents ProgramTextBox As TextBox
    Friend WithEvents Year_LevelTextBox As TextBox
    Friend WithEvents StudentListDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
End Class
