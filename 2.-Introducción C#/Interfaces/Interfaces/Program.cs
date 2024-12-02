using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IFigura[] ArrayFig = new IFigura[2] { new Cuadrado(5), new Triangulo(5,11) };

            ArrayFig[0].Area();
            ArrayFig[0].Perimetro();
            ArrayFig[1].Area();
            ArrayFig[1].Perimetro();

            Console.ReadKey();
        }
    }
}
