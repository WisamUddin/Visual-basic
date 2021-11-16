Module Module1

    Sub Main()
         Dim UserInput As String
        Dim char1, char2 As Char


        Console.WriteLine("Enter a string")
        UserInput = Console.ReadLine
        char1 = Left(UserInput, 1)


        Console.Write(char1)
        For i = 1 To Len(UserInput) - 1
            char2 = Mid(UserInput, i + 1, 1)
            If char2 = char1 Then
                char2 = "*"
            End If
            Console.Write(char2)
        Next
        Console.ReadKey()
    End Sub

End Module
