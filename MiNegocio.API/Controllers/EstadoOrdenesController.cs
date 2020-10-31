﻿using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Domain.Entities;
using API.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace MiNegocio.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EstadoOrdenesController : ControllerBase
    {
        private readonly IEstadoOrdenService<Tbestadoorden> _service;

        public EstadoOrdenesController(IEstadoOrdenService<Tbestadoorden> service)
        {
            _service = service;
        }

        [HttpDelete()]
        public async Task<ActionResult<Tbestadoorden>> Delete(Tbestadoorden entity)
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
        public async Task<ActionResult<IEnumerable<Tbestadoorden>>> Get()
        {
            IEnumerable<Tbestadoorden> model = await _service.Get();
            if (model.Count() > 0)
                return Ok(model);
            else
                return NoContent();
        }

        [HttpPost("GetById")]
        public async Task<ActionResult<Tbestadoorden>> GetById(Tbestadoorden entity)
        {
            Tbestadoorden model = await _service.GetById(entity);

            if (model != null)
                return Ok(model);
            else
                return NotFound();
        }

        [HttpPost()]
        public async Task<ActionResult<Tbestadoorden>> Post(Tbestadoorden entity)
        {
            if (entity != null && ModelState.IsValid)
            {
                Tbestadoorden model = await _service.Post(entity);
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
        public async Task<IActionResult> Put(Tbestadoorden entity)
        {
            if (!string.IsNullOrEmpty(entity.EstadoOrden))
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