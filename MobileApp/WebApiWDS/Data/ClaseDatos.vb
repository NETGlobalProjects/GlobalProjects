Public Class ClaseDatos
    Shared con As New SqlClient.SqlConnection(My.MySettings.Default.con.ToString())
    Shared Function conectar()
        Return con
    End Function
    Shared Sub abrirConexion()
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
    End Sub
    Shared Sub cerrarConexion()
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
    End Sub
End Class
