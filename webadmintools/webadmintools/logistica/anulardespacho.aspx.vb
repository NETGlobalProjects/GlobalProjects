Public Class anulardespacho
    Inherits System.Web.UI.Page
    Dim odtsND As New dtsNETDATA
    Dim DealerAdapter As dtsNETDATATableAdapters.DealerTableAdapter
    Dim sucursalAdapter As New dtsNETDATATableAdapters.SucursalTableAdapter
    Dim LogAdminAdapter As New dtsNETDATATableAdapters.LogsAdminToolTableAdapter

    Dim despachoAdapter As New dtsNETDATATableAdapters.DespachoTableAdapter

    Private Sub anulardespacho_Init(sender As Object, e As EventArgs) Handles Me.Init
        Me.dealerASPxComboBox1.DataSource = DealerAdapter.GetData()
        Me.dealerASPxComboBox1.ValueField = "Codigo"
        Me.dealerASPxComboBox1.TextField = "Nombre"
        Me.dealerASPxComboBox1.DataBind()
    End Sub
    Protected Sub dealerASPxComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles dealerASPxComboBox1.SelectedIndexChanged
        Me.sucursalASPxComboBox1.DataSource = sucursalAdapter.GetData(Me.dealerASPxComboBox1.SelectedItem.Value)
        Me.sucursalASPxComboBox1.ValueField = "Sucursal"
        Me.sucursalASPxComboBox1.TextField = "Nombre"
        Me.sucursalASPxComboBox1.DataBind()
    End Sub

    Protected Sub regresarASPxButton1_Click(sender As Object, e As EventArgs) Handles regresarASPxButton1.Click
        Me.Response.Redirect("~/logistica/logistica.aspx")
    End Sub

    Protected Sub despachoASPxTextBox1_TextChanged(sender As Object, e As EventArgs) Handles despachoASPxTextBox1.TextChanged
        Try
            If despachoASPxTextBox1.Text <> "" Then
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
                    Me.guardarButton1.Visible = True
                Else
                    Me.guardarButton1.Visible = False
                End If
            End If

        Catch ex As Exception
            Dim mensaje As String = "alert('ERROR: " & ex.Message & "');"
            ScriptManager.RegisterStartupScript(Me, Me.GetType(), "newWindow", mensaje, True)
        End Try
    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles guardarButton1.Click
        If despachoAdapter.GetValorLiquidadoDesp(Me.despachoASPxTextBox1.Text, Me.dealerASPxComboBox1.SelectedItem.Value, Me.sucursalASPxComboBox1.SelectedItem.Value) > 0 Then
            Dim mensaje As String = "alert('ERROR: NO PUEDE ANULAR UN DESPACHO QUE YA TIENE DOCUMENTOS LIQUIDADOS O ANULADOS');"
            ScriptManager.RegisterStartupScript(Me, Me.GetType(), "newWindow", mensaje, True)
        ElseIf RTrim(Me.motivoASPxTextBox1.Text) = "" Then
            Dim mensaje As String = "alert('ERROR: DEBE INGRESAR UN MOTIVO POR EL CUAL SE ANULARÁ EL DESPACHO');"
            ScriptManager.RegisterStartupScript(Me, Me.GetType(), "newWindow", mensaje, True)
            Me.motivoASPxTextBox1.Focus()
        Else
            Dim _con As New SqlClient.SqlConnection(My.MySettings.Default.conNetdata.ToString)

            Dim codigo As Integer
            Dim msj As String
            Try

                Dim cmd As New SqlClient.SqlCommand("dbo.AnularCuadroDespacho", _con)
                cmd.CommandTimeout = 200000
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@CodPais", SqlDbType.Char, 3).Value = "SAL"
                cmd.Parameters.Add("@Dealer", SqlDbType.Int).Value = Me.dealerASPxComboBox1.SelectedItem.Value
                cmd.Parameters.Add("@Tda", SqlDbType.Char, 7).Value = Me.sucursalASPxComboBox1.SelectedItem.Value
                cmd.Parameters.Add("@DespachoNo", SqlDbType.Int).Value = Me.despachoASPxTextBox1.Text
                cmd.Parameters.Add("@Justificacion", SqlDbType.Char, 300).Value = Me.motivoASPxTextBox1.Text
                cmd.Parameters.Add("@Usuario", SqlDbType.Char, 30).Value = Session("usuario")
                Dim lector As SqlClient.SqlDataReader
                _con.Open()
                lector = cmd.ExecuteReader()
                'cmd.ExecuteNonQuery()
                While lector.Read
                    codigo = lector(0)
                    msj = lector(1)
                End While
                _con.Close()

                If codigo = 0 Then
                    Dim mensaje As String = "alert('EXITO: " & UCase(msj) & "');"
                    ScriptManager.RegisterStartupScript(Me, Me.GetType(), "newWindow", mensaje, True)
                    GridView1.DataSource = Nothing
                    GridView1.DataBind()
                    Me.hechoporLabel.Text = ""
                    Me.estatusASPxCheckBox1.CheckState = DevExpress.Web.CheckState.Unchecked
                    Me.despachoASPxTextBox1.Text = ""
                    Me.motivoASPxTextBox1.Text = ""
                ElseIf codigo < 0 Then
                    Dim mensaje As String = "alert('ERROR: " & UCase(msj) & "');"
                    ScriptManager.RegisterStartupScript(Me, Me.GetType(), "newWindow", mensaje, True)
                End If

            Catch ex As Exception
                Dim mensaje As String = "alert('ERROR: " & ex.Message & "');"
                ScriptManager.RegisterStartupScript(Me, Me.GetType(), "newWindow", mensaje, True)
            Finally
                If _con.State = ConnectionState.Open Then
                    _con.Close()
                End If
            End Try

        End If
    End Sub

    Private Sub anulardespacho_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Session("usuario") = "" Then
            Response.Redirect("~/default.aspx")
        End If
    End Sub
End Class