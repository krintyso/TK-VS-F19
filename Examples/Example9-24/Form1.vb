Public Class Form1
    Private Sub GoButton_Click(sender As Object, e As EventArgs) Handles GoButton.Click
        CompareStrings()
    End Sub

    Sub CompareNumbers()
        Dim firstNumber As Integer
        Dim SecondNumber As Integer
        Dim ThirdNumber As Integer

        firstNumber = 1
        SecondNumber = 4
        ThirdNumber = 3

        'is third number between first and second number
        If ThirdNumber > firstNumber And ThirdNumber < SecondNumber Then

            MessageBox.Show("What up playa", "Super cool Title")

        Else
            'no condition was true
            MessageBox.Show("This ain't it chief", "Super Cool Title")
        End If

    End Sub

    Sub CompareStrings()
        Dim firstString As String
        Dim SecondString As String
        Dim x As String

        firstString = "A"
        SecondString = "Z"
        'x = Hex(90)
        'x = Chr(90)
        x =
        Console.WriteLine(firstString < SecondString)
        Console.WriteLine(x)
    End Sub
End Class
