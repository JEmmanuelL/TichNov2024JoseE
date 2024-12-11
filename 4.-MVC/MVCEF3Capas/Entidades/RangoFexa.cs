using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System.ComponentModel.DataAnnotations

{
    public class RangoFexa : ValidationAttribute
    {
        public RangoFexa(string fechaInicial, string fechaFinal)
        {
            _fechaInicial = Convert.ToDateTime(fechaInicial);
            _fechaFinal = DateTime.Parse(fechaFinal);
        }

        public DateTime _fechaInicial { get; set; }
        public DateTime _fechaFinal { get; set; }

        public override string FormatErrorMessage(string name)
        {
            return String.Format(ErrorMessage,name,_fechaInicial.ToString("yyyy-MM-dd"),_fechaFinal.ToString("yyyy-MM-dd"));
        }

        public override bool IsValid(object value)
        {
            if(value != null)
            {
                DateTime fechaIngresada = (DateTime)value;
                return (fechaIngresada >= _fechaInicial && fechaIngresada <= _fechaFinal);
            }
            else
            {
                return false;
            }
           
        }


    }
}
