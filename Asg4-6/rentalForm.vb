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
    Dim distanceTotal As Double
    Dim dayCharge As Double
    Dim Distance As Double
    Dim totalCost As Double
    Dim costTotal As Double
    Dim totalCharge As Double
    Dim milesCharge As Double
    Dim Distance2 As Double
    Dim Discount As Double
    Dim numberofCustomers As Integer
    Dim errors As Boolean = False
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

        If errors = False Then
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




            Catch ex As FormatException
                InputValidation()
            Catch ex1 As InvalidCastException
                MessageBox.Show("Invalid Conversion", "Illegal conversion", MessageBoxButtons.OK)
            Catch ex2 As ArithmeticException
                MessageBox.Show("Division by zero or variable overflow", "Invalid Calculation", MessageBoxButtons.OK)
            Catch ex3 As OutOfMemoryException
                MessageBox.Show("Not enough memory", "Out of Memory", MessageBoxButtons.OK)
            End Try
        End If

        milesDrivenLabel.Text = Distance.ToString
        youOweLabel.Text = totalCharge.ToString("C")
        mileChargeLabel.Text = milesCharge.ToString("C")
        discountLabel.Text = Discount.ToString("C")

        Totals(Distance, milesCharge, dayCharge, totalCost)

    End Sub
    Private Sub Totals(ByVal Distance As Double, ByVal milesCharge As Double, ByVal daycharge As Double, ByVal totalCost As Double)

        numberofCustomers += 1
        distanceTotal += Distance
        costTotal += totalCost

    End Sub
    Private Sub SummaryButton_Click(sender As Object, e As EventArgs) Handles summaryButton.Click
        Dim summarylist As New List(Of String)
        Dim sSummary As String = " "


        summarylist.Add("Total miles: " & distanceTotal.ToString)
        summarylist.Add("Total charges: " & costTotal.ToString("C"))
        summarylist.Add("Total customers: " & numberofCustomers.ToString)

        For Each item As String In summarylist
            sSummary &= item & " " & vbNewLine
        Next


        MessageBox.Show(sSummary, "Summary", MessageBoxButtons.OK)

    End Sub
    Private Sub InputValidation()
        Dim nameCheck As Double
        Dim cityCheck As Double
        Dim stateCheck As Double
        Dim zipCheck As Double
        Dim beginodCheck As Double
        Dim endodCheck As Double
        Dim daysCheck As Double
        Dim errorList As New List(Of String)
        Dim sErrors As String = " "





        If Double.TryParse(nameTextBox.Text, nameCheck) Then
            errorList.Add("Invalid name")
            nameTextBox.SelectAll()
            errors = True
        End If
        If Double.TryParse(cityTextBox.Text, cityCheck) Then
            errorList.Add("Invalid city")
            cityTextBox.SelectAll()
            errors = True
        End If
        If Double.TryParse(stateTextBox.Text, stateCheck) Then
            errorList.Add("Invalid state")
            stateTextBox.SelectAll()
            errors = True
        End If

        If Double.TryParse(zipCodeTextBox.Text, zipCheck) Then
        Else
            errorList.Add("Invalid zip code")
            zipCodeTextBox.SelectAll()
            errors = True
        End If

        If Double.TryParse(beginOdometerTextBox.Text, beginodCheck) Then
        Else
            errorList.Add("Invalid Beginning Odometer")
            beginOdometerTextBox.SelectAll()
            errors = True
        End If

        If Double.TryParse(endOdometerTextBox.Text, endodCheck) Then
        Else
            errorList.Add("Invalid Ending Odometer")
            endOdometerTextBox.SelectAll()
            errors = True
        End If
        If Double.TryParse(daysTextBox.text, daysCheck) Then
        Else
            errorList.Add("Invalid Number of days")
            daysTextBox.SelectAll()
            errors = True
        End If

        If errors = True Then
            For Each item As String In errorList
                sErrors &= item & " " & vbNewLine
            Next
            MessageBox.Show(sErrors, "Errors", MessageBoxButtons.OK)
        End If

    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click

        DialogResult = MessageBox.Show("Are you sure you want to exit", "Exit", MessageBoxButtons.YesNo)

        If DialogResult = DialogResult.Yes Then
            Me.Close()
        End If

    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles clearButton.Click
        nameTextBox.Text = ""
        addressTextBox.Text = ""
        cityTextBox.Text = ""
        stateTextBox.Text = ""
        zipCodeTextBox.Text = ""
        beginOdometerTextBox.Text = ""
        endOdometerTextBox.Text = ""
        daysTextBox.Text = ""
        milesDrivenLabel.Text = ""
        mileChargeLabel.Text = ""
        dayChargeLabel.Text = ""
        discountLabel.Text = ""
        youOweLabel.Text = ""
    End Sub
End Class