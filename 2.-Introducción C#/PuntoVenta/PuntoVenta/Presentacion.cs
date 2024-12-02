using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using Newtonsoft.Json;
using System.Text;
using System.Threading.Tasks;

namespace PuntoVenta
{
    public class Presentacion
    {

        public static List<Articulo> _listaArti = new List<Articulo>();

        public static List<ItemBase> _Ticket = new List<ItemBase>();


        public static void Vender()
        {
            string nombreArchivo = @"C:\Users\Tichs\Documents\JELJ\Semana2_Intro_NET_C#\PuntoVenta\Articulos.json";
            CargarArticulos(nombreArchivo);

            string ParaVenta = "V";
            string terminarVenta = " ";
            try
            {
                do
                {
                    Console.WriteLine("\n--- Iniciar una nueva Venta presione ( V ) terminar una venta ( T ) ---");
                    ParaVenta = Console.ReadLine().ToUpper();

                    if (ParaVenta == "V" || ParaVenta == "v")
                    {
                        do
                        {
                               /* Console.WriteLine("\nMenu de ID's de los Articulos " +
                                                        "1.-Lápiz" +
                                                        "2.-Pluma" +
                                                        "3.-Cuaderno" +
                                                        "4.-Libreta" +
                                                        "5.-Libro" +
                                                        "6.-Folder" +
                                                        "7.-Marcador" +
                                                        "8.-Tiempo Aire");
                                    */
                                item producto = new item();

                                Console.WriteLine("\nIngrese el id del articulo");
                                producto.id = Convert.ToInt32(Console.ReadLine());

                                if(producto.id != 8)
                                {
                                Console.WriteLine("\nIngrese la cantidad de compra del articulo");
                                producto.cantidad = Convert.ToInt32(Console.ReadLine());
                                }
                                else
                                {
                                producto.cantidad = 1;
                                }

                            Console.WriteLine("\n--- Para ingresar más productos al carrito ( CONTI )\nPara Terminar la venta ingrese ( TV ) ---");
                                terminarVenta= Console.ReadLine().ToUpper();

                                            var ProductoEncontrado =
                                            from Articulo in _listaArti
                                            where Articulo.id == producto.id
                                            select Articulo;

                                            if (ProductoEncontrado == null)
                                            {
                                                throw new Exception("No ha encontrado productos");
                                            }
                                            else
                                            {
                                                foreach (var item in ProductoEncontrado.ToList())
                                                {
                                                    switch (item.tipo)
                                                    {
                                                        case 1:
                                                            //Con descuento
                                                            ItemDescuento articuloDesc = new ItemDescuento();
                                                            articuloDesc.id = item.id;
                                                            articuloDesc.nombre = item.nombre;
                                                            articuloDesc.precio = item.precio;
                                                            articuloDesc.cantidad = producto.cantidad;
                                                            Console.WriteLine("\nIngrese el descuento del articulo: " + item.nombre + " Ej. 30");
                                                            articuloDesc.Descuento = Convert.ToInt32(Console.ReadLine());
                                                            Console.WriteLine(articuloDesc.Imprimir());
                                                            _Ticket.Add(articuloDesc);


                                                            break;
                                                        case 2:
                                                            //Sin descuento
                                                            item articulo = new item();
                                                            articulo.id = item.id;
                                                            articulo.nombre = item.nombre;
                                                            articulo.precio = item.precio;
                                                            articulo.cantidad = producto.cantidad;
                                                            Console.WriteLine(articulo.Imprimir());
                                                            _Ticket.Add(articulo);

                                                            break;
                                                        case 3:
                                                            //Recarga
                                                            ItemTA Recarga = new ItemTA();
                                                            Console.WriteLine("\nProporcione el número de Telefono");
                                                            Recarga.telefono = Console.ReadLine();

                                                            Console.WriteLine("\nProporcione la compañia telefonica");
                                                            Recarga.company = Console.ReadLine();

                                                            Console.WriteLine("\nProporcione la comisión por la recarga telefonica");
                                                            Recarga.comision = Convert.ToDecimal(Console.ReadLine());

                                                            Recarga.id = item.id;
                                                            Recarga.nombre = item.nombre;
                                                            Recarga.precio = item.precio;
                                                            Recarga.cantidad = producto.cantidad;
                                                            Console.WriteLine(Recarga.Imprimir());
                                                            _Ticket.Add(Recarga);

                                                            break;
                                                        default:
                                                            throw new Exception("Error con el tipo del Articulo");
                                                            break;
                                                    }
                                                }
                                            }





                        } while (terminarVenta != "TV");

                        
                        /* for (int i = 0; i < _Ticket.Count; i++)
                         {
                              List<ItemBase>ProductoRep = _Ticket.FindAll(x => x.id == i);
                             if(ProductoRep.Count > 1)
                             {
                                 var PrimerItem = _Ticket.First(x => x.id == i);

                                 for (int j = 1; j < ProductoRep.Count; j++)
                                 { 
                                     PrimerItem.cantidad = PrimerItem.cantidad + ProductoRep[j].cantidad;
                                    // PrimerItem.precio = PrimerItem.Total() + ProductoRep[j].Total();
                                    // Console.WriteLine($"\nFOR item Completado: {PrimerItem.id} {PrimerItem.nombre} {PrimerItem.Total()} {PrimerItem.cantidad} {PrimerItem.precio}");
                                    _Ticket.RemoveAt(j);

                                 }


                             }
                         }*/
                        //ItemBase ProductoRep = _Ticket.FindAll(x => x.id )

                        decimal total = 0;
                        Console.WriteLine("\nVenta finalizada");
                        Console.WriteLine("Empresa TICH");


                        foreach (var producto in _Ticket)
                        {
                            //Console.WriteLine($"\nID: {producto.id} Articulo: {producto.nombre} Precio: {producto.precio} Cantidad: {producto.cantidad} {producto.Total()}");
                            // total += producto.Total();
                            Console.WriteLine( producto.Imprimir());
                        }
                        //Console.WriteLine($"\nTotal de la compra: {total}");
                        Console.WriteLine($"\nTotal de la compra: {_Ticket.Sum(e => e.Total())}");


                    }
                    else if(ParaVenta != "T")
                    {
                        throw new Exception("No ha ingresado un caracter correcto para continuar la operación");
                    }


                } while (ParaVenta == "V");

            }
            catch (Exception e)
            {

                Console.WriteLine("\nOcurrió un error inesperado los detalles son: " + e.Message + "\n");
            }



        }

        public static void CargarArticulos(string nombreArchivo)
        {
            StreamReader archivo = new StreamReader(nombreArchivo);
            var JSON = archivo.ReadToEnd();
            archivo.Close();
            _listaArti = JsonConvert.DeserializeObject<List<Articulo>>(JSON);

        }
    }
}
