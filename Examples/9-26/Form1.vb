Public Class Form1
    Dim everyonecanseethis As Integer
    Sub RunningTotal()
        Static total As Integer

        total += 1
        everyonecanseethis += 1
        Console.WriteLine(total)
        Console.WriteLine(everyonecanseethis)

    End Sub

    Private Sub Form1_click(sender As Object, e As EventArgs) Handles Me.Click
        RunningTotal()
    End Sub
End Class
