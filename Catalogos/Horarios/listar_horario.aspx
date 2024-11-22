<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="listar_horario.aspx.cs" Inherits="Dulceria3C.Catalogos.Horarios.listar_horario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
            <div class="container">
    <div class="row">
        <h3>Lista de horarios</h3>
        <p>
            <asp:Button ID="Insertar" runat="server" Text="Agregar" CssClass="btn btn-primary btn-xs" Width="85px" OnClick="Insertar_Click" />
        </p>
    </div>
    <div class="row">
        <asp:GridView ID="GVHorarios" runat="server" CssClass="table table-bordered table-striped table-condensed" AutoGenerateColumns="false" DataKeyNames="Id_Horario" OnRowDeleting="GVHorarios_RowDeleting" OnRowCommand="GVHorarios_RowCommand" OnRowEditing="GVHorarios_RowEditing" OnRowUpdating="GVHorarios_RowUpdating" OnRowCancelingEdit="GVHorarios_RowCancelingEdit">
            <Columns>
                <asp:BoundField DataField="Id_Horario" HeaderText="Numero de Horario" ItemStyle-Width="85px" ReadOnly="true"></asp:BoundField>
                <asp:BoundField DataField="Empresa_id" HeaderText="Empresa" ItemStyle-Width="85px" ></asp:BoundField>
                <asp:BoundField DataField="Descripcion" HeaderText="Descripcion" ItemStyle-Width="85px"></asp:BoundField>
                <asp:BoundField DataField="Horario_Inicio" HeaderText="Horario de Inicio" ItemStyle-Width="85px"></asp:BoundField>
                <asp:BoundField DataField="Horario_fin" HeaderText="Horario de Fin" ItemStyle-Width="85px"></asp:BoundField>
                <asp:ButtonField ButtonType="Button" CommandName="Select" HeaderText="Detalles" text="Ver detalles" ControlStyle-CssClass="btn btn-primary btn-xs" ItemStyle-Width="50px"></asp:ButtonField>
                <asp:CommandField ButtonType="Button" HeaderText="Editar" ShowEditButton="true" ShowHeader="true" ControlStyle-CssClass="btn btn-warning btn-xs" ItemStyle-Width="50px"></asp:CommandField>
                <asp:CommandField ButtonType="Button" HeaderText="Eliminar" ShowDeleteButton="true" ShowHeader="true" ControlStyle-CssClass="btn btn-danger btn-xs" ItemStyle-Width="50px"></asp:CommandField>

            </Columns>
        </asp:GridView>

    </div>
</div>
</asp:Content>
