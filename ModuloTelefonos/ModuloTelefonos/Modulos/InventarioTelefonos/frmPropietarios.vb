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
    Public odtsInventarioTelefonos As New dtsInventarioTelefonos

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

    Private Sub frmPropietarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'cargar_cargos()
        'cargar_empresas()
        'cargar_departamentos()
        cargar_propietarios(" ")
    End Sub

    Sub habilitar()
        'Me.nombresTextBoxX2.ReadOnly = False
        'Me.apellidosTextBoxX3.ReadOnly = False
        'Me.fechabajaTextBoxX5.ReadOnly = False
        'Me.fechaingresoTextBoxX4.ReadOnly = False
        'Me.codigoempleadoTextBoxX1.ReadOnly = False
        'Me.cdCostosTextBoxX1.ReadOnly = False
        Me.rutaTextBoxX2.ReadOnly = False
        Me.otrosdatosTextBoxX1.ReadOnly = False
        Me.estatusSwitchButton1.Enabled = True

        Me.DataGridViewX1.Enabled = False
    End Sub

    Sub deshabilitar()
        'Me.nombresTextBoxX2.ReadOnly = True
        'Me.apellidosTextBoxX3.ReadOnly = True
        'Me.fechabajaTextBoxX5.ReadOnly = True
        'Me.fechaingresoTextBoxX4.ReadOnly = True
        'Me.codigoempleadoTextBoxX1.ReadOnly = True
        'Me.cdCostosTextBoxX1.ReadOnly = True
        Me.rutaTextBoxX2.ReadOnly = True
        Me.otrosdatosTextBoxX1.ReadOnly = True
        Me.estatusSwitchButton1.Enabled = False

        Me.DataGridViewX1.Enabled = True
    End Sub

    Sub cargar_propietarios(buscar As String)
        Try
            dtsPropietarios.Fill(odtsInventarioTelefonos.propietarios, buscar)
            bsPropitarios.DataSource = odtsInventarioTelefonos.propietarios

            Me.DataGridViewX1.AutoGenerateColumns = False
            Me.DataGridViewX1.DataSource = bsPropitarios

            Me.idpropietarioTextBoxX1.DataBindings.Clear()
            Me.nombresTextBoxX2.DataBindings.Clear()
            Me.apellidosTextBoxX3.DataBindings.Clear()
            Me.fechaingresoTextBoxX4.DataBindings.Clear()
            Me.fechabajaTextBoxX5.DataBindings.Clear()
            Me.imeiactualTextBoxX1.DataBindings.Clear()
            Me.lineactualTextBoxX4.DataBindings.Clear()
            Me.otrosdatosTextBoxX1.DataBindings.Clear()
            Me.estatusSwitchButton1.DataBindings.Clear()
            Me.codigoempleadoTextBoxX1.DataBindings.Clear()
            Me.rutaTextBoxX2.DataBindings.Clear()
            Me.duiMaskedTextBox1.DataBindings.Clear()

            Me.cdCostosTextBoxX1.DataBindings.Clear()

            Me.idEmpresaTxt.DataBindings.Clear()
            Me.empresaTxt.DataBindings.Clear()
            Me.idDepTxt.DataBindings.Clear()
            Me.depTxt.DataBindings.Clear()
            Me.idCargoTxt.DataBindings.Clear()
            Me.cargoTxt.DataBindings.Clear()

            Me.idpropietarioTextBoxX1.DataBindings.Add("text", bsPropitarios, "id_propietario", True, DataSourceUpdateMode.OnPropertyChanged)
            Me.nombresTextBoxX2.DataBindings.Add("text", bsPropitarios, "nombres", True, DataSourceUpdateMode.OnPropertyChanged)
            Me.apellidosTextBoxX3.DataBindings.Add("text", bsPropitarios, "apellidos", True, DataSourceUpdateMode.OnPropertyChanged)
            Me.fechaingresoTextBoxX4.DataBindings.Add("text", bsPropitarios, "fecha_ingreso", True, DataSourceUpdateMode.OnPropertyChanged)
            Me.fechabajaTextBoxX5.DataBindings.Add("text", bsPropitarios, "fecha_egreso", True, DataSourceUpdateMode.OnPropertyChanged)
            Me.imeiactualTextBoxX1.DataBindings.Add("text", bsPropitarios, "imei_actual", True, DataSourceUpdateMode.OnPropertyChanged)
            Me.lineactualTextBoxX4.DataBindings.Add("text", bsPropitarios, "numero_actual", True, DataSourceUpdateMode.OnPropertyChanged)
            Me.otrosdatosTextBoxX1.DataBindings.Add("text", bsPropitarios, "otros_datos", True, DataSourceUpdateMode.OnPropertyChanged)
            Me.estatusSwitchButton1.DataBindings.Add("Value", bsPropitarios, "estatus", True, DataSourceUpdateMode.OnPropertyChanged)
            Me.codigoempleadoTextBoxX1.DataBindings.Add("text", bsPropitarios, "codigo_empleado", True, DataSourceUpdateMode.OnPropertyChanged)
            Me.rutaTextBoxX2.DataBindings.Add("text", bsPropitarios, "ruta", True, DataSourceUpdateMode.OnPropertyChanged)
            Me.duiMaskedTextBox1.DataBindings.Add("text", bsPropitarios, "dui", True, DataSourceUpdateMode.OnPropertyChanged)

            Me.cdCostosTextBoxX1.DataBindings.Add("text", bsPropitarios, "CCosto", True, DataSourceUpdateMode.OnPropertyChanged)

            Me.idEmpresaTxt.DataBindings.Add("text", bsPropitarios, "id_empresa", True, DataSourceUpdateMode.OnPropertyChanged)
            Me.empresaTxt.DataBindings.Add("text", bsPropitarios, "empresaNombre", True, DataSourceUpdateMode.OnPropertyChanged)
            Me.idDepTxt.DataBindings.Add("text", bsPropitarios, "id_departamento", True, DataSourceUpdateMode.OnPropertyChanged)
            Me.depTxt.DataBindings.Add("text", bsPropitarios, "departamentoNombre", True, DataSourceUpdateMode.OnPropertyChanged)
            Me.idCargoTxt.DataBindings.Add("text", bsPropitarios, "id_cargo", True, DataSourceUpdateMode.OnPropertyChanged)
            Me.cargoTxt.DataBindings.Add("text", bsPropitarios, "cargoNombre", True, DataSourceUpdateMode.OnPropertyChanged)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Admin GT - Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
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
                Throw New Exception("Dui no detectado, Debes elegir una nomina")
            Else
                Me.Validate()
                bsPropitarios.EndEdit()
                dtsPropietarios.Update(odtsInventarioTelefonos.propietarios)
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message, ex.InnerException)
        End Try
    End Sub

    Private Sub ButtonX6_Click(sender As Object, e As EventArgs) Handles eliminarButtonX6.Click
        Dim resp As MsgBoxResult = MessageBoxEx.Show("Esta seguro de eliminar por completo el registro del propietario: " & RTrim(Me.nombresTextBoxX2.Text) & " " & RTrim(Me.apellidosTextBoxX3.Text), "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
        If resp = MsgBoxResult.Yes Then
            Try
                bsPropitarios.RemoveCurrent()
                guardarcambios()
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Admin GT - Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub nuevoButtonX4_Click(sender As Object, e As EventArgs) Handles nuevoButtonX4.Click
        If Me.nuevoButtonX4.Text = "&Nuevo" Then
            Me.habilitar()
            Me.nuevoButtonX4.Text = "&Cancelar"
            Me.eliminarButtonX6.Enabled = False
            Me.modificarButtonX5.Enabled = False
            Me.guardarButtonX7.Enabled = True
            Me.nominaBtn.Enabled = True
            odtsInventarioTelefonos.propietarios.fecha_ingresoColumn.DefaultValue = "1901/01/01"
            odtsInventarioTelefonos.propietarios.id_empresaColumn.DefaultValue = 0
            odtsInventarioTelefonos.propietarios.id_departamentoColumn.DefaultValue = 0
            odtsInventarioTelefonos.propietarios.id_cargoColumn.DefaultValue = 0
            odtsInventarioTelefonos.propietarios.otros_datosColumn.DefaultValue = ""
            odtsInventarioTelefonos.propietarios.id_propietarioColumn.DefaultValue = dtsPropietarios.GetNextId
            odtsInventarioTelefonos.propietarios.estatusColumn.DefaultValue = True
            odtsInventarioTelefonos.propietarios.fecha_egresoColumn.DefaultValue = "1901/01/01"
            odtsInventarioTelefonos.propietarios.duiColumn.DefaultValue = ""
            bsPropitarios.AddNew()
            abrirBusquedaNomina()
            Me.rutaTextBoxX2.Focus()
        ElseIf Me.nuevoButtonX4.Text = "&Cancelar" Then
            Me.deshabilitar()
            Me.nuevoButtonX4.Text = "&Nuevo"
            Me.eliminarButtonX6.Enabled = True
            Me.modificarButtonX5.Enabled = True
            Me.guardarButtonX7.Enabled = False
            Me.nominaBtn.Enabled = False
            bsPropitarios.RemoveCurrent()
            bsPropitarios.CancelEdit()
        End If
    End Sub

    Private Sub guardarButtonX7_Click(sender As Object, e As EventArgs) Handles guardarButtonX7.Click
        Try
            If nuevoButtonX4.Text = "&Cancelar" Then
                guardarcambios()
                Me.deshabilitar()
                Me.nuevoButtonX4.Text = "&Nuevo"
                Me.eliminarButtonX6.Enabled = True
                Me.modificarButtonX5.Enabled = True
                Me.guardarButtonX7.Enabled = False
                Me.nominaBtn.Enabled = False
            ElseIf modificarButtonX5.Text = "&Cancelar" Then
                guardarcambios()
                Me.nuevoButtonX4.Enabled = True
                Me.modificarButtonX5.Text = "&Modificar"
                Me.eliminarButtonX6.Enabled = True
                Me.guardarButtonX7.Enabled = False
                Me.nominaBtn.Enabled = False
                Me.deshabilitar()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
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
            Me.nominaBtn.Enabled = True
            quitarespacion()
            Me.habilitar()
            Me.nombresTextBoxX2.Focus()
        ElseIf modificarButtonX5.Text = "&Cancelar" Then
            Me.nuevoButtonX4.Enabled = True
            Me.modificarButtonX5.Text = "&Modificar"
            Me.eliminarButtonX6.Enabled = True
            Me.guardarButtonX7.Enabled = False
            Me.nominaBtn.Enabled = False
            Me.deshabilitar()
            bsPropitarios.CancelEdit()
        End If
    End Sub

    Private Sub seleccionarButtonX4_Click(sender As Object, e As EventArgs) Handles seleccionarButtonX4.Click
        frmMovimientos.id_propietarioTextBoxX5.Text = bsPropitarios.Current("id_propietario")
        Me.Close()
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

    Private Sub estatusSwitchButton1_ValueChanged(sender As Object, e As EventArgs) Handles estatusSwitchButton1.ValueChanged
        If Me.nuevoButtonX4.Text = "&Cancelar" Or Me.modificarButtonX5.Text = "&Cancelar" Then
            If estatusSwitchButton1.Value = False Then
                bsPropitarios.Current("fecha_egreso") = Format(Today, "dd/MM/yyyy")
            Else
                bsPropitarios.Current("fecha_egreso") = "01/01/1901"
            End If
        End If
    End Sub

    Private Sub buscarBtn_Click(sender As Object, e As EventArgs) Handles buscarBtn.Click
        cargar_propietarios(Me.localizarTextBoxX1.Text)
    End Sub

    Sub abrirBusquedaNomina()
        Dim buscarNominaForm As New frmBuscarNomina()

        If buscarNominaForm.ShowDialog() = DialogResult.OK Then
            Dim empleado As NominaEmpleadoModel = buscarNominaForm.EmpleadoSeleccionado
            Me.nombresTextBoxX2.Text = empleado.Nombre
            Me.apellidosTextBoxX3.Text = empleado.Apellidos
            Me.codigoempleadoTextBoxX1.Text = empleado.Numero
            Me.duiMaskedTextBox1.Text = empleado.DUI

            Me.idEmpresaTxt.Text = empleado.Dealer
            Me.empresaTxt.Text = empleado.DealerNombre
            Me.idDepTxt.Text = empleado.Departamento
            Me.depTxt.Text = empleado.DepartamentoNombre
            Me.idCargoTxt.Text = empleado.CargoDesempeñado
            Me.cargoTxt.Text = empleado.CargoNombre

            Me.cdCostosTextBoxX1.Text = empleado.CCosto
            Me.fechaingresoTextBoxX4.Text = empleado.FechaIngreso
            Me.estatusSwitchButton1.Value = True
        End If
    End Sub

    Private Sub nominaBtn_Click(sender As Object, e As EventArgs) Handles nominaBtn.Click
        abrirBusquedaNomina()
    End Sub
End Class