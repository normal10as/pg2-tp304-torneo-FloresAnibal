Public Class Equipo
    'campos
    Private _nombre As String
    Private _jugadores As List(Of Jugador)


    'constructor
    Sub New(nombre As String)
        Me.Nombre = nombre
        _jugadores = New List(Of Jugador)
    End Sub


    'propiedades
    Public Property Nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            If ValidarCadena(value, 30) Then _nombre = value
        End Set
    End Property

    Public Sub comprarJugador(jugador As Jugador)
        'si el jugador pertenece a un equipo no se realiza la compra
        If jugador.Equipo Is Nothing Then
            jugador.Equipo = Me
            _jugadores.Add(jugador)
        End If
    End Sub

    Public Function getAllJugadores() As List(Of Jugador)
        Return _jugadores
    End Function

    Public Sub venderJugador(jugador As Jugador, equipoDestino As Equipo)
        equipoDestino.comprarJugador(jugador) '= jugador.Equipo
        liberarJugador(jugador)
    End Sub

    Public Sub liberarJugador(jugador)
        'jugador.equipo = Nothing
        _jugadores.Remove(jugador)
    End Sub

    'metodos
    Public Overrides Function ToString() As String
        Return Nombre
    End Function

    'valida la longitud maxima y minima de un string
    Private Function ValidarCadena(cadena As String, maximo As UShort) As Boolean
        If cadena.Length >= 1 And cadena.Length <= maximo Then
            Return True
        End If
        Return False
    End Function
End Class
