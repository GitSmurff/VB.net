Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ReDim K(0 To n)
        If Not n >= 1 Or b < a Then
            MsgBox("Введены ошибочные параметры массива!", MsgBoxStyle.Critical, "Ошибка!")
            Exit Sub
        End If
        Randomize()
        For i = 1 To n
            K(i) = Rnd() * (b - a) + a
            RichTextBox1.Text = RichTextBox1.Text & K(i)
            If i <> n Then
                RichTextBox1.Text = RichTextBox1.Text & ", "
            End If
        Next
    End Sub
    'Function nummin(ByVal x() As Integer, ByVal m As Integer) As Integer
    'Dim min As Integer = x(m)
    'Dim NumberMin As Integer = m
    'For i = m To UBound(x)
    'If x(i) < min Then min = x(i) : NumberMin = i
    'Next
    'nummin = NumberMin
    'End Function
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Dim l As Integer
        'Dim t As Integer
        'Dim j As Integer
        'For j = LBound(K) To UBound(K)
        'l = nummin(K, j)
        't = K(j)
        'K(j) = K(l)
        'K(l) = t
        'Next
        'For j = LBound(K) To UBound(K)
        'RichTextBox2.Text = RichTextBox2.Text & K(j)
        'If i <> UBound(K) Then
        'RichTextBox2.Text = RichTextBox2.Text & ", "
        'End If
        'Next
        For i = 1 To n
            RichTextBox2.Text = RichTextBox2.Text & K(i) & Chr(13)
        Next i
        Array.Sort(K)
    End Sub
End Class