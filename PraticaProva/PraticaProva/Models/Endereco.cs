using System.ComponentModel.DataAnnotations;

namespace PapaiNoelAPI.Models
{
    public class Endereco
    {
        [Required]
        public string Rua { get; set; } = string.Empty;

        [Required]
        public string Numero { get; set; } = string.Empty;

        [Required]
        public string Bairro { get; set; } = string.Empty;

        [Required]
        public string Cidade { get; set; } = string.Empty;

        [Required]
        public string Estado { get; set; } = string.Empty;

        [Required]
        [RegularExpression(@"^\d{5}-\d{3}$", ErrorMessage = "CEP inválido (formato esperado: 00000-000)")]
        public string Cep { get; set; } = string.Empty;
    }
}
