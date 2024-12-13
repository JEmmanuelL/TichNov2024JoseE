using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{

    public interface IRepositorioBase<T> where T : class
    {
        List<T> RConsultar();

        List<T> RConsultar(Expression<Func<T, bool>> predicado);

        T RConsultas(int id);

        T RConsultas(Expression<Func<T, bool>> predicado);

        void RAgregar(T entidad);

        void RActualzizar(T entidad);

        void REliminar(int id);

        void REliminar(T entidad);

        void REliminar(Expression<Func<T,bool>> predicado);


    }
}
