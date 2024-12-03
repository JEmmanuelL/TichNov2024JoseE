using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolaMundoWindowsForm
{
    internal class CRUDEstados
    {
        List<Estado> _ListaEStados = new List<Estado>
        {
            new Estado {id=1,nombre= "Aguascalientes"},
            new Estado {id=2,nombre= "Veracruz"},
             new Estado {id=3,nombre= "Hidalgo"},
              new Estado {id=4,nombre= "Puebla"}
        };

    public List<Estado> Consultar()
        {
            return _ListaEStados;
        }

        public Estado ConsultarUNO(int id)
        {
            return _ListaEStados.Find(x => x.id == id);
        }





    }
}
