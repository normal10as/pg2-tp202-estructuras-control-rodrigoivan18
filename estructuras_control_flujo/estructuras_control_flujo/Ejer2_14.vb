Module Ejer2_14

    '    Se ingresan repetitivamente dos valores relativos a un producto en venta: cantidad y
    'precio unitario. Si la cantidad es entre a 10 y 50 el producto recibe un descuento de 5%, si es
    'entre 51 y 250 el descuento es del 10% y si es 251 o más el descuento es del 20%. Informar por
    'cada producto subtotal (cantidad por precio unitario), porcentaje de descuento aplicado, monto
    'descontado y el total (subtotal – monto descontado). Al finalizar el ingreso, por cantidad igual a
    'cero, informar el total de pesos descontados y el total a cobrar.

    Sub Main()

        Dim cantidad As UShort
        Dim precio_unitario, descuento, subtotal, acumulado_descuento, acumulado_subtotal As Integer

        Do
            Console.Write("Cantidad del producto: ")
            cantidad = Console.ReadLine()

            If cantidad = 0 Then

                Exit Do

            End If

            Console.Write("Precio unitario del producto: ")
            precio_unitario = Console.ReadLine()

            If cantidad >= 10 And cantidad <= 50 Then
                descuento = precio_unitario * 5 / 100

                Console.WriteLine("El producto recibe un 5% de descuento.")
            ElseIf cantidad >= 51 And cantidad <= 250 Then
                descuento = precio_unitario * 10 / 100
                Console.WriteLine("El producto recibe un 10% de descuento.")
            ElseIf cantidad >= 251 Then
                descuento = precio_unitario * 20 / 100
                Console.WriteLine("El producto recibe un 20% de descuento.")
            Else
                descuento = precio_unitario * 0 / 100
                Console.WriteLine("Sin descuento.")
            End If

            subtotal = cantidad * precio_unitario

            acumulado_descuento += descuento
            acumulado_subtotal += subtotal

            Console.WriteLine("Subtotal {0}", subtotal)
            Console.WriteLine("Monto descontado {0}", descuento)
            Console.WriteLine("Total {0}", subtotal - descuento)
        Loop Until cantidad = 0

        Console.WriteLine("Total de pesos descontados {0}", acumulado_descuento)
        Console.WriteLine("Total a pagar {0}", acumulado_subtotal - acumulado_descuento)

        Console.ReadKey()

    End Sub

End Module
