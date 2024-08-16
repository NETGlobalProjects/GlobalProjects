Public Class frmAddModEquipo
    Public accion As String
    Public id_equipo As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
    Private Sub frmAddModEquipo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarMarcas()
        cargarTipoTelefonos()
        cargarEstados()
        Me.fechaDateTimeInput1.Text = Today.ToString()
        Me.garantiaIntegerInput1.Value = 1
        If accion = "editar" Then
            Dim equipo As New ModuloTelefonos_Equipos
            equipo = EquiposClase.getInfoEquipo(id_equipo)
            With equipo
                Me.idTextBox1.Text = Convert.ToString(.id_equipo)
                Me.estadoComboBox1.SelectedValue = .id_estado
                Me.marcaComboBox2.SelectedValue = .id_marca
                Me.modeloTextBox2.Text = .modelo
                Me.serieTextBox3.Text = .serie
                Me.tipoComboBox1.SelectedValue = .id_tipo
                Me.fechaDateTimeInput1.Text = Convert.ToString(.fecha_compra)
                Me.proveedorTextBox4.Text = .proveedor
                Me.descripcionTextBox5.Text = .descripcion
                Me.garantiaIntegerInput1.Value = CInt(.tiempo_garantia_meses)
                Me.disponibleCheckBoxX1.Checked = Convert.ToBoolean(.disponible)
            End With
        End If
    End Sub
    Sub cargarMarcas()
        Me.marcaComboBox2.DataSource = EquiposClase.getMarcas()
        Me.marcaComboBox2.ValueMember = "id_marca"
        Me.marcaComboBox2.DisplayMember = "descripcion"
    End Sub
    Sub cargarTipoTelefonos()
        Me.tipoComboBox1.DataSource = EquiposClase.getTipos()
        Me.tipoComboBox1.ValueMember = "id_tipo"
        Me.tipoComboBox1.DisplayMember = "nombre"
    End Sub
    Sub cargarEstados()
        Me.estadoComboBox1.DataSource = EquiposClase.getEstados()
        Me.estadoComboBox1.DisplayMember = "descripcion"
        Me.estadoComboBox1.ValueMember = "id_estado"
    End Sub
    Sub validarCampos()
        If Me.descripcionTextBox5.Text = "" Then
            MessageBox.Show("Debe ingresar una descripción", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If accion = "añadir" Then
            Dim r As String = EquiposClase.nuevoEquipo(New ModuloTelefonos_Equipos() With {.descripcion = Me.descripcionTextBox5.Text, .id_estado = CInt(Me.estadoComboBox1.SelectedValue), .fecha_compra = CDate(Me.fechaDateTimeInput1.Text), .id_marca = CInt(Me.marcaComboBox2.SelectedValue), .id_tipo = CInt(Me.tipoComboBox1.SelectedValue), .modelo = Me.modeloTextBox2.Text, .proveedor = Me.proveedorTextBox4.Text, .serie = Me.serieTextBox3.Text, .tiempo_garantia_meses = CInt(Me.garantiaIntegerInput1.Value), .disponible = True})
            If r.Contains("Error:") Then
                MessageBox.Show(r, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                frmManttoEquipos.cargarListado()
                Me.Dispose()
            End If
        ElseIf accion = "editar" Then
            Dim r As String = EquiposClase.editarEquipo(New ModuloTelefonos_Equipos() With {.descripcion = Me.descripcionTextBox5.Text, .id_estado = CInt(Me.estadoComboBox1.SelectedValue), .fecha_compra = CDate(Me.fechaDateTimeInput1.Text), .id_marca = CInt(Me.marcaComboBox2.SelectedValue), .id_tipo = CInt(Me.tipoComboBox1.SelectedValue), .modelo = Me.modeloTextBox2.Text, .proveedor = Me.proveedorTextBox4.Text, .serie = Me.serieTextBox3.Text, .tiempo_garantia_meses = CInt(Me.garantiaIntegerInput1.Value), .disponible = Me.disponibleCheckBoxX1.Checked}, id_equipo)
            If r.Contains("Error:") Then
                MessageBox.Show(r, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                frmManttoEquipos.cargarListado()
                Me.Dispose()
            End If
        End If
    End Sub
End Class