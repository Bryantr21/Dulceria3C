<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="listar_personal.aspx.cs" Inherits="Dulceria3C.Catalogos.Personal.listar_personal" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <div class="row">
            <h3>Lista de personal</h3>
            <p>
                <asp:Button ID="Insertar" runat="server" Text="Agregar" CssClass="btn btn-primary btn-xs" Width="85px" OnClick="Insertar_Click" />
            </p>
        </div>
        <div class="row">
            <asp:GridView ID="GVPersonal" runat="server" CssClass="table table-bordered table-striped table-condensed" AutoGenerateColumns="false" DataKeyNames="Id_Persona" OnRowDeleting="GVPersonal_RowDeleting" OnRowCommand="GVPersonal_RowCommand" OnRowEditing="GVPersonal_RowEditing" OnRowUpdating="GVPersonal_RowUpdating" OnRowCancelingEdit="GVPersonal_RowCancelingEdit">
                <Columns>
                    <asp:BoundField DataField="Nombres" HeaderText="Nombre" ItemStyle-Width="85px"></asp:BoundField>
                    <asp:BoundField DataField="Apellido_P" HeaderText="Apellido_P" ItemStyle-Width="85px"></asp:BoundField>
                    <asp:BoundField DataField="Apellido_M" HeaderText="Apellido_M" ItemStyle-Width="85px"></asp:BoundField>
                    <asp:BoundField DataField="Direccion" HeaderText="Direccion" ItemStyle-Width="85px"></asp:BoundField>
                    <asp:BoundField DataField="Colonia" HeaderText="Colonia" ItemStyle-Width="85px"></asp:BoundField>
                    <asp:BoundField DataField="Municipio_Delegacion" HeaderText="Municipio_Delegacion" ItemStyle-Width="85px"></asp:BoundField>
                    <asp:BoundField DataField="Estado" HeaderText="Estado" ItemStyle-Width="85px"></asp:BoundField>
                    <asp:BoundField DataField="CURP" HeaderText="CURP" ItemStyle-Width="85px"></asp:BoundField>
                    <asp:BoundField DataField="Cel" HeaderText="Cel" ItemStyle-Width="85px"></asp:BoundField>
                    <asp:BoundField DataField="Email" HeaderText="Email" ItemStyle-Width="85px"></asp:BoundField>
                    <asp:BoundField DataField="Puesto" HeaderText="Puesto" ItemStyle-Width="85px"></asp:BoundField>
                    <asp:ButtonField ButtonType="Button" CommandName="Select" HeaderText="detalles" Text="Ver detalles" ControlStyle-CssClass="btn btn-primary btn-xs" ItemStyle-Width="50px"></asp:ButtonField>
                    <asp:CommandField ButtonType="Button" HeaderText="Editar" ShowEditButton="true" ShowHeader="true" ControlStyle-CssClass="btn btn-warning btn-xs" ItemStyle-Width="50px"></asp:CommandField>
                    <asp:CommandField ButtonType="Button" HeaderText="Eliminar" ShowDeleteButton="true" ShowHeader="true" ControlStyle-CssClass="btn btn-danger btn-xs" ItemStyle-Width="50px"></asp:CommandField>

                </Columns>
            </asp:GridView>

        </div>
    </div>
</asp:Content>
