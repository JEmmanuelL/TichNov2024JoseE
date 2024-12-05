<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="Presentation.Alumnos.Index" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="form-group ">
    <div class="col-sm-12  text-start">
       <br /> <asp:Button ID="btnAgregar" runat="server" Text="Agregar" CssClass="btn btn-primary" OnClick="btnAgregar_Click"></asp:Button>
    </div>
</div>
     <br />
     <br />
     <br />
    <asp:GridView ID="gvAlumnos" runat="server" AllowPaging="True" AutoGenerateColumns="False" BorderStyle="None" CssClass="table" GridLines="Horizontal" OnPageIndexChanging="gvAlumnos_PageIndexChanging" OnRowCommand="gvAlumnos_RowCommand" PageSize="3">
        <Columns>
            <asp:BoundField DataField="id" HeaderText="Id" />
            <asp:BoundField DataField="nombre" HeaderText="Nombre" />

              <asp:BoundField DataField="primerApellido" HeaderText="Primer Apellido" />
              <asp:BoundField DataField="segundoApellido" HeaderText="Segundo Apellido" />

              <asp:BoundField DataField="correo" HeaderText="Correo" />
               <asp:BoundField DataField="telefono" HeaderText="Telefono" />

              <asp:BoundField DataField="idEstadoOrigen" HeaderText="Estado" />
              <asp:BoundField DataField="idEstatus" HeaderText="Estatus" />

            <asp:ButtonField CommandName="btnDetails" Text="Detalles">
            <ControlStyle CssClass="btn btn-warning btn-sm" />
            </asp:ButtonField>
            <asp:ButtonField CommandName="btnEdit" Text="Editar">
            <ControlStyle CssClass="btn btn-success btn-sm" />
            </asp:ButtonField>
            <asp:ButtonField CommandName="btnDelete" Text="Eliminar">
            <ControlStyle CssClass="btn btn-danger btn-sm" />
            </asp:ButtonField>

        </Columns>
    </asp:GridView>



</asp:Content>
