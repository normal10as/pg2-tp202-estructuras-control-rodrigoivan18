Module Ejer2_15

    Sub Main()

        Const interes_anual As Byte = 36
        Dim meses As Byte
        Dim capital_inicial, interes, saldo, acumulado_interes As Single

        Console.Write("Capital Inicial: ")
        capital_inicial = Console.ReadLine()

        Console.Write("Meses: ")
        meses = Console.ReadLine()

        Console.WriteLine(vbCrLf & "    MES   " & "  CAPITAL  " & "  INTERES  " & "  SALDO  ")

        For x As Byte = 1 To meses

            interes = (capital_inicial * interes_anual * meses) / 1200
            saldo = capital_inicial + interes
            acumulado_interes += interes

            Console.WriteLine("      " & x & "       " & capital_inicial & "        " & interes & "        " & saldo)

            capital_inicial = saldo

        Next

        Console.WriteLine(vbCrLf & "TOTAL INTERESES GANADOS: " & acumulado_interes & "$")

        Console.ReadKey()

    End Sub

End Module
