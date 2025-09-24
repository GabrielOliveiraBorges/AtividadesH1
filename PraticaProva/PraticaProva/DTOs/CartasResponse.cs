using PapaiNoelAPI.Models;

namespace PapaiNoelAPI.DTOs
{
    public class CartaResponse
    {
        public int Id { get; set; }
        public string NomeCrianca { get; set; } = string.Empty;
        public Endereco Endereco { get; set; } = new Endereco();
        public int Idade { get; set; }
        public string Texto { get; set; } = string.Empty;
        public DateTime DataEnvio { get; set; }
    }
}
