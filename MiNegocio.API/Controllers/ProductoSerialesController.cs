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
    public class ProductoSerialesController : ControllerBase
    {
        private readonly IProductoSerialService<Tbproductoserial> _service;

        public ProductoSerialesController(IProductoSerialService<Tbproductoserial> service)
        {
            _service = service;
        }

        [HttpDelete()]
        public async Task<ActionResult<Tbproductoserial>> Delete(Tbproductoserial entity)
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
        public async Task<ActionResult<IEnumerable<Tbproductoserial>>> Get()
        {
            IEnumerable<Tbproductoserial> model = await _service.Get();
            if (model.Count() > 0)
                return Ok(model);
            else
                return NoContent();
        }

        [HttpPost("GetById")]
        public async Task<ActionResult<Tbproductoserial>> GetById(Tbproductoserial entity)
        {
            Tbproductoserial model = await _service.GetById(entity);

            if (model != null)
                return Ok(model);
            else
                return NotFound();
        }

        [HttpPost()]
        public async Task<ActionResult<Tbproductoserial>> Post(Tbproductoserial entity)
        {
            if (entity != null && ModelState.IsValid)
            {
                Tbproductoserial model = await _service.Post(entity);
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
        public async Task<IActionResult> Put(Tbproductoserial entity)
        {
            if (!string.IsNullOrEmpty(entity.IdProducto))
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
