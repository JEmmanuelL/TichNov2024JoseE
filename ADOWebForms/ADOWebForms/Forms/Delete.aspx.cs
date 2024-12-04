using ADOWebForms.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ADOWebForms.Forms
{
    public partial class Delete : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = int.Parse(Request.QueryString["id"] ?? "1"); //Verifica si el valor de request es nulo en caso verdadero pone 1

            List<EstatusAlumno> ListaEstatus = new List<EstatusAlumno>();

            ADOEstatusAlumno onjCRUD = new ADOEstatusAlumno();

            EstatusAlumno estatus = onjCRUD.Consultar(id);

            lblid.Text = estatus.id.ToString();

            lblNombreDef.Text = estatus.nombre;

            lblNombreClv.Text = estatus.clave;
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            ADOEstatusAlumno onjCRUD = new ADOEstatusAlumno();
            int id = int.Parse(Request.QueryString["id"] ?? "1");

           onjCRUD.Eliminar(id);

            Response.Redirect($"index.aspx");
        }
    }
}