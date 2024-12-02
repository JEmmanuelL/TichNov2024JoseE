using System;
using System.Collections.Generic;
using System.Dynamic;
using Newtonsoft.Json;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    public class CreadorJSON
    {



        /*  private static List<string> _NameColu;

         //Crear JSON dinamico con columnas dinamicas por meido de un objeto dinamico
         public static void CrearList()
         {
             sbyte Columna = 0;
             sbyte Fila;
             int rep = 1;
             do
             {
                 Console.WriteLine("Ingrese el nombre de una columna\n");
                 _NameColu.Add(Console.ReadLine());
                 Columna++;
                 Console.WriteLine("¿Desea agregar más columnas?\n1.-Sí\n2.-No");
                 rep=Convert.ToInt32(Console.ReadLine());


             } while (rep == 1);

             dynamic objColum = CrearObjeto(_NameColu);




         }

         public static dynamic CrearObjeto(List<string> atributos)
         {
             // Crear un ExpandoObject para almacenar los atributos
             ExpandoObject objeto = new ExpandoObject();
             var diccionario = (IDictionary<string, object>)objeto;

             // Agregar atributos con valores predeterminados (null)
             foreach (var atributo in atributos)
             {
                 diccionario.Add(atributo, null); // Valor inicial: null
             }

             return objeto;
         }


         */

    }
}
