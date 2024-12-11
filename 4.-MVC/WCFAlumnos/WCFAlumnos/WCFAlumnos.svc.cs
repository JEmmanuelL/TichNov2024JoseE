using BusinessLogic;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Newtonsoft.Json;


namespace WCFAlumnos
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "WCFAlumnos" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione WCFAlumnos.svc o WCFAlumnos.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class WCFAlumnos : IWCFAlumnos
    {
        NAlumno objCRUD = new NAlumno();

        public AportacionesIMSS CalcularIMSS(int id)
        {
            Entity.AportacionesIMSS Aportaciones = objCRUD.CalcularIMSS(id);

            AportacionesIMSS aportacionesIMSS = new AportacionesIMSS();
            //{ EnfermedadMaternidad = Aportaciones.EnfermedadMaternidad ,
            //  Cesantia = Aportaciones.Cesantia};


            var ObjJSON = JsonConvert.SerializeObject(Aportaciones);
             aportacionesIMSS =JsonConvert.DeserializeObject<AportacionesIMSS>(ObjJSON);

            return aportacionesIMSS;
        }

        public ItemTablaISR CalcularISR1(int id)
        {
            Entity.ItemTablaISR sujeto = objCRUD.CalcularISR(id);

            var ObjJSON = JsonConvert.SerializeObject(sujeto);
            ItemTablaISR  sujeto1 = JsonConvert.DeserializeObject<ItemTablaISR>(ObjJSON);
            return sujeto1;
        }


    }
}
