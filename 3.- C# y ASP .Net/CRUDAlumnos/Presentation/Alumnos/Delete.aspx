<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Delete.aspx.cs" Inherits="Presentation.Alumnos.Delete" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    
    <div>
	<h1>Eliminar Alumno</h1>
        	<h3>¿Esta seguro que quieree eliminar al Alumno?</h3>

<table border="0" style="border-collapse: separate; border-spacing: 10px; width: 50%;">
    <tr>
        <th style="text-align: right;">ID</th>
        <td><asp:Label ID="lblID" runat="server" Text=""></asp:Label></td>
    </tr>
    <tr>
        <th style="text-align: right;">Nombre</th>
        <td><asp:Label ID="lblNombre" runat="server" Text=""></asp:Label></td>
    </tr>
    <tr>
        <th style="text-align: right;">Primer Apellido</th>
        <td><asp:Label ID="lblPrimerA" runat="server" Text=""></asp:Label></td>
    </tr>
    <tr>
        <th style="text-align: right;">Segundo Apellido</th>
        <td><asp:Label ID="lblSegundoA" runat="server" Text=""></asp:Label></td>
    </tr>
    <tr>
        <th style="text-align: right;">Fecha de Nacimiento</th>
        <td><asp:Label ID="lblFechaNA" runat="server" Text=""></asp:Label></td>
    </tr>
    <tr>
        <th style="text-align: right;">CURP</th>
        <td><asp:Label ID="lblCURP" runat="server" Text=""></asp:Label></td>
    </tr>
    <tr>
        <th style="text-align: right;">Correo</th>
        <td><asp:Label ID="lblCorreo" runat="server" Text=""></asp:Label></td>
    </tr>
    <tr>
        <th style="text-align: right;">Teléfono</th>
        <td><asp:Label ID="lblTelefono" runat="server" Text=""></asp:Label></td>
    </tr>
    <tr>
        <th style="text-align: right;">Sueldo Mensual</th>
        <td><asp:Label ID="lblSueldoM" runat="server" Text=""></asp:Label></td>
    </tr>
    <tr>
        <th style="text-align: right;">Estado</th>
        <td><asp:Label ID="lblEstado" runat="server" Text=""></asp:Label></td>
    </tr>
    <tr>
        <th style="text-align: right;">Estatus</th>
        <td><asp:Label ID="lblEstatus" runat="server" Text=""></asp:Label></td>
    </tr>
</table>

   <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" OnClick="btnEliminar_Click" />
     <br />
    <a href="index.aspx">Regresar a la Lista</a>
</asp:Content>
