using crud.Models;
using crud.Service;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace crud.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VagasController : ControllerBase
    {
        private readonly VagasService _vagaService;

        public VagasController(VagasService vagaService)
        {
            _vagaService = vagaService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Vaga>>> GetAllVagas()
        {
            var vagas = await _vagaService.GetAllVagas();
            return Ok(vagas);
        }

        // Aqui, você pode adicionar outros métodos como Post (Criar), Put (Atualizar), Delete, etc.
        // Por exemplo:

        [HttpPost]
        public async Task<ActionResult<Vaga>> CreateVaga([FromBody] Vaga vaga)
        {
            await _vagaService.AddVaga(vaga);
            return CreatedAtAction(nameof(GetVagaById), new { id = vaga.Id }, vaga);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Vaga>> GetVagaById(int id)
        {
            var vaga = await _vagaService.GetVagaById(id);
            if (vaga == null)
            {
                return NotFound();
            }
            return Ok(vaga);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateVaga(int id, [FromBody] Vaga vaga)
        {
            if (id != vaga.Id)
            {
                return BadRequest();
            }
            await _vagaService.UpdateVaga(vaga);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteVaga(int id)
        {
            await _vagaService.DeleteVaga(id);
            return NoContent();
        }
    }
}
