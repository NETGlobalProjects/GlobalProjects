Imports System.Net
Imports System.Net.Http
Imports System.Web.Http

Public Class maquinasController
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
        Dim p_pai_id As Integer, p_emp_id As Integer, p_are_id As Integer, p_sba_id As Integer, p_pla_id As Integer
        p_pai_id = CInt(parametros(0))
        p_emp_id = CInt(parametros(1))
        p_are_id = CInt(parametros(2))
        p_sba_id = CInt(parametros(3))
        p_pla_id = CInt(parametros(4))



        Dim datos = (From m In ctx.activos_maquinas
                     Where m.pai_id = p_pai_id And m.emp_id = p_emp_id And m.are_id = p_are_id And m.sba_id = p_sba_id And m.pla_id = p_pla_id
                     Select maq_codigo_nombre = m.maq_id & "; " & m.maq_nombre, m.pai_id, m.emp_id, m.maq_id, m.maq_nombre, m.maq_descripcion, m.maq_no_serie, m.maq_capacidad, m.maq_fecha_ingreso, m.maq_potencia, m.mar_id, m.maq_modelo, m.cco_id, m.maq_fecha_fabricacion, m.maq_dimensiones, m.maq_cap_diseno, m.ctc_id, m.maq_activo_fijo, m.maq_peso_neto, m.maq_fecha_instalacion, m.are_id, m.sba_id, m.prv_id, m.uni_id, m.maq_estado).ToList().AsEnumerable()
        If (datos IsNot Nothing) Then
            Return Request.CreateResponse(HttpStatusCode.OK, datos)
        Else
            Return Request.CreateErrorResponse(HttpStatusCode.NotFound, "No se encotrarón registros de maquinas")
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
