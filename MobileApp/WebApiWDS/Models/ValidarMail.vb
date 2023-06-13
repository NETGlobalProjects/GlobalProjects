Public Class ValidarMail
    Private _mail As String
    Public Property Mail As String
        Get
            Return _mail
        End Get
        Set(value As String)
            _mail = value
        End Set
    End Property
End Class
