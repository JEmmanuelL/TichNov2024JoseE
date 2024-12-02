using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperacionesAritmeticas
{
     public struct OperacionAritmetica
    {
        public OperacionAritmetica(decimal Ope1, decimal Ope2,tipoOperacion Operador)
        {
            VarOpe1 = Ope1;
            VarOpe2 = Ope2;
            VarOperador = Operador;
        }

        public decimal VarOpe1 { get; set; }
        public decimal VarOpe2 { get; set; }
        public tipoOperacion VarOperador { get; set; }

    }
}
