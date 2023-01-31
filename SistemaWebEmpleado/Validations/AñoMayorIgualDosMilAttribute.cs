using System;
using System.ComponentModel.DataAnnotations;

namespace SistemaWebEmpleado.Validations
{
    public class AñoMayorIgualDosMilAttribute : ValidationAttribute
    {

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value == null) return ValidationResult.Success;
            var fecha = Convert.ToDateTime(value.ToString());
            if (fecha.Year < 2000) {
                return new ValidationResult("El año debe ser mayor o igual a 2000.");
            }

            return ValidationResult.Success;
        }

    }
}
