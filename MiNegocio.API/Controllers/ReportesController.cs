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
    public class ReportesController : ControllerBase
    {
        private readonly IReportesService<Tbreportes> _service;

        public ReportesController(IReportesService<Tbreportes> service)
        {
            _service = service;
        }

        [HttpDelete()]
        public async Task<ActionResult<Tbreportes>> Delete(Tbreportes entity)
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
        public async Task<ActionResult<IEnumerable<Tbreportes>>> Get()
        {
            IEnumerable<Tbreportes> model = await _service.Get();
            if (model.Count() > 0)
                return Ok(model);
            else
                return NoContent();
        }

        [HttpPost("GetById")]
        public async Task<ActionResult<Tbreportes>> GetById(Tbreportes entity)
        {
            Tbreportes model = await _service.GetById(entity);

            if (model != null)
                return Ok(model);
            else
                return NotFound();
        }

        [HttpPost()]
        public async Task<ActionResult<Tbreportes>> Post(Tbreportes entity)
        {
            if (entity != null && ModelState.IsValid)
            {
                Tbreportes model = await _service.Post(entity);
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
        public async Task<IActionResult> Put(Tbreportes entity)
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
