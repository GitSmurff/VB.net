Public Class Form1
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        MsgBox("Извините, время вышло.")
        End
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "nikita5567" Then
            Timer1.Enabled = False
            MsgBox("Добро пожаловать в систему!")
            End
        Else
            MsgBox("Извините, я вас не знаю.")
        End If

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim i As Integer
        For i = 1 To 10
            MsgBox("Нажмите ОК!")
        Next i
        Dim InpName As String
        For i = 1 To 10
            InpName = InputBox("Имя?")
            If InpName = "Nikita" Then Exit For
            TextBox1.Text = InpName
        Next i
        Dim Query As String = ""
        Do While Query <> "Yes"
            Query = InputBox("Никита?")
            If Query = "Yes" Then MsgBox("Привет")
        Loop
        Dim GiveIn As String
        Do
            GiveIn = InputBox("Say 'Uncle'")
        Loop Until GiveIn = "Uncle"

    End Sub
End Class
