Module Module1

    Sub Main()
        Dim str1 As String
        Dim char1 As Char
        Dim char2 As Char

        Console.WriteLine("Enter a statement")
        str1 = Console.ReadLine
        char1 = Left(str1, 1)
        Console.Write(char1)
        For i = 1 To Len(str1) - 1
            char2 = Mid(str1, (i + 1), 1)
            If char2 = char1 Then
                char2 = "*"
            End If
            Console.Write(char2)
        Next
        Console.ReadKey()
    End Sub

End Module
