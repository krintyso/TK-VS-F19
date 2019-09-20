'Tyson Kriner
'RCET0265
'asg2-6
'state flag viewer program
'https://github.com/krintyso/TK-VS-F19/tree/master/Asg2-6
Public Class Form1
    Private Sub IdahoFlagButton_Click(sender As Object, e As EventArgs) Handles IdahoFlagButton.Click
        FlagDisplay.Image = My.Resources.IdahoFlag
    End Sub

    Private Sub RhodeIslandFlag_Click(sender As Object, e As EventArgs) Handles RhodeIslandFlag.Click
        FlagDisplay.Image = My.Resources.RhodeIsland
    End Sub

    Private Sub OregonFlag_Click(sender As Object, e As EventArgs) Handles OregonFlag.Click
        FlagDisplay.Image = My.Resources.OregonFlag
    End Sub

    Private Sub TexasFlag_Click(sender As Object, e As EventArgs) Handles TexasFlag.Click
        FlagDisplay.Image = My.Resources.TexasFlag
    End Sub

    Private Sub Exitbutton_Click(sender As Object, e As EventArgs) Handles exitbutton.Click
        Me.Close()
    End Sub
End Class
