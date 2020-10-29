using API.Domain.Entities;
using API.Domain.Interfaces;
using API.Services.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace API.Services
{
    public class EstadoOrdenService : IEstadoOrdenService<Tbestadoorden>
    {
        private readonly IEstadoOrden<Tbestadoorden> _repository;

        public EstadoOrdenService(IEstadoOrden<Tbestadoorden> repository)
        {
            _repository = repository;
        }
        public async Task<bool> Delete(Tbestadoorden entity)
        {
            return await _repository.Delete(entity);
        }

        public async Task<bool> Exists(Tbestadoorden entity)
        {
            return await _repository.Exists(entity);
        }

        public async Task<Tbestadoorden> GetById(Tbestadoorden entity)
        {
            return await _repository.GetById(entity);
        }

        public async Task<IEnumerable<Tbestadoorden>>Get()
        {
            return await _repository.Get();
        }

        public async Task<Tbestadoorden> Post(Tbestadoorden entity)
        {
            return await _repository.Post(entity);
        }

        public async Task<Tbestadoorden> Put(Tbestadoorden entity)
        {
            return await _repository.Put(entity);
        }
    }
}
