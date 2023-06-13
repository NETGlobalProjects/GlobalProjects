Imports System.Net
Imports System.Web.Http
Imports System.Net.Http
Imports System.Data.SqlClient
Imports System.Data
Public Class OrdenManttoEncEstadoController
    Inherits ApiController
#Disable Warning BC30002 ' No está definido el tipo 'GlobalDBEntities'.
    Dim ctx As GlobalDBEntities
#Enable Warning BC30002 ' No está definido el tipo 'GlobalDBEntities'.
    ' GET api/<controller>
    Public Function GetValues() As IEnumerable(Of String)
        Return New String() {"value1", "value2"}
    End Function

    ' GET api/<controller>/5
    Public Function GetValue(ByVal id As String) As HttpResponseMessage

        ctx = New GlobalDBEntities
        Dim parametros() As String = id.Split(";")
        Dim p_pai_id As Integer = CInt(parametros(0))
        Dim p_emp_id As Integer = CInt(parametros(1))
        Dim p_ord_id As Integer = CInt(parametros(2))

        Try
            Dim estado As Integer? = 0
            estado = (From o In ctx.mantto_orden_capa
                      Where o.pai_id = p_pai_id And o.emp_id = p_emp_id And o.ord_id = p_ord_id
                      Select o.oes_id).Single
            If (Not IsNumeric(estado) Or estado = 0) Then
                Return Request.CreateResponse(HttpStatusCode.OK, 0)
            Else
                Return Request.CreateResponse(HttpStatusCode.OK, estado)
            End If
        Catch ex As Exception
            Return Request.CreateErrorResponse(HttpStatusCode.NotFound, ex.Message.ToString())
        End Try

    End Function

    ' POST api/<controller>
    Public Function PostValue(ByVal id As String) As HttpResponseMessage
        Dim parametros() As String = id.Split(";")
        Dim p_pai_id As Integer = CInt(parametros(0))
        Dim p_emp_id As Integer = CInt(parametros(1))
        Dim p_ord_id As Integer = CInt(parametros(2))
        Dim p_proceso As Integer = CInt(parametros(3)) ' 1= Iniciar, 2= Pausar, 3 = Finalizar
        Dim p_comentario_mec As String = parametros(4)
        Dim p_usu_id As Integer = CInt(parametros(5))

        Try
            Dim cmd As New SqlCommand("p_actualizar_estado_orden_mantto", ClaseDatos.conectar)
            Dim leer As SqlDataReader, hay_error As Boolean, mensaje_pa As String
            hay_error = False
            mensaje_pa = ""
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@pai_id", SqlDbType.Int).Value = p_pai_id
            cmd.Parameters.Add("@emp_id", SqlDbType.Int).Value = p_emp_id
            cmd.Parameters.Add("@ord_id", SqlDbType.Int).Value = p_ord_id
            cmd.Parameters.Add("@proceso", SqlDbType.Int).Value = p_proceso
            cmd.Parameters.Add("@comentario_mecanico", SqlDbType.NVarChar, 250).Value = p_comentario_mec
            cmd.Parameters.Add("@usu_id", SqlDbType.Int).Value = p_usu_id

            ClaseDatos.abrirConexion()
            leer = cmd.ExecuteReader
            While leer.Read
                hay_error = leer(0)
                mensaje_pa = leer(1)
            End While
            ClaseDatos.cerrarConexion()


            If hay_error Then
                Return Request.CreateErrorResponse(HttpStatusCode.NotFound, mensaje_pa)
            Else
                Return Request.CreateResponse(HttpStatusCode.OK, mensaje_pa)
            End If
        Catch ex As Exception
            ClaseDatos.cerrarConexion()
            Return Request.CreateErrorResponse(HttpStatusCode.NotFound, ex.Message.ToString())
        End Try

    End Function

    ' PUT api/<controller>/5
    Public Sub PutValue(ByVal id As Integer, <FromBody()> ByVal value As String)

    End Sub

    ' DELETE api/<controller>/5
    Public Sub DeleteValue(ByVal id As Integer)

    End Sub
End Class
