<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="ADOWebForms.Forms.index" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
        <h1>Indice</h1>

        <dl>
        <dt>
            <asp:Label ID="lbEstatus" runat="server" Text="Estatus"></asp:Label>
        </dt>
        <dd>
            <asp:DropDownList ID="ddlEstatus" runat="server"></asp:DropDownList>
        </dd>

    </dl>
    <hr />
       
    <asp:Button ID="btnConsultar" runat="server" Text="Agregar" OnClick="btnConsultar_Click"/>
    <asp:Button ID="btnDetalles" runat="server" Text="Detalles" OnClick="btnDetalles_Click" />
    <asp:Button ID="btnEdita" runat="server" Text="Edita" OnClick="btnEdita_Click" />
    <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" OnClick="btnEliminar_Click" />

</asp:Content>
