﻿
Public Class Form1
    Private Sub TestValidateAndConvert() Handles Me.Load
        Dim count As Integer = 0
        Dim result As Integer = 0
        Dim pad As Integer = 15
        Dim report As String = ""
        Dim temp As String = ""
        Dim testData = New String(4, 4) {
    {"5", "2", "17", "8", "42"},
    {"6.7", "3.14", "5.4", "5.5", "0.125"},
    {"-21", "-32.1", "-4", "-4.5", "-4.4"},
    {"", "", "", "", ""},
    {"True", "False", "lOOlO", "9O2lO", "dog"}}
        For row = 0 To 4
            For column = 0 To 4
                result = 0
                temp = ValidateAndConvert(testData(row, column), result)
                report &= ("Trying: " & testData(row, column)).PadRight(pad)
                If row < 3 Then
                    If CStr(CInt(testData(row, column))) <> CStr(result) Or temp <> "" Then
                        report &= " TEST FAIL" & vbNewLine
                        report &= ("Result is: " & CStr(result)).PadRight(pad) & " : " & temp & vbNewLine
                        report &= ("Should be: " & CStr(CInt(testData(row, column)))).PadRight(pad) & " : " _
    & "<Empty>" & vbNewLine
                    Else
                        report &= " TEST PASS" & vbNewLine
                        count += 1
                    End If
                ElseIf temp <> "is empty" And row = 3 Then
                    report &= " TEST FAIL" & vbNewLine
                    report &= ("Result is: " & CStr(result)).PadRight(pad) & " : " & temp & vbNewLine
                    report &= ("Should be: " & CStr(0)).PadRight(pad) & " : " & "is empty" & vbNewLine
                ElseIf temp <> "Must contain a number" And row > 3 Then
                    report &= " TEST FAIL" & vbNewLine
                    report &= ("Result is: " & CStr(result)).PadRight(pad) & " : " & temp & vbNewLine
                    report &= ("Should be: " & CStr(0)).PadRight(pad) & " : " & "Must contain a number" _
    & vbNewLine
                Else
                    report &= " TEST PASS" & vbNewLine
                    count += 1
                End If
            Next
        Next
        Console.WriteLine(report & "Passed " & CStr(count) & " of 25 tests. Score: " _
    & CStr((count / 25) * 100) & "%")
        MessageBox.Show("Passed " & CStr(count) & " of 25 tests. Score: " _
    & CStr((count / 25) * 100) & "%")
    End Sub

    Private Function ValidateAndConvert(ByVal convertThisString, ByRef toThisInteger) As String


        Try
            toThisInteger = CInt(convertThisString)

        Catch ex As Exception
            If convertThisString = "" Then
                Return "is empty"
            Else
                Return "Must contain a number"
            End If

        End Try

        Return ""

    End Function

End Class