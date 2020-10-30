using API.Domain.Entities;
using API.Domain.Interfaces;
using API.Services.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace API.Services
{
    public class VentaProductoService : IVentaProductoService<Tbventaproducto>
    {
        private readonly IVentaProducto<Tbventaproducto> _repository;

        public VentaProductoService(IVentaProducto<Tbventaproducto> repository)
        {
            _repository = repository;
        }
        public async Task<bool> Delete(Tbventaproducto entity)
        {
            return await _repository.Delete(entity);
        }

        public async Task<bool> Exists(Tbventaproducto entity)
        {
            return await _repository.Exists(entity);
        }

        public async Task<IEnumerable<Tbventaproducto>> Get()
        {
            return await _repository.Get();
        }

        public async Task<Tbventaproducto> GetById(Tbventaproducto entity)
        {
            return await _repository.GetById(entity);
        }

        public async Task<Tbventaproducto> Post(Tbventaproducto entity)
        {
            return await _repository.Post(entity);
        }

        public async Task<Tbventaproducto> Put(Tbventaproducto entity)
        {
            return await _repository.Put(entity);
        }
    }
}
