Public Class Login
    Private _usuario As String
    Private _contraseña As String

    Public Property usuario As String
        Get
            Return _usuario
        End Get
        Set
            _usuario = Value
        End Set
    End Property

    Public Property contraseña As String
        Get
            Return _contraseña
        End Get
        Set
            _contraseña = Value
        End Set
    End Property
End Class
