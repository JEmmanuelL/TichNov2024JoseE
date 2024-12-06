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
            <div class="text-start py-2">
                <asp:Label ID="lblISRxIMSS" runat="server"></asp:Label>
            </div>
         <div class="text-start mt-4">
      <asp:Button ID="btnIMSS" runat="server" Text="Calcular el IMSS" CssClass="btn btn-primary px-1" OnClick="btnIMSS_Click" Width="161px" />

         <input id="btnISR" type="button" value="CalcularISR" CssClass="btn btn-primary" onclick="CalcularISRjs()" />

     </div><br />
    <div class="mt-3">
        <a href="index.aspx" class="btn btn-link">Regresar a la Lista</a>
    </div>
</div>

    <!-- Button trigger modal -->

<!-- Modal -->
<div class="modal fade" id="ModalISR" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel" aria-hidden="true">
  <div class="modal-dialog" role="document">
    <div class="modal-content">
      <div class="modal-header">
        <h5 class="modal-title" id="exampleModalLabel">Calculo de ISR</h5>
        <button type="button" class="close" data-dismiss="modal" aria-label="Close">
          <span aria-hidden="true">&times;</span>
        </button>
      </div>
      <div class="modal-body">
                       <dl>
                            <dt>Limite Inferior:</dt>
                            <dd>
                                <asp:Label ID="lblInf" runat="server" Text=""></asp:Label>
                            </dd>
                            <dt>Limite Superior:</dt>
                            <dd>
                                <asp:Label ID="lblSup" runat="server" Text=""></asp:Label>
                            </dd>
                            <dt>Cuota Fija:</dt>
                            <dd>
                                <asp:Label ID="lblCuota" runat="server" Text=""></asp:Label>
                            </dd>
                            <dt>Excedente</dt>
                            <dd>
                                <asp:Label ID="lblExcedente" runat="server" Text=""></asp:Label>
                            </dd>
                            <dt>Subsidio:</dt>
                            <dd>
                                <asp:Label ID="lblSubsidio" runat="server" Text=""></asp:Label>
                            </dd>
                            <dt>ISR:</dt>
                            <dd>
                                <asp:Label ID="lblISR" runat="server" Text=""></asp:Label>
                            </dd>
                        </dl>
      </div>
      <div class="modal-footer">
        <button type="button" class="btn btn-secondary" data-dismiss="modal">Close</button>
      </div>
    </div>
  </div>
</div>

        <!-- Button trigger modal -->

<!-- Modal -->
<div class="modal fade" id="ModalIMSS" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabelIMSS" aria-hidden="true">
  <div class="modal-dialog" role="document">
    <div class="modal-content">
      <div class="modal-header">
        <h5 class="modal-title" id="exampleModalLabelIMSS">Calculo del IMSS</h5>
        <button type="button" class="close" data-dismiss="modal" aria-label="Close">
          <span aria-hidden="true">&times;</span>
        </button>
      </div>
      <div class="modal-body">
                       <dl>
                            <dt>EnfermedadMaternidad:</dt>
                            <dd>
                                <asp:Label ID="lblEnfermedadMaternidad" runat="server" Text=""></asp:Label>
                            </dd>
                            <dt>InvalidezVida:</dt>
                            <dd>
                                <asp:Label ID="lblInvalidezVida" runat="server" Text=""></asp:Label>
                            </dd>
                            <dt>Retiro:</dt>
                            <dd>
                                <asp:Label ID="lblRetiro" runat="server" Text=""></asp:Label>
                            </dd>
                            <dt>Cesantia: </dt>
                            <dd>
                                <asp:Label ID="lblCesantia" runat="server" Text=""></asp:Label>
                            </dd>
                            <dt>Infonavit:</dt>
                            <dd>
                                <asp:Label ID="lblInfonavit" runat="server" Text=""></asp:Label>
                            </dd>
                        </dl>
      </div>
      <div class="modal-footer">
        <button type="button" class="btn btn-secondary" data-dismiss="modal">Close</button>      

      </div>
    </div>
  </div>
</div>

    <script type="text/javascript">

        function CalcularISRjs() {

            let urlWS = 'http://localhost:53150/WSAlumnos.asmx/CalcularISR';

            let id = $("#<%=lblID.ClientID%>").text();

            let jsonID = JSON.stringify({ id: id });
            

            $.ajax({
                type: 'POST',
                url: urlWS,
                data: jsonID,
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                success: RecibeObjetoISR,
                error: errorGenerico
            }

            )
        }


        function RecibeObjetoISR(resultado)
        {
            let itemTablaISR = resultado.d;

            if (itemTablaISR != null) {
                $("#<%=lblInf.ClientID%>").text(itemTablaISR.LimitInf);
                $("#<%=lblSup.ClientID%>").text(itemTablaISR.LimitSup);
                $("#<%=lblCuota.ClientID%>").text(itemTablaISR.CuotaFija);
                $("#<%=lblExcedente.ClientID%>").text(itemTablaISR.Excedente);
                $("#<%=lblSubsidio.ClientID%>").text(itemTablaISR.subsidio);
                $("#<%=lblISR.ClientID%>").text(itemTablaISR.ISR);

                $("#ModalISR").modal("show");

            }
        }


        function errorGenerico(jqXHR, estatus, error) {
            var msg = '';
            if (jqXHR.status === 0) {
                msg = 'No está conectado, favor de verificar su conexión.';
            }
            else if (jqXHR.status === 404) {
                msg = 'Página no encontrada [404]';
            }
            else if (jqXHR.status === 500) {
                msg = 'Error no hay conexión al servidor [500]';
            }
            else if (jqXHR.status === 'parseerror') {
                msg = 'El parseo del JSON es erróneo.';
            }
            else if (jqXHR.status === 'timeout') {
                $('body').addClass('loaded');
            }
            else if (jqXHR.status === 'abort') {
                msg = 'La petición Ajax fue abortada.';
            }
            else {
                msg = 'Error no conocido. ';
                console.log(exception);
            }
            alert(msg);
        }
    </script>


</asp:Content>
