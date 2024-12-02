using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDEstados
{
    internal class Program
    {
        static void Main(string[] args)
        {
        
            do
            {
                sbyte opc;
                Console.WriteLine("1. Consultar Todos\n2.Consultar Solo uno\n3.Agregar\n4.Actualizar\n5.Eliminar\n6.Terminar");
                opc = Convert.ToSByte(Console.ReadLine());

                CRUD objCRUD = new CRUD();
                try
                {

                switch (opc)
                {
                    case 1:
                        Dictionary<int, Estado> dicEstado = objCRUD.ConsultarTodos();
                        foreach (KeyValuePair<int, Estado> kvp in dicEstado)
                        {
                            Console.WriteLine(" id: {0} nombre: {1}", kvp.Key, kvp.Value.nombreEstado);
                        }
                        Console.Clear();  
                        break;
                    case 2:
                        Console.WriteLine("\ningrese el id del estado a consultar");
                        int id = Convert.ToInt32(Console.ReadLine());
                        Estado objEstado = objCRUD.ConsultarUno(id);
                        Console.WriteLine("id: {0} nombre: {1}", objEstado.id, objEstado.nombreEstado);
                        break;
                        Console.Clear();

                    case 3:
                        Estado objEstadoAgregar = new Estado();
                        Console.WriteLine("ingrese el id del estado Agregar");
                        objEstadoAgregar.id = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("ingrese el nombre del estado a Agregar");
                        objEstadoAgregar.nombreEstado = Console.ReadLine();
                        objCRUD.Agregar(objEstadoAgregar);
                        break;
                        Console.Clear();

                    case 4:
                        Estado objEstadoActualizar = new Estado();
                        Console.WriteLine("ingrese el id del estado a Actualizar");
                        objEstadoActualizar.id = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("ingrese el nombre del estado a Actualizar");
                        objEstadoActualizar.nombreEstado = Console.ReadLine();
                        objCRUD.Actualizar(objEstadoActualizar);
                        Console.Clear();

                        break;

                    case 5:
                        Console.WriteLine("ingrese el id del estado a Eliminar");
                        id = Convert.ToInt32(Console.ReadLine());
                        objCRUD.Eliminar(id);
                        Console.Clear();

                        break;
                            default:  
                            break;
                            break;
                
                }
                }
                catch (Exception e)
                {

                    Console.WriteLine("\nOcurrió un error inesperado los detalles son: " + e.Message+ "\n");
                }

            } while(true);

        }
    }
}
