Option Strict On
Option Explicit On

Module IfStatementExample

    Sub Main()
        Dim userInput As String
        Dim userNumber As Integer

        'If 3 > 5 Then
        'Console.WriteLine("Yep")
        'Else
        'Console.WriteLine("Nope")
        'End If
        userInput = Console.ReadLine()
        userNumber = CInt(userInput)

        If userNumber > 5 Then
            Console.WriteLine("Bigger than 5")
        ElseIf userNumber < 5 Then
            Console.WriteLine("Smaller than 5")
        ElseIf userNumber = 5 Then
            Console.WriteLine("It is 5")
        Else
            Console.WriteLine("Its weird")
        End If
        Console.ReadLine()

    End Sub

End Module
