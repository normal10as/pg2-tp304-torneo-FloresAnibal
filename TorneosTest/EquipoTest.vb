Imports TorneosEntidades

Module EquipoTest

    Sub Main()

        Dim equipo_1 As New Equipo("Misiones")

        Console.WriteLine("Nombre: " & equipo_1.Nombre)
        Console.WriteLine("ToString: " & equipo_1.ToString)

        Console.ReadKey()

    End Sub

End Module
