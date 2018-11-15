Imports System
Imports System.IO
Imports System.Text
Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Try
            Dim sr As StreamReader = New StreamReader("File.txt")
            Dim line As String
            RichTextBox1.Clear()
            Do
                line = sr.ReadLine()
                RichTextBox1.Text = RichTextBox1.Text & line & Chr(13)
            Loop Until line Is Nothing
            sr.Close()
        Finally
            TextBox1.Clear()
            TextBox1.Text = "Файл читается:"
        End Try

    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            RichTextBox1.Clear()
            Dim sr As StreamReader = New StreamReader("File.txt")
            Dim a As Integer
            a = TextBox3.Text
            Dim ar As Char() = New Char(a) {}
            sr.Read(ar, 0, a)
            RichTextBox1.Text = RichTextBox1.Text & ar & Chr(13)
            sr.Close()
        Finally
            TextBox1.Clear()
            TextBox1.Text = "Файл читается:"
        End Try
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            'читаем данные в массив
            Dim ArryTast() As String = IO.File.ReadAllLines("File.txt", System.Text.Encoding.Default)
            For i As Integer = 0 To ArryTast.Count - 1 'перебираем все элементы массива
                If IsNumeric(ArryTast(i)) = True Then 'если True то число
                    RichTextBox2.Text = RichTextBox2.Text & vbCrLf & ArryTast(i) 'числа
                End If
            Next

        Finally
            TextBox1.Clear()
            TextBox1.Text = "Файл читается:"
        End Try
    End Sub

    
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            Using reader As New StreamReader("File.txt")
                Text = reader.ReadToEnd()
            End Using
            Using writer As New StreamWriter("File.txt", False, System.Text.Encoding.UTF8)
                writer.WriteLine(Text)
            End Using

            Using writer As New StreamWriter("File.txt", True, System.Text.Encoding.UTF8)
                writer.WriteLine(RichTextBox1.Text)
                writer.Write(4.5)
            End Using
        Finally
            TextBox1.Text = "Файл записался:"
        End Try
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TextBox1.Clear()
        TextBox2.Clear()
        RichTextBox1.Clear()
        RichTextBox2.Clear()
    End Sub
End Class
