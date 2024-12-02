using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoVenta
{
    public class item : ItemBase
    {
        public item()
        {

        }

        public item(int id, string nombre, decimal precio, int cantidad) : base(id,nombre,precio,cantidad){

        } 

        public override string Imprimir()
        {
            return id+" "+nombre+" Precio: "+precio.ToString("c2")+" Cantidad: "+cantidad+" Subtotal: "+Subtotal().ToString("c2") + "\n Total: " + Total().ToString("c2");
        }
    }
}
