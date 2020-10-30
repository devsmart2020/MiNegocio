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
    public class VentaAnuladasController : ControllerBase
    {
        private readonly IVentaAnuladaService<Tbventaanulada> _service;

        public VentaAnuladasController(IVentaAnuladaService<Tbventaanulada> service)
        {
            _service = service;
        }

        [HttpDelete()]
        public async Task<ActionResult<Tbventaanulada>> Delete(Tbventaanulada entity)
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
        public async Task<ActionResult<IEnumerable<Tbventaanulada>>> Get()
        {
            IEnumerable<Tbventaanulada> model = await _service.Get();
            if (model.Count() > 0)
                return Ok(model);
            else
                return NoContent();
        }

        [HttpPost("GetById")]
        public async Task<ActionResult<Tbventaanulada>> GetById(Tbventaanulada entity)
        {
            Tbventaanulada model = await _service.GetById(entity);

            if (model != null)
                return Ok(model);
            else
                return NotFound();
        }

        [HttpPost()]
        public async Task<ActionResult<Tbventaanulada>> Post(Tbventaanulada entity)
        {
            if (entity != null && ModelState.IsValid)
            {
                Tbventaanulada model = await _service.Post(entity);
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
        public async Task<IActionResult> Put(Tbventaanulada entity)
        {
            if (!string.IsNullOrEmpty(entity.IdUsuario))
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
