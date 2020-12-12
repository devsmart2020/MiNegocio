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
    public class PerfilesController : ControllerBase
    {
        private readonly IPerfilService<PerfilDTO> _service;

        public PerfilesController(IPerfilService<PerfilDTO> service)
        {
            _service = service;
        }

        [HttpDelete()]
        public async Task<IActionResult> Delete(PerfilDTO entity)
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
            IEnumerable<PerfilDTO> model = await _service.Get();
            if (model.Count() > 0)
                return Ok(model);
            else
                return NoContent();
        }

        [HttpPost("GetById")]
        public async Task<IActionResult> GetById(PerfilDTO entity)
        {
            PerfilDTO model = await _service.GetById(entity);

            if (model != null)
                return Ok(model);
            else
                return NotFound();
        }

        [HttpPost()]
        public async Task<IActionResult> Post(PerfilDTO entity)
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
        public async Task<IActionResult> Put(PerfilDTO entity)
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
