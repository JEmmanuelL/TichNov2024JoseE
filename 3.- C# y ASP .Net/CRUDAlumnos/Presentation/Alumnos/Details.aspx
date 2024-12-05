<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Details.aspx.cs" Inherits="Presentation.Alumnos.Details" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

<%--    <div>
	<h2>Datos del Alumno</h2>
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


    <a href="index.aspx">Regresar a la Lista</a>--%>

    <div class="container mt-5">
    <h2 class="mb-4">Datos del Alumno</h2>
    <div class="table-responsive">
        <table class="table table-bordered">
            <tbody>
                <tr>
                    <th class="text-right" style="width: 30%;">ID</th>
                    <td><asp:Label ID="lblID" runat="server" Text=""></asp:Label></td>
                </tr>
                <tr>
                    <th class="text-right">Nombre</th>
                    <td><asp:Label ID="lblNombre" runat="server" Text=""></asp:Label></td>
                </tr>
                <tr>
                    <th class="text-right">Primer Apellido</th>
                    <td><asp:Label ID="lblPrimerA" runat="server" Text=""></asp:Label></td>
                </tr>
                <tr>
                    <th class="text-right">Segundo Apellido</th>
                    <td><asp:Label ID="lblSegundoA" runat="server" Text=""></asp:Label></td>
                </tr>
                <tr>
                    <th class="text-right">Fecha de Nacimiento</th>
                    <td><asp:Label ID="lblFechaNA" runat="server" Text=""></asp:Label></td>
                </tr>
                <tr>
                    <th class="text-right">CURP</th>
                    <td><asp:Label ID="lblCURP" runat="server" Text=""></asp:Label></td>
                </tr>
                <tr>
                    <th class="text-right">Correo</th>
                    <td><asp:Label ID="lblCorreo" runat="server" Text=""></asp:Label></td>
                </tr>
                <tr>
                    <th class="text-right">Teléfono</th>
                    <td><asp:Label ID="lblTelefono" runat="server" Text=""></asp:Label></td>
                </tr>
                <tr>
                    <th class="text-right">Sueldo Mensual</th>
                    <td><asp:Label ID="lblSueldoM" runat="server" Text=""></asp:Label></td>
                </tr>
                <tr>
                    <th class="text-right">Estado</th>
                    <td><asp:Label ID="lblEstado" runat="server" Text=""></asp:Label></td>
                </tr>
                <tr>
                    <th class="text-right">Estatus</th>
                    <td><asp:Label ID="lblEstatus" runat="server" Text=""></asp:Label></td>
                </tr>
            </tbody>
        </table>
    </div>
    <div class="mt-3">
        <a href="index.aspx" class="btn btn-link">Regresar a la Lista</a>
    </div>
</div>


</asp:Content>
