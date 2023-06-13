Imports System.Net
Imports System.Net.Http
Imports System.Web.Http

Public Class menuAsignacionesController
    Inherits ApiController

    ' GET api/<controller>
    Public Function GetValues() As IEnumerable(Of String)
        Return New String() {"value1", "value2"}
    End Function

    ' GET api/<controller>/5
    Public Function GetValue(ByVal id As String) As HttpResponseMessage
        Dim ctx As GlobalDBEntities
        ctx = New GlobalDBEntities
        Dim parametros() As String = id.Split(";")
        Dim p_usu_id As Integer, p_function As String
        p_usu_id = CInt(parametros(0))
        p_function = parametros(1)

        Dim datos = (From m In ctx.menu_asignaciones
                     Group Join u In ctx.menu_submenu.AsEnumerable On u.men_id Equals m.men_id And u.sub_id Equals m.sub_id Into ov = Group From x In ov.DefaultIfEmpty
                     Where m.usu_id = p_usu_id And x.sub_funcion.Contains(p_function)
                     Select m.men_id, m.sub_id, m.usu_id, m.asi_insertar, m.asi_borrar, m.asi_modificar).SingleOrDefault()
        If (datos IsNot Nothing) Then
            Return Request.CreateResponse(HttpStatusCode.OK, datos)
        Else
            Return Request.CreateErrorResponse(HttpStatusCode.NotFound, "No se encotrarón registros")
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
