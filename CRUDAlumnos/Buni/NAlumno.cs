using Datos;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class NAlumno
    {


        public List<Alumno> NConsultar() => DAlumno.DConsultar();


        public Alumno NConsultar(int id) => DAlumno.DConsultar(id);

        public int NAgregar(Alumno DataEstatus) => DAlumno.DAgregar(DataEstatus);
 
        public int NActualizar(Alumno DataEstatus) => DAlumno.DActualizar(DataEstatus);

        public int NEliminar(int id) => DAlumno.DEliminar(id);

    }
}
