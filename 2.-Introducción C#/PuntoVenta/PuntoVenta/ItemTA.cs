using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoVenta
{
    public class ItemTA : ItemBase
    {
        public string telefono { get; set; }

        public string company { get; set; }

        public decimal comision { get; set; }

        public override decimal Total()
        {
            return Subtotal() + comision;
        }

        public override string Imprimir()
        {
            return id + " " + nombre + " Precio: " + precio.ToString("c2") + " Cantidad: " + cantidad + " Subtotal: " + Subtotal().ToString("c2") + "\n Telefono: " + telefono + " Compañia" + company + " Comisión: " +comision+ "\n Total: " + Total().ToString("c2");
        }
    }
}
