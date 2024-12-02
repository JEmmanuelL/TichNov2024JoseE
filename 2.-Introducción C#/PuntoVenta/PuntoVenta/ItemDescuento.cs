using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoVenta
{
    public class ItemDescuento : ItemBase
    {
        public decimal Descuento { get; set; }

        public  decimal impDescuento {

            get
            {
                return (Subtotal() * Descuento)/100;
            }
        
        }

        public ItemDescuento()
        {
        }

        public ItemDescuento(int id, string nombre, decimal precio, int cantidad) : base(id, nombre, precio, cantidad)
        {

        }

        public override decimal Total()
        {
            return Subtotal() - impDescuento;
        }

        public override string Imprimir()
        {
            return id + " " + nombre + " Precio: " + precio.ToString("c2") + " Cantidad: " + cantidad + " Subtotal: " + Subtotal().ToString("c2")+ "\n Descuento: "+impDescuento+"("+Descuento+"%)"+"\n Total: "+Total().ToString("c2");
        }

    }
}
