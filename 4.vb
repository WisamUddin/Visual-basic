Module Module1

    Sub Main()
        Dim Char3, Char1, Char2 As Char
        Dim maximum, Count, i As Integer

        Char1 = ""
        Char3 = ""

        Count = 0

        Dim Phrase As String
        Console.Write("Enter Phrase: ")
        Phrase = Console.ReadLine

        For i = 1 To Len(Phrase)
            Char2 = Mid(Phrase, i, 1)
            Count = 0

            Dim X As Integer

            For X = 1 To Len(Phrase)
                Char1 = Mid(Phrase, X, 1)
                If Char1 = Char2 Then Count = Count + 1

            Next

            If Count > maximum Then
                maximum = Count
                Char3 = Char2
            End If
        Next
        Console.WriteLine(Char3 & " appeared " & maximum & " number of times.")
        Console.ReadKey()
    End Sub

End Module
