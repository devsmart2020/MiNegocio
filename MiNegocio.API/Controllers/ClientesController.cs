using API.Domain.Entities;
using API.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiNegocio.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientesController : ControllerBase
    {
        private readonly IClienteService<Tbcliente> _service;

        public ClientesController(IClienteService<Tbcliente> service)
        {
            _service = service;
        }

        [HttpDelete()]
        public async Task<ActionResult<Tbcliente>> Delete(Tbcliente entity)
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
        public async Task<ActionResult<IEnumerable<Tbcliente>>> Get()
        {
            IEnumerable<Tbcliente> tbclientes = await _service.Get();
            if (tbclientes.Count() > 0)
                return Ok(tbclientes);
            else
                return NoContent();
        }

        [HttpPost("GetById")]
        public async Task<ActionResult<Tbcliente>> GetById(Tbcliente entity)
        {
            Tbcliente cliente = await _service.GetById(entity);

            if (cliente != null)
                return Ok(cliente);
            else
                return NotFound();
        }

        [HttpPost()]
        public async Task<ActionResult<Tbcliente>> Post(Tbcliente entity)
        {
            if (entity != null && ModelState.IsValid)
            {
                Tbcliente cliente = await _service.Post(entity);
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

        [HttpPost("RptEquipoCliente")]
        public async Task<ActionResult<IEnumerable<Tbcliente>>> RptEquiposxCliente(Tbcliente entity)
        {
            if (entity != null)
            {
                IEnumerable<Tbcliente> equipoClientes = await _service.RptEquiposxCliente(entity);
                if (equipoClientes.Any())
                {
                    return Ok(equipoClientes);
                }
                else
                {
                    return NoContent();
                }
            }
            else
            {
                return BadRequest();
            }
        }
        [HttpPost("RptOrdenCliente")]
        public async Task<ActionResult<IEnumerable<Tbcliente>>> RptOrdenxCliente(Tbcliente entity)
        {
            if (entity != null)
            {
                IEnumerable<Tbcliente> tbclientes = await _service.RptOrdenxCliente(entity);
                if (tbclientes.Any())
                {
                    return Ok(tbclientes);
                }
                else
                {
                    return NoContent();
                }
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpPut()]
        public async Task<IActionResult> Put(Tbcliente entity)
        {
            if (!string.IsNullOrEmpty(entity.DocId))
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
