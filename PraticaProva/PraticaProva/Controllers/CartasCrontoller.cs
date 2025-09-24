using Microsoft.AspNetCore.Mvc;
using PapaiNoelAPI.DTOs;
using PapaiNoelAPI.Models;

namespace PapaiNoelAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CartasController : ControllerBase
    {
        private static List<Carta> _cartas = new();

       
        [HttpPost]
        public IActionResult EnviarCarta([FromBody] CartaRequest cartaRequest)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var novaCarta = new Carta
            {
                Id = _cartas.Count + 1,
                NomeCrianca = cartaRequest.NomeCrianca,
                Endereco = cartaRequest.Endereco,
                Idade = cartaRequest.Idade,
                Texto = cartaRequest.Texto,
                DataEnvio = DateTime.UtcNow
            };

            _cartas.Add(novaCarta);

            var response = new CartaResponse
            {
                Id = novaCarta.Id,
                NomeCrianca = novaCarta.NomeCrianca,
                Endereco = novaCarta.Endereco,
                Idade = novaCarta.Idade,
                Texto = novaCarta.Texto,
                DataEnvio = novaCarta.DataEnvio
            };

            return CreatedAtAction(nameof(ObterCartaPorId), new { id = response.Id }, response);
        }

     
        [HttpGet("{id}")]
        public IActionResult ObterCartaPorId(int id)
        {
            var carta = _cartas.FirstOrDefault(c => c.Id == id);
            if (carta == null)
                return NotFound();

            var response = new CartaResponse
            {
                Id = carta.Id,
                NomeCrianca = carta.NomeCrianca,
                Endereco = carta.Endereco,
                Idade = carta.Idade,
                Texto = carta.Texto,
                DataEnvio = carta.DataEnvio
            };

            return Ok(response);
        }
    }
}
