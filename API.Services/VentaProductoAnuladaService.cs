using API.Domain.DTOs;
using API.Domain.Interfaces;
using API.Services.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace API.Services
{
    public class VentaProductoAnuladaService : IVentaProductoAnuladaService<VentaProductoAnuladaDTO>
    {
        private readonly IVentaProductoAnulada<VentaProductoAnuladaDTO> _repository;

        public VentaProductoAnuladaService(IVentaProductoAnulada<VentaProductoAnuladaDTO> repository)
        {
            _repository = repository;
        }
        public async Task<bool> Delete(VentaProductoAnuladaDTO entity)
        {
            return await _repository.Delete(entity);
        }

        public async Task<bool> Exists(VentaProductoAnuladaDTO entity)
        {
            return await _repository.Exists(entity);
        }

        public async Task<VentaProductoAnuladaDTO> GetById(VentaProductoAnuladaDTO entity)
        {
            return await _repository.GetById(entity);
        }

        public async Task<IEnumerable<VentaProductoAnuladaDTO>> Get()
        {
            return await _repository.Get();
        }

        public async Task<bool> Post(VentaProductoAnuladaDTO entity)
        {
            return await _repository.Post(entity);
        }

        public async Task<bool> Put(VentaProductoAnuladaDTO entity)
        {
            return await _repository.Put(entity);
        }
    }
}
