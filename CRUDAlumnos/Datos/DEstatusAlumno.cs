using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DEstatusAlumno
    {
        public List<EstatusAlumno> Consultar()
        {
            List < EstatusAlumno > ListAlu = new List<EstatusAlumno>();

            return ListAlu;
        }

        public EstatusAlumno Consultar(int id)
        {
            EstatusAlumno Estatus = new EstatusAlumno();
            return Estatus;
        }

        public int Agregar(EstatusAlumno DataEstatus)
        {
            int Result = 0;

            return Result;
        }

        public int Actualizar(EstatusAlumno DataEstatus)
        {
            int Result = 0;

            return Result;
        }

        public int Eliminar(int id)
        {
            int Result = 0;

            return Result;
       
        }
    }
}
