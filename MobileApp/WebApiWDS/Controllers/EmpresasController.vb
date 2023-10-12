Imports System.Net
Imports System.Net.Http
Imports System.Web.Http

Public Class EmpresasController
    Inherits ApiController

    ' GET api/<controller>

    Dim ctx As GlobalDBEntities

    Public Function GetValues() As IEnumerable(Of String)
        Return New String() {"value1", "value2"}
    End Function

    ' GET api/<controller>/5
    <HttpGet>
    Public Function GetValue(ByVal id As String) As HttpResponseMessage
        Dim parametros() As String = id.Split(";")
        Dim pai_id As Integer, usu_id As Integer
        pai_id = CInt(parametros(0))
        usu_id = CInt(parametros(1))
        ctx = New GlobalDBEntities
        Dim datos = (From p In ctx.v_usuario_empresa
                     Where p.pai_id = pai_id And p.usu_id = usu_id
                     Select emp_nombre = p.emp_id & "; " & p.emp_nombre_corto, p.emp_id, p.emp_nombre_corto, emp_nombre_completo = p.emp_nombre).ToList().AsEnumerable()
        If (datos IsNot Nothing) Then
            Return Request.CreateResponse(HttpStatusCode.OK, datos)
        Else
            Return Request.CreateErrorResponse(HttpStatusCode.NotFound, "No se encontrarón registros de Empresas")
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
