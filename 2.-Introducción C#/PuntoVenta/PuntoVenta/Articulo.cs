﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoVenta
{
    public class Articulo
    {
        public Articulo()
        {
        }

        public Articulo(int id, string nombre, decimal precio, int tipo)
        {
            this.id = id;
            this.nombre = nombre;
            this.precio = precio;
            this.tipo = tipo;
        }

        public int id { get; set; }

        public string nombre { get; set; }

        public decimal precio { get; set; }

        public int tipo { get; set; }
    }
}
