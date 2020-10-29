using API.Domain.Entities;
using API.Domain.Interfaces;
using API.Services.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace API.Services
{
    public class TipoEquipoService : ITipoEquipoService<Tbtipoequipo>
    {
        private readonly ITipoEquipo<Tbtipoequipo> _repository;

        public TipoEquipoService(ITipoEquipo<Tbtipoequipo> repository)
        {
            _repository = repository;
        }
        public async Task<bool> Delete(Tbtipoequipo entity)
        {
            return await _repository.Delete(entity);
        }

        public async Task<bool> Exists(Tbtipoequipo entity)
        {
            return await _repository.Exists(entity);
        }

        public async Task<Tbtipoequipo> GetById(Tbtipoequipo entity)
        {
            return await _repository.GetById(entity);
        }

        public async Task<IEnumerable<Tbtipoequipo>>Get()
        {
            return await _repository.Get();
        }

        public async Task<Tbtipoequipo> Post(Tbtipoequipo entity)
        {
            return await _repository.Post(entity);
        }

        public async Task<Tbtipoequipo> Put(Tbtipoequipo entity)
        {
            return await _repository.Put(entity);
        }
    }
}
