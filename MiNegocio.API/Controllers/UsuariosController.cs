using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Domain.Entities;
using API.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MiNegocio.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {
        private readonly IUsuarioService<Tbusuario> _service;

        public UsuariosController(IUsuarioService<Tbusuario> service)
        {
            _service = service;
        }

        [HttpDelete()]
        [Authorize]
        public async Task<ActionResult<Tbusuario>> Delete(Tbusuario entity)
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
        [Authorize]
        public async Task<ActionResult<IEnumerable<Tbusuario>>> Get()
        {
            IEnumerable<Tbusuario> model = await _service.Get();
            if (model.Count() > 0)
                return Ok(model);
            else
                return NoContent();
        }

        [HttpPost("GetById")]
        [Authorize]
        public async Task<ActionResult<Tbusuario>> GetById(Tbusuario entity)
        {
            Tbusuario model = await _service.GetById(entity);

            if (model != null)
                return Ok(model);
            else
                return NotFound();
        }

        [HttpGet("GetTecnicos")]
        public async Task<ActionResult<IEnumerable<Tbusuario>>> GetTenicos()
        {
            IEnumerable<Tbusuario> model = await _service.GetTecnicos();
            if (model.Count() > 0)
                return Ok(model);
            else
                return NoContent();
        }

        [HttpPost()]
        [Authorize]
        public async Task<ActionResult<Tbusuario>> Post(Tbusuario entity)
        {
            if (entity != null && ModelState.IsValid)
            {
                Tbusuario model = await _service.Post(entity);
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
        [Authorize]
        public async Task<IActionResult> Put(Tbusuario entity)
        {
            if (!string.IsNullOrEmpty(entity.DocId))
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
