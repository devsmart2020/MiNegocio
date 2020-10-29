using API.Domain.Entities;
using API.Domain.Interfaces;
using API.Services.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace API.Services
{
    public class ModeloService : IModeloService<Tbmodelo>
    {
        private readonly IModelo<Tbmodelo> _repository;

        public ModeloService(IModelo<Tbmodelo> repository)
        {
            _repository = repository;
        }
        public async Task<bool> Delete(Tbmodelo entity)
        {
            return await _repository.Delete(entity);
        }

        public async Task<bool> Exists(Tbmodelo entity)
        {
            return await _repository.Exists(entity);
        }

        public async Task<Tbmodelo> GetById(Tbmodelo entity)
        {
            return await _repository.GetById(entity);
        }

        public async Task<IEnumerable<Tbmodelo>>Get()
        {
            return await _repository.Get();
        }

        public async Task<Tbmodelo> Post(Tbmodelo entity)
        {
            return await _repository.Post(entity);
        }

        public async Task<Tbmodelo> Put(Tbmodelo entity)
        {
            return await _repository.Put(entity);
        }
    }
}
