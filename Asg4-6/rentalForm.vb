'Tyson Kriner
'RCET0265
'asg4-6
'rentalForm
'https://github.com/krintyso/TK-VS-F19

Option Strict On
Option Explicit On

Public Class rentalForm

    Dim beginOdometer As Decimal
    Dim endOdometer As Decimal
    Dim days As Double
    Dim daysTotal As Double
    Dim dayCharge As Double
    Dim Distance As Double
    Dim totalCost As Double
    Dim costTotal As Double
    Dim totalCharge As Double
    Dim milesTotal As Double
    Dim milesCharge As Double
    Dim Distance2 As Double
    Dim Discount As Double
    Dim numberofCustomers As Integer
    Private Sub CalculateButton_Click(sender As Object, e As EventArgs) Handles calculateButton.Click
        Dim beginOdometerStr As String
        Dim endOdometerStr As String
        Dim daysStr As String
        beginOdometerStr = beginOdometerTextBox.Text
        endOdometerStr = endOdometerTextBox.Text
        daysStr = daysTextBox.Text


        InputValidation()


        beginOdometer = Decimal.Parse(beginOdometerStr)
        endOdometer = Decimal.Parse(endOdometerStr)
        days = Decimal.Parse(daysStr)





        If beginOdometer > endOdometer Then
            MessageBox.Show("Beginning odometer cannot be larger than ending odometer", "Invalid odometer", MessageBoxButtons.OK)
            beginOdometerTextBox.SelectAll()
        ElseIf days < 0 Or days > 45 Then
            MessageBox.Show("Number of days cannot be less than 0 or greater than 45", "Invalid days", MessageBoxButtons.OK)
            daysTextBox.SelectAll()
        End If

        Try
            dayCharge = days * 15
            dayChargeLabel.Text = dayCharge.ToString("C")
            If milesRadioButton.Checked = True Then
                Distance = endOdometer - beginOdometer
                milesDrivenLabel.Text = Distance.ToString
            ElseIf kilometersRadioButton.Checked = True Then
                Distance = (endOdometer - beginOdometer) * 0.62
                milesDrivenLabel.Text = Distance.ToString
            End If
            If Distance <= 200.0 Then
                milesCharge = 0.00
                mileChargeLabel.Text = milesCharge.ToString("C")

            ElseIf Distance >= 500.0 Then
                milesCharge = (300.0 * 0.12) + ((Distance - 500.0) * 0.1)

                mileChargeLabel.Text = milesCharge.ToString("C")
            ElseIf Distance <= 500.0 And Distance >= 200.0 Then
                Distance2 = Distance - 200.0
                milesCharge = Distance2 * 0.12
                mileChargeLabel.Text = milesCharge.ToString("C")
            End If
            If aaaCheckBox.Checked = True Then
                Discount = totalCost * 0.05
                discountLabel.Text = Discount.ToString("C")
            ElseIf seniorCheckBox.Checked = True Then
                Discount = totalCost * 0.03
                discountLabel.Text = Discount.ToString("C")
            ElseIf aaaCheckBox.Checked = True And seniorCheckBox.Checked = True Then
                Discount = totalCost * 0.08
                discountLabel.Text = Discount.ToString("C")
            End If
            totalCost = milesCharge + dayCharge
            totalCharge = totalCost - Discount
            youOweLabel.Text = totalCharge.ToString("C")


            discountLabel.BackColor = Color.White
            milesDrivenLabel.BackColor = Color.White
            youOweLabel.BackColor = Color.White
            mileChargeLabel.BackColor = Color.White
            dayChargeLabel.BackColor = Color.White


            numberofCustomers += 1

        Catch ex As FormatException
            InputValidation()
        Catch ex1 As InvalidCastException
            MessageBox.Show("Invalid Conversion", "Illegal conversion", MessageBoxButtons.OK)
        Catch ex2 As ArithmeticException
            MessageBox.Show("Division by zero or variable overflow", "Invalid Calculation", MessageBoxButtons.OK)
        Catch ex3 As OutOfMemoryException
            MessageBox.Show("Not enough memory", "Out of Memory", MessageBoxButtons.OK)
        End Try

        milesDrivenLabel.Text = Distance.ToString
        youOweLabel.Text = totalCharge.ToString("C")
        mileChargeLabel.Text = milesCharge.ToString("C")
        discountLabel.Text = Discount.ToString("C")

        Totals(Distance, milesCharge, dayCharge, totalCost)

    End Sub
    Private Sub Totals(ByVal Distance As Double, ByVal milesCharge As Double, ByVal daycharge As Double, ByVal totalCost As Double)
        Static daysTotal As Double
        Static milesTotal As Double
        Static costTotal As Double

        daysTotal += Distance
        milesTotal += milesCharge
        costTotal += totalCost

    End Sub
    Private Sub SummaryButton_Click(sender As Object, e As EventArgs) Handles summaryButton.Click
        Dim summarylist As New List(Of String)
        Dim numberofCustomers As Integer


        summarylist.Add(daysTotal.ToString)
        summarylist.Add(milesTotal.ToString("C"))
        summarylist.Add(costTotal.ToString("C"))
        summarylist.Add(numberofCustomers.ToString)



        MessageBox.Show(summarylist.ToString, "Summary", MessageBoxButtons.OK)

    End Sub
    Private Sub InputValidation()
        Dim nameCheck As Integer
        Dim cityCheck As Integer
        Dim stateCheck As Integer
        Dim zipCheck As Integer
        Dim beginodCheck As Integer
        Dim endodCheck As Integer
        Dim daysCheck As Integer
        Dim errorList As New List(Of String)
        Dim sErrors As String = " "



        nameCheck = VarType(nameTextBox.Text)
        cityCheck = VarType(cityTextBox.Text)
        stateCheck = VarType(stateTextBox.Text)
        zipCheck = VarType(zipCodeTextBox.Text)
        beginodCheck = VarType(beginOdometerTextBox.Text)
        endodCheck = VarType(endOdometerTextBox.Text)
        daysCheck = VarType(daysTextBox.Text)

        If nameCheck <> 8 Then
            errorList.Add("Invalid name")
            nameTextBox.SelectAll()
        End If
        If cityCheck <> 8 Then
            errorList.Add("Invalid city")
            cityTextBox.SelectAll()
        End If
        If stateCheck <> 8 Then
            errorList.Add("Invalid state")
            stateTextBox.SelectAll()
        End If

        If zipCheck <> 2 Then
            errorList.Add("Invalid zip code")
            zipCodeTextBox.SelectAll()
        End If

        If beginodCheck <> 14 Then
            errorList.Add("Invalid Beginning Odometer")
            beginOdometerTextBox.SelectAll()
        End If
        If endodCheck <> 14 Then
            errorList.Add("Invalid Ending Odometer")
            endOdometerTextBox.SelectAll()
        End If
        If daysCheck <> 2 Then
            errorList.Add("Invalid Number of days")
            daysTextBox.SelectAll()
        End If

        For Each item As String In errorList
            sErrors &= item & " "
        Next

        'MessageBox.Show(sErrors, "Errors", MessageBoxButtons.OK)
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click

        DialogResult = MessageBox.Show("Are you sure you want to exit", "Exit", MessageBoxButtons.YesNo)

        If DialogResult = DialogResult.Yes Then
            Me.Close()
        End If

    End Sub
End Class