Module Ejer2_3

    'If: Crear un programa que se ingresen 5 valores enteros e informar cual es el mayor por su
    'posición de ingreso, por ejemplo, dado los siguientes valores: 3,7,12,5,9 informar: “El tercer
    'número es el mayor valor”

    Sub Main()

        Dim a, b, c, d, e As UShort

        Console.Write("Ingrese un número: ")
        a = Console.ReadLine()

        Console.Write("Ingrese un número: ")
        b = Console.ReadLine()

        Console.Write("Ingrese un número: ")
        c = Console.ReadLine()

        Console.Write("Ingrese un número: ")
        d = Console.ReadLine()

        Console.Write("Ingrese un número: ")
        e = Console.ReadLine()

        If a > b And a > c And a > d And a > e Then
            Console.WriteLine("El primer número es el mayor valor.")
        ElseIf b > c And b > d And b > e Then
            Console.WriteLine("El segundo número es el mayor valor.")
        ElseIf c > d And c > e Then
            Console.WriteLine("El tercer número es el mayor valor.")
        ElseIf d > e Then
            Console.WriteLine("El cuarto número es el mayor valor.")
        Else
            Console.WriteLine("El quinto número es el mayor valor.")
        End If
        Console.ReadKey()

    End Sub

End Module
