Imports System.Net
Imports System.Net.Http
Imports System.Web.Http

Public Class OrdenManttoItemsEstadoController
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
        Dim p_pai_id As Integer = CInt(parametros(0))
        Dim p_emp_id As Integer = CInt(parametros(1))
        Dim p_ord_id As Integer = CInt(parametros(2))
        Dim p_dor_id As Integer = CInt(parametros(3))
        Try
            Dim estado As Integer? = 0
            estado = (From c In ctx.mantto_orden_items
                      Where c.pai_id = p_pai_id And c.emp_id = p_emp_id And c.ord_id = p_ord_id And c.dor_id = p_dor_id
                      Select c.dor_estado).Single
            If (Not IsNumeric(estado) Or estado = 0) Then
                Return Request.CreateResponse(HttpStatusCode.OK, 0)
            Else
                Return Request.CreateResponse(HttpStatusCode.OK, estado)
            End If

            'Else
            '    Return Request.CreateErrorResponse(HttpStatusCode.NotFound, "No se encontrarón registros")
            'End If

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
