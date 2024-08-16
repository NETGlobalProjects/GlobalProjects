Public Class frmMotivosTelefonos
    Inherits DevComponents.DotNetBar.Office2007Form
    Dim odtsInventarioTelefonos As New dtsInventarioTelefonos
    Dim motivosAdapter As New dtsInventarioTelefonosTableAdapters.motivos_movimientosTableAdapter
    Dim bsMotivos As New BindingSource
    Private Sub frmMotivosTelefonos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargar()
    End Sub
    Sub cargar()
        'Try
        motivosAdapter.Fill(odtsInventarioTelefonos.motivos_movimientos)
        bsMotivos.DataSource = odtsInventarioTelefonos.motivos_movimientos

        Me.DataGridViewX1.AutoGenerateColumns = False
        Me.DataGridViewX1.DataSource = bsMotivos
        'Catch ex As Exception
        '    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'End Try
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Try
            Me.Validate()
            bsMotivos.EndEdit()
            motivosAdapter.Update(odtsInventarioTelefonos.motivos_movimientos)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub LinkLabel3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        cargar()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Try
            odtsInventarioTelefonos.motivos_movimientos.id_motivoColumn.DefaultValue = motivosAdapter.GetNextCorrelativo()
            bsMotivos.AddNew()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class