﻿using Crud_Api.DataTransferObject;
using Crud_Domain.Entity;
using Crud_Repositories.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Crud_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PessoaController : ControllerBase
    {
        private readonly IPessoaRepository _pessoaRepository;
        public PessoaController(IPessoaRepository pessoaRepositoy)
        {
            _pessoaRepository = pessoaRepositoy;
        }

        [HttpPost("Insert")]
        public async Task<IActionResult> Registrar(PessoaDto dto)
        {
            if (dto == null)
            {
                return BadRequest("Insira os Dados");
            }

            var pessoa = dto.MapToEntity();

            await _pessoaRepository.Insert(pessoa);

            return Created("Cadastrado com Sucesso!", pessoa);
        }

        [HttpGet("GetById/{id}")]
        [Authorize(Roles = "operador")]
        public async Task<IActionResult> GetById(int id)
        {
            var result = await _pessoaRepository.GetById(id);

            if (result == null) return NotFound("nenhum dado encontrato");
            return Ok(result);
        }

        [HttpGet("GetAll")]
        [Authorize(Roles = "administrador")]
        public async Task<IActionResult> GetAll()
        {
            var result = await _pessoaRepository.GetAll();

            if (result == null) return NotFound("nenhum dado encontrato");
            return Ok(result);
        }

        [HttpPut("Update")]
        public async Task<IActionResult> Update(PessoaDto dto)
        {
            if (dto == null) return BadRequest("Informe os dados");

            var pessoa = dto.MapToEntity();

            await _pessoaRepository.Update(pessoa);

            return Ok("Pessoa Atualizada");
        }

        [HttpDelete("Delete/{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _pessoaRepository.Delete(id);

            return Ok("Deleção concluída");
        }
    }
}
