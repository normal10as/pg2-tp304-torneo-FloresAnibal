Imports TorneosEntidades

Module PartidoTest

    Sub Main()
        Dim equipo_1 As New Equipo("Rojo")
        Dim equipo_2 As New Equipo("Azul")
        Dim partido_1 As New Partido(5, equipo_1, equipo_2)

        partido_1.NuevoGolLocal(25)
        partido_1.NuevoGolVisitante(60)
        partido_1.NuevoGolVisitante(78)
        partido_1.Finalizado()

        mostrar(partido_1)

        partido_1.NuevoGolLocal(80)
        mostrar(partido_1)

        Console.ReadKey()
    End Sub

    Private Sub mostrar(partido As Partido)
        Console.WriteLine("Jornada: " & partido.Jornada)
        Console.WriteLine("Equipo Local: " & partido.Local.Nombre)
        Console.WriteLine("Equipo Visitante: " & partido.Visitante.Nombre)
        Console.WriteLine("Goles Local: " & partido.GolesLocal)
        Console.WriteLine("Goles Visitante: " & partido.GolesVisitantes)
        MostrarMinutos("Minutos Goles Locales: ", partido.MinutosGolesLocales)
        MostrarMinutos("Minutos Goles Visitantes: ", partido.MinutosGolesVisitantes)
        Console.WriteLine("ToString: " & partido.ToString)
        Console.WriteLine()
    End Sub

    Private Sub MostrarMinutos(cadena As String, lista As List(Of Byte))
        For Each iterar As UShort In lista
            Console.WriteLine(cadena & iterar)
        Next
    End Sub
End Module
