using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDListas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int m = 1;
            do
            {
                sbyte opc;
                Console.WriteLine("1. Consultar Todos\n2.Consultar Solo uno\n3.Agregar\n4.Actualizar\n5.Eliminar\n6.Terminar");
                opc = Convert.ToSByte(Console.ReadLine());

                CRUDList objEstatus = new CRUDList();
                try
                {

                    switch (opc)
                    {
                        case 1:

                            List<Estatus> lis = objEstatus.ConsultarTodos();

                            for (int i = 0; i < lis.Count; i++)
                            {
                                Console.WriteLine("id: {0}, nombre: {1}, clave: {2}", lis[i]._id, lis[i]._nombre, lis[i]._clave);
                            }


                            break;
                        case 2:
                            Console.WriteLine("\ningrese el id del estado a consultar");
                            int id = Convert.ToInt32(Console.ReadLine());
                            Estatus objEstatus2 = objEstatus.ConsultarUno(id);
                            Console.WriteLine("id: {0} nombre: {1} clave: {2}", objEstatus2._id, objEstatus2._nombre, objEstatus2._clave);
                            break;

                        case 3:
                            Estatus objEstatus2Agregar = new Estatus();
                            Console.WriteLine("ingrese el id del Estatus Agregar");
                            objEstatus2Agregar._id = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("ingrese el nombre del estatus a Agregar");
                            objEstatus2Agregar._nombre = Console.ReadLine();
                            Console.WriteLine("ingrese el nombre del estatus a Agregar");
                            objEstatus2Agregar._clave = Console.ReadLine();
                            objEstatus.Agregar(objEstatus2Agregar);
                            break;
                
                        case 4:
                            Estatus objEstaUpd = new Estatus();
                            Console.WriteLine("ingrese el id del Estatus Actualizar");
                            objEstaUpd._id = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("ingrese el nombre del estatus a Actualizar");
                            objEstaUpd._nombre = Console.ReadLine();
                            Console.WriteLine("ingrese el nombre del estatus a Actualizar");
                            objEstaUpd._clave = Console.ReadLine();
                            objEstatus.Actualizar(objEstaUpd);
                            Console.Clear();

                            break;

                        case 5:
                            Console.WriteLine("ingrese el id del estado a Eliminar");
                            id = Convert.ToInt32(Console.ReadLine());
                            objEstatus.Eliminar(id);
                            Console.Clear();

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

            } while (m==1);

        }
    }
}
