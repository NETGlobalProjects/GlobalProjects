Imports DevExpress.Web

Public Class pedidosvta
    Inherits System.Web.UI.Page
    Dim odtsND As New dtsNETDATA

    Dim DealerAdapter As New dtsNETDATATableAdapters.DealerTableAdapter
    Dim pedConsulAdap As New dtsNETDATATableAdapters.PedidosVta_ConsultaTableAdapter
    Dim pedidosVtaAdap As New dtsNETDATATableAdapters.PedidoVtaTableAdapter
    Dim LogAdminAdapter As New dtsNETDATATableAdapters.LogsAdminToolTableAdapter

    Private Sub pedidosvta_Init(sender As Object, e As EventArgs) Handles Me.Init
        cargarempresas()
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Session("usuario") = "" Then
            Response.Redirect("~/default.aspx")
        End If
    End Sub
    Sub cargarempresas()
        Try
            Me.dealerASPxComboBox1.DataSource = DealerAdapter.GetData()
            Me.dealerASPxComboBox1.ValueField = "Codigo"
            Me.dealerASPxComboBox1.TextField = "Nombre"
            Me.dealerASPxComboBox1.DataBind()

        Catch ex As Exception
            Dim mensaje As String = "alert('ERROR: " & ex.Message & "');"
            ScriptManager.RegisterStartupScript(Me, Me.GetType(), "newWindow", mensaje, True)
        End Try
    End Sub
    Protected Sub regresarASPxButton1_Click(sender As Object, e As EventArgs) Handles regresarASPxButton1.Click
        Me.Response.Redirect("~/menu.aspx", False)
    End Sub
    Sub cargar(dealer As Integer, pedidono As Integer)
        Try
            pedConsulAdap.Fill(odtsND._PedidosVta_Consulta, dealer, pedidono)
            Me.DataList1.DataSource = odtsND._PedidosVta_Consulta
            Me.DataList1.DataBind()

            Me.resultadosASPxLabel1.Text = Me.DataList1.Items.Count

            For Each i As DataListItem In DataList1.Items
                Dim estatus As ASPxLabel = CType(i.FindControl("estatusactualASPxLabel1"), ASPxLabel)
                Dim chckAprobar As ASPxCheckBox = CType(i.FindControl("aprobarASPxCheckBox1"), ASPxCheckBox)
                If RTrim(estatus.Text) = "Pendiente Autorización" Or RTrim(estatus.Text) = "Rechazado" Then
                    chckAprobar.Enabled = True
                Else
                    chckAprobar.Enabled = False
                End If
            Next
        Catch ex As Exception
            Dim mensaje As String = "alert('ERROR: " & ex.Message & "');"
            ScriptManager.RegisterStartupScript(Me, Me.GetType(), "newWindow", mensaje, True)
        End Try
    End Sub
    Protected Sub ASPxTextBox1_TextChanged(sender As Object, e As EventArgs) Handles pedidonoASPxTextBox1.TextChanged
        cargar(Me.dealerASPxComboBox1.SelectedItem.Value, Me.pedidonoASPxTextBox1.Text)
    End Sub

    Protected Sub cambiarASPxButton1_Click(sender As Object, e As EventArgs) Handles cambiarASPxButton1.Click
        Dim mensaje_error As String = ""
        Try

            For Each i As DataListItem In DataList1.Items

                Dim chckAprobar As ASPxCheckBox = CType(i.FindControl("aprobarASPxCheckBox1"), ASPxCheckBox)
                Dim tdalabel As ASPxLabel = CType(i.FindControl("tdaCodigoASPxLabel1"), ASPxLabel)
                Dim pedidono As ASPxLabel = CType(i.FindControl("pedidonoASPxLabel2"), ASPxLabel)
                Dim tipopedido As ASPxLabel = CType(i.FindControl("tipopedidoASPxLabel1"), ASPxLabel)
                Dim fechapedido As ASPxLabel = CType(i.FindControl("fechaASPxLabel1"), ASPxLabel)
                Dim totalpedido As ASPxLabel = CType(i.FindControl("totalASPxLabel1"), ASPxLabel)
                Dim estatusactualpedido As ASPxLabel = CType(i.FindControl("estatusactualASPxLabel1"), ASPxLabel)

                'Try
                If chckAprobar.CheckState = CheckState.Checked Then
                        pedidosVtaAdap.ActualizarEstatus("Ap", Session("usuario"), "SAL", Me.dealerASPxComboBox1.SelectedItem.Value, RTrim(tdalabel.Text), RTrim(tipopedido.Text), pedidono.Text)
                        If dealerASPxComboBox1.SelectedItem.Value = 0 Then
                            Dim cnx As New SqlClient.SqlConnection(My.MySettings.Default.conNetdata.ToString)
                            Try
                                Dim cmd As New SqlClient.SqlCommand("Proc_DesglocePedido", cnx)
                                cmd.CommandType = CommandType.StoredProcedure
                                cmd.CommandTimeout = 300000
                                cmd.Parameters.Add("@CodPais", SqlDbType.Char, 3).Value = "SAL"
                                cmd.Parameters.Add("@PedidoNo", SqlDbType.Int).Value = dealerASPxComboBox1.SelectedItem.Value
                                cmd.Parameters.Add("@TipoPedido", SqlDbType.Char, 2).Value = tipopedido.Text
                                cmd.Parameters.Add("@FechaPedido", SqlDbType.DateTime).Value = fechapedido.Text
                                cnx.Open()
                                cmd.ExecuteNonQuery()
                                cnx.Close()
                            Catch ex As Exception
                                Dim mensaje As String = "alert('ERROR: SE PRODUJO UN ERROR AL DESGLOSAR EL PEDIDO PEDIDO:  " & ex.Message & " ');"
                                ScriptManager.RegisterStartupScript(Me, Me.GetType(), "newWindow", mensaje, True)
                            Finally
                                If cnx.State = ConnectionState.Open Then
                                    cnx.Close()
                                End If
                            End Try
                        End If
                        LogAdminAdapter.Insertar(Today, Format(TimeOfDay, "HH:mm:ss"), Session("usuario"), "Aprobacion Pedidos", "Tda: " & tdalabel.Text & "; Pedido No: " & pedidono.Text & "; Tipo Pedido: " & tipopedido.Text & ";  Fecha Pedido: " & fechapedido.Text & "; Total: " & totalpedido.Text & "; Estatus Anterior: " & estatusactualpedido.Text & "; Estatus Nuevo: Ap; ", Me.dealerASPxComboBox1.SelectedItem.Value, "SAL")
                        Session("exitosos") += 1
                        Session("pedidosOK") &= pedidono.Text & "; "
                    End If
                'Catch ex As Exception
                '    'Dim mensaje As String = "alert('ERROR: " & ex.Message & "');"
                '    'ScriptManager.RegisterStartupScript(Me, Me.GetType(), "newWindow", mensaje, True)
                '    Session("errores") += 1
                '    Session("pedidoserror") &= pedidono.Text & "; "
                '    mensaje_error += ex.Message
                'End Try

            Next

            If Session("errores") > 0 Then
                Dim mensaje As String = "alert('ERROR: Al actualizar estatus de pedidos: " & Session("pedidoserror") & ", detalle del error: " & mensaje_error & " ');"
                ScriptManager.RegisterStartupScript(Me, Me.GetType(), "newWindow", mensaje, True)
            Else
                Dim mensaje As String = "alert('EXITO: Al actualizar estatus de pedidos: " & Session("pedidosOK") & " ');"
                ScriptManager.RegisterStartupScript(Me, Me.GetType(), "newWindow", mensaje, True)
                cargar(Me.dealerASPxComboBox1.SelectedItem.Value, Me.pedidonoASPxTextBox1.Text)
            End If

        Catch ex As Exception
            Dim mensaje As String = "alert('ERROR: " & ex.Message & ", detalle del error: " & mensaje_error & " ');"
            ScriptManager.RegisterStartupScript(Me, Me.GetType(), "newWindow", mensaje, True)
        End Try
    End Sub

    Protected Sub dealerASPxComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles dealerASPxComboBox1.SelectedIndexChanged
        Me.pedidonoASPxTextBox1.Focus()
    End Sub
End Class