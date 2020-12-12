using API.Domain.DTOs;
using API.Domain.Interfaces;
using API.Services.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace API.Services
{
    public class EstadoCompraService : IEstadoCompraService<EstadoCompraDTO>
    {
        private readonly IEstadoCompra<EstadoCompraDTO> _repository;

        public EstadoCompraService(IEstadoCompra<EstadoCompraDTO> repository)
        {
            _repository = repository;
        }

        public async Task<bool> Delete(EstadoCompraDTO entity)
        {
            return await _repository.Delete(entity);
        }

        public async Task<bool> Exists(EstadoCompraDTO entity)
        {
            return await _repository.Exists(entity);
        }

        public async Task<IEnumerable<EstadoCompraDTO>> Get()
        {
            return await _repository.Get();
        }

        public async Task<EstadoCompraDTO> GetById(EstadoCompraDTO entity)
        {
            return await _repository.GetById(entity);
        }

        public async Task<bool> Post(EstadoCompraDTO entity)
        {
            return await _repository.Post(entity);
        }

        public async Task<bool> Put(EstadoCompraDTO entity)
        {
            return await _repository.Put(entity);
        }
    }
}
