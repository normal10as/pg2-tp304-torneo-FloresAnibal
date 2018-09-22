Imports TorneosEntidades

Module PersonaTest

    Sub Main()
        'Dim persona_1 As New Persona("Carlos35", #05-01-1983#) 'mm-dd-aaaa
        'mostrar(persona_1)

        'Dim persona_2 As New Persona("Carmen12", #05-01-2006#)
        'mostrar(persona_2)

        'Dim persona_3 As New Persona("cumple16hoy", #09-19-2002#)
        'mostrar(persona_3)

        'Dim persona_4 As New Persona("cumplio16ayer", #09-20-2002#)
        'mostrar(persona_4)

        'Console.ReadKey()
    End Sub
    Private Sub mostrar(persona As Persona)
        Console.WriteLine("Nombre: " & persona.Nombre)
        Console.WriteLine("Fecha de nacimiento: " & persona.FechaNacimiento)
        Console.WriteLine("Edad: " & persona.Edad)
        Console.WriteLine()
    End Sub

End Module
