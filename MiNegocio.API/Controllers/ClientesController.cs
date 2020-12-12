using API.Domain.DTOs;
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
        private readonly IClienteService<ClienteDTO> _service;

        public ClientesController(IClienteService<ClienteDTO> service)
        {
            _service = service;
        }

        [HttpDelete()]
        public async Task<IActionResult> Delete(ClienteDTO entity)
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
        public async Task<IActionResult> Get()
        {
            IEnumerable<ClienteDTO> ClienteDTOs = await _service.Get();
            if (ClienteDTOs.Count() > 0)
                return Ok(ClienteDTOs);
            else
                return NoContent();
        }

        [HttpPost("GetById")]
        public async Task<IActionResult> GetById(ClienteDTO entity)
        {
            ClienteDTO cliente = await _service.GetById(entity);

            if (cliente != null)
                return Ok(cliente);
            else
                return NotFound();
        }

        [HttpPost()]
        public async Task<IActionResult> Post(ClienteDTO entity)
        {
            if (entity != null && ModelState.IsValid)
            {
                var query = await _service.Post(entity);
                if (query)
                    return Ok(query);
                else
                    return Conflict();
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpPost("RptEquipoCliente")]
        public async Task<IActionResult> RptEquiposxCliente(ClienteDTO entity)
        {
            if (entity != null)
            {
                IEnumerable<ClienteDTO> equipoClientes = await _service.RptEquiposxCliente(entity);
                if (equipoClientes.Any())
                    return Ok(equipoClientes);
                else
                    return NoContent();
            }
            else
            {
                return BadRequest();
            }
        }
        [HttpPost("RptOrdenCliente")]
        public async Task<ActionResult<IEnumerable<object>>> RptOrdenxCliente(ClienteDTO entity)
        {
            if (entity != null)
            {
                IEnumerable<object> ClienteDTOs = await _service.RptOrdenxCliente(entity);
                if (ClienteDTOs.Any())
                {
                    return Ok(ClienteDTOs);
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
        public async Task<IActionResult> Put(ClienteDTO entity)
        {
            if (!string.IsNullOrEmpty(entity.DocId))
            {
                var cliente = await _service.Put(entity);
                if (cliente)
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
