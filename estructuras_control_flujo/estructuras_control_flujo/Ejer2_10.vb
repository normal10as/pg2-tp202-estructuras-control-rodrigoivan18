Module Ejer2_10

    '    For y Do Loop. Crear un módulo para resolver el siguiente problema: con dos valores
    'numéricos enteros cualquiera, el primero menor al segundo, calcular cuantos números múltiplos
    'de cinco hay entre ellos e informar. Repetir esta solución en el mismo módulo con las diferentes
    'alternativas las estructuras de repetición “do while … loop”, “do until … loop”, “do … loop
    'while”, “do … loop until y “for”

    Sub Main()

        Dim a, b, contador As UShort

        Console.WriteLine("Ingrese dos valores numericos el primero menor al segundo")

        Console.Write("Primer valor: ")
        a = Console.ReadLine()
        Console.Write("Segundo valor: ")
        b = Console.ReadLine()

        'Do While a <= b

        '    If a Mod 5 = 0 Then
        '        contador += 1
        '    End If

        '    a += 1

        'Loop

        'Console.WriteLine("Se encontraron {0} multiplos de 5", contador)


        'Do Until a > b

        '    If a Mod 5 = 0 Then
        '        contador += 1
        '    End If

        '    a += 1

        'Loop

        'Console.WriteLine("Se encontraron {0} multiplos de 5", contador)


        'Do

        '    If a Mod 5 = 0 Then
        '        contador += 1
        '    End If

        '    a += 1

        'Loop While a <= b

        'Console.WriteLine("Se encontraron {0} multiplos de 5", contador)

        'Do

        '    If a Mod 5 = 0 Then
        '        contador += 1
        '    End If

        '    a += 1

        'Loop Until a > b

        'Console.WriteLine("Se encontraron {0} multiplos de 5", contador)

        For x As Byte = a To b Step 1

            If x Mod 5 = 0 Then

                contador += 1

            End If

        Next

        Console.WriteLine("Se encontraron {0} multiplos de 5", contador)

        Console.ReadKey()

    End Sub

End Module
