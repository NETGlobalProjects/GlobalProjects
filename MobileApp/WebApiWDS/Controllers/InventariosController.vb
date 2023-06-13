Imports System.Net
Imports System.Net.Http
Imports System.Web.Http

Public Class InventariosController
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
        Dim pm() As String = id.Split(";")
        Dim p_pai_id As Integer, buscar As String
        p_pai_id = CInt(pm(0))
        buscar = pm(1)
        Try
            Dim datos = (From i In ctx.inventario_inventarios
                         Group Join u In ctx.general_unidades_medida.AsEnumerable On u.uni_id Equals i.uni_id Into ov = Group From x In ov.DefaultIfEmpty
                         Where i.pai_id = p_pai_id And (i.inv_descripcion.Contains(buscar) Or i.inv_descripcion_larga.Contains(buscar) Or i.inv_id.Contains(buscar))
                         Select i.inv_id, i.inv_descripcion, i.inv_descripcion_larga, i.inv_estado, i.inv_maneja_existencias, i.inv_peso, i.inv_unidad_presentacion, i.inv_otros_datos, i.uni_id, x.uni_descripcion).ToList().AsEnumerable()
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
    Public Sub PostValue(<FromBody()> ByVal value As String)

    End Sub

    ' PUT api/<controller>/5
    Public Sub PutValue(ByVal id As Integer, <FromBody()> ByVal value As String)

    End Sub

    ' DELETE api/<controller>/5
    Public Sub DeleteValue(ByVal id As Integer)

    End Sub
End Class
