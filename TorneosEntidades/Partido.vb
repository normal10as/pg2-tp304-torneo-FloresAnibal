Public Class Partido
    'campos
    Private _visitante As Equipo
    Private _local As Equipo
    Private _referee As Referee
    Private _jornada As Byte
    Private _golesVisitantes As Byte
    Private _golesLocal As Byte
    Private _minutosGolesLocales As List(Of Byte)
    Private _minutosGolesVisitantes As List(Of Byte)
    Private _estadoPartido As Boolean

    'constructor
    Sub New(jornada As Byte, equipoLocal As Equipo, equipoVisitante As Equipo)
        Me.Jornada = jornada
        Local = equipoLocal
        Visitante = equipoVisitante
        Referee = New Referee
        _golesVisitantes = 0
        _golesLocal = 0
        _minutosGolesLocales = New List(Of Byte)
        _minutosGolesVisitantes = New List(Of Byte)
        _estadoPartido = False
    End Sub

    Sub New(jornada As Byte, equipoLocal As Equipo, equipoVisitante As Equipo, golesLocal As Byte, golesVisitantes As Byte)
        Me.Jornada = jornada
        Local = equipoLocal
        Visitante = equipoVisitante
        Referee = New Referee
        _minutosGolesLocales = New List(Of Byte)
        _minutosGolesVisitantes = New List(Of Byte)
        _golesVisitantes = golesVisitantes
        _golesLocal = golesLocal
        Finalizado()
    End Sub

    'propiedades
    Public Property Jornada As Byte
        Get
            Return _jornada
        End Get
        Set(value As Byte)
            _jornada = value
        End Set
    End Property

    Public Property Visitante As Equipo
        Get
            Return _visitante
        End Get
        Set(value As Equipo)
            _visitante = value
        End Set
    End Property

    Public Property Local As Equipo
        Get
            Return _local
        End Get
        Set(value As Equipo)
            _local = value
        End Set
    End Property

    Public Property Referee As Referee
        Get
            Return _referee
        End Get
        Set(value As Referee)
            _referee = value
        End Set
    End Property

    Public ReadOnly Property GolesLocal As Byte
        Get
            Return _golesLocal
        End Get
    End Property

    Public ReadOnly Property GolesVisitantes As Byte
        Get
            Return _golesVisitantes
        End Get
    End Property

    Public ReadOnly Property MinutosGolesLocales As List(Of Byte)
        Get
            Return _minutosGolesLocales
        End Get
    End Property

    Public ReadOnly Property MinutosGolesVisitantes As List(Of Byte)
        Get
            Return _minutosGolesVisitantes
        End Get
    End Property

    'metodos
    Public Sub NuevoGolLocal(Minutos As UShort)
        If Not _estadoPartido Then
            _golesLocal += 1
            _minutosGolesLocales.Add(Minutos)
        End If
    End Sub

    Public Sub NuevoGolVisitante(Minutos As UShort)
        If Not _estadoPartido Then
            _golesVisitantes += 1
            _minutosGolesVisitantes.Add(Minutos)
        End If
    End Sub

    Public Sub Finalizado()
        'Partido Finalizado = True
        _estadoPartido = True
    End Sub

    Public Overrides Function ToString() As String
        Return Local.Nombre & " (" & GolesLocal & ") - " & Visitante.Nombre & "(" & GolesVisitantes & ")"
    End Function
End Class
