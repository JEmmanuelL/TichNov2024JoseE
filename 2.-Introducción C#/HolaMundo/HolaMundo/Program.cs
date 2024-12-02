using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolaMundo
{
    internal class Program
    {
        static void Main(string[] args) //Firma del método -- Conformado por: 1) Modificador de acceso (static)
                                        //2) Tipo de dato de retorno  (void)
                                        //3) Nombre del Método (Main)
                                        //4) Parametros (strings[] args)  arreglo de string
         
        {   //Definir las variables
            //(Tipo de dato) (nombre);
            string nombre;

            //Para ivocar un método estatico, se coloca el nombre de la clase, seguido del nombre del método
            Console.WriteLine("¿Cuál es tu nombre?");
            //Para acceder a la sobrecarga de un método se coloca una "," entro 2 parentesis "(,)"
            //Sobrecarga del método: la variedad de parametros que se pueden enviar.


            nombre = Console.ReadLine(); //para conocer el tipo de dato de retorno del método, posicionamos el cursos sobre el método 
                                         //Asignando el valor que retorna el método (String)


            // Console.WriteLine("Hola. ¿Como estas "+nombre+"?");

            //Para invocar un método estatico

            String ValorRetorno = Saludo.SaludarEstatico(nombre);

            Console.WriteLine(ValorRetorno);
            //Console.WriteLine(Saludo.SaludarEstatico(nombre));

            Console.ReadKey(); //para detener el resultado esperando que presione una tecla 


            //Para invocar un método no estatico, se coloca el nombre del objeto seguido del nombre del método

            Saludo ObjetoSaludo = new Saludo(); //instanciar la clase para crear un objeto

            ObjetoSaludo.SaludarNoEstatico(nombre);

            Console.WriteLine(ObjetoSaludo.SaludarNoEstatico(nombre));


            Console.ReadKey(); //para detener el resultado esperando que presione una tecla 

        }
    }
}
