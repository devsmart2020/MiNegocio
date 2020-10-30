using API.Domain.Entities;
using API.Domain.Interfaces;
using API.Services.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace API.Services
{
    public class VentaProductoAnuladaService : IVentaProductoAnuladaService<Tbventaproductoanulada>
    {
        private readonly IVentaProductoAnulada<Tbventaproductoanulada> _repository;

        public VentaProductoAnuladaService(IVentaProductoAnulada<Tbventaproductoanulada> repository)
        {
            _repository = repository;
        }
        public async Task<bool> Delete(Tbventaproductoanulada entity)
        {
            return await _repository.Delete(entity);
        }

        public async Task<bool> Exists(Tbventaproductoanulada entity)
        {
            return await _repository.Exists(entity);
        }

        public async Task<Tbventaproductoanulada> GetById(Tbventaproductoanulada entity)
        {
            return await _repository.GetById(entity);
        }

        public async Task<IEnumerable<Tbventaproductoanulada>>Get()
        {
            return await _repository.Get();
        }

        public async Task<Tbventaproductoanulada> Post(Tbventaproductoanulada entity)
        {
            return await _repository.Post(entity);
        }

        public async Task<Tbventaproductoanulada> Put(Tbventaproductoanulada entity)
        {
            return await _repository.Put(entity);
        }
    }
}
