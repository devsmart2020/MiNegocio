using API.Domain.DTOs;
using API.Domain.Interfaces;
using API.Services.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace API.Services
{
    public class NegocioService : INegocioService<NegocioDTO>
    {
        private readonly INegocio<NegocioDTO> _repository;

        public NegocioService(INegocio<NegocioDTO> repository)
        {
            _repository = repository;
        }

        public async Task<bool> Delete(NegocioDTO entity)
        {
            return await _repository.Delete(entity);
        }

        public async Task<bool> Exists(NegocioDTO entity)
        {
            return await _repository.Delete(entity);
        }

        public async Task<NegocioDTO> GetById(NegocioDTO entity)
        {
            return await _repository.GetById(entity);
        }

        public async Task<IEnumerable<NegocioDTO>> Get()
        {
            return await _repository.Get();
        }

        public async Task<bool> Post(NegocioDTO entity)
        {
            return await _repository.Post(entity);
        }

        public async Task<bool> Put(NegocioDTO entity)
        {
            return await _repository.Put(entity);
        }
    }
}
