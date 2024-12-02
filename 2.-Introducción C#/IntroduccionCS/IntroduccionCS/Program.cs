using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroduccionCS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("¿Cuál es tu nombre?");
            string nombre = Console.ReadLine();
            Console.WriteLine("¿Cuál es tu Primer Apellido?");
            string PrimerA = Console.ReadLine();
            Console.WriteLine("¿Cuál es tu Segundo Apellido?");
            string SegA = Console.ReadLine();
            Console.WriteLine("¿Cuál es tu edad?");
            sbyte edad = Convert.ToSByte(Console.ReadLine().Trim());

            Console.WriteLine(Cadenas.HolaMundo(nombre.Trim(), PrimerA.Trim(), SegA.Trim(), edad));
            Console.ReadKey();
        }
    }
}
