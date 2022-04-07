<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="Emma.aspx.vb" Inherits="PruebaEmma.Emma" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">


    <div class="row">
        
        <div class="col-md-4">
            <h2>Formulario</h2>


            <asp:Button ID="cmdCambiar" runat="server" Text="Cambiar Nombre" CssClass="btn-default" />
            <br />

            <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control"></asp:TextBox>

            <asp:Button ID="cmdBoton2" runat="server" CssClass="btn-primary" Text="Boton 2" />
            <br />
            <input id="Text1" type="text" value="Texto html" class="form-control" />
            <br />
            <asp:Label ID="lblPrincipal" runat="server" Text="Emma"></asp:Label>

            <br />
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Emma2.aspx?id=48">Ir a Emma 2</asp:HyperLink>

        </div>
        
    </div>


</asp:Content>
