using API.Domain.DTOs;
using API.Domain.Interfaces;
using API.Services.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace API.Services
{
    public class ServicioService : IServicioService<ServicioDTO>
    {
        private readonly IServicio<ServicioDTO> _repository;

        public ServicioService(IServicio<ServicioDTO> repository)
        {
            _repository = repository;
        }
        public async Task<bool> Delete(ServicioDTO entity)
        {
            return await _repository.Delete(entity);
        }

        public async Task<bool> Exists(ServicioDTO entity)
        {
            return await _repository.Exists(entity);
        }

        public async Task<ServicioDTO> GetById(ServicioDTO entity)
        {
            return await _repository.GetById(entity);
        }

        public async Task<IEnumerable<ServicioDTO>> Get()
        {
            return await _repository.Get();
        }

        public async Task<bool> Post(ServicioDTO entity)
        {
            return await _repository.Post(entity);
        }

        public async Task<bool> Put(ServicioDTO entity)
        {
            return await _repository.Put(entity);
        }
    }
}
