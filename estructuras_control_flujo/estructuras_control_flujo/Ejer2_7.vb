Module Ejer2_7

    Sub Main()

        Dim grado As UShort

        Console.Write("Ingrese el tamaño de un ángulo: ")
        grado = Console.ReadLine()

        Select Case grado

            Case 0 To 89
                Console.WriteLine("Agudo.")
            Case 90
                Console.WriteLine("Recto.")
            Case 91 To 179
                Console.WriteLine("Obtuso.")
            Case 180
                Console.WriteLine("Llano.")
            Case 181 To 359
                Console.WriteLine("Cóncavo.")
            Case Else
                Console.WriteLine("Error.")

        End Select

        Console.ReadKey()

    End Sub

End Module
