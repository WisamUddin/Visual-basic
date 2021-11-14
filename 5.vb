Module Module1

    Sub Main()
        Dim Str1, Char1 As String
        Dim Counter, cCount As Integer
        Const vowels = "aA"

        Str1 = ""
        Char1 = ""
        cCount = 0
        Counter = 0

        Console.Write("Enter string to look for vowels: ")
        Str1 = Console.ReadLine

        For Counter = 1 To Len(Str1)
            Char1 = Mid(Str1, Counter, 1)
            If InStr(vowels, Char1) > 0 Then
                cCount = cCount + 1ei
            End If
        Next

        Console.WriteLine("Number of vowels in the given string = " & cCount)
        Console.ReadKey()
    End Sub

End Module
