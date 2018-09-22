Imports TorneosEntidades

Module RefereeTest
    Sub Main()

        Dim referee_1 As New Referee("Esteban", #05-26-1976#, True)
        mostrar(referee_1)

        Dim referee_2 As New Referee("Roberto", #03-16-1967#, False)
        mostrar(referee_2)

        Console.ReadKey()
    End Sub

    Private Sub mostrar(referee As Referee)
        Console.WriteLine("Nombre: " & referee.Nombre)
        Console.WriteLine("Fecha de nacimiento: " & referee.FechaNacimiento)
        Console.WriteLine("Internacional: " & referee.Internacional)
        Console.WriteLine("ToString: " & referee.ToString)
        Console.WriteLine()
    End Sub
End Module
