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
    public class ConceptosController : ControllerBase
    {
        private readonly IConceptoService<Tbconcepto> _service;

        public ConceptosController(IConceptoService<Tbconcepto> service)
        {
            _service = service;
        }
        [HttpDelete()]
        public async Task<ActionResult<Tbconcepto>> Delete(Tbconcepto entity)
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
        public async Task<ActionResult<IEnumerable<Tbconcepto>>> Get()
        {
            IEnumerable<Tbconcepto> model = await _service.Get();
            if (model.Count() > 0)
                return Ok(model);
            else
                return NoContent();
        }

        [HttpPost("GetById")]
        public async Task<ActionResult<Tbconcepto>> GetById(Tbconcepto entity)
        {
            Tbconcepto model = await _service.GetById(entity);

            if (model != null)
                return Ok(model);
            else
                return NotFound();
        }

        [HttpPost()]
        public async Task<ActionResult<Tbconcepto>> Post(Tbconcepto entity)
        {
            if (entity != null && ModelState.IsValid)
            {
                Tbconcepto model = await _service.Post(entity);
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
        public async Task<IActionResult> Put(Tbconcepto entity)
        {
            if (!string.IsNullOrEmpty(entity.Concepto))
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
