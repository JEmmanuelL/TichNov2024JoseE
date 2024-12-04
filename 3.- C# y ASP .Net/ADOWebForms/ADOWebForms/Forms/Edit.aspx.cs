using ADOWebForms.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ADOWebForms.Forms
{
    public partial class Edit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int id = int.Parse(Request.QueryString["id"] ?? "1"); //Verifica si el valor de request es nulo en caso verdadero pone 1

                List<EstatusAlumno> ListaEstatus = new List<EstatusAlumno>();

                ADOEstatusAlumno onjCRUD = new ADOEstatusAlumno();

                EstatusAlumno estatus = onjCRUD.Consultar(id);

                idEsta.Text = estatus.id.ToString();

                nameEsta.Text = estatus.nombre;

                clvEsta.Text = estatus.clave;
            }
           
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            ADOEstatusAlumno onjCRUD = new ADOEstatusAlumno();

            EstatusAlumno dataAlum = new EstatusAlumno
            {
                id = int.Parse(Request.QueryString["id"] ?? "1"),
                clave = nameEsta.Text,
                nombre = clvEsta.Text,
            };
            onjCRUD.Actualizar(dataAlum);

            Response.Redirect($"index.aspx");

        }
    }
}