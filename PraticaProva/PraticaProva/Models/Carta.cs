using System.ComponentModel.DataAnnotations;

namespace PapaiNoelAPI.Models
{
    public class Carta
    {
        public int Id { get; set; }  // Identificador da carta (chave primária futura)

        [Required]
        [StringLength(255, MinimumLength = 3)]
        public string NomeCrianca { get; set; } = string.Empty;

        [Required]
        public Endereco Endereco { get; set; } = new Endereco();

        [Required]
        [Range(0, 14)]
        public int Idade { get; set; }

        [Required]
        [StringLength(500)]
        public string Texto { get; set; } = string.Empty;

        public DateTime DataEnvio { get; set; } = DateTime.UtcNow;
    }
}
