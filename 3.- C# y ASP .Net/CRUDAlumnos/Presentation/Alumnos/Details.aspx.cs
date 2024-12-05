using BusinessLogic;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Presentation.Alumnos
{
    public partial class Details : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            NAlumno objCRUD = new NAlumno();

            int id = int.Parse(Request.QueryString["id"] ?? "2");


            Alumno UnAlumno = objCRUD.NConsultar(id);

            lblID.Text = UnAlumno.id.ToString();
            lblNombre.Text = UnAlumno.nombre;
            lblPrimerA.Text = UnAlumno.primerApellido;
            lblSegundoA.Text = UnAlumno.segundoApellido;
            lblFechaNA.Text = UnAlumno.fechaNacimiento.ToString("yyyy/MM/dd");
            lblCURP.Text = UnAlumno.curp;
            lblCorreo.Text = UnAlumno.correo;
            lblTelefono.Text = UnAlumno.telefono;
            //lblSueldoM.Text = UnAlumno.sueldo.ToString();

            lblSueldoM.Text = UnAlumno.sueldo.ToString("c2");


            NEstado objCRUDestado = new NEstado();
            NEstatusAlumno objCRUDEstatus = new NEstatusAlumno();

            Estado EstaEnc = objCRUDestado.NConsultar(UnAlumno.idEstadoOrigen);
            EstatusAlumno EstatusEnc = objCRUDEstatus.NConsultar(UnAlumno.idEstatus);


            lblEstado.Text = EstaEnc.nombre.ToString();
            lblEstatus.Text = EstatusEnc.nombre.ToString();


        }

        protected void btnISR_Click(object sender, EventArgs e)
        {
            NAlumno objCRUD = new NAlumno();

            ItemTablaISR Sujeto = objCRUD.CalcularISR(Convert.ToInt32(lblID.Text));

            string ResultISR = "";

            ResultISR = "El limite inferior es de: "+Sujeto.LimitInf.ToString("c2")+" ";
            ResultISR += "El limite superior es de: " + Sujeto.LimitSup.ToString("c2") + " ";
            ResultISR += "La cuota fija es de: " + Sujeto.CuotaFija.ToString("c2") + " ";
            ResultISR += "El excedente es de: " + Sujeto.Excedente.ToString("c2") + " ";
            ResultISR += "El subsidio es de: " + Sujeto.Subsidio.ToString("c2") + " ";
            ResultISR += "El ISR a pagar es de: " + Sujeto.ISR.ToString("c2") + " ";


            lblISRxIMSS.Text = ResultISR;
        }

        protected void btnIMSS_Click(object sender, EventArgs e)
        {
            NAlumno objCRUD = new NAlumno();

            AportacionesIMSS Sujeto = objCRUD.CalcularIMSS(Convert.ToInt32(lblID.Text));

            string ResultIMSS = "";

            ResultIMSS =$"La prestación obtenida para Enfermedades y Maternidad es de {Sujeto.EnfermedadMaternidad.ToString("C2")}\n";
            ResultIMSS += $"La prestación obtenida para Invalidez y vida es de {Sujeto.InvalidezVida.ToString("C2")}\n";
            ResultIMSS += $"La prestación obtenida para Retiro es de {Sujeto.Retiro.ToString("C2")}\n";
            ResultIMSS += $"La prestación obtenida para Cesantia es de {Sujeto.Cesantia.ToString("C2")}\n";
            ResultIMSS += $"La prestación obtenida para Credito Infonavit es de {Sujeto.Infonavit.ToString("C2")}\n";

            lblISRxIMSS.Text = ResultIMSS;
        }
    }
}