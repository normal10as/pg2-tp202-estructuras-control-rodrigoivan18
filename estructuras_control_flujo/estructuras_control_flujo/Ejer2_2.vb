Module Ejer2_2

    'IF: ingresar tres valores y mostrar el menor.

    Sub Main()

        Dim a, b, c, menor As UShort

        Console.Write("Ingrese un número: ")
        a = Console.ReadLine()

        Console.Write("Ingrese un número: ")
        b = Console.ReadLine()

        Console.Write("Ingrese un número: ")
        c = Console.ReadLine()

        If a < b And a < c Then
            menor = a
        ElseIf b < c Then
            menor = b
        Else
            menor = c
        End If

        Console.WriteLine("El {0} es el menor de los números ingresados", menor)

        Console.ReadKey()

    End Sub

End Module
