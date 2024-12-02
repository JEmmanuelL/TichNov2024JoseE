using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuGeneral
{
    public struct EstructuraPolizaResultado
    {
        public EstructuraPolizaResultado(DateTime FechaTermino, decimal Prima)
        {
            _Prima = Prima;
            _FechaTermino = FechaTermino;
        }

        public decimal _Prima { get; set; }
        public DateTime _FechaTermino { get; set; }

    }
}
