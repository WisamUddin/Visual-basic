Module Module1

    Sub Main()

        Dim A, Char1, B As String
        Dim Counter, cCount As Integer

        A = ""
        Char1 = ""
        B = ""
        Counter = 0
        cCount = 0

        Console.Write("Enter a String ")
        A = Console.ReadLine

        Console.Write("Enter character to search for: ")
        B = Console.ReadLine

        For Counter = 1 To Len(A)
            Char1 = Mid(A, Counter, 1)
            If UCase(Char1) = UCase(B) Then
                cCount = cCount + 1
            End If
        Next

        Console.WriteLine(cCount)
        Console.ReadKey()
    End Sub

End Module
