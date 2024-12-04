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
    public partial class Edit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            NAlumno objCRUD = new NAlumno();

            //int id = int.Parse(Request.QueryString["id"] ?? "1");
            int id = 20;
            Alumno Alumn = objCRUD.NConsultar(id);
            Alumn.nombre = "JOSE";
            Alumn.primerApellido = "JIMENEZ";
            if (objCRUD.NActualizar(Alumn) >= 1)
            {
                Response.Redirect($"Index.aspx");
            }
        }
    }
}