Public Class Jugador
    Inherits Persona
    'campos
    Private _numero As Byte


    'constructor
    Sub New(nombre As String, fechaNacimiento As Date, numero As Byte)
        MyBase.New(nombre, fechaNacimiento)
        Me.Numero = numero
    End Sub


    'propiedades
    Public Property Numero As Byte
        Get
            Return _numero
        End Get
        Set(value As Byte)
            If value >= 1 And value <= 99 Then _numero = value
        End Set
    End Property


    'metodos
    Public Overrides Function ToString() As String
        Return Nombre & " (" & Numero & ")"
    End Function

End Class
