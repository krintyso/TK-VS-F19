'Tyson Kriner
'RCET0265
'wk1-3
'Random integers 
'https://github.com/krintyso/TK-VS-F19

Option Strict On
Option Explicit On

Public Class Form1

    Private Sub RngButton_Click(sender As Object, e As EventArgs) Handles rngButton.Click
        Dim random As Single

        For i = 1 To 10
            random = Int(Rnd() * 20) - 10
            rngListBox1.Items.Insert(0, random)

        Next
        rngListBox1.Items.Insert(10, vbCr & "--------------------------")
    End Sub
End Class
