using Crud_Api.DataTransferObject;
using Crud_Api.Service;
using Crud_Repositories.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Crud_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioRepository _usuarioRepository;
        public UsuarioController(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }
        [HttpPost("Insert")]
        public IActionResult Insert(UsuarioDto dto)
        {
            if (dto == null) return BadRequest("Inválido");

            var etity = dto.MapToEntity();
            _usuarioRepository.Insert(etity);
            return Created("Criado com sucesso", etity);

        }

        [HttpPost("Authenticate")]
        public IActionResult Authenticate(UsuarioDto dto)
        {
            if (dto == null) return BadRequest("Inválido");

            var etity = dto.MapToEntity();
            var user = _usuarioRepository.Authenticate(etity);

            var token = TokenService.GenerateToken(user.Result);

            return Ok(token);
        }

        [HttpGet("GetById/{Id}")]
        [Authorize]
        public IActionResult GetById(int Id)
        {
            var user = _usuarioRepository.GetById(Id);

            return Ok(user.Result);
        }
    }
}
