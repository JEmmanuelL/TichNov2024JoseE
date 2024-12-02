using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoVenta
{
    public abstract class ItemBase
    {
        public ItemBase()
        {
        }

        public ItemBase(int id, string nombre, decimal precio, int cantidad)
        {
            this.id = id;
            this.nombre = nombre;
            this.precio = precio;
            this.cantidad = cantidad;
        }

        public int id { get; set; }
        public string nombre { get; set; }
        public decimal precio { get; set; }
        public int cantidad { get; set; }

        public virtual decimal Subtotal()
        {
            return precio * cantidad;
        }

        public virtual decimal Total()
        {
            return precio * cantidad;
        }

        public abstract string Imprimir();
    }
}
