using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDEstados
{
    public class CRUD
    {

        private static Dictionary<int, Estado> _diccionarioEstados = new Dictionary<int, Estado>();

        protected internal Dictionary<int, Estado> ConsultarTodos()
        {

            try
            {
                if (_diccionarioEstados.Count() == 0 || _diccionarioEstados.Count() == null)
                {
                    throw new Exception("No hay datos para consultar");
                }
                else
                {
                    return _diccionarioEstados;
                }
            }
            catch (Exception)
            {
                throw new Exception("No hay datos para consultar");
            }

        }

        protected internal Estado ConsultarUno(int id)
        {

            try
            {
                return _diccionarioEstados[id];
            }
            catch (Exception)
            {
                throw new Exception("No existe el ID ingresado: " + id);
            }


        }

        protected internal void Agregar(Estado objEstado)
        {
            try
            {
                _diccionarioEstados.Add(objEstado.id, objEstado);
            }
            catch (Exception)
            {
                throw new Exception("No existe el ID ingresado: "+objEstado.id);
            }
        }

        protected internal void Actualizar(Estado objEstado)
        {
            try
            {
                _diccionarioEstados[objEstado.id] = objEstado;
            }
            catch (Exception)
            {
                throw new Exception("No existe el ID ingresado: " + objEstado.id);
            }
        }

        protected internal void Eliminar(int id)
        {
            try
            {
                _diccionarioEstados.Remove(id);
            }
            catch (Exception)
            {
                throw new Exception("No existe el ID ingresado: " +id);
            }


        }
    }
}
