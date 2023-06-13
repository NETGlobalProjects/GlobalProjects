Public Class CambiarContrasena
    Private _usu_username As String
    Private _usu_correo As String
    Private _usu_nuevacontrasena As String

    Public Property Usu_username As String
        Get
            Return _usu_username
        End Get
        Set(value As String)
            _usu_username = value
        End Set
    End Property

    Public Property Usu_correo As String
        Get
            Return _usu_correo
        End Get
        Set(value As String)
            _usu_correo = value
        End Set
    End Property

    Public Property Usu_nuevacontrasena As String
        Get
            Return _usu_nuevacontrasena
        End Get
        Set(value As String)
            _usu_nuevacontrasena = value
        End Set
    End Property
End Class
