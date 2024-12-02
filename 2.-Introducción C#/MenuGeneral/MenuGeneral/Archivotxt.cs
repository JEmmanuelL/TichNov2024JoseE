using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuGeneral
{
    public class Archivotxt
    {

        public static void MostrarTxT(string nombre)
        {
            string linea;

            StreamReader archivo = new StreamReader($@"C:\Users\Tichs\Documents\JELJ\Semana2_Intro_NET_C#\{nombre}");
            linea = archivo.ReadToEnd();
            Console.WriteLine(linea);
            //Console.WriteLine(linea.Length);
            archivo.Close();

        }

        public static void MostrarCSV(string nombreArchivo)
        {
            int contador = 0;
            string linea;
            //Leer Archivo  
            StreamReader archivo = new StreamReader(nombreArchivo);
            while ((linea = archivo.ReadLine()) != null)
            {
               
               string[] PartesOracion = linea.Split(',');

                for (int i = 0; i < PartesOracion.Length; i++)
                {
                    Console.WriteLine(PartesOracion[i]);
                }
                contador++;
            }

            archivo.Close();
            Console.WriteLine("\nTotal de lineas:  {0}\n", contador);
            Console.ReadLine();
            archivo.Close();
        }

        public static void EscribirTxt(string nombreArchivo, bool SobreEscribir, string Formato)
        {
            sbyte i = 1;
            String nuevaLinea = null;
            Encoding codigo;

            while (i == 1)
            {
                switch (Formato)
                {
                    case "UTF7":
                        codigo = Encoding.UTF7;
                        break;
                    case "UTF8":
                        codigo = Encoding.UTF8;
                        break;
                    case "Unicod":
                        codigo = Encoding.Unicode;
                        break;
                    case "UTF32":
                        codigo = Encoding.UTF32;
                        break;
                    case "ASCII":
                        codigo = Encoding.ASCII;
                        break;
                    default:
                        codigo = Encoding.ASCII;
                        break;
                }
                if (File.Exists(nombreArchivo))
                {
                    string[] linea = new string[5];
                    Console.WriteLine("Ingrese su Nombre");
                    linea[0] = Console.ReadLine();
                    Console.WriteLine("\nIngrese su Primer Apellido");
                    linea[1] = Console.ReadLine();
                    Console.WriteLine("\nIngrese su Segundo Apellido");
                    linea[2] = Console.ReadLine();
                    Console.WriteLine("\nIngrese su Edad");
                    linea[3] = Console.ReadLine();
                    Console.WriteLine("\nIngrese su Estado de residencia");
                    linea[4] = Console.ReadLine();
                    // Crea un acrhvio

                    StreamWriter archivo = new StreamWriter(nombreArchivo, SobreEscribir, codigo);
                    nuevaLinea = ($"{linea[0]},{linea[1]},{linea[2]},{linea[3]},{linea[4]},");
                    archivo.WriteLine(nuevaLinea);
                    Console.WriteLine($"Alumno agregado Exitosamente con los siguientes datos: {nuevaLinea}\n\n¿Desea agregar otro alumno?\n1.- Sí\n2.-No");
                    i = Convert.ToSByte(Console.ReadLine());
                    archivo.Close();

                    if (i == 2)
                    {
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("El archivo {0} ya existe", nombreArchivo);
                }
            }
           


        }


        public  static void PresentacionTxt()
        {
            string nombreA = null;
            Console.WriteLine("Ingrese un nombre de archivo\n");
            nombreA = Console.ReadLine();
            MostrarTxT(nombreA);
        }

        public static void Presentacion2Txt()
        {
            string nombreArchivo = null;
            Console.WriteLine("Ingrese la ruta dela archivo completo con todo y extensión\n");
            nombreArchivo = Console.ReadLine();
            MostrarCSV(nombreArchivo);
        }

        public static void Presentacion3Txt()
        {
            string nombreArchivo = null;
            bool? SobreE = null;
            string Codigo = null;
            Console.WriteLine("Ingrese la ruta dela archivo completo con todo y extensión\n");
            nombreArchivo = Console.ReadLine();
            Console.WriteLine("\n1. Agregar nuevos datos al archivo existente\n" +
                              "2. Para Sobreescribir el archivo con nuevos datos\n");
            SobreE = Convert.ToSByte(Console.ReadLine()) == 1 ? (bool) true: (bool) false;
            Console.WriteLine("\nIngrese en que codigo desea escribir ( UTF7, UTF8, Unicod, UTF32, ASCII) \n");
            Codigo = Console.ReadLine();
            EscribirTxt(nombreArchivo, (bool) SobreE, Codigo);
        }

    }
}
