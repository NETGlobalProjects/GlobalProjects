Imports System.Net
Imports System.Net.Http
Imports System.Web.Http

Public Class UsuarioEmpresaController
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
        Dim p_pai_id As Integer, p_emp_id As Integer, p_usu_id As Integer
        p_pai_id = CInt(parametros(0))
        p_emp_id = CInt(parametros(1))
        p_usu_id = CInt(parametros(2))
        Try
            Dim datos = (From e In ctx.v_usuario_empresa_plantel
                         Where e.pai_id = p_pai_id And e.emp_id = p_emp_id And e.usu_id = p_usu_id
                         Select e).SingleOrDefault

            If datos IsNot Nothing Then
                Return Request.CreateResponse(HttpStatusCode.OK, datos)
            Else
                Return Request.CreateErrorResponse(HttpStatusCode.NotFound, "No se encontrarón registros")
            End If
        Catch ex As Exception
            Return Request.CreateErrorResponse(HttpStatusCode.NotFound, ex.Message.ToString())
        End Try
    End Function

    ' POST api/<controller>
    Public Sub PostValue(<FromBody()> ByVal value As String)

    End Sub

    ' PUT api/<controller>/5
    <HttpPut>
    Public Function PutValue(ByVal id As String) As HttpResponseMessage
        ctx = New GlobalDBEntities
        Dim parametros() As String = id.Split(";")
        Dim p_pai_id As Integer, p_emp_id As Integer, p_usu_id As Integer, p_pla_id As Integer
        p_pai_id = CInt(parametros(0))
        p_emp_id = CInt(parametros(1))
        p_usu_id = CInt(parametros(2))
        p_pla_id = CInt(parametros(3))

        Try
            Dim dato = (From e In ctx.usuario_empresa_usuario
                        Where e.pai_id = p_pai_id And e.emp_id = p_emp_id And e.usu_id = p_usu_id
                        Select e).SingleOrDefault()

            dato.pla_id = p_pla_id
            ctx.SaveChanges()
            Return Request.CreateResponse(HttpStatusCode.OK, "Registro modificado correctamente")

        Catch ex As Exception
            Return Request.CreateErrorResponse(HttpStatusCode.NotFound, ex.Message.ToString())
        End Try
    End Function

    ' DELETE api/<controller>/5
    Public Sub DeleteValue(ByVal id As Integer)

    End Sub
End Class
