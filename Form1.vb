Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        HookApplication(TextBox1.Text)

        MsgBox("Success")
    End Sub
End Class
