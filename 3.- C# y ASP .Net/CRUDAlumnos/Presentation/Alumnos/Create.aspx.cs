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
    public partial class Create : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                NEstado objCRUDestado = new NEstado();
                NEstatusAlumno objCRUDEstatus = new NEstatusAlumno();
                ddlEstado.DataSource = objCRUDestado.NConsultar();
                ddlEstado.DataTextField = "Nombre";
                ddlEstado.DataValueField = "id";
                ddlEstado.DataBind();

                ddlEstatus.DataSource = objCRUDEstatus.NConsultar();
                ddlEstatus.DataTextField = "Nombre";
                ddlEstatus.DataValueField = "id";
                ddlEstatus.DataBind();
            }
           
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            NAlumno objCRUD = new NAlumno();

            Alumno Alumno = new Alumno
            {
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

            if (objCRUD.NAgregar(Alumno) >= 1)
            {
                Response.Redirect($"Index.aspx");
            }

        }
    }
}