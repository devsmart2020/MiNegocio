using API.Domain.DTOs;
using API.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiNegocio.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {
        private readonly IUsuarioService<UsuarioDTO> _service;

        public UsuariosController(IUsuarioService<UsuarioDTO> service)
        {
            _service = service;
        }

        [HttpDelete()]
        [Authorize]
        public async Task<ActionResult<UsuarioDTO>> Delete(UsuarioDTO entity)
        {
            if (entity != null)
            {
                if (await _service.Delete(entity))
                    return Ok(entity);
                else
                    return Conflict();
            }
            return BadRequest();

        }

        [HttpGet]
        [Authorize]
        public async Task<ActionResult<IEnumerable<UsuarioDTO>>> Get()
        {
            IEnumerable<UsuarioDTO> model = await _service.Get();
            if (model.Count() > 0)
                return Ok(model);
            else
                return NoContent();
        }

        [HttpPost("GetById")]
        [Authorize]
        public async Task<ActionResult<UsuarioDTO>> GetById(UsuarioDTO entity)
        {
            UsuarioDTO model = await _service.GetById(entity);

            if (model != null)
                return Ok(model);
            else
                return NotFound();
        }

        [HttpPost()]
        [Authorize]
        public async Task<IActionResult> Post(UsuarioDTO entity)
        {
            if (entity != null && ModelState.IsValid)
                if (await _service.Post(entity))
                    return Ok(entity);
                else
                    return Conflict();
            else
                return BadRequest();

        }

        [HttpPut()]
        [Authorize]
        public async Task<IActionResult> Put(UsuarioDTO entity)
        {
            if (!string.IsNullOrEmpty(entity.DocId))
            {
                if (await _service.Put(entity))
                    return Ok(entity);
                else
                    return NotFound();
            }
            return BadRequest();
        }

        [HttpGet("Tecnicos")]
        public async Task<IActionResult> GetTecnicos()
        {
            IEnumerable<UsuarioDTO> tecnicos = await _service.GetTecnicos();
            if (tecnicos.Any())
                return Ok(tecnicos);
            else
                return NoContent();
        }
    }
}
