Imports System.Net
Imports System.Web.Http
Imports System.Data.SqlClient
Public Class scpController
    Inherits ApiController

    ' GET api/<controller>
    Public Function GetValues() As IEnumerable(Of String)
        Return New String() {"value1", "value2"}
    End Function

    ' GET api/<controller>/5
    Public Function GetValue(ByVal id As String) As String
        Try
            Dim cmd As New SqlCommand("select scp_estado from solicitudes_cambio_contrasena where scp_id='" & id & "'", ClaseDatos.conectar)
            Dim leer As SqlDataReader
            Dim estado As String
            ClaseDatos.abrirConexion()
            leer = cmd.ExecuteReader
            While leer.Read
                estado = leer(0)
            End While
            ClaseDatos.cerrarConexion()
            Return estado
        Catch ex As Exception
            Return "Error: " & ex.Message.ToString()
        Finally
            ClaseDatos.cerrarConexion()
        End Try
    End Function

    ' POST api/<controller>
    Public Function PostValue(<FromBody()> ByVal value As scp) As String
        Try

            Dim p_usu_id As String
            Dim p_correo As String
            p_usu_id = value.User_name
            p_correo = value.Correo

            Dim cmd As New SqlCommand("p_solicitud_cambio_clave", ClaseDatos.conectar)
            Dim leer As SqlDataReader
            Dim hay_error As Boolean, spc As String, mensaje As String
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@user_name", SqlDbType.NVarChar, 50).Value = p_usu_id
            cmd.Parameters.Add("@correo", SqlDbType.NVarChar, 100).Value = p_correo

            ClaseDatos.abrirConexion()
            leer = cmd.ExecuteReader
            While leer.Read
                hay_error = leer(0)
                spc = leer(1)
                mensaje = leer(2)
            End While
            ClaseDatos.cerrarConexion()

            If hay_error Then
                Return "Error: " & mensaje
            Else
                Return spc
            End If
        Catch ex As Exception
            Return "Error: " & ex.Message.ToString()
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
