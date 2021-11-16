Module Module1

    Sub Main()
        Dim A, message, C, D, E As String
        Dim count As Integer

        A = ""
        message = ""

        C = ""
        D = ""
        E = ""
        count = 0

        Console.Write("Enter Your Sentence: ")
        A = Console.ReadLine
        Console.Write("Enter Char you want to replace")
        C = Console.ReadLine
        Console.Write("Enter Char you want to replace : ")
        D = Console.ReadLine

        For count = 1 To Len(A)
            E = Mid(A, count, 1)
        If  E = C Then 
            E= D
        End If
        message=  E

        Console.WriteLine("Your tas has been completed" & message)
            Console.ReadLine()
            Console.ReadKey()



        Next


    End Sub

    Private Function IIf(ByVal p1 As Boolean, ByVal p2 As String) As String

    End Function

End Module
