Imports TorneosEntidades
Module JugadorTest
    Sub Main()

        Dim jugador_1 As New Jugador("Emanuel", #01-05-1983#, 15)
        mostrar(jugador_1)

        Console.ReadKey()
    End Sub

    Private Sub mostrar(jugador As Jugador)
        Console.WriteLine("Nombre: " & jugador.Nombre)
        Console.WriteLine("Fecha de nacimiento: " & jugador.FechaNacimiento)
        Console.WriteLine("Numero: " & jugador.Numero)
        Console.WriteLine("ToString: " & jugador.ToString)
        Console.WriteLine()
    End Sub

End Module
