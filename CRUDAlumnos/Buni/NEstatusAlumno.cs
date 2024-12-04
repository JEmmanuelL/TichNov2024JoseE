using Entity;
using System.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class NEstatusAlumno
    {
        public List<EstatusAlumno> NConsultar()
        {
            List<EstatusAlumno> ListAlu = new List<EstatusAlumno>();

            return ListAlu;
        }

        public EstatusAlumno NConsultar(int id)
        {
            EstatusAlumno Estatus = new EstatusAlumno();
            return Estatus;
        }

        public int NAgregar(EstatusAlumno DataEstatus)
        {
            int Result = 0;

            return Result;
        }

        public int NActualizar(EstatusAlumno DataEstatus)
        {
            int Result = 0;

            return Result;
        }

        public int NEliminar(int id)
        {
            int Result = 0;

            return Result;

        }
    }
}
