using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    public class OperacionesLINQ
    {
        public static void CargarLists( out List<Alumno> ListaAlumn,out List<Estado> ListaEstado,out List<Estatus> ListaEstatus, out List<ItemISR> TablaISR)
        {
            ListaAlumn = new List<Alumno>();
            string nombreArchivo = null;
            Console.WriteLine("Ingrese la ruta del archivo completo con todo y extensión para alumno");
            nombreArchivo = Console.ReadLine();
            StreamReader archivo = new StreamReader(nombreArchivo);
            var JSON = archivo.ReadToEnd();
            archivo.Close();
            ListaAlumn = JsonConvert.DeserializeObject<List<Alumno>>(JSON);

            ListaEstado = new List<Estado>();
            nombreArchivo = null;
            Console.WriteLine("\nIngrese la ruta del archivo completo con todo y extensión para Estado");
            nombreArchivo = Console.ReadLine();
             archivo = new StreamReader(nombreArchivo);
            JSON = archivo.ReadToEnd();
            archivo.Close();
            ListaEstado = JsonConvert.DeserializeObject<List<Estado>>(JSON);

            ListaEstatus = new List<Estatus>();
            nombreArchivo = null;
            Console.WriteLine("\nIngrese la ruta del archivo completo con todo y extensión para Estatus");
            nombreArchivo = Console.ReadLine();
             archivo = new StreamReader(nombreArchivo);
            JSON = archivo.ReadToEnd();
            archivo.Close();
            ListaEstatus = JsonConvert.DeserializeObject<List<Estatus>>(JSON);

            TablaISR = new List<ItemISR>();
            nombreArchivo = null;
            Console.WriteLine("\nIngrese la ruta del archivo completo con todo y extensión para la Tabla ISR");
            nombreArchivo = Console.ReadLine();
            ISRCal.CargarTabla(nombreArchivo);
            
        }

        public static void Consultas()
        {
            CargarLists(out List<Alumno> ListaAlumn, out List<Estado> ListaEstado, out List<Estatus> ListaEstatus, out List<ItemISR> TablaISR);
            try
            {
                //Ejercicios
                //7.2.1.1 De la lista de estados, obtener el estado que tiene el id = 5  
                Estado ListaFind = new Estado();
                //ListaFind = ListaEstado.Find(x => x.id == 5) == null ? throw new Exception("No hay datos para consultar") : ListaEstado.Find(x => x.id == 5);
                var ListaEsta1 =
                        from Estado in ListaEstado
                        where Estado.id == 5
                        select Estado;
                Console.WriteLine("\n--- De la lista de estados, obtener el estado que tiene el id = 5  ---");

                if(ListaEsta1 == null)
                {
                    Console.WriteLine("\n--- No se encontro  ---");
                }
                else
                {
                    foreach (var item in ListaEsta1.ToList())
                    {
                        Console.WriteLine("\nid: {0} Nombre del Estado: {1}", item.id, item.nombre);
                    }
                }
                
                //7.2.1.2 De la lista de alumnos obtener a los alumnos cuyo idEstado 29 y 13, Ordenado por nombre 
                var ListaAluF =
                        from Alumno in ListaAlumn
                        where Alumno.idEstado == 29 || Alumno.idEstado == 13
                        orderby Alumno.nombre ascending
                        select Alumno;
                Console.WriteLine("\n--- Lista de Alumnos cuyo idEstado 29 y 13, Ordenado por nombre ---");


                if (ListaAluF == null)
                {
                    Console.WriteLine("\n--- No se encontro  ---");
                }
                else
                {
                    foreach (var item in ListaAluF.ToList())
                    {
                        Console.WriteLine("id: {0} Nombre: {1} Calificación: {2} idEstado: {3} idEstatus: {4}", item.id, item.nombre, item.calificacion, item.idEstado, item.idEstatus);
                    }
                }

              
                //7.2.1.3 De la lista de alumnos obtener los alumnos que son IdEstado 19 y 20 y además de que estén en el estatus 4 o 5
                ListaAluF =
                       from Alumno in ListaAlumn
                       where (Alumno.idEstado == 19 || Alumno.idEstado == 20) && (Alumno.idEstatus == 4 || Alumno.idEstatus == 5)
                       orderby Alumno.nombre ascending
                       select Alumno;
                Console.WriteLine("\n--- Lista de Alumnos cuyo idEstado 19 y 20 y además de que estén en el estatus 4 o 5 ---");

                if (ListaAluF == null)
                {
                    Console.WriteLine("\n--- No se encontro  ---");
                }
                else
                {
                    foreach (var item in ListaAluF.ToList())
                    {
                        Console.WriteLine("id: {0} Nombre: {1} Calificación: {2} idEstado: {3} idEstatus: {4}", item.id, item.nombre, item.calificacion, item.idEstado, item.idEstatus);
                    }
                }


                //7.2.1.4.  Obtener una lista de los alumnos que tienen calificación aprobatoria, considerando esta como 6 o mayor, ordenado por calificación del mayor al menor

                ListaAluF =
                        from Alumno in ListaAlumn
                        where (Alumno.calificacion >= 6)
                        orderby Alumno.calificacion descending
                        select Alumno;
                Console.WriteLine("\n--- Lista de Alumnos que tienen calificación aprobatoria ---");


                if (ListaAluF == null)
                {
                    Console.WriteLine("\n--- No se encontro  ---");
                }
                else
                {
                    foreach (var item in ListaAluF.ToList())
                    {
                        Console.WriteLine("id: {0} Nombre: {1} Calificación: {2} idEstado: {3} idEstatus: {4}", item.id, item.nombre, item.calificacion, item.idEstado, item.idEstatus);
                    }
                }

                

                //7.2.1.5.  Obtener la calificación promedio de los alumnos
                List<Alumno> listaAluF2 = new List<Alumno>();
                listaAluF2 =
                       (from Alumno in ListaAlumn
                        select Alumno).ToList();

                if (listaAluF2 == null)
                {
                    Console.WriteLine("\n--- No se encontro  ---");
                }
                else
                {
                    Console.WriteLine("\n--- Calificación promedio de los alumnos: {0} ---", listaAluF2.Average(e => e.calificacion));

                }

                /* 7.2.1.6. En caso de que ningún alumno tenga 10, sumarles un punto 
                             de calificación, y en caso de que todos estén entre 6 y 7 sumarles 
                             dos puntos. */
                listaAluF2 =
                        (from Alumno in ListaAlumn
                         select Alumno).ToList();
                if (listaAluF2 == null)
                {
                    Console.WriteLine("\n--- No se encontro  ---");
                }
                else
                {
                    if (listaAluF2.All(z => (z.calificacion < 10)))
                    {
                        foreach (var item in listaAluF2.ToList())
                        {
                            item.calificacion = (int)item.calificacion + 1;
                        }
                    }
                    else
                    {
                        if (listaAluF2.All(z => (z.calificacion >= 6 && z.calificacion <= 7)))
                        {
                            foreach (var item in listaAluF2.ToList())
                            {
                                item.calificacion = (int)item.calificacion + 2;
                            }
                        }
                    }
                }

            

                /*7.2.1.7. Mostar en la consola los siguientes datos, de aquellos
                            alumnos que estén en estatus 3: 
                            • idAlumnos, 
                            • nombreAlumno, 
                            • nombre del Estado al que pertenece */

                var ListaAluF3 =
                       (from Alumno in ListaAlumn
                        join Estado in ListaEstado on Alumno.idEstado equals Estado.id
                        where Alumno.idEstatus == 3
                        select new { Alumno.id, Nombrealumno = Alumno.nombre, NombreEstado = Estado.nombre });
                Console.WriteLine("\n--- Lista de Alumnos que estén en estatus 3 ---");

                if (ListaAluF3 == null)
                {
                    Console.WriteLine("\n--- No se encontro  ---");
                }
                else
                {

                    foreach (var item in ListaAluF3.ToList())
                    {
                        Console.WriteLine("id: {0} Nombre: {1} Nombre del Estado: {2}", item.id, item.Nombrealumno, item.NombreEstado);
                    }
                }


                /*7.2.1.8. Mostar en la consola los siguientes datos, de aquellos 
                            alumnos que estén en estatus 2, ordenado por nombre del Alumno: 
                            • idAlumnos, 
                            • nombreAlumno, 
                            • nombre del Estatus en que se encuentran */

                var ListaAluF4 =
                       (from Alumno in ListaAlumn
                        join Estatus in ListaEstatus on Alumno.idEstatus equals Estatus.id
                        where Alumno.idEstatus == 2
                        orderby Alumno.nombre ascending
                        select new { Alumno.id, Nombrealumno = Alumno.nombre, NombreEstatus = Estatus.nombre });
                Console.WriteLine("\n--- Lista de Alumnos que estén en estatus 2 con orden ---");

                if (ListaAluF4 == null)
                {
                    Console.WriteLine("\n--- No se encontro  ---");
                }
                else
                {
                    foreach (var item in ListaAluF4.ToList())
                    {
                        Console.WriteLine("id: {0} Nombre: {1} Nombre del Estatus: {2}", item.id, item.Nombrealumno, item.NombreEstatus);
                    }
                }


                /* 7.2.1.9. Mostar en la consola los siguientes datos, de aquellos 
                            alumnos cuyo estatus sea mayor a 2, ordenado por nombre del 
                            estatus: 
                            • idAlumnos, 
                            • nombreAlumno, 
                            • nombre del Estado al que pertenece 
                            • nombre del Estatus en que se encuentran */

                var ListaAluF5 =
                       (from Alumno in ListaAlumn
                        join Estado in ListaEstado on Alumno.idEstado equals Estado.id
                        join Estatus in ListaEstatus on Alumno.idEstatus equals Estatus.id
                        where Alumno.idEstatus > 2
                        orderby Estatus.nombre ascending
                        select new { Alumno.id, Nombrealumno = Alumno.nombre, NombreEstado = Estado.nombre, NombreEstatus = Estatus.nombre });
                Console.WriteLine("\n--- Lista de Alumnos cuyo estatus sea mayor a 2... ---");

                if (ListaAluF5 == null)
                {
                    Console.WriteLine("\n--- No se encontro  ---");
                }
                else
                {
                    foreach (var item in ListaAluF5.ToList())
                    {
                        Console.WriteLine("id: {0} Nombre: {1} Nombre del Estado: {2} Nombre del Estatus: {3}", item.id, item.Nombrealumno, item.NombreEstado, item.NombreEstatus);
                    }
                }

   
                /*7.2.1.10. Calcular el impuesto para un sueldo mensual de 22,000, y 
                            mostrarlo en la consola: 
                            • La búsqueda en la tablaISR de los parámetros 
                            correspondientes para el cálculo del ISR deben de ser a través 
                            de LINQ */
                TablaISR = ISRCal.Calcular(22000);
                decimal SueldoM = 22000;
                decimal ISRCalulado = 0;
                var listaAluF6 = from ISR in TablaISR
                                 where ISR.Liminf <= SueldoM && ISR.LimSup >= SueldoM
                                 select ISR;
                SueldoM = SueldoM / 2;
                foreach (var item in listaAluF6)
                {
                    ISRCalulado = ((((SueldoM - item.Liminf) * item.PorExced) / 100) + item.CuotaFija) - item.Subsidio;
                }

                Console.WriteLine("\nEl impuesto a pagar por un sueldo de $ 22,000 pesos es de: {0}", ISRCalulado.ToString("c2"));
                Console.ReadKey();
            }
            catch (Exception e)
            {

                Console.WriteLine("\nOcurrió un error inesperado los detalles son: " + e.Message + "\n");
            }


        }

    }
}
