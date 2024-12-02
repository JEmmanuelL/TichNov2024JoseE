using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public class Cuadrado : IFigura
    {
        public Cuadrado(decimal lado)
        {
   
            this.lado = lado;
        }

        public decimal lado { get; set; }


        public void Area()
        {
            Console.WriteLine($"El Área del Cuadrado es: {lado*lado*lado*lado}");
        }

        public void Perimetro()
        {
            Console.WriteLine($"El Perimetro del Cuadrado es: {lado + lado + lado + lado}");
        }
    }
}
