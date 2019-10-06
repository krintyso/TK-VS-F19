'Tyson Kriner
'RCET0265
'asg4-1
'MathContestForm
'https://github.com/krintyso/TK-VS-F19



Option Explicit On
Option Strict On


Public Class MathContest

    Private totalRight As Integer
    Private totalWrong As Integer

    Public Sub MathContest_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Refreshvalues() 'When the form loads, 1st and 2nd numbers are refreshed
    End Sub

    Sub Refreshvalues()
        Dim rn1 As New Random
        Dim firstNum As Integer
        Dim secondNum As Single

        firstNum = (rn1.Next(1, 10)) 'generates a random number for the 1st text box
        secondNum = Int((10 * Rnd() + 1)) 'generates a different random number for the 2nd text box


        firstNumbertextbox.Text = firstNum.ToString 'Converts the firstNum variable to a string and displays it in the text box
        secondNumbertextbox.Text = secondNum.ToString 'Converts the secondNum variable to a string and displays it in the text box


    End Sub


    Private Sub Message(Correctanswer As Decimal)
        If Decimal.Parse(StudentAnswerTextbox.Text) <> Correctanswer Then 'If the student answer doesn't match the correct answer, then the "incorrect answer" message box is displayed and the total wrong variable is incremented
            MessageBox.Show("Incorrect Answer, the correct answer is " & Correctanswer, "oopsies", MessageBoxButtons.OK)
            totalWrong += 1
        ElseIf Decimal.Parse(StudentAnswerTextbox.Text) = Correctanswer Then 'If the student answer does match the correct answer, then the "correct answer" message box is displayed and the total right variable is incremented
            MessageBox.Show("Congrats! Correct answer!", "Nice Job", MessageBoxButtons.OK)
            totalRight += 1
        End If
    End Sub

    Private Sub SubmitButton_Click(sender As Object, e As EventArgs) Handles SubmitButton.Click
        Dim correctanswer As Decimal
        Dim firstNumber As Decimal
        Dim secondNumber As Decimal
        Dim StudentInfoError As Boolean

        If NameTextbox.Text = "" Then 'If the name text box is empty than the "invalid name" message box is displayed
            MessageBox.Show("Please enter student's name", "Invalid Name", MessageBoxButtons.OK)
            NameTextbox.Select()
            StudentInfoError = True
        ElseIf Integer.Parse(GradeMaskTextbox.Text) < 1 Or 'If the grade masked text box is greater than 4 or less than 1, then the "Invalid Grade" message box is shown 
               Integer.Parse(GradeMaskTextbox.Text) > 4 Or
               GradeMaskTextbox.Text = "" Then
            MessageBox.Show("Grade can only be 1-4", "Invalid Grade", MessageBoxButtons.OK)
            StudentInfoError = True
        ElseIf Integer.Parse(AgeMaskTextbox.Text) < 4 Or 'If the age masked text box is greater than 11 or less than 4, then the "Invalid Age" message box is shown
               Integer.Parse(AgeMaskTextbox.Text) > 11 Or
               AgeMaskTextbox.Text = "" Then
            MessageBox.Show("Age can only be 4-11", "Invalid Age", MessageBoxButtons.OK)
            StudentInfoError = True
        End If


        Select Case StudentInfoError
            Case True 'If the Student info error is true then no action is taken

            Case False 'If the student info error is false, then the answer is produced based on which radio button is checked
                Try
                    If AddRadioButton.Checked Then
                        firstNumber = Decimal.Parse(firstNumbertextbox.Text)
                        secondNumber = Decimal.Parse(secondNumbertextbox.Text)
                        correctanswer = firstNumber + secondNumber
                    ElseIf SubRadioButton.Checked Then
                        firstNumber = Decimal.Parse(firstNumbertextbox.Text)
                        secondNumber = Decimal.Parse(secondNumbertextbox.Text)
                        correctanswer = firstNumber - secondNumber
                    ElseIf MultiplyRadioButton.Checked Then
                        firstNumber = Decimal.Parse(firstNumbertextbox.Text)
                        secondNumber = Decimal.Parse(secondNumbertextbox.Text)
                        correctanswer = firstNumber * secondNumber
                    ElseIf DivideRadioButton.Checked Then
                        firstNumber = Decimal.Parse(firstNumbertextbox.Text)
                        secondNumber = Decimal.Parse(secondNumbertextbox.Text)
                        correctanswer = firstNumber / secondNumber
                    End If
                Catch ex As System.Exception
                    MessageBox.Show("Please enter valid number", "Invalid Data", MessageBoxButtons.OK) 'This catches any invalid data being entered

                End Try
                Message(correctanswer)

        End Select



    End Sub

    Private Sub RefreshButton_Click(sender As Object, e As EventArgs) Handles RefreshButton.Click 'When the refresh button is pressed, the values are refreshed
        Refreshvalues()
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click 'When the clear button is pressed then the text boxes are cleared
        NameTextbox.Text = ""
        AgeMaskTextbox.Text = ""
        GradeMaskTextbox.Text = ""
        StudentAnswerTextbox.Text = ""

    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click 'when the exit button is pressed, then the program is closed
        Me.Close()
    End Sub

    Private Sub SummaryButton_Click(sender As Object, e As EventArgs) Handles SummaryButton.Click 'when the summary button is pressed, a message box shows the total correct and incorrect answers.
        MessageBox.Show(NameTextbox.Text & " had " & totalRight & " correct " &
                       " and " & totalWrong & " incorrect ")

    End Sub


End Class





























































































