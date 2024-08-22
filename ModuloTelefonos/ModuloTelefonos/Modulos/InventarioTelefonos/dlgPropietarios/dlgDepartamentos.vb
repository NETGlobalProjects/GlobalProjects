Public Class dlgDepartamentos
    Dim dtsDepartamentos As New dtsInventarioTelefonosTableAdapters.t_departamentosTableAdapter
    Dim bsdepartamentos As New BindingSource
    Public odtsInventarioTelefonos As New dtsInventarioTelefonos
    Private Sub dlgDepartamentos_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        'frmPropietarios.cargar_departamentos()
    End Sub
    Private Sub dlgDepartamentos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            dtsDepartamentos.Fill(odtsInventarioTelefonos.t_departamentos)
            bsdepartamentos.DataSource = odtsInventarioTelefonos.t_departamentos

            Me.DataGridViewX1.AutoGenerateColumns = False
            Me.DataGridViewX1.DataSource = bsdepartamentos

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Admin GT - Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Sub guardarcambios()
        Try
            Me.Validate()
            bsdepartamentos.EndEdit()
            dtsDepartamentos.Update(odtsInventarioTelefonos.t_departamentos)

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Admin GT - Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub DataGridViewX1_CellLeave(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewX1.CellLeave
        guardarcambios()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Try
            odtsInventarioTelefonos.t_departamentos.id_departamentoColumn.DefaultValue = dtsDepartamentos.GetNextId()
            odtsInventarioTelefonos.t_empresas.descripcionColumn.DefaultValue = ""
            bsdepartamentos.AddNew()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Admin GT - Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Try
            bsdepartamentos.RemoveCurrent()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Admin GT - Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ButtonX1_Click(sender As Object, e As EventArgs) Handles ButtonX1.Click
        'frmPropietarios.departamentoComboBoxEx2.SelectedValue = bsdepartamentos.Current("id_departamento")
        Me.Close()
    End Sub
End Class