Imports System.Net
Imports System.Net.Http
Imports System.Web.Http

Public Class PlantelesController
    Inherits ApiController
#Disable Warning BC30002 ' No está definido el tipo 'GlobalDBEntities'.
    Dim ctx As GlobalDBEntities
#Enable Warning BC30002 ' No está definido el tipo 'GlobalDBEntities'.
    ' GET api/<controller>
    Public Function GetValues() As String
        Return "value1"
    End Function

    ' GET api/<controller>/5
    Public Function GetValue(ByVal id As String) As HttpResponseMessage
        ctx = New GlobalDBEntities
        Dim pa() As String = id.Split(";")
        Dim p_pai_id As Integer, p_emp_id As Integer
        p_pai_id = CInt(pa(0))
        p_emp_id = CInt(pa(1))
        Dim datos = (From p In ctx.general_plantas
                     Where p.pai_id = p_pai_id And p.emp_id = p_emp_id
                     Select pla_descripcion_id = p.pla_id & "; " & p.pla_descripcion, p.pai_id, p.pla_id, p.pla_descripcion).ToList().AsEnumerable()
        If (datos IsNot Nothing) Then
            Return Request.CreateResponse(HttpStatusCode.OK, datos)
        Else
            Return Request.CreateErrorResponse(HttpStatusCode.NotFound, "No se encontrarón registros")
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
