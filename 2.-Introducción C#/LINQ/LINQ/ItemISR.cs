using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    public class ItemISR
    {
        public ItemISR()
        {
        }

        public ItemISR(decimal liminf, decimal limSup, decimal cuotaFija, decimal porExced, decimal subsidio)
        {
            Liminf = liminf;
            LimSup = limSup;
            CuotaFija = cuotaFija;
            PorExced = porExced;
            Subsidio = subsidio;
        }

        public decimal Liminf { get; set; }
        public decimal LimSup { get; set; }
        public decimal CuotaFija { get; set; }
        public decimal PorExced { get; set; }
        public decimal Subsidio { get; set; }

    }
}
