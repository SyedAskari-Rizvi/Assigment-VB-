Module Module1

    Sub Main()
        Dim Str1, Str2, charRemo, charRep, Char1 As String
        Dim Counter As Integer

        Str1 = ""
        Str2 = ""
        charRemo = ""
        charRep = ""
        Char1 = ""
        Counter = 0

        Console.Write("Enter String: ")
        Str1 = Console.ReadLine
        Console.Write("Enter character to remove: ")
        charRemo = Console.ReadLine
        Console.Write("Enter character to replce: ")
        charRep = Console.ReadLine

        For Counter = 1 To Len(Str1)
            Char1 = Mid(Str1, Counter, 1)
            If Char1 = charRemo Then
                Str2 = Str2 + charRep
            Else
                Str2 = Str2 + Char1
            End If
        Next

        Console.Write("the new string is: " + Str2)
        Console.ReadKey()




    End Sub

End Module
