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
    public class InventarioFijosController : ControllerBase
    {
        private readonly IInventarioFijoService<Tbinventariofijo> _service;

        public InventarioFijosController(IInventarioFijoService<Tbinventariofijo> service)
        {
            _service = service;
        }

        [HttpDelete()]
        public async Task<ActionResult<Tbinventariofijo>> Delete(Tbinventariofijo entity)
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
        public async Task<ActionResult<IEnumerable<Tbinventariofijo>>> Get()
        {
            IEnumerable<Tbinventariofijo> model = await _service.Get();
            if (model.Count() > 0)
                return Ok(model);
            else
                return NoContent();
        }

        [HttpPost("GetById")]
        public async Task<ActionResult<Tbinventariofijo>> GetById(Tbinventariofijo entity)
        {
            Tbinventariofijo model = await _service.GetById(entity);

            if (model != null)
                return Ok(model);
            else
                return NotFound();
        }

        [HttpPost()]
        public async Task<ActionResult<Tbinventariofijo>> Post(Tbinventariofijo entity)
        {
            if (entity != null && ModelState.IsValid)
            {
                Tbinventariofijo model = await _service.Post(entity);
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
        public async Task<IActionResult> Put(Tbinventariofijo entity)
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
