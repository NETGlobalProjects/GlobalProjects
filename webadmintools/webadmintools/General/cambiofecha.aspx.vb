Public Class CambioFecha
    Inherits System.Web.UI.Page
    Dim odtsND As New dtsNETDATA

    Dim seguridadAdapter As New dtsNETDATATableAdapters.tbSeguridadTableAdapter
    Dim DealerAdapter As New dtsNETDATATableAdapters.DealerTableAdapter
    Dim UsuariosGuiaAdapter As New dtsNETDATATableAdapters.GuiaDigitacionTableAdapter
    Dim UsuariosGuiaAdminAdapter As New dtsNETDATATableAdapters.GuiaDigitacionAdminTableAdapter
    Dim LogAdminAdapter As New dtsNETDATATableAdapters.LogsAdminToolTableAdapter
    Dim DerechosMenuAdapter As New dtsNETDATATableAdapters.DerechosMenuTableAdapter
    Dim listacompletausuariosAdapter As New dtsNETDATATableAdapters.ListaUsuariosCompletaTableAdapter
    Dim listasegunJefeAdapter As New dtsNETDATATableAdapters.ListaUsuariosSegunJefeTableAdapter
    Private Sub CambioFecha_Init(sender As Object, e As EventArgs) Handles Me.Init
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
        Me.Response.Redirect("~/submenu/general.aspx", False)
    End Sub
    Protected Sub dealerASPxComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles dealerASPxComboBox1.SelectedIndexChanged
        Try
            If RTrim(Session("UserAdmin")) = "ADMIN" Then
                If mostrarpornombreASPxCheckBox1.CheckState = DevExpress.Web.CheckState.Checked Then
                    Me.usuariosASPxComboBox1.DataSource = UsuariosGuiaAdminAdapter.GetData(Me.dealerASPxComboBox1.SelectedItem.Value)
                    Me.usuariosASPxComboBox1.ValueField = "Usuario"
                    Me.usuariosASPxComboBox1.TextField = "Nombre"
                    Me.usuariosASPxComboBox1.DataBind()
                Else
                    Me.usuariosASPxComboBox1.DataSource = UsuariosGuiaAdminAdapter.GetData(Me.dealerASPxComboBox1.SelectedItem.Value)
                    Me.usuariosASPxComboBox1.ValueField = "Usuario"
                    Me.usuariosASPxComboBox1.TextField = "Usuario"
                    Me.usuariosASPxComboBox1.DataBind()
                End If

            Else
                If mostrarpornombreASPxCheckBox1.CheckState = DevExpress.Web.CheckState.Checked Then
                    Me.usuariosASPxComboBox1.DataSource = UsuariosGuiaAdapter.GetData(Session("UserAdmin"), Me.dealerASPxComboBox1.SelectedItem.Value)
                    Me.usuariosASPxComboBox1.ValueField = "Usuario"
                    Me.usuariosASPxComboBox1.TextField = "Nombre"
                    Me.usuariosASPxComboBox1.DataBind()
                Else
                    Me.usuariosASPxComboBox1.DataSource = UsuariosGuiaAdapter.GetData(Session("UserAdmin"), Me.dealerASPxComboBox1.SelectedItem.Value)
                    Me.usuariosASPxComboBox1.ValueField = "Usuario"
                    Me.usuariosASPxComboBox1.TextField = "Usuario"
                    Me.usuariosASPxComboBox1.DataBind()
                End If

            End If
        Catch ex As Exception
            Me.lbnotificaciones.Text = ex.Message
        End Try
    End Sub
    Protected Sub usuariosASPxComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles usuariosASPxComboBox1.SelectedIndexChanged
        If Me.todasempresasASPxCheckBox1.CheckState = DevExpress.Web.CheckState.Unchecked Then
            Me.fechaASPxDateEdit1.Date = UsuariosGuiaAdapter.GetFecha(Me.usuariosASPxComboBox1.SelectedItem.Value, Me.dealerASPxComboBox1.SelectedItem.Value)
            Session("oldfecha") = Me.fechaASPxDateEdit1.Text
        End If
    End Sub
    Protected Sub mostrarpornombreASPxCheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles mostrarpornombreASPxCheckBox1.CheckedChanged
        dealerASPxComboBox1_SelectedIndexChanged(sender, e)
    End Sub

    Protected Sub cambiarASPxButton1_Click(sender As Object, e As EventArgs) Handles cambiarASPxButton1.Click
        Try
           
            If (DatePart(DateInterval.Month, Today) <> DatePart(DateInterval.Month, CDate(Me.fechaASPxDateEdit1.Text)) Or DatePart(DateInterval.Year, Today) <> DatePart(DateInterval.Year, CDate(Me.fechaASPxDateEdit1.Text))) Then

                If MODOASPxCheckBox1.CheckState = DevExpress.Web.CheckState.Unchecked Then
                    If DerechosMenuAdapter.GetRestriccionMes(RTrim(Session("usuario")), "General", "cambiofecha") = True Then
                        Dim mensaje As String = "alert('ERROR: NO ESTA AUTORIZADO PARA CAMBIAR FECHA DE OTRO MES/AÑO');"
                        ScriptManager.RegisterStartupScript(Me, Me.GetType(), "newWindow", mensaje, True)
                    Else
                        If IsDate(Me.fechaASPxDateEdit1.Text) Then
                            Try
                                UsuariosGuiaAdapter.DisableTrigger()
                                If todasempresasASPxCheckBox1.CheckState = DevExpress.Web.CheckState.Checked Then
                                    cambiarfecha(False)
                                Else
                                    cambiarfecha(True)
                                End If

                                UsuariosGuiaAdapter.EnableTrigger()
                                Me.usuariosASPxComboBox1.Text = ""
                                Me.fechaASPxDateEdit1.Text = ""
                                Dim mensaje As String = "alert('EXITO: CAMBIO REALIZADO CORRECTAMENTE');"
                                ScriptManager.RegisterStartupScript(Me, Me.GetType(), "newWindow", mensaje, True)
                            Catch ex As Exception
                                Dim mensaje As String = "alert('ERROR: " & ex.Message & "');"
                                ScriptManager.RegisterStartupScript(Me, Me.GetType(), "newWindow", mensaje, True)
                            End Try

                        Else
                            Dim mensaje As String = "alert('ERROR: EL FORMATO DE FECHA NO ES CORRECTO');"
                            ScriptManager.RegisterStartupScript(Me, Me.GetType(), "newWindow", mensaje, True)
                        End If
                    End If
                   
                Else
                    If IsDate(Me.fechaASPxDateEdit1.Text) Then
                        Try
                            UsuariosGuiaAdapter.DisableTrigger()
                            If todasempresasASPxCheckBox1.CheckState = DevExpress.Web.CheckState.Checked Then
                                cambiarfecha(False)
                            Else
                                cambiarfecha(True)
                            End If
                            UsuariosGuiaAdapter.EnableTrigger()
                            Me.usuariosASPxComboBox1.Text = ""
                            Me.fechaASPxDateEdit1.Text = ""
                            Dim mensaje As String = "alert('EXITO: CAMBIO REALIZADO CORRECTAMENTE');"
                            ScriptManager.RegisterStartupScript(Me, Me.GetType(), "newWindow", mensaje, True)
                        Catch ex As Exception
                            Dim mensaje As String = "alert('ERROR: " & ex.Message & "');"
                            ScriptManager.RegisterStartupScript(Me, Me.GetType(), "newWindow", mensaje, True)
                        End Try

                    Else
                        Dim mensaje As String = "alert('ERROR: EL FORMATO DE FECHA NO ES CORRECTO');"
                        ScriptManager.RegisterStartupScript(Me, Me.GetType(), "newWindow", mensaje, True)
                    End If
                End If

            Else
                If IsDate(Me.fechaASPxDateEdit1.Text) Then
                    Try
                        If todasempresasASPxCheckBox1.CheckState = DevExpress.Web.CheckState.Checked Then
                            cambiarfecha(False)
                        Else
                            cambiarfecha(True)
                        End If
                        Me.usuariosASPxComboBox1.Text = ""
                        Me.fechaASPxDateEdit1.Text = ""
                        Dim mensaje As String = "alert('EXITO: CAMBIO REALIZADO CORRECTAMENTE');"
                        ScriptManager.RegisterStartupScript(Me, Me.GetType(), "newWindow", mensaje, True)
                    Catch ex As Exception
                        Dim mensaje As String = "alert('ERROR: " & ex.Message & "');"
                        ScriptManager.RegisterStartupScript(Me, Me.GetType(), "newWindow", mensaje, True)
                    End Try

                Else
                    Dim mensaje As String = "alert('ERROR: EL FORMATO DE FECHA NO ES CORRECTO');"
                    ScriptManager.RegisterStartupScript(Me, Me.GetType(), "newWindow", mensaje, True)
                End If
            End If

        Catch ex As Exception
            Dim mensaje As String = "alert('ERROR: " & ex.Message & "');"
            ScriptManager.RegisterStartupScript(Me, Me.GetType(), "newWindow", mensaje, True)
        End Try
    End Sub
    Sub cambiarfecha(porEmpresa As Boolean)
        If porEmpresa = True Then
            
            UsuariosGuiaAdapter.ActualizarFecha(Me.fechaASPxDateEdit1.Text, Me.usuariosASPxComboBox1.SelectedItem.Value, Me.dealerASPxComboBox1.SelectedItem.Value)
            LogAdminAdapter.Insertar(Today, Format(TimeOfDay, "HH:mm:ss"), Session("usuario"), "Cambio de Fecha/por Empresa", "A Usuario: " & Me.usuariosASPxComboBox1.SelectedItem.Value & " FechaAnterior: " & Session("oldfecha") & "; fechanueva: " & Me.fechaASPxDateEdit1.Text, Me.dealerASPxComboBox1.SelectedItem.Value, "SAL")
        Else
            UsuariosGuiaAdapter.DisableTrigger()
            UsuariosGuiaAdapter.ActualizarTodasEmpresas(Me.fechaASPxDateEdit1.Text, Me.usuariosASPxComboBox1.SelectedItem.Value)
            UsuariosGuiaAdapter.EnableTrigger()
            LogAdminAdapter.Insertar(Today, Format(TimeOfDay, "HH:mm:ss"), Session("usuario"), "Cambio de Fecha/Todas Empresa", "A Usuario: " & Me.usuariosASPxComboBox1.SelectedItem.Value & "; fechanueva: " & Me.fechaASPxDateEdit1.Text, 0, "SAL")
        End If

    End Sub
    Protected Sub MODOASPxCheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles MODOASPxCheckBox1.CheckedChanged
        If UCase((RTrim(Session("UserAdmin")))) <> "ADMIN" Then
            Dim mensaje As String = "alert('ERROR: NO ESTA AUTORIZADO A CAMBIARSE A MODO ADMINISTRADOR');"
            ScriptManager.RegisterStartupScript(Me, Me.GetType(), "newWindow", mensaje, True)
            Me.MODOASPxCheckBox1.CheckState = DevExpress.Web.CheckState.Unchecked
        End If
    End Sub

    Protected Sub todasempresasASPxCheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles todasempresasASPxCheckBox1.CheckedChanged
        If Me.todasempresasASPxCheckBox1.Checked = True Then
            Me.dealerASPxComboBox1.Enabled = False
            Me.cargarusuarioscompleta()
        Else
            Me.dealerASPxComboBox1.Enabled = True
            Me.usuariosASPxComboBox1.DataSource = Nothing
            Me.usuariosASPxComboBox1.DataBind()
        End If


    End Sub
    Sub cargarusuarioscompleta()

        If UCase((RTrim(Session("UserAdmin")))) <> "ADMIN" Then
           

            Me.usuariosASPxComboBox1.DataSource = listasegunJefeAdapter.GetData(Session("UserERP"))
            Me.usuariosASPxComboBox1.ValueField = "usuario"
            Me.usuariosASPxComboBox1.TextField = "usuario"
            Me.usuariosASPxComboBox1.DataBind()
        Else
            Me.usuariosASPxComboBox1.DataSource = listacompletausuariosAdapter.GetData
            Me.usuariosASPxComboBox1.ValueField = "usuario"
            Me.usuariosASPxComboBox1.TextField = "usuario"
            Me.usuariosASPxComboBox1.DataBind()
        End If
        
    End Sub
End Class