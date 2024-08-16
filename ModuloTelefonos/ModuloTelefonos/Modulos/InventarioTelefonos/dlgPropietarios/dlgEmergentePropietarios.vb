Public Class dlgEmergentePropietarios
    Public odtsInventarioTelefonos As New dtsInventarioTelefonos
    Private Sub dlgEmergentePropietarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Public Sub cargarbusquedaPropietarios(buscar As String)
        Try
            Dim dtsbuscarpropietarios As New dtsInventarioTelefonosTableAdapters.BuscarPropietariosTableAdapter

            dtsbuscarpropietarios.Fill(odtsInventarioTelefonos.BuscarPropietarios, buscar)

            Me.DataGridViewX2.AutoGenerateColumns = False
            Me.DataGridViewX2.DataSource = odtsInventarioTelefonos.BuscarPropietarios

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Admin GT - Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class