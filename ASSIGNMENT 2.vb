Module Module1

    Sub Main()
       Dim X, Char1, str1, char2 As String


        X = ""

        Char1 = ""
        str1 = ""
        char2 = ""


        Console.Write("Enter String: ")
        X = Console.ReadLine

        Console.Write("Enter char to remove: ")
        Char1 = Console.ReadLine

        Console.Write("Enter word that you want to replce: ")
        str1 = Console.ReadLine

        Dim i As Integer
        Dim message As String
        i = 0
        message = ""
        For i = 1 To Len(X)
            char2 = Mid(X, i, 1)
            If char2 = Char1 Then
                char2 = str1
            End If
            message = message & char2
        Next

        Console.WriteLine("replaced string = " & message)
    
    
    
    
    
    
    
    
    Console.ReadKey()
    
    
    



        Next


    End Sub

    Private Function IIf(ByVal p1 As Boolean, ByVal p2 As String) As String

    End Function

End Module
