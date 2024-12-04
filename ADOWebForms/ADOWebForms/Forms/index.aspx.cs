using ADOWebForms.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ADOWebForms.Forms
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        public void CargarDatos()
        {
            if (!IsPostBack)
            {
                ADOEstatusAlumno onjCRUD = new ADOEstatusAlumno();
                ddlEstatus.DataSource = onjCRUD.Consultar();
                ddlEstatus.DataTextField = "Nombre";
                ddlEstatus.DataValueField = "id";
                ddlEstatus.DataBind();
                //ADOEstatusAlumno onjCRUD = new ADOEstatusAlumno();
            }


        }

        protected void btnConsultar_Click(object sender, EventArgs e)
        {
            Response.Redirect($"Create.aspx");
        }

        protected void btnDetalles_Click(object sender, EventArgs e)
        {
            int id = int.Parse(ddlEstatus.SelectedValue);
            Response.Redirect($"Details.aspx?id={id}");
        }

        protected void btnEdita_Click(object sender, EventArgs e)
        {
            int id = int.Parse(ddlEstatus.SelectedValue);
            Response.Redirect($"Edit.aspx?id={id}");
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(ddlEstatus.SelectedValue);
            Response.Redirect($"Delete.aspx?id={id}");
        }
    }
}