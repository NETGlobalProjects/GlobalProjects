Imports DevComponents.DotNetBar.Rendering
Imports DevComponents.DotNetBar

Public Class frmBuscarNomina
    Inherits DevComponents.DotNetBar.Office2007Form
    Dim bsNominas As New BindingSource
    Dim accesoDatos As New AccesoDatosNetData()
    Public EmpleadoSeleccionado As NominaEmpleadoModel
    Dim numero As Integer

    Private Sub frmBuscarNomina_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With filtroCbx
            .Items.Clear()
            .Items.Add(New With {.Text = "Todo", .Value = 0})
            .Items.Add(New With {.Text = "Dui", .Value = 1})
            .Items.Add(New With {.Text = "#Numero", .Value = 2})
            .Items.Add(New With {.Text = "Nombre", .Value = 3})
            .Items.Add(New With {.Text = "Apellidos", .Value = 4})

            .DisplayMember = "Text"
            .ValueMember = "Value"
            .SelectedIndex = 0
        End With
    End Sub

    Sub cargar_propietarios(busqueda As String, filtro As Integer)
        Try
            bsNominas.DataSource = accesoDatos.ListarNominaEmpleados(busqueda, filtro)

            Me.nominasDgv.AutoGenerateColumns = False
            Me.nominasDgv.DataSource = bsNominas

            Me.nombreTxt.DataBindings.Clear()
            Me.idDealerTxt.DataBindings.Clear()
            Me.dealerTxt.DataBindings.Clear()

            Me.direccionTxt.DataBindings.Clear()

            Me.idCargoTxt.DataBindings.Clear()
            Me.cargoTxt.DataBindings.Clear()
            Me.centroCostosTxt.DataBindings.Clear()

            Me.idDepartamentoTxt.DataBindings.Clear()
            Me.departamentoTxt.DataBindings.Clear()
            Me.fechaIngTxt.DataBindings.Clear()

            Me.duiTxt.DataBindings.Clear()
            Me.telefonoTxt.DataBindings.Clear()
            Me.codigoEmpleadoTxt.DataBindings.Clear()

            Me.nombreTxt.DataBindings.Add("text", bsNominas, "NombreCompleto", True, DataSourceUpdateMode.OnPropertyChanged)
            Me.idDealerTxt.DataBindings.Add("text", bsNominas, "Dealer", True, DataSourceUpdateMode.OnPropertyChanged)
            Me.dealerTxt.DataBindings.Add("text", bsNominas, "DealerNombre", True, DataSourceUpdateMode.OnPropertyChanged)

            Me.direccionTxt.DataBindings.Add("text", bsNominas, "Direccion", True, DataSourceUpdateMode.OnPropertyChanged)

            Me.idCargoTxt.DataBindings.Add("text", bsNominas, "CargoDesempeñado", True, DataSourceUpdateMode.OnPropertyChanged)
            Me.cargoTxt.DataBindings.Add("text", bsNominas, "CargoNombre", True, DataSourceUpdateMode.OnPropertyChanged)
            Me.centroCostosTxt.DataBindings.Add("text", bsNominas, "CCosto", True, DataSourceUpdateMode.OnPropertyChanged)

            Me.idDepartamentoTxt.DataBindings.Add("text", bsNominas, "Departamento", True, DataSourceUpdateMode.OnPropertyChanged)
            Me.departamentoTxt.DataBindings.Add("text", bsNominas, "DepartamentoNombre", True, DataSourceUpdateMode.OnPropertyChanged)
            Me.fechaIngTxt.DataBindings.Add("text", bsNominas, "FechaIngreso", True, DataSourceUpdateMode.OnPropertyChanged)

            Me.duiTxt.DataBindings.Add("text", bsNominas, "DUI", True, DataSourceUpdateMode.OnPropertyChanged)
            Me.telefonoTxt.DataBindings.Add("text", bsNominas, "Telefono", True, DataSourceUpdateMode.OnPropertyChanged)
            Me.codigoEmpleadoTxt.DataBindings.Add("text", bsNominas, "Numero", True, DataSourceUpdateMode.OnPropertyChanged)

        Catch ex As Exception
            MessageBox.Show(ex.Message, "FrmBuscarNomina.cargar_propietarios - Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub buscarBtn_Click(sender As Object, e As EventArgs) Handles buscarBtn.Click
        cargar_propietarios(Me.busquedaTxt.Text, Me.filtroCbx.SelectedIndex)
    End Sub

    Private Sub seleccionarBtn_Click(sender As Object, e As EventArgs) Handles seleccionarBtn.Click
        If Integer.TryParse(codigoEmpleadoTxt.Text, numero) Then
            EmpleadoSeleccionado = accesoDatos.ObtenerNominaEmpleado(numero)

            If EmpleadoSeleccionado IsNot Nothing Then
                Me.DialogResult = DialogResult.OK
                Me.Close()
            Else
                MessageBox.Show("Empleado no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("Debe seleccionar un registro", "Seleccione", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub cancelarBtn_Click(sender As Object, e As EventArgs) Handles cancelarBtn.Click
        Me.Close()
    End Sub
End Class