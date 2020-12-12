using API.Domain.DTOs;
using API.Domain.Interfaces;
using API.Services.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace API.Services
{
    public class TipoEquipoService : ITipoEquipoService<TipoEquipoDTO>
    {
        private readonly ITipoEquipo<TipoEquipoDTO> _repository;

        public TipoEquipoService(ITipoEquipo<TipoEquipoDTO> repository)
        {
            _repository = repository;
        }
        public async Task<bool> Delete(TipoEquipoDTO entity)
        {
            return await _repository.Delete(entity);
        }

        public async Task<bool> Exists(TipoEquipoDTO entity)
        {
            return await _repository.Exists(entity);
        }

        public async Task<TipoEquipoDTO> GetById(TipoEquipoDTO entity)
        {
            return await _repository.GetById(entity);
        }

        public async Task<IEnumerable<TipoEquipoDTO>> Get()
        {
            return await _repository.Get();
        }

        public async Task<bool> Post(TipoEquipoDTO entity)
        {
            return await _repository.Post(entity);
        }

        public async Task<bool> Put(TipoEquipoDTO entity)
        {
            return await _repository.Put(entity);
        }
    }
}
