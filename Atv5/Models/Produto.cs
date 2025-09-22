using System.ComponentModel.DataAnnotations;

namespace Atv5.Models
{
    public class Produto
    {
        [Required(ErrorMessage = "A descrição é obrigatória.")]
        [StringLength(200, MinimumLength = 3, ErrorMessage = "A descrição deve ter entre 3 e 200 caracteres.")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "O preço é obrigatório.")]
        [Range(0.01, double.MaxValue, ErrorMessage = "O preço deve ser maior que 0.")]
        public decimal Preco { get; set; }

        [Required(ErrorMessage = "O estoque é obrigatório.")]
        [Range(0, int.MaxValue, ErrorMessage = "O estoque não pode ser negativo.")]
        public int Estoque { get; set; }

        [Required(ErrorMessage = "O código do produto é obrigatório.")]
        [CodigoProdutoValidation(ErrorMessage = "O código do produto deve seguir o formato 'AAA-1234', onde 'AAA' são 3 letras maiúsculas e '1234' são 4 dígitos.")]
        public string CodigoProduto { get; set; }
    }
}
