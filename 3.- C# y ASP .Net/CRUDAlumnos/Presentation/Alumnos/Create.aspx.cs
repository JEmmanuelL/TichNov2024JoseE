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
            NAlumno objCRUD = new NAlumno();

            Alumno Alumno = new Alumno
            {
                nombre = "Jose",
                primerApellido = "Lopez",
                segundoApellido = "Jimenez",
                correo = "yyy@hotmail.com",
                telefono = "9211405292",
                fechaNacimiento = Convert.ToDateTime("2000-09-17"),
                curp = "LOJE00917HVZPMMA1",
                sueldo = 45500,
                idEstadoOrigen = 17,
                idEstatus = 1,
            };

            if(objCRUD.NAgregar(Alumno) >= 1)
            {
                Response.Redirect($"Index.aspx");
            }
            
        }
    }
}