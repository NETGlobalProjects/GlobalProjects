Imports System.Net
Imports System.Web.Http
Imports System.Net.Http
Imports System.Data.SqlClient

Public Class autorizacionPreciosDetController
    Inherits ApiController

    ' GET api/<controller>
    Public Function GetValues() As IEnumerable(Of String)
        Return New String() {"value1", "value2"}
    End Function

    ' GET api/<controller>/5
    Public Function GetValue(ByVal id As Integer) As HttpResponseMessage
        Dim cnx As New SqlConnection(My.MySettings.Default.con.ToString)
        Dim query As String = "select dt.cot_precio_sugerido,dt.cot_id,(select cp.cli_id+cp.cot_cli_nombre from cotizacion_capa cp where cp.cot_id=dt.cot_id) cliente 
                                  ,dt.cot_correlativo,dt.inv_id,dt.cot_descripcion,dt.cot_cantidad,dt.cot_peso,dt.cot_margen,dt.cot_preciociva,dt.cot_preciosiva 
                                  from cotizacion_detalle dt 
                                  where dt.cot_estado_aut_precio='PEN' and dt.cot_estado in (9)
                                  and dt.cot_id= " & id & ""
        Dim cmd As New SqlCommand(query, cnx)
        Dim leer As SqlDataReader
        Dim listado As New List(Of autorizacionPrecioDet)
        Try
            cnx.Open()
            leer = cmd.ExecuteReader
            While leer.Read
                Dim nuevo As New autorizacionPrecioDet
                nuevo.autorizacionPrecioDet(leer(0), leer(1), leer(2), leer(3), leer(4), leer(5), leer(6), leer(7), leer(8), leer(9), leer(10))
                listado.Add(nuevo)

            End While
            cnx.Close()

            If listado IsNot Nothing Then
                Return Request.CreateResponse(HttpStatusCode.OK, listado.ToList().AsEnumerable())
            Else
                Return Request.CreateErrorResponse(HttpStatusCode.NotFound, "No se encontrarón registros")
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
    Public Function PostValue(ByVal id As Integer)
        Dim cnx As New SqlConnection(My.MySettings.Default.con.ToString)
        Try

            Return Request.CreateResponse(HttpStatusCode.OK, "Notificación enviada exitosamente")
        Catch ex As Exception
            Return Request.CreateErrorResponse(HttpStatusCode.NotFound, ex.InnerException.ToString())
        Finally
            If cnx.State = ConnectionState.Open Then
                cnx.Close()
            End If

        End Try
    End Function

    ' PUT api/<controller>/5
    Public Function PutValue(ByVal id As String)
        Dim ctx As New GlobalDBEntities

        Dim pm() As String = id.Split(";")
        Dim _cot_id As Integer, _cot_correlativo As Integer, _usu_id As Integer, _cot_estado_aut_precio As String, _precio_autorizado As Double, _doc_decimales As Integer, estado_x As Integer
        _cot_id = CInt(pm(0))
        _cot_correlativo = CInt(pm(1))
        _usu_id = CInt(pm(2))
        _cot_estado_aut_precio = pm(3)
        _precio_autorizado = Convert.ToDouble(pm(4).Replace("P", "."))
        _doc_decimales = Convert.ToDouble(pm(5))

        Try
            Dim linea = (From i In ctx.cotizacion_detalle
                         Where i.cot_id = _cot_id And i.cot_correlativo = _cot_correlativo
                         Select i).SingleOrDefault()
            Dim capa = (From a In ctx.cotizacion_capa
                        Where a.cot_id = _cot_id
                        Select a).SingleOrDefault()

            If _cot_estado_aut_precio = "APR" Then
                linea.cot_estado_aut_precio = _cot_estado_aut_precio
                linea.cot_precioautorizado = Math.Round(_precio_autorizado, _doc_decimales)
                linea.cot_estado = 10
                estado_x = 10
                linea.usu_id_autorizadaprecio = _usu_id
                linea.cot_fechaautorizacion = Today & " " & Format(TimeOfDay, "HH:mm:ss")
            ElseIf _cot_estado_aut_precio = "DEN" Then
                linea.cot_estado_aut_precio = _cot_estado_aut_precio
                linea.cot_precioautorizado = Nothing
                linea.cot_estado = 3
                estado_x = 3
                linea.usu_id_autorizadaprecio = Nothing
                linea.cot_fechaautorizacion = Nothing
            End If
            capa.cot_estado = estado_x

            ctx.SaveChanges()

            Dim cnx As New SqlConnection(My.MySettings.Default.con.ToString)
            Try
                Dim cmd As New SqlCommand("p_cotizacion_not_autorizacion_request", cnx)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@cot_id", SqlDbType.Int).Value = _cot_id
                cnx.Open()
                cmd.ExecuteNonQuery()
                cnx.Close()

            Catch ex As Exception
            Finally
                If cnx.State = ConnectionState.Open Then
                    cnx.Close()
                End If
            End Try

            Return Request.CreateResponse(HttpStatusCode.OK, "Linea modificada correctamente")
        Catch ex As Exception
            Return Request.CreateErrorResponse(HttpStatusCode.NotFound, ex.InnerException.ToString())
        End Try
    End Function

    ' DELETE api/<controller>/5
    Public Sub DeleteValue(ByVal id As Integer)

    End Sub
End Class
