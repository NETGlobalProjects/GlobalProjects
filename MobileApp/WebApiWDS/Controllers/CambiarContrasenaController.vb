Imports System.Net
Imports System.Web.Http
Imports System.Data.SqlClient
Public Class CambiarContrasenaController
    Inherits ApiController

    ' GET api/<controller>
    Public Function GetValues() As IEnumerable(Of String)
        Return New String() {"value1", "value2"}
    End Function

    ' GET api/<controller>/5
    Public Function GetValue(ByVal id As Integer) As String
        Return "value"
    End Function

    ' POST api/<controller>
    Public Function PostValue(<FromBody()> ByVal value As CambiarContrasena) As String
        Try
            Dim cmd As New SqlCommand("p_usuario_resetear_contrasena", ClaseDatos.conectar)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@usu_username", SqlDbType.NVarChar, 30).Value = value.Usu_username
            cmd.Parameters.Add("@usu_correo", SqlDbType.NVarChar, 50).Value = value.Usu_correo
            cmd.Parameters.Add("@usu_newpassword", SqlDbType.NVarChar, 30).Value = value.Usu_nuevacontrasena
            Dim leer As SqlDataReader
            Dim hay_error As Boolean, mensaje As String
            ClaseDatos.abrirConexion()
            leer = cmd.ExecuteReader
            While leer.Read
                hay_error = leer(0)
                mensaje = leer(1)
            End While
            ClaseDatos.cerrarConexion()
            If hay_error Then
                Return "Error: " + mensaje
            Else
                Return mensaje
            End If

        Catch ex As Exception
            Return "Error: " + ex.Message.ToString()
        Finally
            ClaseDatos.cerrarConexion()
        End Try
    End Function

    ' PUT api/<controller>/5
    Public Sub PutValue(ByVal id As Integer, <FromBody()> ByVal value As String)

    End Sub

    ' DELETE api/<controller>/5
    Public Sub DeleteValue(ByVal id As Integer)

    End Sub
End Class
