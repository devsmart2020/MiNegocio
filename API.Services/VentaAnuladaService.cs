using API.Domain.DTOs;
using API.Domain.Interfaces;
using API.Services.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace API.Services
{
    public class VentaAnuladaService : IVentaAnuladaService<VentaAnuladaDTO>
    {
        private readonly IVentaAnulada<VentaAnuladaDTO> _repository;

        public VentaAnuladaService(IVentaAnulada<VentaAnuladaDTO> repository)
        {
            _repository = repository;
        }
        public async Task<bool> Delete(VentaAnuladaDTO entity)
        {
            return await _repository.Delete(entity);
        }

        public async Task<bool> Exists(VentaAnuladaDTO entity)
        {
            return await _repository.Exists(entity);
        }

        public async Task<IEnumerable<VentaAnuladaDTO>> Get()
        {
            return await _repository.Get();
        }

        public async Task<VentaAnuladaDTO> GetById(VentaAnuladaDTO entity)
        {
            return await _repository.GetById(entity);
        }

        public async Task<bool> Post(VentaAnuladaDTO entity)
        {
            return await _repository.Post(entity);
        }

        public async Task<bool> Put(VentaAnuladaDTO entity)
        {
            return await _repository.Put(entity);
        }
    }
}
