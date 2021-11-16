Module Module1

    Sub Main()
            Dim str1 As String
        Dim count, UserOutput, X As Integer
        Dim Char1 As Char

        str1 = ""
        UserOutput = 0
        X = 0
        count = 0

        Console.Write("type a phrase: ")
        str1 = Console.ReadLine

        For count = 1 To Len(str1)
            Char1 = Mid(str1, count, 1)
            X = InStr("AEIOU", UCase(Char1))
            If X > 0 Then UserOutput += 1
        Next

        Console.WriteLine(" Total Number of vowels found in the above Phrase: " & UserOutput)
        Console.ReadKey()
    End Sub

End Module
