using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDADO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ADOEstatus aDOEstatus = new ADOEstatus();

            int m = 1;
            do
            {
                sbyte opc;
                Console.WriteLine("1. Consultar Todos\n2.Consultar Solo uno\n3.Agregar\n4.Actualizar\n5.Eliminar\n6.Terminar");
                opc = Convert.ToSByte(Console.ReadLine());
                try
                {

                    switch (opc)
                    {
                        case 1:
                            aDOEstatus.ConsultarTodos();
                            break;
                        case 2:
                            Console.WriteLine("\ningrese el id del estado a consultar");
                            int id = Convert.ToInt32(Console.ReadLine());
                            aDOEstatus.ConsultarUno(id);

                            break;

                        case 3:
                           
                            Console.WriteLine("ingrese el nombre de clave a Agregar");
                            string clv = Console.ReadLine();
                            Console.WriteLine("ingrese el nombre a Agregar");
                            string name = Console.ReadLine();
                            aDOEstatus.Agregar(clv, name);

                            break;

                        case 4:
                            Console.WriteLine("ingrese el id del Estatus Actualizar");
                            id = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("ingrese el nombre del estatus a Actualizar");
                            clv = Console.ReadLine();
                            Console.WriteLine("ingrese el nombre del estatus a Actualizar");
                           name = Console.ReadLine();
                            aDOEstatus.Actualizar(id, clv, name);
                            break;

                        case 5:
                            Console.WriteLine("ingrese el id del estado a Eliminar");
                            id = Convert.ToInt32(Console.ReadLine());
                            aDOEstatus.Eliminar(id);
                            break;
                        default:
                            m = 0;
                            break;

                    }
                }
                catch (Exception e)
                {

                    Console.WriteLine("\nOcurrió un error inesperado los detalles son: " + e.Message + "\n");
                }

            } while (m == 1);


        }
    }
}
