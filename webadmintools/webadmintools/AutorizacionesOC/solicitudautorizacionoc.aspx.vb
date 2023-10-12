Public Class solicitudautorizacionoc
    Inherits System.Web.UI.Page
    Dim odtsNetData As New dtsNETDATA
    Dim OrdenCompraSolicitudAutorizacionTableAdapter As New dtsNETDATATableAdapters.OrdenCompraSolicitudAutorizacionTableAdapter
    Dim DetOrdenCompraSolicitudAutorizacionTableAdapter As New dtsNETDATATableAdapters.DetOrdenCompraSolicitudAutorizacionTableAdapter
    Dim GuiaDigitacionTableAdapter As New dtsNETDATATableAdapters.GuiaDigitacionTableAdapter

    Private Sub Page_Init(sender As Object, e As EventArgs) Handles Me.Init

        cargar()
    End Sub
    Sub cargar()
        Dim IDAutorizacion As Integer = Request.QueryString("idautorizacion")
        Session("autorizacion") = IDAutorizacion
        Try
            OrdenCompraSolicitudAutorizacionTableAdapter.Fill(odtsNetData.OrdenCompraSolicitudAutorizacion, IDAutorizacion)
            DetOrdenCompraSolicitudAutorizacionTableAdapter.Fill(odtsNetData.DetOrdenCompraSolicitudAutorizacion, IDAutorizacion)

            Me.OrdenNoASPxTextBox1.Text = odtsNetData.OrdenCompraSolicitudAutorizacion.Rows(0).Item("OrdenCompra")
            Me.proveedorASPxTextBox1.Text = odtsNetData.OrdenCompraSolicitudAutorizacion.Rows(0).Item("Proveedor")
            Me.fechaocASPxTextBox1.Text = odtsNetData.OrdenCompraSolicitudAutorizacion.Rows(0).Item("FechaOC")
            Me.fechaentregaASPxTextBox1.Text = odtsNetData.OrdenCompraSolicitudAutorizacion.Rows(0).Item("FechaEntrega")
            Me.tipoASPxTextBox2.Text = odtsNetData.OrdenCompraSolicitudAutorizacion.Rows(0).Item("TipoOC")
            Me.solicitadoporASPxTextBox1.Text = odtsNetData.OrdenCompraSolicitudAutorizacion.Rows(0).Item("SolicitadoPor")
            Me.motivoASPxTextBox1.Text = odtsNetData.OrdenCompraSolicitudAutorizacion.Rows(0).Item("Motivo")
            Me.totalordenASPxTextBox1.Text = odtsNetData.OrdenCompraSolicitudAutorizacion.Rows(0).Item("TotalOrden")
            Me.formapagoASPxTextBox1.Text = odtsNetData.OrdenCompraSolicitudAutorizacion.Rows(0).Item("FormaPago")
            Me.diascreditoASPxTextBox1.Text = odtsNetData.OrdenCompraSolicitudAutorizacion.Rows(0).Item("DiasCredito")
            If Me.odtsNetData.OrdenCompraSolicitudAutorizacion.Rows(0).Item("Estado") = "ENV" Then
                Me.aprobadaASPxRadioButton1.Checked = False
                Me.rechazadaASPxRadioButton2.Checked = False
                Me.aprobadaASPxRadioButton1.Enabled = True
                Me.rechazadaASPxRadioButton2.Enabled = True
                Me.APROBADA.Visible = False
                Me.RECHAZADA.Visible = False
                Me.enviarrespuestaButton1.Enabled = True
                Me.comentarioASPxTextBox1.Enabled = True
            ElseIf Me.odtsNetData.OrdenCompraSolicitudAutorizacion.Rows(0).Item("Estado") = "APR" Then
                Me.aprobadaASPxRadioButton1.Checked = True
                Me.rechazadaASPxRadioButton2.Checked = False
                Me.aprobadaASPxRadioButton1.Enabled = False
                Me.rechazadaASPxRadioButton2.Enabled = False
                Me.APROBADA.Visible = True
                Me.RECHAZADA.Visible = False
                Me.enviarrespuestaButton1.Enabled = False
                Me.comentarioASPxTextBox1.Enabled = False
            ElseIf Me.odtsNetData.OrdenCompraSolicitudAutorizacion.Rows(0).Item("Estado") = "REC" Then
                Me.aprobadaASPxRadioButton1.Checked = False
                Me.rechazadaASPxRadioButton2.Checked = True
                Me.aprobadaASPxRadioButton1.Enabled = False
                Me.rechazadaASPxRadioButton2.Enabled = False
                Me.APROBADA.Visible = False
                Me.RECHAZADA.Visible = True
                Me.enviarrespuestaButton1.Enabled = False
                Me.comentarioASPxTextBox1.Enabled = False
            End If
            Me.comentarioASPxTextBox1.Text = RTrim(odtsNetData.OrdenCompraSolicitudAutorizacion.Rows(0).Item("ComentarioAutorizador"))
            Me.usuarioNDASPxTextBox1.Text = RTrim(odtsNetData.OrdenCompraSolicitudAutorizacion.Rows(0).Item("SolicitaAutorizacion"))
            Me.nombresolicitaASPxTextBox1.Text = RTrim(odtsNetData.OrdenCompraSolicitudAutorizacion.Rows(0).Item("NombreSolicitaAutorizacion"))

            Me.ASPxGridView1.DataSource = odtsNetData.DetOrdenCompraSolicitudAutorizacion
            Me.ASPxGridView1.DataBind()

        Catch ex As Exception
            Me.lbMensaje.ForeColor = Drawing.Color.Red
            Me.lbMensaje.Text = "Se produjo el siguiente error: " & ex.Message.ToString
        End Try
    End Sub
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Session("autorizacion") = 0 Then
            Me.Response.Redirect("~/AutorizacionesOC/solicitudautorizacionfinalizada.aspx")
        End If
    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles enviarrespuestaButton1.Click
        Try
            If Me.aprobadaASPxRadioButton1.Checked = False And Me.rechazadaASPxRadioButton2.Checked = False Then
                Dim mensaje As String = "alert('NOTIFICACION: DEBE SELECCIONAR UNA OPCION');"
                ScriptManager.RegisterStartupScript(Me, Me.GetType(), "newWindow", mensaje, True)
            Else
                Dim estado As String, estadocompleto As String
                If aprobadaASPxRadioButton1.Checked = True Then
                    estado = "APRO"
                    estadocompleto = "<td style='background-color:green; color:white; padding=5px;'>APROBADA</td>"
                ElseIf rechazadaASPxRadioButton2.Checked = True Then
                    estado = "REC"
                    estadocompleto = "<td style='background-color:red; color:white; padding=5px;'>RECHAZADA</td>"
                Else
                    estado = "<td style='background-color:orange; color:white; padding=5px;'>PENDIENTE</td>"
                    estadocompleto = "PENDIENTE"
                End If
                OrdenCompraSolicitudAutorizacionTableAdapter.ActualizarEstado(estado, comentarioASPxTextBox1.Text, Session("autorizacion"))
                Dim correo As New Correo
                Dim cuerpo As String

                correo.vAsunto = "Revisada - Solicitud Autorizacion(" & Session("autorizacion") & ")"
                cuerpo = "La sollicitud de autorizacion # " & Session("autorizacion") & ", ha sido revisada"
                cuerpo += "<table cellpadding=0 cellspacing=6>"
                cuerpo += "<tr><td>Orden No.</td><td>:</td><td>" & Me.OrdenNoASPxTextBox1.Text & "</td></tr>"
                cuerpo += "<tr><td>Proveedor</td><td>:</td><td>" & Me.proveedorASPxTextBox1.Text & "</td></tr>"
                cuerpo += "<tr><td>Fecha OC:</td><td>:</td><td>" & Me.fechaocASPxTextBox1.Text & "</td></tr>"
                cuerpo += "<tr><td>Solicitado Por</td><td>:</td><td>" & Me.solicitadoporASPxTextBox1.Text & "</td></tr>"
                cuerpo += "<tr><td>Forma de Pago</td><td>:</td><td>" & Me.formapagoASPxTextBox1.Text & "</td></tr>"
                cuerpo += "<tr><td>Días Crédito</td><td>:</td><td>" & Me.diascreditoASPxTextBox1.Text & "</td></tr>"
                cuerpo += "<tr><td>Solicitó Autorización</td><td>:</td><td>" & RTrim(Me.usuarioNDASPxTextBox1.Text) & " - " & RTrim(nombresolicitaASPxTextBox1.Text) & "</td></tr>"
                cuerpo += "<tr><td>Total OC.</td><td>:</td><td>" & Me.totalordenASPxTextBox1.Text & "</td></tr>"
                cuerpo += "<tr><td>Estado</td><td>:</td>" & estadocompleto & "</tr>"
                cuerpo += "<tr><td>Comentario Autorizador</td><td>:</td><td>" & comentarioASPxTextBox1.Text & "</td></tr>"
                cuerpo += "</table></br>"
                cuerpo += "<i>Aplicativo desarrollado por departamento de sistemas</i>"
                correo.vCuerpo = cuerpo
                correo.vParaNombre = nombresolicitaASPxTextBox1.Text
                correo.vParaCorreo = GuiaDigitacionTableAdapter.GetCorreo(Me.usuarioNDASPxTextBox1.Text)
                Dim cbxcopia As New DropDownList
                cbxcopia.Items.Add("VanessaCastro@globalalimentos.com.sv")
                'cbxcopia.Items.Add("robertogutierrez@globalalimentos.com.sv")
                correo.vCC = cbxcopia
                correo.enviarcorreo()
                Session.Abandon()
                Response.Redirect("~/AutorizacionesOC/solicitudautorizacionfinalizada.aspx", True)
            End If

        Catch ex As Exception
            Me.lbMensaje.ForeColor = Drawing.Color.Red
            Me.lbMensaje.Text = "Se produjo el siguiente error: " & ex.Message.ToString
        End Try
    End Sub

    Protected Sub aprobadaASPxRadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles aprobadaASPxRadioButton1.CheckedChanged
        If Me.aprobadaASPxRadioButton1.CheckState = DevExpress.Web.CheckState.Checked Then
            Me.rechazadaASPxRadioButton2.CheckState = DevExpress.Web.CheckState.Unchecked
        End If
    End Sub
    Protected Sub rechazadaASPxRadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles rechazadaASPxRadioButton2.CheckedChanged
        If Me.rechazadaASPxRadioButton2.CheckState = DevExpress.Web.CheckState.Checked Then
            Me.aprobadaASPxRadioButton1.CheckState = DevExpress.Web.CheckState.Unchecked
        End If
    End Sub
End Class