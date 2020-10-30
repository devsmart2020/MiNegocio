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
    public class EstadoComprasController : ControllerBase
    {
        private readonly IEstadoCompraService<Tbestadocompra> _service;

        public EstadoComprasController(IEstadoCompraService<Tbestadocompra> service)
        {
            _service = service;
        }
        [HttpDelete()]
        public async Task<ActionResult<Tbestadocompra>> Delete(Tbestadocompra entity)
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
        public async Task<ActionResult<IEnumerable<Tbestadocompra>>> Get()
        {
            IEnumerable<Tbestadocompra> model = await _service.Get();
            if (model.Count() > 0)
                return Ok(model);
            else
                return NoContent();
        }

        [HttpPost("GetById")]
        public async Task<ActionResult<Tbestadocompra>> GetById(Tbestadocompra entity)
        {
            Tbestadocompra model = await _service.GetById(entity);

            if (model != null)
                return Ok(model);
            else
                return NotFound();
        }

        [HttpPost()]
        public async Task<ActionResult<Tbestadocompra>> Post(Tbestadocompra entity)
        {
            if (entity != null && ModelState.IsValid)
            {
                Tbestadocompra model = await _service.Post(entity);
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
        public async Task<IActionResult> Put(Tbestadocompra entity)
        {
            if (!string.IsNullOrEmpty(entity.Estado))
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
