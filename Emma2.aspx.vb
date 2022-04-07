Public Class Emma2
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        'Querystring

        If Not Page.IsPostBack Then
            lblPrincipal.Text = Request.QueryString("id") & " - " & Session("EMMA")
        End If





    End Sub

End Class