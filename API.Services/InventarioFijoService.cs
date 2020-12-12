using API.Domain.DTOs;
using API.Domain.Interfaces;
using API.Services.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace API.Services
{
    public class InventarioFijoService : IInventarioFijoService<InventarioFijoDTO>
    {
        private readonly IInventarioFijo<InventarioFijoDTO> _repository;

        public InventarioFijoService(IInventarioFijo<InventarioFijoDTO> repository)
        {
            _repository = repository;
        }
        public async Task<bool> Delete(InventarioFijoDTO entity)
        {
            return await _repository.Delete(entity);
        }

        public async Task<bool> Exists(InventarioFijoDTO entity)
        {
            return await _repository.Exists(entity);
        }

        public async Task<InventarioFijoDTO> GetById(InventarioFijoDTO entity)
        {
            return await _repository.GetById(entity);
        }

        public async Task<IEnumerable<InventarioFijoDTO>> Get()
        {
            return await _repository.Get();
        }

        public async Task<bool> Post(InventarioFijoDTO entity)
        {
            return await _repository.Post(entity);
        }

        public async Task<bool> Put(InventarioFijoDTO entity)
        {
            return await _repository.Put(entity);
        }
    }
}
