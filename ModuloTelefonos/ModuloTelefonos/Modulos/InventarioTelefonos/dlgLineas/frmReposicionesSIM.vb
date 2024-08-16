Imports DevComponents.DotNetBar.Rendering
Imports DevComponents.DotNetBar
Public Class frmReposicionesSIM
    Inherits DevComponents.DotNetBar.Office2007Form
    Dim reposicionessimAdapter As New dtsInventarioTelefonosTableAdapters.reposiciones_simTableAdapter
    Dim motivosAdapter As New dtsInventarioTelefonosTableAdapters.motivos_movimientosTableAdapter

    Dim bsreposicionessim As New BindingSource
    Public numero As String
    Public odtsInventarioTelefonos As New dtsInventarioTelefonos

    Private Sub frmReposicionesSIM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarmotivos()
        cargardatos(numero)
    End Sub
    Sub cargarmotivos()
        Try
            motivosAdapter.Fill(odtsInventarioTelefonos.motivos_movimientos)
            id_motivo.DataSource = odtsInventarioTelefonos.motivos_movimientos
            id_motivo.DisplayMember = "descripcion"
            id_motivo.ValueMember = "id_motivo"
        Catch ex As Exception
            MessageBoxEx.Show(ex.Message, "Error", MessageBoxButtons.OK)
        End Try
    End Sub
    Sub cargardatos(numero As String)
        Try
            reposicionessimAdapter.Fill(odtsInventarioTelefonos.reposiciones_sim, numero)
            bsreposicionessim.DataSource = odtsInventarioTelefonos.reposiciones_sim

            Me.DataGridViewX1.AutoGenerateColumns = False
            Me.DataGridViewX1.DataSource = bsreposicionessim
        Catch ex As Exception
            MessageBoxEx.Show(ex.Message, "Error", MessageBoxButtons.OK)
        End Try
    End Sub
    Private Sub ButtonX2_Click(sender As Object, e As EventArgs) Handles ButtonX2.Click
        Me.Close()
    End Sub

    Private Sub ButtonX1_Click(sender As Object, e As EventArgs) Handles ButtonX1.Click
        Try
            Me.Validate()
            bsreposicionessim.EndEdit()
            reposicionessimAdapter.Update(odtsInventarioTelefonos.reposiciones_sim)
            odtsInventarioTelefonos.reposiciones_sim.AcceptChanges()
            frmLineas.actualizarNoReposiciones()
            Me.Close()
        Catch ex As Exception
            MessageBoxEx.Show(ex.Message, "Error", MessageBoxButtons.OK)
        End Try
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Try
            odtsInventarioTelefonos.reposiciones_sim.numeroColumn.DefaultValue = numero
            odtsInventarioTelefonos.reposiciones_sim.fechaColumn.DefaultValue = Today
            odtsInventarioTelefonos.reposiciones_sim.id_motivoColumn.DefaultValue = 0
            odtsInventarioTelefonos.reposiciones_sim.numero_de_simColumn.DefaultValue = ""
            odtsInventarioTelefonos.reposiciones_sim.reposicion_noColumn.DefaultValue = reposicionessimAdapter.GetNextCorrelativo(numero)
            bsreposicionessim.AddNew()

        Catch ex As Exception
            MessageBoxEx.Show(ex.Message, "Error", MessageBoxButtons.OK)
        End Try
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Try
            bsreposicionessim.RemoveCurrent()
        Catch ex As Exception
            MessageBoxEx.Show(ex.Message, "Error", MessageBoxButtons.OK)
        End Try
    End Sub
End Class