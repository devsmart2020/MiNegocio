using API.Domain.Entities;
using API.Domain.Interfaces;
using API.Services.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace API.Services
{
    public class OrdenService :  IOrdenService<Tborden>
    {
        private readonly IOrden<Tborden> _repository;

        public OrdenService(IOrden<Tborden> repository)
        {
            _repository = repository;
        }
        public async Task<bool> Delete(Tborden entity)
        {
            return await _repository.Delete(entity);
        }

        public async Task<bool> Exists(Tborden entity)
        {
            return await _repository.Exists(entity);
        }

        public async Task<Tborden> GetById(Tborden entity)
        {
            return await _repository.GetById(entity);
        }

        public async Task<IEnumerable<Tborden>>Get()
        {
            return await _repository.Get();
        }

        public async Task<Tborden> Post(Tborden entity)
        {
            return await _repository.Post(entity);
        }

        public async Task<Tborden> Put(Tborden entity)
        {
            return await _repository.Put(entity);
        }
    }
}
