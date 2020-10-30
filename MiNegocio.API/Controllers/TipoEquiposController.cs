using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Domain.Entities;
using API.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace MiNegocio.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TipoEquiposController : ControllerBase
    {
        private readonly ITipoEquipoService<Tbtipoequipo> _service;

        public TipoEquiposController(ITipoEquipoService<Tbtipoequipo> service)
        {
            _service = service;
        }

        [HttpDelete()]
        public async Task<ActionResult<Tbtipoequipo>> Delete(Tbtipoequipo entity)
        {
            if (entity != null)
            {
                if (await _service.Delete(entity))
                    return Ok(entity);
                else
                    return Conflict();
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Tbtipoequipo>>> Get()
        {
            IEnumerable<Tbtipoequipo> model = await _service.Get();
            if (model.Count() > 0)
                return Ok(model);
            else
                return NoContent();
        }

        [HttpPost("GetById")]
        public async Task<ActionResult<Tbtipoequipo>> GetById(Tbtipoequipo entity)
        {
            Tbtipoequipo model = await _service.GetById(entity);

            if (model != null)
                return Ok(model);
            else
                return NotFound();
        }

        [HttpPost()]
        public async Task<ActionResult<Tbtipoequipo>> Post(Tbtipoequipo entity)
        {
            if (entity != null && ModelState.IsValid)
            {
                Tbtipoequipo model = await _service.Post(entity);
                if (model != null)
                    return Ok(model);
                else
                    return Conflict();
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpPut()]
        public async Task<IActionResult> Put(Tbtipoequipo entity)
        {
            if (!string.IsNullOrEmpty(entity.TipoEquipo))
            {
                var model = await _service.Put(entity);
                if (model != null)
                    return Ok(model);
                else
                    return NotFound();
            }
            else
            {
                return BadRequest();
            }
        }
    }
}
