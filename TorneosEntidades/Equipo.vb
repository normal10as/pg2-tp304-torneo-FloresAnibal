Public Class Equipo
    'campos
    Private _nombre As String


    'constructor
    Sub New(nombre As String)
        Me.Nombre = nombre
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
