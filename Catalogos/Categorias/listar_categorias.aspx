<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="listar_categorias.aspx.cs" Inherits="Dulceria3C.Catalogos.Categorias.listar_categorias" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
    <div class="row">
        <h3>Lista de Categorias</h3>
        <p>
            <asp:Button ID="Insertar" runat="server" Text="Agregar" CssClass="btn btn-primary btn-xs" Width="85px" OnClick="Insertar_Click" />
        </p>
    </div>
    <div class="row">
        <asp:GridView ID="GVCategorias" runat="server" CssClass="table table-bordered table-striped table-condensed" AutoGenerateColumns="false" DataKeyNames="Id_Categoria" OnRowDeleting="GVCategorias_RowDeleting" OnRowCommand="GVCategorias_RowCommand" OnRowEditing="GVCategorias_RowEditing" OnRowUpdating="GVCategorias_RowUpdating" OnRowCancelingEdit="GVCategorias_RowCancelingEdit">
            <Columns>
                <asp:BoundField DataField="Id_Categoria" HeaderText="Numero de Categoria" ItemStyle-Width="85px" ReadOnly="true"></asp:BoundField>
                <asp:BoundField DataField="Nombre" HeaderText="Nombre" ItemStyle-Width="85px"></asp:BoundField>
                <asp:BoundField DataField="Descripcion" HeaderText="Descripcion" ItemStyle-Width="85px"></asp:BoundField>
                <asp:ButtonField ButtonType="Button" CommandName="Select" HeaderText="1" text="Ver detalles" ControlStyle-CssClass="btn btn-primary btn-xs" ItemStyle-Width="50px"></asp:ButtonField>
                <asp:CommandField ButtonType="Button" HeaderText="2" ShowEditButton="true" ShowHeader="true" ControlStyle-CssClass="btn btn-warning btn-xs" ItemStyle-Width="50px"></asp:CommandField>
                <asp:CommandField ButtonType="Button" HeaderText="3" ShowDeleteButton="true" ShowHeader="true" ControlStyle-CssClass="btn btn-danger btn-xs" ItemStyle-Width="50px"></asp:CommandField>

            </Columns>
        </asp:GridView>

    </div>
</div>
</asp:Content>
