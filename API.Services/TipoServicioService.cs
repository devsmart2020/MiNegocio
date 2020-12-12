using API.Domain.DTOs;
using API.Domain.Interfaces;
using API.Services.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace API.Services
{
    public class TipoServicioService : ITipoServicioService<TipoServicioDTO>
    {
        private readonly ITipoServicio<TipoServicioDTO> _repository;

        public TipoServicioService(ITipoServicio<TipoServicioDTO> repository)
        {
            _repository = repository;
        }

        public async Task<bool> Delete(TipoServicioDTO entity)
        {
            return await _repository.Delete(entity);
        }

        public async Task<bool> Exists(TipoServicioDTO entity)
        {
            return await _repository.Exists(entity);
        }

        public async Task<TipoServicioDTO> GetById(TipoServicioDTO entity)
        {
            return await _repository.GetById(entity);
        }

        public async Task<IEnumerable<TipoServicioDTO>> Get()
        {
            return await _repository.Get();
        }

        public async Task<bool> Post(TipoServicioDTO entity)
        {
            return await _repository.Post(entity);
        }

        public async Task<bool> Put(TipoServicioDTO entity)
        {
            return await _repository.Put(entity);
        }
    }
}
