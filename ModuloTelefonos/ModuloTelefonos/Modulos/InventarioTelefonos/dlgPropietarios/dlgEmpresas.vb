Public Class dlgEmpresas
    Dim dtsEmpresas As New dtsInventarioTelefonosTableAdapters.t_empresasTableAdapter
    Dim bsempresas As New BindingSource
    Public odtsInventarioTelefonos As New dtsInventarioTelefonos
    Private Sub dlgEmpresas_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        'frmPropietarios.cargar_empresas()
    End Sub
    Private Sub dlgEmpresas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            dtsEmpresas.Fill(odtsInventarioTelefonos.t_empresas)
            bsempresas.DataSource = odtsInventarioTelefonos.t_empresas

            Me.DataGridViewX1.AutoGenerateColumns = False
            Me.DataGridViewX1.DataSource = bsempresas
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Admin GT - Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Sub guardarcambios()
        Try
            Me.Validate()
            bsempresas.EndEdit()
            dtsEmpresas.Update(odtsInventarioTelefonos.t_empresas)

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Admin GT - Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub DataGridViewX1_CellLeave(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewX1.CellLeave
        guardarcambios()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Try
            odtsInventarioTelefonos.t_empresas.id_empresaColumn.DefaultValue = dtsEmpresas.GetNextId()
            odtsInventarioTelefonos.t_empresas.descripcionColumn.DefaultValue = ""
            bsempresas.AddNew()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Admin GT - Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Try
            bsempresas.RemoveCurrent()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Admin GT - Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ButtonX1_Click(sender As Object, e As EventArgs) Handles ButtonX1.Click
        'frmPropietarios.empresaComboBoxEx1.SelectedValue = bsempresas.Current("id_empresa")
        Me.Close()
    End Sub
End Class