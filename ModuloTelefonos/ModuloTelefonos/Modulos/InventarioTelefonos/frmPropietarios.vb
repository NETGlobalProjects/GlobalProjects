Imports DevComponents.DotNetBar.Rendering
Imports DevComponents.DotNetBar
Public Class frmPropietarios
    Inherits DevComponents.DotNetBar.Office2007Form
    Dim dtsPropietarios As New dtsInventarioTelefonosTableAdapters.propietariosTableAdapter
    Dim bsPropitarios As New BindingSource

    Dim dtsCargos As New dtsInventarioTelefonosTableAdapters.cargosTableAdapter
    Dim dtsEmpresas As New dtsInventarioTelefonosTableAdapters.t_empresasTableAdapter
    Dim dtsDepartamentos As New dtsInventarioTelefonosTableAdapters.t_departamentosTableAdapter
    Dim dtsTelefonos As New dtsInventarioTelefonosTableAdapters.telefonosMarcasTableAdapter
    Dim dtslineas As New dtsInventarioTelefonosTableAdapters.lineasTableAdapter
    Dim accesoDatos As New AccesoDatosNetData()
    Public odtsInventarioTelefonos As New dtsInventarioTelefonos
<<<<<<< HEAD
    Public Nomina As NominaEmpleadoModel
    Dim accion As Integer
    Dim numero As Integer

