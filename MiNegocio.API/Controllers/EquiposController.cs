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
    public class EquiposController : ControllerBase
    {
        private readonly IEquipoService<EquipoDTO> _service;

        public EquiposController(IEquipoService<EquipoDTO> service)
        {
            _service = service;
        }

        [HttpDelete()]
        public async Task<IActionResult> Delete(EquipoDTO entity)
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
            IEnumerable<EquipoDTO> model = await _service.Get();
            if (model.Count() > 0)
                return Ok(model);
            else
                return NoContent();
        }

        [HttpPost("GetById")]
        public async Task<IActionResult> GetById(EquipoDTO entity)
        {
            EquipoDTO model = await _service.GetById(entity);

            if (model != null)
                return Ok(model);
            else
                return NotFound();
        }

        [HttpPost()]
        public async Task<IActionResult> Post(EquipoDTO entity)
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
        public async Task<IActionResult> Put(EquipoDTO entity)
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
