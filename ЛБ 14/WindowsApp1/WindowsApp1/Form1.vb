Public Class Form1
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label1.Text = TimeString & vbCrLf & System.DateTime.Now
    End Sub

End Class
