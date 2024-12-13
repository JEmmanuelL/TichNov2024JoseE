using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;


namespace Datos
{
    public class DRepositorio<T> : IRepositorioBase<T> where T : class
    {

        InstitutoTichEntities _DBContext = new InstitutoTichEntities();


        public List<T> RConsultar()
        {
            return (List<T>) _DBContext.Set<T>().ToList();

        }

        public List<T> RConsultar(System.Linq.Expressions.Expression<Func<T, bool>> predicado)
        {

            return (List<T>)_DBContext.Set<T>().Where(predicado).ToList();
        }

        public T RConsultas(int id)
        {
            return _DBContext.Set<T>().Find(id);
        }

        public T RConsultas(System.Linq.Expressions.Expression<Func<T, bool>> predicado)
        {
            return _DBContext.Set<T>().FirstOrDefault<T>(predicado);
        }

        public void RAgregar(T entidad)
        {
            _DBContext.Set<T>().Add(entidad);
            _DBContext.SaveChanges();
        }


        public void RActualzizar(T entidad)
        {
            _DBContext.Entry(entidad).State = EntityState.Modified;
            _DBContext.SaveChanges();

        }


        public void REliminar(int id)
        {
            T elemento = _DBContext.Set<T>().Find(id);
            _DBContext.Entry(elemento).State = EntityState.Deleted;
            _DBContext.SaveChanges();

        }

        public void REliminar(T entidad)
        {
            _DBContext.Entry(entidad).State = EntityState.Deleted;
            _DBContext.SaveChanges();

        }

        public void REliminar(System.Linq.Expressions.Expression<Func<T, bool>> predicado)
        {
                             //Primero se hace lo de aqui               //   Luego lo de aqui
            _DBContext.Entry(_DBContext.Set<T>().Where(predicado).ToList()).State = EntityState.Deleted;
            _DBContext.SaveChanges();
        }
    }
}
