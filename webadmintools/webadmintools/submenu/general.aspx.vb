Public Class general
    Inherits System.Web.UI.Page
    Dim odtsND As New dtsNETDATA
    Dim derechosMenuAdapter As New dtsNETDATATableAdapters.DerechosMenuTableAdapter

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Session("usuario") = "" Then
            Response.Redirect("~/default.aspx")
        Else
            derechosMenuAdapter.Fill(odtsND.DerechosMenu, Session("usuario"))
            For i As Integer = 0 To odtsND.DerechosMenu.Rows.Count - 1

                If RTrim(UCase((odtsND.DerechosMenu.Rows(i).Item(2)))) = "cambiofecha" Then
                    Me.cambiofechaASPxButton1.Enabled = True
                End If
            Next
        End If
    End Sub

    Protected Sub regresarASPxButton1_Click(sender As Object, e As EventArgs) Handles regresarASPxButton1.Click
        Response.Redirect("~/menu.aspx", True)
    End Sub

    Protected Sub ASPxButton3_Click(sender As Object, e As EventArgs) Handles ASPxButton3.Click
        Session.Abandon()
        Response.Redirect("~/default.aspx")
    End Sub

    Protected Sub cambiofechaASPxButton1_Click(sender As Object, e As EventArgs) Handles cambiofechaASPxButton1.Click
        Me.Response.Redirect("~/General/cambiofecha.aspx")
    End Sub
End Class