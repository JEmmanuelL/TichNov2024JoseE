using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{

    public class NEstatus
    {

        InstitutoTichEntities _DBContext = new InstitutoTichEntities();
        private List<EstatusAlumnos> _lstEstatusAlu;

        public List<EstatusAlumnos> NConsultar()
        {
            _DBContext.Configuration.LazyLoadingEnabled = true;
            _lstEstatusAlu = _DBContext.EstatusAlumnos.ToList();

            return _lstEstatusAlu;
        }
        public EstatusAlumnos NConsultar(int id)
        {
            return new EstatusAlumnos();
        }
        public void NAgregar(EstatusAlumnos DataEstatus)
        {


        }
        public void NActualizar(EstatusAlumnos DataEstatus)
        {

        }

        public void NEliminar(int id)
        {

        }



    }
}
