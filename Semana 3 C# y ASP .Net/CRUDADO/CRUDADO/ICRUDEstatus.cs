using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDADO
{
    internal interface ICRUDEstatus
    {
        void ConsultarTodos();

        void ConsultarUno(int id);

        void Agregar(string clave, string nombre);

        void Actualizar(int id, string clave, string nombre);

        void Eliminar(int id );

    }
}
