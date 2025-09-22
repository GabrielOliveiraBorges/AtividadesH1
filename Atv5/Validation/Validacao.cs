using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace Atv5.Models
{
    public class CodigoProdutoValidationAttribute : ValidationAttribute
    {
       
        public override bool IsValid(object value)
        {
            if (value == null)
            {
                return false; 
            }

            string codigoProduto = value.ToString();
            var regex = new Regex(@"^[A-Z]{3}-\d{4}$"); 

            return regex.IsMatch(codigoProduto); 
        }
    }
}
