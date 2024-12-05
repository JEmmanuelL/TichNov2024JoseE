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
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CargarGridView();

        }

        protected void gvAlumnos_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if(e.CommandName != "Page")
            {
                int numFila = Convert.ToInt32(e.CommandArgument);
                GridViewRow Fila = gvAlumnos.Rows[numFila];
                TableCell Celda = Fila.Cells[0];
                int id = Convert.ToInt32(Celda.Text);

                //e.CommandName =

                switch (e.CommandName)
                {
                    case "btnDetails":
                        Response.Redirect($"Details.aspx?id={id}");
                        break;
                    case "btnEdit":
                        Response.Redirect($"Edit.aspx?id={id}");
                        break;
                    case "btnDelete":
                        Response.Redirect($"Delete.aspx?id={id}");
                        break;
                    default:
                        Response.Redirect($"Index.aspx");
                        break;
                }
            }
            else
            {
                return;
            }


        }

        protected void gvAlumnos_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvAlumnos.PageIndex = e.NewPageIndex;
            CargarGridView();

        }

        private void CargarGridView()
        {
            NAlumno objCRUD = new NAlumno();

            List<Alumno> Alumns = objCRUD.NConsultar();

            gvAlumnos.DataSource = Alumns;
            gvAlumnos.DataBind();
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(Request.QueryString["id"] ?? "2");
            Response.Redirect($"Create.aspx?id={id}");

        }
    }
}