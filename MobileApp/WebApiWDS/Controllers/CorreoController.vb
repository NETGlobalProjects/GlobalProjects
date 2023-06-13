Imports System.Net
Imports System.Web.Http
Imports System.Net.Http
Public Class CorreoController
    Inherits ApiController

    ' GET api/<controller>
    Public Function GetValues() As IEnumerable(Of String)
        Return New String() {"value1", "value2"}
    End Function

    ' GET api/<controller>/5
    Public Function GetValue(ByVal id As ValidarMail) As String
        Return "value"
    End Function

    ' POST api/<controller>
    Public Function PostValue(<FromBody()> ByVal value As Correo) As HttpResponseMessage
        Try
            Dim para As String, asunto As String, cuerpo As String, copiar_a As String, adjuntos As String
            para = value.Para
            asunto = value.Asunto
            cuerpo = value.Cuerpo
            copiar_a = value.Copiar_a
            adjuntos = value.Adjuntos

            cmd = New SqlClient.SqlCommand("p_enviar_correo", ClaseDatos.conectar)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@para", SqlDbType.NVarChar).Value = para
            If RTrim(copiar_a) <> "" Then
                cmd.Parameters.Add("@copiar_a", SqlDbType.NVarChar).Value = copiar_a
            End If
            If RTrim(adjuntos) <> "" Then
                cmd.Parameters.Add("@adjuntos", SqlDbType.NVarChar).Value = adjuntos
            End If
            cmd.Parameters.Add("@asunto", SqlDbType.NVarChar).Value = asunto
            cmd.Parameters.Add("cuerpo", SqlDbType.NVarChar).Value = cuerpo

            Dim leer As SqlClient.SqlDataReader
            Dim hay_error As Boolean, mensaje_pa As String
            ClaseDatos.abrirConexion()
            leer = cmd.ExecuteReader
            While leer.Read
                hay_error = leer(0)
                mensaje_pa = leer(1)
            End While
            ClaseDatos.cerrarConexion()
            If hay_error Then
                Return Request.CreateErrorResponse(HttpStatusCode.NotFound, mensaje_pa)
            Else
                Return Request.CreateResponse(HttpStatusCode.OK, mensaje_pa)
            End If

        Catch ex As Exception
            ClaseDatos.cerrarConexion()
            Return Request.CreateErrorResponse(HttpStatusCode.NotFound, ex.Message.ToString())
        End Try

    End Function

    ' PUT api/<controller>/5
    Public Sub PutValue(ByVal id As Integer, <FromBody()> ByVal value As String)

    End Sub

    ' DELETE api/<controller>/5
    Public Sub DeleteValue(ByVal id As Integer)

    End Sub
End Class
