<%@ Page Title="" Language="C#" MasterPageFile="~/page/Adex.Master" AutoEventWireup="true" CodeBehind="frmCliente.aspx.cs" Inherits="Adex.page.frmCliente" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:GridView ID="gv_cliente" runat="server" AutoGenerateColumns="false" OnRowCommand="gv_cliente_RowCommand" DataKeyNames="id_cliente" >
        <Columns>
            <asp:BoundField DataField="nombre" HeaderText="Nombre" />
            <asp:BoundField DataField="apellidos" HeaderText="Apellido"/>
            <asp:BoundField DataField="correo" HeaderText="Correo"/>
            <asp:BoundField DataField="estado" HeaderText="Estado"/>
            <asp:BoundField DataField="fecha_registro" HeaderText="FechaRegistro"/>
            <asp:TemplateField>
                <HeaderTemplate>
                    Edit
                </HeaderTemplate>
                <ItemTemplate>
                    <asp:LinkButton ID="lnkEditar" runat="server" CommandName="SelParaSQL" CommandArgument="<%# ((GridViewRow) Container).RowIndex %>">
                        Editar
                    </asp:LinkButton>
                </ItemTemplate>
                <ItemStyle HorizontalAlign="Center" Width="9%" />
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
</asp:Content>
