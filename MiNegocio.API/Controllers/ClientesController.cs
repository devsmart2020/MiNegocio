using API.Domain.DTOs;
using API.Services.Interfaces;
using AutoMapper;
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
        private readonly IClienteService<ClienteDto> _service;

        public ClientesController(IClienteService<ClienteDto> service)
        {
            _service = service;
        }

        [HttpDelete()]
        public async Task<ActionResult<ClienteDto>> Delete(ClienteDto entity)
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
        public async Task<ActionResult<IEnumerable<ClienteDto>>> Get()
        {
            IEnumerable<ClienteDto> ClienteDtos = await _service.Get();
            if (ClienteDtos.Count() > 0)
                return Ok(ClienteDtos);
            else
                return NoContent();
        }

        [HttpPost("GetById")]
        public async Task<ActionResult<ClienteDto>> GetById(ClienteDto entity)
        {
            ClienteDto cliente = await _service.GetById(entity);

            if (cliente != null)
                return Ok(cliente);
            else
                return NotFound();
        }

        [HttpPost()]
        public async Task<ActionResult<ClienteDto>> Post(ClienteDto entity)
        {
            if (entity != null && ModelState.IsValid)
            {
                ClienteDto cliente = await _service.Post(entity);
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
        public async Task<ActionResult<IEnumerable<ClienteDto>>> RptEquiposxCliente(ClienteDto entity)
        {
            if (entity != null)
            {
                IEnumerable<ClienteDto> equipoClientes = await _service.RptEquiposxCliente(entity);
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
        public async Task<ActionResult<IEnumerable<object>>> RptOrdenxCliente(ClienteDto entity)
        {
            if (entity != null)
            {
                IEnumerable<object> ClienteDtos = await _service.RptOrdenxCliente(entity);
                if (ClienteDtos.Any())
                {
                    return Ok(ClienteDtos);
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
        public async Task<IActionResult> Put(ClienteDto entity)
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
