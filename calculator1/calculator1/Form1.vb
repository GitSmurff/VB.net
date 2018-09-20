Public Class Form1
    Dim x1 As Decimal
    Dim x2 As Decimal
    Dim y1 As Integer
    Dim y2 As Boolean = False

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        If y2 = True Then
            x2 = TextBox1.Text
            If y1 = 1 Then
                TextBox1.Text = x1 + x2
            ElseIf y1 = 2 Then
                TextBox1.Text = x1 - x2
            ElseIf y1 = 3 Then
                TextBox1.Text = x1 * x2
            ElseIf y1 = 5 Then
                TextBox1.Text = x1 ^ x2
            Else
                If x2 = 0 Then
                    TextBox1.Text = "Ошибка! Проверьте свой процесс."
                Else
                    TextBox1.Text = x1 / x2
                End If
            End If
            y2 = False
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Text = "0"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox1.Text <> "0" Then
            TextBox1.Text += "1"
        Else
            TextBox1.Text = "1"
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If TextBox1.Text <> "0" Then
            TextBox1.Text += "2"
        Else
            TextBox1.Text = "2"
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If TextBox1.Text <> "0" Then
            TextBox1.Text += "3"
        Else
            TextBox1.Text = "3"
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If TextBox1.Text <> "0" Then
            TextBox1.Text += "4"
        Else
            TextBox1.Text = "4"
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If TextBox1.Text <> "0" Then
            TextBox1.Text += "5"
        Else
            TextBox1.Text = "5"
        End If
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If TextBox1.Text <> "0" Then
            TextBox1.Text += "6"
        Else
            TextBox1.Text = "6"
        End If
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        If TextBox1.Text <> "0" Then
            TextBox1.Text += "7"
        Else
            TextBox1.Text = "7"
        End If
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        If TextBox1.Text <> "0" Then
            TextBox1.Text += "8"
        Else
            TextBox1.Text = "8"
        End If
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        If TextBox1.Text <> "0" Then
            TextBox1.Text += "9"
        Else
            TextBox1.Text = "9"
        End If
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        If TextBox1.Text <> "0" Then
            TextBox1.Text += "0"
        End If
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        If Not (TextBox1.Text.Contains(".")) Then
            TextBox1.Text += ","
        End If
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        x1 = TextBox1.Text
        TextBox1.Text = ""
        y2 = True
        y1 = 2 ' - -
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        x1 = TextBox1.Text
        TextBox1.Text = ""
        y2 = True
        y1 = 1 ' = +
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        x1 = TextBox1.Text
        TextBox1.Text = ""
        y2 = True
        y1 = 4 ' /
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        x1 = TextBox1.Text
        TextBox1.Text = ""
        y2 = True
        y1 = 3 '=x
    End Sub
    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        If TextBox1.Text <> "0" Then
            x1 = CDbl(TextBox1.Text)
            TextBox1.Text = Math.Cos(x1)
        End If
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        If TextBox1.Text <> "0" Then
            x1 = CDbl(TextBox1.Text)
            TextBox1.Text = Math.Sin(x1)
        End If
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        If TextBox1.Text <> "0" Then
            x1 = CDbl(TextBox1.Text)
            TextBox1.Text = Math.Tan(x1)
        End If
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        If TextBox1.Text <> "0" Then
            x1 = CDbl(TextBox1.Text)
            TextBox1.Text = Math.Sqrt(x1)
        End If
    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        If TextBox1.Text <> "0" Then
            x1 = CDbl(TextBox1.Text)
            TextBox1.Text = Math.Log(x1)
        End If
    End Sub

    Private Sub Button23_Click(sender As Object, e As EventArgs) Handles Button23.Click
        If TextBox1.Text <> "0" Then
            x1 = CDbl(TextBox1.Text)
            TextBox1.Text = Math.Exp(x1)
        End If
    End Sub

    Private Sub Button24_Click(sender As Object, e As EventArgs) Handles Button24.Click
        x1 = TextBox1.Text
        TextBox1.Text = ""
        y2 = True
        y1 = 5 '^
    End Sub

    Private Sub Button25_Click(sender As Object, e As EventArgs) Handles Button25.Click
        If TextBox1.Text <> "0" Then
            x1 = CDbl(TextBox1.Text)
            TextBox1.Text = x1 * 3.14159265359
        End If
    End Sub

    Private Sub Button26_Click(sender As Object, e As EventArgs)
        If TextBox1.Text <> "0" Then
            x1 = CDbl(TextBox1.Text)
            TextBox1.Text = Math.Ans(x1)
        End If
    End Sub
End Class
