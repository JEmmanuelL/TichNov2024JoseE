using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Negocio
{
    public class NEstado
    {
        InstitutoTichEntities _DBContext = new InstitutoTichEntities();
        private List<Estados> _lstEstados;

        public List<Estados> NConsultar()
        {
            _DBContext.Configuration.LazyLoadingEnabled = true;
            _lstEstados = _DBContext.Estados.ToList();

            return _lstEstados;
        }
        public Estados NConsultar(int id)
        {
            return new Estados();
        }
        public void NAgregar(Estados DataEstatus)
        {


        }
        public void NActualizar(Estados DataEstatus)
        {

        }

        public void NEliminar(int id)
        {

        }
    }
}
