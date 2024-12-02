using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace LINQ
{
    public class ISRCal
    {
        public static List<ItemISR> _ListISR = new List<ItemISR>();

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
           // Console.WriteLine("Total de lineas:  {0}", _fila);
            //_fila = archivo.ReadToEnd().Length;
           // Console.WriteLine("Impresion de line: " + linea + "Impresion de fila: " + _fila + "Impresion de columna: " + _columna);

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
           // Console.WriteLine("\nTabla Cargada Correctamente\n", contador);
            archivo.Close();
            _matrix = _matrix2;
        }

        private static decimal[,] _matrix = new decimal[21, 6];

        private static int _fila = new int();

        private static int _columna = new int();


        public static List<ItemISR> Calcular(decimal SueldoMens)
        {

            SueldoMens = SueldoMens / 2;

            // Llenar la lista a partir de la matriz
            for (int i = 0; i < _matrix.GetLength(0); i++)
            {
                ItemISR lineaISR = new ItemISR();
                {
                    lineaISR.Liminf = _matrix[i, 1];
                    lineaISR.LimSup = _matrix[i, 2];
                    lineaISR.CuotaFija = _matrix[i, 3];
                    lineaISR.PorExced = _matrix[i, 4];
                    lineaISR.Subsidio = _matrix[i, 5];
                };
                _ListISR.Add(lineaISR);
            }
            return _ListISR;
        }
    }
}
