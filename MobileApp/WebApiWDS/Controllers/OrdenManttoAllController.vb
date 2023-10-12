Imports System.Net
Imports System.Web.Http
Imports System.Net.Http
Public Class OrdenManttoAllController
    Inherits ApiController
    Dim ctx As GlobalDBEntities
    ' GET api/<controller>
    Public Function GetValues() As IEnumerable(Of String)
        Return New String() {"value1", "value2"}
    End Function

    ' GET api/<controller>/5
    Public Function GetValue(ByVal id As String) As HttpResponseMessage
        Try
            ctx = New GlobalDBEntities
            Dim pm() As String = id.Split(";")
            Dim p_pai_id As Integer, p_emp_id As Integer, p_pla_id As Integer, p_oes_id As Integer, p_buscar As String
            p_pai_id = CInt(pm(0))
            p_emp_id = CInt(pm(1))
            p_pla_id = CInt(pm(2))
            p_oes_id = CInt(pm(3))
            p_buscar = pm(4)
            Dim datos
            If (p_oes_id < 0) Then
                datos = (From o In ctx.v_ordenes_mantto
                         Where o.pai_id = p_pai_id And o.emp_id = p_emp_id And o.pla_id = p_pla_id And (o.ord_descripcion.Contains(p_buscar) Or o.maq_nombre.Contains(p_buscar) Or o.are_descripcion.Contains(p_buscar) Or o.sba_descripcion.Contains(p_buscar))
                         Select o
                         Order By o.ord_fecha_hora_creacion Descending).ToList().AsEnumerable()
            Else
                datos = (From o In ctx.v_ordenes_mantto
                         Where o.pai_id = p_pai_id And o.emp_id = p_emp_id And o.pla_id = p_pla_id And o.oes_id = p_oes_id And (o.ord_descripcion.Contains(p_buscar) Or o.maq_nombre.Contains(p_buscar) Or o.are_descripcion.Contains(p_buscar) Or o.sba_descripcion.Contains(p_buscar))
                         Select o
                         Order By o.ord_fecha_hora_creacion Descending).ToList().AsEnumerable()
            End If
            If datos IsNot Nothing Then
                Return Request.CreateResponse(HttpStatusCode.OK, datos)
            Else
                Return Request.CreateErrorResponse(HttpStatusCode.NotFound, "No se encontrarón registros de ordenes de mantto")
            End If

        Catch ex As Exception
            Return Request.CreateErrorResponse(HttpStatusCode.NotFound, ex.Message())
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
