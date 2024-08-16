Imports DevComponents.DotNetBar.Rendering
Imports DevComponents.DotNetBar
Public Class frmMovimientos
    Inherits DevComponents.DotNetBar.Office2007Form
    Dim dtsMovimientos As New dtsInventarioTelefonosTableAdapters.movimientos_lineas_telefonosTableAdapter
    Dim dtsMotivosMovimientos As New dtsInventarioTelefonosTableAdapters.motivos_movimientosTableAdapter
    Dim dtsTiposMovimientos As New dtsInventarioTelefonosTableAdapters.tipos_movimientosTableAdapter
    Dim dtsestados As New dtsInventarioTelefonosTableAdapters.estadosTableAdapter
    Dim dtspropietarios As New dtsInventarioTelefonosTableAdapters.propietariosTableAdapter
    Dim dtstelefonosMarcas As New dtsInventarioTelefonosTableAdapters.telefonosMarcasTableAdapter
    Dim dtsTelefonos As New dtsInventarioTelefonosTableAdapters.telefonosTableAdapter
    Dim dtsLineas As New dtsInventarioTelefonosTableAdapters.lineasTableAdapter
    Dim dtsBuscarLineas As New dtsInventarioTelefonosTableAdapters.buscarNumerosTableAdapter
    Dim dtsBuscarTelefonos As New dtsInventarioTelefonosTableAdapters.buscartelefonosTableAdapter

    Dim bsMovimientos As New BindingSource
    Dim bsBuscarPropietarios As New BindingSource
    Dim bsLineas As New BindingSource
    Dim bsBuscarTelefonos As New BindingSource
    Public odtsInventarioTelefonos As New dtsInventarioTelefonos

    Private Sub frmMovimientos_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If Me.nuevoButtonX1.Text = "&Cancelar" Then
            Dim resp As MsgBoxResult = MessageBoxEx.Show("Se encuentra en modo creación si cierra este formulario no se guardara el registro" & vbCrLf & vbCrLf & "¿Desea cerrar la ventana de todas formas?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If resp = MsgBoxResult.Yes Then
                nuevoButtonX1_Click(sender, e)
                Me.Close()
            Else
                e.Cancel = True
            End If
        ElseIf Me.modificarButtonX2.Text = "&Cancelar" Then
            Dim resp As MsgBoxResult = MessageBoxEx.Show("Se encuentra en modo modificación si cierra este formulario no se guardaran los cambios" & vbCrLf & vbCrLf & "¿Desea cerrar la ventana de todas formas?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If resp = MsgBoxResult.Yes Then
                modificarButtonX2_Click(sender, e)
                Me.Close()
            Else
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub frmMovimientos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            cargarestados()
            cargarmotivos()
            cargarpropietarios()
            cargartiposmovientos()
            cargarmovimientos("", "")
        Catch ex As Exception
            MessageBoxEx.Show(ex.Message, "Error - Cargar Movimientos", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Sub habilitar()
        Me.numeroTextBoxX2.Enabled = True
        Me.imeiTextBoxX3.Enabled = True
        Me.fechaTextBoxX4.Enabled = True
        Me.justificanteTextBoxX6.Enabled = True
        Me.id_propietarioTextBoxX5.Enabled = True
        Me.motivoComboBoxEx2.Enabled = True
        Me.tipomovimientoComboBoxEx1.Enabled = True
        Me.estadoComboBoxEx3.Enabled = True
        Me.DataGridViewX1.Enabled = False
    End Sub
    Sub deshabilitar()
        Me.numeroTextBoxX2.Enabled = False
        Me.imeiTextBoxX3.Enabled = False
        Me.fechaTextBoxX4.Enabled = False
        Me.justificanteTextBoxX6.Enabled = False
        Me.id_propietarioTextBoxX5.Enabled = False
        Me.motivoComboBoxEx2.Enabled = False
        Me.tipomovimientoComboBoxEx1.Enabled = False
        Me.estadoComboBoxEx3.Enabled = False
        Me.DataGridViewX1.Enabled = True
    End Sub
    Sub cargarmovimientos(id_propietario As String, buscar As String)
        Try
            dtsMovimientos.Fill(odtsInventarioTelefonos.movimientos_lineas_telefonos, id_propietario, buscar)
            bsMovimientos.DataSource = odtsInventarioTelefonos.movimientos_lineas_telefonos

            Me.DataGridViewX1.AutoGenerateColumns = False
            Me.DataGridViewX1.DataSource = bsMovimientos


            Me.noMovimientoTextBoxX1.DataBindings.Clear()
            Me.tipomovimientoComboBoxEx1.DataBindings.Clear()
            Me.numeroTextBoxX2.DataBindings.Clear()
            Me.imeiTextBoxX3.DataBindings.Clear()
            Me.fechaTextBoxX4.DataBindings.Clear()
            Me.motivoComboBoxEx2.DataBindings.Clear()
            Me.id_propietarioTextBoxX5.DataBindings.Clear()
            Me.estadoComboBoxEx3.DataBindings.Clear()
            Me.justificanteTextBoxX6.DataBindings.Clear()
            Me.idEquipoTextBoxX2.DataBindings.Clear()

            Me.noMovimientoTextBoxX1.DataBindings.Add("text", bsMovimientos, "no_movimiento", True, DataSourceUpdateMode.OnPropertyChanged)
            Me.tipomovimientoComboBoxEx1.DataBindings.Add("selectedvalue", bsMovimientos, "id_tipo_movimiento", True, DataSourceUpdateMode.OnPropertyChanged)
            Me.numeroTextBoxX2.DataBindings.Add("text", bsMovimientos, "numero", True, DataSourceUpdateMode.OnPropertyChanged)
            Me.imeiTextBoxX3.DataBindings.Add("text", bsMovimientos, "imei", True, DataSourceUpdateMode.OnPropertyChanged)
            Me.fechaTextBoxX4.DataBindings.Add("text", bsMovimientos, "fecha", True, DataSourceUpdateMode.OnPropertyChanged)
            Me.motivoComboBoxEx2.DataBindings.Add("selectedvalue", bsMovimientos, "id_motivo", True, DataSourceUpdateMode.OnPropertyChanged)
            Me.id_propietarioTextBoxX5.DataBindings.Add("text", bsMovimientos, "id_propietario", True, DataSourceUpdateMode.OnPropertyChanged)
            Me.estadoComboBoxEx3.DataBindings.Add("selectedvalue", bsMovimientos, "id_estado", True, DataSourceUpdateMode.OnPropertyChanged)
            Me.justificanteTextBoxX6.DataBindings.Add("text", bsMovimientos, "justificante", True, DataSourceUpdateMode.OnPropertyChanged)
            Me.idEquipoTextBoxX2.DataBindings.Add("text", bsMovimientos, "id_equipo", True, DataSourceUpdateMode.OnPropertyChanged)

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Admin GT - Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Sub cargarpropietarios()
        Try

            Dim dtsPropietariosNombreCompleto As New dtsInventarioTelefonosTableAdapters.propietariosNombreApellidosTableAdapter
            dtsPropietariosNombreCompleto.Fill(odtsInventarioTelefonos.propietariosNombreApellidos)
            id_propietario.DataSource = odtsInventarioTelefonos.propietariosNombreApellidos
            id_propietario.DisplayMember = "nombre_completo"
            id_propietario.ValueMember = "id_propietario"

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Admin GT - Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Sub cargarmotivos()
        Try
            id_motivo.DataSource = dtsMotivosMovimientos.GetData
            id_motivo.DisplayMember = "descripcion"
            id_motivo.ValueMember = "id_motivo"

            Me.motivoComboBoxEx2.DataSource = dtsMotivosMovimientos.GetData
            motivoComboBoxEx2.DisplayMember = "descripcion"
            motivoComboBoxEx2.ValueMember = "id_motivo"
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Admin GT - Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Sub cargarestados()
        Try
            id_estado.DataSource = dtsestados.GetData
            id_estado.DisplayMember = "descripcion"
            id_estado.ValueMember = "id_estado"

            Me.estadoComboBoxEx3.DataSource = dtsestados.GetData
            Me.estadoComboBoxEx3.DisplayMember = "descripcion"
            Me.estadoComboBoxEx3.ValueMember = "id_estado"
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Admin GT - Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Sub cargartiposmovientos()
        Try
            id_tipo_movimiento.DataSource = dtsTiposMovimientos.GetData
            id_tipo_movimiento.DisplayMember = "descripcion"
            id_tipo_movimiento.ValueMember = "id_tipo_movimiento"

            Me.tipomovimientoComboBoxEx1.DataSource = dtsTiposMovimientos.GetData
            tipomovimientoComboBoxEx1.DisplayMember = "descripcion"
            tipomovimientoComboBoxEx1.ValueMember = "id_tipo_movimiento"
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Admin GT - Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub id_propietarioTextBoxX5_KeyDown(sender As Object, e As KeyEventArgs) Handles id_propietarioTextBoxX5.KeyDown
        If e.KeyCode = Keys.F5 Then
            With frmPropietarios
                .seleccionarButtonX4.Visible = True
                .WindowState = FormWindowState.Normal
                .StartPosition = FormStartPosition.CenterScreen
                .ShowDialog()
            End With
        End If
    End Sub

    Private Sub id_propietarioTextBoxX5_TextChanged(sender As Object, e As EventArgs) Handles id_propietarioTextBoxX5.TextChanged
        Try
            Me.nombrecompletoTextBoxX1.Text = dtspropietarios.GetNombreCompleto(Me.id_propietarioTextBoxX5.Text)
        Catch ex As Exception

        End Try

    End Sub
    Sub guardarcambios()
        Try
            Me.Validate()
            bsMovimientos.EndEdit()
            dtsMovimientos.Update(odtsInventarioTelefonos.movimientos_lineas_telefonos)

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Admin GT - Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub eliminarButtonX3_Click(sender As Object, e As EventArgs) Handles eliminarButtonX3.Click
        Try
            Dim resp As MsgBoxResult = MessageBoxEx.Show("Realmente desea eliminar por completo el no de movimiento: " & Me.noMovimientoTextBoxX1.Text, "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
            If resp = MsgBoxResult.Yes Then
                bsMovimientos.RemoveCurrent()
                guardarcambios()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Admin GT - Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub nuevoButtonX1_Click(sender As Object, e As EventArgs) Handles nuevoButtonX1.Click
        If Me.nuevoButtonX1.Text = "&Nuevo" Then
            Me.nuevoButtonX1.Text = "&Cancelar"
            habilitar()
            Me.modificarButtonX2.Enabled = False
            Me.eliminarButtonX3.Enabled = False
            Me.imprimirButtonX5.Enabled = False
            Me.guardarButtonX4.Enabled = True
            odtsInventarioTelefonos.movimientos_lineas_telefonos.fechaColumn.DefaultValue = Today
            odtsInventarioTelefonos.movimientos_lineas_telefonos.justificanteColumn.DefaultValue = ""
            bsMovimientos.AddNew()
            Me.tipomovimientoComboBoxEx1.Focus()
        ElseIf nuevoButtonX1.Text = "&Cancelar" Then
            Me.nuevoButtonX1.Text = "&Nuevo"
            deshabilitar()
            Me.modificarButtonX2.Enabled = True
            Me.eliminarButtonX3.Enabled = True
            Me.imprimirButtonX5.Enabled = True
            Me.guardarButtonX4.Enabled = False
            bsMovimientos.RemoveCurrent()
            bsMovimientos.CancelEdit()
        End If
    End Sub
    Private Sub guardarButtonX4_Click(sender As Object, e As EventArgs) Handles guardarButtonX4.Click
        If nuevoButtonX1.Text = "&Cancelar" Then
            If Me.id_propietarioTextBoxX5.Text = "" Or Me.id_propietarioTextBoxX5.Text = "0" Then
                MessageBoxEx.Show("No ha ingresado el propietario al que se le registrara el moviemiento", "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf Me.tipomovimientoComboBoxEx1.SelectedValue = 3 And Me.idEquipoTextBoxX2.Text = "" Then
                MessageBoxEx.Show("Debe ingresar el id del equipo a que se esta efectuando el movimiento", "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                bsMovimientos.Current("no_movimiento") = dtsMovimientos.GetNextId
                bsMovimientos.Current("realizado_por") = UsuarioActual
                guardarcambios()
                If Me.tipomovimientoComboBoxEx1.SelectedValue = 1 Then '<--- Telefono
                    dtsTelefonos.Update_UsuarioActual(bsMovimientos.Current("id_propietario"), bsMovimientos.Current("imei"))
                    dtspropietarios.UpdateIMEIActual(bsMovimientos.Current("imei"), bsMovimientos.Current("id_propietario"))
                    dtsLineas.UpdateImeiActual(bsMovimientos.Current("imei"), dtspropietarios.GetNumeroActual(bsMovimientos.Current("id_propietario")))

                    If Me.motivoComboBoxEx2.SelectedValue = 1 Or Me.motivoComboBoxEx2.SelectedValue = 2 Or Me.motivoComboBoxEx2.SelectedValue = 3 Or Me.motivoComboBoxEx2.SelectedValue = 4 Or Me.motivoComboBoxEx2.SelectedValue = 5 Or Me.motivoComboBoxEx2.SelectedValue = 10 Then
                        dtsTelefonos.UpdateIdEstadoTelefono(5, bsMovimientos.Current("imei"))
                    ElseIf Me.motivoComboBoxEx2.SelectedValue = 6 Then
                        dtsTelefonos.UpdateIdEstadoTelefono(1, bsMovimientos.Current("imei"))
                        dtspropietarios.UpdateIMEIActual("", bsMovimientos.Current("id_propietario"))
                        dtsLineas.UpdateImeiActual("", dtspropietarios.GetNumeroActual(bsMovimientos.Current("id_propietario")))
                        dtsTelefonos.Update_UsuarioActual(0, bsMovimientos.Current("imei"))
                    ElseIf Me.motivoComboBoxEx2.SelectedValue = 7 Then
                        dtsTelefonos.UpdateIdEstadoTelefono(4, bsMovimientos.Current("imei"))
                        dtspropietarios.UpdateIMEIActual("", bsMovimientos.Current("id_propietario"))
                        dtsLineas.UpdateImeiActual("", dtspropietarios.GetNumeroActual(bsMovimientos.Current("id_propietario")))
                        dtsTelefonos.Update_UsuarioActual(0, bsMovimientos.Current("imei"))
                    ElseIf Me.motivoComboBoxEx2.SelectedValue = 8 Then
                        dtsTelefonos.UpdateIdEstadoTelefono(2, bsMovimientos.Current("imei"))
                        dtspropietarios.UpdateIMEIActual("", bsMovimientos.Current("id_propietario"))
                        dtsLineas.UpdateImeiActual("", dtspropietarios.GetNumeroActual(bsMovimientos.Current("id_propietario")))
                        dtsTelefonos.Update_UsuarioActual(0, bsMovimientos.Current("imei"))
                    ElseIf Me.motivoComboBoxEx2.SelectedValue = 9 Then
                        dtsTelefonos.UpdateIdEstadoTelefono(3, bsMovimientos.Current("imei"))
                        dtspropietarios.UpdateIMEIActual("", bsMovimientos.Current("id_propietario"))
                        dtsLineas.UpdateImeiActual("", dtspropietarios.GetNumeroActual(bsMovimientos.Current("id_propietario")))
                        dtsTelefonos.Update_UsuarioActual(0, bsMovimientos.Current("imei"))
                    End If

                ElseIf tipomovimientoComboBoxEx1.SelectedValue = 2 Then '<----- Linea
                    dtsLineas.UpdatePropActual(bsMovimientos.Current("id_propietario"), bsMovimientos.Current("numero"))
                    dtspropietarios.UpdateNumeroActual(bsMovimientos.Current("numero"), bsMovimientos.Current("id_propietario"))
                    dtsTelefonos.UpdateLineaActual(bsMovimientos.Current("numero"), dtspropietarios.GetImeiActual(bsMovimientos.Current("id_propietario")))
                End If

                Me.nuevoButtonX1.Text = "&Nuevo"
                deshabilitar()
                Me.modificarButtonX2.Enabled = True
                Me.eliminarButtonX3.Enabled = True
                Me.imprimirButtonX5.Enabled = True
                Me.guardarButtonX4.Enabled = False
            End If

        ElseIf Me.modificarButtonX2.Text = "&Cancelar" Then
            guardarcambios()

            Me.modificarButtonX2.Text = "&Modificar"
            deshabilitar()

            Me.nuevoButtonX1.Enabled = True
            Me.eliminarButtonX3.Enabled = True
            Me.imprimirButtonX5.Enabled = True
            Me.guardarButtonX4.Enabled = False
        End If
    End Sub
    Sub quitarespacios()
        Me.numeroTextBoxX2.Text.TrimEnd()
        Me.imeiTextBoxX3.Text.TrimEnd()
        Me.justificanteTextBoxX6.Text.TrimEnd()
        Me.id_propietarioTextBoxX5.Text.TrimEnd()
    End Sub
    Private Sub modificarButtonX2_Click(sender As Object, e As EventArgs) Handles modificarButtonX2.Click
        If Me.modificarButtonX2.Text = "&Modificar" Then
            Me.modificarButtonX2.Text = "&Cancelar"
            habilitar()
            quitarespacios()
            Me.nuevoButtonX1.Enabled = False
            Me.eliminarButtonX3.Enabled = False
            Me.imprimirButtonX5.Enabled = False
            Me.guardarButtonX4.Enabled = True
        ElseIf Me.modificarButtonX2.Text = "&Cancelar" Then
            bsMovimientos.CancelEdit()
            Me.modificarButtonX2.Text = "&Modificar"
            deshabilitar()

            Me.nuevoButtonX1.Enabled = True
            Me.eliminarButtonX3.Enabled = True
            Me.imprimirButtonX5.Enabled = True
            Me.guardarButtonX4.Enabled = False
        End If
    End Sub

    Private Sub numeroTextBoxX2_GotFocus(sender As Object, e As EventArgs) Handles numeroTextBoxX2.GotFocus
        Me.numeroTextBoxX2.SelectAll()
    End Sub
    Private Sub numeroTextBoxX2_KeyDown(sender As Object, e As KeyEventArgs) Handles numeroTextBoxX2.KeyDown
        If e.KeyCode = Keys.Escape Then
            panelNumerosGroupPanel1.Visible = False
        End If
        If e.KeyCode = Keys.F5 Then
            With frmLineas
                .seleccionarButtonX1.Visible = True
                .WindowState = FormWindowState.Normal
                .StartPosition = FormStartPosition.CenterScreen
                .TextBoxX1.Focus()
                .ShowDialog()
            End With
        End If

        If Me.numeroTextBoxX2.TextLength > 0 And numeroTextBoxX2.Focused = True Then
            If e.KeyCode = Keys.Up Then
                Try
                    bsLineas.Position -= 1
                Catch ex As Exception
                End Try
            ElseIf e.KeyCode = Keys.Down Then
                Try
                    bsLineas.Position += 1
                Catch ex As Exception
                End Try
            End If
        End If
        If e.KeyCode = Keys.Enter Then
            If Me.panelNumerosGroupPanel1.Visible = True Then
                Me.numeroTextBoxX2.Text = bsLineas.Current("numero")
                Me.id_propietarioTextBoxX5.Text = bsLineas.Current("id_propietario")
                Me.panelNumerosGroupPanel1.Visible = False
                Me.numeroTextBoxX2.SelectionStart = 9
            End If

        End If
    End Sub
    Private Sub imeiTextBoxX3_KeyDown(sender As Object, e As KeyEventArgs) Handles imeiTextBoxX3.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.paneltelefonosGroupPanel1.Visible = True
        End If
        If e.KeyCode = Keys.F5 Then
            With frmLotesTelefonos
                .quienllama = "movimientos"
                .seleccionarButtonX2.Visible = True
                .WindowState = FormWindowState.Normal
                .StartPosition = FormStartPosition.CenterScreen
                .TextBoxX1.Focus()
                .ShowDialog()
            End With
        End If
        If RTrim(imeiTextBoxX3.Text) <> "" And imeiTextBoxX3.Focused = True Then
            If e.KeyCode = Keys.Up Then
                Try
                    bsBuscarTelefonos.Position -= 1
                Catch ex As Exception
                End Try
            ElseIf e.KeyCode = Keys.Down Then
                Try
                    bsBuscarTelefonos.Position += 1
                Catch ex As Exception
                End Try
            End If
        End If
        If e.KeyCode = Keys.Enter Then
            If Me.paneltelefonosGroupPanel1.Visible = True Then
                Me.imeiTextBoxX3.Text = bsBuscarTelefonos.Current("imei")
                imeiTextBoxX3.SelectAll()
                Me.paneltelefonosGroupPanel1.Visible = False
            End If
        End If
    End Sub
    Private Sub imeiTextBoxX3_LostFocus(sender As Object, e As EventArgs) Handles imeiTextBoxX3.LostFocus
        If Me.tipomovimientoComboBoxEx1.SelectedValue = 1 Then
            If Me.nuevoButtonX1.Text = "&Cancelar" Then
                'Me.id_propietarioTextBoxX5.Text = dtsTelefonos.GetIdUsuarioActual(Me.imeiTextBoxX3.Text)
            End If

        End If
    End Sub
    Private Sub imeiTextBoxX3_TextChanged(sender As Object, e As EventArgs) Handles imeiTextBoxX3.TextChanged
        Me.marcaTextBoxX1.Text = dtstelefonosMarcas.GetMarcaTelefono(RTrim(imeiTextBoxX3.Text))
        Me.modeloTextBoxX2.Text = dtstelefonosMarcas.GetModeloTelefono(RTrim(imeiTextBoxX3.Text))

        If RTrim(Me.imeiTextBoxX3.Text) <> "" And Me.imeiTextBoxX3.Focused = True Then
            Me.paneltelefonosGroupPanel1.Visible = True
            Me.paneltelefonosGroupPanel1.Size = New Size(894, 143)
            cargarbusquedaTelefonos(Me.imeiTextBoxX3.Text)
        Else
            Me.paneltelefonosGroupPanel1.Visible = False
        End If
    End Sub

    Private Sub tipomovimientoComboBoxEx1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tipomovimientoComboBoxEx1.SelectedIndexChanged
        Try
            If Me.tipomovimientoComboBoxEx1.SelectedValue = 1 And Me.guardarButtonX4.Enabled = True Then
                Me.imeiTextBoxX3.Enabled = True
                Me.numeroTextBoxX2.Enabled = False
                Me.idEquipoTextBoxX2.Enabled = False
            ElseIf Me.tipomovimientoComboBoxEx1.SelectedValue = 2 And Me.guardarButtonX4.Enabled = True Then
                Me.imeiTextBoxX3.Enabled = False
                Me.numeroTextBoxX2.Enabled = True
                Me.idEquipoTextBoxX2.Enabled = False
            ElseIf Me.tipomovimientoComboBoxEx1.SelectedValue = 3 And Me.guardarButtonX4.Enabled = True Then
                Me.imeiTextBoxX3.Enabled = False
                Me.numeroTextBoxX2.Enabled = False
                Me.idEquipoTextBoxX2.Enabled = True
            End If
        Catch ex As Exception

        End Try

    End Sub
    Public Sub Actualizar()
        cargarestados()
        cargarmotivos()
        cargarpropietarios()
        cargartiposmovientos()
        cargarmovimientos("", "")
    End Sub
    Private Sub ButtonX1_Click(sender As Object, e As EventArgs) Handles ButtonX1.Click
        Actualizar()
    End Sub

    Private Sub imprimirButtonX5_Click(sender As Object, e As EventArgs) Handles imprimirButtonX5.Click
        Me.Cursor = Cursors.WaitCursor
        'Dim rptfichas As New rptFicha
        'Dim dtsFichas As New dtsInventarioTelefonosTableAdapters.FichasTableAdapter
        'dtsFichas.Fill(odtsInventarioTelefonos.Fichas, bsMovimientos.Current("no_movimiento"))

        'rptfichas.SetParameterValue("realizadopor", RTrim(UsuarioActual))
        'rptfichas.SetDataSource(odtsInventarioTelefonos.Tables("Fichas"))
        'rptfichas.Refresh()
        'Dim frmvistaprevia As New frmVista_Previa_Rpts
        'With frmvistaprevia
        '    .CrystalReportViewer1.ReportSource = rptfichas
        '    .WindowState = FormWindowState.Maximized
        '    .Show()
        'End With


        Dim rpt As New xRptFicha

        Dim dtsFichas As New dtsInventarioTelefonosTableAdapters.FichasTableAdapter
        rpt.Report.DataSource = dtsFichas.GetData(Convert.ToInt32(bsMovimientos.Current("no_movimiento")))
        rpt.Report.DataMember = "Fichas"

        Dim frmvisor As New xFrmVisorDocumentos
        frmvisor.WindowState = FormWindowState.Maximized
        frmvisor.DocumentViewer1.DocumentSource = rpt
        frmvisor.DocumentViewer1.InitiateDocumentCreation()
        frmvisor.Show()

        Me.Cursor = Cursors.Arrow

    End Sub

    Private Sub numeroTextBoxX2_TextChanged(sender As Object, e As EventArgs) Handles numeroTextBoxX2.TextChanged
        If RTrim(numeroTextBoxX2.Text) <> "" And numeroTextBoxX2.Focused = True Then
            panelNumerosGroupPanel1.Visible = True
            panelNumerosGroupPanel1.Size = New Size(636, 134)
            cargarbusquedanumeros(Me.numeroTextBoxX2.Text)
        Else
            panelNumerosGroupPanel1.Visible = False
        End If
    End Sub

    Private Sub TextBoxX1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBoxX1.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.panelPropietariosGroupPanel2.Visible = False
        End If
        If e.KeyCode = Keys.Enter Then
            If Me.TextBoxX1.TextLength > 0 And Me.PorNombreCheckBoxX1.CheckState = CheckState.Checked Then
                Try
                    cargarmovimientos(Me.DataGridViewX2.CurrentRow.Cells(0).Value, "")
                    bsMovimientos.Position = bsMovimientos.Find("id_propietario", Me.DataGridViewX2.CurrentRow.Cells(0).Value)
                    Me.panelPropietariosGroupPanel2.Visible = False
                Catch ex As Exception
                End Try
            End If
        End If

        If Me.TextBoxX1.TextLength > 0 And Me.PorNombreCheckBoxX1.CheckState = CheckState.Checked Then
            If e.KeyCode = Keys.Up Then
                Try
                    bsBuscarPropietarios.Position -= 1
                Catch ex As Exception
                End Try
            ElseIf e.KeyCode = Keys.Down Then
                Try
                    bsBuscarPropietarios.Position += 1
                Catch ex As Exception
                End Try
            End If
        End If
    End Sub




    Sub cargarbusquedaPropietarios(buscar As String)
        Try
            Dim dtsbuscarpropietarios As New dtsInventarioTelefonosTableAdapters.BuscarPropietariosTableAdapter

            dtsbuscarpropietarios.Fill(odtsInventarioTelefonos.BuscarPropietarios, buscar)


            Me.DataGridViewX2.AutoGenerateColumns = False
            bsBuscarPropietarios.DataSource = odtsInventarioTelefonos.BuscarPropietarios
            Me.DataGridViewX2.DataSource = bsBuscarPropietarios

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Admin GT - Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Sub cargarbusquedanumeros(numero As String)
        Try
            dtsBuscarLineas.Fill(odtsInventarioTelefonos.buscarNumeros, numero)
            Me.DataGridViewX3.AutoGenerateColumns = False
            bsLineas.DataSource = odtsInventarioTelefonos.buscarNumeros
            Me.DataGridViewX3.DataSource = bsLineas
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Admin GT - Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Sub cargarbusquedaTelefonos(imei As String)
        Try
            dtsBuscarTelefonos.Fill(odtsInventarioTelefonos.buscartelefonos, imei)
            bsBuscarTelefonos.DataSource = odtsInventarioTelefonos.buscartelefonos

            Me.DataGridViewX4.AutoGenerateColumns = False
            Me.DataGridViewX4.DataSource = bsBuscarTelefonos

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Admin GT - Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub




    Private Sub TextBoxX1_TextChanged(sender As Object, e As EventArgs) Handles TextBoxX1.TextChanged
        If Me.TextBoxX1.TextLength > 0 And Me.PorNombreCheckBoxX1.CheckState = CheckState.Checked Then

            Me.panelPropietariosGroupPanel2.Visible = True
            Me.panelPropietariosGroupPanel2.Size = New Size(615, 125)
            cargarbusquedaPropietarios(Me.TextBoxX1.Text)
        Else
            Me.panelPropietariosGroupPanel2.Visible = False
            cargarmovimientos("", Me.TextBoxX1.Text)
        End If
    End Sub
    Private Sub DataGridViewX2_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewX2.CellDoubleClick
        Try
            cargarmovimientos(Me.DataGridViewX2.CurrentRow.Cells(0).Value, "")
            bsMovimientos.Position = bsMovimientos.Find("id_propietario", Me.DataGridViewX2.CurrentRow.Cells(0).Value)
            Me.panelPropietariosGroupPanel2.Visible = False
        Catch ex As Exception
        End Try

    End Sub

    Private Sub fechaTextBoxX4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles fechaTextBoxX4.KeyPress

        If Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57 Or Asc(e.KeyChar) = 8 And Not Asc(e.KeyChar) = 47 And Not Asc(e.KeyChar) = 46 And Not Asc(e.KeyChar) = 45 Then
            e.Handled = False
        Else
            e.Handled = True
        End If
        If fechaTextBoxX4.TextLength = 2 And Not Asc(e.KeyChar) = 8 Then
            fechaTextBoxX4.Text = fechaTextBoxX4.Text & "/"
            fechaTextBoxX4.SelectionStart = 4
        ElseIf fechaTextBoxX4.TextLength = 5 And Not Asc(e.KeyChar) = 8 Then
            fechaTextBoxX4.Text = fechaTextBoxX4.Text & "/"
            fechaTextBoxX4.SelectionStart = 6
        End If
    End Sub

    Private Sub DataGridViewX3_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewX3.CellDoubleClick
        If Me.panelNumerosGroupPanel1.Visible = True Then
            Me.numeroTextBoxX2.Text = bsLineas.Current("numero")
            Me.id_propietarioTextBoxX5.Text = bsLineas.Current("id_propietario")
            Me.panelNumerosGroupPanel1.Visible = False
            Me.numeroTextBoxX2.SelectionStart = 9
        End If
    End Sub
    Private Sub DataGridViewX4_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewX4.CellDoubleClick
        If Me.paneltelefonosGroupPanel1.Visible = True Then
            Me.imeiTextBoxX3.Text = bsBuscarTelefonos.Current("imei")
            imeiTextBoxX3.SelectAll()
            Me.paneltelefonosGroupPanel1.Visible = False
        End If
    End Sub

    Private Sub ButtonX2_Click(sender As Object, e As EventArgs) Handles ButtonX2.Click
        If Me.guardarButtonX4.Text = "&Cancelar" Then
            MessageBoxEx.Show("Para aplicarle el descuento es necesario que guarde el movimiento", "Falta Guardar", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        ElseIf Me.noMovimientoTextBoxX1.Text = "0" Or Me.noMovimientoTextBoxX1.Text = "" Then
            MessageBoxEx.Show("No hay ningun movimiento seleccionado, para aplicar un descuento se debe de conocer el movimiento", "Incompleto", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        ElseIf Me.tipomovimientoComboBoxEx1.SelectedValue <> 1 Then
            MessageBoxEx.Show("El descuento solo se puede aplicar a un movimiento de tipo teléfono", "No permitido", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        Else

            If Me.id_propietarioTextBoxX5.Text <> "0" And Me.id_propietarioTextBoxX5.Text <> "" Then
                With dlgDescuentosxReposicion
                    .WindowState = FormWindowState.Normal
                    .StartPosition = FormStartPosition.CenterScreen
                    .no_movimiento = bsMovimientos.Current("no_movimiento")
                    .id_propietario = bsMovimientos.Current("id_propietario")
                    .ShowDialog()
                End With
            Else
                MessageBoxEx.Show("No ha ingresado el propietario", "Incompleto", MessageBoxButtons.OK, MessageBoxIcon.Stop)


            End If
        End If

    End Sub

    Private Sub fechaTextBoxX4_TextChanged(sender As Object, e As EventArgs) Handles fechaTextBoxX4.TextChanged

    End Sub

    Private Sub idEquipoTextBoxX2_Leave(sender As Object, e As EventArgs) Handles idEquipoTextBoxX2.Leave
        If Not String.IsNullOrEmpty(idEquipoTextBoxX2.Text) Then
            Dim equipoInfo As New ModuloTelefonos_Equipos
            equipoInfo = EquiposClase.getInfoEquipo(Convert.ToInt32(idEquipoTextBoxX2.Text))
            If equipoInfo IsNot Nothing Then
                Me.nombreEquipoTextBoxX3.Text = equipoInfo.descripcion
            Else
                MessageBoxEx.Show("El ID del equipo que ha ingresado no existe en la base de datos, favor validar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.idEquipoTextBoxX2.Focus()
            End If
        End If
    End Sub

    Private Sub idEquipoTextBoxX2_KeyDown(sender As Object, e As KeyEventArgs) Handles idEquipoTextBoxX2.KeyDown
        If e.KeyCode = Keys.F5 Then
            With frmConsultarEquipos
                .WindowState = FormWindowState.Normal
                .StartPosition = FormStartPosition.CenterScreen
                .ShowDialog()
            End With
        End If
    End Sub
End Class