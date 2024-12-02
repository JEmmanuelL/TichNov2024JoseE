using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuGeneral
{
    public class Poliza
    {
        public static EstructuraPolizaResultado Calcular(DateTime FechaI,string TipoPoli,decimal DuracionPoli, decimal SumaAseg, DateTime FechaNacimiento, sbyte Genero)
        {
            decimal[,] TablaFactor = new decimal[12, 3] { 
            { 20m, 0m,0.05m },
            { 30m, 0m,0.1m },
            { 40m, 0m,0.4m },
            { 50m, 0m,0.5m },
            { 60m, 0m,0.65m },
            { 61m, 0m,0.85m },
            { 20m, 1m,0.05m },
            { 30m, 1m,0.1m },
            { 40m, 1m,0.4m },
            { 50m, 1m,0.55m },
            { 60m, 1m,0.7m },
            { 61m, 1m,0.9m }
            };

            decimal FactorPorcen = 0;

            decimal Edad = 0;

            DateTime fecha = DateTime.Now;

            TimeSpan fechaDiff = fecha.Subtract(FechaNacimiento);
            Edad = (decimal)  Math.Round((fechaDiff.TotalDays/365.25)); //365.25 porque existen los años bisiestos

            for (int i = 0; i < 12; i++)
            {
                if (i == 11 && Edad == 0)
                {
                    FactorPorcen = 0.9m;
                }
                else
                {
                    if ((Edad >= TablaFactor[i,0] && Edad < TablaFactor[(i+1),0] ) && TablaFactor[i, 1] == Genero)
                    {
                        FactorPorcen = TablaFactor[i, 2];
                    }

                }

            }


            decimal DiasDuraPoli = 0;

            EstructuraPolizaResultado ResultadoPoliza = new EstructuraPolizaResultado();

            switch (TipoPoli)
            {
                case "año":
                case "años":
                    ResultadoPoliza._FechaTermino = FechaI.AddYears((int)DuracionPoli);

                    TimeSpan YearsDiff = FechaI.Subtract(ResultadoPoliza._FechaTermino);
                    DiasDuraPoli = (decimal)YearsDiff.TotalDays * -1;

                    break;
                case "mes":
               case "meses":
                    ResultadoPoliza._FechaTermino = FechaI.AddMonths((int)DuracionPoli);

                    TimeSpan MothDiff = FechaI.Subtract(ResultadoPoliza._FechaTermino);
                    DiasDuraPoli = (decimal)MothDiff.TotalDays * -1;

                    break;
                case "dia":
                case "dias":
                    ResultadoPoliza._FechaTermino = FechaI.AddDays((double)DuracionPoli);

                    TimeSpan DaysDiff = FechaI.Subtract(ResultadoPoliza._FechaTermino);
                    DiasDuraPoli = (decimal)DaysDiff.TotalDays * -1;

                    break;
                default:
                    DuracionPoli = 0;
                    break;
            }


            //ResultadoPoliza._FechaTermino = FechaI.AddDays((double)DiasDuraPoli);

            ResultadoPoliza._Prima = Math.Round((SumaAseg * FactorPorcen) * (DiasDuraPoli / 360));

            
            return ResultadoPoliza;

        }

        public static void Presentacion()
        {

            //DateTime FechaI = Convert.ToDateTime(Console.ReadLine());
            bool p1 = true;
            bool p2 = true;
            bool p3 = true;
            bool p4 = true;
            bool p5 = true;
            DateTime FechaI = DateTime.Now;
            decimal periodoPoli = 0;
            string TiempoPolizaC = null;
            decimal SumaAse = 0;
            DateTime FechaNac = DateTime.Now;
            string Genero = null;
            sbyte Genero1 = 0;
            EstructuraPolizaResultado rest = new EstructuraPolizaResultado();


            do
            {
                Console.WriteLine("Proporciona la fecha de inicio de Vigencia\n");
                if (DateTime.TryParse(Console.ReadLine(), out FechaI) == false)
                {
                    Console.WriteLine("Ingreso una fecha invalida\n");
                }
                else
                {
                    p1 = false;
                }
            } while (p1 == true);

            //string TiempoPolizaC = Console.ReadLine();
            do
            {
                Console.WriteLine("\nProporciona para cuanto tiempo requieres la póliza (ejemplo 2 años)");
                TiempoPolizaC = Console.ReadLine();
                string[] partesTimePoliza = TiempoPolizaC.Split(' ');
                TiempoPolizaC = partesTimePoliza[1].ToLower().Trim();
                if (decimal.TryParse(partesTimePoliza[0], out periodoPoli) & ((TiempoPolizaC == "años" || TiempoPolizaC == "meses" || TiempoPolizaC == "dias") || (TiempoPolizaC == "año" || TiempoPolizaC == "mes" || TiempoPolizaC == "dia")))
                {
                    p2 = false;
                }
                else
                {
                    Console.WriteLine("\nIngreso una fecha invalida\n");
                }
            } while (p2 == true);


            do
            {
                Console.WriteLine("\nProporciona la suma asegurada");
                if (decimal.TryParse(Console.ReadLine(), out SumaAse) == false)
                {
                    Console.WriteLine("Ingreso una cantidad invalida\n");
                }
                else
                {
                    p3 = false;
                }
            } while (p3 == true);


            do
            {
                Console.WriteLine("\nProporciona la fecha de Nacimiento del asegurado");
                if (DateTime.TryParse(Console.ReadLine(), out FechaNac) == false)
                {
                    Console.WriteLine("Ingreso una fecha invalida\n");
                }
                else
                {
                    p4 = false;
                }
            } while (p4 == true);

            do
            {
                Console.WriteLine("\nProporciona el género del asegurado (masculino o femenino)");
                Genero = Console.ReadLine().ToLower().Trim();

                if (Genero == "masculino" || Genero == "femenino")
                {
                    p5 = false;
                    Genero1 = Genero == "masculino" ? (sbyte) 1 : (sbyte) 0;
                }
                else
                {
                    Console.WriteLine("Ingreso un género invalido\n");
                }
            } while (p5 == true);


            rest = Calcular(FechaI, TiempoPolizaC, periodoPoli, SumaAse, FechaNac, Genero1);


            Console.WriteLine($"\nLa poliza vencerá el: {rest._FechaTermino.ToLongDateString()}\n");

            Console.WriteLine($"\nLa Prima a pagar es de: {rest._Prima.ToString("c2")} pesos\n");

            Console.ReadKey();
        }
    }
}
