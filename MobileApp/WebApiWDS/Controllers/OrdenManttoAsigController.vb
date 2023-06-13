Imports System.Net
Imports System.Net.Http
Imports System.Web.Http

Public Class OrdenManttoAsigController
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
        Dim parametros() As String = id.Split(";")
        Dim p_pai_id As Integer, p_emp_id As Integer, p_usu_id As Integer, buscar As String, p_pla_id As Integer
        p_pai_id = CInt(parametros(0))
        p_emp_id = CInt(parametros(1))
        p_usu_id = CInt(parametros(2))
        buscar = parametros(3)
        p_pla_id = CInt(parametros(4))
        Try
            Dim datos = (From o In ctx.v_ordenes_asignadas
                         Where o.pai_id = p_pai_id And o.emp_id = p_emp_id And o.pla_id = p_pla_id And o.usu_id_mec = p_usu_id And (o.ord_descripcion.Contains(buscar) Or o.detalle.Contains(buscar))
                         Select o
                         Order By o.ord_id Descending).ToList().AsEnumerable()
            If (datos IsNot Nothing) Then
                Return Request.CreateResponse(HttpStatusCode.OK, datos)
            Else
                Return Request.CreateErrorResponse(HttpStatusCode.NotFound, "No hay datos que mostrar")
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
