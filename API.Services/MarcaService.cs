using API.Domain.DTOs;
using API.Domain.Interfaces;
using API.Services.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace API.Services
{
    public class MarcaService : IMarcaService<MarcaDTO>
    {
        private readonly IMarca<MarcaDTO> _repository;

        public MarcaService(IMarca<MarcaDTO> repository)
        {
            _repository = repository;
        }
        public async Task<bool> Delete(MarcaDTO entity)
        {
            return await _repository.Delete(entity);
        }

        public async Task<bool> Exists(MarcaDTO entity)
        {
            return await _repository.Exists(entity);
        }

        public async Task<MarcaDTO> GetById(MarcaDTO entity)
        {
            return await _repository.GetById(entity);
        }

        public async Task<IEnumerable<MarcaDTO>> Get()
        {
            return await _repository.Get();
        }

        public async Task<bool> Post(MarcaDTO entity)
        {
            return await _repository.Post(entity);
        }

        public async Task<bool> Put(MarcaDTO entity)
        {
            return await _repository.Put(entity);
        }
    }
}
