Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim sum, i As Integer
        sum = 0
        For i = 1 To 10 Step 1
            sum = sum + 5
        Next i
        TextBox1.Text = sum

    End Sub
End Class
