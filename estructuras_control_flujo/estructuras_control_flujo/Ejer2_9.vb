Module Ejer2_9

    '    Elabore un algoritmo que permita hacer conversiones de equivalencias entre metros,
    'centímetros, yardas, pies y pulgadas:
    ' Presentar un menú y preguntar que unidad de medida desea convertir, el valor a convertir y
    'después mostrar las equivalencias.
    ' Utilizar únicamente las equivalencias conocidas: 1 pie = 12 pulgadas, 1 yarda = 3 pies, 1
    'pulgada = 2.54 cm, 1 metro = 100 cm.
    ' Ejemplo: si escogió metros, debe solicitar y leer el número de metros a convertir, luego
    'imprimir la equivalencia en centímetros, pies, yardas y pulgadas.

    Sub Main()

        Dim opcion As Byte

        Console.WriteLine("Ingrese un valor")
        Console.WriteLine()

        Console.WriteLine("Opciones " & vbCrLf & " 1 - Centimetros " & vbCrLf & " 2 - Metros " & vbCrLf & " 3 - Yardas " & vbCrLf & " 4 - Pulgadas " & vbCrLf & " 5 - Pies ")

        Console.Write("Opción número: ")
        opcion = Console.ReadLine()

        Dim centimetros, metros, yardas, pulgadas, pies As Single

        Console.Write("Valor a convertir: ")
        Dim valor_convertir As Single = Console.ReadLine()

        Select Case opcion

            Case 1 ' Centimetros

                Console.WriteLine("Centimetros ingresados {0}", valor_convertir)

                metros = valor_convertir / 100
                pulgadas = valor_convertir / 2.54
                pies = pulgadas / 12
                yardas = pies / 3

                Console.WriteLine("{0} centimetros equivalen a {1} metros", valor_convertir, metros)
                Console.WriteLine("{0} centimetros equivalen a {1} yardas", valor_convertir, yardas)
                Console.WriteLine("{0} centimetros equivalen a {1} pies", valor_convertir, pies)
                Console.WriteLine("{0} centimetros equivalen a {1} pulgadas", valor_convertir, pulgadas)

            Case 2 ' Metros

                Console.WriteLine("Metros ingresados {0}", valor_convertir)

                centimetros = valor_convertir * 100
                pulgadas = centimetros / 2.54
                pies = pulgadas / 12
                yardas = pies / 3

                Console.WriteLine("{0} metros equivalen a {1} centimetros", valor_convertir, centimetros)
                Console.WriteLine("{0} metros equivalen a {1} yardas", valor_convertir, yardas)
                Console.WriteLine("{0} metros equivalen a {1} pies", valor_convertir, pies)
                Console.WriteLine("{0} metros equivalen a {1} pulgadas", valor_convertir, pulgadas)

            Case 3 ' Yardas

                Console.WriteLine("Yardas ingresadas {0}", valor_convertir)

                pies = valor_convertir * 3
                pulgadas = pies * 12
                centimetros = pulgadas * 2.54
                metros = centimetros / 100

                Console.WriteLine("{0} yardas equivalen a {1} metros", valor_convertir, metros)
                Console.WriteLine("{0} yardas equivalen a {1} centimetros", valor_convertir, centimetros)
                Console.WriteLine("{0} yardas equivalen a {1} pies", valor_convertir, pies)
                Console.WriteLine("{0} yardas equivalen a {1} pulgadas", valor_convertir, pulgadas)

            Case 4 ' Pulgadas

                Console.WriteLine("Pulgadas ingresadas {0}", valor_convertir)

                centimetros = valor_convertir * 2.54
                pies = valor_convertir / 12
                metros = centimetros / 100
                yardas = pies / 3

                Console.WriteLine("{0} pulgadas equivalen a {1} metros", valor_convertir, metros)
                Console.WriteLine("{0} pulgadas equivalen a {1} centimetros", valor_convertir, centimetros)
                Console.WriteLine("{0} pulgadas equivalen a {1} yardas", valor_convertir, yardas)
                Console.WriteLine("{0} pulgadas equivalen a {1} pies", valor_convertir, pies)

            Case 5 ' Pies

                Console.WriteLine("Pies ingresados {0}", valor_convertir)

                pulgadas = valor_convertir * 12
                yardas = valor_convertir / 3
                centimetros = pulgadas * 2.54
                metros = centimetros / 100

                Console.WriteLine("{0} pies equivalen a {1} metros", valor_convertir, metros)
                Console.WriteLine("{0} pies equivalen a {1} centimetros", valor_convertir, centimetros)
                Console.WriteLine("{0} pies equivalen a {1} yardas", valor_convertir, yardas)
                Console.WriteLine("{0} pies equivalen a {1} pulgadas", valor_convertir, pulgadas)

            Case Else

                Console.WriteLine("Opción Incorrecta.")

        End Select

        Console.Read()

    End Sub

End Module
