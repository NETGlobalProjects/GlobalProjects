Imports System.Net
Imports System.Web.Http
Imports System.Net.Http

Public Class estadosOrdenesController
    Inherits ApiController
#Disable Warning BC30002 ' No está definido el tipo 'GlobalDBEntities'.
    Dim ctx As GlobalDBEntities
#Enable Warning BC30002 ' No está definido el tipo 'GlobalDBEntities'.
    ' GET api/<controller>
    Public Function GetValues() As HttpResponseMessage
        Try
            ctx = New GlobalDBEntities
            Dim dato = (From e In ctx.v_estados_ordenes
                        Select e).ToList().AsEnumerable()
            If dato IsNot Nothing Then
                Return Request.CreateResponse(HttpStatusCode.OK, dato)
            Else
                Return Request.CreateErrorResponse(HttpStatusCode.NotFound, "No se encontraron registros de estados ordenes")
            End If
        Catch ex As Exception
            Return Request.CreateErrorResponse(HttpStatusCode.NotFound, ex.Message.ToString())
        End Try
    End Function

    ' GET api/<controller>/5
    Public Function GetValue(ByVal id As String) As HttpResponseMessage
        Dim p_oes_id As Integer = CInt(id)
        Try
            ctx = New GlobalDBEntities
            Dim dato = (From e In ctx.v_estados_ordenes
                        Where e.oes_id = p_oes_id
                        Select e).SingleOrDefault()
            If dato IsNot Nothing Then
                Return Request.CreateResponse(HttpStatusCode.OK, dato)
            Else
                Return Request.CreateErrorResponse(HttpStatusCode.NotFound, "No se encontraron registros de estados ordenes")
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
