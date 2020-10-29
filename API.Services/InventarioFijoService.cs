using API.Domain.Entities;
using API.Domain.Interfaces;
using API.Services.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace API.Services
{
    public class InventarioFijoService : IInventarioFijoService<Tbinventariofijo>
    {
        private readonly IInventarioFijo<Tbinventariofijo> _repository;

        public InventarioFijoService(IInventarioFijo<Tbinventariofijo> repository)
        {
            _repository = repository;
        }
        public async  Task<bool> Delete(Tbinventariofijo entity)
        {
            return await _repository.Delete(entity);
        }

        public async Task<bool> Exists(Tbinventariofijo entity)
        {
            return await _repository.Exists(entity);
        }

        public async Task<Tbinventariofijo> GetById(Tbinventariofijo entity)
        {
            return await _repository.GetById(entity);
        }

        public async Task<IEnumerable<Tbinventariofijo>>Get()
        {
            return await _repository.Get();
        }

        public async Task<Tbinventariofijo> Post(Tbinventariofijo entity)
        {
            return await _repository.Post(entity);
        }

        public async Task<Tbinventariofijo> Put(Tbinventariofijo entity)
        {
            return await _repository.Put(entity);
        }
    }
}
