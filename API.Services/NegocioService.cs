using API.Domain.Entities;
using API.Domain.Interfaces;
using API.Services.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace API.Services
{
    public class NegocioService : INegocioService<Tbnegocio>
    {
        private readonly INegocio<Tbnegocio> _repository;

        public NegocioService(INegocio<Tbnegocio> repository)
        {
            _repository = repository;
        }

        public async Task<bool> Delete(Tbnegocio entity)
        {
            return await _repository.Delete(entity);
        }

        public async Task<bool> Exists(Tbnegocio entity)
        {
            return await _repository.Delete(entity);
        }

        public async Task<Tbnegocio> GetById(Tbnegocio entity)
        {
            return await _repository.GetById(entity);
        }

        public async Task<IEnumerable<Tbnegocio>>Get()
        {
            return await _repository.Get();
        }

        public async Task<Tbnegocio> Post(Tbnegocio entity)
        {
            return await _repository.Post(entity);
        }

        public async Task<Tbnegocio> Put(Tbnegocio entity)
        {
            return await _repository.Put(entity);
        }
    }
}
