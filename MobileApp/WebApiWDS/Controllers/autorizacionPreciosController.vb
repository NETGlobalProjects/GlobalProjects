Imports System.Net
Imports System.Web.Http
Imports System.Net.Http
Imports System.Data.SqlClient
Public Class autorizacionPreciosController

    Inherits ApiController
    Structure lista_autorizaciones
        Public cot_id As Integer
        Public usu_nomina_fotogracia As String
        Public cliente As String
        Public no_productos As Integer
        Public fecha_cotizacion As DateTime
        Public usu_id_crea As String
    End Structure
    ' GET api/<controller>
    Public Function GetValues() As IEnumerable(Of String)
        Return New String() {"value1", "value2"}
    End Function

    ' GET api/<controller>/5
    Public Function GetValue(ByVal id As String) As HttpResponseMessage
        Dim valor() As String = id.Split(";")
        Dim buscar As String = valor(1)
        Dim cnx As New SqlConnection(My.MySettings.Default.con.ToString)
        Dim query As String = "select distinct dt.cot_id, isnull(n.usu_nomina_fotografia,'') usu_nomina_fotografia, 
	                                    (select cp.cli_id+'; '+cp.cot_cli_nombre from cotizacion_capa cp where cp.cot_id=dt.cot_id) cliente,
	                                    (select count(*)  from cotizacion_detalle dt2 where dt2.cot_id = dt.cot_id and dt2.cot_estado_aut_precio = 'PEN' and dt2.cot_estado in (9)) no_productos, format(c.cot_fechacreacion, 'dd/MM/yyyy HH:mm:ss') fecha_cotizacion,
	                                    dbo.fe_GetNombreApellido (c.usu_id_crea) usu_id_crea, c.cot_tipo_doc, cf.doc_decimales
                                    from cotizacion_detalle dt inner join cotizacion_capa c on c.cot_id = dt.cot_id
															   left join general_documentos d on d.doc_id_nd = c.cot_tipo_doc
															   left join configuracion_documentos cf on cf.doc_id = d.doc_id
							                                     left join usuario_usuarios u on u.usu_id = c.usu_id_crea
							                                     left join v_usuario_nomina n on n.usu_id_nomina = u.usu_id_nomina
                                    where dt.cot_estado_aut_precio='PEN' and dt.cot_estado in (9)
                                            and (dt.cot_id like '%" & buscar & "%' 
                                                    or (select cp.cli_id+cp.cot_cli_nombre from cotizacion_capa cp where cp.cot_id=dt.cot_id) like '%" & buscar & "%' 
                                                    or convert(char,c.cot_fechacreacion,103) like '%" & buscar & "%')
                                    order by cot_id"
        Dim cmd As New SqlCommand(query, cnx)
        Dim leer As SqlDataReader
        Dim listado As New List(Of listado_autorizaciones)
        Try
            cnx.Open()
            leer = cmd.ExecuteReader
            While leer.Read
                Dim nuevo As New listado_autorizaciones
                nuevo.listado_autorizaciones(leer(0), leer(1), leer(2), leer(3), leer(4), leer(5), leer(6), leer(7))
                listado.Add(nuevo)

            End While
            cnx.Close()

            If listado IsNot Nothing Then
                Return Request.CreateResponse(HttpStatusCode.OK, listado.ToList().AsEnumerable())
            Else
                Return Request.CreateErrorResponse(HttpStatusCode.NotFound, "No se encontrarón registros de autorizacion precios")
            End If

        Catch ex As Exception
            Return Nothing
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If
        End Try
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
