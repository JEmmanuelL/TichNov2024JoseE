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
            lblSueldoM.Text = UnAlumno.sueldo.ToString("c2");


            NEstado objCRUDestado = new NEstado();
            NEstatusAlumno objCRUDEstatus = new NEstatusAlumno();

            Estado EstaEnc = objCRUDestado.NConsultar(UnAlumno.idEstadoOrigen);
            EstatusAlumno EstatusEnc = objCRUDEstatus.NConsultar(UnAlumno.idEstatus);


            lblEstado.Text = EstaEnc.nombre.ToString();
            lblEstatus.Text = EstatusEnc.nombre.ToString();


        }
    }
}