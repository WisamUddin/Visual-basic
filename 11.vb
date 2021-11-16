Module Module1

    Sub Main()


        Dim input As String
        Dim x, y, str2 As String
        Dim char1 As Integer
        Dim str3 As String
        Dim T As String

        T = ""

        char1 = 0
        x = ""
        y = ""
        str2 = ""
        str3 = ""


        Console.WriteLine("Enter a String: ")
        input = Console.ReadLine()


        Dim count, Nextcount As Integer
        count = 0
        Nextcount = 0


        For count = 1 To Len(input)
            For Nextcount = 1 To Len(input)
                x = Mid(input, count, 3)
                y = Mid(input, Nextcount, 3)
                str2 = Left(input, (count - 1))
                str3 = Mid(input, (Nextcount + 3), (Len(input)))

                If x = "not" And y = "bad" Then
                    char1 = (Nextcount - count)
                    input = str2 & "good" & str3
                End If
            Next
        Next

        Console.Write(input)












        Console.ReadLine()

    End Sub

End Module
