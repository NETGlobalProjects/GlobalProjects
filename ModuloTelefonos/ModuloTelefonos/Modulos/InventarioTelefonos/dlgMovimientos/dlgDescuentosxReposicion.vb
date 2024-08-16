Imports DevComponents.DotNetBar.Rendering
Imports DevComponents.DotNetBar
Public Class dlgDescuentosxReposicion
    Inherits DevComponents.DotNetBar.Office2007Form
    Public no_movimiento, id_propietario As Integer
    Dim descuentosxreposicionesAdapter As New dtsInventarioTelefonosTableAdapters.descuentos_x_reposicionesTableAdapter
    Dim bsdescuentoxreposiciones As New BindingSource

    Dim dtstelefonosMarcas As New dtsInventarioTelefonosTableAdapters.telefonosMarcasTableAdapter
    Dim dtsTelefonos As New dtsInventarioTelefonosTableAdapters.telefonosTableAdapter
    Dim dtsMovimientos As New dtsInventarioTelefonosTableAdapters.movimientos_lineas_telefonosTableAdapter
    Dim dtspropietarios As New dtsInventarioTelefonosTableAdapters.propietariosTableAdapter
    Public odtsInventarioTelefonos As New dtsInventarioTelefonos

    Private Sub ButtonX1_Click(sender As Object, e As EventArgs) Handles ButtonX1.Click
        bsdescuentoxreposiciones.CancelEdit()

        Me.Close()
    End Sub
    Sub cargar(propietario As Integer)
        Try
            descuentosxreposicionesAdapter.Fill(odtsInventarioTelefonos.descuentos_x_reposiciones, propietario)
            bsdescuentoxreposiciones.DataSource = odtsInventarioTelefonos.descuentos_x_reposiciones

            descuentonoTextBox3.DataBindings.Clear()
            nomovimientoTextBox5.DataBindings.Clear()
            idpropietarioTextBox1.DataBindings.Clear()
            imeiTextBoxX1.DataBindings.Clear()
            precioDoubleInput2.DataBindings.Clear()
            porcentajeDoubleInput1.DataBindings.Clear()
            valoradescontarDoubleInput3.DataBindings.Clear()
            fechaTextBoxX4.DataBindings.Clear()
            reiniciarCheckBox1.DataBindings.Clear()


            descuentonoTextBox3.DataBindings.Add("text", bsdescuentoxreposiciones, "descuento_no", True, DataSourceUpdateMode.OnPropertyChanged)
            nomovimientoTextBox5.DataBindings.Add("text", bsdescuentoxreposiciones, "no_movimiento", True, DataSourceUpdateMode.OnPropertyChanged)
            idpropietarioTextBox1.DataBindings.Add("text", bsdescuentoxreposiciones, "id_propietario", True, DataSourceUpdateMode.OnPropertyChanged)
            imeiTextBoxX1.DataBindings.Add("text", bsdescuentoxreposiciones, "imei", True, DataSourceUpdateMode.OnPropertyChanged)
            precioDoubleInput2.DataBindings.Add("value", bsdescuentoxreposiciones, "precio_del_telefono", True, DataSourceUpdateMode.OnPropertyChanged)
            porcentajeDoubleInput1.DataBindings.Add("value", bsdescuentoxreposiciones, "porcentaje_descontar", True, DataSourceUpdateMode.OnPropertyChanged)
            valoradescontarDoubleInput3.DataBindings.Add("value", bsdescuentoxreposiciones, "valor_a_descontar", True, DataSourceUpdateMode.OnPropertyChanged)
            fechaTextBoxX4.DataBindings.Add("text", bsdescuentoxreposiciones, "fecha", True, DataSourceUpdateMode.OnPropertyChanged)
            reiniciarCheckBox1.DataBindings.Add("checked", bsdescuentoxreposiciones, "reiniciar_conteo", True, DataSourceUpdateMode.OnPropertyChanged)

        Catch ex As Exception
            MessageBoxEx.Show(ex.Message, "Error al cargar descuentos", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Sub nuevo()
        odtsInventarioTelefonos.descuentos_x_reposiciones.no_movimientoColumn.DefaultValue = no_movimiento
        odtsInventarioTelefonos.descuentos_x_reposiciones.id_propietarioColumn.DefaultValue = id_propietario
        odtsInventarioTelefonos.descuentos_x_reposiciones.imeiColumn.DefaultValue = dtsMovimientos.GetAnteriorImei(id_propietario, no_movimiento)
        odtsInventarioTelefonos.descuentos_x_reposiciones.descuento_noColumn.DefaultValue = descuentosxreposicionesAdapter.GetNoDescuento(id_propietario)
        odtsInventarioTelefonos.descuentos_x_reposiciones.precio_del_telefonoColumn.DefaultValue = 0
        odtsInventarioTelefonos.descuentos_x_reposiciones.porcentaje_descontarColumn.DefaultValue = 20
        porcentajeanteriorDoubleInput1.Value = descuentosxreposicionesAdapter.GetPorcentajeAnteriorDescuento(id_propietario)
        odtsInventarioTelefonos.descuentos_x_reposiciones.valor_a_descontarColumn.DefaultValue = CDbl(precioDoubleInput2.Value) * ((CDbl(porcentajeDoubleInput1.Value)) / 100)
        odtsInventarioTelefonos.descuentos_x_reposiciones.fechaColumn.DefaultValue = Format(Today, "dd/MM/yyyy")
        odtsInventarioTelefonos.descuentos_x_reposiciones.reiniciar_conteoColumn.DefaultValue = False
        odtsInventarioTelefonos.descuentos_x_reposiciones.reailzado_porColumn.DefaultValue = UsuarioActual
        bsdescuentoxreposiciones.AddNew()

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

    Private Sub fechaTextBoxX4_TextChanged(sender As Object, e As EventArgs) Handles fechaTextBoxX4.TextChanged

    End Sub

    Private Sub dlgDescuentosxReposicion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargar(id_propietario)
        nuevo()

    End Sub

    Private Sub TextBoxX1_KeyDown(sender As Object, e As KeyEventArgs) Handles imeiTextBoxX1.KeyDown
        If e.KeyCode = Keys.F5 Then
            With frmLotesTelefonos
                .quienllama = "descuentos"
                .seleccionarButtonX2.Visible = True
                .WindowState = FormWindowState.Normal
                .StartPosition = FormStartPosition.CenterScreen
                .TextBoxX1.Focus()
                .ShowDialog()
            End With
        End If
    End Sub

    Private Sub imeiTextBoxX1_TextChanged(sender As Object, e As EventArgs) Handles imeiTextBoxX1.TextChanged
        Me.marcaTextBoxX1.Text = dtstelefonosMarcas.GetMarcaTelefono(RTrim(imeiTextBoxX1.Text))
        Me.modeloTextBoxX2.Text = dtstelefonosMarcas.GetModeloTelefono(RTrim(imeiTextBoxX1.Text))
    End Sub

    Private Sub idpropietarioTextBox1_TextChanged(sender As Object, e As EventArgs) Handles idpropietarioTextBox1.TextChanged
        nombrecompletoTextBox2.Text = dtspropietarios.GetNombreCompleto(Me.idpropietarioTextBox1.Text)
    End Sub



    Private Sub precioDoubleInput2_ValueChanged(sender As Object, e As EventArgs) Handles precioDoubleInput2.ValueChanged
        Me.valoradescontarDoubleInput3.Value = CDbl(precioDoubleInput2.Value) * ((CDbl(porcentajeDoubleInput1.Value)) / 100)
    End Sub

    Private Sub ButtonX2_Click(sender As Object, e As EventArgs) Handles ButtonX2.Click
        Try
            bsdescuentoxreposiciones.EndEdit()
            descuentosxreposicionesAdapter.Update(odtsInventarioTelefonos.descuentos_x_reposiciones)

            Me.Close()
        Catch ex As Exception
            MessageBoxEx.Show(ex.Message, "Error al guardar", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class