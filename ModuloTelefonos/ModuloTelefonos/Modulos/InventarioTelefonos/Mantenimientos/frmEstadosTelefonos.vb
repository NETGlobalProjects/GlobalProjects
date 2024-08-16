Public Class frmEstadosTelefonos
    Inherits DevComponents.DotNetBar.Office2007Form
    Dim odtsdtsInventarioTelefonos As New dtsInventarioTelefonos
    Dim estadostelefonosAdapter As New dtsInventarioTelefonosTableAdapters.estados_telefonosTableAdapter
    Dim bsEstados As New BindingSource
    Private Sub frmEstadosTelefonos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargar()
    End Sub
    Sub cargar()
        Try
            estadostelefonosAdapter.Fill(odtsdtsInventarioTelefonos.estados_telefonos)
            bsEstados.DataSource = odtsdtsInventarioTelefonos.estados_telefonos
            Me.DataGridViewX1.AutoGenerateColumns = False
            Me.DataGridViewX1.DataSource = bsEstados

            For i As Integer = 0 To Me.DataGridViewX1.Rows.Count - 1

            Next


        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub DataGridViewX1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewX1.CellContentClick

    End Sub

    Private Sub DataGridViewX1_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewX1.CellEnter
        Try
            Me.DataGridViewX1.Rows(e.RowIndex).Cells(1).Value = Trim(Me.DataGridViewX1.Rows(e.RowIndex).Cells(1).Value)
        Catch ex As Exception
        End Try

    End Sub

    Private Sub DataGridViewX1_CellLeave(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewX1.CellLeave


    End Sub

    Private Sub DataGridViewX1_CellPainting(sender As Object, e As DataGridViewCellPaintingEventArgs) Handles DataGridViewX1.CellPainting

    End Sub

    Private Sub DataGridViewX1_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles DataGridViewX1.DataBindingComplete
        'For i As Integer = 0 To Me.DataGridViewX1.Rows.Count - 1
        '    Me.DataGridViewX1.Rows(i).Cells(1).Value = Trim(Me.DataGridViewX1.Rows(i).Cells(1).Value)
        'Next

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Try
            odtsdtsInventarioTelefonos.estados_telefonos.id_estadoColumn.DefaultValue = estadostelefonosAdapter.GetNextCorrelativo()
            bsEstados.AddNew()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Try
            Me.Validate()
            bsEstados.EndEdit()
            estadostelefonosAdapter.Update(odtsdtsInventarioTelefonos.estados_telefonos)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub LinkLabel3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        Me.cargar()
    End Sub
End Class