Public Class ListExampleForm
    Sub CreateList()
        Dim namesList As New List(Of String)
        Dim numbers As New List(Of Integer)(New Integer() {3, 5, 7, 2, 8})

        namesList.Add("Bill")
        namesList.Add("Emily")
        namesList.Add("Joe")
        namesList.Add("Nancy")

        'Console.WriteLine(namesList(2))

        'For Each name As String In namesList
        '    Console.WriteLine(name)
        'Next

        'For i = 0 To namesList.Count - 1 Step 2
        '    Console.WriteLine(namesList(i))
        'Next

        For Each amount As Integer In numbers
            Console.WriteLine(amount.ToString("C"))
        Next
    End Sub

    Private Sub ListExampleForm_Load(sender As Object, e As EventArgs) Handles Me.Click

        CreateList()

    End Sub

    Sub FormatExample()
        'format data in nice rows and columns
        Dim output As String
        output = ""

        For column = 1 To 12
            output &= Str(column)
        Next
        Console.WriteLine(output)



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Function invoiceHeader() As String

    End Function
End Class
