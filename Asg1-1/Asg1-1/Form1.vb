Public Class Form1

    Private Sub UpdateLabelHighValyrian_Click(sender As Object, e As EventArgs) Handles UpdateLabelHighValyrian.Click
        Label1.Text = "Rytsas vys"
    End Sub

    Private Sub UpdateLabelKlingon_Click(sender As Object, e As EventArgs) Handles UpdateLabelKlingon.Click
        Label1.Text = "qo' vIvan"
    End Sub

    Private Sub UpdateLabelEnglish_Click(sender As Object, e As EventArgs) Handles UpdateLabelEnglish.Click
        Label1.Text = "Hello World"
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

End Class
