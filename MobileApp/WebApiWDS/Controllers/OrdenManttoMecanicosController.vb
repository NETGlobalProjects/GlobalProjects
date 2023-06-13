Imports System.Net
Imports System.Web.Http
Imports System.Net.Http
Public Class OrdenManttoMecanicosController
    Inherits ApiController
    Dim ctx As GlobalDBEntities
    ' GET api/<controller>
    Public Function GetValues() As IEnumerable(Of String)
        Return New String() {"value1", "value2"}
    End Function

    ' GET api/<controller>/5
    Public Function GetValue(ByVal id As String) As HttpResponseMessage
        Try
            ctx = New GlobalDBEntities
            Dim pm() As String = id.Split(";")
            Dim p_pai_id As Integer, p_emp_id As Integer, p_ord_id As Integer
            p_pai_id = CInt(pm(0))
            p_emp_id = CInt(pm(1))
            p_ord_id = CInt(pm(2))

            Dim datos = (From a In ctx.v_mecanicos_orden_mantto
                         Where a.pai_id = p_pai_id And a.emp_id = p_emp_id And a.ord_id = p_ord_id
                         Select a).ToList().AsEnumerable()
            If datos IsNot Nothing Then
                Return Request.CreateResponse(HttpStatusCode.OK, datos)
            Else
                Return Request.CreateErrorResponse(HttpStatusCode.NotFound, "No se encontrarón registros")
            End If

        Catch ex As Exception
            Return Request.CreateErrorResponse(HttpStatusCode.NotFound, ex.Message.ToString())
        End Try
    End Function

    ' POST api/<controller>
    <HttpPost>
    Public Function PostValue(ByVal id As String) As String
        Try
            Dim pm() As String = id.Split(";")
            Dim p_pai_id As Integer, p_emp_id As Integer, p_ord_id As Integer, p_mec_id As Integer, p_usu_id As Integer
            p_pai_id = CInt(pm(0))
            p_emp_id = CInt(pm(1))
            p_ord_id = CInt(pm(2))
            p_mec_id = CInt(pm(3))
            p_usu_id = CInt(pm(4))

            Dim cmd As New SqlClient.SqlCommand("p_insertar_mec_mantto_mano_obra", ClaseDatos.conectar)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@pai_id", SqlDbType.Int).Value = p_pai_id
            cmd.Parameters.Add("@emp_id", SqlDbType.Int).Value = p_emp_id
            cmd.Parameters.Add("@ord_id", SqlDbType.Int).Value = p_ord_id
            cmd.Parameters.Add("@mec_id", SqlDbType.Int).Value = p_mec_id
            cmd.Parameters.Add("@usu_id", SqlDbType.Int).Value = p_usu_id


            Dim hay_error As Boolean, mensaje As String
            mensaje = ""
            Dim leer As SqlClient.SqlDataReader
            ClaseDatos.abrirConexion()
            leer = cmd.ExecuteReader
            While leer.Read
                hay_error = leer(0)
                mensaje = leer(1)
            End While
            ClaseDatos.cerrarConexion()
            If hay_error Then
                Return "Error: " & mensaje
            Else
                Return mensaje
            End If
        Catch ex As Exception
            Return "Error: " & ex.Message.ToString()
        Finally
            ClaseDatos.cerrarConexion()
        End Try
    End Function

    ' PUT api/<controller>/5
    Public Sub PutValue(ByVal id As Integer, <FromBody()> ByVal value As String)

    End Sub

    ' DELETE api/<controller>/5
    Public Sub DeleteValue(ByVal id As Integer)

    End Sub
End Class
