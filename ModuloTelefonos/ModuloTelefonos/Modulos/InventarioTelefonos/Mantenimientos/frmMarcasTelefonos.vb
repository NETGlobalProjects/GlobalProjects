Public Class frmMarcasTelefonos
    Inherits DevComponents.DotNetBar.Office2007Form
    Dim odtsInventario As New dtsInventarioTelefonos
    Dim marcaasAdapter As New dtsInventarioTelefonosTableAdapters.marcasTableAdapter
    Dim bsMarcas As New BindingSource
    Private Sub frmMarcasTelefonos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargar()
    End Sub
    Sub cargar()
        Try
            marcaasAdapter.Fill(odtsInventario.marcas)
            Me.DataGridViewX1.AutoGenerateColumns = False
            bsMarcas.DataSource = odtsInventario.marcas
            Me.DataGridViewX1.DataSource = bsMarcas


        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.InnerException.ToString, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub LinkLabel3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        cargar()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Try
            odtsInventario.marcas.id_marcaColumn.DefaultValue = marcaasAdapter.GetNextCorrelativo
            bsMarcas.AddNew()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.InnerException.ToString, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Try
            Me.Validate()
            odtsInventario.marcas.AcceptChanges()
            bsMarcas.EndEdit()
            marcaasAdapter.Update(odtsInventario.marcas)

        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.InnerException.ToString, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class