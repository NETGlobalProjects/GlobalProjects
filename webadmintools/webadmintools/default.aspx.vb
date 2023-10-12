Public Class login
    Inherits System.Web.UI.Page
    Dim odtsND As New dtsNETDATA
    Dim seguridadAdapter As New dtsNETDATATableAdapters.tbSeguridadTableAdapter
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub ASPxButton1_Click(sender As Object, e As EventArgs) Handles ASPxButton1.Click
        seguridadAdapter.Fill(odtsND.tbSeguridad, Me.ASPxTextBox1.Text, Me.ASPxTextBox2.Text)
        If odtsND.tbSeguridad.Rows.Count > 0 Then
            Session("usuario") = Me.ASPxTextBox1.Text
            Session("UserERP") = odtsND.tbSeguridad.Rows(0).Item(12)
            Session("UserAdmin") = odtsND.tbSeguridad.Rows(0).Item(13)
            Me.Response.Redirect("menu.aspx")
        Else
            Me.lbinfo.Text = "USUARIO O CONTRASEÑA INCORRECTA"
        End If
    End Sub
End Class