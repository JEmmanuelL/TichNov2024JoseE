using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolaMundo
{
    internal class Saludo
    {

        public static string SaludarEstatico(string nombre )
        {
            return "Hola. ¿Como estas "+nombre+"?, " + "Saludando desde un método Estatico";
        }

        public string SaludarNoEstatico(string nom)
        {
           return "Hola. ¿Como estas " + nom + "?, " + "Saludando desde un método No Estatico";
        }


    }
}
