Public Class cambioliquidador
    Inherits System.Web.UI.Page
    Dim odtsND As New dtsNETDATA
    Dim DealerAdapter As New dtsNETDATATableAdapters.DealerTableAdapter
    Dim sucursalAdapter As New dtsNETDATATableAdapters.SucursalTableAdapter
    Dim LogAdminAdapter As New dtsNETDATATableAdapters.LogsAdminToolTableAdapter

    Dim guiaProveeduriaAdapter As New dtsNETDATATableAdapters.GuiaDigitacionProveeduriaTableAdapter
    Dim liquidadoresAdapter As New dtsNETDATATableAdapters.LiquidadoresdeCajaTableAdapter
    Private Sub cambioliquidador_Init(sender As Object, e As EventArgs) Handles Me.Init
        Me.dealerASPxComboBox1.DataSource = DealerAdapter.GetData()
        Me.dealerASPxComboBox1.ValueField = "Codigo"
        Me.dealerASPxComboBox1.TextField = "Nombre"
        Me.dealerASPxComboBox1.DataBind()
    End Sub
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Session("usuario") = "" Then
            Response.Redirect("~/default.aspx")
        End If
    End Sub
    Protected Sub regresarASPxButton1_Click(sender As Object, e As EventArgs) Handles regresarASPxButton1.Click
        Me.Response.Redirect("~/proveeduria/proveeduria.aspx")
    End Sub
   
    Private Sub dealerASPxComboBox1_selectedindexchanged(sender As Object, e As EventArgs) Handles dealerASPxComboBox1.SelectedIndexChanged
        Me.liquidadoresASPxComboBox1.Text = ""
        Me.nombrenuevoliqASPxLabel1.Text = ""

        Me.usuariosASPxComboBox1.DataSource = guiaProveeduriaAdapter.GetData(Me.dealerASPxComboBox1.SelectedItem.Value)
        Me.usuariosASPxComboBox1.ValueField = "Usuario"
        Me.usuariosASPxComboBox1.TextField = "Usuario"
        Me.usuariosASPxComboBox1.DataBind()

        Me.liquidadoresASPxComboBox1.DataSource = liquidadoresAdapter.GetData(Session("usuario"), Me.dealerASPxComboBox1.SelectedItem.Value)
        Me.liquidadoresASPxComboBox1.ValueField = "Codigo"
        Me.liquidadoresASPxComboBox1.TextField = "Codigo"
        Me.liquidadoresASPxComboBox1.DataBind()
    End Sub

    Protected Sub usuariosASPxComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles usuariosASPxComboBox1.SelectedIndexChanged
        Me.liquidadoractualASPxTextBox1.Text = guiaProveeduriaAdapter.GetLiquidActual(Me.dealerASPxComboBox1.SelectedItem.Value, Me.usuariosASPxComboBox1.SelectedItem.Value)
        Me.nombreliqactualASPxLabel1.Text = liquidadoresAdapter.GetNombreLiquidador(Me.dealerASPxComboBox1.SelectedItem.Value, Me.liquidadoractualASPxTextBox1.Text)
    End Sub

   
    Private Sub liquidadoresASPxComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles liquidadoresASPxComboBox1.SelectedIndexChanged
        Me.nombrenuevoliqASPxLabel1.Text = liquidadoresAdapter.GetNombreLiquidador(Me.dealerASPxComboBox1.SelectedItem.Value, Me.liquidadoresASPxComboBox1.SelectedItem.Value)
    End Sub

    Protected Sub guardarASPxButton1_Click(sender As Object, e As EventArgs) Handles guardarASPxButton1.Click
        Try
            If Me.liquidadoresASPxComboBox1.Text = "" Then
                Dim mensaje As String = "alert('ERROR: DEBE DE SELECCIONAR EL LIQUIDADOR AL QUE DESEA CAMBIARSE');"
                ScriptManager.RegisterStartupScript(Me, Me.GetType(), "newWindow", mensaje, True)
            ElseIf RTrim(Me.liquidadoractualASPxTextBox1.Text) = RTrim(Me.liquidadoresASPxComboBox1.SelectedItem.Value) Then
                Dim mensaje As String = "alert('ERROR: HA ELEGIDO EL MISMO LIQUIDADOR QUE TIENE ACTUALMENTE, PRO FAVOR SELECCIONE UNO DIFERENTE');"
                ScriptManager.RegisterStartupScript(Me, Me.GetType(), "newWindow", mensaje, True)
            Else
                Me.guiaProveeduriaAdapter.ActualizarLiquidador(Me.liquidadoresASPxComboBox1.SelectedItem.Value, "SAL", Me.dealerASPxComboBox1.SelectedItem.Value, RTrim(Me.usuariosASPxComboBox1.SelectedItem.Value))
                Me.liquidadoresAdapter.ActualizarLiquidador(Me.usuariosASPxComboBox1.SelectedItem.Value, "SAL", Me.dealerASPxComboBox1.SelectedItem.Value, RTrim(Me.liquidadoresASPxComboBox1.SelectedItem.Value))
                Me.LogAdminAdapter.Insertar(Today, Format(TimeOfDay, "HH:mm:ss"), Session("usuario"), "Cambio de liquidador", "A Usuario: " & Me.usuariosASPxComboBox1.SelectedItem.Value & "; Liquidador Actual: " & Me.liquidadoractualASPxTextBox1.Text & "; Nuevo Liquidador: " & Me.liquidadoresASPxComboBox1.SelectedItem.Value, Me.dealerASPxComboBox1.SelectedItem.Value, "SAL")
                Me.liquidadoractualASPxTextBox1.Text = ""
                Me.nombreliqactualASPxLabel1.Text = ""
                Me.liquidadoresASPxComboBox1.Text = ""
                Me.nombrenuevoliqASPxLabel1.Text = ""
                Dim mensaje As String = "alert('EXITO: CAMBIO REALIZADO CORRECTAMENTE');"
                ScriptManager.RegisterStartupScript(Me, Me.GetType(), "newWindow", mensaje, True)
            End If
    
        Catch ex As Exception
            Dim mensaje As String = "alert('ERROR: " & ex.Message & "');"
            ScriptManager.RegisterStartupScript(Me, Me.GetType(), "newWindow", mensaje, True)


        End Try
    End Sub
End Class