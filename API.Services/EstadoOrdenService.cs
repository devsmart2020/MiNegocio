using API.Domain.DTOs;
using API.Domain.Interfaces;
using API.Services.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace API.Services
{
    public class EstadoOrdenService : IEstadoOrdenService<EstadoOrdenDTO>
    {
        private readonly IEstadoOrden<EstadoOrdenDTO> _repository;

        public EstadoOrdenService(IEstadoOrden<EstadoOrdenDTO> repository)
        {
            _repository = repository;
        }
        public async Task<bool> Delete(EstadoOrdenDTO entity)
        {
            return await _repository.Delete(entity);
        }

        public async Task<bool> Exists(EstadoOrdenDTO entity)
        {
            return await _repository.Exists(entity);
        }

        public async Task<EstadoOrdenDTO> GetById(EstadoOrdenDTO entity)
        {
            return await _repository.GetById(entity);
        }

        public async Task<IEnumerable<EstadoOrdenDTO>> Get()
        {
            return await _repository.Get();
        }

        public async Task<bool> Post(EstadoOrdenDTO entity)
        {
            return await _repository.Post(entity);
        }

        public async Task<bool> Put(EstadoOrdenDTO entity)
        {
            return await _repository.Put(entity);
        }
    }
}
