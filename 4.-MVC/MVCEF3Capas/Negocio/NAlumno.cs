using Datos;
using Entidades;
using Negocio.RefWCFAlumnos;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NAlumno
    {
        private RefWCFAlumnos.WCFAlumnosClient _wcfAlumnos = new RefWCFAlumnos.WCFAlumnosClient();

        InstitutoTichEntities _DBContext = new InstitutoTichEntities();
        //private List<Alumnos> _lstAlumnos;
        //private Alumnos _oAlumno;

        DRepositorio<Alumnos> RAlumno = new DRepositorio<Alumnos>();


        public List<Alumnos> NConsultar()
        {
            //_DBContext.Configuration.LazyLoadingEnabled = true;
            //_lstAlumnos = _DBContext.Alumnos.ToList();

            return RAlumno.RConsultar(); ;
        }
        public Alumnos NConsultar(int idAlumno)
        {
            //_DBContext.Configuration.LazyLoadingEnabled = true;
            //_oAlumno = _DBContext.Alumnos.Find(idAlumno);
            return RAlumno.RConsultas(idAlumno);
        }
        public void NAgregar(Alumnos DataAlumno){
            
            try
            {
                //_DBContext.Alumnos.Add(DataAlumno);
                //_DBContext.SaveChanges();

                RAlumno.RAgregar(DataAlumno);

            }
            catch (Exception)
            {
                return;
            }
        }
        public void NActualizar(Alumnos DataEstatus) {
            //_DBContext.Entry(DataEstatus).State = EntityState.Modified;
            //_DBContext.SaveChanges();

            try
            {
                DataEstatus.sueldo = Convert.ToDecimal(DataEstatus.sueldo);

                RAlumno.RActualzizar(DataEstatus);
            }
            catch (Exception)
            {

                throw;
            }


        }

        public void NEliminar(int idAlumno)
        {
            //_oAlumno = _DBContext.Alumnos.Find(idAlumno);

            //_DBContext.Alumnos.Remove(_oAlumno);
            //_DBContext.SaveChanges();

            try
            {
                RAlumno.REliminar(idAlumno);
            }
            catch (Exception)
            {

                throw;
            }

        }


        public AportacionesIMSS CalcularIMSS(int id)
        {
            try
            {
                AportacionesIMSS wfcIMSS = _wcfAlumnos.CalcularIMSS(id);

                return wfcIMSS;
            }
            catch (Exception)
            {
                throw;
            }

        }

        public ItemTablaISR CalcularISR(int id)
        {
            try
            {
                ItemTablaISR wdcISR = _wcfAlumnos.CalcularISR1(id);

                return wdcISR;
            }
            catch (Exception)
            {

                throw;
            }

            
        }

    }
}
