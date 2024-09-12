Module Module1

    Sub Main()

        Dim pass, i As Integer

        i = 0

        Console.WriteLine("Ingrese la contraseña correcta")
        While (i = 2)
            pass = Console.ReadLine()

            If pass = 3312 Then i = i + 3

        End While

    End Sub

End Module
