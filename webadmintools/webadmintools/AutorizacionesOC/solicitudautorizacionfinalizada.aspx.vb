Public Class solicitudautorizacionfinalizada
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            Response.Cache.SetCacheability(HttpCacheability.ServerAndNoCache)
            Response.Cache.SetAllowResponseInBrowserHistory(False)
            Response.Cache.SetNoStore()
        End If

    End Sub

End Class