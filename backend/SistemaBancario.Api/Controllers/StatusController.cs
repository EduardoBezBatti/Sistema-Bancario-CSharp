using Microsoft.AspNetCore.Mvc;

namespace SistemaBancario.Api.Controllers;

[ApiController]
[Route("api/status")]
public class StatusController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        return Ok(new { mensagem = "API do Sistema Bancário em execução." });
    }
}
