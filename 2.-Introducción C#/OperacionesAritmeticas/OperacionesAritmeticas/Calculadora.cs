using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperacionesAritmeticas
{
    public class Calculadora
    {
        public static decimal Sumar(decimal Ope1, decimal Ope2)
        {
            return Ope1 + Ope2; 
        }

        public static decimal Restar(decimal Ope1, decimal Ope2)
        {
            return Ope1 - Ope2;
        }
        public static decimal Multi(decimal Ope1, decimal Ope2)
        {
            return Ope1 * Ope2;
        }

        public static decimal Div(decimal Ope1, decimal Ope2)
        {
            return Ope1 / Ope2;
        }

        public static decimal Mod(decimal Ope1, decimal Ope2)
        {
            return Ope1 % Ope2;
        }

        public static decimal Operacion(OperacionAritmetica ObjOperacion)
        {
            decimal result = 0;
            switch (ObjOperacion.VarOperador)
            {
                case tipoOperacion.sumar:
                    result = Sumar(ObjOperacion.VarOpe1, ObjOperacion.VarOpe2);
                 break;
                case tipoOperacion.restar:
                    result = Restar(ObjOperacion.VarOpe1, ObjOperacion.VarOpe2);
                    break;
                case tipoOperacion.multiplicar:
                    result = Multi(ObjOperacion.VarOpe1, ObjOperacion.VarOpe2);
                    break;
                case tipoOperacion.divir:
                    result = Div(ObjOperacion.VarOpe1, ObjOperacion.VarOpe2);
                    break;
                case tipoOperacion.modulo:
                    result = Mod(ObjOperacion.VarOpe1, ObjOperacion.VarOpe2);
                    break;
                    default:
                    result = 404;
                    break;
            }
            return result;
        }

        public static Resultado Simultaneas(decimal Ope1, decimal Ope2)
        {
            Resultado result = new Resultado();

           result.Suma = Sumar(Ope1, Ope2);
           result.resta = Restar(Ope1, Ope2);
           result.multiplicacion = Multi(Ope1, Ope2);
           result.division = Div(Ope1, Ope2);
           result.modulo = Mod(Ope1, Ope2);

            return result;
        }

        public static void Presentacion()
        {
            OperacionAritmetica Valores = new OperacionAritmetica();
            Console.WriteLine("Operación a Realizar\n 1.Sumar\n 2.Restar\n 3.Multiplicar\n 4.Dividir\n 5.Módulo\n 6.Todas");
            Valores.VarOperador = (tipoOperacion)Convert.ToSByte(Console.ReadLine());
            //Console.ReadKey();
            Console.WriteLine("Proporciona el primer operador \n");
            Valores.VarOpe1 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Proporciona el segundo operador \n");
            Valores.VarOpe2 = Convert.ToDecimal(Console.ReadLine());


            if(Valores.VarOperador == (tipoOperacion)6)
            {
                Resultado result = Calculadora.Simultaneas(Valores.VarOpe1,Valores.VarOpe2);
                Console.WriteLine($"El resultado de la suma es {result.Suma}\n ");
                Console.WriteLine($"El resultado de la resta es {result.resta}\n ");
                Console.WriteLine($"El resultado de la multiplicación es {result.multiplicacion}\n ");
                Console.WriteLine($"El resultado de la división es {result.division}\n ");
                Console.WriteLine($"El resultado del módulo es {result.modulo}\n ");

            }
            else
            {
                decimal result = Calculadora.Operacion(Valores);
                Console.WriteLine($"El resultado de {Valores.VarOperador.ToString()} es {result}");
            }
        }

    }
}
