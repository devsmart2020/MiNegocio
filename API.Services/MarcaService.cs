using API.Domain.Entities;
using API.Domain.Interfaces;
using API.Services.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace API.Services
{
    public class MarcaService : IMarcaService<Tbmarca>
    {
        private readonly IMarca<Tbmarca> _repository;

        public MarcaService(IMarca<Tbmarca> repository)
        {
            _repository = repository;
        }
        public async Task<bool> Delete(Tbmarca entity)
        {
            return await _repository.Delete(entity);
        }

        public async Task<bool> Exists(Tbmarca entity)
        {
            return await _repository.Exists(entity);
        }

        public async Task<Tbmarca> GetById(Tbmarca entity)
        {
            return await _repository.GetById(entity);
        }

        public async Task<IEnumerable<Tbmarca>>Get()
        {
            return await _repository.Get();
        }

        public async Task<Tbmarca> Post(Tbmarca entity)
        {
            return await _repository.Post(entity);
        }

        public async Task<Tbmarca> Put(Tbmarca entity)
        {
            return await _repository.Put(entity);
        }
    }
}
