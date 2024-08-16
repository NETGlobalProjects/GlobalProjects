Public Class dlgCargos
    Dim dtsCargos As New dtsInventarioTelefonosTableAdapters.cargosTableAdapter
    Dim bscargos As New BindingSource
    Public odtsInventarioTelefonos As New dtsInventarioTelefonos
    Private Sub dlgCargos_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        frmPropietarios.cargar_cargos()
    End Sub
    Private Sub dlgCargos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            dtsCargos.Fill(odtsInventarioTelefonos.cargos)
            bscargos.DataSource = odtsInventarioTelefonos.cargos

            Me.DataGridViewX1.AutoGenerateColumns = False
            Me.DataGridViewX1.DataSource = bscargos

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Admin GT - Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Sub guardarcambios()
        Try
            Me.Validate()
            bscargos.EndEdit()
            dtsCargos.Update(odtsInventarioTelefonos.cargos)

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Admin GT - Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub DataGridViewX1_CellLeave(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewX1.CellLeave
        guardarcambios()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Try
            odtsInventarioTelefonos.cargos.id_cargoColumn.DefaultValue = dtsCargos.GetNextId()
            odtsInventarioTelefonos.cargos.descripcionColumn.DefaultValue = ""
            bscargos.AddNew()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Admin GT - Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Try
            bscargos.RemoveCurrent()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Admin GT - Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ButtonX1_Click(sender As Object, e As EventArgs) Handles ButtonX1.Click
        frmPropietarios.cargoComboBoxEx3.SelectedValue = bscargos.Current("id_Cargo")
        Me.Close()
    End Sub
End Class