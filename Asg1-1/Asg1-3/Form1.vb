'by Tyson Kriner
Public Class Form1
    Dim rndNumber As Single ' random number is a single digit
    Dim randomNumberExample As New Random 'makes number random
    Dim Statement1 As String ' statements 1-4 are strings
    Dim Statement2 As String
    Dim Statement3 As String
    Dim Statement4 As String

    Private Sub Updatewisdom_Click(sender As Object, e As EventArgs) Handles Updatewisdom.Click
        Statement1 = "Curiosity Killed the Cat"
        Statement2 = "World is Your Oyster"
        Statement3 = "You Need Money To Make Money"
        Statement4 = "All good things come to those who wait"
        rndNumber = randomNumberExample.Next(1, 5) 'Fills the label randomly with statements 1-4
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

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close() 'Exits the program
    End Sub
End Class
