using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroduccionCS
{
    internal class Cadenas
    {
        public static string HolaMundo(string nombre, string PrimerA, string SegA, sbyte Edad)
        {
            string Salida = null;

            Salida = "Hola " + nombre+" "+PrimerA+" "+SegA+"\n";

            Salida += String.Format("{0} {1} {2} tiene {3} años \n",nombre,PrimerA,SegA,Edad);

            Salida += $"Gusto en conocerte {nombre.ToUpper()} {PrimerA.ToUpper()} {SegA.ToUpper()}!!!\n";

            Salida += "El archivo fue guardado en:  \n";

            Salida += String.Format(@"c:\Documentos\DiplomadoNet\{0}{1}{2}.docx", nombre, PrimerA, SegA, Edad);


            return Salida;
        }
    }
}
