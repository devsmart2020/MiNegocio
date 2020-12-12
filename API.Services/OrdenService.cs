using API.Domain.DTOs;
using API.Domain.Interfaces;
using API.Services.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace API.Services
{
    public class OrdenService : IOrdenService<OrdenDTO>
    {
        private readonly IOrden<OrdenDTO> _repository;

        public OrdenService(IOrden<OrdenDTO> repository)
        {
            _repository = repository;
        }
        public async Task<bool> Delete(OrdenDTO entity)
        {
            return await _repository.Delete(entity);
        }

        public async Task<bool> Exists(OrdenDTO entity)
        {
            return await _repository.Exists(entity);
        }

        public async Task<OrdenDTO> GetById(OrdenDTO entity)
        {
            return await _repository.GetById(entity);
        }

        public async Task<IEnumerable<OrdenDTO>> Get()
        {
            return await _repository.Get();
        }

        public async Task<bool> Post(OrdenDTO entity)
        {
            return await _repository.Post(entity);
        }

        public async Task<bool> Put(OrdenDTO entity)
        {
            return await _repository.Put(entity);
        }
    }
}
