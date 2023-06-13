Public Class autorizacionPrecioDet
    Private _cot_precio_sugerido As Double
    Private _cot_id As Integer
    Private _cliente As String
    Private _cot_correlativo As Integer
    Private _inv_id As String
    Private _cot_descripcion As String
    Private _cot_cantidad As Double
    Private _cot_peso As Double
    Private _cot_margen As Double
    Private _cot_preciociva As Double
    Private _cot_preciosiva As Double

    Public Property Cot_precio_sugerido As Double
        Get
            Return _cot_precio_sugerido
        End Get
        Set(value As Double)
            _cot_precio_sugerido = value
        End Set
    End Property
    Public Property Cot_id As Integer
        Get
            Return _cot_id
        End Get
        Set(value As Integer)
            _cot_id = value
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

    Public Property Cot_correlativo As Integer
        Get
            Return _cot_correlativo
        End Get
        Set(value As Integer)
            _cot_correlativo = value
        End Set
    End Property

    Public Property Inv_id As String
        Get
            Return _inv_id
        End Get
        Set(value As String)
            _inv_id = value
        End Set
    End Property

    Public Property Cot_descripcion As String
        Get
            Return _cot_descripcion
        End Get
        Set(value As String)
            _cot_descripcion = value
        End Set
    End Property

    Public Property Cot_cantidad As Double
        Get
            Return _cot_cantidad
        End Get
        Set(value As Double)
            _cot_cantidad = value
        End Set
    End Property

    Public Property Cot_peso As Double
        Get
            Return _cot_peso
        End Get
        Set(value As Double)
            _cot_peso = value
        End Set
    End Property

    Public Property Cot_margen As Double
        Get
            Return _cot_margen
        End Get
        Set(value As Double)
            _cot_margen = value
        End Set
    End Property

    Public Property Cot_preciociva As Double
        Get
            Return _cot_preciociva
        End Get
        Set(value As Double)
            _cot_preciociva = value
        End Set
    End Property

    Public Property Cot_preciosiva As Double
        Get
            Return _cot_preciosiva
        End Get
        Set(value As Double)
            _cot_preciosiva = value
        End Set
    End Property
    Public Sub autorizacionPrecioDet()
    End Sub
    Public Sub autorizacionPrecioDet(cot_precio_sugerido As Double, cot_id As Integer, cliente As String, cot_correlativo As Integer, inv_id As String, cot_descripcion As String, cot_cantidad As Double, cot_peso As Double, cot_margen As Double, cot_preciociva As Double, cot_preciosiva As Double)
        Me.Cliente = cliente
        Me.Cot_cantidad = cot_cantidad
        Me.Cot_correlativo = cot_correlativo
        Me.Cot_descripcion = cot_descripcion
        Me.Cot_id = cot_id
        Me.Cot_margen = cot_margen
        Me.Cot_peso = cot_peso
        Me.Inv_id = inv_id
        Me.Cot_precio_sugerido = cot_precio_sugerido
        Me.Cot_preciociva = cot_preciociva
        Me.Cot_preciosiva = cot_preciosiva
    End Sub
End Class
