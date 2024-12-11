using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    [MetadataType(typeof(AlumnosDataAnnotations))]

    public partial class Alumnos
    {
    }

    public class AlumnosDataAnnotations
    {
        [Key]
        public int id { get; set; }
        [DisplayName("Nombre")]
        [Required(ErrorMessage = "El {0} es obligatorio")]
        [RegularExpression(@"(\s*[a-zA-Z]+\s*[a-zA-Z]*)+", ErrorMessage = "El {0} solo acepta letras y espacios")]
        public string nombre { get; set; }

        [DisplayName("Primer Apellido")]
        [Required(ErrorMessage = "El {0} es obligatorio")]
        [RegularExpression(@"(\s*[a-zA-Z]+\s*[a-zA-Z]*)+", ErrorMessage = "El {0} solo acepta letras y espacios")]
        public string primerApellido { get; set; }

        [DisplayName("Segundo Apellido")]
        [RegularExpression(@"(\s*[a-zA-Z]+\s*[a-zA-Z]*)+", ErrorMessage = "El {0} solo acepta letras y espacios")]
        public string segundoApellido { get; set; }

        [Required(ErrorMessage = "El {0} es obligatorio")]
        public string correo { get; set; }
        public string telefono { get; set; }

        [Required(ErrorMessage = "El {0} es obligatorio")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        [RangoFexa("1990-01-01","2000-12-31",ErrorMessage = "La fecha debe estar entre {1} y {2}")]
        public System.DateTime fechaNacimiento { get; set; }

        [Required(ErrorMessage = "El {0} es obligatorio")]
        [RegularExpression(@"^[A-Z]{4}[0-9]{6}[A-Z]{6}\w{2}", ErrorMessage = "El {0} no tiene el formato")]
        public string curp { get; set; }

        [Range(10000, 40000, ErrorMessage = "El valor debe estar entre el {1} y el {2}")]
        public Nullable<decimal> sueldo { get; set; }


    }


}
