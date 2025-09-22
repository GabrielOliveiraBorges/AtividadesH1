using System.ComponentModel.DataAnnotations;
using Atv5.Models;
using Microsoft.AspNetCore.Mvc;

namespace Atv5.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProdutoController : ControllerBase
    {
        [HttpPost]
        public IActionResult SalvarProduto([FromBody] Produto produto)
        {
            var validationResults = new List<ValidationResult>();
            var context = new ValidationContext(produto, serviceProvider: null, items: null);

            bool isValid = Validator.TryValidateObject(produto, context, validationResults, true);

            if (isValid)
            {
                return Ok(new { message = "Produto salvo com sucesso!", produto });
            }

            return BadRequest(new { message = "Validação falhou", errors = validationResults });
        }
    }
}
