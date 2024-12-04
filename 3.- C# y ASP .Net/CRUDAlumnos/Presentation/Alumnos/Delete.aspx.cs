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
    public partial class Delete : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            NAlumno objCRUD = new NAlumno();

           int id = int.Parse(Request.QueryString["id"] ?? "20");

            Alumno Alum = objCRUD.NConsultar(id);

            lblID.Text = Alum.id.ToString();
            lblNombre.Text = Alum.nombre;
            lblPrimerA.Text = Alum.primerApellido;
            lblSegundoA.Text = Alum.segundoApellido;
            lblFechaNA.Text = Alum.fechaNacimiento.ToString("yyyy/MM/dd");
            lblCURP.Text = Alum.curp;
            lblCorreo.Text = Alum.correo;
            lblTelefono.Text = Alum.telefono;
            lblSueldoM.Text = Alum.sueldo.ToString("c2");


            NEstado objCRUDestado = new NEstado();
            NEstatusAlumno objCRUDEstatus = new NEstatusAlumno();

            Estado EstaEnc = objCRUDestado.NConsultar(Alum.idEstadoOrigen);
            EstatusAlumno EstatusEnc = objCRUDEstatus.NConsultar(Alum.idEstatus);


            lblEstado.Text = EstaEnc.nombre.ToString();
            lblEstatus.Text = EstatusEnc.nombre.ToString();

    

        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(Request.QueryString["id"] ?? "20");
            NAlumno objCRUD = new NAlumno();

            if (objCRUD.NEliminar(id) >= 1)
            {
                Response.Redirect($"Index.aspx");
            }
        }
    }
}