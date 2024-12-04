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

            //int id = int.Parse(Request.QueryString["id"] ?? "1");

            int id = 22;

            Alumno Alum = objCRUD.NConsultar(id);
            
            if (objCRUD.NEliminar(Alum.id) >= 1)
            {
                Response.Redirect($"Index.aspx");
            }

        }
    }
}