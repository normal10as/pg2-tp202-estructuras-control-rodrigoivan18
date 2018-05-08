Module Ejer2_11

    'Utilizando la estructura de repetición más adecuada elaborar un programa que se ingresen
    'valores enteros hasta que se ingrese cero (descartar negativos). Luego informar cuantos son
    'pares y cuantos impares. Si todos son pares o todos son impares informar esta situación
    'particular en lugar de la consigna anterior.

    Sub Main()

        Dim valor, pares, impares As UShort

        Do

            Console.Write("Valor entero: ")
            valor = Console.ReadLine()

            If Math.Pow(-1, valor) = 1 Then
                pares += 1
            'ElseIf Math.Pow(-1, valor) = -1 Then
            '    impares += 1
            Else
                impares += 1
            End If

        Loop Until valor = 0

        If pares > 0 And impares = 0 Then
            Console.WriteLine("Todos los valores ingresados son pares")
        ElseIf impares > 0 And pares = 0 Then
            Console.WriteLine("Todos los valores ingresados son impares")
        Else
            Console.WriteLine("{0} de los valores ingresados son pares - {1} de los valores ingresados son impares", pares, impares)
        End If

        Console.ReadKey()

    End Sub

End Module
