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
    public class VentaServiciosController : ControllerBase
    {
        private readonly IVentaServicioService<Tbventaservicio> _service;

        public VentaServiciosController(IVentaServicioService<Tbventaservicio> service)
        {
            _service = service;
        }
        [HttpDelete()]
        public async Task<ActionResult<Tbventaservicio>> Delete(Tbventaservicio entity)
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
        public async Task<ActionResult<IEnumerable<Tbventaservicio>>> Get()
        {
            IEnumerable<Tbventaservicio> model = await _service.Get();
            if (model.Count() > 0)
                return Ok(model);
            else
                return NoContent();
        }

        [HttpPost("GetById")]
        public async Task<ActionResult<Tbventaservicio>> GetById(Tbventaservicio entity)
        {
            Tbventaservicio model = await _service.GetById(entity);

            if (model != null)
                return Ok(model);
            else
                return NotFound();
        }

        [HttpPost()]
        public async Task<ActionResult<Tbventaservicio>> Post(Tbventaservicio entity)
        {
            if (entity != null && ModelState.IsValid)
            {
                Tbventaservicio model = await _service.Post(entity);
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
        public async Task<IActionResult> Put(Tbventaservicio entity)
        {
            if (entity.IdVenta != default)
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
