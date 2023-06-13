Imports System.Net
Imports System.Web.Http
Imports System.Net.Http
Public Class ListaMecanicosController
    Inherits ApiController
    Dim ctx As GlobalDBEntities
    ' GET api/<controller>
    Public Function GetValues() As HttpResponseMessage
        Try
            ctx = New GlobalDBEntities
            Dim datos = (From a In ctx.v_listado_mecanicos
                         Select a).ToList().AsEnumerable()
            If datos IsNot Nothing Then
                Return Request.CreateResponse(HttpStatusCode.OK, datos)
            Else
                Return Request.CreateErrorResponse(HttpStatusCode.NotFound, "No se encontrarón datos")
            End If
        Catch ex As Exception
            Return Request.CreateErrorResponse(HttpStatusCode.NotFound, ex.Message.ToString())
        End Try
    End Function

    ' GET api/<controller>/5
    Public Function GetValue(ByVal id As String) As HttpResponseMessage
        Try
            ctx = New GlobalDBEntities
            Dim datos = (From a In ctx.v_listado_mecanicos
                         Where a.mec_nombre.Contains(id)
                         Select a).ToList().AsEnumerable()
            If datos IsNot Nothing Then
                Return Request.CreateResponse(HttpStatusCode.OK, datos)
            Else
                Return Request.CreateErrorResponse(HttpStatusCode.NotFound, "No se encontrarón datos")
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
