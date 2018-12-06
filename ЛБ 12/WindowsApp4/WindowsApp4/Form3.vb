Public Class Form3
    Dim k As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Timer1.Enabled = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Timer1.Enabled = False
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        k = k + 1
        If k = 1 Then PictureBox1.Image = My.Resources._1
        If k = 2 Then PictureBox1.Image = My.Resources._2
        If k = 3 Then PictureBox1.Image = My.Resources._4
        If k = 4 Then PictureBox1.Image = My.Resources._4
        If k = 5 Then PictureBox1.Image = My.Resources._5
        If k = 6 Then PictureBox1.Image = My.Resources._6 : k = 0

    End Sub
End Class