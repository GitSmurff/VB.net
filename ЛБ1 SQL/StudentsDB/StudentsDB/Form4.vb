Public Class Form4
    Private Sub СтудентыBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles СтудентыBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.СтудентыBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.StudentsDataSet)

    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "StudentsDataSet.Специальности". При необходимости она может быть перемещена или удалена.
        Me.СпециальностиTableAdapter.Fill(Me.StudentsDataSet.Специальности)
        'TODO: данная строка кода позволяет загрузить данные в таблицу "StudentsDataSet.Студенты". При необходимости она может быть перемещена или удалена.
        Me.СтудентыTableAdapter.Fill(Me.StudentsDataSet.Студенты)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        СтудентыBindingSource.MoveFirst()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        СтудентыBindingSource.MovePrevious()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        СтудентыBindingSource.AddNew()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        СтудентыBindingSource.MoveLast()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        СтудентыBindingSource.MoveNext()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        СтудентыBindingSource.RemoveCurrent()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Me.Validate()
        Me.СтудентыBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.StudentsDataSet)
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Form6.Show()
    End Sub
End Class