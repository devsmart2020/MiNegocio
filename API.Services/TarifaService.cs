using API.Domain.DTOs;
using API.Domain.Interfaces;
using API.Services.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace API.Services
{
    public class TarifaService : ITarifaService<TarifaDTO>
    {
        private readonly ITarifa<TarifaDTO> _repository;

        public TarifaService(ITarifa<TarifaDTO> repository)
        {
            _repository = repository;
        }
        public async Task<bool> Delete(TarifaDTO entity)
        {
            return await _repository.Delete(entity);
        }

        public async Task<bool> Exists(TarifaDTO entity)
        {
            return await _repository.Exists(entity);
        }

        public async Task<TarifaDTO> GetById(TarifaDTO entity)
        {
            return await _repository.GetById(entity);
        }

        public async Task<IEnumerable<TarifaDTO>> Get()
        {
            return await _repository.Get();
        }

        public async Task<bool> Post(TarifaDTO entity)
        {
            return await _repository.Post(entity);
        }

        public async Task<bool> Put(TarifaDTO entity)
        {
            return await _repository.Put(entity);
        }
    }
}
