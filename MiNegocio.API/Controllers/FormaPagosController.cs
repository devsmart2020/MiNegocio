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
    public class FormaPagosController : ControllerBase
    {
        private readonly IFormaPagoService<Tbformapago> _service;

        public FormaPagosController(IFormaPagoService<Tbformapago> service)
        {
            _service = service;
        }

        [HttpDelete()]
        public async Task<ActionResult<Tbformapago>> Delete(Tbformapago entity)
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
        public async Task<ActionResult<IEnumerable<Tbformapago>>> Get()
        {
            IEnumerable<Tbformapago> model = await _service.Get();
            if (model.Count() > 0)
                return Ok(model);
            else
                return NoContent();
        }

        [HttpPost("GetById")]
        public async Task<ActionResult<Tbformapago>> GetById(Tbformapago entity)
        {
            Tbformapago model = await _service.GetById(entity);

            if (model != null)
                return Ok(model);
            else
                return NotFound();
        }

        [HttpPost()]
        public async Task<ActionResult<Tbformapago>> Post(Tbformapago entity)
        {
            if (entity != null && ModelState.IsValid)
            {
                Tbformapago model = await _service.Post(entity);
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
        public async Task<IActionResult> Put(Tbformapago entity)
        {
            if (!string.IsNullOrEmpty(entity.FormaPago))
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
