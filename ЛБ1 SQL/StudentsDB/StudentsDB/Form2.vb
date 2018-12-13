Public Class Form2
    Private Sub СпециальностиBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles СпециальностиBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.СпециальностиBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.StudentsDataSet)

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "StudentsDataSet.Специальности". При необходимости она может быть перемещена или удалена.
        Me.СпециальностиTableAdapter.Fill(Me.StudentsDataSet.Специальности)

    End Sub
End Class