Module Ejer2_12

    '    Utilizando la estructura de repetición más adecuada elaborar Los números de Fibonacci
    'constituyen una secuencia que empieza con 0 y 1; el número que sigue a éstos se calcula
    'sumando los dos anteriores y así sucesivamente. Utilizando la estructura de repetición más
    'adecuada elaborar un algoritmo que imprima los 20 primeros números de la secuencia.

    Sub Main()

        Dim inicio As UInteger = 0
        Dim fin As UInteger = 1
        Dim resultado As UInteger

        For x As Byte = 0 To 20

            resultado = inicio + fin
            'Console.WriteLine("{0} - {1} + {2} = {3}", x, inicio, fin, resultado)
            Console.WriteLine("{0} + {1} = {2}", inicio, fin, resultado)

            inicio = fin
            fin = resultado

        Next

        Console.ReadKey()

    End Sub

End Module
