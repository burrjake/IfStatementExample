Option Strict On
Option Explicit On
Option Compare Binary

Module IfStatementExample

    Sub Main()
        Dim userInput As String
        Dim userNumber As Integer
        Const COMPSREWITHNUMBER As Integer = 51

        'If 3 > 5 Then
        'Console.WriteLine("Yep")
        'Else
        'Console.WriteLine("Nope")
        'End If
        'userInput = Console.ReadLine()
        'userNumber = CInt(userInput)

        'If userNumber > 5 Then
        '    Console.WriteLine("Bigger than 5")
        'ElseIf userNumber < 5 Then
        '    Console.WriteLine("Smaller than 5")
        'ElseIf userNumber = 5 Then
        '    Console.WriteLine("It is 5")
        'Else
        '    Console.WriteLine("Its weird")
        'End If
        'Console.ReadLine()


        Console.WriteLine("Please enter some text")
        userInput = Console.ReadLine()
        If userInput = "Hello" Or userInput = "hello" Then
            Console.WriteLine("Well, hello to you...")
            'ElseIf userInput = "hello" Then
            '    Console.WriteLine("Well, hello to you...")
        Else
            Console.WriteLine("You entered: " & userInput)
        End If
        Console.ReadLine()
    End Sub

End Module
