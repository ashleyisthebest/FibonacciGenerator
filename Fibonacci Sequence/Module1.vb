Module Module1

    Dim numberOfTerms As String
    Dim closest As BigMath.BigInteger
    Dim secondClosest As BigMath.BigInteger
    Dim counter As Integer
    Dim nextTerm As BigMath.BigInteger
    Dim sleepTime As Integer
    Dim copy As String
    Dim stringVersion As String
    Dim numericCheck As Boolean
    Dim mode As Integer

    Sub Main()
        Console.ForegroundColor = ConsoleColor.Yellow
        Console.WriteLine("")
        Console.WriteLine("Fibonacci Sequence Generator by @ImLynxTheGod")
        Console.WriteLine("")
        Console.WriteLine("Modes:")
        Console.WriteLine("1 - Displays terms during calculation")
        Console.WriteLine("2 - Displays how many terms have been calculated")
        Console.WriteLine("3 - Rainbows at calculation speed")
        Console.WriteLine("")
        Console.Write("Mode: ")
        Console.ForegroundColor = ConsoleColor.Magenta
        mode = Console.ReadLine()
        Console.WriteLine("")
        Console.WriteLine("Enter the number of terms you would like the Fibonacci Sequence listed to:")
        Console.WriteLine("")
        Console.Write("Number of terms: ")
        numberOfTerms = Console.ReadLine()
        Console.WriteLine()

        'Making sure string is numbers only
        numericCheck = IsNumeric(numberOfTerms)

        If numericCheck = False Then
            Console.WriteLine("The string you entered was not a valid integer.")
            End
        End If

        numberOfTerms.ToString()

        sleepTime = 10
        secondClosest = 0
        closest = 1
        counter = 0

        'Normal mode (1)
        If mode = 1 Then

            Console.ForegroundColor = ConsoleColor.Green

            If numberOfTerms = "" Then
                Console.WriteLine("Please enter a number.")
                End
            End If

            'Incase they type 0
            If numberOfTerms = 0 Then
                Console.WriteLine("What was the point?")
                End
            End If

            'Incase they type 2
            If numberOfTerms = 2 Then
                Console.WriteLine("0")
                Console.WriteLine("1")
            End If

            'Incase they type 1
            If numberOfTerms > 2 Then
                Console.WriteLine("0")
                counter += 2
            End If

            stringVersion = "0 1"

            Do
                'Couting length of sequence
                counter += 1

                'Calculate the next term
                nextTerm = secondClosest + closest

                'Write the next term
                Console.WriteLine(nextTerm)

                'Change the second closest
                secondClosest = closest

                'Change the closest
                closest = nextTerm

                stringVersion = stringVersion + " " + nextTerm.ToString

            Loop Until counter = numberOfTerms

        End If

        'Count mode (2)
        If mode = 2 Then

            Console.ForegroundColor = ConsoleColor.Green

            If numberOfTerms = "" Then
                Console.WriteLine("Please enter a number.")
                End
            End If

            'Incase they type 1
            If numberOfTerms > 2 Then
                Console.WriteLine("0")
                Console.WriteLine("1")
                counter += 2
            End If

            stringVersion = "0 1"

            Do
                'Couting length of sequence
                counter += 1

                'Calculate the next term
                nextTerm = secondClosest + closest

                'Write the next term
                Console.WriteLine(counter)

                'Change the second closest
                secondClosest = closest

                'Change the closest
                closest = nextTerm

                stringVersion = stringVersion + " " + nextTerm.ToString

            Loop Until counter = numberOfTerms

        End If

        'Rainbow mode (3)
        If mode = 3 Then

            Console.ForegroundColor = ConsoleColor.Green

            If numberOfTerms = "" Then
                Console.WriteLine("Please enter a number.")
                End
            End If

            'Incase they type 0
            If numberOfTerms = 0 Then
                Console.WriteLine("What was the point?")
                Console.ReadLine()
            End If

            'Incase they type 1
            If numberOfTerms > 2 Then
                counter += 2
            End If

            stringVersion = "0 1"

            Dim colourShifter As Integer

            Do
                'Colour generator
                colourShifter += 1

                'Making colours show
                Console.WriteLine("")

                If 0 = 0 Then

                    If colourShifter = 1 Then
                        Console.BackgroundColor = ConsoleColor.Red
                    End If

                    If colourShifter = 2 Then
                        Console.BackgroundColor = ConsoleColor.Red
                    End If

                    If colourShifter = 3 Then
                        Console.BackgroundColor = ConsoleColor.Red
                    End If

                    If colourShifter = 4 Then
                        Console.BackgroundColor = ConsoleColor.Red
                    End If

                    If colourShifter = 5 Then
                        Console.BackgroundColor = ConsoleColor.Red
                    End If

                    If colourShifter = 6 Then
                        Console.BackgroundColor = ConsoleColor.Red
                    End If

                    If colourShifter = 7 Then
                        Console.BackgroundColor = ConsoleColor.Red
                    End If

                    If colourShifter = 8 Then
                        Console.BackgroundColor = ConsoleColor.Red
                    End If

                    If colourShifter = 9 Then
                        Console.BackgroundColor = ConsoleColor.Green
                    End If

                    If colourShifter = 10 Then
                        Console.BackgroundColor = ConsoleColor.Green
                    End If

                    If colourShifter = 11 Then
                        Console.BackgroundColor = ConsoleColor.Green
                    End If

                    If colourShifter = 12 Then
                        Console.BackgroundColor = ConsoleColor.Green
                    End If

                    If colourShifter = 13 Then
                        Console.BackgroundColor = ConsoleColor.Green
                    End If

                    If colourShifter = 14 Then
                        Console.BackgroundColor = ConsoleColor.Green
                    End If

                    If colourShifter = 15 Then
                        Console.BackgroundColor = ConsoleColor.Green
                    End If

                    If colourShifter = 16 Then
                        Console.BackgroundColor = ConsoleColor.Green
                    End If

                    If colourShifter = 17 Then
                        Console.BackgroundColor = ConsoleColor.Blue
                    End If

                    If colourShifter = 18 Then
                        Console.BackgroundColor = ConsoleColor.Blue
                    End If

                    If colourShifter = 19 Then
                        Console.BackgroundColor = ConsoleColor.Blue
                    End If

                    If colourShifter = 20 Then
                        Console.BackgroundColor = ConsoleColor.Blue
                    End If

                    If colourShifter = 21 Then
                        Console.BackgroundColor = ConsoleColor.Blue
                    End If

                    If colourShifter = 22 Then
                        Console.BackgroundColor = ConsoleColor.Blue
                    End If

                    If colourShifter = 23 Then
                        Console.BackgroundColor = ConsoleColor.Blue
                    End If

                    If colourShifter = 24 Then
                        Console.BackgroundColor = ConsoleColor.Blue
                        colourShifter = 0
                    End If

                End If

                'Couting length of sequence
                counter += 1

                'Calculate the next term
                nextTerm = secondClosest + closest

                'Change the second closest
                secondClosest = closest

                'Change the closest
                closest = nextTerm

                stringVersion = stringVersion + " " + nextTerm.ToString

            Loop Until counter = numberOfTerms

        End If

        Console.ForegroundColor = ConsoleColor.White
        Console.BackgroundColor = ConsoleColor.Black

        'End message
        Console.WriteLine("")
        Console.ForegroundColor = ConsoleColor.Yellow
        Console.WriteLine("Enter 'c' to copy to clipboard or enter to exit.")
        Console.WriteLine("")
        Console.Write(System.Security.Principal.WindowsIdentity.GetCurrent().Name + ": ")
        copy = Console.ReadLine()

        'Copy to clipboard
        If copy = "c" Then
            My.Computer.Clipboard.SetText(stringVersion)
            Console.ForegroundColor = ConsoleColor.White
            Console.BackgroundColor = ConsoleColor.Black
        Else
            Console.ForegroundColor = ConsoleColor.White
            Console.BackgroundColor = ConsoleColor.Black
            End
        End If

        Console.ForegroundColor = ConsoleColor.White
        Console.BackgroundColor = ConsoleColor.Black

        End

    End Sub

End Module
