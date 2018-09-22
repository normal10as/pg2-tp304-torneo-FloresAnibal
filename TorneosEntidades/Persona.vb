Public MustInherit Class Persona
    'campos
    Private _fechaNacimiento As Date
    Private _nombre As String

    'constructor
    Sub New(nombre As String, fechaNacimiento As Date)
        Me.Nombre = nombre
        Me.FechaNacimiento = fechaNacimiento
    End Sub


    'propiedades
    Public Property FechaNacimiento As Date
        Get
            Return _fechaNacimiento
        End Get
        Set(value As Date)
            'value <> Nothing = se evalua porque al instanciar una subclase con su constructor 
            'predeterminado daba error
            If value <> Nothing Then
                'paso la fecha de nacimiento menos un dia para evitar grabar la fecha si 
                'cumple 16 el dia de hoy.
                If CalcularEdad(value.AddDays(-1)) >= 16 Then _fechaNacimiento = value
            End If
        End Set
    End Property

    Public ReadOnly Property Edad As UShort
        Get
            'If para evitar que edad devuelva un valor distinto de cero cuando _fechaNacimiento es "Nothing" 
            If _fechaNacimiento = Nothing Then Return 0
            Return CalcularEdad(FechaNacimiento)
        End Get
    End Property

    Public Property Nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            If ValidarCadena(value) Then _nombre = value
        End Set
    End Property

    'metodos
    Public Overrides Function ToString() As String
        Return Nombre
    End Function

    Private Function CalcularEdad(fechaNacimiento As Date) As UShort
        If fechaNacimiento.Day < Today.Day And fechaNacimiento.Month <= Today.Month Then
            Return DateDiff("yyyy", fechaNacimiento, Date.Now) - 1
        End If
        Return DateDiff("yyyy", fechaNacimiento, Date.Now)
    End Function

    'valida la longitud minima de un string
    Private Function ValidarCadena(cadena As String) As Boolean
        If cadena.Length > 0 Then
            Return True
        End If
        Return False
    End Function
End Class
