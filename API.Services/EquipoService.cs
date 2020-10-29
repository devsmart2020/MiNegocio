using API.Domain.Entities;
using API.Domain.Interfaces;
using API.Services.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace API.Services
{
    public class EquipoService : IEquipoService<Tbequipo>
    {
        private readonly IEquipo<Tbequipo> _repository;

        public EquipoService(IEquipo<Tbequipo> repository)
        {
            _repository = repository;
        }
        public async Task<bool> Delete(Tbequipo entity)
        {
            return await _repository.Delete(entity);
        }

        public async Task<bool> Exists(Tbequipo entity)
        {
            return await _repository.Exists(entity);
        }

        public async Task<Tbequipo> GetById(Tbequipo entity)
        {
            return await _repository.GetById(entity);
        }

        public async Task<IEnumerable<Tbequipo>>Get()
        {
            return await _repository.Get();
        }

        public async Task<Tbequipo> Post(Tbequipo entity)
        {
            return await _repository.Post(entity);
        }

        public async Task<Tbequipo> Put(Tbequipo entity)
        {
            return await _repository.Put(entity);
        }
    }
}
