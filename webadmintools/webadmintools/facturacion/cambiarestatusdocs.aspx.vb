Imports DevExpress.Web

Public Class cambiarestatusdocs
    Inherits System.Web.UI.Page
    Dim odtsND As New dtsNETDATA
    Dim DealerAdapter As New dtsNETDATATableAdapters.DealerTableAdapter
    Dim sucursalAdapter As New dtsNETDATATableAdapters.SucursalTableAdapter
    Dim LogAdminAdapter As New dtsNETDATATableAdapters.LogsAdminToolTableAdapter

    Dim facturaAdapter As New dtsNETDATATableAdapters.FacturaTableAdapter
    Private Sub cambiarestatusdocs_Init(sender As Object, e As EventArgs) Handles Me.Init
        Me.dealerASPxComboBox1.DataSource = DealerAdapter.GetData()
        Me.dealerASPxComboBox1.ValueField = "Codigo"
        Me.dealerASPxComboBox1.TextField = "Nombre"
        Me.dealerASPxComboBox1.DataBind()
        Me.fechaASPxDateEdit1.Date = DateAdd(DateInterval.Day, 1, Today)
    End Sub
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Session("usuario") = "" Then
            Response.Redirect("~/default.aspx")
        End If
        
    End Sub

    Protected Sub regresarASPxButton1_Click(sender As Object, e As EventArgs) Handles regresarASPxButton1.Click
        Me.Response.Redirect("~/facturacion/facturacion.aspx", False)
    End Sub
    Protected Sub mostrarASPxButton1_Click(sender As Object, e As EventArgs) Handles mostrarASPxButton1.Click
        Try
            facturaAdapter.Fill(odtsND.Factura, fechaASPxDateEdit1.Date, Me.serieASPxTextBox1.Text, Me.vendedorASPxTextBox1.Text, Me.dealerASPxComboBox1.SelectedItem.Value, Me.sucursalASPxComboBox1.SelectedItem.Value)
            
            Me.GridView1.AutoGenerateColumns = False
            Me.GridView1.DataSource = odtsND.Factura
            Me.GridView1.DataBind()
            If Me.GridView1.Rows.Count > 0 Then
                Me.guardarASPxButton1.Visible = True
            Else
                Me.guardarASPxButton1.Visible = False
            End If
        Catch ex As Exception
            Dim mensaje As String = "alert('ERROR: " & ex.Message & "');"
            ScriptManager.RegisterStartupScript(Me, Me.GetType(), "newWindow", mensaje, True)
        End Try
    End Sub
   
   

  
  
    Protected Sub ASPxCheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles ASPxCheckBox1.CheckedChanged
        For i As Integer = 0 To Me.GridView1.Rows.Count - 1
            Me.GridView1.Rows(i).Cells(4).Text = 3
        Next
    End Sub

    Protected Sub guardarASPxButton1_Click(sender As Object, e As EventArgs) Handles guardarASPxButton1.Click
        Try
            For i As Integer = 0 To Me.GridView1.Rows.Count - 1
                facturaAdapter.ActualizarEstatus(Me.GridView1.Rows(i).Cells(4).Text, Me.dealerASPxComboBox1.SelectedItem.Value, Me.GridView1.Rows(i).Cells(0).Text, Me.GridView1.Rows(i).Cells(1).Text, Me.GridView1.Rows(i).Cells(2).Text, "SAL", Me.sucursalASPxComboBox1.SelectedItem.Value)
            Next
            LogAdminAdapter.Insertar(Today, Format(TimeOfDay, "HH:mm:ss"), Session("usuario"), "Cambio de estatus Tikets", "Fecha de Docs: " & Me.fechaASPxDateEdit1.Text & "; Serie Doc: " & Me.serieASPxTextBox1.Text & "; Vendedor: " & Me.vendedorASPxTextBox1.Text & "; Nuevo Estatus: 3", Me.dealerASPxComboBox1.SelectedItem.Value, "SAL")
            Me.serieASPxTextBox1.Text = ""
            Me.vendedorASPxTextBox1.Text = ""
            Me.GridView1.DataSource = Nothing
            Me.GridView1.DataBind()
            Me.guardarASPxButton1.Visible = False
            Dim mensaje As String = "alert('EXITO: CAMBIO REALIZADO CORRECTAMENTE');"
            ScriptManager.RegisterStartupScript(Me, Me.GetType(), "newWindow", mensaje, True)
        Catch ex As Exception
            Dim mensaje As String = "alert('ERROR: " & ex.Message & "');"
            ScriptManager.RegisterStartupScript(Me, Me.GetType(), "newWindow", mensaje, True)
        End Try
    End Sub

    Protected Sub dealerASPxComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles dealerASPxComboBox1.SelectedIndexChanged
        Me.sucursalASPxComboBox1.DataSource = sucursalAdapter.GetData(Me.dealerASPxComboBox1.SelectedItem.Value)
        Me.sucursalASPxComboBox1.ValueField = "Sucursal"
        Me.sucursalASPxComboBox1.TextField = "Nombre"
        Me.sucursalASPxComboBox1.DataBind()
    End Sub
End Class