Imports System.Net
Imports System.Net.Http
Imports System.Web.Http

Public Class subAreasController
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

        Dim parametros() As String = id.Split(";")
        Dim pai_id As Integer = CInt(parametros(0))
        Dim emp_id As Integer = CInt(parametros(1))
        Dim are_id As Integer = CInt(parametros(2))
        Dim pla_id As Integer = CInt(parametros(3))

        ctx = New GlobalDBEntities
        Dim datos = (From a In ctx.general_sub_areas
                     Where a.pai_id = pai_id And a.emp_id = emp_id And a.are_id = are_id And a.pla_id = pla_id
                     Select sba_descripcion = a.sba_id & "; " & a.sba_descripcion, a.sba_activo).ToList().AsEnumerable()
        If (datos IsNot Nothing) Then
            Return Request.CreateResponse(HttpStatusCode.OK, datos)
        Else
            Return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Registro no encontrado")
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
