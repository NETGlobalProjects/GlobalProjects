Imports System.Net
Imports System.Web.Http
Imports System.Net.Http
Public Class PushNotificacionesController
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
        Try
            ctx = New GlobalDBEntities
            Dim p_usu_id As Integer = CInt(id)

            Dim datos = (From n In ctx.notificaciones_push
                         Where n.usu_id = p_usu_id And n.pus_read = 0
                         Select n).ToList().AsEnumerable()
            If datos IsNot Nothing Then

                Dim cmd As New SqlClient.SqlCommand("update notificaciones_push set pus_read =1 where usu_id = " & p_usu_id & "", ClaseDatos.conectar)
                ClaseDatos.abrirConexion()
                cmd.ExecuteNonQuery()
                ClaseDatos.cerrarConexion()

                Return Request.CreateResponse(HttpStatusCode.OK, datos)



            Else
                Return Request.CreateErrorResponse(HttpStatusCode.NotFound, "No hay datos para mostrar")
            End If


        Catch ex As Exception
            ClaseDatos.cerrarConexion()
            Return Request.CreateErrorResponse(HttpStatusCode.NotFound, ex.Message.ToString())
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
