Public Class Emma
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        'Querystring

        Session("EMMA") = "Hola, cómo va?"

        If Not Page.IsPostBack Then
            lblPrincipal.Text = Request.QueryString("texto") & " - " & Request.QueryString("otrotexto") & " - " & Request.QueryString("id")
        End If

    End Sub

    Private Sub cmdCambiar_Click(sender As Object, e As EventArgs) Handles cmdCambiar.Click
        lblPrincipal.Text = TextBox1.Text
    End Sub

    Private Sub cmdBoton2_Click(sender As Object, e As EventArgs) Handles cmdBoton2.Click
        lblPrincipal.Text = "Hola Che"
    End Sub
End Class