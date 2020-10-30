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
    public class EgresoConceptosController : ControllerBase
    {
        private readonly IEgresoConceptoService<Tbegresoconcepto> _service;

        public EgresoConceptosController(IEgresoConceptoService<Tbegresoconcepto> service)
        {
            _service = service;
        }

        [HttpDelete()]
        public async Task<ActionResult<Tbegresoconcepto>> Delete(Tbegresoconcepto entity)
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
        public async Task<ActionResult<IEnumerable<Tbegresoconcepto>>> Get()
        {
            IEnumerable<Tbegresoconcepto> model = await _service.Get();
            if (model.Count() > 0)
                return Ok(model);
            else
                return NoContent();
        }

        [HttpPost("GetById")]
        public async Task<ActionResult<Tbegresoconcepto>> GetById(Tbegresoconcepto entity)
        {
            Tbegresoconcepto model = await _service.GetById(entity);

            if (model != null)
                return Ok(model);
            else
                return NotFound();
        }

        [HttpPost()]
        public async Task<ActionResult<Tbegresoconcepto>> Post(Tbegresoconcepto entity)
        {
            if (entity != null && ModelState.IsValid)
            {
                Tbegresoconcepto model = await _service.Post(entity);
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
        public async Task<IActionResult> Put(Tbegresoconcepto entity)
        {
            if (entity.IdConcepto != default)
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
