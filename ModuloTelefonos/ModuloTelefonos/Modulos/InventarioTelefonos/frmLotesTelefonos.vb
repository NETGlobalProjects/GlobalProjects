Imports DevComponents.DotNetBar.Rendering
Imports DevComponents.DotNetBar
Imports System.Data.SqlClient
Public Class frmLotesTelefonos
    Inherits DevComponents.DotNetBar.Office2007Form

    Dim dtsLotes As New dtsInventarioTelefonosTableAdapters.lotesTableAdapter
    Dim dtsTelefonos As New dtsInventarioTelefonosTableAdapters.telefonosTableAdapter
    Dim bslotes As New BindingSource
    Dim bstelefonos As New BindingSource
    Public quienllama As String = ""
    Public odtsInventarioTelefonos As New dtsInventarioTelefonos
    Public conDtsys As New SqlConnection()

    Private Sub frmLotesTelefonos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarmarcas()
        cargarpropietarios()
        cargarestadostelefonos()
        cargarSO()
        cargar_lotes()
        cargar_telefonos("", "")
    End Sub
    Sub cargarpropietarios()
        Try
            Dim dtspropietariosNombreCompleto As New dtsInventarioTelefonosTableAdapters.propietariosNombreApellidosTableAdapter
            dtspropietariosNombreCompleto.Fill(odtsInventarioTelefonos.propietariosNombreApellidos)
            id_usuario_actual.DataSource = odtsInventarioTelefonos.propietariosNombreApellidos
            id_usuario_actual.DisplayMember = "nombre_completo"
            id_usuario_actual.ValueMember = "id_propietario"

            nombre_propietario.DataSource = odtsInventarioTelefonos.propietariosNombreApellidos
            nombre_propietario.DisplayMember = "nombre_completo"
            nombre_propietario.ValueMember = "nombre_completo"
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Admin GT - Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Sub cargarestadostelefonos()
        Try
            Dim dtsEstadosTelefonos As New dtsInventarioTelefonosTableAdapters.estados_telefonosTableAdapter
            id_estado.DataSource = dtsEstadosTelefonos.GetData
            id_estado.DisplayMember = "descripcion"
            id_estado.ValueMember = "id_estado"
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Admin GT - Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    Sub cargar_lotes()
        Try
            dtsLotes.Fill(odtsInventarioTelefonos.lotes)
            bslotes.DataSource = odtsInventarioTelefonos.lotes

            Me.DataGridViewX1.AutoGenerateColumns = False
            Me.DataGridViewX1.DataSource = bslotes


        Catch ex As Exception
            MessageBox.Show(ex.Message, "Admin GT - Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Sub cargarmarcas()
        Try
            Dim dtsmarcas As New dtsInventarioTelefonosTableAdapters.marcasTableAdapter
            id_marca.DataSource = dtsmarcas.GetData
            id_marca.ValueMember = "id_marca"
            id_marca.DisplayMember = "descripcion"
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Admin GT - Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Sub cargarSO()
        Try
            Dim dtsSO As New dtsInventarioTelefonosTableAdapters.SOTableAdapter
            id_so.DataSource = dtsSO.GetData
            id_so.ValueMember = "id_so"
            id_so.DisplayMember = "descripcion"
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Admin GT - Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Sub guardarcambios_lotes()
        Try
            Me.Validate()
            bslotes.EndEdit()
            dtsLotes.Update(odtsInventarioTelefonos.lotes)

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Admin GT - Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Sub guardarcambios_telefonos()

        Try
            Me.Validate()
            bstelefonos.EndEdit()
            dtsTelefonos.Update(odtsInventarioTelefonos.telefonos)

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Admin GT - Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Sub cargar_telefonos(imei As String, lote As String)
        Try
            dtsTelefonos.Fill(odtsInventarioTelefonos.telefonos, imei, lote)

            bstelefonos.DataSource = odtsInventarioTelefonos.telefonos

            Me.DataGridViewX2.AutoGenerateColumns = False
            Me.DataGridViewX2.DataSource = bstelefonos

            totalizar()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Admin GT - Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub DataGridViewX1_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewX1.CellEnter
        cargar_telefonos("", bslotes.Current("lote"))
        If lecturaButtonX3.Checked = True Then
            Me.DataGridViewX1.Rows(e.RowIndex).Cells(e.ColumnIndex).ReadOnly = True
        Else
            Me.DataGridViewX1.Rows(e.RowIndex).Cells(e.ColumnIndex).ReadOnly = False
        End If
    End Sub



    Private Sub DataGridViewX1_CellLeave(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewX1.CellLeave
        If Me.escrituraButtonX4.Checked = True Then
            guardarcambios_lotes()
        End If

    End Sub

    Private Sub DataGridViewX2_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewX2.CellEnter
        Try
            Me.notasTextBoxX2.Text = Me.DataGridViewX2.Rows(e.RowIndex).Cells(15).Value
        Catch ex As Exception
            Me.notasTextBoxX2.Text = ""
        End Try
        If lecturaButtonX3.Checked = True Then
            Me.DataGridViewX2.Rows(e.RowIndex).Cells(e.ColumnIndex).ReadOnly = True
        Else
            Me.DataGridViewX2.Rows(e.RowIndex).Cells(e.ColumnIndex).ReadOnly = False
        End If
    End Sub



    Private Sub DataGridViewX2_CellLeave(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewX2.CellLeave
        If Me.escrituraButtonX4.Checked = True Then
            guardarcambios_telefonos()
        End If

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        If Me.lecturaButtonX3.Checked = True Then
            MessageBoxEx.Show("Se encuentra en modo lectura, para agregar un registro por favor seleccione el modo escritura", "Modo", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        Else

            Try
                odtsInventarioTelefonos.lotes.fechaColumn.DefaultValue = Today
                odtsInventarioTelefonos.lotes.cantidadColumn.DefaultValue = 0
                odtsInventarioTelefonos.lotes.costoColumn.DefaultValue = 0
                bslotes.AddNew()
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
                bslotes.RemoveCurrent()
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Admin GT - Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If

    End Sub
    Sub totalizar()
        Me.totalLabelX3.Text = bstelefonos.Count
    End Sub
    Private Sub LinkLabel4_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel4.LinkClicked
        If Me.lecturaButtonX3.Checked = True Then
            MessageBoxEx.Show("Se encuentra en modo lectura, para agregar un registro por favor seleccione el modo escritura", "Modo", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        Else
            Try
                odtsInventarioTelefonos.telefonos.id_marcaColumn.DefaultValue = 0
                odtsInventarioTelefonos.telefonos.id_soColumn.DefaultValue = 0
                odtsInventarioTelefonos.telefonos.id_usuario_actualColumn.DefaultValue = 0
                odtsInventarioTelefonos.telefonos.numero_linea_actualColumn.DefaultValue = 0
                odtsInventarioTelefonos.telefonos.fecha_ingresoColumn.DefaultValue = Format(bslotes.Current("fecha"), "dd/MM/yyyy")
                odtsInventarioTelefonos.telefonos.loteColumn.DefaultValue = bslotes.Current("lote")
                bstelefonos.AddNew()
                totalizar()

            Catch ex As Exception
                MessageBox.Show(ex.Message, "Admin GT - Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If

    End Sub

    Private Sub LinkLabel3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        If Me.lecturaButtonX3.Checked = True Then
            MessageBoxEx.Show("Se encuentra en modo lectura, para quitar un registro por favor seleccione el modo escritura", "Modo", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        Else
            Try
                Dim resp As MsgBoxResult = MessageBoxEx.Show("Realmente desea eliminar por completo el registro de telefono con imei: " & RTrim(bstelefonos.Current("imei")), "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
                If resp = MsgBoxResult.Yes Then
                    bstelefonos.RemoveCurrent()
                    guardarcambios_telefonos()
                    cargar_telefonos("", bslotes.Current("lote"))
                    totalizar()

                End If

            Catch ex As Exception
                MessageBox.Show(ex.Message, "Admin GT - Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If


    End Sub

    Private Sub TextBoxX1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBoxX1.KeyDown
        cargar_telefonos(Me.TextBoxX1.Text, "")
    End Sub



    Private Sub seleccionarButtonX2_Click(sender As Object, e As EventArgs) Handles seleccionarButtonX2.Click
        If quienllama = "movimientos" Then
            frmMovimientos.imeiTextBoxX3.Text = bstelefonos.Current("imei")
            Me.Close()
        ElseIf quienllama = "descuentos" Then
            dlgDescuentosxReposicion.imeiTextBoxX1.Text = bstelefonos.Current("imei")
            Me.Close()
        End If

    End Sub

    Private Sub DataGridViewX1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewX1.CellContentClick

    End Sub
    Public Sub actualizar()
        cargarmarcas()
        cargarpropietarios()
        cargarestadostelefonos()
        cargarSO()
        cargar_lotes()
        cargar_telefonos("", "")
    End Sub
    Private Sub ButtonX2_Click(sender As Object, e As EventArgs) Handles ButtonX2.Click
        actualizar()
    End Sub
    Private Sub DataGridViewX2_RowPrePaint(sender As Object, e As DataGridViewRowPrePaintEventArgs) Handles DataGridViewX2.RowPrePaint
        If Me.DataGridViewX2.Rows(e.RowIndex).Cells("id_estado").Value = 5 Then
            ' Me.DataGridViewX2.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.Green
            Me.DataGridViewX2.Rows(e.RowIndex).DefaultCellStyle.ForeColor = Color.Green
        ElseIf Me.DataGridViewX2.Rows(e.RowIndex).Cells("id_estado").Value = 1 Then
            Me.DataGridViewX2.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.White
            Me.DataGridViewX2.Rows(e.RowIndex).DefaultCellStyle.ForeColor = Color.Black
        Else
            'Me.DataGridViewX2.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.RED
            Me.DataGridViewX2.Rows(e.RowIndex).DefaultCellStyle.ForeColor = Color.Red
        End If
    End Sub

    Private Sub DataGridViewX2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewX2.CellContentClick

    End Sub

    Private Sub ButtonX4_Click(sender As Object, e As EventArgs) Handles escrituraButtonX4.Click
        Me.escrituraButtonX4.Checked = True
        Me.lecturaButtonX3.Checked = False
    End Sub

    Private Sub lecturaButtonX3_Click(sender As Object, e As EventArgs) Handles lecturaButtonX3.Click
        Me.escrituraButtonX4.Checked = False
        Me.lecturaButtonX3.Checked = True
    End Sub
End Class