

using SistemaWebEmpleado.Validations;
using System;
using System.ComponentModel.DataAnnotations;

namespace SistemaWebEmpleado.Models
{
    public class Empleado
    {

        public int Id { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public string Apellido { get; set; }

        public int DNI { get; set; }
        [Required]
        [RegularExpression("^AA[0-9]{5}$")]
        public string Legajo { get; set; }

        [AñoMayorIgualDosMil]
        public DateTime FechaNacimiento { get; set; }
        [Required]
        public string Titulo { get; set; }

    }
}
