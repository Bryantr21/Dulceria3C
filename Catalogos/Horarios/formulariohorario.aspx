<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="formulariohorario.aspx.cs" Inherits="Dulceria3C.Catalogos.Horarios.formulariohorario" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <div class="row">
            <asp:Label ID="Titulo" runat="server" CssClass="text-center modal-title" Text=""></asp:Label>
            <asp:Label ID="Subtitulo" runat="server" CssClass="text-center modal-title" Text=""></asp:Label>
        </div>
        <div class="row">
            <div class="form-group">
                <asp:Label ID="lblempresa_id" runat="server" Text="Empresa"></asp:Label>
                <asp:DropDownList ID="ddlempresa" runat="server" CssClass="form-control"></asp:DropDownList>

                <asp:Label ID="lbldescripcion" runat="server" Text="Descripcion"></asp:Label>
                <asp:TextBox ID="txtdescripcion" runat="server" CssClass="form-control"></asp:TextBox>

                <asp:Label ID="lblhorario_inicio" runat="server" Text="Horario_Inicio"></asp:Label>
                <asp:TextBox ID="txthorario_inicio" runat="server" CssClass="form-control"></asp:TextBox>

                <asp:Label ID="lblhorario_fin" runat="server" Text="Horario_fin"></asp:Label>
                <asp:TextBox ID="txthorario_fin" runat="server" CssClass="form-control"></asp:TextBox>

                <asp:Button ID="btnguardar" CssClass="btn btn-primary" runat="server" Text="Guardar" OnClick="btnguardar_Click" />
            </div>

        </div>
    </div>
</asp:Content>
