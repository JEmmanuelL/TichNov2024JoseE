using Datos;
using Entidades;
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
        InstitutoTichEntities _DBContext = new InstitutoTichEntities();
        private List<Alumnos> _lstAlumnos;
        private Alumnos _oAlumno;
        public List<Alumnos> NConsultar()
        {
            _DBContext.Configuration.LazyLoadingEnabled = true;
            _lstAlumnos = _DBContext.Alumnos.ToList();

            return _lstAlumnos;
        }
        public Alumnos NConsultar(int idAlumno)
        {
            _DBContext.Configuration.LazyLoadingEnabled = true;
            _oAlumno = _DBContext.Alumnos.Find(idAlumno);
            return _oAlumno;
        }
        public void NAgregar(Alumnos DataAlumno){

            try
            {
                _DBContext.Alumnos.Add(DataAlumno);
                _DBContext.SaveChanges();
            }
            catch (Exception)
            {
                return;
            }
        }
        public void NActualizar(Alumnos DataEstatus) {
            _DBContext.Entry(DataEstatus).State = EntityState.Modified;
            _DBContext.SaveChanges();
            
        }

        public void NEliminar(int idAlumno)
        {
            _oAlumno = _DBContext.Alumnos.Find(idAlumno);

            _DBContext.Alumnos.Remove(_oAlumno);
            _DBContext.SaveChanges();
        }
    }
}
