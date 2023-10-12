Imports System.Net
Imports System.Net.Http
Imports System.Web.Http

Public Class UsuarioEmpresaController
    Inherits ApiController
#Disable Warning BC30002 ' No está definido el tipo 'GlobalDBEntities'.
    Dim ctx As GlobalDBEntities
#Enable Warning BC30002 ' No está definido el tipo 'GlobalDBEntities'.
    ' GET api/<controller>
    Public Function GetValues() As IEnumerable(Of String)
        Return New String() {"value1", "value2"}
    End Function
    Public Class EmpresaUsuario
        Private _pai_id As Integer
        Private _emp_id As Integer
        Private _usu_id As Integer
        Private _suc_id As String
        Private _suc_nombre As String
        Private _bod_id As String
        Private _bod_descripcion As String
        Private _pla_id As Integer
        Private _pla_descripcion As String
        Private _emp_nombre_corto As String


        Public Property pai_id() As Integer
            Get
                Return _pai_id
            End Get
            Set(ByVal value As Integer)
                _pai_id = value
            End Set
        End Property
        Public Property emp_id() As Integer
            Get
                Return _emp_id
            End Get
            Set(ByVal value As Integer)
                _emp_id = value
            End Set
        End Property
        Public Property usu_id() As Integer
            Get
                Return _usu_id
            End Get
            Set(ByVal value As Integer)
                _usu_id = value
            End Set
        End Property
        Public Property suc_id() As String
            Get
                Return _suc_id
            End Get
            Set(ByVal value As String)
                _suc_id = value
            End Set
        End Property
        Public Property suc_nombre() As String
            Get
                Return _suc_nombre
            End Get
            Set(ByVal value As String)
                _suc_nombre = value
            End Set
        End Property
        Public Property bod_id() As String
            Get
                Return _bod_id
            End Get
            Set(ByVal value As String)
                _bod_id = value
            End Set
        End Property
        Public Property bod_descripcion() As String
            Get
                Return _bod_descripcion
            End Get
            Set(ByVal value As String)
                _bod_descripcion = value
            End Set
        End Property
        Public Property pla_id() As String
            Get
                Return _pla_id
            End Get
            Set(ByVal value As String)
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
        Public Property emp_nombre_corto() As String
            Get
                Return _emp_nombre_corto
            End Get
            Set(ByVal value As String)
                _emp_nombre_corto = value
            End Set
        End Property
    End Class
    ' GET api/<controller>/5
    Public Function GetValue(ByVal id As String) As HttpResponseMessage
        ctx = New GlobalDBEntities
        Dim parametros() As String = id.Split(";")
        Dim p_pai_id As Integer, p_emp_id As Integer, p_usu_id As Integer
        p_pai_id = CInt(parametros(0))
        p_emp_id = CInt(parametros(1))
        p_usu_id = CInt(parametros(2))
        Try


            Dim cnx As New SqlClient.SqlConnection(My.MySettings.Default.con)
            Dim cmd As New SqlClient.SqlCommand("SELECT distinct [pai_id], [emp_id], [usu_id], [suc_id], [suc_nombre], [bod_id], [bod_descripcion], [pla_id], [pla_descripcion], rtrim([emp_nombre_corto]) emp_nombre_corto FROM  v_usuario_empresa_plantel p where p.pai_id = @pai_id and p.emp_id = @emp_id and p.usu_id = @usu_id", cnx)
            cmd.CommandType = CommandType.Text
            cmd.Parameters.Add("@pai_id", SqlDbType.Int).Value = p_pai_id
            cmd.Parameters.Add("@emp_id", SqlDbType.Int).Value = p_emp_id
            cmd.Parameters.Add("@usu_id", SqlDbType.Int).Value = p_usu_id

            Dim leer As SqlClient.SqlDataReader
            Dim listado As New List(Of EmpresaUsuario)

            cnx.Open()
            leer = cmd.ExecuteReader
            While leer.Read
                Dim valor As New EmpresaUsuario

                valor.pai_id = leer(0)
                valor.emp_id = leer(1)
                valor.usu_id = leer(2)
                valor.suc_id = leer(3)
                valor.suc_nombre = leer(4)
                valor.bod_id = leer(5)
                valor.bod_descripcion = leer(6)
                valor.pla_id = leer(7)
                valor.pla_descripcion = leer(8)
                valor.emp_nombre_corto = leer(9)
                listado.Add(valor)
            End While
            cnx.Close()
            'Dim datos = (From e In ctx.v_usuario_empresa_plantel
            '             Where e.pai_id = p_pai_id And e.emp_id = p_emp_id And e.usu_id = p_usu_id
            '             Select e).SingleOrDefault

            If listado IsNot Nothing Then
                Return Request.CreateResponse(HttpStatusCode.OK, listado)
            Else
                Return Request.CreateErrorResponse(HttpStatusCode.NotFound, "No se encontrarón registros de Empresa Usuarios")
            End If
        Catch ex As Exception
            Return Request.CreateErrorResponse(HttpStatusCode.NotFound, ex.Message.ToString())
        End Try
    End Function

    ' POST api/<controller>
    Public Sub PostValue(<FromBody()> ByVal value As String)

    End Sub

    ' PUT api/<controller>/5
    <HttpPut>
    Public Function PutValue(ByVal id As String) As HttpResponseMessage
        ctx = New GlobalDBEntities
        Dim parametros() As String = id.Split(";")
        Dim p_pai_id As Integer, p_emp_id As Integer, p_usu_id As Integer, p_pla_id As Integer
        p_pai_id = CInt(parametros(0))
        p_emp_id = CInt(parametros(1))
        p_usu_id = CInt(parametros(2))
        p_pla_id = CInt(parametros(3))

        Try
            Dim dato = (From e In ctx.usuario_empresa_usuario
                        Where e.pai_id = p_pai_id And e.emp_id = p_emp_id And e.usu_id = p_usu_id
                        Select e).SingleOrDefault()

            dato.pla_id = p_pla_id
            ctx.SaveChanges()
            Return Request.CreateResponse(HttpStatusCode.OK, "Registro modificado correctamente")

        Catch ex As Exception
            Return Request.CreateErrorResponse(HttpStatusCode.NotFound, ex.Message.ToString())
        End Try
    End Function

    ' DELETE api/<controller>/5
    Public Sub DeleteValue(ByVal id As Integer)

    End Sub
End Class
