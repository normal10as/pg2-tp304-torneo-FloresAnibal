Imports TorneosEntidades

Module EquipoTest

    Sub Main()

        Dim equipo_1 As New Equipo("Misiones")
        Dim equipo_2 As New Equipo("Candelaria")
        Dim jugador_1 As New Jugador("Carlos", #05-03-1997#, 5)
        Dim jugador_2 As New Jugador("Martin", #05-03-1987#, 4)

        equipo_1.comprarJugador(jugador_1) 'equipo1 compra jugador1
        mostrarEquipo(equipo_1)
        MostrarJugadores(equipo_1)

        equipo_2.comprarJugador(jugador_2) 'equipo1 compra jugador1
        mostrarEquipo(equipo_2)
        MostrarJugadores(equipo_2)

        equipo_2.venderJugador(jugador_2, equipo_1) 'equipo2 vende jugador1 a equipo1
        mostrarEquipo(equipo_1)
        MostrarJugadores(equipo_1)

        mostrarEquipo(equipo_2)
        MostrarJugadores(equipo_2)

        Console.ReadKey()

        equipo_2.comprarJugador(jugador_2) 'equipo2 intenta comprar jugador2 que pertenece a equipo1
        mostrarEquipo(equipo_2)
        MostrarJugadores(equipo_2)

        Console.ReadKey()

    End Sub

    Private Sub MostrarJugadores(equipo As Equipo)
        Console.WriteLine("Jugadores: ")
        For Each iterar In equipo.getAllJugadores
            Console.WriteLine(iterar.Nombre)
        Next
        Console.WriteLine()
    End Sub

    Private Sub mostrarEquipo(equipo As Equipo)
        Console.WriteLine("Nombre: " & equipo.Nombre)
        Console.WriteLine("ToString: " & equipo.ToString)
    End Sub
End Module
