using Datos;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class NEstado
    {
        public List<Estado> NConsultar() => DEstado.DConsultar();

        public Estado NConsultar(int id) => DEstado.DConsultar(id);

        public int NAgregar(Estado DataEstatus) => DEstado.DAgregar(DataEstatus);

        public int NActualizar(Estado DataEstatus) => DEstado.DActualizar(DataEstatus);

        public int NEliminar(int id) => DEstado.DEliminar(id);
    }
}
