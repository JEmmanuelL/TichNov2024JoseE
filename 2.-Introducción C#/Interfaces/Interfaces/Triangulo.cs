using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public class Triangulo : IFigura
    {
        public Triangulo()
        {
        }

        public Triangulo(double base1, double arista)
        {
            this.Base1 = base1;
            this.Arista = arista;
        }

        public double Base1 { get; set; }

        public double Arista { get; set; }



        public void Area()
        {
            double h = Math.Sqrt(  (Arista* Arista) - ((Base1*Base1)/4));
            //Console.WriteLine($"El Área del Triangulo es: {h} {Base1} {Arista}");
            Console.WriteLine($"El Área del Triangulo es: {0.5 * Base1 * h}");
        }

        public void Perimetro()
        {
            //Console.WriteLine($"El Perimetro del Triangulo es: {Base1} {Arista}");

            Console.WriteLine($"El Perimetro del Triangulo es: {Arista+Arista+Base1}");
        }
    }
}
