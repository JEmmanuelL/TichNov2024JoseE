using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDEstados
{
    public class Estado
    {
        public Estado()
        {
        }

        public Estado(int id, string nombreEstado)
        {
            this.id = id;
            this.nombreEstado = nombreEstado;
        }

        public int id { get; set; }

        public string nombreEstado { get; set; }
    }
}
