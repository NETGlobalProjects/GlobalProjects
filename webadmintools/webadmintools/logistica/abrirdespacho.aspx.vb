Public Class Formulario_web1
    Inherits System.Web.UI.Page
    Dim odtsND As New dtsNETDATA
    Dim DealerAdapter As New dtsNETDATATableAdapters.DealerTableAdapter
    Dim sucursalAdapter As New dtsNETDATATableAdapters.SucursalTableAdapter
    Dim LogAdminAdapter As New dtsNETDATATableAdapters.LogsAdminToolTableAdapter


    Dim despachoAdapter As New dtsNETDATATableAdapters.DespachoTableAdapter
    Private Sub Formulario_web1_Init(sender As Object, e As EventArgs) Handles Me.Init
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

    Protected Sub dealerASPxComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles dealerASPxComboBox1.SelectedIndexChanged
        Me.sucursalASPxComboBox1.DataSource = sucursalAdapter.GetData(Me.dealerASPxComboBox1.SelectedItem.Value)
        Me.sucursalASPxComboBox1.ValueField = "Sucursal"
        Me.sucursalASPxComboBox1.TextField = "Nombre"
        Me.sucursalASPxComboBox1.DataBind()
    End Sub

    Protected Sub mostrarASPxButton1_Click(sender As Object, e As EventArgs) Handles mostrarASPxButton1.Click
        Try
            Dim estatus As Boolean = despachoAdapter.GetEstatus(Me.dealerASPxComboBox1.SelectedItem.Value, Me.sucursalASPxComboBox1.SelectedItem.Value, Me.despachoASPxTextBox1.Text)
            Me.despachoAdapter.Fill(odtsND.Despacho, Me.dealerASPxComboBox1.SelectedItem.Value, Me.sucursalASPxComboBox1.SelectedItem.Value, Me.despachoASPxTextBox1.Text)

            'Dim mensaje As String = "alert('ERROR: " & estatus & "');"
            'ScriptManager.RegisterStartupScript(Me, Me.GetType(), "newWindow", mensaje, True)
            Me.estatusASPxCheckBox1.Checked = despachoAdapter.GetEstatus(Me.dealerASPxComboBox1.SelectedItem.Value, Me.sucursalASPxComboBox1.SelectedItem.Value, Me.despachoASPxTextBox1.Text)
            Me.hechoporLabel.Text = odtsND.Despacho.Rows(0).Item("HechoPor")
            Me.GridView1.AutoGenerateColumns = False
            Me.GridView1.DataSource = odtsND.Despacho
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

    Protected Sub estatusASPxCheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles estatusASPxCheckBox1.CheckedChanged
        If estatusASPxCheckBox1.Checked = True Then
            Me.motivoASPxTextBox1.Enabled = False
        Else
            Me.motivoASPxTextBox1.Enabled = True
            Me.motivoASPxTextBox1.Focus()
        End If
    End Sub

    Protected Sub guardarASPxButton1_Click(sender As Object, e As EventArgs) Handles guardarASPxButton1.Click
        If Me.estatusASPxCheckBox1.Checked = False Then
            If Me.motivoASPxTextBox1.Text <> "" Then
                Me.despachoAdapter.AbrirDespacho("0", "SAL", Me.dealerASPxComboBox1.SelectedItem.Value, Me.sucursalASPxComboBox1.SelectedItem.Value, Me.despachoASPxTextBox1.Text)
                LogAdminAdapter.Insertar(Today, Format(TimeOfDay, "HH:mm:ss"), Session("usuario"), "Abrir Despacho", "Tda: " & Me.sucursalASPxComboBox1.SelectedItem.Value & "; DespachoNo: " & Me.despachoASPxTextBox1.Text & "; Fecha: " & Me.GridView1.Rows(0).Cells("Fecha") & "; Total: " & Me.GridView1.Rows(0).Cells("Total") & "; NoFacturas: " & Me.GridView1.Rows(0).Cells("NoFacturas") & "; Saldo: " & Me.GridView1.Rows(0).Cells("Saldo") & "; HechoPor: " & Me.GridView1.Rows(0).Cells("HechoPor") & "; Motivo: " & Me.motivoASPxTextBox1.Text, Me.dealerASPxComboBox1.SelectedItem.Value, "SAL")
                Dim mensaje As String = "alert('EXITO: SE ABRIO EL CUADRO DE DESPACHO CORRECTAMENTE');"
                ScriptManager.RegisterStartupScript(Me, Me.GetType(), "newWindow", mensaje, True)
                Me.motivoASPxTextBox1.Text = ""
                Me.GridView1.DataSource = Nothing
                Me.GridView1.DataBind()
                Me.guardarASPxButton1.Visible = False
            Else
                Dim mensaje As String = "alert('ERROR: DEBE DE INGRESAR UN MOTIVO PARA ABRIR UN DESPACHO');"
                ScriptManager.RegisterStartupScript(Me, Me.GetType(), "newWindow", mensaje, True)
            End If
        Else
            Dim mensaje As String = "alert('ERROR: NO HA REALIZADO NINGUNA ACCION');"
            ScriptManager.RegisterStartupScript(Me, Me.GetType(), "newWindow", mensaje, True)
        End If
        
    End Sub

    Protected Sub regresarASPxButton1_Click(sender As Object, e As EventArgs) Handles regresarASPxButton1.Click
        Me.Response.Redirect("~/logistica/logistica.aspx")
    End Sub
End Class