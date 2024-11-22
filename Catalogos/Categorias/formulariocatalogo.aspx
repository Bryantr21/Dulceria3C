<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="formulariocatalogo.aspx.cs" Inherits="Dulceria3C.Catalogos.Categorias.formulariocatalogo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
    <div class="row">
        <asp:Label ID="Titulo" runat="server" CssClass="text-center modal-title" Text=""></asp:Label>
        <asp:Label ID="Subtitulo" runat="server" CssClass="text-center modal-title" Text=""></asp:Label>
    </div>
    <div class="row">
        <div class="form-group">
            <asp:Label ID="lblnombre" runat="server" Text="Nombre"></asp:Label>
            <asp:TextBox ID="txtnombre" runat="server" CssClass="form-control"></asp:TextBox>

            <asp:Label ID="lbldescripcion" runat="server" Text="Descripcion"></asp:Label>
            <asp:TextBox ID="txtdescripcion" runat="server" CssClass="form-control"></asp:TextBox>

            <asp:Button ID="btnguardar" CssClass="btn btn-primary" runat="server" Text="Guardar" OnClick="btnguardar_Click" />
        </div>

    </div>
</div>
</asp:Content>
