using BusinessLogic;
using Entity;
using System;
using System.Collections.Generic;
using System.EnterpriseServices;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Presentation.Alumnos
{
    public partial class Edit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            NAlumno objCRUD = new NAlumno();

            if (!IsPostBack)
            {
                int id = int.Parse(Request.QueryString["id"] ?? "2");
                Alumno UnAlumno = objCRUD.NConsultar(id);

                lblID.Text = UnAlumno.id.ToString();
                txtNombre.Text = UnAlumno.nombre;
                txtPrimerA.Text = UnAlumno.primerApellido;
                txtSegundoA.Text = UnAlumno.segundoApellido;
                txtFechaNA.Text = UnAlumno.fechaNacimiento.ToString("yyyy-MM-dd");
                txtCURP.Text = UnAlumno.curp;
                txtCorreo.Text = UnAlumno.correo;
                txtTelefono.Text = UnAlumno.telefono;
                txtSueldoM.Text = UnAlumno.sueldo.ToString();

                NEstado objCRUDestado = new NEstado();
                NEstatusAlumno objCRUDEstatus = new NEstatusAlumno();

                ddlEstado.DataSource = objCRUDestado.NConsultar();
                ddlEstado.DataTextField = "Nombre";
                ddlEstado.DataValueField = "id";
                ddlEstado.DataBind();

                ddlEstado.SelectedValue = UnAlumno.idEstadoOrigen.ToString();


                ddlEstatus.DataSource = objCRUDEstatus.NConsultar();
                ddlEstatus.DataTextField = "Nombre";
                ddlEstatus.DataValueField = "id";
                ddlEstatus.DataBind();
                ddlEstatus.SelectedValue = UnAlumno.idEstatus.ToString();
            }



        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {

            if (Page.IsValid)
            {
                NAlumno objCRUD = new NAlumno();

                int id = int.Parse(Request.QueryString["id"] ?? "2");
                Alumno Alumn = new Alumno
                {
                    id = id,
                    nombre = txtNombre.Text,
                    primerApellido = txtPrimerA.Text,
                    segundoApellido = txtSegundoA.Text,
                    correo = txtCorreo.Text,
                    telefono = txtTelefono.Text,
                    fechaNacimiento = Convert.ToDateTime(txtFechaNA.Text),
                    curp = txtCURP.Text,
                    sueldo = Convert.ToDecimal(txtSueldoM.Text),
                    idEstadoOrigen = int.Parse(ddlEstado.SelectedValue),
                    idEstatus = int.Parse(ddlEstatus.SelectedValue),
                };

                if (objCRUD.NActualizar(Alumn) >= 1)
                {
                    Response.Redirect($"Index.aspx");
                }
            }
          
             
        }

        protected void cvCurp_ServerValidate(object source, ServerValidateEventArgs args)
        {
            var fechaNac = txtFechaNA.Text;
            var curpPartFechaNac = args.Value.Substring(4, 6);
            var fechaNacFormatCurp = fechaNac.Substring(2, 2) + fechaNac.Substring(5, 2) + fechaNac.Substring(8, 2);
            args.IsValid = curpPartFechaNac == fechaNacFormatCurp;
        }
    }
}