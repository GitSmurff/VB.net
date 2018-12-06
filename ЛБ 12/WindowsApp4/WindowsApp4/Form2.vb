Public Class Form2
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        PictureBox1.Visible = False 'сделать 1 картинку невидимой
        Timer1.Enabled = False 'вюкл. первый таймер
        PictureBox2.Visible = True 'сделать  2 картинку видимой 
        Timer2.Enabled = True 'включить второй таймер
        Timer2.Interval = 400
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        PictureBox2.Visible = False
        Timer2.Enabled = False
        PictureBox1.Visible = True
        Timer1.Enabled = True
        Timer1.Interval = 400
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim f As Form3
        f = New Form3
        f.Show()
    End Sub
End Class