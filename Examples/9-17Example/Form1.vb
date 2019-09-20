Option Explicit On
Option Strict On
Public Class UserInput
    Private Sub Getinputbutton_Click(sender As Object, e As EventArgs) Handles Getinputbutton.Click
        Dim firstNumber As Integer
        Dim secondNumber As Integer
        Dim resultNumber As Integer

        secondNumber = 7

        'firstNumber = Convert.ToInt32(NumberTextBox.Text)
        Try
            Console.WriteLine("In the Try code")
            firstNumber = Integer.Parse(NumberTextBox.Text)
        Catch ex As Exception
            Console.WriteLine("In the catch code")
            Console.WriteLine(ex.Message)
            NumberTextBox.Text = ""
            MsgBox("Please enter a valid number", , "You done messed up")
            NumberTextBox.Select()


        Finally
            Console.WriteLine("In the Finally code")
        End Try

        resultNumber = firstNumber + secondNumber
        Console.WriteLine(resultNumber)
    End Sub
End Class
