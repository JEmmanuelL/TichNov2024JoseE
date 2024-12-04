<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Edit.aspx.cs" Inherits="ADOWebForms.Forms.Edit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
         <dl>
               <dt>
                    <asp:Label ID="lblID" runat="server" Text="ID"></asp:Label>
                </dt>
                <dd>
                    <asp:TextBox ID="idEsta" runat="server" Enabled="false"></asp:TextBox>
                </dd>
                <dt>
                    <asp:Label ID="lblnombreTer" runat="server" Text="Nombre"></asp:Label>
                </dt>
                <dd>
                    <asp:TextBox ID="nameEsta" runat="server"></asp:TextBox>
                </dd>
                <dt>
                    <asp:Label ID="lblnombreTer2" runat="server" Text="Clave"></asp:Label>
                </dt>
                <dd>
                    <asp:TextBox ID="clvEsta" runat="server"></asp:TextBox>
                </dd>
    </dl>

        <asp:Button ID="btnGuardar" runat="server" Text="Guardar" OnClick="btnGuardar_Click" />

    <a href="index.aspx">Regresar a la Lista</a>
</asp:Content>
