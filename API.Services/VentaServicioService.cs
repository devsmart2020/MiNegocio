using API.Domain.DTOs;
using API.Domain.Interfaces;
using API.Services.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace API.Services
{
    public class VentaServicioService : IVentaServicioService<VentaServicioDTO>
    {
        private readonly IVentaServicio<VentaServicioDTO> _repository;

        public VentaServicioService(IVentaServicio<VentaServicioDTO> repository)
        {
            _repository = repository;
        }
        public async Task<bool> Delete(VentaServicioDTO entity)
        {
            return await _repository.Delete(entity);
        }

        public async Task<bool> Exists(VentaServicioDTO entity)
        {
            return await _repository.Exists(entity);
        }

        public async Task<IEnumerable<VentaServicioDTO>> Get()
        {
            return await _repository.Get();
        }

        public async Task<VentaServicioDTO> GetById(VentaServicioDTO entity)
        {
            return await _repository.GetById(entity);
        }

        public async Task<bool> Post(VentaServicioDTO entity)
        {
            return await _repository.Post(entity);
        }

        public async Task<bool> Put(VentaServicioDTO entity)
        {
            return await _repository.Put(entity);
        }
    }
}
