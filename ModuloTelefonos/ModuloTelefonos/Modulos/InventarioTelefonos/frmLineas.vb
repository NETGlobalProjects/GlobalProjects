Imports DevComponents.DotNetBar.Rendering
Imports DevComponents.DotNetBar
Public Class frmLineas
    Inherits DevComponents.DotNetBar.Office2007Form
    Dim dtsLineas As New dtsInventarioTelefonosTableAdapters.lineasTableAdapter
    Dim reposicionesAdapter As New dtsInventarioTelefonosTableAdapters.reposiciones_simTableAdapter
    Dim bslineas As New BindingSource
    Dim bsbusquedaproietarios As New BindingSource
    Public odtsInventarioTelefonos As New dtsInventarioTelefonos
    Dim ex, ey As Integer
    Dim Arrastre As Boolean
    Private Sub frmLineas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            cargarpropietarios()
            cargar_lineas(Me.TextBoxX1.Text, "")
            AddHandler bslineas.CurrentChanged, AddressOf bslineas_CurrentChanged
        Catch ex As Exception
            MessageBoxEx.Show(ex.Message, "Error - Cargar Lineas", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    Sub mostrarproximarenovacion()

        Try
            For i As Integer = 0 To Me.DataGridViewX1.RowCount - 1
                Me.DataGridViewX1.Rows(i).Cells("proxima_renovacion").Value = DateAdd(DateInterval.Month, CInt(Me.DataGridViewX1.Rows(i).Cells("duraccion_contrato_meses").Value), CDate(Me.DataGridViewX1.Rows(i).Cells("ultima_renovacion").Value))
            Next
        Catch ex As Exception
        End Try
    End Sub
    Sub cargar_lineas(numero As String, idpropietario As String)
        Try
            dtsLineas.Fill(odtsInventarioTelefonos.lineas, numero, idpropietario)
            bslineas.DataSource = odtsInventarioTelefonos.lineas

            Me.DataGridViewX1.AutoGenerateColumns = False
            Me.DataGridViewX1.DataSource = bslineas

            mostrarproximarenovacion()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Admin GT - Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Sub cargarpropietarios()
        Try
            Dim dtspropietariosNombresApellidos As New dtsInventarioTelefonosTableAdapters.propietariosNombreApellidosTableAdapter
            dtspropietariosNombresApellidos.Fill(odtsInventarioTelefonos.propietariosNombreApellidos)
            id_propietario.DataSource = odtsInventarioTelefonos.propietariosNombreApellidos
            id_propietario.DisplayMember = "nombre_completo"
            id_propietario.ValueMember = "id_propietario"

            id_propietario_actual.DataSource = odtsInventarioTelefonos.propietariosNombreApellidos
            id_propietario_actual.DisplayMember = "nombre_completo"
            id_propietario_actual.ValueMember = "id_propietario"
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Admin GT - Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Sub guardarcambios()
        Try
            Me.Validate()
            bslineas.EndEdit()
            dtsLineas.Update(odtsInventarioTelefonos.lineas)

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Admin GT - Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub TextBoxX1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBoxX1.KeyDown
        If e.KeyCode = Keys.Enter Then
            If porpropietarioCheckBoxX2.CheckState = CheckState.Checked Then
                Try
                    'cargar_lineas(Me.DataGridViewX2.CurrentRow.Cells(0).Value, "")
                    cargar_lineas("", Me.DataGridViewX2.CurrentRow.Cells(0).Value)
                    bslineas.Position = bslineas.Find("id_propietario", Me.DataGridViewX2.CurrentRow.Cells(0).Value)
                    Me.DataGridViewX2.Visible = False
                Catch ex As Exception
                End Try
            End If

        End If
        If Me.TextBoxX1.Text.Length > 0 Then
            If e.KeyCode = Keys.Up Then
                Try
                    bsbusquedaproietarios.Position -= 1
                Catch ex As Exception
                End Try
            ElseIf e.KeyCode = Keys.Down Then
                Try
                    bsbusquedaproietarios.Position += 1
                Catch ex As Exception
                End Try
            End If
        End If
    End Sub

    Private Sub DataGridViewX1_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewX1.CellEnter
        If Me.lecturaButtonX3.Checked = True Then
            Me.DataGridViewX1.Rows(e.RowIndex).Cells(e.ColumnIndex).ReadOnly = True
        Else
            Me.DataGridViewX1.Rows(e.RowIndex).Cells(e.ColumnIndex).ReadOnly = False
        End If
    End Sub
    Private Sub DataGridViewX1_CellLeave(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewX1.CellLeave
        If Me.escrituraButtonX4.Checked = True Then
            guardarcambios()
        End If

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        If Me.lecturaButtonX3.Checked = True Then
            MessageBoxEx.Show("Se encuentra en modo lectura, para agregar un registro por favor seleccione el modo escritura", "Modo", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        Else
            Try
                bslineas.AddNew()
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Admin GT - Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If


    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        If Me.lecturaButtonX3.Checked = True Then
            MessageBoxEx.Show("Se encuentra en modo lectura, para quitar un registro por favor seleccione el modo escritura", "Modo", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        Else
            Try
                bslineas.RemoveCurrent()
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Admin GT - Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If


    End Sub


    Private Sub seleccionarButtonX1_Click(sender As Object, e As EventArgs) Handles seleccionarButtonX1.Click
        frmMovimientos.numeroTextBoxX2.Text = bslineas.Current("numero")
        Me.Close()
    End Sub
    Public Sub actualizar()
        cargarpropietarios()
        cargar_lineas("", "")
    End Sub
    Private Sub ButtonX1_Click(sender As Object, e As EventArgs) Handles ButtonX1.Click
        actualizar()
    End Sub

    Private Sub TextBoxX1_TextChanged(sender As Object, e As EventArgs) Handles TextBoxX1.TextChanged
        If Me.TextBoxX1.TextLength > 0 And Me.porpropietarioCheckBoxX2.CheckState = CheckState.Checked Then
            Me.DataGridViewX2.Visible = True
            cargarbusquedaPropietarios(Me.TextBoxX1.Text)
        Else
            Me.DataGridViewX2.Visible = False
            Me.cargar_lineas(Me.TextBoxX1.Text, "")
        End If
    End Sub
    Public Sub cargarbusquedaPropietarios(buscar As String)
        Try
            Dim dtsbuscarpropietarios As New dtsInventarioTelefonosTableAdapters.BuscarPropietariosTableAdapter

            dtsbuscarpropietarios.Fill(odtsInventarioTelefonos.BuscarPropietarios, buscar)

            bsbusquedaproietarios.DataSource = odtsInventarioTelefonos.BuscarPropietarios
            Me.DataGridViewX2.AutoGenerateColumns = False
            Me.DataGridViewX2.DataSource = bsbusquedaproietarios

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Admin GT - Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub





    Private Sub ButtonX2_Click(sender As Object, e As EventArgs) Handles ButtonX2.Click
        With frmReposicionesSIM
            .WindowState = FormWindowState.Normal
            .numero = bslineas.Current("numero")
            .Text = "Reposiciones de SIM, Linea #: " & bslineas.Current("numero")
            .StartPosition = FormStartPosition.CenterScreen
            .ShowDialog()
        End With
    End Sub
    Public Sub actualizarNoReposiciones()
        Try
            Me.ButtonX2.Text = "Reposiciones de SIM (" & reposicionesAdapter.GetNumeroReposiciones(bslineas.Current("numero")) & ")"
        Catch ex As Exception
            Me.ButtonX2.Text = "Reposiciones de SIM (Error)"
        End Try
    End Sub

    Private Sub bslineas_CurrentChanged(sender As Object, e As EventArgs)
        Try
            Me.ButtonX2.Text = "Reposiciones de SIM (" & reposicionesAdapter.GetNumeroReposiciones(bslineas.Current("numero")) & ")"
        Catch ex As Exception
            Me.ButtonX2.Text = "Reposiciones de SIM (Error)"
        End Try

    End Sub

    Private Sub lecturaButtonX3_Click(sender As Object, e As EventArgs) Handles lecturaButtonX3.Click
        Me.escrituraButtonX4.Checked = False
        Me.lecturaButtonX3.Checked = True
    End Sub

    Private Sub escrituraButtonX4_Click(sender As Object, e As EventArgs) Handles escrituraButtonX4.Click
        Me.escrituraButtonX4.Checked = True
        Me.lecturaButtonX3.Checked = False
    End Sub

    Private Sub DataGridViewX1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewX1.CellContentClick

    End Sub

    Private Sub DataGridViewX1_Sorted(sender As Object, e As EventArgs) Handles DataGridViewX1.Sorted
        mostrarproximarenovacion()
    End Sub


    Private Sub DataGridViewX2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewX2.CellContentClick

    End Sub

    Private Sub DataGridViewX2_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewX2.CellContentDoubleClick
        Try
            'cargar_lineas(Me.DataGridViewX2.CurrentRow.Cells(0).Value, "")
            cargar_lineas("", Me.DataGridViewX2.CurrentRow.Cells(0).Value)
            bslineas.Position = bslineas.Find("id_propietario", Me.DataGridViewX2.CurrentRow.Cells(0).Value)
            Me.DataGridViewX2.Visible = False
        Catch ex As Exception
        End Try
    End Sub


End Class