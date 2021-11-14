Module Module1

    Sub Main()
        Dim strAlphabet() As String = {"a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z"}
        Dim intCounter(25) As Integer
        Dim strInput As String
        Dim strMissingLetters As String
        Dim strSingleChar As String

        Dim i As Integer
        Dim j As Integer
        Dim x As Integer

        Dim boolPangram As Boolean
        Dim strPangramNo As String = "No, it is not a Pangram "
        Dim strPangramYes As String = "Yes, it is a Pangram "


        strInput = txtInput.Text
        strInput = strInput.Replace("", "")
        strInput = strInput.ToLower()


        For i = 0 To strInput.Length - 1

            strSingleChar = strInput.Substring(i, 1)

            For j = 0 To strAlphabet.Length - 1

                If strSingleChar = strAlphabet(j) Then
                    intCounter(j) += 1
                End If
            Next j
        Next i

        For x = 0 To 26
            If intCounter(x) = 0 Then
                boolPangram = False
                strMissingLetters &= strAlphabet(x)
            Else
                boolPangram = True
            End If
        Next

        If boolPangram = False Then
            lblResult.Text = strPangramNo & vbNewLine &
            "Missing letters: " & strMissingLetters
        Else
            lblResult.Text = strPangramYes
        End If
    End Sub

End Module
