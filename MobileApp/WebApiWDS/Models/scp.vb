Public Class scp
    Private _user_name As String
    Private _correo As String

    Public Property User_name As String
        Get
            Return _user_name
        End Get
        Set(value As String)
            _user_name = value
        End Set
    End Property

    Public Property Correo As String
        Get
            Return _correo
        End Get
        Set(value As String)
            _correo = value
        End Set
    End Property
End Class
