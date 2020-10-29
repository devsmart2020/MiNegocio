using API.Domain.Entities;
using API.Domain.Interfaces;
using API.Services.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace API.Services
{
    public class VentaAnulada : IVentaAnuladaService<Tbventaanulada>
    {
        private readonly IVentaAnulada<Tbventaanulada> _repository;

        public VentaAnulada(IVentaAnulada<Tbventaanulada> repository)
        {
            _repository = repository;
        }
        public async Task<bool> Delete(Tbventaanulada entity)
        {
            return await _repository.Delete(entity);
        }

        public async Task<bool> Exists(Tbventaanulada entity)
        {
            return await _repository.Exists(entity);
        }

        public async Task<IEnumerable<Tbventaanulada>> Get()
        {
            return await _repository.Get();
        }

        public async Task<Tbventaanulada> GetById(Tbventaanulada entity)
        {
            return await _repository.GetById(entity);
        }

        public async Task<Tbventaanulada> Post(Tbventaanulada entity)
        {
            return await _repository.Post(entity);
        }

        public async Task<Tbventaanulada> Put(Tbventaanulada entity)
        {
            return await _repository.Put(entity);
        }
    }
}
