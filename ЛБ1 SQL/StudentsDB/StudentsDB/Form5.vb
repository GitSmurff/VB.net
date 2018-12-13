Public Class Form5
    Private Sub ОценкиBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ОценкиBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ОценкиBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.StudentsDataSet)

    End Sub

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "StudentsDataSet.Оценки". При необходимости она может быть перемещена или удалена.
        Me.ОценкиTableAdapter.Fill(Me.StudentsDataSet.Оценки)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Средний_баллTextBox.Text = (Val(Оценка_1TextBox.Text) + Val(Оценка_2TextBox.Text) + Val(Оценка_3TextBox.Text)) / 3
    End Sub
End Class