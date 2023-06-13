Imports System.Net
Imports System.Net.Http
Imports System.Web.Http
#Disable Warning BC40056 ' El espacio de nombres o el tipo especificado en el 'WebApiWDS.Data' Imports no contienen ningún miembro público o no se encuentran. Asegúrese de que el espacio de nombres o el tipo se hayan definido y de que contengan al menos un miembro público. Asegúrese de que el nombre del elemento importado no use ningún alias.
Imports WebApiWDS.Data
#Enable Warning BC40056 ' El espacio de nombres o el tipo especificado en el 'WebApiWDS.Data' Imports no contienen ningún miembro público o no se encuentran. Asegúrese de que el espacio de nombres o el tipo se hayan definido y de que contengan al menos un miembro público. Asegúrese de que el nombre del elemento importado no use ningún alias.
Public Class centrosAtencionController
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

        ctx = New GlobalDBEntities
        Dim datos = (From c In ctx.mantto_orden_centros_atencion
                     Where c.pai_id = pai_id And c.emp_id = emp_id
                     Select cda_descripcion = c.cda_id & "; " & c.cda_descripcion, c.cda_activo).ToList().AsEnumerable()
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
