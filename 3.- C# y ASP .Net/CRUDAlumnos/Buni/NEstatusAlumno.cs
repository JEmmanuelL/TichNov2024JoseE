using Entity;
using System.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace BusinessLogic
{
    public class NEstatusAlumno
    {

        public List<EstatusAlumno> NConsultar() => DEstatusAlumno.DConsultar();

        public EstatusAlumno NConsultar(int id) => DEstatusAlumno.DConsultar(id);

        public int NAgregar(EstatusAlumno DataEstatus) => DEstatusAlumno.DAgregar(DataEstatus);

        public int NActualizar(EstatusAlumno DataEstatus) => DEstatusAlumno.DActualizar(DataEstatus);

        public int NEliminar(int id) => DEstatusAlumno.DEliminar(id);

    }
}
