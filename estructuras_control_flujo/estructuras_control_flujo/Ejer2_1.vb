Module Ejer2_1

    'If: Crear un módulo en el cual se ingresan dos valores numéricos e informar por pantalla cuál es
    'la relación entre ambos: mayor, menor o igual.

    Sub Main()

        Dim a, b As UShort

        Console.Write("Ingrese un número: ")
        a = Console.ReadLine()

        Console.Write("Ingrese un número: ")
        b = Console.ReadLine()

        If a = b Then
            Console.WriteLine("Los números {0} - {1} son iguales", a, b)
        ElseIf a > b Then
            Console.WriteLine("El mayor es A: {0}", a)
        Else
            Console.WriteLine("El mayor es A: {0}", b)
        End If

        Console.ReadKey()

    End Sub

End Module
