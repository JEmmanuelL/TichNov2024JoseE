<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Details.aspx.cs" Inherits="ADOWebForms.Forms.Details" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <dl>
        <dt>id</dt>
        <dd>
            <asp:Label ID="lblid" runat="server" Text=""></asp:Label>
        </dd>
        <dt>
            <asp:Label ID="lblnombreTer" runat="server" Text="Nombre"></asp:Label>
        </dt>
        <dd>
            <asp:Label ID="lblNombreDef" runat="server" Text=""></asp:Label>
        </dd>
        <dt>
            <asp:Label ID="lblnombreTer2" runat="server" Text="Clave"></asp:Label>
        </dt>
        <dd>
            <asp:Label ID="lblNombreClv" runat="server" Text=""></asp:Label>
        </dd>
    </dl>
    <a href="index.aspx">Regresar a la Lista</a>
</asp:Content>
