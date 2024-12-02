using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace MenuGeneral
{
    public class ISR
    {
        public static void CargarTabla(string nombreArchivo)
        {

            int contador = 0;
            string linea = null;
            //Leer Archivo  
            StreamReader archivo = new StreamReader(nombreArchivo);
            while ((linea = archivo.ReadLine()) != null)
            {
                _fila++;
                string[] PartesOracion1 = linea.Split(',');
                _columna = PartesOracion1.Length;

            }
            decimal[,] _matrix2 = new decimal[_fila, _columna];

            //_fila = contador;
            Console.WriteLine("Total de lineas:  {0}", _fila);
            //_fila = archivo.ReadToEnd().Length;
            Console.WriteLine("Impresion de line: " + linea + "Impresion de fila: " + _fila + "Impresion de columna: " + _columna);

            linea = null;
            archivo.Close();

            archivo = new StreamReader(nombreArchivo);

            while ((linea = archivo.ReadLine()) != null)
            {
                string[] PartesOracion = linea.Split(',');

                for (int i = 0; i < PartesOracion.Length; i++)
                {
                    _matrix2[contador, i] = Convert.ToDecimal(PartesOracion[i]);
                    //Console.WriteLine(PartesOracion[i]);
                }
                contador++;

            }
            Console.WriteLine("\nTabla Cargada Correctamente\n", contador);
            archivo.Close();
            _matrix = _matrix2;
        }

        private static decimal[,] _matrix = new decimal[21, 6];

        private static int _fila = new int();

        private static int _columna = new int();


        public  static decimal Calcular(decimal SueldoMens)
        {
            decimal ISRCal = 0;

            SueldoMens = SueldoMens / 2;

            int Fila = 0;

          for (int j = 0; j < _fila; j++)
            {
                      if (SueldoMens > _matrix[j,1] && SueldoMens < _matrix[j, 2])
                    {
                        Fila = j;
                    }
            }

            ISRCal = ((((SueldoMens - _matrix[Fila, 1]) * _matrix[Fila, 4]) / 100) + _matrix[Fila, 3])- _matrix[Fila, 5];
            
            return ISRCal;
        }

        public static void PresentacionISR()
        {
            string nombreArchivo = null;
            decimal SueldoMens = 0;
            decimal ISRCalculado = 0;

            Console.WriteLine("Ingrese la ruta dela archivo completo con todo y extensión\n");
            nombreArchivo = Console.ReadLine();
            CargarTabla(nombreArchivo);

            Console.WriteLine("Ingrese el sueldo mensual\n");
            if (decimal.TryParse(Console.ReadLine(), out SueldoMens) == false)
            {
                Console.WriteLine("Ingreso una cantidad invalida\n");
            }

            ISRCalculado = Calcular(SueldoMens);

            Console.WriteLine($"El ISR a pagar es {ISRCalculado}");

        }
    }
}
