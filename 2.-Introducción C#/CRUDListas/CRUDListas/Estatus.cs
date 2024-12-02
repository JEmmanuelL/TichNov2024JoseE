using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDListas
{
    public class Estatus
    {
        public Estatus()
        {
        }

        public Estatus(int id, string nombre,string clave)
        {
            this._id = id;
            this._nombre = nombre;
            this._clave = clave;
        }

        public int _id { get; set; }

        public string _nombre { get; set; }

        public string _clave { get; set; }

    }
}
