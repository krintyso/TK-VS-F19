Public Class Form1
    Sub Numbers()
        Dim firstNumber As Integer
        Dim secondNumber As Integer
        Dim result As Integer
        firstNumber = Convert.ToDecimal(firstNumbertextbox.Text)
        secondNumber = Convert.ToDecimal(secondNumbertextbox.Text)
        result = firstNumber + secondNumber
        Resulttextbox.Text = result
    End Sub

    Private Sub Calculate_Click(sender As Object, e As EventArgs) Handles Calculate.Click
        Numbers()
    End Sub
End Class

