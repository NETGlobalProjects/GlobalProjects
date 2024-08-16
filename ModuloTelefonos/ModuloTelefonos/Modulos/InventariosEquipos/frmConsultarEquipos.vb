Public Class frmConsultarEquipos
    Private Sub frmConsultarEquipos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarListado()
    End Sub
    Sub cargarListado()

        Me.DataGridViewX1.DataSource = EquiposClase.getListadoDisponibles(Me.buscarTextBoxX1.Text)
        If Me.DataGridViewX1.Rows.Count > 0 Then
            Me.seleccionarButtonX2.Enabled = True
        Else
            Me.seleccionarButtonX2.Enabled = False
        End If
    End Sub

    Private Sub buscarTextBoxX1_TextChanged(sender As Object, e As EventArgs) Handles buscarTextBoxX1.TextChanged
        cargarListado()
    End Sub

    Private Sub ButtonX1_Click(sender As Object, e As EventArgs) Handles ButtonX1.Click
        Me.Close()
    End Sub

    Private Sub seleccionarButtonX2_Click(sender As Object, e As EventArgs) Handles seleccionarButtonX2.Click
        frmMovimientos.idEquipoTextBoxX2.Text = Me.DataGridViewX1.CurrentRow.Cells("id_equipo").Value.ToString()

        Me.Close()
    End Sub
End Class