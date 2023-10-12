Public Class menu
    Inherits System.Web.UI.Page
    Dim odtsND As New dtsNETDATA
    Dim derechosMenuAdapter As New dtsNETDATATableAdapters.DerechosMenuTableAdapter

    Private Sub menu_Init(sender As Object, e As EventArgs) Handles Me.Init

    End Sub
    Protected Sub ASPxButton3_Click(sender As Object, e As EventArgs) Handles ASPxButton3.Click
        Session.Abandon()
        Response.Redirect("default.aspx")
    End Sub

    Protected Sub generalASPxButton1_Click(sender As Object, e As EventArgs) Handles generalASPxButton1.Click
        Me.Response.Redirect("~/submenu/general.aspx")
    End Sub

    Protected Sub facturacionASPxButton2_Click(sender As Object, e As EventArgs) Handles facturacionASPxButton2.Click
        Response.Redirect("~/facturacion/facturacion.aspx")
    End Sub

    Protected Sub logisticaASPxButton1_Click(sender As Object, e As EventArgs) Handles logisticaASPxButton1.Click
        Me.Response.Redirect("~/logistica/logistica.aspx")
    End Sub

    Protected Sub proveeduriaASPxButton1_Click(sender As Object, e As EventArgs) Handles proveeduriaASPxButton1.Click
        Me.Response.Redirect("~/proveeduria/proveeduria.aspx")
    End Sub

    Private Sub menu_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Session("usuario") = "" Then
            Response.Redirect("default.aspx")
        Else

            Me.logisticaASPxButton1.Enabled = False
            Me.facturacionASPxButton2.Enabled = False
            Me.generalASPxButton1.Enabled = False
            Me.proveeduriaASPxButton1.Enabled = False
            Me.cuentasporcobrarASPxButton1.Enabled = False

            derechosMenuAdapter.Fill(odtsND.DerechosMenu, Session("usuario"))

            For i As Integer = 0 To odtsND.DerechosMenu.Rows.Count - 1


                If RTrim(UCase((odtsND.DerechosMenu.Rows(i).Item(1)))) = "LOGISTICA" Then
                    Me.logisticaASPxButton1.Enabled = True
                ElseIf RTrim(UCase((odtsND.DerechosMenu.Rows(i).Item(1)))) = "FACTURACION" Then
                    Me.facturacionASPxButton2.Enabled = True
                ElseIf RTrim(UCase((odtsND.DerechosMenu.Rows(i).Item(1)))) = "GENERAL" Then
                    Me.generalASPxButton1.Enabled = True
                ElseIf RTrim(UCase((odtsND.DerechosMenu.Rows(i).Item(1)))) = "PROVEEDURIA" Then
                    Me.proveeduriaASPxButton1.Enabled = True
                ElseIf RTrim(UCase((odtsND.DerechosMenu.Rows(i).Item(1)))) = "CREDITOSCOBROS" Then
                    Me.cuentasporcobrarASPxButton1.Enabled = True

                End If



            Next
        End If
    End Sub

    Protected Sub cuentasporcobrarASPxButton1_Click(sender As Object, e As EventArgs) Handles cuentasporcobrarASPxButton1.Click
        Me.Response.Redirect("~/cxc/cxcmenu.aspx")
    End Sub
End Class