'/*********************************************************************************************************************************
'Copyright And Licensing Message

'This code Is copyright 2018 Gary Cole Jr. 
'This code Is licensed by Gary Cole To others under the GPLv.3 https://opensource.org/licenses/GPL-3.0 
'If you find the code useful Or just feel generous a donation Is appreciated.
'Donate with this link: paypal.me/ GColeJr
'Please choose Friends And Family

'Alternative Licensing Options

'If you prefer To license under the LGPL For a project, https://opensource.org/licenses/LGPL-3.0
'Single Developers working on their own project can do so with a donation of $20 Or more. 
'Small And medium companies can do so with a donation of $50 Or more. 
'Corporations can Do so With a donation Of $1000 Or more.

'If you prefer To license under the MS-RL For a project, https://opensource.org/licenses/MS-RL
'Single Developers working on their own project can do so with a donation of $40 Or more. 
'Small And medium companies can do so with a donation of $100 Or more.
'Corporations can Do so With a donation Of $2000 Or more.

'If you prefer To license under the MS-PL For a project, https://opensource.org/licenses/MS-PL
'Single Developers working on their own project can do so with a donation of $1000 Or more. 
'Small And medium companies can do so with a donation of $2000 Or more.
'Corporations can Do so With a donation Of $10000 Or more.

'If you use the code In more than one project, a separate license Is required For Each project.
'Any modifications To this code must retain this message. 
'*************************************************************************************************************************************/
Module Module1
    Function getguess() As Int32
        Console.Write("Enter your guess: ")
        Dim guess As Integer
        If (Integer.TryParse(Console.ReadLine(), guess)) Then
            Return guess
        Else
            Throw New Exception("Your guess must be a number")
        End If
    End Function
    Function processguess(Target As Int32, Guess As Int32) As Boolean
        If (Guess > Target) Then
            Console.WriteLine("That guess is too high. Try Again")
            Return False
        ElseIf (Guess < Target) Then
            Console.WriteLine("That guess is too low. Try Again")
            Return False
        Else
            Console.WriteLine("That's it! You got my number")
            Return True
        End If
    End Function
    Sub Main()
        Dim random As Random = New Random
        Dim ch As Char = "y"
        Do While Char.ToUpper(ch) = "Y"
            Dim tries As Int32 = 0
            Console.WriteLine("Enter the upper limit for this game")
            Dim Uppernum As Int32 = Console.ReadLine()
            Dim Guess As Int32 = -12
            Dim Target As Int32 = random.Next(Uppernum)
            Do While Not Guess = Target
                tries += 1
                Guess = getguess()
                If (processguess(Target, Guess)) Then
                    Console.WriteLine($"It only took you {tries} tries to guess it!")
                    Console.WriteLine("Want to play Again? (Y/N)")
                    ch = Char.Parse(Console.ReadLine())
                End If
            Loop
        Loop

    End Sub

End Module
