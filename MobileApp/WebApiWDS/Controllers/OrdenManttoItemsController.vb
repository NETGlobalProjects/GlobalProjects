Imports System.Net
Imports System.Net.Http
Imports System.Web.Http

Public Class OrdenManttoItemsController
    Inherits ApiController
#Disable Warning BC30002 ' No está definido el tipo 'GlobalDBEntities'.
    Dim ctx As GlobalDBEntities
#Enable Warning BC30002 ' No está definido el tipo 'GlobalDBEntities'.
    ' GET api/<controller>
    Public Function GetValues() As IEnumerable(Of String)
        Return New String() {"value1", "value2"}
    End Function

    ' GET api/<controller>/5
    <HttpGet>
    Public Function GetValue(ByVal id As String) As HttpResponseMessage
        ctx = New GlobalDBEntities
        Dim parametros() As String = id.Split(";")
        Dim p_pai_id As Integer = CInt(parametros(0))
        Dim p_emp_id As Integer = CInt(parametros(1))
        Dim p_ord_id As Integer = CInt(parametros(2))
        Try
            Dim datos = (From i In ctx.mantto_orden_items
                         Where i.pai_id = p_pai_id And i.emp_id = p_emp_id And i.ord_id = p_ord_id
                         Select i
                         Order By i.dor_id Descending).ToList().AsEnumerable()
            If (datos IsNot Nothing) Then
                Return Request.CreateResponse(HttpStatusCode.OK, datos)
            Else
                Return Request.CreateErrorResponse(HttpStatusCode.NotFound, "No se encontrarón registros")
            End If

        Catch ex As Exception
            Return Request.CreateErrorResponse(HttpStatusCode.NotFound, ex.Message.ToString())
        End Try
    End Function

    ' POST api/<controller>
#Disable Warning BC30002 ' No está definido el tipo 'mantto_orden_items'.
    <HttpPost>
    Public Function PostValue(<FromBody()> ByVal value As mantto_orden_items) As HttpResponseMessage
#Enable Warning BC30002 ' No está definido el tipo 'mantto_orden_items'.
        ctx = New GlobalDBEntities
        Try
            ctx.mantto_orden_items.Add(value)
            ctx.SaveChanges()
            Return Request.CreateResponse(HttpStatusCode.OK, "Item añadido correctamente")
        Catch ex As Exception
            Return Request.CreateErrorResponse(HttpStatusCode.NotFound, ex.InnerException.ToString())
        End Try

    End Function

    ' PUT api/<controller>/5
    <HttpPut>
    Public Function PutValue(ByVal id As String)
        ctx = New GlobalDBEntities
        Dim pm() As String = id.Split(";")
        Dim p_pai_id As Integer, p_emp_id As Integer, p_ord_id As Integer, p_dor_id As Integer, v_inv_id As String, v_cantidad As Double
        p_pai_id = CInt(pm(0))
        p_emp_id = CInt(pm(1))
        p_ord_id = CInt(pm(2))
        p_dor_id = CInt(pm(3))
        v_inv_id = pm(4)

        v_cantidad = CDbl(pm(5))
        Try
            Dim descripcion As String = (From m In ctx.inventario_inventarios
                                         Where m.pai_id = p_pai_id And m.inv_id = v_inv_id
                                         Select m.inv_descripcion).Single()


            Dim linea = (From i In ctx.mantto_orden_items
                         Where i.pai_id = p_pai_id And i.emp_id = p_emp_id And i.ord_id = p_ord_id And i.dor_id = p_dor_id
                         Select i).SingleOrDefault()
            linea.dor_cantidad = v_cantidad
            linea.inv_id = v_inv_id
            linea.dor_descripcion = descripcion
            ctx.SaveChanges()
            Return Request.CreateResponse(HttpStatusCode.OK, "Linea modificada correctamente")
        Catch ex As Exception
            Return Request.CreateErrorResponse(HttpStatusCode.NotFound, ex.InnerException.ToString())
        End Try
    End Function
    ' DELETE api/<controller>/5
    <HttpDelete>
    Public Function DeleteValue(ByVal id As String) As HttpResponseMessage
        ctx = New GlobalDBEntities
        Dim pm() As String = id.Split(";")
        Dim p_pai_id As Integer, p_emp_id As Integer, p_ord_id As Integer, p_dor_id As Integer
        p_pai_id = CInt(pm(0))
        p_emp_id = CInt(pm(1))
        p_ord_id = CInt(pm(2))
        p_dor_id = CInt(pm(3))
        Try
            Dim linea = (From i In ctx.mantto_orden_items
                         Where i.pai_id = p_pai_id And i.emp_id = p_emp_id And i.ord_id = p_ord_id And i.dor_id = p_dor_id
                         Select i).SingleOrDefault()
            ctx.mantto_orden_items.Remove(linea)
            ctx.SaveChanges()
            Return Request.CreateResponse(HttpStatusCode.OK, "Linea eliminada correctamente")

        Catch ex As Exception
            Return Request.CreateErrorResponse(HttpStatusCode.NotFound, ex.InnerException.ToString())
        End Try


    End Function
End Class
