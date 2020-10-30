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
    public class TipoServiciosController : ControllerBase
    {
        private readonly ITipoServicioService<Tbtiposervicio> _service;

        public TipoServiciosController(ITipoServicioService<Tbtiposervicio> service)
        {
            _service = service;
        }
        [HttpDelete()]
        public async Task<ActionResult<Tbtiposervicio>> Delete(Tbtiposervicio entity)
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
        public async Task<ActionResult<IEnumerable<Tbtiposervicio>>> Get()
        {
            IEnumerable<Tbtiposervicio> model = await _service.Get();
            if (model.Count() > 0)
                return Ok(model);
            else
                return NoContent();
        }

        [HttpPost("GetById")]
        public async Task<ActionResult<Tbtiposervicio>> GetById(Tbtiposervicio entity)
        {
            Tbtiposervicio model = await _service.GetById(entity);

            if (model != null)
                return Ok(model);
            else
                return NotFound();
        }

        [HttpPost()]
        public async Task<ActionResult<Tbtiposervicio>> Post(Tbtiposervicio entity)
        {
            if (entity != null && ModelState.IsValid)
            {
                Tbtiposervicio model = await _service.Post(entity);
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
        public async Task<IActionResult> Put(Tbtiposervicio entity)
        {
            if (!string.IsNullOrEmpty(entity.TipoServicio))
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
