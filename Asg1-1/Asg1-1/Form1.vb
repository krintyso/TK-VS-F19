'By Tyson Kriner

Public Class Form1

    Private Sub UpdateLabelHighValyrian_Click(sender As Object, e As EventArgs) Handles UpdateLabelHighValyrian.Click
        Label1.Text = "Rytsas vys" 'When the High valyrian button is pressed, hello world is translated in High valyrian
    End Sub

    Private Sub UpdateLabelKlingon_Click(sender As Object, e As EventArgs) Handles UpdateLabelKlingon.Click
        Label1.Text = "qo' vIvan" 'When the Klingon button is pressed, hello world is translated in Klingon
    End Sub

    Private Sub UpdateLabelEnglish_Click(sender As Object, e As EventArgs) Handles UpdateLabelEnglish.Click
        Label1.Text = "Hello World" 'When the English button is pressed, hello world is translated in english
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

End Class
