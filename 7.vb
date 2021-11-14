Module Module1

    Sub Main()
        Dim str1, str2, str3 As String
        str3 = ""
        str1 = ""
        str2 = ""



        Console.Write("enter a statement: ")
        str1 = Console.ReadLine

        Dim x As Integer
        x = 0

        x = Len(str1)
        str2 = Left(str1, 2)
        str3 = Mid(x - 2, str1, 1)

        Console.WriteLine(str2 & " " & str3)

        Console.ReadKey()


    End Sub

End Module
