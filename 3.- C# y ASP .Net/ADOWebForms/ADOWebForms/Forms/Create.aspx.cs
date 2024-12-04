using ADOWebForms.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ADOWebForms.Forms
{
    public partial class Create : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           if (!IsPostBack)
            {
                nameEsta.Text = null;
                clvEsta.Text = null;
            }
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            ADOEstatusAlumno onjCRUD = new ADOEstatusAlumno();

            EstatusAlumno dataAlum = new EstatusAlumno
            {
                clave = nameEsta.Text,
                nombre = clvEsta.Text,
            };
            if (onjCRUD.Agregar(dataAlum) != 0)
            {
                Response.Redirect($"index.aspx");
            }
            else
            {
                throw new Exception("Ocurrio un error al intentar agregar");
            }
        }
    }
}