using API.Domain.DTOs;
using API.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiNegocio.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioOrdenesController : ControllerBase
    {
        private readonly IUsuarioOrdenService<UsuarioOrdenDTO> _service;

        public UsuarioOrdenesController(IUsuarioOrdenService<UsuarioOrdenDTO> service)
        {
            _service = service;
        }
        [HttpDelete()]
        public async Task<IActionResult> Delete(UsuarioOrdenDTO entity)
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
        public async Task<IActionResult> Get()
        {
            IEnumerable<UsuarioOrdenDTO> model = await _service.Get();
            if (model.Count() > 0)
                return Ok(model);
            else
                return NoContent();
        }

        [HttpPost("GetById")]
        public async Task<IActionResult> GetById(UsuarioOrdenDTO entity)
        {
            UsuarioOrdenDTO model = await _service.GetById(entity);

            if (model != null)
                return Ok(model);
            else
                return NotFound();
        }

        [HttpPost()]
        public async Task<IActionResult> Post(UsuarioOrdenDTO entity)
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
        public async Task<IActionResult> Put(UsuarioOrdenDTO entity)
        {
            if (ModelState.IsValid && entity != null)
            {
                if (await _service.Put(entity))
                    return Ok(entity);
                else
                    return NotFound();
            }
            return BadRequest();
        }
    }
}
