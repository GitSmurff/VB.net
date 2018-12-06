Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim i As Integer
        For i = 1 To 4
            PictureBox1.Image = System.Drawing.Image.FromFile("D:\Документы\Политех\1курс\2 семестр\VB.net\images0" & i & ".jpg")
            MsgBox("Щелкните здесь, чтобы посмотреть след. рожицу")
        Next
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim f As Form2
        f = New Form2
        f.Show()
    End Sub
End Class
