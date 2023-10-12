Public Class proveeduria
    Inherits System.Web.UI.Page
    Dim odtsND As New dtsNETDATA
    Dim DealerAdapter As New dtsNETDATATableAdapters.DealerTableAdapter
    Dim sucursalAdapter As New dtsNETDATATableAdapters.SucursalTableAdapter
    Dim LogAdminAdapter As New dtsNETDATATableAdapters.LogsAdminToolTableAdapter
    Dim derechosMenuAdapter As New dtsNETDATATableAdapters.DerechosMenuTableAdapter
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Session("usuario") = "" Then
            Response.Redirect("~/default.aspx")
        Else
            derechosMenuAdapter.Fill(odtsND.DerechosMenu, Session("usuario"))
            For i As Integer = 0 To odtsND.DerechosMenu.Rows.Count - 1

                If RTrim(UCase((odtsND.DerechosMenu.Rows(i).Item(2)))) = "cambiarliquidador" Then
                    Me.cambioloquidadorASPxButton1.Enabled = True
                End If
            Next
        End If
    End Sub

    Protected Sub regresarASPxButton1_Click(sender As Object, e As EventArgs) Handles regresarASPxButton1.Click
        Me.Response.Redirect("~/menu.aspx")
    End Sub

    Protected Sub ASPxButton3_Click(sender As Object, e As EventArgs) Handles ASPxButton3.Click
        Session.Abandon()
        Response.Redirect("~/default.aspx")
    End Sub

    Protected Sub cambioloquidadorASPxButton1_Click(sender As Object, e As EventArgs) Handles cambioloquidadorASPxButton1.Click
        Me.Response.Redirect("~/proveeduria/cambioliquidador.aspx")
    End Sub
End Class