using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDListas
{
    public class CRUDList
    {
        private static List<Estatus> _lista = new List<Estatus>();

        protected internal List<Estatus> ConsultarTodos()
        {
            if (_lista.Count() == 0)
            {
                throw new Exception("No hay datos para consultar");
            }
            else
            {
                return _lista;
            }
        }

        protected internal Estatus ConsultarUno(int id)
        {
            try
            {
                if (_lista.Count() == 0)
                {
                    throw new Exception("No hay datos para consultar");
                }
                else
                {
                    return _lista.Find(x => x._id == id) == null ? throw new Exception("No hay datos para consultar") : _lista.Find(x => x._id == id);
                }
;
            }
            catch (Exception)
            {
                throw new Exception("No existe el ID ingresado: " + id);
            }

        }
        
        protected internal void Agregar(Estatus objEstatus)
        {
            try
            {
                _lista.Add(objEstatus);
            }
            catch (Exception)
            {
                throw new Exception("No existe el ID ingresado: " + objEstatus._id);
            }
        }


        protected internal void Actualizar(Estatus objEstado)
        {
            try
            {
                Estatus li = _lista.Find(x => x._id == objEstado._id);
                if (li != null)
                {
                    li._id = objEstado._id;
                    li._nombre = objEstado._nombre;
                    li._clave = objEstado._clave;
                }
                else
                {
                    throw new Exception("No existe el ID ingresado: " + objEstado._id);

                }


            }
            catch (Exception)
            {
                throw new Exception("No existe el ID ingresado: " + objEstado._id);
            }
        }

        protected internal void Eliminar(int id)
        {
            try
            {
                Estatus li = _lista.Find(x => x._id == id);

                if (li != null)
                {
                    _lista.Remove(li);
                }
                else
                {
                    throw new Exception("No existe el ID ingresado: " + id);

                }

            }
            catch (Exception)
            {
                throw new Exception("No existe el ID ingresado: " + id);
            }


        }
    }


}

