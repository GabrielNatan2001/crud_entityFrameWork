using Crud_Api.DataTransferObject;
using Crud_Domain.Entity;
using Crud_Repositories.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Crud_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContatoController : ControllerBase
    {
        private readonly IContatoRepository _contatoRepository;
        public ContatoController(IContatoRepository contatoRepository)
        {
            _contatoRepository = contatoRepository;
        }

        [HttpPost("Insert")]
        public async Task<IActionResult> Insert(ContatoDto dto)
        {
            if (dto == null) return BadRequest("contato inválido");

            var contato = dto.MapToEntity();

            await _contatoRepository.Insert(contato);
            return Created("Contato Adicionado", contato);
        }

        [HttpPut("Update")]
        public async Task<IActionResult> Update(ContatoDto dto)
        {
            if (dto == null) return BadRequest("contato inválido");

            var contato = dto.MapToEntity();

            await _contatoRepository.Update(contato);
            return Ok("Contato Atualizado!");
        }

        [HttpDelete("Delete/{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _contatoRepository.Delete(id);
            return Ok("Contato excluído!");
        }

    }
}
