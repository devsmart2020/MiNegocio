using API.Domain.Entities;
using API.Domain.Interfaces;
using API.Services.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace API.Services
{
    public class VentaServicioService : IVentaServicioService<Tbventaservicio>
    {
        private readonly IVentaServicio<Tbventaservicio> _repository;

        public VentaServicioService(IVentaServicio<Tbventaservicio> repository)
        {
            _repository = repository;
        }
        public async Task<bool> Delete(Tbventaservicio entity)
        {
            return await _repository.Delete(entity);
        }

        public async Task<bool> Exists(Tbventaservicio entity)
        {
            return await _repository.Exists(entity);
        }

        public async Task<IEnumerable<Tbventaservicio>> Get()
        {
            return await _repository.Get();
        }

        public async Task<Tbventaservicio> GetById(Tbventaservicio entity)
        {
            return await _repository.GetById(entity);
        }

        public async Task<Tbventaservicio> Post(Tbventaservicio entity)
        {
            return await _repository.Post(entity);
        }

        public async Task<Tbventaservicio> Put(Tbventaservicio entity)
        {
            return await _repository.Put(entity);
        }
    }
}
