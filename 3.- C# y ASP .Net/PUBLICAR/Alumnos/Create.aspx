﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Create.aspx.cs" Inherits="Presentation.Alumnos.Create" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

<div class="container mt-5">
    <h2 class="mb-4">Agregar Alumno</h2>
    <form>
        <div class="form-group row">
            <label for="txtNombre" class="col-sm-3 col-form-label text-right">Nombre</label>
            <div class="col-sm-9">
                <asp:TextBox ID="txtNombre" runat="server" CssClass="form-control"></asp:TextBox>
                <asp:RequiredFieldValidator ID="rfvNombre" runat="server" ErrorMessage="El campo nombre no puede estar vacio" ControlToValidate="txtNombre" CssClass="text-danger"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="revNombre" runat="server" ErrorMessage="El campo nombre solo acepta nombre y espacios" ControlToValidate="txtNombre" CssClass="text-danger" ValidationExpression="([A-Za-zÀ-ÿ\u00f1\u00d1\s])+"></asp:RegularExpressionValidator>
           
            </div>
        </div>
        <div class="form-group row">
            <label for="txtPrimerA" class="col-sm-3 col-form-label text-right">Primer Apellido</label>
            <div class="col-sm-9">
                <asp:TextBox ID="txtPrimerA" runat="server" CssClass="form-control"></asp:TextBox>
                <asp:RequiredFieldValidator ID="rfvPrimerA" runat="server" ErrorMessage="El campo del Primer Apellido no puede estar vacio" ControlToValidate="txtPrimerA" CssClass="text-danger"></asp:RequiredFieldValidator>
                 <asp:RegularExpressionValidator ID="revPrimerA" runat="server" ErrorMessage="El campo del Primer Apellido solo acepta nombre y espacios" ControlToValidate="txtPrimerA" CssClass="text-danger" ValidationExpression="([A-Za-zÀ-ÿ\u00f1\u00d1 ])+"></asp:RegularExpressionValidator> <%-- Mia (\s*[A-z]+\s*[A-z]*)+--%>

            </div>
        </div>
        <div class="form-group row">
            <label for="txtSegundoA" class="col-sm-3 col-form-label text-right">Segundo Apellido</label>
            <div class="col-sm-9">
                <asp:TextBox ID="txtSegundoA" runat="server" CssClass="form-control"></asp:TextBox>
                <asp:RegularExpressionValidator ID="revSegA" runat="server" ErrorMessage="El campo del Segundo Apellido solo acepta nombre y espacios" ControlToValidate="txtSegundoA" CssClass="text-danger" ValidationExpression="([A-Za-zÀ-ÿ\u00f1\u00d1 ])+"></asp:RegularExpressionValidator>
            </div>
        </div>
        <div class="form-group row">
            <label for="txtFechaNA" class="col-sm-3 col-form-label text-right">Fecha de Nacimiento</label>
            <div class="col-sm-9">
                <asp:TextBox ID="txtFechaNA" runat="server" TextMode="Date" CssClass="form-control"></asp:TextBox>
                <asp:RequiredFieldValidator ID="rfvFechaNaci" runat="server" ErrorMessage="Tiene que ingresar/seleccionar su fecha de nacimiento" ControlToValidate="txtFechaNA" CssClass="text-danger"></asp:RequiredFieldValidator>
                <asp:RangeValidator ID="rvFechaNaci" runat="server" ErrorMessage="La fecha de nacimiento acepta solo es entre 01-ene-1990 y el 31- dic -2000" ControlToValidate="txtFechaNA" CssClass="text-danger" Type="Date" MinimumValue="1990-01-01" MaximumValue="2000-12-31"></asp:RangeValidator>
           
            </div>
        </div>
        <div class="form-group row">
            <label for="txtCURP" class="col-sm-3 col-form-label text-right">CURP</label>
            <div class="col-sm-9">
                <asp:TextBox ID="txtCURP" runat="server" CssClass="form-control"></asp:TextBox>
                <asp:RequiredFieldValidator ID="rfvCurp" runat="server" ErrorMessage="El campo de la CURP no puede estar vacío" ControlToValidate="txtCURP" CssClass="text-danger"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="revCurp" runat="server" ErrorMessage="La CURP no tiene el formato correcto" ControlToValidate="txtCURP" CssClass="text-danger" ValidationExpression="^[A-Z]{4}[0-9]{6}[A-Z]{6}\w{2}"></asp:RegularExpressionValidator> <br />
                <asp:CustomValidator ID="cvCurp" runat="server" ErrorMessage="Fecha de Nacimiento no coincide con fecha de nacimiento de CURP" ControlToValidate="txtCURP" CssClass="text-danger" ClientValidationFunction="CurpvsFechaNac" ></asp:CustomValidator>
            </div>
        </div>
        <div class="form-group row">
            <label for="txtCorreo" class="col-sm-3 col-form-label text-right">Correo</label>
            <div class="col-sm-9">
                <asp:TextBox ID="txtCorreo" runat="server" TextMode="Email" CssClass="form-control"></asp:TextBox>
                 <asp:RequiredFieldValidator ID="rfvCorreo" runat="server" ErrorMessage="El campo del correo no puede estar vacío" ControlToValidate="txtCorreo" CssClass="text-danger"></asp:RequiredFieldValidator>
         
            </div>
        </div>
        <div class="form-group row">
            <label for="txtTelefono" class="col-sm-3 col-form-label text-right">Teléfono</label>
            <div class="col-sm-9">
                <asp:TextBox ID="txtTelefono" runat="server" TextMode="Number" CssClass="form-control"></asp:TextBox>
                <asp:RangeValidator ID="rvSueldo" runat="server" ErrorMessage="El rango de sueldo aceptado es entre 10,000 y 40,000 pesos" ControlToValidate="txtSueldoM" CssClass="text-danger" MinimumValue="10000" MaximumValue="40000" Type="Currency"></asp:RangeValidator>
            </div>
        </div>
        <div class="form-group row">
            <label for="txtSueldoM" class="col-sm-3 col-form-label text-right">Sueldo Mensual</label>
            <div class="col-sm-9">
                <asp:TextBox ID="txtSueldoM" runat="server" TextMode="Number" CssClass="form-control"></asp:TextBox>
            </div>
        </div>
        <div class="form-group row">
            <label for="ddlEstado" class="col-sm-3 col-form-label text-right">Estado</label>
            <div class="col-sm-9">
                <asp:DropDownList ID="ddlEstado" runat="server" CssClass="form-control"></asp:DropDownList>
            </div>
        </div>
        <div class="form-group row">
            <label for="ddlEstatus" class="col-sm-3 col-form-label text-right">Estatus</label>
            <div class="col-sm-9">
                <asp:DropDownList ID="ddlEstatus" runat="server" CssClass="form-control"></asp:DropDownList>
            </div>
        </div>
        <div class="form-group row">
            <div class="col-sm-12 text-start">
                <asp:Button ID="btnGuardar" runat="server" Text="Guardar" OnClick="btnGuardar_Click" CssClass="btn btn-primary"></asp:Button>
            </div>
        </div>
    </form>
    <div class="mt-3">
        <a href="index.aspx" class="btn btn-link">Regresar a la Lista</a>
    </div>
</div>

    <script type="text/javascript">
        function CurpvsFechaNac(source, args)
        {
            var fechaNac = $("#<%=txtFechaNA.ClientID%>").val();
            var curpPartFechaNac = args.Value.substr(4, 6);
            var fechaNacFormatCurp = fechaNac.substr(2, 2) + fechaNac.substr(5, 2) + fechaNac.substr(8, 2);
            args.IsValid = curpPartFechaNac == fechaNacFormatCurp;
        }
    </script>

</asp:Content>