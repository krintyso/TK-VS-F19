'Tyson Kriner
'RCET0265
'asg7-1
'rentalForm
'https://github.com/krintyso/TK-VS-F19

Option Strict On
Option Explicit On


Public Class Form1

    Dim errors As Boolean = False
    Dim stockNameDecisionSummary As String = ""

    Private Sub CalculateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CalculateToolStripMenuItem.Click
        Dim mondayPrice As Double
        Dim tuesdayPrice As Double
        Dim wednesdayPrice As Double
        Dim stockName As String
        Dim stockDecision As String
        Dim blankStringList As New List(Of String)


        InputValidation(mondayPrice, tuesdayPrice, wednesdayPrice, stockName)
        stockName = nameTextBox.Text
        If errors = False Then

            mondayPrice = Double.Parse(monPriceTextBox.Text)
            tuesdayPrice = Double.Parse(tuesPriceTextBox.Text)
            wednesdayPrice = Double.Parse(wedPriceTextBox.Text)
            buySellHoldTextbox.Text = Decision(mondayPrice, tuesdayPrice, wednesdayPrice)
            stockDecision = buySellHoldTextbox.Text

            stockNameDecisionSummary += "Stock name: " & stockName & " " & "Decision: " & stockDecision & vbNewLine


        End If



    End Sub
    Private Function Decision(ByVal mondayPrice As Double, ByVal tuesdayPrice As Double, ByVal wednesdayPrice As Double) As String
        Dim result As String
        Dim n1 As Double
        Dim n2 As Double
        Dim n3 As Double
        n1 = mondayPrice
        n2 = tuesdayPrice
        n3 = wednesdayPrice
        Dim choice As Boolean



        choice = True

        result = ""

        If n1 < n2 And n2 - n1 < n3 - n2 Then
            result = "Buy"
        ElseIf n1 > n2 And n1 - n2 < n2 - n3 Then
            result = "Sell"
        ElseIf choice = True Then
            result = "Hold"
        End If

        Return result
    End Function
    Private Sub InputValidation(mondayPrice As Double, tuesdayPrice As Double, wednesdayPrice As Double, stockName As String)
        Dim errorList As New List(Of String)
        Dim sErrors As String = ""

        If nameTextBox.Text = "" Then
            errorList.Add("Stock name cannot be empty")
            errors = True

        End If

        If monPriceTextBox.Text = "" Then
            errorList.Add("Monday price cannot be blank")
            errors = True
        ElseIf Double.TryParse(monPriceTextBox.Text, mondayPrice) Then
        Else errorList.Add("Invalid Monday Price")
            errors = True

        End If

        If tuesPriceTextBox.Text = "" Then
            errorList.Add("Tuesday price cannot be blank")
            errors = True

        ElseIf Double.TryParse(tuesPriceTextBox.Text, tuesdayPrice) Then
        Else errorList.Add("Invalid Tuesday Price")
            errors = True

        End If

        If wedPriceTextBox.Text = "" Then
            errorList.Add("Wednesday price cannot be empty")
            errors = True

        ElseIf Double.TryParse(wedPriceTextBox.Text, wednesdayPrice) Then
        Else errorList.Add("Invalid Wednesday Price")
            errors = True

        End If

        If errors = True Then
            For Each item As String In errorList
                sErrors &= item & " " & vbNewLine
            Next
            MessageBox.Show(sErrors, "Errors", MessageBoxButtons.OK)
        End If
    End Sub
    Private Sub ClearToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearToolStripMenuItem.Click
        nameTextBox.Text = ""
        monPriceTextBox.Text = ""
        tuesPriceTextBox.Text = ""
        wedPriceTextBox.Text = ""
        buySellHoldTextbox.Text = ""
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub SummaryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SummaryToolStripMenuItem.Click
        MessageBox.Show(stockNameDecisionSummary, "Summary", MessageBoxButtons.OK)
    End Sub
End Class
