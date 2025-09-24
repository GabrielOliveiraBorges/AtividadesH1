using System.ComponentModel.DataAnnotations;
using PapaiNoelAPI.Models;

namespace PapaiNoelAPI.DTOs
{
    public class CartaRequest
    {
        [Required(ErrorMessage = "O nome da criança é obrigatório")]
        [StringLength(255, MinimumLength = 3, ErrorMessage = "O nome deve ter entre 3 e 255 caracteres")]
        public string NomeCrianca { get; set; } = string.Empty;

        [Required(ErrorMessage = "O endereço é obrigatório")]
        public Endereco Endereco { get; set; } = new Endereco();

        [Required(ErrorMessage = "A idade é obrigatória")]
        [Range(0, 14, ErrorMessage = "A idade deve ser menor que 15 anos")]
        public int Idade { get; set; }

        [Required(ErrorMessage = "O texto da carta é obrigatório")]
        [StringLength(500, ErrorMessage = "O texto da carta pode ter no máximo 500 caracteres")]
        public string Texto { get; set; } = string.Empty;
    }
}
