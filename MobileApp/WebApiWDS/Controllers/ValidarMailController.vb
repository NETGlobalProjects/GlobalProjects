Imports System.Net
Imports System.Web.Http

Public Class ValidarMailController
    Inherits ApiController

    ' GET api/<controller>
    Public Function GetValues() As IEnumerable(Of String)
        Return New String() {"value1", "value2"}
    End Function

    ' GET api/<controller>/5
    Public Function GetValue(ByVal id As String) As String

    End Function

    ' POST api/<controller>
    Public Function PostValue(<FromBody()> ByVal id As ValidarMail) As String
        Try
            Dim correo As New ValidarMail

            correo = id
            Dim query As String = "p_validar_mail"
            Dim cmd As New SqlClient.SqlCommand(query, ClaseDatos.conectar)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@mail", SqlDbType.NVarChar, 100).Value = correo.Mail

            Dim leer As SqlClient.SqlDataReader
            Dim valido As Boolean = False
            ClaseDatos.abrirConexion()
            leer = cmd.ExecuteReader
            While leer.Read
                valido = leer(0)
            End While
            ClaseDatos.cerrarConexion()
            If valido = True Then
                Return "OK"
            Else
                Return "NO"
            End If
        Catch ex As Exception
            ClaseDatos.cerrarConexion()
            Return "Error:" & ex.Message.ToString()
        End Try
    End Function

    ' PUT api/<controller>/5
    Public Sub PutValue(ByVal id As Integer, <FromBody()> ByVal value As String)

    End Sub

    ' DELETE api/<controller>/5
    Public Sub DeleteValue(ByVal id As Integer)

    End Sub
End Class
