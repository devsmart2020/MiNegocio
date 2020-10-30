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
    public class NegociosController : ControllerBase
    {
        private readonly INegocioService<Tbnegocio> _service;

        public NegociosController(INegocioService<Tbnegocio> service)
        {
            _service = service;
        }
        [HttpDelete()]
        public async Task<ActionResult<Tbnegocio>> Delete(Tbnegocio entity)
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
        public async Task<ActionResult<IEnumerable<Tbnegocio>>> Get()
        {
            IEnumerable<Tbnegocio> model = await _service.Get();
            if (model.Count() > 0)
                return Ok(model);
            else
                return NoContent();
        }

        [HttpPost("GetById")]
        public async Task<ActionResult<Tbnegocio>> GetById(Tbnegocio entity)
        {
            Tbnegocio model = await _service.GetById(entity);

            if (model != null)
                return Ok(model);
            else
                return NotFound();
        }

        [HttpPost()]
        public async Task<ActionResult<Tbnegocio>> Post(Tbnegocio entity)
        {
            if (entity != null && ModelState.IsValid)
            {
                Tbnegocio model = await _service.Post(entity);
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
        public async Task<IActionResult> Put(Tbnegocio entity)
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
