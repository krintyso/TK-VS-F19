' 9/15/19
' Diner Specials Menu
' By Tyson Kriner
Public Class Specials
    Dim Item1 As String 'Declares these variables as strings
    Dim Item2 As String
    Dim Item3 As String
    Private Sub DisplaySoup_Click(sender As Object, e As EventArgs) Handles DisplaySoup.Click
        Item1 = "Clam Chowder" 'when displaysoup button is clicked, the label populates with item1
        FoodDisplay.Text = Item1

    End Sub

    Private Sub DisplayChef_Click(sender As Object, e As EventArgs) Handles DisplayChef.Click
        Item2 = "Sirloin Steak" 'when displaysoup button is clicked, the label populates with item2
        FoodDisplay.Text = Item2

    End Sub

    Private Sub DisplayFish_Click(sender As Object, e As EventArgs) Handles DisplayFish.Click
        Item3 = "Fresh Clown Fish" 'when displaysoup button is clicked, the label populates with item3
        FoodDisplay.Text = Item3
    End Sub

    Private Sub Exitbutton_Click(sender As Object, e As EventArgs) Handles Exitbutton.Click
        Me.Close() 'When the exit button is clicked, the program closes
    End Sub
End Class
