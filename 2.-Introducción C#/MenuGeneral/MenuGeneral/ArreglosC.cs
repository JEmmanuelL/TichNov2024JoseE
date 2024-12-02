using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuGeneral
{
    public class ArreglosC
    {
        public static void Cadenas()
        {
            string nombreC = null;
            Console.WriteLine("Proporciona tu nombre completo\n");
            nombreC = Console.ReadLine();
            string[] partesNombre = nombreC.Split(' ');
            Console.WriteLine("\nHola");
            foreach (string parte in partesNombre)
            {
                Console.WriteLine(parte);
            }
            Console.WriteLine("\nApellido Vertical\n");
            char[] letras = partesNombre[(partesNombre.Length - 1)].ToCharArray();
            foreach (char c in letras)
            {
                Console.WriteLine(c);
            }
            Console.ReadKey();
        }

        public static void Enteros()
        {
            int[] NumerosEntC = new int[5];

            for (int i = 0; i < NumerosEntC.Length; i++)
            {
                Console.WriteLine("Ingrese 1 numero Entero");
                NumerosEntC[i] = Convert.ToInt32(Console.ReadLine());
            }


            for (int i = 0; i < (NumerosEntC.Length - 1); i++)
            {
                NumerosEntC[i + 1] = (NumerosEntC[i] > NumerosEntC[i + 1]) ? NumerosEntC[i] : NumerosEntC[i + 1];
            }
            Console.WriteLine("\n El número mayor es: " + NumerosEntC[(NumerosEntC.Length - 1)]);
            Console.ReadKey();




        }

        public static void ConvierteATipoOracion()
        {
            string Oracion = null;
            string palabra = null;
            Console.WriteLine("Ingrese una oracion\n");
            Oracion = Console.ReadLine().ToLower();
            string[] PartesOracion = Oracion.Split(' ');
            for (int i = 0; i < PartesOracion.Length; i++)
            {
                palabra =PartesOracion[i].Substring(1);
                PartesOracion[i] = PartesOracion[i].Substring(0,1).Replace(PartesOracion[i].Substring(0, 1), PartesOracion[i].Substring(0, 1).ToUpper()) + palabra;
            }
            Oracion = null;
            foreach (string parte in PartesOracion)
            {
                Oracion += parte+" ";
            }
            Console.WriteLine(Oracion);
            Console.ReadKey();

        }
    }
}
