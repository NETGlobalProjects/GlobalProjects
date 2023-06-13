Imports System.Net
Imports System.Web.Http
Imports System.Data.SqlClient
Imports System.Net.Http

Public Class LoginController
    Inherits ApiController

    Dim ctx As GlobalDBEntities

    ' GET api/<controller>ByID
    <HttpGet>
    Public Function GetValue(ByVal id As String) As HttpResponseMessage

        Dim parametros() As String = id.Split(";")
        Dim usuario As String = parametros(0)
        Dim contraseña As String = parametros(1)
        Dim correcto As Boolean = False, usu_id As Integer


        cmd = New SqlCommand("select convert(bit,(select case when(select count(*) from usuario_usuarios u where u.usu_username = '" & usuario & "' and DECRYPTBYPASSPHRASE((select convert(varchar, c.glb_valor) from configuracion_globales c where c.glb_descripcion = 'nominacion'), u.usu_password) = '" & contraseña & "' ) >0 then 1 else 0 end)),  isnull((select u.usu_id from usuario_usuarios u where u.usu_username = '" & usuario & "' and DECRYPTBYPASSPHRASE((select convert(varchar, c.glb_valor) from configuracion_globales c where c.glb_descripcion = 'nominacion'), u.usu_password) = '" & contraseña & "' ),0)", ClaseDatos.conectar)
        ClaseDatos.abrirConexion()
        leer = cmd.ExecuteReader
        While leer.Read
            correcto = leer(0)
            usu_id = leer(1)
        End While
        ClaseDatos.cerrarConexion()

        ctx = New GlobalDBEntities

        Dim datos = (From m In ctx.v_usuario_usuarios
                     Where m.usu_id = usu_id
                     Select m).SingleOrDefault()

        If datos IsNot Nothing Then
            Return Request.CreateResponse(HttpStatusCode.OK, datos)
        Else
            Return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Registro no encontrado")
        End If

    End Function

    ' POST api/<controller>
    <HttpPost>
    Public Function PostValue(<FromBody()> ByVal id As Login)
        Dim usuario As String = id.usuario
        Dim contraseña As String = id.contraseña
        Dim correcto As Boolean = False, usu_id As Integer

        cmd = New SqlCommand("select convert(bit,(select case when(select count(*) from usuario_usuarios u where u.usu_username = '" & usuario & "' and DECRYPTBYPASSPHRASE((select convert(varchar, c.glb_valor) from configuracion_globales c where c.glb_descripcion = 'nominacion'), u.usu_password) = '" & contraseña & "' ) >0 then 1 else 0 end)),  isnull((select u.usu_id from usuario_usuarios u where u.usu_username = '" & usuario & "' and DECRYPTBYPASSPHRASE((select convert(varchar, c.glb_valor) from configuracion_globales c where c.glb_descripcion = 'nominacion'), u.usu_password) = '" & contraseña & "' ),0)", ClaseDatos.conectar)
        ClaseDatos.abrirConexion()
        leer = cmd.ExecuteReader
        While leer.Read
            correcto = leer(0)
            usu_id = leer(1)
        End While
        ClaseDatos.cerrarConexion()

        ctx = New GlobalDBEntities
        If correcto = True Then
            Dim datos = (From m In ctx.usuario_usuarios
                         Where m.usu_id = usu_id
                         Select m).SingleOrDefault

            If datos IsNot Nothing Then
                Return Request.CreateResponse(HttpStatusCode.OK, datos)
            Else
                Return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Registro no encontrado")
            End If
        Else
            Return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Registro no encontrado")
        End If
    End Function

    ' PUT api/<controller>/5
    Public Sub PutValue(ByVal id As Integer, <FromBody()> ByVal value As String)

    End Sub

    ' DELETE api/<controller>/5
    Public Sub DeleteValue(ByVal id As Integer)

    End Sub
End Class
