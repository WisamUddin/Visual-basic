Module Module1

    Sub Main()
        Dim A, B, C, D, E As String
        Dim count As Integer

        A = ""
        B = ""

        C = ""
        D = ""
        E = ""
        count = 0

        Console.Write("Enter Your Sentence: ")
        A = Console.ReadLine
        Console.Write("Enter Char you want to replace")
        C = Console.ReadLine
        Console.Write("Enter Char you want to replace with: ")
        D = Console.ReadLine

        For count = 1 To Len(A)
            E = Mid(A, count, 1)
            Dim message As String = ""
            message = IIf(B = "B", "E")

            Console.WriteLine("we are unable to complete your task" & message)
            Console.ReadLine()
            Console.ReadKey()



        Next


    End Sub

    Private Function IIf(ByVal p1 As Boolean, ByVal p2 As String) As String

    End Function

End Module
