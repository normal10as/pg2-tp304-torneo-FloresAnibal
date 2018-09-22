Public Class Referee
    Inherits Persona

    'campos
    Private _internacional As Boolean


    'constructor
    Sub New()
        Me.New("", Nothing, False)
    End Sub
    'sobrecargado
    Sub New(nombre As String, fechaNacimiento As Date, internacional As Boolean)
        MyBase.New(nombre, fechaNacimiento)
        Me.Internacional = internacional
    End Sub


    'propiedades
    Public Property Internacional As Boolean
        Get
            Return _internacional
        End Get
        Set(value As Boolean)
            _internacional = value
        End Set
    End Property

    'metodos
    Public Overrides Function ToString() As String
        Return If(Internacional, Nombre & " (" & Chr(34) & "I" & Chr(34) & ")", Nombre)
        'Chr(34) = comilla doble
    End Function
End Class
