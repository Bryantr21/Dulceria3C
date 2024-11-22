<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="formularioempresa.aspx.cs" Inherits="Dulceria3C.Catalogos.Empresas.formularioempresa" %>

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

                <asp:Label ID="lbldireccion" runat="server" Text="Direccion"></asp:Label>
                <asp:TextBox ID="txtdireccion" runat="server" CssClass="form-control"></asp:TextBox>

                <asp:Label ID="lblcolonia" runat="server" Text="Colonia"></asp:Label>
                <asp:TextBox ID="txtcolonia" runat="server" CssClass="form-control"></asp:TextBox>

                <asp:Label ID="lblmunicipio_delegacion" runat="server" Text="Municipio_Delegacion"></asp:Label>
                <asp:TextBox ID="txtmunicipio_delegacion" runat="server" CssClass="form-control"></asp:TextBox>

                <asp:Label ID="lblestado" runat="server" Text="Estado"></asp:Label>
                <asp:TextBox ID="txtestado" runat="server" CssClass="form-control"></asp:TextBox>

                <asp:Label ID="lblemail" runat="server" Text="Email"></asp:Label>
                <asp:TextBox ID="txtemail" runat="server" CssClass="form-control"></asp:TextBox>

                <asp:Label ID="lblcel" runat="server" Text="Cel"></asp:Label>
                <asp:TextBox ID="txtcel" runat="server" CssClass="form-control"></asp:TextBox>

                <asp:Label ID="lbldescripcion" runat="server" Text="Descripcion"></asp:Label>
                <asp:TextBox ID="txtdescripcion" runat="server" CssClass="form-control"></asp:TextBox>

                <asp:Button ID="btnguardar" CssClass="btn btn-primary" runat="server" Text="Guardar" OnClick="btnguardar_Click" />
            </div>

        </div>
    </div>
</asp:Content>
