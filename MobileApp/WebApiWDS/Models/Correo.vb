Public Class Correo
    Private _para As String
    Private _copiar_a As String
    Private _adjuntos As String
    Private _asunto As String
    Private _cuerpo As String
    Public Property Para As String
        Get
            Return _para
        End Get
        Set(value As String)
            _para = value
        End Set
    End Property
    Public Property Copiar_a As String
        Get
            Return _copiar_a
        End Get
        Set(value As String)
            _copiar_a = value
        End Set
    End Property
    Public Property Adjuntos As String
        Get
            Return _adjuntos
        End Get
        Set(value As String)
            _adjuntos = value
        End Set
    End Property
    Public Property Asunto As String
        Get
            Return _asunto
        End Get
        Set(value As String)
            _asunto = value
        End Set
    End Property
    Public Property Cuerpo As String
        Get
            Return _cuerpo
        End Get
        Set(value As String)
            _cuerpo = value
        End Set
    End Property
End Class
