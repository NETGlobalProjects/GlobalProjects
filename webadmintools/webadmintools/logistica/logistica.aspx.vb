Public Class logistica
    Inherits System.Web.UI.Page
    Dim odtsND As New dtsNETDATA
    Dim derechosMenuAdapter As New dtsNETDATATableAdapters.DerechosMenuTableAdapter
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Session("usuario") = "" Then
            Response.Redirect("~/default.aspx")
        Else
            Me.cambioestatustiketsASPxButton1.Enabled = False
            Me.anulardespachoASPxButton1.Enabled = False
            derechosMenuAdapter.Fill(odtsND.DerechosMenu, Session("usuario"))
            For i As Integer = 0 To odtsND.DerechosMenu.Rows.Count - 1

                If RTrim(UCase((odtsND.DerechosMenu.Rows(i).Item(2)))) = "ABRIRDESPACHO" Then
                    Me.cambioestatustiketsASPxButton1.Enabled = True

                End If
                If RTrim(UCase((odtsND.DerechosMenu.Rows(i).Item(2)))) = "ANULARDESPACHO" Then
                    Me.anulardespachoASPxButton1.Enabled = True

                End If
            Next
        End If
    End Sub

    Protected Sub ASPxButton3_Click(sender As Object, e As EventArgs) Handles ASPxButton3.Click
        Session.Abandon()
        Response.Redirect("~/default.aspx")
    End Sub

    Protected Sub regresarASPxButton1_Click(sender As Object, e As EventArgs) Handles regresarASPxButton1.Click
        Me.Response.Redirect("~/menu.aspx")
    End Sub

    Protected Sub cambioestatustiketsASPxButton1_Click(sender As Object, e As EventArgs) Handles cambioestatustiketsASPxButton1.Click
        Me.Response.Redirect("~/logistica/abrirdespacho.aspx")
    End Sub

    Protected Sub anulardespachoASPxButton1_Click(sender As Object, e As EventArgs) Handles anulardespachoASPxButton1.Click
        Me.Response.Redirect("~/logistica/anulardespacho.aspx")
    End Sub
End Class