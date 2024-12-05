using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class ItemTablaISR
    {
        public ItemTablaISR()
        {
        }

        public ItemTablaISR(decimal limitInf, decimal limitSup, decimal cuotaFija, decimal excedente, decimal subsidio, decimal iSR)
        {
            LimitInf = limitInf;
            LimitSup = limitSup;
            CuotaFija = cuotaFija;
            Excedente = excedente;
            Subsidio = subsidio;
            ISR = iSR;
        }

        public decimal LimitInf { get; set; }

        public decimal LimitSup { get; set; }

        public decimal CuotaFija { get; set; }

        public decimal Excedente { get; set; }
        public decimal Subsidio { get; set; }
        public decimal ISR { get; set; }
    }
}
