<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="listar_empresas.aspx.cs" Inherits="Dulceria3C.Catalogos.Empresas.listar_empresas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
        <div class="container">
    <div class="row">
        <h3>Lista de Empresas</h3>
        <p>
            <asp:Button ID="Insertar" runat="server" Text="Agregar" CssClass="btn btn-primary btn-xs" Width="85px" OnClick="Insertar_Click" />
        </p>
    </div>
    <div class="row">
        <asp:GridView ID="GVEmpresas" runat="server" CssClass="table table-bordered table-striped table-condensed" AutoGenerateColumns="false" DataKeyNames="Id_Empresa" OnRowDeleting="GVEmpresas_RowDeleting" OnRowCommand="GVEmpresas_RowCommand" OnRowEditing="GVEmpresas_RowEditing" OnRowUpdating="GVEmpresas_RowUpdating" OnRowCancelingEdit="GVEmpresas_RowCancelingEdit">
            <Columns>
                <asp:BoundField DataField="Id_Empresa" HeaderText="Numero de Empresa" ItemStyle-Width="85px" ReadOnly="true"></asp:BoundField>
                <asp:BoundField DataField="Nombre" HeaderText="Nombre" ItemStyle-Width="85px"></asp:BoundField>
                <asp:BoundField DataField="Direccion" HeaderText="Direccion" ItemStyle-Width="85px"></asp:BoundField>
                <asp:BoundField DataField="Colonia" HeaderText="Colonia" ItemStyle-Width="85px"></asp:BoundField>
                <asp:BoundField DataField="Municipio_Delegacion" HeaderText="Municipio_Delegacion" ItemStyle-Width="85px"></asp:BoundField>
                <asp:BoundField DataField="Estado" HeaderText="Estado" ItemStyle-Width="85px"></asp:BoundField>
                <asp:BoundField DataField="Email" HeaderText="Email" ItemStyle-Width="85px"></asp:BoundField>
                <asp:BoundField DataField="Cel" HeaderText="Cel" ItemStyle-Width="85px"></asp:BoundField>
                <asp:BoundField DataField="Descripcion" HeaderText="Descripcion" ItemStyle-Width="85px"></asp:BoundField>
                <asp:ButtonField ButtonType="Button" CommandName="Select" HeaderText="1" text="Ver detalles" ControlStyle-CssClass="btn btn-primary btn-xs" ItemStyle-Width="50px"></asp:ButtonField>
                <asp:CommandField ButtonType="Button" HeaderText="2" ShowEditButton="true" ShowHeader="true" ControlStyle-CssClass="btn btn-warning btn-xs" ItemStyle-Width="50px"></asp:CommandField>
                <asp:CommandField ButtonType="Button" HeaderText="3" ShowDeleteButton="true" ShowHeader="true" ControlStyle-CssClass="btn btn-danger btn-xs" ItemStyle-Width="50px"></asp:CommandField>

            </Columns>
        </asp:GridView>

    </div>
</div>
</asp:Content>
