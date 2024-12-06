using Datos;
using Entity;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace BusinessLogic
{
    public class NAlumno
    {

        private static string UMA = ConfigurationManager.AppSettings["ConstGlobalUMA"];

        private Buni.RefWSAlumnos.WSAlumnosSoapClient _wSAlumnos = new Buni.RefWSAlumnos.WSAlumnosSoapClient();


        public List<Alumno> NConsultar() => DAlumno.DConsultar();


        public Alumno NConsultar(int id) => DAlumno.DConsultar(id);

        public int NAgregar(Alumno DataEstatus) => DAlumno.DAgregar(DataEstatus);
 
        public int NActualizar(Alumno DataEstatus) => DAlumno.DActualizar(DataEstatus);

        public int NEliminar(int id) => DAlumno.DEliminar(id);



        public Entity.ItemTablaISR CalcularISR(int id)
        {

            try
            {
              //  Buni.RefWSAlumnos.AportacionesIMSS a  = _wSAlumnos.CalcularISR(id);
            }
            catch (Exception)
            {

                throw;
            }


            ItemTablaISR FilaTablISR = new ItemTablaISR();

            DAlumno Funcio = new DAlumno();

            Alumno unAlumno = NConsultar(id);

            List<ItemTablaISR> TablaISR = Funcio.ConsultarTablaISR();

            var FilaEncOfTabla =
                   (from fila in TablaISR
                    where unAlumno.sueldo> fila.LimitInf && unAlumno.sueldo < fila.LimitSup
                    select fila).ToList()[0];

            unAlumno.sueldo = unAlumno.sueldo / 2;

            FilaEncOfTabla.ISR = ((((unAlumno.sueldo - FilaEncOfTabla.LimitInf) * FilaEncOfTabla.Excedente) / 100) + FilaEncOfTabla.CuotaFija) - FilaEncOfTabla.Subsidio;

            return FilaEncOfTabla;
        }

        public Entity.AportacionesIMSS CalcularIMSS(int id)
        {
            AportacionesIMSS aportaciones = new AportacionesIMSS();
            try
            {
                Buni.RefWSAlumnos.AportacionesIMSS IMSSservices = _wSAlumnos.CalcularIMSS(id);
                string json = JsonConvert.SerializeObject(IMSSservices);

                aportaciones = JsonConvert.DeserializeObject<AportacionesIMSS>(json);
            }
            catch (Exception)
            {

                Alumno unAlumno = NConsultar(id);

                aportaciones.EnfermedadMaternidad = (unAlumno.sueldo - (3 * Convert.ToDecimal(UMA))) * 0.004m;
                aportaciones.InvalidezVida = unAlumno.sueldo * 0.00625m;
                aportaciones.Retiro = 0;
                aportaciones.Cesantia = unAlumno.sueldo * 0.01125m;
                aportaciones.Infonavit = 0;
            }



            return aportaciones;
        }

    }
}
