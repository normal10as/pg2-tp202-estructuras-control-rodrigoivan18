Module Ejer2_5

    'Case .Crear un programa con una enumeración para los meses del año. Ingresar un valor
    'numérico y mostrar a que mes corresponde. Si el valor es inválido mostrar el mensaje
    'correspondiente.

    Enum meses_del_año

        enero = 1
        febrero = 2
        marzo = 3
        abril = 4
        mayo = 5
        junio = 6
        julio = 7
        agosto = 8
        septiembre = 9
        octubre = 10
        noviembre = 11
        diciembre = 12

    End Enum

    Sub Main()

        Dim a As Byte

        Console.Write("Ingrese un valor: ")
        a = Console.ReadLine()

        Select Case a

            Case meses_del_año.enero
                Console.WriteLine("Enero.")

            Case meses_del_año.febrero
                Console.WriteLine("Febrero.")

            Case meses_del_año.marzo
                Console.WriteLine("Marzo.")

            Case meses_del_año.abril
                Console.WriteLine("Abril.")

            Case meses_del_año.mayo
                Console.WriteLine("Mayo.")

            Case meses_del_año.junio
                Console.WriteLine("Junio.")

            Case meses_del_año.julio
                Console.WriteLine("Julio.")

            Case meses_del_año.agosto
                Console.WriteLine("Agosto.")

            Case meses_del_año.septiembre
                Console.WriteLine("Septiembre.")

            Case meses_del_año.octubre
                Console.WriteLine("Octubre.")

            Case meses_del_año.noviembre
                Console.WriteLine("Noviembre.")

            Case meses_del_año.diciembre
                Console.WriteLine("Diciembre.")

            Case Else
                Console.WriteLine("El Mes no existe.")

        End Select

        Console.ReadKey()

    End Sub

End Module
