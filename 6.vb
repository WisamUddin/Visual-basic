Module Module1

    Sub Main()

        Dim i As String
        i = ""

        Console.Write("Enter the number of Donuts you want: ")
        i = Console.ReadLine()


        If i < 10 Then

            Console.WriteLine("Numer of Donuts are  " & i)
        Else
            Console.WriteLine("Number of donuts are Many")
        End If


    End Sub

End Module
