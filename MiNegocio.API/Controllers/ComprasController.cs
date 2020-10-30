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
    public class ComprasController : ControllerBase
    {
        private readonly ICompraService<Tbcompra> _service;

        public ComprasController(ICompraService<Tbcompra> service)
        {
            _service = service;
        }

        [HttpDelete()]
        public async Task<ActionResult<Tbcompra>> Delete(Tbcompra entity)
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
        public async Task<ActionResult<IEnumerable<Tbcompra>>> Get()
        {
            IEnumerable<Tbcompra> Tbcompras = await _service.Get();
            if (Tbcompras.Count() > 0)
                return Ok(Tbcompras);
            else
                return NoContent();
        }

        [HttpPost("GetById")]
        public async Task<ActionResult<Tbcompra>> GetById(Tbcompra entity)
        {
            Tbcompra cliente = await _service.GetById(entity);

            if (cliente != null)
                return Ok(cliente);
            else
                return NotFound();
        }

        [HttpPost()]
        public async Task<ActionResult<Tbcompra>> Post(Tbcompra entity)
        {
            if (entity != null && ModelState.IsValid)
            {
                Tbcompra cliente = await _service.Post(entity);
                if (cliente != null)
                    return Ok(cliente);
                else
                    return Conflict();
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpPut()]
        public async Task<IActionResult> Put(Tbcompra entity)
        {
            if (!string.IsNullOrEmpty(entity.IdUsuario))
            {
                var cliente = await _service.Put(entity);
                if (cliente != null)
                    return Ok(cliente);
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
