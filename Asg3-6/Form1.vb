
'Tyson Kriner
'RCET0265
'asg3-6
'ShippingCostCalculatorForm
'https://github.com/krintyso/TK-VS-F19
Public Class ShippingCostCalculatorForm

    Const SHIPPING_RATE_Decimal As Decimal = 0.12  'Sets the shipping rate as a constant

    Private Sub CalculateButto_Click(sender As Object, e As EventArgs) Handles CalculateButto.Click
        Dim TotalWeight As Decimal
        Dim Weightinlb As Decimal
        Dim ShippingCharge As Decimal
        Dim LbToOz As Decimal
        Dim Oz As Decimal
        Dim Mycheck1 As Integer
        Dim Mycheck2 As Integer





        Try
            Weightinlb = (Decimal.Parse(lbTextbox.Text)) 'Converts lbtextbox.text to a decimal
            LbToOz = (Weightinlb * 16) 'converts lbs to oz
            Oz = Decimal.Parse(Oztextbox.Text) 'converts oztextbox.text to decimal
            Mycheck1 = VarType(Weightinlb) 'Check data type of Weigtinlb
            Mycheck2 = VarType(Oz) 'Checks data type of oz 


            ShippingCharge = (TotalWeight * SHIPPING_RATE_Decimal) 'Calculates the shipping charge
            ShippingChargeTextBox.Text = ShippingCharge.ToString("C") 'Displays shipping charge as a currency


        Catch theException As FormatException 'catches invalid data types
            MessageBox.Show("Please enter Numeric Value", "Invalid Data Type", MessageBoxButtons.OK) 'Displays error message

            If Mycheck1 <> 14 Then 'Checks if weightinlb is correct data type, if not lbtextbox is highlighted
                lbTextbox.Focus()
                lbTextbox.SelectAll()

            ElseIf Mycheck2 <> 14 Then 'Checks if oz is correct data type, if not oztextbox is highlighted
                Oztextbox.Focus()
                Oztextbox.SelectAll()
            End If
        End Try

    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click 'Clears data in textboxes
        IDTextBox.Text = ""
        lbTextbox.Text = ""
        Oztextbox.Text = ""
        ShippingChargeTextBox.Text = ""

    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click 'closes program
        Me.Close()

    End Sub



End Class
