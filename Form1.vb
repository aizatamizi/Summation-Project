Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim intsum As Integer

        If (Val(TextBox1.Text) > 0) Then
            intsum = 0
            For x = 1 To Val(TextBox1.Text)
                intsum = intsum + x
            Next x
            Label2.Text = " Summmation of " & TextBox1.Text & " is " & Str(intsum) & "."
        Else
            Label2.Text = "Enter a positive integer only."
        End If
    End Sub
End Class
