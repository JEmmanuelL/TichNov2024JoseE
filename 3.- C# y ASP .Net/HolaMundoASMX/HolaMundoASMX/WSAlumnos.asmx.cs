﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using Entity;
using BusinessLogic;

namespace HolaMundoASMX
{
    /// <summary>
    /// Descripción breve de WSAlumnos
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WSAlumnos : System.Web.Services.WebService
    {
        NAlumno objCRUD = new NAlumno();

        [WebMethod]
        public AportacionesIMSS CalcularIMSS(decimal sueldo)
        {
            AportacionesIMSS Aportaciones = objCRUD.CalcularIMSS(sueldo);

            return Aportaciones;
        }
    }
}
