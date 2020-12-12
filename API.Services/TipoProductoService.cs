using API.Domain.DTOs;
using API.Domain.Interfaces;
using API.Services.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace API.Services
{
    public class TipoProductoService : ITipoProductoService<TipoProductoDTO>
    {
        private readonly ITipoProducto<TipoProductoDTO> _repository;

        public TipoProductoService(ITipoProducto<TipoProductoDTO> repository)
        {
            _repository = repository;
        }
        public async Task<bool> Delete(TipoProductoDTO entity)
        {
            return await _repository.Delete(entity);
        }

        public async Task<bool> Exists(TipoProductoDTO entity)
        {
            return await _repository.Exists(entity);
        }

        public async Task<TipoProductoDTO> GetById(TipoProductoDTO entity)
        {
            return await _repository.GetById(entity);
        }

        public async Task<IEnumerable<TipoProductoDTO>> Get()
        {
            return await _repository.Get();
        }

        public async Task<bool> Post(TipoProductoDTO entity)
        {
            return await _repository.Post(entity);
        }

        public async Task<bool> Put(TipoProductoDTO entity)
        {
            return await _repository.Put(entity);
        }
    }
}
