<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Delete.aspx.cs" Inherits="Presentation.Alumnos.Delete" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

 
    <div class="container mt-5">
    <h1 class="mb-4">Eliminar Alumno</h1>
    <h3 class="mb-4 text-danger">¿Está seguro que quiere eliminar al Alumno?</h3>

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

    <div class="text-start mt-4">
        <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" OnClick="btnEliminar_Click" CssClass="btn btn-danger" />
    </div>
    <div class="mt-3">
        <a href="index.aspx" class="btn btn-link">Regresar a la Lista</a>
    </div>
</div>



</asp:Content>
