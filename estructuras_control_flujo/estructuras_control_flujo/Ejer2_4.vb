﻿Module Ejer2_4

    'If: Se ingresan dos valores relativos a un producto en venta: cantidad y precio unitario. Si la
    'cantidad es entre a 10 y 50 el producto recibe un descuento de 5%, si es entre 51 y 250 el
    'descuento es del 10% y si es 251 o más el descuento es del 20%. Informar subtotal (cantidad por
    'precio unitario), porcentaje de descuento aplicado, monto descontado y el total (subtotal –
    'monto descontado).

    Sub Main()

        Dim cantidad As UShort
        Dim precio_unitario, subtotal, descuento As UInteger

        Console.Write("Ingrese la Cantidad: ")
        cantidad = Console.ReadLine()

        Console.Write("Ingrese el precio unitario: ")
        precio_unitario = Console.ReadLine()

        If cantidad >= 10 And cantidad <= 50 Then
            descuento = precio_unitario * 5 / 100
            Console.WriteLine("El producto recibe un 5% de descuento.")

        ElseIf cantidad >= 51 And cantidad <= 250 Then
            descuento = precio_unitario * 10 / 100
            Console.WriteLine("El producto recibe un 10% de descuento.")

        Else
            descuento = precio_unitario * 20 / 100
            Console.WriteLine("El productor recibe un 20% de descuento.")

        End If

        subtotal = cantidad * precio_unitario

        Console.WriteLine("Subtotal {0}", subtotal)
        Console.WriteLine("Monto descontado {0}", descuento)
        Console.WriteLine("Total {0}", subtotal - descuento)

        Console.ReadKey()

    End Sub

End Module
