using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace Atv5.Validations
{
    public class CustomValidationRa : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value == null)
                return new ValidationResult("O RA é obrigatório.");

            string ra = value.ToString();

            // Regex: começa com RA + 6 dígitos
            if (!Regex.IsMatch(ra, @"^RA\d{6}$"))
                return new ValidationResult("O RA deve começar com 'RA' seguido de 6 dígitos numéricos.");

            return ValidationResult.Success;
        }
    }
}
