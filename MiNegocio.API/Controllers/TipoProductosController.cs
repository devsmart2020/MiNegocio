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
    public class TipoProductosController : ControllerBase
    {
        private readonly ITipoProductoService<Tbtipoproducto> _service;

        public TipoProductosController(ITipoProductoService<Tbtipoproducto> service)
        {
            _service = service;
        }

        [HttpDelete()]
        public async Task<ActionResult<Tbtipoproducto>> Delete(Tbtipoproducto entity)
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
        public async Task<ActionResult<IEnumerable<Tbtipoproducto>>> Get()
        {
            IEnumerable<Tbtipoproducto> model = await _service.Get();
            if (model.Count() > 0)
                return Ok(model);
            else
                return NoContent();
        }

        [HttpPost("GetById")]
        public async Task<ActionResult<Tbtipoproducto>> GetById(Tbtipoproducto entity)
        {
            Tbtipoproducto model = await _service.GetById(entity);

            if (model != null)
                return Ok(model);
            else
                return NotFound();
        }

        [HttpPost()]
        public async Task<ActionResult<Tbtipoproducto>> Post(Tbtipoproducto entity)
        {
            if (entity != null && ModelState.IsValid)
            {
                Tbtipoproducto model = await _service.Post(entity);
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
        public async Task<IActionResult> Put(Tbtipoproducto entity)
        {
            if (!string.IsNullOrEmpty(entity.TipoProducto))
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
