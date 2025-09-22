using Microsoft.AspNetCore.Mvc;
using Atv5.Models;

namespace Atv5.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AlunoController : ControllerBase
    {
        private static List<Aluno> alunos = new List<Aluno>();

        [HttpPost("cadastrar")]
        public IActionResult Cadastrar([FromBody] Aluno aluno)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            alunos.Add(aluno);
            return Ok(new { mensagem = "Aluno cadastrado com sucesso!", aluno });
        }

        [HttpGet("listar")]
        public IActionResult Listar()
        {
            return Ok(alunos);
        }
    }
}
