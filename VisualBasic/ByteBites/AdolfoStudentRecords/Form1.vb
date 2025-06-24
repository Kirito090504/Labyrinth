Public Class Form1
    Private Sub StudentListBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles StudentListBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.StudentListBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ListofStudentsDataSet)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ListofStudentsDataSet.StudentList' table. You can move, or remove it, as needed.
        Me.StudentListTableAdapter.Fill(Me.ListofStudentsDataSet.StudentList)

    End Sub
End Class
