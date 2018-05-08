Module Ejer2_13

    '    Obtener los números primos menores a mil. En matemáticas, un número primo es un
    'número natural mayor que 1 que tiene únicamente dos divisores distintos: él mismo y el 1.

    Sub Main()

        Dim contador As Integer = 0

        For numeros As UShort = 2 To 1000

            For divisores As UShort = 1 To numeros

                If numeros Mod divisores = 0 Then
                    contador += 1

                End If

            Next

            If contador = 2 Then

                Console.WriteLine("Numeros primos: {0}", numeros)

            End If

            contador = 0

        Next



        Console.ReadKey()

    End Sub

End Module
