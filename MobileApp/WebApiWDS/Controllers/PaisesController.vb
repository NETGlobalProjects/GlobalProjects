Imports System.Net
Imports System.Net.Http
Imports System.Web.Http

Public Class PaisesController
    Inherits ApiController
#Disable Warning BC30002 ' No está definido el tipo 'GlobalDBEntities'.
    Dim ctx As GlobalDBEntities
#Enable Warning BC30002 ' No está definido el tipo 'GlobalDBEntities'.
    ' GET api/<controller>
    Public Function GetValues() As HttpResponseMessage
        ctx = New GlobalDBEntities
        Dim datos = (From p In ctx.general_paises
                     Where p.pai_id = 1
                     Select pai_nombre = p.pai_id & "; " & p.pai_nombre, p.pai_id, p.pai_abreviatura).ToList().AsEnumerable()
        If (datos IsNot Nothing) Then
            Return Request.CreateResponse(HttpStatusCode.OK, datos)
        Else
            Return Request.CreateErrorResponse(HttpStatusCode.NotFound, "No se encontrarón registros")
        End If
    End Function

    ' GET api/<controller>/5
    Public Function GetValue(ByVal id As Integer) As String
        Return "value"
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
