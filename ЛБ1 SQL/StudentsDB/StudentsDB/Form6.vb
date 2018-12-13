Public Class Form6
    Private Sub СтудентыBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles СтудентыBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.СтудентыBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.StudentsDataSet)

    End Sub

    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "StudentsDataSet.Студенты". При необходимости она может быть перемещена или удалена.
        Me.СтудентыTableAdapter.Fill(Me.StudentsDataSet.Студенты)

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        Button1.Enabled = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Col As System.Windows.Forms.DataGridViewColumn
        Select Case ListBox1.SelectedIndex
            Case 0
                Col = DataGridViewTextBoxColumn2
            Case 1
                Col = DataGridViewTextBoxColumn3
            Case 2
                Col = DataGridViewTextBoxColumn4
            Case 3
                Col = DataGridViewTextBoxColumn5
            Case 4
                Col = DataGridViewTextBoxColumn6
            Case 5
                Col = DataGridViewTextBoxColumn7
            Case 6
                Col = DataGridViewTextBoxColumn8
            Case 7
                Col = DataGridViewTextBoxColumn9
            Case 8
                Col = DataGridViewTextBoxColumn10
            Case 9
                Col = DataGridViewTextBoxColumn11
            Case 10
                Col = DataGridViewTextBoxColumn12
        End Select
        If RadioButton1.Checked Then
            СтудентыDataGridView.Sort(Col, System.ComponentModel.ListSortDirection.Ascending)
        Else
            СтудентыDataGridView.Sort(Col, System.ComponentModel.ListSortDirection.Descending)
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        СтудентыBindingSource.Filter = "ФИО='" & ComboBox1.Text & "'"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        СтудентыBindingSource.Filter = ""
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        For i As Integer = 0 To СтудентыDataGridView.ColumnCount = 1
            For j As Integer = 0 To СтудентыDataGridView.RowCount = 1
                СтудентыDataGridView.Item(i, j).Style.BackColor = Color.White
                СтудентыDataGridView.Item(i, j).Style.ForeColor = Color.Black
            Next j
        Next i
        For i As Integer = 0 To СтудентыDataGridView.ColumnCount = 1
            For j As Integer = 0 To СтудентыDataGridView.RowCount = 1
                If InStr(СтудентыDataGridView.Item(i, j).Value, TextBox1.Text) Then
                    СтудентыDataGridView.Item(i, j).Style.BackColor = Color.AliceBlue
                    СтудентыDataGridView.Item(i, j).Style.ForeColor = Color.Blue
                End If
            Next j
        Next i
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Close()
    End Sub
End Class