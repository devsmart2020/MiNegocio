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
    public class TarifasController : ControllerBase
    {
        private readonly ITarifaService<Tbtarifa> _service;

        public TarifasController(ITarifaService<Tbtarifa> service)
        {
            _service = service;
        }

        [HttpDelete()]
        public async Task<ActionResult<Tbtarifa>> Delete(Tbtarifa entity)
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
        public async Task<ActionResult<IEnumerable<Tbtarifa>>> Get()
        {
            IEnumerable<Tbtarifa> model = await _service.Get();
            if (model.Count() > 0)
                return Ok(model);
            else
                return NoContent();
        }

        [HttpPost("GetById")]
        public async Task<ActionResult<Tbtarifa>> GetById(Tbtarifa entity)
        {
            Tbtarifa model = await _service.GetById(entity);

            if (model != null)
                return Ok(model);
            else
                return NotFound();
        }

        [HttpPost()]
        public async Task<ActionResult<Tbtarifa>> Post(Tbtarifa entity)
        {
            if (entity != null && ModelState.IsValid)
            {
                Tbtarifa model = await _service.Post(entity);
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
        public async Task<IActionResult> Put(Tbtarifa entity)
        {
            if (!string.IsNullOrEmpty(entity.Nombre))
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
