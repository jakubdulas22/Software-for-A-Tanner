Public Class Form1
    Dim name As String

    Private Sub TabPage1_Click(sender As Object, e As EventArgs)

    End Sub
    Dim a As Integer = 0


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Not UserName.Text = "" Then
            a += 1

        End If
        If Not Password.Text - "" Then
            a += 1
        End If
        If a = 2 Then
            Write "Hey, your right"
        End If
    End Sub

End Class
