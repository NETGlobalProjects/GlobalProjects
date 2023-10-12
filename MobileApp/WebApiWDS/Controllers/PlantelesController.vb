Imports System.Net
Imports System.Net.Http
Imports System.Web.Http

Public Class PlantelesController
    Inherits ApiController
#Disable Warning BC30002 ' No está definido el tipo 'GlobalDBEntities'.
    Dim ctx As GlobalDBEntities
#Enable Warning BC30002 ' No está definido el tipo 'GlobalDBEntities'.
    ' GET api/<controller>
    Public Function GetValues() As String
        Return "value1"
    End Function
    Public Class resultado
        Private _pla_descripcion_id As String
        Private _pai_id As Integer
        Private _pla_id As Integer
        Private _pla_descripcion As String
        Public Property pla_descripcion_id() As String
            Get
                Return _pla_descripcion_id
            End Get
            Set(ByVal value As String)
                _pla_descripcion_id = value
            End Set
        End Property
        Public Property pai_id() As Integer
            Get
                Return _pai_id
            End Get
            Set(ByVal value As Integer)
                _pai_id = value
            End Set
        End Property
        Public Property pla_id() As Integer
            Get
                Return _pla_id
            End Get
            Set(ByVal value As Integer)
                _pla_id = value
            End Set
        End Property
        Public Property pla_descripcion() As String
            Get
                Return _pla_descripcion
            End Get
            Set(ByVal value As String)
                _pla_descripcion = value
            End Set
        End Property
    End Class
    ' GET api/<controller>/5
    Public Function GetValue(ByVal id As String) As HttpResponseMessage
        ctx = New GlobalDBEntities
        Dim pa() As String = id.Split(";")
        Dim p_pai_id As Integer, p_emp_id As Integer, p_usu_id As Integer
        p_pai_id = CInt(pa(0))
        p_emp_id = CInt(pa(1))
        p_usu_id = CInt(pa(2))
        Dim cnx As New SqlClient.SqlConnection(My.MySettings.Default.con)
        Dim cmd As New SqlClient.SqlCommand("SELECT CONCAT(p.pla_id, '; ', p.pla_descripcion ) pla_descripcion_id, p.pai_id, p.pla_id, p.pla_descripcion  FROM  v_usuario_empresa_plantel p where p.pai_id = @pai_id and p.emp_id = @emp_id and p.usu_id = @usu_id", cnx)
        cmd.CommandType = CommandType.Text
        cmd.Parameters.Add("@pai_id", SqlDbType.Int).Value = p_pai_id
        cmd.Parameters.Add("@emp_id", SqlDbType.Int).Value = p_emp_id
        cmd.Parameters.Add("@usu_id", SqlDbType.Int).Value = p_usu_id

        Dim leer As SqlClient.SqlDataReader
        Dim listado As New List(Of resultado)

        cnx.Open()
        leer = cmd.ExecuteReader
        While leer.Read
            Dim valor As New resultado
            valor.pla_descripcion_id = leer(0)
            valor.pai_id = leer(1)
            valor.pla_id = leer(2)
            valor.pla_descripcion = leer(3)
            listado.Add(valor)
        End While
        cnx.Close()

        'Dim datos = (From p In ctx.v_usuario_empresa_plantel
        '             Where p.pai_id = p_pai_id And p.emp_id = p_emp_id And p.usu_id = p_usu_id
        '             Select pla_descripcion_id = p.pla_id & "; " & p.pla_descripcion, p.pai_id, p.pla_id, p.pla_descripcion).ToList().AsEnumerable()
        If (listado IsNot Nothing) Then
            Return Request.CreateResponse(HttpStatusCode.OK, listado)
        Else
            Return Request.CreateErrorResponse(HttpStatusCode.NotFound, "No se encontrarón registros de Planteles ")
        End If
    End Function

    ' POST api/<controller>
    Public Sub PostValue(<FromBody()> ByVal value As String)

    End Sub

    ' PUT api/<controller>/5
    Public Sub PutValue(ByVal id As Integer, <FromBody()> ByVal value As String)

    End Sub

    ' DELETE api/<controller>/5
    Public Sub DeleteValue(ByVal id As Integer)

    End Sub
End Class
