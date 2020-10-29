using API.Domain.Entities;
using API.Domain.Interfaces;
using API.Services.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace API.Services
{
    public class EgresoService : IEgresoService<Tbegreso>
    {
        private readonly IEgreso<Tbegreso> _repository;

        public EgresoService(IEgreso<Tbegreso> repository)
        {
            _repository = repository;
        }
        public async Task<bool> Delete(Tbegreso entity)
        {
            return await _repository.Delete(entity);
        }

        public async Task<bool> Exists(Tbegreso entity)
        {
            return await _repository.Exists(entity);
        }

        public async Task<Tbegreso> GetById(Tbegreso entity)
        {
            return await _repository.GetById(entity);
        }

        public async Task<IEnumerable<Tbegreso>>Get()
        {
            return await _repository.Get();
        }

        public async Task<Tbegreso> Post(Tbegreso entity)
        {
            return await _repository.Post(entity);
        }

        public async Task<Tbegreso> Put(Tbegreso entity)
        {
            return await _repository.Put(entity);
        }
    }

}
