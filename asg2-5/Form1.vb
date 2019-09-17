' Personal Info asg2-5
' By Tyson Kriner

Public Class Information
    Private Sub DisplaysInfo_Click(sender As Object, e As EventArgs) Handles DisplaysInfo.Click
        Line1.Text = Firstname.Text & " " & Lastname.Text
        Line2.Text = Address.Text
        Line3.Text = City.Text & ", " & State.Text & ", " & ZIPcode.Text
        'When the accept button is pressed, the users info is concatenated into 3 different labels
    End Sub
    Private Sub Clearsinfo_Click(sender As Object, e As EventArgs) Handles Clearsinfo.Click
        Line1.Text = ""
        Line2.Text = ""
        Line3.Text = ""
        Firstname.Text = ""
        Lastname.Text = ""
        Address.Text = ""
        City.Text = ""
        State.Text = ""
        ZIPcode.Text = ""
        'When the clear button is pressed, all info is cleared from the textboxes 
    End Sub
    Private Sub Exitprog_Click(sender As Object, e As EventArgs) Handles Exitprog.Click
        Me.Close()
        'when the exit button is pressed, the program closes

    End Sub
End Class
