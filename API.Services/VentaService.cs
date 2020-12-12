using API.Domain.DTOs;
using API.Domain.Interfaces;
using API.Services.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace API.Services
{
    public class VentaService : IVentaService<VentaDTO>
    {
        private readonly IVenta<VentaDTO> _repository;

        public VentaService(IVenta<VentaDTO> repository)
        {
            _repository = repository;
        }
        public async Task<bool> Delete(VentaDTO entity)
        {
            return await _repository.Delete(entity);
        }

        public async Task<bool> Exists(VentaDTO entity)
        {
            return await _repository.Exists(entity);
        }

        public async Task<IEnumerable<VentaDTO>> Get()
        {
            return await _repository.Get();
        }

        public async Task<VentaDTO> GetById(VentaDTO entity)
        {
            return await _repository.GetById(entity);
        }

        public async Task<bool> Post(VentaDTO entity)
        {
            return await _repository.Post(entity);
        }

        public async Task<bool> Put(VentaDTO entity)
        {
            return await _repository.Put(entity);
        }
    }
}
