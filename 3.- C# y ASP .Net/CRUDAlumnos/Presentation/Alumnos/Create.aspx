<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Create.aspx.cs" Inherits="Presentation.Alumnos.Create" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    	<h2>Agregar Alumno</h2>

    <table border="0" style="border-collapse: separate; border-spacing: 10px; width: 50%;">
    <tr>
        <th style="text-align: right;">Nombre</th>
        <td><asp:TextBox ID="txtNombre" runat="server"></asp:TextBox></td>
    </tr>
    <tr>
        <th style="text-align: right;">Primer Apellido</th>
        <td><asp:TextBox ID="txtPrimerA" runat="server"></asp:TextBox></td>
    </tr>
    <tr>
        <th style="text-align: right;">Segundo Apellido</th>
        <td><asp:TextBox ID="txtSegundoA" runat="server"></asp:TextBox></td>
    </tr>
    <tr>
        <th style="text-align: right;">Fecha de Nacimiento</th>
        <td><asp:TextBox ID="txtFechaNA" runat="server" TextMode="Date"></asp:TextBox></td>

    </tr>
    <tr>
        <th style="text-align: right;">CURP</th>
        <td><asp:TextBox ID="txtCURP" runat="server"></asp:TextBox></td>
    </tr>
    <tr>
        <th style="text-align: right;">Correo</th>
        <td><asp:TextBox ID="txtCorreo" runat="server" TextMode="Email"></asp:TextBox></td>
    </tr>
    <tr>
        <th style="text-align: right;">Teléfono</th>
        <td><asp:TextBox ID="txtTelefono" runat="server" TextMode="Number"></asp:TextBox></td>
    </tr>
    <tr>
        <th style="text-align: right;">Sueldo Mensual</th>
        <td><asp:TextBox ID="txtSueldoM" runat="server" TextMode="Number"></asp:TextBox></td>
    </tr>
    <tr>
        <th style="text-align: right;">Estado</th>
        <td><asp:DropDownList ID="ddlEstado" runat="server"></asp:DropDownList></td>
    </tr>
    <tr>
        <th style="text-align: right;">Estatus</th>
        <td><asp:DropDownList ID="ddlEstatus" runat="server"></asp:DropDownList></td>
    </tr>
</table>
<asp:Button ID="btnGuardar" runat="server" Text="Guardar" OnClick="btnGuardar_Click" />
 <br />
<a href="index.aspx">Regresar a la Lista</a>

</asp:Content>
