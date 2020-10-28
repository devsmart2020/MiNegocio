using API.Domain.Entities;
using API.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
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

        public Task<bool> Exists(Tbcliente entity)
        {
            throw new NotImplementedException();
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

        public Task<Tbcliente> GetById(Tbcliente entity)
        {
            throw new NotImplementedException();
        }

        public Task<Tbcliente> Post(Tbcliente entity)
        {
            throw new NotImplementedException();
        }

        public Task<Tbcliente> Put(Tbcliente entity)
        {
            throw new NotImplementedException();
        }
    }
}
