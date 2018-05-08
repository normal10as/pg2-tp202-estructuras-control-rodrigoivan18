Module Ejer2_8

    'Elabore un programa que indique cuantos días tiene un mes respetando las siguientes
    'condiciones:
    ' El flujo normal solo se ingresa el número de mes a evaluar y validar con una enumeración.
    ' En el caso de febrero ingresar el año y tener en cuenta que un año bisiesto tiene 29 días. Un
    'año bisiesto es aquél que es múltiplo de 4 y no de 100 o cuando es múltiplo de 400. Por
    'ejemplo, el año 2000 si bisiesto pero el 2100 no lo es.

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

        Dim numero_del_mes As Byte
        Dim año As UShort

        Console.Write("Número del mes: ")
        numero_del_mes = Console.ReadLine()

        Select Case numero_del_mes

            Case meses_del_año.enero
                Console.WriteLine("Enero tiene 31 días.")

            Case meses_del_año.febrero

                Console.Write("Año: ")
                año = Console.ReadLine()

                If (año Mod 4 = 0 And año Mod 100 <> 0) Or año Mod 400 = 0 Then
                    Console.WriteLine("Año Bisiesto - Febrero tiene 29 días.")
                Else
                    Console.WriteLine("No es Año Bisiesto - Febrero tiene 28 días.")
                End If

            Case meses_del_año.marzo
                Console.WriteLine("Marzo tiene 31 días.")

            Case meses_del_año.abril
                Console.WriteLine("Abril tiene 30 días.")

            Case meses_del_año.mayo
                Console.WriteLine("Mayo tiene 31 días.")

            Case meses_del_año.junio
                Console.WriteLine("Junio tiene 30 días.")

            Case meses_del_año.julio
                Console.WriteLine("Julio tiene 31 días.")

            Case meses_del_año.agosto
                Console.WriteLine("Agosto tiene 31 días.")

            Case meses_del_año.septiembre
                Console.WriteLine("Septiembre tiene 30 días.")

            Case meses_del_año.octubre
                Console.WriteLine("Octubre tiene 31 días.")

            Case meses_del_año.noviembre
                Console.WriteLine("Noviembre tiene 30 días.")

            Case meses_del_año.diciembre
                Console.WriteLine("Diciembre tiene 31 días.")

            Case Else
                Console.WriteLine("El número del mes ingresado no existe - Feed Intenso")

        End Select

        Console.ReadKey()

    End Sub

End Module