=======

    Private Sub frmPropietarios_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If Me.nuevoButtonX4.Text = "&Cancelar" Then
            Dim resp As MsgBoxResult = MessageBoxEx.Show("Se encuentra en modo creación si cierra este formulario no se guardara el registro" & vbCrLf & vbCrLf & "¿Desea cerrar la ventana de todas formas?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If resp = MsgBoxResult.Yes Then
                nuevoButtonX4_Click(sender, e)
                Me.Close()
            Else
                e.Cancel = True
            End If
        ElseIf Me.modificarButtonX5.Text = "&Cancelar" Then
            Dim resp As MsgBoxResult = MessageBoxEx.Show("Se encuentra en modo modificación si cierra este formulario no se guardaran los cambios" & vbCrLf & vbCrLf & "¿Desea cerrar la ventana de todas formas?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If resp = MsgBoxResult.Yes Then
                modificarButtonX5_Click(sender, e)
                Me.Close()
            Else
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub frmPropietarios_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub
>>>>>>> JD
    Private Sub frmPropietarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargar_cargos()
        cargar_empresas()
        cargar_departamentos()

<<<<<<< HEAD
=======
        cargar_propietarios("")
    End Sub
    Sub habilitar()
        Me.nombresTextBoxX2.ReadOnly = False
        Me.apellidosTextBoxX3.ReadOnly = False
        Me.otrosdatosTextBoxX1.ReadOnly = False
        Me.empresaComboBoxEx1.Enabled = True
        Me.departamentoComboBoxEx2.Enabled = True
        Me.cargoComboBoxEx3.Enabled = True
        Me.fechabajaTextBoxX5.ReadOnly = False
        Me.fechaingresoTextBoxX4.ReadOnly = False
        Me.DataGridViewX1.Enabled = False
        Me.estatusSwitchButton1.Enabled = True
        Me.codigoempleadoTextBoxX1.ReadOnly = False
        Me.rutaTextBoxX2.ReadOnly = False
    End Sub
    Sub deshabilitar()
        Me.nombresTextBoxX2.ReadOnly = True
        Me.apellidosTextBoxX3.ReadOnly = True
        Me.otrosdatosTextBoxX1.ReadOnly = True
        Me.empresaComboBoxEx1.Enabled = False
        Me.departamentoComboBoxEx2.Enabled = False
        Me.cargoComboBoxEx3.Enabled = False
        Me.fechabajaTextBoxX5.ReadOnly = True
        Me.fechaingresoTextBoxX4.ReadOnly = True
        Me.DataGridViewX1.Enabled = True
        Me.estatusSwitchButton1.Enabled = False
        Me.codigoempleadoTextBoxX1.ReadOnly = True
        Me.rutaTextBoxX2.ReadOnly = True
    End Sub
>>>>>>> JD
    Sub cargar_propietarios(buscar As String)
        Try
            dtsPropietarios.Fill(odtsInventarioTelefonos.propietarios, buscar)
            bsPropitarios.DataSource = odtsInventarioTelefonos.propietarios

            Me.DataGridViewX1.AutoGenerateColumns = False
            Me.DataGridViewX1.DataSource = bsPropitarios

<<<<<<< HEAD
            Me.idPropietarioTxt.DataBindings.Clear()
            Me.nombresTxt.DataBindings.Clear()
            Me.apellidosTxt.DataBindings.Clear()
            Me.fechaIngresoTxt.DataBindings.Clear()
            Me.fechaBajaTxt.DataBindings.Clear()
=======

            Me.idpropietarioTextBoxX1.DataBindings.Clear()
            Me.nombresTextBoxX2.DataBindings.Clear()
            Me.apellidosTextBoxX3.DataBindings.Clear()
            Me.empresaComboBoxEx1.DataBindings.Clear()
            Me.departamentoComboBoxEx2.DataBindings.Clear()
            Me.cargoComboBoxEx3.DataBindings.Clear()
            Me.fechaingresoTextBoxX4.DataBindings.Clear()
            Me.fechabajaTextBoxX5.DataBindings.Clear()
>>>>>>> JD
            Me.imeiactualTextBoxX1.DataBindings.Clear()
            Me.lineactualTextBoxX4.DataBindings.Clear()
            Me.otrosDatosTxt.DataBindings.Clear()
            Me.estatusSwbtn.DataBindings.Clear()
            Me.codEmpleadoTxt.DataBindings.Clear()
            Me.rutaTxt.DataBindings.Clear()
            Me.duiTxt.DataBindings.Clear()

<<<<<<< HEAD
            Me.costosTxt.DataBindings.Clear()

            Me.idEmpresaTxt.DataBindings.Clear()
            Me.empresaTxt.DataBindings.Clear()
            Me.idDepTxt.DataBindings.Clear()
            Me.depTxt.DataBindings.Clear()
            Me.idCargoTxt.DataBindings.Clear()
            Me.cargoTxt.DataBindings.Clear()

            Me.idPropietarioTxt.DataBindings.Add("text", bsPropitarios, "id_propietario", True, DataSourceUpdateMode.OnPropertyChanged)
            Me.nombresTxt.DataBindings.Add("text", bsPropitarios, "nombres", True, DataSourceUpdateMode.OnPropertyChanged)
            Me.apellidosTxt.DataBindings.Add("text", bsPropitarios, "apellidos", True, DataSourceUpdateMode.OnPropertyChanged)
            Me.fechaIngresoTxt.DataBindings.Add("text", bsPropitarios, "fecha_ingreso", True, DataSourceUpdateMode.OnPropertyChanged)
            Me.fechaBajaTxt.DataBindings.Add("text", bsPropitarios, "fecha_egreso", True, DataSourceUpdateMode.OnPropertyChanged)
=======
            Me.idpropietarioTextBoxX1.DataBindings.Add("text", bsPropitarios, "id_propietario", True, DataSourceUpdateMode.OnPropertyChanged)

            Me.nombresTextBoxX2.DataBindings.Add("text", bsPropitarios, "nombres", True, DataSourceUpdateMode.OnPropertyChanged)
            Me.apellidosTextBoxX3.DataBindings.Add("text", bsPropitarios, "apellidos", True, DataSourceUpdateMode.OnPropertyChanged)
            Me.empresaComboBoxEx1.DataBindings.Add("selectedvalue", bsPropitarios, "id_empresa", True, DataSourceUpdateMode.OnPropertyChanged)
            Me.departamentoComboBoxEx2.DataBindings.Add("selectedvalue", bsPropitarios, "id_departamento", True, DataSourceUpdateMode.OnPropertyChanged)
            Me.cargoComboBoxEx3.DataBindings.Add("selectedvalue", bsPropitarios, "id_cargo", True, DataSourceUpdateMode.OnPropertyChanged)
            Me.fechaingresoTextBoxX4.DataBindings.Add("text", bsPropitarios, "fecha_ingreso", True, DataSourceUpdateMode.OnPropertyChanged)
            Me.fechabajaTextBoxX5.DataBindings.Add("text", bsPropitarios, "fecha_egreso", True, DataSourceUpdateMode.OnPropertyChanged)
>>>>>>> JD
            Me.imeiactualTextBoxX1.DataBindings.Add("text", bsPropitarios, "imei_actual", True, DataSourceUpdateMode.OnPropertyChanged)
            Me.lineactualTextBoxX4.DataBindings.Add("text", bsPropitarios, "numero_actual", True, DataSourceUpdateMode.OnPropertyChanged)
            Me.otrosDatosTxt.DataBindings.Add("text", bsPropitarios, "otros_datos", True, DataSourceUpdateMode.OnPropertyChanged)
            Me.estatusSwbtn.DataBindings.Add("Value", bsPropitarios, "estatus", True, DataSourceUpdateMode.OnPropertyChanged)
            Me.codEmpleadoTxt.DataBindings.Add("text", bsPropitarios, "codigo_empleado", True, DataSourceUpdateMode.OnPropertyChanged)
            Me.rutaTxt.DataBindings.Add("text", bsPropitarios, "ruta", True, DataSourceUpdateMode.OnPropertyChanged)
            Me.duiTxt.DataBindings.Add("text", bsPropitarios, "dui", True, DataSourceUpdateMode.OnPropertyChanged)

<<<<<<< HEAD
            Me.costosTxt.DataBindings.Add("text", bsPropitarios, "CCosto", True, DataSourceUpdateMode.OnPropertyChanged)
=======
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Admin GT - Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Public Sub cargar_cargos()
        Try
            Dim actual As Integer
            actual = cargoComboBoxEx3.SelectedIndex
            cargoComboBoxEx3.DataSource = dtsCargos.GetData()
            cargoComboBoxEx3.ValueMember = "id_cargo"
            cargoComboBoxEx3.DisplayMember = "descripcion"
            Try
                cargoComboBoxEx3.SelectedIndex = actual
            Catch ex As Exception
                cargoComboBoxEx3.SelectedIndex = 0
            End Try

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Admin GT - Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Public Sub cargar_empresas()
        Try
            Dim actual As Integer
            actual = empresaComboBoxEx1.SelectedIndex
            empresaComboBoxEx1.DataSource = dtsEmpresas.GetData()
            empresaComboBoxEx1.ValueMember = "id_empresa"
            empresaComboBoxEx1.DisplayMember = "descripcion"
            Try
                empresaComboBoxEx1.SelectedIndex = actual
            Catch ex As Exception
                empresaComboBoxEx1.SelectedIndex = 0
            End Try

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Admin GT - Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub cargar_departamentos()
        Try
            Dim actual As Integer
            actual = departamentoComboBoxEx2.SelectedIndex
            departamentoComboBoxEx2.DataSource = dtsDepartamentos.GetData()
            departamentoComboBoxEx2.ValueMember = "id_departamento"
            departamentoComboBoxEx2.DisplayMember = "descripcion"
            Try
                departamentoComboBoxEx2.SelectedIndex = actual
            Catch ex As Exception
                departamentoComboBoxEx2.SelectedIndex = 0
            End Try
>>>>>>> JD

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Admin GT - Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub GroupPanel1_Click(sender As Object, e As EventArgs) Handles GroupPanel1.Click

    End Sub

<<<<<<< HEAD
    Private Sub frmPropietarios_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If Me.nuevoBtn.Text = "&Cancelar" Then
            Dim resp As MsgBoxResult = MessageBoxEx.Show("Se encuentra en modo creación si cierra este formulario no se guardara el registro" & vbCrLf & vbCrLf & "¿Desea cerrar la ventana de todas formas?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If resp = MsgBoxResult.Yes Then
                nuevoBtn_Click(sender, e)
                Me.Close()
            Else
                e.Cancel = True
            End If
        ElseIf Me.modificarBtn.Text = "&Cancelar" Then
            Dim resp As MsgBoxResult = MessageBoxEx.Show("Se encuentra en modo modificación si cierra este formulario no se guardaran los cambios" & vbCrLf & vbCrLf & "¿Desea cerrar la ventana de todas formas?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If resp = MsgBoxResult.Yes Then
                modificarBtn_Click(sender, e)
                Me.Close()
            Else
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub frmPropietarios_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub localizarTextBoxX1_KeyDown(sender As Object, e As KeyEventArgs) Handles localizarTextBoxX1.KeyDown
        If e.KeyCode = Keys.Enter Then
            cargar_propietarios(Me.localizarTextBoxX1.Text)
        End If
    End Sub

    Private Sub imeiactualTextBoxX1_TextChanged(sender As Object, e As EventArgs) Handles imeiactualTextBoxX1.TextChanged
        Me.marcaTextBoxX2.Clear()
        Me.modeloTextBoxX3.Clear()
        'Try
        '    Me.marcaTextBoxX2.Text = dtsTelefonos.GetMarcaTelefono(bsPropitarios.Current("imei_actual"))
        '    Me.modeloTextBoxX3.Text = dtsTelefonos.GetModeloTelefono(bsPropitarios.Current("imei_actual"))
        'Catch ex As Exception
        'End Try
    End Sub

    Private Sub lineactualTextBoxX4_TextChanged(sender As Object, e As EventArgs) Handles lineactualTextBoxX4.TextChanged
        Me.propietariolineaTextBoxX5.Clear()
        Try
            Me.propietariolineaTextBoxX5.Text = dtsPropietarios.GetNombreCompleto(dtslineas.GetIdPropietarioLinea(lineactualTextBoxX4.Text))
        Catch ex As Exception
        End Try
    End Sub

    Private Sub estatusSwitchButton1_ValueChanged(sender As Object, e As EventArgs) Handles estatusSwbtn.ValueChanged
        If Me.nuevoBtn.Text = "&Cancelar" Or Me.modificarBtn.Text = "&Cancelar" Then
            If estatusSwbtn.Value = False Then
                bsPropitarios.Current("fecha_egreso") = Format(Today, "dd/MM/yyyy")
            Else
                bsPropitarios.Current("fecha_egreso") = "01/01/1901"
            End If
        End If
    End Sub

    Private Sub fecha_TextChanged(sender As Object, e As EventArgs) Handles fechaIngresoTxt.TextChanged
        If Me.fechaIngresoTxt.Text = "1901/01/01" Then
            Me.fechaIngresoTxt.ForeColor = Color.DarkGray
        Else
            Me.fechaIngresoTxt.ForeColor = SystemColors.ControlText
        End If
    End Sub

    Private Sub fechaTxt_TextChanged(sender As Object, e As EventArgs) Handles fechaBajaTxt.TextChanged
        If Me.fechaBajaTxt.Text = "1901/01/01" Then
            Me.fechaBajaTxt.ForeColor = Color.DarkGray
        Else
            Me.fechaBajaTxt.ForeColor = SystemColors.ControlText
        End If
    End Sub

    Private Sub codEmpleado_TextChanged(sender As Object, e As EventArgs) Handles codEmpleadoTxt.TextChanged
        If Me.codEmpleadoTxt.Text <> "" And accion <> 0 Then
            Me.nominaActBtn.Enabled = True
        Else
            Me.nominaActBtn.Enabled = False
        End If
    End Sub

    Sub habilitar()
        'Me.nombresTextBoxX2.ReadOnly = False
        'Me.apellidosTextBoxX3.ReadOnly = False
        'Me.fechabajaTextBoxX5.ReadOnly = False
        'Me.fechaingresoTextBoxX4.ReadOnly = False
        'Me.codigoempleadoTextBoxX1.ReadOnly = False
        'Me.cdCostosTextBoxX1.ReadOnly = False
        Me.rutaTxt.ReadOnly = False
        Me.otrosDatosTxt.ReadOnly = False
        Me.estatusSwbtn.Enabled = True

        Me.DataGridViewX1.Enabled = False

        Me.nombresTxt.BackColor = Color.Gainsboro
        Me.apellidosTxt.BackColor = Color.Gainsboro
        Me.codEmpleadoTxt.BackColor = Color.Gainsboro
        Me.duiTxt.BackColor = Color.Gainsboro

        Me.idEmpresaTxt.BackColor = Color.Gainsboro
        Me.empresaTxt.BackColor = Color.Gainsboro
        Me.idDepTxt.BackColor = Color.Gainsboro
        Me.depTxt.BackColor = Color.Gainsboro
        Me.idCargoTxt.BackColor = Color.Gainsboro
        Me.cargoTxt.BackColor = Color.Gainsboro

        Me.costosTxt.BackColor = Color.Gainsboro
        Me.fechaIngresoTxt.BackColor = Color.Gainsboro
    End Sub

    Sub deshabilitar()
        'Me.nombresTextBoxX2.ReadOnly = True
        'Me.apellidosTextBoxX3.ReadOnly = True
        'Me.fechabajaTextBoxX5.ReadOnly = True
        'Me.fechaingresoTextBoxX4.ReadOnly = True
        'Me.codigoempleadoTextBoxX1.ReadOnly = True
        'Me.cdCostosTextBoxX1.ReadOnly = True
        Me.rutaTxt.ReadOnly = True
        Me.otrosDatosTxt.ReadOnly = True
        Me.estatusSwbtn.Enabled = False

        Me.DataGridViewX1.Enabled = True

        Me.nombresTxt.BackColor = Color.Gainsboro
        Me.apellidosTxt.BackColor = Color.Gainsboro
        Me.codEmpleadoTxt.BackColor = Color.Gainsboro
        Me.duiTxt.BackColor = Color.Gainsboro

        Me.idEmpresaTxt.BackColor = Color.Gainsboro
        Me.empresaTxt.BackColor = Color.Gainsboro
        Me.idDepTxt.BackColor = Color.Gainsboro
        Me.depTxt.BackColor = Color.Gainsboro
        Me.idCargoTxt.BackColor = Color.Gainsboro
        Me.cargoTxt.BackColor = Color.Gainsboro

        Me.costosTxt.BackColor = Color.Gainsboro
        Me.fechaIngresoTxt.BackColor = Color.Gainsboro
    End Sub

    Sub guardarcambios()
        Try
            Dim dui As String = duiTxt.Text.Replace(" ", "").Replace("-", "")

            ' Validar si es un nuevo registro
            If accion = 1 Then
                ' Verificar si el DUI ya existe en la lista
                For Each propietario As DataRow In odtsInventarioTelefonos.propietarios.Rows
                    Dim propietarioDUI As String = propietario("DUI").ToString().Replace(" ", "").Replace("-", "")
                    If propietarioDUI = dui Then
                        Throw New Exception("El DUI ya está registrado para otro propietario.")
                    End If
                Next
            End If

            ' Proceder con la acción
            If accion = 3 Then
=======
    Private Sub ButtonX3_Click(sender As Object, e As EventArgs) Handles ButtonX3.Click
        With dlgCargos
            .WindowState = FormWindowState.Normal
            .StartPosition = FormStartPosition.CenterScreen
            .ShowDialog()
        End With
    End Sub

    Private Sub ButtonX2_Click(sender As Object, e As EventArgs) Handles ButtonX2.Click
        With dlgDepartamentos
            .WindowState = FormWindowState.Normal
            .StartPosition = FormStartPosition.CenterScreen
            .ShowDialog()
        End With
    End Sub

    Private Sub ButtonX1_Click(sender As Object, e As EventArgs) Handles ButtonX1.Click
        With dlgEmpresas
            .WindowState = FormWindowState.Normal
            .StartPosition = FormStartPosition.CenterScreen
            .ShowDialog()
        End With
    End Sub

    Private Sub localizarTextBoxX1_KeyDown(sender As Object, e As KeyEventArgs) Handles localizarTextBoxX1.KeyDown
        If e.KeyCode = Keys.Enter Then
            cargar_propietarios(Me.localizarTextBoxX1.Text)

        End If
    End Sub
    Sub guardarcambios()
        Try
            Dim dui As String = duiMaskedTextBox1.Text.Replace(" ", "").Replace("-", "")

            If dui.Length < 9 Then
                duiMaskedTextBox1.Focus()
                Throw New Exception("Dui ingresado incompleto")

            Else
>>>>>>> JD
                Me.Validate()
                bsPropitarios.EndEdit()
                dtsPropietarios.Update(odtsInventarioTelefonos.propietarios)
            Else
                If dui.Length < 9 Then
                    duiTxt.Focus()
                    Throw New Exception("Dui no detectado, debe llevar numero de documento del propietario")
                Else
                    Me.Validate()
                    bsPropitarios.EndEdit()
                    dtsPropietarios.Update(odtsInventarioTelefonos.propietarios)
                End If
            End If


        Catch ex As Exception
            Throw New Exception(ex.Message, ex.InnerException)
        End Try
    End Sub
<<<<<<< HEAD

    Sub quitarespacion()
        Me.nombresTxt.Text.TrimEnd()
        Me.apellidosTxt.Text.TrimEnd()
        Me.fechaBajaTxt.Text.TrimEnd()
        Me.fechaIngresoTxt.Text.TrimEnd()
    End Sub

    Sub abrirBusquedaNomina()
        Dim buscarNominaForm As New frmBuscarNomina()

        If buscarNominaForm.ShowDialog() = DialogResult.OK Then
            Dim empleado As NominaEmpleadoModel = buscarNominaForm.EmpleadoSeleccionado
            Me.nombresTxt.Text = empleado.Nombre
            Me.apellidosTxt.Text = empleado.Apellidos
            Me.codEmpleadoTxt.Text = empleado.Numero
            Me.duiTxt.Text = empleado.DUI

            Me.idEmpresaTxt.Text = empleado.Dealer
            Me.empresaTxt.Text = empleado.DealerNombre
            Me.idDepTxt.Text = empleado.Departamento
            Me.depTxt.Text = empleado.DepartamentoNombre
            Me.idCargoTxt.Text = empleado.CargoDesempeñado
            Me.cargoTxt.Text = empleado.CargoNombre

            Me.costosTxt.Text = empleado.CCosto
            Me.fechaIngresoTxt.Text = empleado.FechaIngreso
            Me.estatusSwbtn.Value = True
=======
    Private Sub ButtonX6_Click(sender As Object, e As EventArgs) Handles eliminarButtonX6.Click
        Dim resp As MsgBoxResult = MessageBoxEx.Show("Esta seguro de eliminar por completo el registro del propietario: " & RTrim(Me.nombresTextBoxX2.Text) & " " & RTrim(Me.apellidosTextBoxX3.Text), "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
        If resp = MsgBoxResult.Yes Then
            Try
                bsPropitarios.RemoveCurrent()
                guardarcambios()
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Admin GT - Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
>>>>>>> JD
        End If
    End Sub

    Private Sub nuevoBtn_Click(sender As Object, e As EventArgs) Handles nuevoBtn.Click
        If Me.nuevoBtn.Text = "&Nuevo" Then
            Me.habilitar()
<<<<<<< HEAD
            Me.nuevoBtn.Text = "&Cancelar"
            Me.eliminarBtn.Enabled = False
            Me.modificarBtn.Enabled = False
            Me.guardarBtn.Enabled = True
            Me.nominaBtn.Enabled = True
            odtsInventarioTelefonos.propietarios.fecha_ingresoColumn.DefaultValue = "1901/01/01"
=======
            Me.nuevoButtonX4.Text = "&Cancelar"
            Me.eliminarButtonX6.Enabled = False
            Me.modificarButtonX5.Enabled = False
            Me.guardarButtonX7.Enabled = True
            odtsInventarioTelefonos.propietarios.fecha_ingresoColumn.DefaultValue = Today
>>>>>>> JD
            odtsInventarioTelefonos.propietarios.id_empresaColumn.DefaultValue = 0
            odtsInventarioTelefonos.propietarios.id_departamentoColumn.DefaultValue = 0
            odtsInventarioTelefonos.propietarios.id_cargoColumn.DefaultValue = 0
            odtsInventarioTelefonos.propietarios.otros_datosColumn.DefaultValue = ""
            odtsInventarioTelefonos.propietarios.id_propietarioColumn.DefaultValue = dtsPropietarios.GetNextId
            odtsInventarioTelefonos.propietarios.estatusColumn.DefaultValue = True
            odtsInventarioTelefonos.propietarios.fecha_egresoColumn.DefaultValue = "01/01/1901"
            odtsInventarioTelefonos.propietarios.duiColumn.DefaultValue = ""
            bsPropitarios.AddNew()
<<<<<<< HEAD
            abrirBusquedaNomina()
            Me.accion = 1
            If Me.codEmpleadoTxt.Text <> "" Then
                Me.nominaActBtn.Enabled = True
            End If
            Me.rutaTxt.Focus()
        ElseIf Me.nuevoBtn.Text = "&Cancelar" Then
            Me.deshabilitar()
            Me.nuevoBtn.Text = "&Nuevo"
            Me.eliminarBtn.Enabled = True
            Me.modificarBtn.Enabled = True
            Me.guardarBtn.Enabled = False
            Me.nominaBtn.Enabled = False
            Me.nominaActBtn.Enabled = False
=======
            Me.nombresTextBoxX2.Focus()
        ElseIf Me.nuevoButtonX4.Text = "&Cancelar" Then
            Me.deshabilitar()
            Me.nuevoButtonX4.Text = "&Nuevo"
            Me.eliminarButtonX6.Enabled = True
            Me.modificarButtonX5.Enabled = True
            Me.guardarButtonX7.Enabled = False
>>>>>>> JD
            bsPropitarios.RemoveCurrent()
            bsPropitarios.CancelEdit()
            Me.accion = 0
        End If
    End Sub

    Private Sub modificarBtn_Click(sender As Object, e As EventArgs) Handles modificarBtn.Click
        If modificarBtn.Text = "&Modificar" Then
            Me.nuevoBtn.Enabled = False
            Me.modificarBtn.Text = "&Cancelar"
            Me.eliminarBtn.Enabled = False
            Me.guardarBtn.Enabled = True
            Me.nominaBtn.Enabled = True
            quitarespacion()
            Me.habilitar()
            Me.accion = 2
            If Me.codEmpleadoTxt.Text <> "" Then
                Me.nominaActBtn.Enabled = True
            End If
            Me.rutaTxt.Focus()
        ElseIf modificarBtn.Text = "&Cancelar" Then
            Me.nuevoBtn.Enabled = True
            Me.modificarBtn.Text = "&Modificar"
            Me.eliminarBtn.Enabled = True
            Me.guardarBtn.Enabled = False
            Me.nominaBtn.Enabled = False
            Me.nominaActBtn.Enabled = False
            Me.deshabilitar()
            bsPropitarios.CancelEdit()
            Me.accion = 0
        End If


    End Sub

    Private Sub eliminarBtn_Click(sender As Object, e As EventArgs) Handles eliminarBtn.Click
        Dim resp As MsgBoxResult = MessageBoxEx.Show("Esta seguro de eliminar por completo el registro del propietario: " & RTrim(Me.nombresTxt.Text) & " " & RTrim(Me.apellidosTxt.Text), "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
        If resp = MsgBoxResult.Yes Then
            Try
                bsPropitarios.RemoveCurrent()
                Me.accion = 3
                guardarcambios()
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Admin GT - Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub gardarBtn_Click(sender As Object, e As EventArgs) Handles guardarBtn.Click
        Try
            If nuevoBtn.Text = "&Cancelar" Then
                guardarcambios()
<<<<<<< HEAD
                Me.nuevoBtn.Text = "&Nuevo"
                Me.eliminarBtn.Enabled = True
                Me.modificarBtn.Enabled = True
                Me.guardarBtn.Enabled = False
                Me.nominaBtn.Enabled = False
                Me.nominaActBtn.Enabled = False
                Me.deshabilitar()
                Me.accion = 0
            ElseIf modificarBtn.Text = "&Cancelar" Then
                guardarcambios()
                Me.modificarBtn.Text = "&Modificar"
                Me.nuevoBtn.Enabled = True
                Me.eliminarBtn.Enabled = True
                Me.guardarBtn.Enabled = False
                Me.nominaBtn.Enabled = False
                Me.nominaActBtn.Enabled = False
                Me.deshabilitar()
                Me.accion = 0
=======
                Me.deshabilitar()
                Me.nuevoButtonX4.Text = "&Nuevo"
                Me.eliminarButtonX6.Enabled = True
                Me.modificarButtonX5.Enabled = True
                Me.guardarButtonX7.Enabled = False
            ElseIf modificarButtonX5.Text = "&Cancelar" Then
                guardarcambios()
                Me.nuevoButtonX4.Enabled = True
                Me.modificarButtonX5.Text = "&Modificar"
                Me.eliminarButtonX6.Enabled = True
                Me.guardarButtonX7.Enabled = False
                Me.deshabilitar()

>>>>>>> JD
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

<<<<<<< HEAD
    Private Sub seleccionarBtn_Click(sender As Object, e As EventArgs) Handles seleccionarBtn.Click
=======

    End Sub
    Sub quitarespacion()
        Me.nombresTextBoxX2.Text.TrimEnd()
        Me.apellidosTextBoxX3.Text.TrimEnd()
        Me.fechabajaTextBoxX5.Text.TrimEnd()
        Me.fechaingresoTextBoxX4.Text.TrimEnd()
    End Sub
    Private Sub modificarButtonX5_Click(sender As Object, e As EventArgs) Handles modificarButtonX5.Click
        If modificarButtonX5.Text = "&Modificar" Then
            Me.nuevoButtonX4.Enabled = False
            Me.modificarButtonX5.Text = "&Cancelar"
            Me.eliminarButtonX6.Enabled = False
            Me.guardarButtonX7.Enabled = True
            quitarespacion()
            Me.habilitar()
            Me.nombresTextBoxX2.Focus()
        ElseIf modificarButtonX5.Text = "&Cancelar" Then
            Me.nuevoButtonX4.Enabled = True
            Me.modificarButtonX5.Text = "&Modificar"
            Me.eliminarButtonX6.Enabled = True
            Me.guardarButtonX7.Enabled = False
            Me.deshabilitar()
            bsPropitarios.CancelEdit()
        End If
    End Sub
    Private Sub seleccionarButtonX4_Click(sender As Object, e As EventArgs) Handles seleccionarButtonX4.Click
>>>>>>> JD
        frmMovimientos.id_propietarioTextBoxX5.Text = bsPropitarios.Current("id_propietario")
        Me.Close()
    End Sub

<<<<<<< HEAD
    Private Sub buscarBtn_Click(sender As Object, e As EventArgs) Handles buscarBtn.Click
        cargar_propietarios(Me.localizarTextBoxX1.Text)
    End Sub

    Private Sub nominaBtn_Click(sender As Object, e As EventArgs) Handles nominaBtn.Click
        abrirBusquedaNomina()
=======
    Private Sub imeiactualTextBoxX1_TextChanged(sender As Object, e As EventArgs) Handles imeiactualTextBoxX1.TextChanged
        Me.marcaTextBoxX2.Clear()
        Me.modeloTextBoxX3.Clear()
        'Try
        '    Me.marcaTextBoxX2.Text = dtsTelefonos.GetMarcaTelefono(bsPropitarios.Current("imei_actual"))
        '    Me.modeloTextBoxX3.Text = dtsTelefonos.GetModeloTelefono(bsPropitarios.Current("imei_actual"))
        'Catch ex As Exception

        'End Try

    End Sub

    Private Sub lineactualTextBoxX4_TextChanged(sender As Object, e As EventArgs) Handles lineactualTextBoxX4.TextChanged
        Me.propietariolineaTextBoxX5.Clear()

        Try
            Me.propietariolineaTextBoxX5.Text = dtsPropietarios.GetNombreCompleto(dtslineas.GetIdPropietarioLinea(lineactualTextBoxX4.Text))
        Catch ex As Exception

        End Try


>>>>>>> JD
    End Sub

    Private Sub nominaActBtn_Click(sender As Object, e As EventArgs) Handles nominaActBtn.Click
        If Integer.TryParse(codEmpleadoTxt.Text, numero) Then
            Nomina = accesoDatos.ObtenerNominaEmpleado(numero)

            If Nomina IsNot Nothing Then
                Dim sinCambio As Boolean = True
                If Me.nombresTxt.Text.Trim() <> Nomina.Nombre.Trim() Then
                    Me.nombresTxt.Text = Nomina.Nombre
                    Me.nombresTxt.BackColor = Color.Khaki
                    sinCambio = False
                End If
                If Me.apellidosTxt.Text.Trim() <> Nomina.Apellidos.Trim() Then
                    Me.apellidosTxt.Text = Nomina.Apellidos
                    Me.apellidosTxt.BackColor = Color.Khaki
                    sinCambio = False
                End If
                If Me.codEmpleadoTxt.Text <> Nomina.Numero Then
                    Me.codEmpleadoTxt.Text = Nomina.Numero
                    Me.codEmpleadoTxt.BackColor = Color.Khaki
                    sinCambio = False
                End If
                If Me.duiTxt.Text.Replace("-", "").Trim() <> Nomina.DUI.Replace("-", "").Trim() Then
                    Me.duiTxt.Text = Nomina.DUI
                    Me.duiTxt.BackColor = Color.Khaki
                    sinCambio = False
                End If

                If Me.idEmpresaTxt.Text <> Nomina.Dealer Then
                    Me.idEmpresaTxt.Text = Nomina.Dealer
                    Me.idEmpresaTxt.BackColor = Color.Khaki
                    sinCambio = False
                End If
                If Me.empresaTxt.Text <> Nomina.DealerNombre Then
                    Me.empresaTxt.Text = Nomina.DealerNombre
                    Me.empresaTxt.BackColor = Color.Khaki
                    sinCambio = False
                End If
                If Me.idDepTxt.Text <> Nomina.Departamento Then
                    Me.idDepTxt.Text = Nomina.Departamento
                    Me.idDepTxt.BackColor = Color.Khaki
                    sinCambio = False
                End If
                If Me.depTxt.Text <> Nomina.DepartamentoNombre Then
                    Me.depTxt.Text = Nomina.DepartamentoNombre
                    Me.depTxt.BackColor = Color.Khaki
                    sinCambio = False
                End If
                If Me.idCargoTxt.Text <> Nomina.CargoDesempeñado Then
                    Me.idCargoTxt.Text = Nomina.CargoDesempeñado
                    Me.idCargoTxt.BackColor = Color.Khaki
                    sinCambio = False
                End If
                If Me.cargoTxt.Text <> Nomina.CargoNombre Then
                    Me.cargoTxt.Text = Nomina.CargoNombre
                    Me.cargoTxt.BackColor = Color.Khaki
                    sinCambio = False
                End If

                If Me.costosTxt.Text <> Nomina.CCosto Then
                    Me.costosTxt.Text = Nomina.CCosto
                    Me.costosTxt.BackColor = Color.Khaki
                    sinCambio = False
                End If
                If Me.fechaIngresoTxt.Text <> Nomina.FechaIngreso Then
                    Me.fechaIngresoTxt.Text = Nomina.FechaIngreso
                    Me.fechaIngresoTxt.BackColor = Color.Khaki
                    sinCambio = False
                End If

                If sinCambio Then
                    MessageBox.Show("No se encontraron cambios en la nomina", "Sin Cambios", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Else
                MessageBox.Show("Empleado no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("Error en Cod. Empleado", "Seleccione", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
<<<<<<< HEAD
    End Sub

    Private Sub ButtonX3_Click(sender As Object, e As EventArgs)
        With dlgCargos
            .WindowState = FormWindowState.Normal
            .StartPosition = FormStartPosition.CenterScreen
            .ShowDialog()
        End With
    End Sub

    Private Sub ButtonX2_Click(sender As Object, e As EventArgs)
        With dlgDepartamentos
            .WindowState = FormWindowState.Normal
            .StartPosition = FormStartPosition.CenterScreen
            .ShowDialog()
        End With
    End Sub

    Private Sub ButtonX1_Click(sender As Object, e As EventArgs)
        With dlgEmpresas
            .WindowState = FormWindowState.Normal
            .StartPosition = FormStartPosition.CenterScreen
            .ShowDialog()
        End With
    End Sub

    'Public Sub cargar_cargos()
    'Try
    'Dim actual As Integer
    '       actual = cargoComboBoxEx3.SelectedIndex
    '      cargoComboBoxEx3.DataSource = dtsCargos.GetData()
    '     cargoComboBoxEx3.ValueMember = "id_cargo"
    '    cargoComboBoxEx3.DisplayMember = "descripcion"
    'Try
    '           cargoComboBoxEx3.SelectedIndex = actual
    'Catch ex As Exception
    '           cargoComboBoxEx3.SelectedIndex = 0
    'End Try
    'Catch ex As Exception
    '       MessageBox.Show(ex.Message, "Admin GT - Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    'End Try
    'End Sub

    'Public Sub cargar_empresas()
    'Try
    'Dim actual As Integer
    '       actual = empresaComboBoxEx1.SelectedIndex
    '      empresaComboBoxEx1.DataSource = dtsEmpresas.GetData()
    '     empresaComboBoxEx1.ValueMember = "id_empresa"
    '    empresaComboBoxEx1.DisplayMember = "descripcion"
    'Try
    '           empresaComboBoxEx1.SelectedIndex = actual
    'Catch ex As Exception
    '           empresaComboBoxEx1.SelectedIndex = 0
    'End Try
    'Catch ex As Exception
    '       MessageBox.Show(ex.Message, "Admin GT - Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    'End Try
    'End Sub

    'Public Sub cargar_departamentos()
    'Try
    'Dim actual As Integer
    '       actual = departamentoComboBoxEx2.SelectedIndex
    '      departamentoComboBoxEx2.DataSource = dtsDepartamentos.GetData()
    '     departamentoComboBoxEx2.ValueMember = "id_departamento"
    '    departamentoComboBoxEx2.DisplayMember = "descripcion"
    'Try
    '           departamentoComboBoxEx2.SelectedIndex = actual
    'Catch ex As Exception
    '           departamentoComboBoxEx2.SelectedIndex = 0
    'End Try
    'Catch ex As Exception
    '       MessageBox.Show(ex.Message, "Admin GT - Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    'End Try
    'End Sub
=======

    End Sub
>>>>>>> JD
End Class