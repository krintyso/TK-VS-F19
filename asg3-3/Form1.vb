'Tyson Kriner
'RCET0265
'asg3-3
'Inventory calculator 
'https://github.com/krintyso/TK-VS-F19
Public Class InventoryCalculator

    Private Sub CalculateButton_Click(sender As Object, e As EventArgs) Handles CalculateButton.Click
        Dim AverageInv As Double
        Dim BeginInv As Double
        Dim EndingInv As Double
        Dim CostofGoods As Double
        Dim Turnover As Decimal
        'Declares the variables as their correct data types
        Try
            CostofGoods = Decimal.Parse(Costofgoodstextbox.Text) 'CostofGoods variable is set to the decimal number of the user input from CostOfGoodstextbox
            BeginInv = Decimal.Parse(BeginInvTextBox.Text) 'BeginInv variable is set to the decimal number of the user input from BeginInventorytextbox
            EndingInv = Decimal.Parse(EndInvTextBox.Text) 'EndInv variable is set to the decimal number of the user input from EndInvTextbox
            AverageInv = (BeginInv + EndingInv) / 2 'The sum of the data from variables divided by 2 equals the average inventory
            Turnover = CostofGoods / AverageInv 'The turnover is the quotient of the CostofGoods over the AverageInv
            AverageInvtextbox.Text = AverageInv.ToString("C") 'The AverageInv variable is formatted as the "C" specifier code
            Turnovertextbox.Text = Decimal.Round(Turnover, 1) 'The turover variable is rounded to the 1st decimal 
        Catch anyException As FormatException 'The catch function anticipates any errors 
            MessageBox.Show("Please enter numeric value", "Invalid data") 'If the user enters incorrect data the 
        End Try
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click 'Clears all user data when the clear button is pressed
        BeginInvTextBox.Text = ""
        EndInvTextBox.Text = ""
        Costofgoodstextbox.Text = ""
        AverageInvtextbox.Text = ""
        Turnovertextbox.Text = ""
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close() 'Closes the program when the exit button is pressed.
    End Sub


End Class
