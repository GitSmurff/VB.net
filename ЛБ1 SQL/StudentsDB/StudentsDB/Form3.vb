Public Class Form3
    Private Sub ПредметыBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ПредметыBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ПредметыBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.StudentsDataSet)

    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "StudentsDataSet.Предметы". При необходимости она может быть перемещена или удалена.
        Me.ПредметыTableAdapter.Fill(Me.StudentsDataSet.Предметы)

    End Sub
End Class