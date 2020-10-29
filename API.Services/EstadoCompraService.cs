using API.Domain.Entities;
using API.Domain.Interfaces;
using API.Services.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace API.Services
{
    public class EstadoCompraService : IEstadoCompraService<Tbestadocompra>
    {
        private readonly IEstadoCompra<Tbestadocompra> _repository;

        public EstadoCompraService(IEstadoCompra<Tbestadocompra> repository)
        {
            _repository = repository;
        }

        public async Task<bool> Delete(Tbestadocompra entity)
        {
            return await _repository.Delete(entity);
        }

        public async Task<bool> Exists(Tbestadocompra entity)
        {
            return await _repository.Exists(entity);
        }

        public async Task<IEnumerable<Tbestadocompra>> Get()
        {
            return await _repository.Get();
        }

        public async Task<Tbestadocompra> GetById(Tbestadocompra entity)
        {
            return await _repository.GetById(entity);
        }

        public async Task<Tbestadocompra> Post(Tbestadocompra entity)
        {
            return await _repository.Post(entity);
        }

        public async Task<Tbestadocompra> Put(Tbestadocompra entity)
        {
            return await _repository.Put(entity);
        }
    }
}
