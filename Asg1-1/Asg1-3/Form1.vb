Public Class Form1
    Dim rndNumber As Single
    Dim randomNumberExample As New Random
    Dim Statement1 As String
    Dim Statement2 As String
    Dim Statement3 As String
    Dim Statement4 As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Statement1 = "Curiosity Killed the Cat"
        Statement2 = "World is Your Oyster"
        Statement3 = "You Need Money To Make Money"
        Statement4 = "All good things come to those who wait"
        rndNumber = randomNumberExample.Next(1, 5)
        If rndNumber = 1 Then
            Label1.Text = Statement1
        ElseIf rndNumber = 2 Then
            Label1.Text = Statement2
        ElseIf rndNumber = 3 Then
            Label1.Text = Statement3
        ElseIf rndNumber = 4 Then
            Label1.Text = Statement4
        End If
    End Sub
End Class
