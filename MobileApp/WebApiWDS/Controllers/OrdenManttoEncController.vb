Imports System.Net
Imports System.Net.Http
Imports System.Web.Http
#Disable Warning BC40056 ' El espacio de nombres o el tipo especificado en el 'WebApiWDSVB' Imports no contienen ningún miembro público o no se encuentran. Asegúrese de que el espacio de nombres o el tipo se hayan definido y de que contengan al menos un miembro público. Asegúrese de que el nombre del elemento importado no use ningún alias.
Imports WebApiWDSVB
#Enable Warning BC40056 ' El espacio de nombres o el tipo especificado en el 'WebApiWDSVB' Imports no contienen ningún miembro público o no se encuentran. Asegúrese de que el espacio de nombres o el tipo se hayan definido y de que contengan al menos un miembro público. Asegúrese de que el nombre del elemento importado no use ningún alias.
Public Class OrdenManttoEncController
    Inherits ApiController
#Disable Warning BC30002 ' No está definido el tipo 'GlobalDBEntities'.
    Dim ctx As GlobalDBEntities
#Enable Warning BC30002 ' No está definido el tipo 'GlobalDBEntities'.
    ' GET api/<controller>
    <HttpGet>
    Public Function GetValues() As HttpResponseMessage
        ctx = New GlobalDBEntities
        Dim datos = (From m In ctx.mantto_orden_capa
                     Select m).ToList().AsEnumerable()
        If (datos IsNot Nothing) Then
            Return Request.CreateResponse(HttpStatusCode.OK, datos)
        Else
            Return Request.CreateErrorResponse(HttpStatusCode.NotFound, "No hay datos que mostrar")
        End If

    End Function

    ' GET api/<controller>/5
    <HttpGet>
    Public Function GetValueBy(ByVal id As String) As HttpResponseMessage
        Dim parametros() As String
        parametros = id.Split(";")
        Dim p_pai_id As Integer, p_emp_id As Integer, ord_id As Integer
        p_pai_id = CInt(parametros(0))
        p_emp_id = CInt(parametros(1))
        ord_id = CInt(parametros(2))
        ctx = New GlobalDBEntities
        Dim datos = (From m In ctx.mantto_orden_capa
                     Where m.pai_id = p_pai_id And m.emp_id = p_emp_id And m.ord_id = ord_id
                     Select m).SingleOrDefault

        If datos IsNot Nothing Then
            Return Request.CreateResponse(HttpStatusCode.OK, datos)
        Else
            Return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Registro no encontrado")
        End If
    End Function

    ' POST api/<controller>
#Disable Warning BC30002 ' No está definido el tipo 'mantto_orden_capa'.
    <HttpPost>
    Public Function PostValue(<FromBody()> ByVal value As mantto_orden_capa) As HttpResponseMessage
#Enable Warning BC30002 ' No está definido el tipo 'mantto_orden_capa'.
        Try
            ctx = New GlobalDBEntities
            ctx.mantto_orden_capa.Add(value)
            ctx.SaveChanges()
            Return Request.CreateResponse(HttpStatusCode.OK, "Orden de Mantenimiento creada exitosamente")
        Catch ex As Exception
            Return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Error: " & ex.Message.ToString())
        End Try

    End Function

    ' PUT api/<controller>/5
    Public Sub PutValue(ByVal id As Integer, <FromBody()> ByVal value As String)

    End Sub

    ' DELETE api/<controller>/5
    Public Sub DeleteValue(ByVal id As Integer)

    End Sub
End Class
