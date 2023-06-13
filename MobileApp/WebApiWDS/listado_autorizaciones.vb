Public Class listado_autorizaciones
    Private _cot_id As Integer
    Private _usu_nomina_fotografia As String
    Private _cliente As String
    Private _no_productos As Integer
    Private _fecha_cotizacion As DateTime
    Private _usu_id_crea As String
    Private _cot_tipo_doc As String
    Private _doc_decimales As Integer
    Public Property Cot_id As Integer
        Get
            Return _cot_id
        End Get
        Set(value As Integer)
            _cot_id = value
        End Set
    End Property
    Public Property Usu_nomina_fotografia As String
        Get
            Return _usu_nomina_fotografia
        End Get
        Set(value As String)
            _usu_nomina_fotografia = value
        End Set
    End Property
    Public Property Cliente As String
        Get
            Return _cliente
        End Get
        Set(value As String)
            _cliente = value
        End Set
    End Property
    Public Property No_productos As Integer
        Get
            Return _no_productos
        End Get
        Set(value As Integer)
            _no_productos = value
        End Set
    End Property
    Public Property Fecha_cotizacion As Date
        Get
            Return _fecha_cotizacion
        End Get
        Set(value As Date)
            _fecha_cotizacion = value
        End Set
    End Property
    Public Property Usu_id_crea As String
        Get
            Return _usu_id_crea
        End Get
        Set(value As String)
            _usu_id_crea = value
        End Set
    End Property

    Public Property Cot_tipo_doc As String
        Get
            Return _cot_tipo_doc
        End Get
        Set(value As String)
            _cot_tipo_doc = value
        End Set
    End Property

    Public Property Doc_decimales As Integer
        Get
            Return _doc_decimales
        End Get
        Set(value As Integer)
            _doc_decimales = value
        End Set
    End Property

    Public Sub listado_autorizaciones()
        Me.Cot_id = 0
        Me.Usu_nomina_fotografia = ""
        Me.Cliente = ""
        Me.No_productos = 0
        Me.Fecha_cotizacion = "01/01/1901"
        Me.Usu_id_crea = ""
    End Sub
    Public Sub listado_autorizaciones(cot_id As Integer, usu_nonima_fotografia As String, cliente As String, no_productos As Integer, fecha_cotizacion As DateTime, usu_id_crea As String, cot_tipo_doc As String, doc_decimales As Double)
        Me.Cot_id = cot_id
        Me.Usu_nomina_fotografia = usu_nonima_fotografia
        Me.Cliente = cliente
        Me.No_productos = no_productos
        Me.Fecha_cotizacion = fecha_cotizacion
        Me.Usu_id_crea = usu_id_crea
        Me.Cot_tipo_doc = cot_tipo_doc
        Me.Doc_decimales = doc_decimales
    End Sub

End Class
