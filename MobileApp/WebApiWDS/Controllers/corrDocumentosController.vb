Imports System.Net
Imports System.Net.Http
Imports System.Web.Http

Public Class corrDocumentosController
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
        Try
            Dim parametros() As String = id.Split(";")
            Dim pai_id As Integer, emp_id As Integer, doc_id As String
            pai_id = CInt(parametros(0))
            emp_id = CInt(parametros(1))
            doc_id = parametros(2)
            Dim correlativo As Integer
            Dim dato = (From c In ctx.general_documentos_correlativos
                        Where c.pai_id = pai_id And c.emp_id = emp_id And c.doc_id = doc_id
                        Select c).SingleOrDefault
            correlativo = dato.doc_correlativo + 1
            dato.doc_correlativo = correlativo
            ctx.SaveChanges()
            Return Request.CreateResponse(HttpStatusCode.OK, dato)
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
