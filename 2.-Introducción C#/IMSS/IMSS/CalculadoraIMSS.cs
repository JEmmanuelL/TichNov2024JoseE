using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMSS
{
    public class CalculadoraIMSS
    {
       
        public static void Calcular(decimal SBC, decimal UMA, sbyte Person)
        {
            Aportaciones aportaciones = new Aportaciones();

            string Person1 = "";

            if (Person == 1)
            {
                aportaciones.EnfermedadMaternidad = (SBC-UMA)* 0.011m;
                aportaciones.InvalidezVida = SBC* 0.0175m;
                aportaciones.Retiro = SBC* 0.02m;
                aportaciones.Cesantia=SBC*0.0315m;
                aportaciones.Infonavit = SBC* 0.05m;
                Person1 = "Patrón";
            }
            else
            {
                aportaciones.EnfermedadMaternidad = (SBC - (3*UMA)) * 0.004m;
                aportaciones.InvalidezVida = SBC * 0.00625m;
                aportaciones.Retiro = 0;
                aportaciones.Cesantia = SBC * 0.01125m;
                aportaciones.Infonavit = 0;
                Person1 = "Trabajador";
            }

            Console.WriteLine($"\n\nCalculadora del IMSS\nSu Salario Base es {SBC.ToString("C2")} MXN y el UMA ingresado es {UMA.ToString("C2")}");
            Console.WriteLine($"El calculo se realizo basado en que su rol es {Person1}\n");
            Console.WriteLine($"La prestación obtenida para Enfermedades y Maternidad es de {aportaciones.EnfermedadMaternidad.ToString("C2")}\n");
            Console.WriteLine($"La prestación obtenida para Invalidez y vida es de {aportaciones.InvalidezVida.ToString("C2")}\n");
            Console.WriteLine($"La prestación obtenida para Retiro es de {aportaciones.Retiro.ToString("C2")}\n");
            Console.WriteLine($"La prestación obtenida para Cesantia es de {aportaciones.Cesantia.ToString("C2")}\n");
            Console.WriteLine($"La prestación obtenida para Credito Infonavit es de {aportaciones.Infonavit.ToString("C2")}\n");
            Console.ReadKey();
        }

        public static void Presentacion()
        {

            decimal SBC = 0;
            decimal UMA = 0;
            sbyte Person = 0;

            Console.WriteLine("Calculadora del IMSS\n Ingrese su Salario Base");
            SBC = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Ingrese la Unidad de Medida de Actualización (UMA)");
            UMA = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Si es Patrón ingrese 1 si es trabajador ingrese 2");
            Person = Convert.ToSByte(Console.ReadLine());
            //Console.ReadKey();

            Calcular(SBC, UMA, Person);
        }



    }



}

