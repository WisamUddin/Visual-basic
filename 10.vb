Module Module1

    Sub Main()
        Dim verb As String
        Dim command As Integer


        If command = "8" Then


            Console.Write("Enter Verb: ")
            verb = Console.ReadLine()

            If Len(verb) > 2 Then
                If Right(verb, 3) <> "ing" Then
                    Console.WriteLine(verb & "ly")

                End If

            ElseIf Len(verb) < 3 Then
                Console.WriteLine(verb)


            End If
            Console.ReadKey()

        End If
    End Sub

End Module
