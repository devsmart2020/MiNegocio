using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Domain.Entities;
using API.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MiNegocio.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EgresosController : ControllerBase
    {
        private readonly IEgresoService<Tbegreso> _service;

        public EgresosController(IEgresoService<Tbegreso> service)
        {
            _service = service;
        }

        [HttpDelete()]
        public async Task<ActionResult<Tbegreso>> Delete(Tbegreso entity)
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
        public async Task<ActionResult<IEnumerable<Tbegreso>>> Get()
        {
            IEnumerable<Tbegreso> model = await _service.Get();
            if (model.Count() > 0)
                return Ok(model);
            else
                return NoContent();
        }

        [HttpPost("GetById")]
        public async Task<ActionResult<Tbegreso>> GetById(Tbegreso entity)
        {
            Tbegreso model = await _service.GetById(entity);

            if (model != null)
                return Ok(model);
            else
                return NotFound();
        }

        [HttpPost()]
        public async Task<ActionResult<Tbegreso>> Post(Tbegreso entity)
        {
            if (entity != null && ModelState.IsValid)
            {
                Tbegreso model = await _service.Post(entity);
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
        public async Task<IActionResult> Put(Tbegreso entity)
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
