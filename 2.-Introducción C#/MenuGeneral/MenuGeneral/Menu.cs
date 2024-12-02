using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuGeneral
{
    public class Menu
    {
        public static void MostrarMenu()
        {
            string Opc = "0";

            while (Opc != "F"){
                Console.WriteLine("\n\nMenu General\n" +
                    "1.- Arreglos Cadenas\n" +
                    "2.- Arreglo Num Enteros\n" +
                    "3.- Arreglo ConvierteATipoOracion\n" +
                    "4.- Presentación de la clase Poliza\n" +
                    "5.- Mostrar Archivo Txt\n" +
                    "6.- MostrarCSV\n" +
                    "7.- EscribirTxt\n" +
                    "8.- Calculo de Impuesto Sobre la Renta\n" +
                    "F.- Para salir");
                Opc = Console.ReadLine();

                switch (Opc)
                {
                    case "1":
                        Console.WriteLine("Selecciono el programa... 1\n");
                        ArreglosC.Cadenas();
                        break;
                    case "2":
                        Console.WriteLine("Selecciono el programa... 2\n");
                        ArreglosC.Enteros();
                        break;
                    case "3":
                        Console.WriteLine("Selecciono el programa... 3\n");
                        ArreglosC.ConvierteATipoOracion();
                        break;
                    case "4":
                        Console.WriteLine("Selecciono el programa... 4\n");
                        Poliza.Presentacion();
                        break;
                    case "5":
                        Console.WriteLine("Selecciono el programa... 5\n");
                        Archivotxt.PresentacionTxt();
                        break;
                    case "6":
                        Console.WriteLine("Selecciono el programa... 6\n");
                        Archivotxt.Presentacion2Txt();
                        break;
                    case "7":
                        Console.WriteLine("Selecciono el programa... 7\n");
                        Archivotxt.Presentacion3Txt();
                        break;
                    case "8":
                        Console.WriteLine("Selecciono el programa... 8\n");
                        ISR.PresentacionISR();
                        break;
                    case "F":
                    case "f":
                        Opc = "F";
                        break;
                    default:
                        Console.WriteLine("Seleccione una opción del menu por favor!!!! :p\n");
                        Opc = "0";
                        MostrarMenu();
                        break;
                }
            }
        }
    }
}
