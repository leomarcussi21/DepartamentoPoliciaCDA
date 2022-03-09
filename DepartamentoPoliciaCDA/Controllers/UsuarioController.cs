using DepartamentoPolicia.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DepartamentoPolicia.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioService _usuarioService;

        public UsuarioController(IUsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            _usuarioService.Test();
            return Ok("Ok");
        }
    }
}
